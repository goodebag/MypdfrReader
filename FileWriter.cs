using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace My_Pdf_Reader
{
    class FileWritter
    {
        private gender GetGender;
        private string UsersEmailsx;
        public static TextBox userbox;
        public static TextBox Pdfs;
        private static FileWritter uniqueInstance;
        string dirs;
        private FileWritter(string UsersEmail, string password, string yournames, gender getGender)
        {
            WriteData(UsersEmail, password, yournames, getGender);
        }
        public static FileWritter CreateUser(string UsersEmail, string password, string yournames, gender getGender)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new FileWritter(UsersEmail, password, yournames,getGender);
            }
            return uniqueInstance;
        }
        public static FileWritter Signin(string UsersEmail, string password)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new FileWritter(UsersEmail, password);
            }
            return uniqueInstance;
        }
        private FileWritter(string UsersEmail, string password)
        {
            readData(UsersEmail, password);
        }
        private void WriteData(string UsersEmail, string password, string yournames, gender getGender)
        {
            string dir = Directory.GetCurrentDirectory();
            dirs = dir + @"\Users\" + UsersEmail;
            if (!Directory.Exists(dirs))
            {
                Directory.CreateDirectory(dirs);
            }
            using (StreamWriter writer = new StreamWriter(dirs + @"\" + UsersEmail + ".txt"))
            {
                writer.WriteLine($"{UsersEmail}\r\n{password}\r\n{yournames}\r\n{getGender}");
            }
        }

        private void readData(string UsersEmail, string password)
        {
            this.UsersEmailsx = UsersEmail;
            string FileAddress = Directory.GetCurrentDirectory();
            FileAddress += @"\Users\" + UsersEmail;
            if (Directory.Exists(FileAddress))
            {
                using (StreamReader reader = new StreamReader(FileAddress + @"\" + UsersEmail + ".txt"))
                {
                    // if (!reader.EndOfStream)
                    userbox = new TextBox();
                    userbox.Text = reader.ReadToEnd();
                    if ((userbox.Lines[0].Equals(UsersEmail)) && (userbox.Lines[1].Equals(password)))
                    {
                        FileReader.Readfile(UsersEmail);
                        if (!string.IsNullOrEmpty(FileReader.Getpdfnames.Text))
                        {
                            Pdfs = new TextBox();
                            Pdfs.Text = FileReader.Getpdfnames.Text;
                        }
                        else
                        MessageBox.Show("Sorry there's no PDF on your Libary, Please press the " +
                            "AddToLibary button to add some pdfs");
                    }

                }

            }
            else
                MessageBox.Show("Wrong password or Username", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

        }
    }
}
