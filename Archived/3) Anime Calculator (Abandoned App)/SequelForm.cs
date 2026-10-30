using System;
using System.Windows.Forms;

namespace Anime_Calculator_App
{
    public partial class Sequel : Form
    {
        public string SequelTitle { get; private set; }
        public int SequelEpisodeNumber { get; private set; }
        public double SequelEpisodeDuration { get; private set; }

        public Sequel()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SequelTitle = sequelTitleTextBox.Text;
            SequelEpisodeNumber = (int)sequelEpisodeNumberNumericUpDown.Value;
            SequelEpisodeDuration = (double)sequelEpisodeDurationNumericUpDown.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
