using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;
using System.Threading;

namespace UPJoystick
{
    class Paint
    {
        private float posX = 0, posY = 0;
        private float mouseSpeed = 150;
        private PaintEmulator editor;
        private Joystick joystick;
        public Paint(PaintEmulator editor, Joystick joystick)
        {
            this.editor = editor;
            this.joystick = joystick;
        }
        public void InputThread()
        {
            editor.ClearScreen();  
            while (editor.Visible)
            {
                int inputOffset = (1 << 15) - 1;
                int x = joystick.GetCurrentState().X - inputOffset;
                int y = joystick.GetCurrentState().Y - inputOffset;

                float xOffset = (float)x / inputOffset;
                float yOffset = (float)y / inputOffset;

                int slider = joystick.GetCurrentState().Z;
                mouseSpeed = 150 / ((1 << 16) - 1) + 1;
                posX += xOffset * mouseSpeed;
                posY += yOffset * mouseSpeed;

                // zebysmy nie wyszli poza okno
                if (posX > editor.WindowWidth)
                {
                    posX = editor.WindowWidth;
                }
                if (posX < 0)
                {
                    posX = 0;
                }
                if (posY > editor.WindowHeight)
                {
                    posY = editor.WindowHeight;
                }
                if (posY < 0)
                {
                    posY = 0;
                }

                
                if (joystick.GetCurrentState().Buttons[0])
                {
                    slider /= 1000;
                    
                    editor.Draw(posX, posY, slider);
                }
                
                if (joystick.GetCurrentState().Buttons[2])
                {
                    editor.ClearScreen();
                }
                editor.moveCoursor(posX, posY);  

                Thread.Sleep(10); 
            }

        }
    }
}
