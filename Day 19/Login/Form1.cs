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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_btn_click(object sender, EventArgs e)
        {

            string username = Username_txt.Text;
            string password = Password_txt.Text;
            Console.WriteLine(username + " " + password);

            string original_name = "Yadhu";
            string original_password = "Yadhu@123";

            if (original_name != username)
            {
                MessageBox.Show("Invalid username ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (original_password != password)
            {
                MessageBox.Show("Invalid Password ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Remember_me_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
