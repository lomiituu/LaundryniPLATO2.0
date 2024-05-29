using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class LoginHomepage : Form
    {
        public LoginHomepage()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            
            string userName = Username.Text;
            string passWord = Password.Text;
            userName = "admin123";
            passWord = "admin1005";

            if (Username.Text == userName && Password.Text == passWord)
            {
                MessageBox.Show("Log In Successfully");
                DB.Show();
                this.Hide();

            }
            else

                MessageBox.Show("Invalid username or password. Please try again");
            }





           
        }

       
    }

