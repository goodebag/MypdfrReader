using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace My_Pdf_Reader
{
    public partial class SignUpAndSignIn : UserControl
    {
        PDF_Libary Libary = new PDF_Libary();
        public SignUpAndSignIn()
        {
            InitializeComponent();
        }

        //disabling & enabling bottons for user to delete an acct
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            signinButton.Visible = false;
            DeletePanel.Visible = true;
            signupButton.Visible = false;
            gunaButton1.Visible = false;
        }

        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);

        }


        private void signinButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(EmailTextBox.Text)) && (!string.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                Libary.UsersEmail = EmailTextBox.Text;
                FileWritter.Signin(EmailTextBox.Text, PasswordTextBox.Text);
                addusercontrol(Libary, panel1);
                Libary.GetallPdfs();
            }
            else
                MessageBox.Show("Please Some fields are still Empty, Fill them all", "Empty Field");

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(EmailTextBox.Text)) && (!string.IsNullOrEmpty(PasswordTextBox.Text)) &&
             (!string.IsNullOrEmpty(FirstnameTextBox1.Text)) && (!string.IsNullOrEmpty(LastnameTextBox2.Text)))
            {
                Libary.UsersEmail = EmailTextBox.Text;
                FileWritter.CreateUser(EmailTextBox.Text,
                PasswordTextBox.Text, FirstnameTextBox1.Text + " " + LastnameTextBox2.Text, (gender)numericUpDown1.Value);
                addusercontrol(Libary, panel1);
            }
            else
                MessageBox.Show("Please Some fields are still Empty, Fill them all", "Empty Field");
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            signinButton.Visible = false;
            signupButton.Visible = false;
            DeletePanel.Visible = true;
            gunaButton1.Visible = false;
            EmailTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserToBeDeletedbox.Text))
            {
                string dir = Directory.GetCurrentDirectory();
                string dirs = dir + @"\Users\" + UserToBeDeletedbox.Text;
                if (Directory.Exists(dirs))
                {
                    File.Delete(dirs + @"\" + UserToBeDeletedbox.Text + ".txt");
                    string fir = dirs + @"\Mypdfs\ pdfs.txt";
                    File.Delete(fir);
                    Directory.Delete(dirs + @"\Mypdfs");
                    Directory.Delete(dirs);
                    MessageBox.Show(UserToBeDeletedbox.Text + " has successfully been Deleted ", " Deleted");
                }
            }
            else
                MessageBox.Show("Please type-in the Email of the account to be deleted", "Empty Field");
        }
    }
}