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
    public partial class MouseEmulator : Form
    {
        private float mouseX = 0, mouseY = 0; 
        private float MouseSpeed = 50; 
        Joystick joystick;
         
        bool ifJoystickInUse = false;
        
        public MouseEmulator(Joystick joystick)
        {
            
            this.joystick = joystick;
            InitializeComponent();
        }

        public void Emulation()
        {
            while (true)
            {
                int inputOffset = (1 << 15) - 1;
                int x = joystick.GetCurrentState().X - inputOffset;
                int y = joystick.GetCurrentState().Y - inputOffset;

                float xOffset = (float)x / inputOffset; 
                float yOffset = (float)y / inputOffset;

                int slider = joystick.GetCurrentState().Z;  

                MouseSpeed = 50 * slider / ((1 << 16) - 1); 

                mouseX += xOffset * MouseSpeed;
                mouseY += yOffset * MouseSpeed;

                if (mouseX / 50 < 0)
                    mouseX = 0;
                if (mouseX / 50 > 1300)
                    mouseX = 1300 * 50;
                if (mouseY / 50 < 0)
                    mouseY = 0;
                if (mouseY / 50 > 1300)
                    mouseY = 1300 * 50;

               
                uint flags = (uint)(MouseEventFlags.ABSOLUTE | MouseEventFlags.MOVE);

                if (joystick.GetCurrentState().Buttons[0])  
                {
                    flags |= (uint)MouseEventFlags.LEFTDOWN; 
                }
                else
                {
                    flags |= (uint)MouseEventFlags.LEFTUP;
                }

                if (joystick.GetCurrentState().Buttons[2])
                {
                    System.Environment.Exit(0);
                }

                if (ifJoystickInUse)
                    mouse_event(flags, (uint)mouseX, (uint)mouseY, 0, 0);

                
            }

        }
        [Flags] 
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,  // wcisniety lewy przycisk myszy
            LEFTUP = 0x00000004,
            MOVE = 0x00000001,  // poruszenie myszka
            ABSOLUTE = 0x00008000,  // pozycja absolute
            RIGHTDOWN = 0x00000008,  // wcisniety prawy przycisk myszy
            RIGHTUP = 0x00000010
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);  
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelX.Text = "x:" + (mouseX/50).ToString();
            labelY.Text = "y:" + (mouseY/50).ToString();
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Start();

            ifJoystickInUse = true;
            mouseX = 0;
            mouseY = 0;
            
        }
    }
}
