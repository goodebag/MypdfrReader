using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.IO;

namespace My_Pdf_Reader
{
    public partial class Form1 : Form
    {
        SignUpAndSignIn USERsignPANEL = new SignUpAndSignIn();
        public Form1()
        {
            InitializeComponent();
            gunaButton3.Enabled = false;
            gunaButton2.Enabled = false;
        }

        private void ImageMover(object sender)
        {
            GunaButton c = (GunaButton)sender;
            SlidePicture.Location = new Point(c.Location.X + 27, c.Location.Y - 8);
            SlidePicture.SendToBack();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            ImageMover(sender);
        }

        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Normal))
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState.Equals(FormWindowState.Maximized))
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        //closes the form when clicked
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Resizes the form
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Normal))
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState.Equals(FormWindowState.Maximized))
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            USERsignPANEL.SignupPanel.Visible = false;
            USERsignPANEL.signupButton.Visible = false;
            addusercontrol(USERsignPANEL, panel3);
            gunaButton2.Enabled = true;
            SlidePicture.Location = SlidePicture.Location = new Point(gunaButton2.Location.X + 27, gunaButton2.Location.Y - 8);
            SlidePicture.SendToBack();
        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            USERsignPANEL.signinButton.Visible = false;
            addusercontrol(USERsignPANEL, panel3);
            gunaButton2.Enabled = true;
        }

        private void gunaButton1_DoubleClick(object sender, EventArgs e)
        {
            PDF_Libary _Libary = new PDF_Libary();
            addusercontrol(_Libary, panel3);
            _Libary.GetallPdfs();
        }
    }
}
