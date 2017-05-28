namespace GameOfLife
{
    partial class FormRules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addSurvivalRule = new System.Windows.Forms.Button();
            this.removeSurvivalRule = new System.Windows.Forms.Button();
            this.numericUpDownSurvival = new System.Windows.Forms.NumericUpDown();
            this.listBoxSurvival = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeCreationRule = new System.Windows.Forms.Button();
            this.addCreationRule = new System.Windows.Forms.Button();
            this.numericUpDownCreation = new System.Windows.Forms.NumericUpDown();
            this.listBoxCreation = new System.Windows.Forms.ListBox();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurvival)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addSurvivalRule);
            this.groupBox1.Controls.Add(this.removeSurvivalRule);
            this.groupBox1.Controls.Add(this.numericUpDownSurvival);
            this.groupBox1.Controls.Add(this.listBoxSurvival);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survival Rules";
            // 
            // addSurvivalRule
            // 
            this.addSurvivalRule.Location = new System.Drawing.Point(133, 195);
            this.addSurvivalRule.Name = "addSurvivalRule";
            this.addSurvivalRule.Size = new System.Drawing.Size(83, 23);
            this.addSurvivalRule.TabIndex = 4;
            this.addSurvivalRule.Text = "Add Rule";
            this.addSurvivalRule.UseVisualStyleBackColor = true;
            this.addSurvivalRule.Click += new System.EventHandler(this.addSurvivalRule_Click);
            // 
            // removeSurvivalRule
            // 
            this.removeSurvivalRule.Location = new System.Drawing.Point(133, 20);
            this.removeSurvivalRule.Name = "removeSurvivalRule";
            this.removeSurvivalRule.Size = new System.Drawing.Size(83, 23);
            this.removeSurvivalRule.TabIndex = 3;
            this.removeSurvivalRule.Text = "Remove Rule";
            this.removeSurvivalRule.UseVisualStyleBackColor = true;
            this.removeSurvivalRule.Click += new System.EventHandler(this.removeSurvivalRule_Click);
            // 
            // numericUpDownSurvival
            // 
            this.numericUpDownSurvival.Location = new System.Drawing.Point(133, 169);
            this.numericUpDownSurvival.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownSurvival.Name = "numericUpDownSurvival";
            this.numericUpDownSurvival.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownSurvival.TabIndex = 2;
            // 
            // listBoxSurvival
            // 
            this.listBoxSurvival.FormattingEnabled = true;
            this.listBoxSurvival.Location = new System.Drawing.Point(7, 20);
            this.listBoxSurvival.Name = "listBoxSurvival";
            this.listBoxSurvival.Size = new System.Drawing.Size(120, 199);
            this.listBoxSurvival.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeCreationRule);
            this.groupBox2.Controls.Add(this.addCreationRule);
            this.groupBox2.Controls.Add(this.numericUpDownCreation);
            this.groupBox2.Controls.Add(this.listBoxCreation);
            this.groupBox2.Location = new System.Drawing.Point(245, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creation Rules";
            // 
            // removeCreationRule
            // 
            this.removeCreationRule.Location = new System.Drawing.Point(132, 20);
            this.removeCreationRule.Name = "removeCreationRule";
            this.removeCreationRule.Size = new System.Drawing.Size(83, 23);
            this.removeCreationRule.TabIndex = 5;
            this.removeCreationRule.Text = "Remove Rule";
            this.removeCreationRule.UseVisualStyleBackColor = true;
            this.removeCreationRule.Click += new System.EventHandler(this.removeCreationRule_Click);
            // 
            // addCreationRule
            // 
            this.addCreationRule.Location = new System.Drawing.Point(132, 195);
            this.addCreationRule.Name = "addCreationRule";
            this.addCreationRule.Size = new System.Drawing.Size(83, 23);
            this.addCreationRule.TabIndex = 4;
            this.addCreationRule.Text = "Add Rule";
            this.addCreationRule.UseVisualStyleBackColor = true;
            this.addCreationRule.Click += new System.EventHandler(this.addCreationRule_Click);
            // 
            // numericUpDownCreation
            // 
            this.numericUpDownCreation.Location = new System.Drawing.Point(132, 169);
            this.numericUpDownCreation.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCreation.Name = "numericUpDownCreation";
            this.numericUpDownCreation.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownCreation.TabIndex = 3;
            // 
            // listBoxCreation
            // 
            this.listBoxCreation.FormattingEnabled = true;
            this.listBoxCreation.Location = new System.Drawing.Point(6, 19);
            this.listBoxCreation.Name = "listBoxCreation";
            this.listBoxCreation.Size = new System.Drawing.Size(120, 199);
            this.listBoxCreation.TabIndex = 1;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(73, 248);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownSize.TabIndex = 5;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cell Size";
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(163, 248);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(75, 23);
            this.buttonSize.TabIndex = 7;
            this.buttonSize.Text = "Change Size";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Speed:";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimer.Location = new System.Drawing.Point(295, 248);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimer.TabIndex = 9;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTimer.ValueChanged += new System.EventHandler(this.numericUpDownTimer_ValueChanged);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 275);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRules";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurvival)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSurvival;
        private System.Windows.Forms.ListBox listBoxSurvival;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCreation;
        private System.Windows.Forms.Button addSurvivalRule;
        private System.Windows.Forms.Button removeSurvivalRule;
        private System.Windows.Forms.Button removeCreationRule;
        private System.Windows.Forms.Button addCreationRule;
        private System.Windows.Forms.NumericUpDown numericUpDownCreation;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
    }
}