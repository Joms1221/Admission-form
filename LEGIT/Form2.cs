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
        private string filepath = "student_data.txt";
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            string filepath = "Students_data.txt";
            using (StreamWriter writer = new StreamWriter(filepath))
            {

                writer.WriteLine("StudentId , Fullname , Address , GuardianName , PhoneNumber , Status");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (!row.IsNewRow) 
                    { 
                        string studentId = row.Cells[0].Value.ToString();
                        string fullName = row.Cells[1].Value.ToString();
                        string address = row.Cells[2].Value.ToString();
                        string guardianName = row.Cells[3].Value.ToString();
                        string phoneNumber = row.Cells[4].Value.ToString();
                        string status = row.Cells[5].Value.ToString();  
                        writer.WriteLine($"{studentId},{fullName},{address},{guardianName},{phoneNumber},{status}");
                    }
                    MessageBox.Show("Data saved successfully.");
                
            }

            }


            
        }
    }
}