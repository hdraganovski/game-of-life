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
    public partial class FormRules : Form
    {
        LifeGrid Grid;
        Timer Tmr;
        public FormRules(LifeGrid grid, Timer tmr)
        {
            InitializeComponent();
            Grid = grid;
            Tmr = tmr;
            foreach (int rule in grid.rulesCreate)
                listBoxCreation.Items.Add(rule);
            foreach (int rule in grid.rulesSurvive)
                listBoxSurvival.Items.Add(rule);
            numericUpDownSize.Value = grid.getCellSize();
            numericUpDownTimer.Value = tmr.Interval;
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            Grid.changeSize((int) numericUpDownSize.Value);
        }

        private void removeSurvivalRule_Click(object sender, EventArgs e)
        {
            if(listBoxSurvival.Items.Count != 0 && listBoxSurvival.SelectedIndex != -1)
            {
                Grid.rulesSurvive.Remove((int)listBoxSurvival.Items[listBoxSurvival.SelectedIndex]);
                listBoxSurvival.Items.RemoveAt(listBoxSurvival.SelectedIndex);
            }
        }

        private void addSurvivalRule_Click(object sender, EventArgs e)
        {
            if (!listBoxSurvival.Items.Contains(numericUpDownSurvival.Value))
            {
                Grid.rulesSurvive.Add((int)numericUpDownSurvival.Value);
                listBoxSurvival.Items.Add((int)numericUpDownSurvival.Value);
            }
        }

        private void removeCreationRule_Click(object sender, EventArgs e)
        {
            if (listBoxCreation.Items.Count != 0 && listBoxCreation.SelectedIndex != -1)
            {
                Grid.rulesCreate.Remove((int)listBoxCreation.Items[listBoxCreation.SelectedIndex]);
                listBoxCreation.Items.RemoveAt(listBoxCreation.SelectedIndex);
            }
        }

        private void addCreationRule_Click(object sender, EventArgs e)
        {
            if (!listBoxCreation.Items.Contains(numericUpDownCreation.Value))
            {
                Grid.rulesCreate.Add((int)numericUpDownCreation.Value);
                listBoxCreation.Items.Add((int)numericUpDownCreation.Value);
            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            Grid.changeSize((int)numericUpDownSize.Value);
        }

        private void numericUpDownTimer_ValueChanged(object sender, EventArgs e)
        {
            Tmr.Interval = (int)numericUpDownTimer.Value;
        }
    }
}
