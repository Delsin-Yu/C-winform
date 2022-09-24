using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment_1
{
    public partial class Meun_Index : Form
    {
        public Meun_Index()
        {
            InitializeComponent();
            Text = Database.database.meun_name_number;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Meun_Index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meun_Index meun_index = new Meun_Index();
            meun_index.button_Order_6_TextChanged(this, new EventArgs());
           
        }

        private void button_Order_1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button_Order_5_TextChanged(object sender, EventArgs e)
        {
            Meun_Index meun_Index = new Meun_Index();
            InitializeComponent();
            button_Order_5.Text = Database.database.service_name;
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string x = textBox2.Text;
            int X = int.Parse(x);
            Database.database.number_ordered = X;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string x = textBox3.Text;
            int X = int.Parse(x);
            Database.database.number_ordered += X;
        }

        public void button_Order_6_TextChanged(object sender, EventArgs e)
        {
            Meun_Index meun_Index = new Meun_Index();
            InitializeComponent();
            button_Order_6.Text = Convert.ToString(Database.database.number_ordered);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string x = textBox4.Text;
            int X = int.Parse(x);
            Database.database.number_ordered += X;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string x = textBox5.Text;
            int X = int.Parse(x);
            Database.database.number_ordered += X;
        }
    }
}
