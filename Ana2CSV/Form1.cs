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


namespace Ana2CSV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string xmlFilename;
        string xmlFilePath;
        // string foldername = "";
        private void BTConvert_Click(object sender, EventArgs e)
        {
            ReadAna ReadAna = new ReadAna();
            ReadAna.ReadAndCreate2(this.TBPath.Text);
        }

        private void BTBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                this.xmlFilePath = ofd.FileName;
                this.xmlFilename = ofd.SafeFileName;



            }
            this.TBPath.Text = xmlFilePath;
        }

    }
}
