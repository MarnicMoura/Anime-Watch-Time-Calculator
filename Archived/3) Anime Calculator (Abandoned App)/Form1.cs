using Anime_Calculator_App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AnimeFormApp
{
    public partial class MainForm : Form
    {
        private List<string> animeList = new List<string>();
        private List<double> animeTotalTimes = new List<double>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RunAnimeProgramButton_Click(object sender, EventArgs e)
        {
            RunAnimeProgram();
            UpdateAnimeListBox();
        }

        private void RunAnimeProgram()
        {
            string animeName = AnimeNameTextBox.Text;
            animeList.Add(animeName);

            int episodeNumber = (int)EpisodeNumberNumericUpDown.Value;
            double episodeDuration = (double)EpisodeDurationNumericUpDown.Value;

            double time = Math.Round((episodeNumber * episodeDuration) / 60.0, 2);
            animeTotalTimes.Add(time);

            bool includeSequels = IncludeSequelsCheckBox.Checked;

            if (includeSequels)
            {
                using (Sequel sequelForm = new Sequel())
                {
                    DialogResult result = sequelForm.ShowDialog();

                    while (result == DialogResult.OK)
                    {
                        string sequelTitle = sequelForm.SequelTitle;
                        int sequelEpisodeNumber = sequelForm.SequelEpisodeNumber;
                        double sequelEpisodeDuration = sequelForm.SequelEpisodeDuration;

                        animeList.Add(sequelTitle);
                        double sequelTime = Math.Round((sequelEpisodeNumber * sequelEpisodeDuration) / 60.0, 2);
                        animeTotalTimes.Add(sequelTime);

                        result = sequelForm.ShowDialog();
                    }
                }
            }

            // Code for saving to file goes here (similar to the original code)
        }

        private void UpdateAnimeListBox()
        {
            AnimeListBox.Items.Clear();

            var sortedAnimeList = animeList
                .Select((anime, index) => new { Name = anime, Time = animeTotalTimes[index] })
                .OrderByDescending(a => a.Time);

            foreach (var animeEntry in sortedAnimeList)
            {
                AnimeListBox.Items.Add($"{animeEntry.Name} - {animeEntry.Time} hours");
            }
        }
    }
}
