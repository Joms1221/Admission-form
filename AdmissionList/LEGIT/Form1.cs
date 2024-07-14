using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LEGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string file = "login_data.txt";

            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);
                bool a = lines.Any(line => line == $"{username}:{password}");

                if (a)
                {
                    MessageBox.Show("Login successful.");
                    var form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("No signup data found.");
            }
        }
    }
}
