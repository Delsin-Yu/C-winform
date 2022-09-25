using System.Collections.Generic;
using System.Linq;

namespace Assignment_1
{
    public class RuntimeData : Singleton<RuntimeData>
    {
        public string server_name;
        public int table_number;
        public int number_ordered;

        private readonly Queue<Dictionary<string, int>> m_HistorySales = new Queue<Dictionary<string, int>>();

        public void AddHistorySales(Dictionary<string, int> data) => m_HistorySales.Enqueue(data);

        public int GetTransactionCounts() => m_HistorySales.Count;
        public int GetPizzaOrderedCounts() => m_HistorySales.SelectMany(x => x.Select(y => y.Value)).Sum();
        public decimal GetPizzaTotalRecepts()
        {
            var dbInstance = Database.Instance;
            return m_HistorySales.SelectMany(x => x.Select(y => dbInstance.GetPrice(y.Key, y.Value))).Sum();
        }
        public decimal GetAVGTransaction() => GetPizzaTotalRecepts() / GetTransactionCounts();
    }

    public class Database : Singleton<Database>
    {
        private readonly Dictionary<string, decimal> m_Price;
        public Database() => m_Price = new Dictionary<string, decimal>()
            {
                { "Ham Pizza", 7.99m },
                { "Pepperoni Pizza", 8.99m },
                { "Pineapple Pizza", 9.99m },
                { "Calzoni", 11.99m }
            };

        public decimal GetPrice(string pizzaName, int orderCount) => m_Price.TryGetValue(pizzaName, out var price) ? price * orderCount : 0;

        public (string ItemName, decimal ItemPrice) GetInfoAtIndex(int index)
        {
            var data = m_Price.ElementAt(index);
            return (data.Key, data.Value);
        }
    }

    public abstract class Singleton<T> where T : class, new()
    {
        private static T s_Instance;
        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new T();
                }
                return s_Instance;
            }
        }

    }
}
