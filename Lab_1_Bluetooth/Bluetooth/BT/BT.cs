using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;


namespace BT
{
    class BT
    {

        public BluetoothRadio[] _btAdapters; //BT Devices (hardware in pc)
        public BluetoothClient _client;
        public BluetoothDeviceInfo[] _bluetoothDevice;
        public BluetoothDeviceInfo choosenDevice;
        private BluetoothEndPoint localEndPoint;
        public BluetoothRadio choosenRadio;
        public BT()
        {
            System.Console.WriteLine("Bluetooth: ok!");
            choosenRadio = null;
        }

        public void updateAdapters()
        {   Console.WriteLine("Adapters update:");
            _btAdapters = BluetoothRadio.AllRadios; //gets all adapters to table
       
            if(_btAdapters.Length>0)
            foreach (var adapter in _btAdapters)
            {
                Console.WriteLine(adapter.Name +" "+ adapter.HardwareStatus+" "+ adapter.Mode + " " + adapter.LocalAddress.ToString());
                
            }
            
        }

        public void findDevices()
        {
            Console.WriteLine("Started searching...");
            localEndPoint = new BluetoothEndPoint(choosenRadio.LocalAddress, BluetoothService.SerialPort);
            _client = new BluetoothClient(localEndPoint);
            _bluetoothDevice = _client.DiscoverDevices();
            if (_btAdapters.Length == 0) { Console.WriteLine("Missing BT device"); }

            {

                Console.WriteLine("Devices found:" + _bluetoothDevice.Length);
                foreach (var device in _bluetoothDevice)
                {
                    Console.WriteLine(device.DeviceName.ToString());
                }


            }
            Console.WriteLine("End searching");
        }

        public void connectToDevice()
        {
            try
            {
                BluetoothSecurity.PairRequest(
                    choosenDevice.DeviceAddress, "123456");
            }
            catch
            {
                Console.WriteLine("Couldn't pair with" + choosenDevice.DeviceName.ToString());
            }
        }

        public void sendTextFile()
        {
            Console.WriteLine("Staring sending file");
            string filePath = "C:/Users/vb/Desktop/BT/test.txt";
            var uri = new Uri("obex://"+choosenDevice.DeviceAddress+"/"+filePath);
            ObexWebRequest request= new ObexWebRequest(uri);
            request.ReadFile(filePath);
            ObexWebResponse response = (ObexWebResponse)request.GetResponse();
            response.Close();
            Console.WriteLine("Done!");

        }
        public void sendImageFile()
        {
            Console.WriteLine("Staring sending file");
            string filePath = "C:/Users/vb/Desktop/BT/test.jpeg";
            var uri = new Uri("obex://" + choosenDevice.DeviceAddress + "/" + filePath);
            ObexWebRequest request = new ObexWebRequest(uri);
            request.ReadFile(filePath);
            ObexWebResponse response = (ObexWebResponse)request.GetResponse();
            response.Close();
            Console.WriteLine("Done!");

        }

    }
}
