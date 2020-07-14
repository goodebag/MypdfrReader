using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Pdf_Reader
{
    class FileReader
    {
        public static TextBox Getpdfnames;
        public static FileReader UnqueInstance;
        private FileReader(string filename, string safefilename, string Useremail)
        {
            AddPDF(filename, safefilename, Useremail);
        }
        private FileReader(String Useremail)
        {
            readData(Useremail);
        }
        public static FileReader Savefile(string filename, string safefilename, string Useremail)
        {

                UnqueInstance = new FileReader(filename, safefilename, Useremail);          
                return UnqueInstance;
        }
        public static FileReader Readfile(string useremail)
        {

                UnqueInstance = new FileReader(useremail);
            
            return UnqueInstance;
        }

        public void AddPDF(string pdfFilename, string pdfSafefileName, string UsersEmailsx)
        {

            string dir = Directory.GetCurrentDirectory();
           string dirs = dir + @"\Users\" + UsersEmailsx;
            if (!Directory.Exists(dirs))
            {
                Directory.CreateDirectory(dirs);
            }
            string pdfs = dirs + @"\Mypdfs";
            if (!Directory.Exists(pdfs))
            {
                Directory.CreateDirectory(pdfs);
            }
            string filepath = pdfs + @"\ pdfs.txt";
            if (File.Exists(filepath))
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    
                    string existingFileName = Path.GetFileName(pdfFilename);
                    string NewPdfpath = Path.Combine(dir , "Books");
                    Directory.CreateDirectory(NewPdfpath);

                    string fileName = Path.Combine(NewPdfpath, existingFileName);

                    File.Copy(pdfFilename, fileName, true);
                    
                    writer.WriteLine(fileName);
                }
            }
            if (!File.Exists(filepath))
            {
                using (StreamWriter writer = new StreamWriter(pdfs + @"\ pdfs.txt"))
                {
                    writer.WriteLine(pdfFilename);
                }
            }
           
        }
        private void readData(string UsersEmail)
        {
            string dir = Directory.GetCurrentDirectory();
            string dirs = dir + @"\Users\" + UsersEmail;
            if (Directory.Exists(dirs))
            {
                string pdfs = dirs + @"\Mypdfs";
                if (Directory.Exists(pdfs))
                {
                    string filepath = pdfs + @"\ pdfs.txt";
                    if (File.Exists(filepath))
                        using (StreamReader reader = new StreamReader(pdfs + @"\ pdfs.txt"))
                        {
                           Getpdfnames = new TextBox();
                           Getpdfnames.Text = reader.ReadToEnd();
                        }
                    }
                }
            }
            
        }
 }



    enum gender
    {
      none,
      Male,
      Female
   
    }

