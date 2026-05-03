using MySql.Data.MySqlClient;
using Saria_EDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARIA_EDP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MyDatabase db = new MyDatabase();

        string[,] userCredentials =
        {
            { "admin", "admin", "Gianne Kharla Saria" },
            { "cashier", "password", "hatdog" }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected to Database");
            }
            else
            {
                MessageBox.Show("Database Connection Failed!");
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }
            else
            {
                DataTable dt = db.ExecuteReturnQuery("SELECT * from tblLoginCredentials WHERE user_username = @uname and user_password = @pword;",
                    new MySqlParameter("@uname", tbUsername.Text),
                    new MySqlParameter("@pword", tbPassword.Text));

                if (dt.Rows.Count == 1)
                {
                    Dashboard frm = new Dashboard();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }



               
            }   
        }
    }
}


