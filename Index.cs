using System;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Index : Form
    {
        public Index() => InitializeComponent();

        private int m_TableNumber;

        private void Form1_Load(object sender, EventArgs e) => ValifyStartBtnState();

        private void Start_Click(object sender, EventArgs e)
        {
            RuntimeData.Instance.server_name = Server_Name.Text;
            RuntimeData.Instance.table_number = m_TableNumber;

            var menu_index = new Meun_Index();
            menu_index.Show();
        }

        private void Server_Name_TextChanged(object sender, EventArgs e) => ValifyStartBtnState();

        private void Table_Number_TextChanged(object sender, EventArgs e) => ValifyStartBtnState();

        private void ValifyStartBtnState() => Start.Enabled = !(string.IsNullOrWhiteSpace(Server_Name.Text) || string.IsNullOrWhiteSpace(Table_Number.Text) || !int.TryParse(Table_Number.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out m_TableNumber));
    }
}
