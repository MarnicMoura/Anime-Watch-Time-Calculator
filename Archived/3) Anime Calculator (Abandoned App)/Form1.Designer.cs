namespace AnimeFormApp
{
    partial class MainForm
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
            this.AnimeNameTextBox = new System.Windows.Forms.TextBox();
            this.EpisodeNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncludeSequelsCheckBox = new System.Windows.Forms.CheckBox();
            this.runAnimeProgramButton = new System.Windows.Forms.Button();
            this.AnimeListBox = new System.Windows.Forms.ListBox();
            this.EpisodeDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSequel = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeDurationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxSequel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimeNameTextBox
            // 
            this.AnimeNameTextBox.Location = new System.Drawing.Point(50, 70);
            this.AnimeNameTextBox.Name = "AnimeNameTextBox";
            this.AnimeNameTextBox.Size = new System.Drawing.Size(310, 26);
            this.AnimeNameTextBox.TabIndex = 0;
            // 
            // EpisodeNumberNumericUpDown
            // 
            this.EpisodeNumberNumericUpDown.Location = new System.Drawing.Point(435, 71);
            this.EpisodeNumberNumericUpDown.Name = "EpisodeNumberNumericUpDown";
            this.EpisodeNumberNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.EpisodeNumberNumericUpDown.TabIndex = 1;
            // 
            // IncludeSequelsCheckBox
            // 
            this.IncludeSequelsCheckBox.AutoSize = true;
            this.IncludeSequelsCheckBox.Location = new System.Drawing.Point(6, 25);
            this.IncludeSequelsCheckBox.Name = "IncludeSequelsCheckBox";
            this.IncludeSequelsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncludeSequelsCheckBox.Size = new System.Drawing.Size(199, 24);
            this.IncludeSequelsCheckBox.TabIndex = 2;
            this.IncludeSequelsCheckBox.Text = "Does it have a Sequel?";
            this.IncludeSequelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // runAnimeProgramButton
            // 
            this.runAnimeProgramButton.Location = new System.Drawing.Point(453, 346);
            this.runAnimeProgramButton.Name = "runAnimeProgramButton";
            this.runAnimeProgramButton.Size = new System.Drawing.Size(75, 44);
            this.runAnimeProgramButton.TabIndex = 3;
            this.runAnimeProgramButton.Text = "Confirm";
            this.runAnimeProgramButton.UseVisualStyleBackColor = true;
            this.runAnimeProgramButton.Click += new System.EventHandler(this.RunAnimeProgramButton_Click);
            // 
            // AnimeListBox
            // 
            this.AnimeListBox.FormattingEnabled = true;
            this.AnimeListBox.ItemHeight = 20;
            this.AnimeListBox.Location = new System.Drawing.Point(50, 136);
            this.AnimeListBox.Name = "AnimeListBox";
            this.AnimeListBox.Size = new System.Drawing.Size(651, 164);
            this.AnimeListBox.TabIndex = 4;
            // 
            // EpisodeDurationNumericUpDown
            // 
            this.EpisodeDurationNumericUpDown.Location = new System.Drawing.Point(581, 71);
            this.EpisodeDurationNumericUpDown.Name = "EpisodeDurationNumericUpDown";
            this.EpisodeDurationNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.EpisodeDurationNumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Episode Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Episode Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 92);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 17;
            // 
            // groupBoxSequel
            // 
            this.groupBoxSequel.Controls.Add(this.label4);
            this.groupBoxSequel.Controls.Add(this.IncludeSequelsCheckBox);
            this.groupBoxSequel.Controls.Add(this.numericUpDown1);
            this.groupBoxSequel.Location = new System.Drawing.Point(732, 47);
            this.groupBoxSequel.Name = "groupBoxSequel";
            this.groupBoxSequel.Size = new System.Drawing.Size(230, 253);
            this.groupBoxSequel.TabIndex = 18;
            this.groupBoxSequel.TabStop = false;
            this.groupBoxSequel.Text = "Sequels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "How many Sequels?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 424);
            this.Controls.Add(this.groupBoxSequel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EpisodeDurationNumericUpDown);
            this.Controls.Add(this.AnimeListBox);
            this.Controls.Add(this.runAnimeProgramButton);
            this.Controls.Add(this.EpisodeNumberNumericUpDown);
            this.Controls.Add(this.AnimeNameTextBox);
            this.Name = "MainForm";
            this.Text = "Anime Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeDurationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxSequel.ResumeLayout(false);
            this.groupBoxSequel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnimeNameTextBox;
        private System.Windows.Forms.NumericUpDown EpisodeNumberNumericUpDown;
        private System.Windows.Forms.CheckBox IncludeSequelsCheckBox;
        private System.Windows.Forms.Button runAnimeProgramButton;
        private System.Windows.Forms.ListBox AnimeListBox;
        private System.Windows.Forms.NumericUpDown EpisodeDurationNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBoxSequel;
        private System.Windows.Forms.Label label4;
    }
}

