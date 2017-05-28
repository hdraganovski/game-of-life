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
    public partial class LifeForm : Form
    {
        public LifeForm()
        {
            InitializeComponent();
            colorDialog.Color = lifeGrid1.colorAlive;
            aliveToolStripMenuItem.ForeColor = lifeGrid1.colorAlive;
            deadToolStripMenuItem.ForeColor = lifeGrid1.colorDead;
            clickTypeToolStripMenuItem.ForeColor = lifeGrid1.colorAlive;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lifeGrid1.computeNextState();
        }

        private void LifeForm_ResizeEnd(object sender, EventArgs e)
        {
            if (Height < Width)
                Height = Width + 48;
            else
                Width = Height - 48;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            statusCellNumber.Text = lifeGrid1.liveCells.ToString();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                playToolStripMenuItem.Text = "Pause";
            else
                playToolStripMenuItem.Text = "Play";
        }

        private void aliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lifeGrid1.colorAlive = colorDialog.Color;
                aliveToolStripMenuItem.ForeColor = colorDialog.Color;
                lifeGrid1.drawCurrentIteration();
                if (lifeGrid1.brush)
                    clickTypeToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void deadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lifeGrid1.colorDead = colorDialog.Color;
                deadToolStripMenuItem.ForeColor = colorDialog.Color;
                lifeGrid1.drawCurrentIteration();
                if (!lifeGrid1.brush)
                    clickTypeToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FormRules frm = new FormRules(lifeGrid1, timer1);
            frm.Show();
            playToolStripMenuItem.Text = "Play";
        }

        private void clickTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lifeGrid1.brush = !lifeGrid1.brush;
            if (lifeGrid1.brush)
            {
                clickTypeToolStripMenuItem.Text = "Mode: Create";
                clickTypeToolStripMenuItem.ForeColor = aliveToolStripMenuItem.ForeColor;
            }
            else
            {
                clickTypeToolStripMenuItem.Text = "Mode: Destroy";
                clickTypeToolStripMenuItem.ForeColor = deadToolStripMenuItem.ForeColor;
            }
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lifeGrid1.fillRandom();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lifeGrid1.clear();
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter =
            "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";


            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    Image tmp = lifeGrid1.getImg();
                    tmp.Save(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file \"" +
                    saveFileDialog1.FileName + "\" to disk. Original error: " +
                    ex.Message);
                }
            }
        }
    }
}
