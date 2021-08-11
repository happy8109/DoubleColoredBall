using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoubleColoredBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reptile reptile = new Reptile();
            this.tbResult.Text = reptile.GetHtml();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            DBdal.CreateDB();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            DBdal.CreateTable();
        }
    }
}
