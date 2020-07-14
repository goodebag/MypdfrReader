using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pdf_Reader
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void Reader_Enter(object sender, EventArgs e)
        {
            Reader.Size = this.Size;
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
