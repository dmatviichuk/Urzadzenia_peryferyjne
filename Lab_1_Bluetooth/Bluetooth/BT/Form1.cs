using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;

namespace BT
{
    public partial class Form1 : Form
    {
        private BT bt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           bt = new BT();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void refreshBtDevices(object sender, EventArgs e)
        {

        }
        private void refreshAdapters(object sender, EventArgs e )
        {
         
            bt.updateAdapters();
            listBox1.Items.Clear();
            if (bt._btAdapters.Length == 0)
            {
                MessageBox.Show("BT Adapters not found");
            }
            else
            foreach (var device in bt._btAdapters)
            {
                listBox1.Items.Add(device.Name);
            }
        }

        private void deviceInfo_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Info:");
            
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                Console.WriteLine(bt._btAdapters[index].Name);
                BluetoothRadio temp = bt._btAdapters[index];
                Console.WriteLine(temp.Name + "\n");
                Console.WriteLine(temp.LocalAddress + "\n");
                MessageBox.Show(
                    "Name:" + temp.Name +"\n" +
                    "MAC: " + temp.LocalAddress+ "\n");
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chooseAdapter(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            {
                bt.choosenRadio = bt._btAdapters[listBox1.SelectedIndex];
                Console.Write("Selected device is: "+ bt.choosenRadio.Name);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                bt.choosenDevice = bt._bluetoothDevice[listBox2.SelectedIndex];
                bt.connectToDevice();
            }
        }

        private void searchDevices(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (bt.choosenRadio != null)
            {
                bt.findDevices();
                foreach (var device in bt._bluetoothDevice)
                {
                    listBox2.Items.Add(device.DeviceName.ToString());
                }
            }
            Console.WriteLine("End of search");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                int index = listBox2.SelectedIndex;
                if(bt._bluetoothDevice != null)
                    if (bt._bluetoothDevice.Length != 0 && listBox2.SelectedIndex!=-1)
                    {
                        Console.WriteLine("Device info");
                    Console.WriteLine("Device name: " + bt._bluetoothDevice[index].DeviceName.ToString() + "\n");
                    Console.WriteLine("Device Address: " + bt._bluetoothDevice[index].DeviceAddress.ToString());
                    MessageBox.Show("Device name: " + bt._bluetoothDevice[index].DeviceName.ToString() + "\n" +
                                        "Device Address: " + bt._bluetoothDevice[index].DeviceAddress.ToString());
                    }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (bt.choosenDevice != null)
            {
               
                bt.sendTextFile();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (bt.choosenDevice != null)
            {

                bt.sendImageFile();
            }
             
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
