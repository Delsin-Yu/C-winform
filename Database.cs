using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1
{
    /// <summary>
    /// Singleton RuntimeData for storing the info generate when using the application
    /// </summary>
    public class RuntimeData : Singleton<RuntimeData>
    {
        /// <summary>
        /// Current logged in server name
        /// </summary>
        public string server_name;
        /// <summary>
        /// Current logged in table number
        /// </summary>
        public int table_number;

        /// <summary>
        /// All Sales during the use of the application
        /// </summary>
        /// <remarks>
        /// This never resets unless the application is closed
        /// </remarks>
        private readonly Queue<Dictionary<string, int>> m_HistorySales = new Queue<Dictionary<string, int>>();

        /// <summary>
        /// Record the data from one order session into the runtime db
        /// </summary>
        /// <param name="data">Data from one order session</param>
        public void AddHistorySales(Dictionary<string, int> data) => m_HistorySales.Enqueue(data);

        /// <summary>
        /// Get total transaction count during the use of application
        /// </summary>
        /// <returns>
        /// Total transaction during the use of the application
        /// </returns>
        /// <remarks>
        /// This value is THE combined transaction counts accross all user of this instance of application, the data does not resets when the user close <see cref="Menu_Index"/>
        /// </remarks>
        public int GetTransactionCounts() => m_HistorySales.Count;

        /// <summary>
        /// Get total pizza order count during the use of application
        /// </summary>
        /// <returns>
        /// Total pizza order during the use of the application
        /// </returns>
        /// <remarks>
        /// This value is THE combined pizza order counts accross all user of this instance of application, the data does not resets when the user close <see cref="Menu_Index"/>
        /// </remarks>
        public int GetPizzaOrderedCounts() => m_HistorySales.SelectMany(x => x.Select(y => y.Value)).Sum();

        /// <summary>
        /// Get total pizza recepts during the use of application
        /// </summary>
        /// <returns>
        /// Total pizza recepts during the use of the application
        /// </returns>
        /// <remarks>
        /// This value is THE combined pizza recepts accross all user of this instance of application, the data does not resets when the user close <see cref="Menu_Index"/>
        /// </remarks>
        public decimal GetPizzaTotalRecepts()
        {
            var dbInstance = Database.Instance;
            return m_HistorySales.SelectMany(x => x.Select(y => dbInstance.GetPrice(y.Key, y.Value))).Sum();
        }

        /// <summary>
        /// Get average transaction value during the use of application
        /// </summary>
        /// <returns>
        /// Average transaction value during the use of the application
        /// </returns>
        /// <remarks>
        /// This value is THE average transaction value accross all user of this instance of application, the data does not resets when the user close <see cref="Menu_Index"/>
        /// </remarks>
        public decimal GetAVGTransaction() => GetPizzaTotalRecepts() / GetTransactionCounts();
    }

    /// <summary>
    /// Singleton Database for storing price information
    /// </summary>
    public class Database : Singleton<Database>
    {
        private readonly Dictionary<string, decimal> m_Price;

        /// <summary>
        /// Initialize Database
        /// </summary>
        public Database() => m_Price = new Dictionary<string, decimal>()
            {
                { "Ham Pizza", 7.99m },
                { "Pepperoni Pizza", 8.99m },
                { "Pineapple Pizza", 9.99m },
                { "Calzoni", 11.99m }
            };

        /// <summary>
        /// Get the price by a given item name
        /// </summary>
        /// <param name="itemName">The item name for checking</param>
        /// <param name="orderCount">The number of item ordered</param>
        /// <returns>
        /// The combined price for the given item
        /// </returns>
        /// <remarks>
        /// This function returns 0 if the item is not present or the orderCount is 0
        /// </remarks>
        public decimal GetPrice(string itemName, int orderCount) => m_Price.TryGetValue(itemName, out var price) ? price * orderCount : 0;

        /// <summary>
        /// Get the price and item name by given index
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>
        /// A <see cref="ValueTuple{String, Decimal}"/> of item name and item price
        /// </returns>
        /// <exception cref="IndexOutOfRangeException">
        /// Throws when the index exceeds the maxinum <see cref="Dictionary{TKey, TValue}.Count"/> of <see cref="m_Price"/>
        /// </exception>
        public (string ItemName, decimal ItemPrice) GetInfoAtIndex(int index)
        {
            try
            {
                var data = m_Price.ElementAt(index);
                return (data.Key, data.Value);
            }
            catch
            {
                throw new IndexOutOfRangeException($"The given index ({index}) is outside of the Price Database Rage ({m_Price.Count})");
            }
        }
    }

    /// <summary>
    /// Singleton bass class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
