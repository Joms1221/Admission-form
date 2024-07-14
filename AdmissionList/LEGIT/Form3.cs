using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace LEGIT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private int Counter = 0;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter++;
            int studentID = Counter;
            string firstName = Fname.Text;
            string lastname = Lastname.Text;
            string middlename = Middleinitial.Text;
            string birthDate = Birthday.Value.ToString("yyyy-MM-dd");
            string gender = male.Checked ? "Male" : "Female";
            string number = Phonenumber.Text;
            string email = Emailadd.Text;
            string address = Completeadd.Text;
            string zipcode = Zipcode.Text;
            string contact = Emergency.Text;
            string studentdata = $"{firstName} , {lastname} , {middlename} , {birthDate} , {gender} , {number},{email} , {address} , {zipcode} , {contact}";
            File.AppendAllText("student_data.txt", studentdata + Environment.NewLine);
            string basicInfo = $"{studentID},{firstName},{address},{contact},{number},{zipcode}";
            File.AppendAllText("Students_Data.txt", basicInfo + Environment.NewLine);
            MessageBox.Show("Saved Successfully");

        }   
    }
}
