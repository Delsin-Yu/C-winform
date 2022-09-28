using System;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment_1
{
    /// <summary>
    /// Form for login
    /// </summary>
    public partial class Index : Form
    {
        /// <summary>
        /// Current parsed table number, parsed from <see cref="Table_Number"/>
        /// </summary>
        private int m_TableNumber;

        /// <summary>
        /// Called by Winform, initialize visual elements
        /// </summary>
        public Index() => InitializeComponent();

        /// <summary>
        /// Called by Winform, update start button state
        /// </summary>
        private void Form1_Load(object sender, EventArgs e) => ValifyStartBtnState();

        /// <summary>
        /// Called when clicking start btn, collect the server name and table number then launch the order screen 
        /// </summary>
        /// <remarks>
        /// The Server Name is collected from <see cref="Server_Name"/> and the Table Number is collected from <see cref="m_TableNumber"/>
        /// </remarks>
        private void Start_Click(object sender, EventArgs e)
        {
            RuntimeData.Instance.server_name = Server_Name.Text;
            RuntimeData.Instance.table_number = m_TableNumber;

            var menu_index = new Menu_Index();
            menu_index.Show();
        }

        /// <summary>
        /// Called when user updated the text in <see cref="Server_Name"/>, update start button state
        /// </summary>
        private void Server_Name_TextChanged(object sender, EventArgs e) => ValifyStartBtnState();

        /// <summary>
        /// Called when user updated the text in <see cref="Table_Number"/>, update start button state
        /// </summary>
        private void Table_Number_TextChanged(object sender, EventArgs e) => ValifyStartBtnState();

        /// <summary>
        /// Check and ensure the server name and table number from user input is valid before allowing user to press the <see cref="Start"/> button.
        /// </summary>
        /// <remarks>
        /// This function checks the following:<br />
        /// <see cref="TextBox.Text"/> under <see cref="Server_Name"/> is not Null or WhiteSpace<br />
        /// <see cref="TextBox.Text"/> under <see cref="Table_Number"/> is not Null or WhiteSpace and is Valid Integer (and the successfully parsed integer will be stored in <see cref="m_TableNumber"/>)
        /// </remarks>
        private void ValifyStartBtnState() => Start.Enabled = !(string.IsNullOrWhiteSpace(Server_Name.Text) || string.IsNullOrWhiteSpace(Table_Number.Text) || !int.TryParse(Table_Number.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out m_TableNumber));
    }
}
