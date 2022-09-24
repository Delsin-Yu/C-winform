using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Database.database.service_name = Server_Name.Text;
            Database.database.table_number = Table_Number.Text;
            Database.database.meun_name_number = Database.database.service_name + '@' + Database.database.table_number;

            Meun_Index menu_index = new Meun_Index();  
            menu_index.Show();
    


        }

        private void Server_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
