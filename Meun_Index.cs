using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Meun_Index : Form
    {
        private readonly Database m_DBInstance;
        private readonly RuntimeData m_RTInstance;
        private readonly string m_ZeroString = 0.ToString();

        public Meun_Index()
        {
            InitializeComponent();

            m_DBInstance = Database.Instance;
            m_RTInstance = RuntimeData.Instance;

            base.Text = $"{m_RTInstance.server_name} @ Table {m_RTInstance.table_number}";
            ServerNameDisplay.Text = m_RTInstance.server_name;

            var (data1Name, data1Price) = m_DBInstance.GetInfoAtIndex(0);
            var (data2Name, data2Price) = m_DBInstance.GetInfoAtIndex(1);
            var (data3Name, data3Price) = m_DBInstance.GetInfoAtIndex(2);
            var (data4Name, data4Price) = m_DBInstance.GetInfoAtIndex(3);

            MenuItem1.Text = data1Name;
            MenuItem2.Text = data2Name;
            MenuItem3.Text = data3Name;
            MenuItem4.Text = data4Name;

            MenuPrice1.Text = FormatPriceTag(data1Price);
            MenuPrice2.Text = FormatPriceTag(data2Price);
            MenuPrice3.Text = FormatPriceTag(data3Price);
            MenuPrice4.Text = FormatPriceTag(data4Price);

            OrderSumPannel.Visible = false;
            CompanySumPannel.Visible = false;

            SummaryBtn.Enabled = m_RTInstance.GetTransactionCounts() > 0;
        }

        private static string FormatPriceTag(decimal price) => $"@{FormatPrice(price)}";
        private static string FormatPrice(decimal price) => $"€{Math.Round(price, 2)}";


        private bool ParseTextBoxValue(TextBox textBox, string key, out int value)
        {
            if (int.TryParse(textBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value) && value >= 0)
            {
                return true;
            }
            else
            {
                textBox.Text = m_ZeroString;
                MessageBox.Show($"Please enter numerical data for {key}'s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            var test1Result = ParseTextBoxValue(MenuCount1, MenuItem1.Text, out var menuItem1Price);
            var test2Result = ParseTextBoxValue(MenuCount2, MenuItem2.Text, out var menuItem2Price);
            var test3Result = ParseTextBoxValue(MenuCount3, MenuItem3.Text, out var menuItem3Price);
            var test4Result = ParseTextBoxValue(MenuCount4, MenuItem4.Text, out var menuItem4Price);

            if (!test1Result || !test2Result || !test3Result || !test4Result)
            {
                return;
            }

            if (menuItem1Price + menuItem2Price + menuItem3Price + menuItem4Price == 0)
            {
                return;
            }


            OrderSumPannel.Visible = true;
            var dictionary = new Dictionary<string, int>
            {
                { MenuItem1.Text, menuItem1Price},
                { MenuItem2.Text, menuItem2Price},
                { MenuItem3.Text, menuItem3Price},
                { MenuItem4.Text, menuItem4Price }
            };

            NumberPizzaOrderedDisplay.Text = dictionary.Values.Sum().ToString();
            TotalTableReciptsDisplay.Text = $"€{Math.Round(dictionary.Select(x => m_DBInstance.GetPrice(x.Key, x.Value)).Sum(), 2)}";

            m_RTInstance.AddHistorySales(dictionary);
            SummaryBtn.Enabled = true;
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            MenuCount1.Text = m_ZeroString;
            MenuCount2.Text = m_ZeroString;
            MenuCount3.Text = m_ZeroString;
            MenuCount4.Text = m_ZeroString;
            OrderSumPannel.Visible = false;
            CompanySumPannel.Visible = false;
        }

        private void SummaryBtn_Click(object sender, EventArgs e)
        {
            OrderSumPannel.Visible = false;
            CompanySumPannel.Visible = true;

            CompTransDisplay.Text = m_RTInstance.GetTransactionCounts().ToString();
            NumPizzaTotalDisplay.Text = m_RTInstance.GetPizzaOrderedCounts().ToString();
            TotalCompanyReceDisplay.Text = FormatPrice(m_RTInstance.GetPizzaTotalRecepts());
            AvgTransDisplay.Text = FormatPrice(m_RTInstance.GetAVGTransaction());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
