using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ts = Tekla.Structures;
using tsm = Tekla.Structures.Model;


namespace StartUp
{
    public partial class Form1 : Form
    {
        SiteProvider siteProvider = new SiteProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siteProvider.FootingRepository.InsertPadFootings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siteProvider.ColumnRepository.InsertColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            siteProvider.BaseplateRepository.CreateBasePlate();
        }
    }
}
