using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;

namespace UPJoystick
{
    public partial class PaintEmulator : Form {
        private System.Threading.Thread myThread;
        private Joystick joystick;

        float x = 0, y = 0;
        public bool showCross = false;  
        private PaintEmulator() {
            InitializeComponent();
        }

        public void dodajJoystick(Joystick joystick) {
            this.joystick = joystick;
        }


        public static PaintEmulator CreateCanvas() {  
            PaintEmulator canvas = null;
            System.Threading.Thread thread = new System.Threading.Thread(() => {  
                canvas = new PaintEmulator();
                canvas.ShowDialog();
            });
            thread.Start();
            while(canvas == null) {
                System.Threading.Thread.Sleep(10);
            }
            canvas.myThread = thread;

            return canvas;
        }

        public int WindowWidth { get { return pictureBox1.Width; } }  
        public int WindowHeight { get { return pictureBox1.Height; } }  
        private void Timer1_Tick(object sender, EventArgs e) {  
            
            if(updated) {
                updated = false;
                Refresh();
            }

            
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e) {
            lock(bmp) {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
            using(SolidBrush pedzel = new SolidBrush(Color.Black)) { 
                e.Graphics.FillEllipse(pedzel, x - 4, y - 4, 2 * 4, 2 * 4);  
            }
        }

        public void ClearScreen() {  
            bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);  
            lock(bmp) {
                using(Graphics g = Graphics.FromImage(bmp))
                using(SolidBrush pedzel = new SolidBrush(Color.White)) { 
                    g.FillRectangle(pedzel, 0, 0, WindowWidth, WindowHeight); 
                }
                updated = true; 
            }
        }
        public void Draw(float x, float y, float r) { 
            lock(bmp) {
                using(Graphics g = Graphics.FromImage(bmp))
                using(SolidBrush pedzel = new SolidBrush(Color.Green)) {  
                    g.FillEllipse(pedzel, x - r, y - r, 2 * r, 2 * r);  
                }
                updated = true; 
            }
        }

        public void moveCoursor(float x, float y) { 
            this.x = x;
            this.y = y;
            updated = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_Load(object sender, EventArgs e) {
            bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
        }
    }
}
