using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnLocker
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String year = cboYear.Text;
            String docNumber = txtDocNumber.Text;
            string pathToFile = $"L:/progvat/hl/rch/{docNumber}{year.Substring(2,2)}.TMP";
            try
            {

                File.Delete(pathToFile);
                labStatus.Text = "Dokument " + docNumber + " odblokowany.";

            }

            catch

            {

                labStatus.Text = "Nie można odblokować dokumentu!";

            }

        }
    }
}
