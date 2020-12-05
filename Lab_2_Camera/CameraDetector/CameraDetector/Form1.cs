using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video; //przetwarzanie video
using AForge.Video.DirectShow;
using AForge.Imaging.Filters; //przetwarzanie obrazu, filtry

namespace CameraDetector
{
    public partial class MyForm : Form
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        int brightness1 = 0;
        int contrast1 = 0;
        int saturation1 = 0;
    
     

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            // get the collection of video input devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // list these devices in the combobox
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxDevices.Items.Add(device.Name);
               
            }

            videoSource = new VideoCaptureDevice();
            comboBoxDevices.SelectedIndex = 0; // default selected item will be the first device
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startPreview();
        }

        private void startPreview()
        {
           
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBoxOutput.Image = null;
                pictureBoxOutput.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxDevices.SelectedIndex].MonikerString);
                videoSource.NewFrame += videoSource_NewFrame;
                videoSource.Start();
            }
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxOutput.Image = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightness1);
            ContrastCorrection cr = new ContrastCorrection(contrast1);
            SaturationCorrection sr = new SaturationCorrection(saturation1);
            pictureBoxOutput.Image  = br.Apply((Bitmap)pictureBoxOutput.Image.Clone());
            pictureBoxOutput.Image = cr.Apply((Bitmap)pictureBoxOutput.Image.Clone());
            pictureBoxOutput.Image = sr.Apply((Bitmap)pictureBoxOutput.Image.Clone());
        }

       
        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
      
        private void BrightnessScroll(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)

                brightness1 = brightness.Value;


        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        private void CapturePhoto(object sender, EventArgs e)
        {

            if (pictureBoxOutput.Image != null)
            {
                captureImage();
            }
            else
            { MessageBox.Show("null exception"); }
        }

        private void captureImage()
        {
            Bitmap varBmp = new Bitmap(pictureBoxOutput.Image);
            Bitmap current = (Bitmap) varBmp.Clone();
            string filepath = Environment.CurrentDirectory;
            string fileName = System.IO.Path.Combine(filepath, @"name.bmp");
            current.Save(fileName);
            current.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        bool shouldDetect = false;
        private void button3_Click(object sender, EventArgs e)
        {

            Bitmap firstBitmap;
            Bitmap secondBitmap;
            for (int i = 0; i < 1000; i++)
                {
                    firstBitmap = new Bitmap(pictureBoxOutput.Image);
                    Thread.Sleep(50);
                    secondBitmap = new Bitmap(pictureBoxOutput.Image);
                //                    label1.Text = bitmapsAreEqual(firstBitmap, secondBitmap) + "%";

                    

                    if (similiarityOfBitmaps(firstBitmap, secondBitmap) < 10)
                    {
                        Console.WriteLine("Wykryto ruch" + i);
                    }
                Thread.Sleep(50);
                firstBitmap.Dispose();
                    secondBitmap.Dispose();
                }

        }



        private double similiarityOfBitmaps(Bitmap a, Bitmap b)
        {
            var height = a.PhysicalDimension.Height;
            var width = a.PhysicalDimension.Width;
            double sumPixels = 0;
            double sameColors = 0;

            for (int i = 0; i < height; i+=10)
            {
                for (int j = 0; j < width; j+=10)
                {
                    sumPixels++;
                    Color firstPixel = a.GetPixel(j, i);
                    Color secondPixel = b.GetPixel(j, i);
                    if (compareTwoPixels(firstPixel, secondPixel))
                    {
                        sameColors++;
                    }
                }
            }
            double similarity = (sameColors / sumPixels)*100;
            return similarity;
        }

        private bool compareTwoPixels(Color a, Color b)
        {

            return a.GetBrightness().Equals(b.GetBrightness());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startPreview();
            videoSource.DisplayPropertyPage(Handle);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void contrast_Scroll(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)

                contrast1 = contrast.Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)

                brightness1 = brightness.Value;
        }

        private void saturation_Scroll(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)

                saturation1 = saturation.Value;
        }

        private void pictureBoxOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
