namespace Anime_Calculator_App
{
    partial class Sequel
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
            this.sequelTitleTextBox = new System.Windows.Forms.TextBox();
            this.sequelEpisodeNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sequelEpisodeDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sequelEpisodeNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequelEpisodeDurationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sequelTitleTextBox
            // 
            this.sequelTitleTextBox.Location = new System.Drawing.Point(32, 106);
            this.sequelTitleTextBox.Name = "sequelTitleTextBox";
            this.sequelTitleTextBox.Size = new System.Drawing.Size(306, 26);
            this.sequelTitleTextBox.TabIndex = 0;
            // 
            // sequelEpisodeNumberNumericUpDown
            // 
            this.sequelEpisodeNumberNumericUpDown.Location = new System.Drawing.Point(408, 107);
            this.sequelEpisodeNumberNumericUpDown.Name = "sequelEpisodeNumberNumericUpDown";
            this.sequelEpisodeNumberNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.sequelEpisodeNumberNumericUpDown.TabIndex = 1;
            // 
            // sequelEpisodeDurationNumericUpDown
            // 
            this.sequelEpisodeDurationNumericUpDown.Location = new System.Drawing.Point(570, 106);
            this.sequelEpisodeDurationNumericUpDown.Name = "sequelEpisodeDurationNumericUpDown";
            this.sequelEpisodeDurationNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.sequelEpisodeDurationNumericUpDown.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(263, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Confirm";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(443, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sequel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Episode Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Episode Duration";
            // 
            // Sequel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sequelEpisodeDurationNumericUpDown);
            this.Controls.Add(this.sequelEpisodeNumberNumericUpDown);
            this.Controls.Add(this.sequelTitleTextBox);
            this.Name = "Sequel";
            this.Text = "Sequel";
            ((System.ComponentModel.ISupportInitialize)(this.sequelEpisodeNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequelEpisodeDurationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sequelTitleTextBox;
        private System.Windows.Forms.NumericUpDown sequelEpisodeNumberNumericUpDown;
        private System.Windows.Forms.NumericUpDown sequelEpisodeDurationNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}