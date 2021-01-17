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
using System.Threading;

namespace UPJoystick
{
    public partial class FormMain : Form
    {
        SharpDX.DirectInput.DirectInput directInput = new SharpDX.DirectInput.DirectInput();
        List<DeviceInstance> deviceList = new List<DeviceInstance>();  
        public FormMain()
        {
            InitializeComponent();

            var devices = directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly);  
            foreach (DeviceInstance instance in devices)
            { 
                deviceList.Add(instance);
                comboBoxSelect.Items.Add(instance.InstanceName);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEmulation.Enabled = true;
            buttonEditor.Enabled = true;

        }

        private void ButtonEmulation_Click(object sender, EventArgs e)
        {
            this.Hide();
            int SelectedID = comboBoxSelect.SelectedIndex;  
            Joystick joystick = new Joystick(directInput, deviceList.ElementAt(SelectedID).InstanceGuid);
            joystick.Acquire();

            MouseEmulator ME = new MouseEmulator(joystick);  
            new Thread(new ThreadStart(ME.Emulation)).Start();
            ME.ShowDialog();
        }

        private void ButtonEditor_Click(object sender, EventArgs e)
        {
            this.Hide();
            int SelectedID = comboBoxSelect.SelectedIndex; 
            Joystick device = new Joystick(directInput, deviceList.ElementAt(SelectedID).InstanceGuid);
            device.Acquire();
            PaintEmulator editorClass = PaintEmulator.CreateCanvas();   
            Paint paint = new Paint(editorClass, device); 
            paint.InputThread();
            this.Close();
        }
    }
}
