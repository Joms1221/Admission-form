using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LEGIT
{
    public partial class Form2 : Form
    {
        private string Filepath = "Students_data.txt";
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
             if (File.Exists(Filepath))
                {
                    var lines = File.ReadAllLines(Filepath);
                    if (lines.Length > 0)
                    {
                        for (int i = 1; i < lines.Length; i++)
                        {
                            var data = lines[i].Split(',');
                            dataGridView1.Rows.Add(data);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File not found: " + Filepath);
                }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    
        private void button4_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
    }
}