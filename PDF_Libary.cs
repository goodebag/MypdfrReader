using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;

namespace My_Pdf_Reader
{
    public partial class PDF_Libary : UserControl
    {
        public string UsersEmail;
        Dashboard readerpanel = new Dashboard();
        string GetFileName;
        string Getfilesafename;
        public PDF_Libary()
        {
            InitializeComponent();
           
        }

        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);

        }

        public void GetallPdfs()
        {
            
            if (!string.IsNullOrEmpty(FileWritter.Pdfs.Text))
            {
                Point position = new Point(6, 21);
                 foreach (var pdf in FileWritter.Pdfs.Lines)
                {
                    if (!string.IsNullOrWhiteSpace(pdf))
                    {

                        Guna2Panel pdflayoutpanel = new Guna2Panel();
                        Label pdfnameLabel = new Label();
                        pdfnameLabel.BackColor = Color.Transparent;
                        pdfnameLabel.ForeColor = Color.Blue;
                        pdfnameLabel.Visible = true;
                        pdfnameLabel.Location = label1.Location;
                        pdfnameLabel.AutoSize = true;

                        PictureBox pBox = new PictureBox();
                        pBox.Size = pictureBox1.Size;
                        pBox.Location = pictureBox1.Location;
                        pBox.Image = Image.FromFile(@"C:\Users\Mr-Goodebag\Desktop\images.jpeg");
                        pBox.SizeMode = pictureBox1.SizeMode;

                        pdflayoutpanel.BackColor = PanToAdds.BackColor;
                        pdflayoutpanel.BorderRadius = PanToAdds.BorderRadius;
                        pdflayoutpanel.BorderColor = PanToAdds.BorderColor;
                        pdflayoutpanel.BorderThickness = PanToAdds.BorderThickness;
                        pdflayoutpanel.FillColor = PanToAdds.FillColor;
                        pdflayoutpanel.Size = PanToAdds.Size;
                        
                        pdflayoutpanel.Controls.Add(pBox);
                        pdflayoutpanel.Controls.Add(pdfnameLabel);
                        pdflayoutpanel.Click += new EventHandler(this.panel_Click);

                        pdflayoutpanel.Location = position;
                        pdflayoutpanel.Visible = true;
                        foreach (Control item in pdflayoutpanel.Controls)
                        {
                            pdflayoutpanel.Name = pdf;
                            if (item is PictureBox)
                            {
                                item.Name = pdf;
                                item.Click += new EventHandler(this.picture_Click);
                            }
                            if (item is Label)
                            {
                                item.Text = pdf;
                                item.Click += new EventHandler(this.label_Click);
                            }  
                        }
                        PdflistView.Controls.Add(pdflayoutpanel);
                        position.Y += 55;

                    }

                }

            }
        }

        void panel_Click(object sender, EventArgs e)
        {
            Guna2Panel btn = sender as Guna2Panel;
            readerpanel.Reader.src = btn.Name;
            addusercontrol(readerpanel, panel2);
        }
        void picture_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            readerpanel.Reader.src = btn.Name;
            addusercontrol(readerpanel, panel2);
        }
        void label_Click(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            readerpanel.Reader.src = btn.Text;
            addusercontrol(readerpanel, panel2);
        }

        private void AddToLibaryButton_Click(object sender, EventArgs e)
        {
            if (ChooseFileToOpen.ShowDialog().Equals(DialogResult.OK))
            {
                ChooseFileToOpen.Filter = "(PDF)|*.Pdf";
                GetFileName = ChooseFileToOpen.FileName;
                Getfilesafename = ChooseFileToOpen.SafeFileName;
                FileReader.Savefile(GetFileName, Getfilesafename, UsersEmail);
                readerpanel.Reader.src = ChooseFileToOpen.FileName;
                addusercontrol(readerpanel, panel2);

            }
        }
    }
}
