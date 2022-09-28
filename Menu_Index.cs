using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1
{
    /// <summary>
    /// Form for taking order and generating summary
    /// </summary>
    public partial class Menu_Index : Form
    {
        /// <summary>
        /// Database instance for quicker access
        /// </summary>
        private readonly Database m_DBInstance;
        /// <summary>
        /// RuntimeData instance for quicker access
        /// </summary>
        private readonly RuntimeData m_RTInstance;
        /// <summary>
        /// A zero integer in string type
        /// </summary>
        private readonly string m_ZeroString = 0.ToString();

        /// <summary>
        /// Called by Winform, initialize all visual elements and data reuired by the form
        /// </summary>
        /// <remarks>
        /// This function does the following:<br />
        /// - Generate tooltip for <see cref="OrderBtn"/>, <see cref="ClrBtn"/>, <see cref="SummaryBtn"/> , and <see cref="ExitBtn"/> button<br />
        /// - Initialize the instance to <see cref="Database"/> and <see cref="RuntimeData"/><br />
        /// - Use data from <see cref="Database"/> to initialize four menu name, and price<br />
        /// - Disable <see cref="OrderSumPannel"/> and <see cref="CompanySumPannel"/><br />
        /// - Conditionaly enable <see cref="SummaryBtn"/> if there are histroy transaction (orders) exists
        /// </remarks>
        public Menu_Index()
        {
            InitializeComponent();

            GenerateToolTip(OrderBtn, "Record New Order");
            GenerateToolTip(ClrBtn, "Clear Form for New Order");
            GenerateToolTip(SummaryBtn, "Get Summary of Orders");
            GenerateToolTip(ExitBtn, "Exit Application");

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

        /// <summary>
        /// Generate <see cref="ToolTip"/> for given <see cref="Button"/>
        /// </summary>
        /// <param name="control">The button to assign tooltip</param>
        /// <param name="text">The text displayed by the tooltip</param>
        /// <remarks>
        /// The <see cref="ToolTip"/> is Ballon styled, and has an Info icon and title displayed "Info"
        /// </remarks>
        private static void GenerateToolTip(Button control, string text)
        {
            var toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info";
            toolTip.SetToolTip(control, $"Press to {text}");
        }

        /// <summary>
        /// Formats the given price into price tag forms
        /// </summary>
        /// <param name="price">Price to format</param>
        /// <returns>
        /// Formated price tag
        /// </returns>
        /// <remarks>
        /// When input is: 18.9444<br />
        /// The output is: @€18.94
        /// </remarks>
        private static string FormatPriceTag(decimal price) => $"@{FormatPrice(price)}";

        /// <summary>
        /// Prepends a "€" mark to the given price
        /// </summary>
        /// <param name="price">Price to format</param>
        /// <returns>
        /// Formated price
        /// </returns>
        /// <remarks>
        /// When input is: 18.9444<br />
        /// The output is: €18.94
        /// </remarks>
        private static string FormatPrice(decimal price) => $"€{Math.Round(price, 2)}";

        /// <summary>
        /// Parse the value entered into the <see cref="TextBox.Text"/>, if the value is not a valid integer, reset it into 0 and pop up an error message
        /// </summary>
        /// <param name="textBox">TextBox to check</param>
        /// <param name="errorMessageName">Error message to display when the input is not a valid integer</param>
        /// <param name="value">The integer parsed</param>
        /// <returns>Does the input text successufuly converted into integer</returns>
        private bool ParseAndCorrectTextBoxValue(TextBox textBox, string errorMessageName, out int value)
        {
            if (int.TryParse(textBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value) && value >= 0)
            {
                return true;
            }
            else
            {
                textBox.Text = m_ZeroString;
                MessageBox.Show($"Please enter numerical data for {errorMessageName}'s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Called when clicking <see cref="OrderBtn"/>, check any input format error, if not, set visible and write order info on to <see cref="OrderSumPannel"/>
        /// </summary>
        /// <remarks>
        /// This function does the following:<br />
        /// - Check input format error on <see cref="MenuCount1"/>, <see cref="MenuCount2"/>, <see cref="MenuCount3"/>, and <see cref="MenuCount4"/><br />
        /// -- If any of which has an format error, pop up error dialog for each one then abort<br />
        /// -- Abort if the sum of all item is zero<br />
        /// - Otherwise, adds the current order info into <see cref="m_RTInstance"/> through <see cref="RuntimeData.AddHistorySales(Dictionary{string, int})"/>
        /// - Calculate and display the order result
        /// </remarks>
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            var test1Result = ParseAndCorrectTextBoxValue(MenuCount1, MenuItem1.Text, out var menuItem1Price);
            var test2Result = ParseAndCorrectTextBoxValue(MenuCount2, MenuItem2.Text, out var menuItem2Price);
            var test3Result = ParseAndCorrectTextBoxValue(MenuCount3, MenuItem3.Text, out var menuItem3Price);
            var test4Result = ParseAndCorrectTextBoxValue(MenuCount4, MenuItem4.Text, out var menuItem4Price);

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

            m_RTInstance.AddHistorySales(dictionary);

            NumberPizzaOrderedDisplay.Text = dictionary.Values.Sum().ToString();
            TotalTableReciptsDisplay.Text = $"€{Math.Round(dictionary.Select(x => m_DBInstance.GetPrice(x.Key, x.Value)).Sum(), 2)}";
            SummaryBtn.Enabled = true;

        }

        /// <summary>
        /// Called when clicking <see cref="ClrBtn"/>, clearing inputed order number on all items, and hide visible <see cref="OrderSumPannel"/> or <see cref="CompanySumPannel"/> if any
        /// </summary>
        private void ClrBtn_Click(object sender, EventArgs e)
        {
            MenuCount1.Text = m_ZeroString;
            MenuCount2.Text = m_ZeroString;
            MenuCount3.Text = m_ZeroString;
            MenuCount4.Text = m_ZeroString;
            OrderSumPannel.Visible = false;
            CompanySumPannel.Visible = false;
        }

        /// <summary>
        /// Called when clicking <see cref="SummaryBtn"/>, hide visible <see cref="OrderSumPannel"/> if any, then calculate and display summary data on <see cref="CompanySumPannel"/>
        /// </summary>
        private void SummaryBtn_Click(object sender, EventArgs e)
        {
            OrderSumPannel.Visible = false;

            CompTransDisplay.Text = m_RTInstance.GetTransactionCounts().ToString();
            NumPizzaTotalDisplay.Text = m_RTInstance.GetPizzaOrderedCounts().ToString();
            TotalCompanyReceDisplay.Text = FormatPrice(m_RTInstance.GetPizzaTotalRecepts());
            AvgTransDisplay.Text = FormatPrice(m_RTInstance.GetAVGTransaction());
            
            CompanySumPannel.Visible = true;
        }

        /// <summary>
        /// Called when clicking <see cref="ExitBtn"/>
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
