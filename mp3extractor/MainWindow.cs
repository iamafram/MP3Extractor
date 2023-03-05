using NReco.VideoConverter;
using System;
using System.IO;
using System.Windows.Forms;

namespace mp3extract
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_samepath_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_samepath.Checked)
            {
                label2.Visible = false;
                fileDestination_textBox.Visible = false;
                file_destination.Visible = false;
                file_destination.Enabled = false;
            }
            else
            {
                label2.Visible = true;
                fileDestination_textBox.Visible = true;
                file_destination.Visible = true;
                file_destination.Enabled = true;
            }
        }

        // exit the application
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void file_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog mp4_file = new OpenFileDialog();
            mp4_file.Filter = "mp4 files (*.mp4)|*.mp4";

            if (mp4_file.ShowDialog() == DialogResult.OK ) fileLocation_textBox.Text = mp4_file.FileName;
        }

        private void file_destination_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult directory = fbd.ShowDialog();

            if (directory == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) fileDestination_textBox.Text = fbd.SelectedPath;
        }

        // check if the field FileLocation is empty or not
        private Boolean checkFileLocation()
        {
            if (fileLocation_textBox.Text == "" )
            {
                MessageBox.Show("Select a MP4 file !");
                return false;
            }
            else if (filename_field.Text == "")
            {
                MessageBox.Show("Enter a filename !");
                return false;
            }
            return true;
        }

        private Boolean checkFileDestination()
        {
            if (fileDestination_textBox.Text == "")
            {
                MessageBox.Show("Select a destination path !");
                return false;
            }
            return true;

        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            string dirName, destinationfield;
            Boolean checkFileLoca = checkFileLocation();
            
            if (checkFileLoca && checkBox_samepath.Checked)
            {
                progressBar1.Visible = true;
                dirName = Path.GetDirectoryName(fileLocation_textBox.Text) + "\\";
                dirName += filename_field.Text + ".mp3";
                destinationfield = fileDestination_textBox.Text + "\\" + filename_field.Text + ".mp3";
                var convert = new FFMpegConverter();
                convert.ConvertProgress += UpdateProgress;
                convert.ConvertMedia(fileLocation_textBox.Text.Trim(), dirName.Trim(), "mp3");
                convert.ConvertProgress += UpdateProgress;
            }
            else if (checkFileLoca && checkBox_samepath.Checked == false && checkFileDestination())
            {
                progressBar1.Visible = true;
                dirName = Path.GetDirectoryName(fileLocation_textBox.Text) + "\\";
                dirName += filename_field.Text + ".mp3";
                destinationfield = fileDestination_textBox.Text + "\\" + filename_field.Text + ".mp3";
                var convert = new FFMpegConverter();
                convert.ConvertProgress += UpdateProgress;
                convert.ConvertMedia(fileLocation_textBox.Text.Trim(), destinationfield.Trim(), "mp3");
            }
        }

        private void UpdateProgress(object sender, ConvertProgressEventArgs e)
        {
            progressBar1.Value = (int)e.Processed.TotalMilliseconds / (int)e.TotalDuration.TotalMilliseconds * 100;
            if (progressBar1.Value == progressBar1.Maximum) MessageBox.Show("Convert OK");
        }
    }
}
