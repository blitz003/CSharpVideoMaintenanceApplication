using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMaintenace
{
    public partial class frmNewVideo : Form
    {
        Video newVideo = null;
        public frmNewVideo()
        {
            InitializeComponent();
        }


        private void frmNewVideo_Load(object sender, EventArgs e)
        {
            PopulateGenreComboBox();
        }

        private void PopulateGenreComboBox()
        {
            try
            {
                VideoEntities container = new VideoEntities();
                List<Genre> genre = container.Genres.ToList();
                comboBoxNewVideoGenre.DisplayMember = "GenreName";
                comboBoxNewVideoGenre.ValueMember = "GenreId";
                comboBoxNewVideoGenre.DataSource = genre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genre options into combobox." + ex.Message);
                
            }
        }
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveNewVideo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving new video to database." + ex.Message);
                return;
            }
        }

        private void SaveNewVideo()
        {
            try
            {
                //TODO: populate the newVideo object.
                newVideo = new Video();
                try
                {
                    newVideo.VideoId = textBoxNewVideoId.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid VideoID.");
                }

                try
                {
                    newVideo.Title = textBoxNewVideoTitle.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid Video Title.");
                }
              
                try
                {
                    newVideo.Price = decimal.Parse(textBoxNewVideoPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric digit for New Video Price.");
                }

                try
                {
                    newVideo.Download = int.Parse(textBoxNewVideoDownload.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric digit for New Video Download.");
                }
                try
                {
                    newVideo.GenreId = comboBoxNewVideoGenre.SelectedValue.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select a Genre.");
                    
                }


                //Add New Grader Object to our Database
                try
                {
                    VideoEntities container = new VideoEntities();
                    container.Videos.Add(newVideo);
                    container.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving new video into database.");
                    Console.WriteLine(ex);
                    return;
                }
                ShowMessageBoxForVideoFee();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowMessageBoxForVideoFee()
        {
            try
            {
                MessageBox.Show("The fee for this video you added is: " + newVideo.CalculateFee().ToString("C"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not calculate the applicable fee.");
                
            }
        }
    }
}
