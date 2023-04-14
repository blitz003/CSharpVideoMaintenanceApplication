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
    public partial class frmVideoMaintenance : Form
    {           //Program by Marcus D. Block CIS 3325 11:00AM T/TH

        List<Video> videos = new List<Video>();
        Video selectedVideo = null;

        public frmVideoMaintenance()
        {
            InitializeComponent();
        }

        private void frmVideoMaintenance_Load(object sender, EventArgs e)
        {
            showVideos();

        }
        //METHOD TO LOAD VIDEOS INTO DATA GRID VIEW

        private void showVideos()
        {
            try
            {
                VideoEntities container = new VideoEntities();
                videos = container.Videos.ToList();

                var values = from dummyVariable in videos
                             orderby dummyVariable.VideoId
                             select new
                             {
                                 dummyVariable.VideoId,
                                 dummyVariable.Title,
                                 dummyVariable.Price,
                                 dummyVariable.Download,
                                 dummyVariable.GenreId
                             };
                dgvVideos.DataSource = values.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading datagridview" + ex.Message);
                return;
            }
        }
        //CODE TO SHOW VIDEO INFORMATION IN OUTPUT TEXTBOX

        private void dgvVideos_SelectionChanged(object sender, EventArgs e)
        {
            string selectedVideoID = dgvVideos.CurrentRow.Cells[0].Value.ToString();
            try
            {
                VideoEntities container = new VideoEntities();
                var value = from v in container.Videos
                            where v.VideoId == selectedVideoID.ToString()
                            select v;

                selectedVideo = value.FirstOrDefault(); // a grader object || null


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting a videoID" + ex.Message);
                
            }
            if (selectedVideo != null)
            {

                textBoxVideoID.Text = selectedVideo.VideoId.ToString();
                textBoxTitle.Text = selectedVideo.Title;
                textBoxPrice.Text = selectedVideo.Price.ToString("C");
                textBoxDownload.Text = selectedVideo.Download.ToString();
                textBoxSalePrice.Text = selectedVideo.GenreId;
                textBoxFee.Text = selectedVideo.CalculateFee().ToString("C");

            }

            /*
            if (dgvVideos.Focused)
            {
                string selectedVideoID = dgvVideos.CurrentRow.Cells[0].Value.ToString();
                Video selectedVideo = videos.Where(x => x.VideoId == selectedVideoID).FirstOrDefault();
                MessageBox.Show(selectedVideo.Title + " sale price: " +
                                    selectedVideo.CalculateSalePrice().ToString("C"), "Selected Video Sale Price");
            }
            */
           

        }


        //CODE TO ADD A NEW VIDEO
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Open a new form to add a new Video.
                OpenFormAddNewVideoForm();
                //Refresh the DataGridView
                showVideos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding and saving a new video to the database.");
                
            }
        }

        private void OpenFormAddNewVideoForm()
        {
            try
            {
                frmNewVideo form = new frmNewVideo();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening add new Video form." + ex.Message);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                TerminateApplication();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TerminateApplication()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing program." + ex.Message);
                
            }
        }
    }
}
