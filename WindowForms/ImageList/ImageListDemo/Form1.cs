using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageListDemo
{
    public partial class Form1 : Form
    {
        // selected image index, from the listview
        private int SelectedImageIndex = 0;
        private List<Image> LoadedImages { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImagesFromFolder(string[] paths)
        {
            LoadedImages = new List<Image>();
            foreach(var path in paths)
            {
                var tempImage = Image.FromFile(path);
                LoadedImages.Add(tempImage);
            }
        }

        private void imageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                selectedImage.Image = selectedImg;
                SelectedImageIndex = selectedIndex;
            }
        }

        private void button_navigation(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton.Text.Equals("Previous"))
            {
                if (SelectedImageIndex > 0)
                {
                    SelectedImageIndex -= 1;
                    Image selectedImg = LoadedImages[SelectedImageIndex];
                    selectedImage.Image = selectedImg;
                    SelectTheClickedItem(imageList, SelectedImageIndex);
                }

            }
            else
            {
                if (SelectedImageIndex < (LoadedImages.Count - 1) && LoadedImages.Count > 0)
                {
                    SelectedImageIndex += 1;
                    Image selectedImg = LoadedImages[SelectedImageIndex];
                    selectedImage.Image = selectedImg;
                    SelectTheClickedItem(imageList, SelectedImageIndex);
                }
            }
        }

        private void SelectTheClickedItem(ListView list, int index)
        {
            for(int item = 0; item < list.Items.Count; item++)
            {
                if(item == index)
                {
                    list.Items[item].Selected = true;
                } else
                {
                    list.Items[item].Selected = false;
                }
            }
            
        }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadDirectory();
        }

        private void btnSaveNext_Click(object sender, EventArgs e)
        {
            // downloads directy name
            const string directoryName = "Downloads";

            // downloads directy exists
            Directory.CreateDirectory(directoryName);

            // creating dynamic image name
            var imageName = Guid.NewGuid().ToString();

            selectedImage?.Image?.Save($@"c:/downloads/downloadsconverted/{imageName}.png", ImageFormat.Png);

            WriteToCsvFile(txtVendor.Text, txtDescription.Text, txtAmount.Text, dtmDate.Value, imageName);

            //Reset the text value fields, pick next image in list

            if (SelectedImageIndex < (LoadedImages.Count - 1) && LoadedImages.Count > 0)
            {
                SelectedImageIndex += 1;
                Image selectedImg = LoadedImages[SelectedImageIndex];
                selectedImage.Image = selectedImg;
                SelectTheClickedItem(imageList, SelectedImageIndex);
            }

            txtAmount.Text = "";
            txtDescription.Text = "";
            txtVendor.Text = "";

        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.LoadDirectory();
        }

        private void WriteToCsvFile(string vendor, string description, string amount, DateTime date, string imageName)
        {
            // Get the file location
            var fileLocation = $@"c:/downloads/downloadsconverted/{imageName}.png";

            // Format the data as a CSV row
            string csvRow = string.Join(",", vendor, description, amount, date.ToString("yyyy-MM-dd"), fileLocation);

            // Append the data to the end of the file
            File.AppendAllText(@"c:/downloads/Imagedata.csv", csvRow + Environment.NewLine);
        }

        private void LoadDirectory()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // selected directory
                var selectedDirectory = folderBrowser.SelectedPath;
                // images paths from selected directory
                var imagePaths = Directory.GetFiles(selectedDirectory);
                // loading images from images paths
                LoadImagesFromFolder(imagePaths);

                // initializing images list
                ImageList images = new ImageList();
                images.ImageSize = new Size(130, 40);


                foreach (var image in LoadedImages)
                {
                    images.Images.Add(image);
                }

                // double check we have some images selected
                if(images.Images.Count > 0)
                {
                    imageList.Visible = true;
                    selectedImage.Visible = true;
                    nextBtn.Visible = true;
                    previousBtn.Visible = true;
                    btnSaveNext.Visible = true;
                    menuStrip1.Visible = true;
                    selectDirectoryBtn.Visible = true;

                }
                // setting our listview with the imagelist
                imageList.LargeImageList = images;

                for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
                {
                    imageList.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                }
            }
        }


    }
}
