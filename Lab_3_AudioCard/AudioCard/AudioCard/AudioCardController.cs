using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AxWMPLib;

namespace AudioCard
{
   
    class AudioCardController
    {
        public static string filepath { get; set; }
        [DllImport("winmm.dll")]
        private static extern long micSendString(string command,
            StringBuilder retstring, int ReturnLength, IntPtr callback);

        public AxWindowsMediaPlayer mediaPlayer;
        private SoundPlayer player;
        public AudioCardController()
        {
            
          
        }

        public void PlaySound(string fileName)
        {
            if (fileName != null)
            {
                player = new SoundPlayer(fileName);
                player.Play();
            }
            else
            {
                MessageBox.Show("Choose .wav file first");
            }

        }
        public void StopSound()
        {
            player?.Stop();
        }

        public void PlayMediaPlayer(string fileName)
        {
            if (fileName != null)
            {
                mediaPlayer.URL = fileName;
                mediaPlayer.Ctlcontrols.play();

            }
        }

        public void MicroPhoneOn()
        {
            micSendString("open new type waveaudio alias wavfile", null, 0, IntPtr.Zero);
            micSendString("record wavfile", null, 0, IntPtr.Zero);

        }

        public void SaveMicro()
        {
            micSendString("save wavfile test.wav", null, 0, IntPtr.Zero);
            micSendString("close wavfile", null, 0, IntPtr.Zero);
            
        }
        public void micPlay(string fileName)
        {
            string command = "Open wavefile " + fileName + " alias MediaFile";
            Console.WriteLine(command);
            micSendString(command,null,0,IntPtr.Zero);
            command = "Play "+fileName +" from 5";
           
            micSendString(command,null,0,IntPtr.Zero);
        }

        public void micPause(string filename)
        {
            string command= "pause "+filename;
            micSendString(command, null, 0, IntPtr.Zero);
        }

        public void micResume(string filename)
        {
            string command = "resume " + filename;
            micSendString(command, null, 0, IntPtr.Zero);
        }

        public void micStop(string filename)
        {
            string command = "stop " + filename;
            micSendString(command, null, 0, IntPtr.Zero);
            command = "close " + filename;
            micSendString(command, null, 0, IntPtr.Zero);

        }
        public static string GetHeadersAndDetails()
        {
            var header = new Naglowki();

            using (var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))

            {
                try
                {
                    //pobiera dane pliku .wav
                    header.riffID = binaryReader.ReadBytes(4);
                    header.size = binaryReader.ReadUInt32();
                    header.wavID = binaryReader.ReadBytes(4);
                    header.fmtID = binaryReader.ReadBytes(4);
                    header.fmtSize = binaryReader.ReadUInt32();
                    header.format = binaryReader.ReadUInt16();
                    header.channels = binaryReader.ReadUInt16();
                    header.sampleRate = binaryReader.ReadUInt32();
                    header.bytePerSec = binaryReader.ReadUInt32();
                    header.blockSize = binaryReader.ReadUInt16();
                    header.bit = binaryReader.ReadUInt16();
                    header.dataID = binaryReader.ReadBytes(4);
                    header.dataSize = binaryReader.ReadUInt32();
                }
                finally
                {
                    binaryReader.Close();
                    fileStream.Close();
                }
            }
            return header.ToString();
        }
    }
}
