using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        HotelDataEntities connectdata = new HotelDataEntities();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btemployee.Checked || btlabor.Checked)
                {
                    if (connectdata.AccountEmployees.Where(r => r.Username == txtusername.Text && r.Password == txtpassword.Text).Count() > 0)
                    {
                        MessageBox.Show("Login Successfully");
                        EmployeeMenuForm employeeMenuForm = new EmployeeMenuForm();
                        employeeMenuForm.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                else if (btnadmin.Checked)
                {
                    if (txtusername.Text == "admin" && txtpassword.Text == "admin")
                    {
                        MessageBox.Show("Login Successfully");
                        AdminMenu admin = new AdminMenu();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (btnmanager.Checked)
                {
                    if (connectdata.AccountManagers.Where(r => r.UserName == txtusername.Text && r.Password == txtpassword.Text).Count() > 0)
                    {
                        MessageBox.Show("Login Successfully");
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Please Choose Role Before Login", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
