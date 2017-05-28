using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int childN;
        public Form1()
        {
            childN = 1;
            InitializeComponent();
            Text = "Game of Life";
        }
          
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LifeForm child = new LifeForm();
            child.Text = "Game " + childN.ToString();
            child.MdiParent = this;
            child.Show();
            childN++;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ((LifeForm)ActiveMdiChild).saveToolStripMenuItem_Click(null, null);
        }
    }
}
