using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using PhotoAlbum;

namespace PhotoAlbumDemo
{
    public partial class MainForm : Form
    {
        private ImageAlbum album; // photo album
        private string albumFileName; // file name of the album
        private string fileName;

        public MainForm()
        {
            InitializeComponent();
            album = new ImageAlbum();
            next.Enabled = false;
            previous.Enabled = false;
            menuImage.Enabled = false;
            menuAlbum.Enabled = false;
        }
        private void ChangedHandler(object source, PhotosChangedEventArgs e)
        {
            if (e.ChangeType == ChangeType.Replaced)
            {
                statusFileName.Text = $"'{e.ChangedItem.FileName}' was " +
                "replaced with '{e.ReplacedWith.FileName}'.";
            }
            else if (e.ChangeType == ChangeType.Cleared)
            {
                statusFileName.Text = "The photo list was cleared.";
            }
            else
            {
                statusFileName.Text = $"'{e.ChangedItem.FileName}' was " +
                "'{e.ChangeType}'.";
            }
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo";
            dlg.Filter =
            "All Image files(*.bmp;*.gif;*.jpg,*.ico,*.emf,*.wmf)|" +
            "*.bmp;*.gif;*.jpg;*.ico;*.emf,*.wmf|" +
            "Bitmap Files(*.bmp;*.gif;*.jpg;*.ico)|" +
            "*.bmp;*.gif;*.jpg;*.ico|Meta Files(*.emf;*.wmf)|*.emf;*.wmf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = dlg.FileName;
                    pbox.Image = new Bitmap(dlg.OpenFile());
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;
                    statusFileName.Text = "Loaded " + dlg.FileName;
                    statusImageSize.Text = String.Format("{0:#} x {1:#}",
                    pbox.Image.Width, pbox.Image.Height);
                    menuImage.Enabled = true;
                }
                catch (Exception ex)
                {
                    statusFileName.Text = "Unable to load " + dlg.FileName;
                    MessageBox.Show("Unable to load file: " + ex.Message);
                }
            }
            dlg.Dispose();
        }        private void add_Click(object sender, EventArgs e)
        {
            // add the form as a subscriber
            album.Changed += ChangedHandler;
            album.Add(new Photo(fileName));
        }        public void BinarySerialization(string fileName, ImageAlbum album)
        {
            using (Stream w = File.Create(fileName))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(w, album);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Failed to serialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
        }        private void saveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save Photo Album";
            dlg.Filter = "Bynary files (*.dat)|*.dat" + "|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    albumFileName = dlg.FileName;
                    this.BinarySerialization(albumFileName, album);
                    statusFileName.Text = "Saved " + dlg.FileName;
                }
                catch (Exception ex)
                {
                    statusFileName.Text = "Unable to save " + dlg.FileName;
                    MessageBox.Show("Unable to save photo album file: " +
                    ex.Message);
                }
            }
            dlg.Dispose();
        }        public ImageAlbum BinaryDeserialization(string fileName)
        {
            ImageAlbum album = null;
            using (Stream r = File.OpenRead(fileName))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    album = (ImageAlbum)bf.Deserialize(r);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Failed to deserialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
            return album;
        }
        private void loadAlbum_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo Album";
            dlg.Filter = "Binary files (*.dat)|*.dat" + "|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    albumFileName = dlg.FileName;
                    album = this.BinaryDeserialization(albumFileName);
                    statusFileName.Text = "Loaded " + dlg.FileName;
                    next.Enabled = true;
                    previous.Enabled = true;
                    menuImage.Enabled = true;
                    menuAlbum.Enabled = true;
                }
                catch (Exception ex)
                {
                    statusFileName.Text = "Unable to load " + dlg.FileName;
                    MessageBox.Show("Unable to load photo album file: " +
                    ex.Message);
                }
            }
            dlg.Dispose();
        }        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }        private void menuView_Click(object sender, EventArgs e)
        {
            if (sender == menuStretch)
            {
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (sender == menuActual)
            {
                pbox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (sender == menuCenter)
            {
                pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            pbox.Invalidate();
            statusBar.Invalidate();
        }        private void menuAlbum_Click(object sender, EventArgs e)
        {
            album.CurrentPosition = 0;
            pbox.Image = new Bitmap(album.CurrentPhoto.FileName);
            pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            statusFileName.Text = album[album.CurrentPosition].FileName;
            statusImageSize.Text = String.Format("{0:#} x {1:#}",
            album[album.CurrentPosition].Image.Width,
            album[album.CurrentPosition].Image.Height);
        }        private void next_Click(object sender, EventArgs e)
        {
            album.CurrentNext();
            pbox.Image = new Bitmap(album.CurrentPhoto.FileName);
            pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            statusFileName.Text = album[album.CurrentPosition].FileName;
            statusImageSize.Text = String.Format("{0:#} x {1:#}",
            album[album.CurrentPosition].Image.Width,
            album[album.CurrentPosition].Image.Height);
        }
        private void previous_Click(object sender, EventArgs e)
        {
            album.CurrentPrev();
            pbox.Image = new Bitmap(album.CurrentPhoto.FileName);
            pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            statusFileName.Text = album[album.CurrentPosition].FileName;
            statusImageSize.Text = String.Format("{0:#} x {1:#}",
            album[album.CurrentPosition].Image.Width,
            album[album.CurrentPosition].Image.Height);
        }
    }
}
