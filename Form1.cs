using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string result;
        bool prerequsiteClear;
        string selectedSubject;
        string[] courses = { "Algo", "DSA","Theory Of Automata", "Mobile Application Development", "Enterprise Application Development" };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(courses);
        }
        private void button1_Click(object sender, EventArgs e)
        {
             firstName=textBox1.Text.Trim();
             lastName = textBox2.Text.Trim(); 

             if(comboBox1.SelectedItem!=null)
            {
                selectedSubject= comboBox1.SelectedItem.ToString();

            }
            else
            {
                selectedSubject = string.Empty;
            }

            prerequsiteClear = checkBox1.Checked;
            firstName = Regex.Replace(firstName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
            lastName = Regex.Replace(lastName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);

            result = "";
           
            if (prerequsiteClear)
            {
                result = $"Registration Successful!{Environment.NewLine} First Name: {firstName}{Environment.NewLine}Last Name: {lastName}{Environment.NewLine}Subject: {selectedSubject}{Environment.NewLine}Prerequisite Clear: {prerequsiteClear}";
            }
            else
            {
                result = "Please clear the prerequisites for " + selectedSubject + " before registering.";
            }

            label5.Text = result;





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
