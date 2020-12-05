using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AudioCard
{
    public partial class Form1 : Form
    {
        private AudioCardController audio;
        private string filepath;
       
        public Form1()
        {
            InitializeComponent();
            audio = new AudioCardController();
            audio.mediaPlayer = mediaPlayer;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SoundClick_Click(object sender, EventArgs e)
        {
            audio.PlaySound(filepath);
        }


        private void StopSound_btn_Click(object sender, EventArgs e)
        {
            audio.StopSound();
        }

        private void fileDialogBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio Files(*.wav)|*.wav"; //filter to be sure that user
            if (fileDialog.ShowDialog() == DialogResult.OK)
               AudioCardController.filepath = fileDialog.FileName;
            filepath = fileDialog.FileName; 

            Console.WriteLine(filepath);

        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            audio.PlayMediaPlayer(filepath);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            audio.MicroPhoneOn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            audio.SaveMicro();
            filepath = "test.wav";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            audio.micPlay(filepath);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            audio.micPause(filepath);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {audio.micResume(filepath);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            audio.micStop(filepath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = AudioCardController.GetHeadersAndDetails();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nie można wczytać załadowanego pliku!",
                    @"Uwaga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
