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

namespace Reading_A_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string[] studentInfo = new string[] {
                    "Student No.: " + txtbStudentNo.Text,
                    "Full Name : " + txtboxLastName.Text + " " + txtboxFname.Text + " "+ txtboxMi.Text,
                    "Program: " + cbProgram.SelectedItem.ToString(),
                    "Gender: " + cbGender.SelectedItem.ToString(),
                    "Age: " +   txtboxAge.Text,
                    "Birthday: " + dateTimePicker1.Value.ToShortDateString(),
                    "Contact: " + txtContact.Text
                };

            string filename = txtbStudentNo.Text + ".txt";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (string info in studentInfo)
                {
                    writer.WriteLine(info);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.SelectedIndex = -1;

            cbProgram.Items.Add("Information Technology");
            cbProgram.Items.Add("Tourism");
            cbProgram.Items.Add("Psychology");
            cbProgram.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmStudentRecord().Show();
        }
    }
}
