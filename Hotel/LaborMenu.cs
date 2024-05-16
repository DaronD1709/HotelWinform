using Hotel.CheckInOutFolder;
using Hotel.InventoryFolder;
using Hotel.ManagerFolder;
using Hotel.SalaryFolder;
using Hotel.ScheduleFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class LaborMenu : Form
    {

        private bool isCollapsed;
        private bool ismenu;
        private Form currentChildForm;
        public LaborMenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel5.Height += 10;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                panel1.Width += 15;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel1.Width -= 15;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InOut());
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TakeItems());
        }

        private void buttonschedual_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleTable());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalaryEmployee());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InfoAccount infoAccount = new InfoAccount();
            infoAccount.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
        }
    }
}
