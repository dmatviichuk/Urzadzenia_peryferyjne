using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Net.Sockets;
using System.Net;

namespace Lab_4_Drukarka
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool Print()
        {
            Font printFont;
            StreamReader streamToPrint;
            int fontSize = 11;                  //standardowy rozmiar czcionki
            string font = "TimesNewRoman";      //standardowa czcionka       
            string fileName = "File";
            string path = @"C:\Users\KONJI\Desktop\";
            streamToPrint = new StreamReader("C:\\Users\\KONJI\\Desktop\\file.txt");
            

            if (checkBoxPrint.Checked)
            {
                var printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPage;
                printDocument.Print();
                return true;
               
            }

            if(comboBoxFont.SelectedItem != null || comboBoxFont.SelectedItem == "")
            {
                if(comboBoxFont.SelectedItem == "Arial")
                {
                    font = "Arial";
                }
                else if (comboBoxFont.SelectedItem == "TimesNewRoman")
                {
                    font = "TimesNewRoman";
                }
                else if (comboBoxFont.SelectedItem == "Comic Sans MS")
                {
                    font = "Comic Sans MS";
                }
            }
            
            if (comboBoxSize.SelectedItem != null || comboBoxSize.SelectedItem == "")
            {
                if (comboBoxSize.SelectedItem == "Duzy")
                {
                    fontSize = 30;
                }
                else if(comboBoxSize.SelectedItem == "Sredni")
                {
                    fontSize = 11;
                }
                else if(comboBoxSize.SelectedItem == "Maly")
                {
                    fontSize = 6;
                }
            }

            printFont = new Font(font, fontSize);

            if (checkBoxBold.Checked)
            {
                printFont = new Font(printFont, printFont.Style ^ FontStyle.Bold);
            }
            if (checkBoxUnderline.Checked)
            {
                printFont = new Font(printFont, printFont.Style ^ FontStyle.Underline);
            }
            if (checkBoxItalic.Checked)
            {
                printFont = new Font(printFont, printFont.Style ^ FontStyle.Italic);
            }

            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            // initialize PrintDocument object
            PrintDocument doc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    // set the printer to 'Microsoft Print to PDF'
                    PrinterName = "Microsoft Print to PDF",

                    // tell the object this document will print to file
                    PrintToFile = true,
                   
            // set the filename to whatever you like (full path)
            PrintFileName = Path.Combine(path, fileName + ".pdf"),
                }
            };
            doc.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            doc.Print(
                
                );
            streamToPrint.Close();
            void pd_PrintPage(object sender, PrintPageEventArgs ev)
            {
                float linesPerPage = 0;
                float yPos = 0;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;
                float topMargin = ev.MarginBounds.Top;
                String line = null;

                // Calculate the number of lines per page.
                linesPerPage = ev.MarginBounds.Height /
                               printFont.GetHeight(ev.Graphics);

                // Iterate over the file, printing each line.
                while (count < linesPerPage &&
                       ((line = streamToPrint.ReadLine()) != null))
                {
                    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black,
                        leftMargin, yPos, new StringFormat());
                    count++;
                }

                // If more lines exist, print another page.
                if (line != null)
                    ev.HasMorePages = true;
                else
                    ev.HasMorePages = false;
            }
            return true;
        }

        private void buttonPrint_Click(object sender, EventArgs e) //Zaprogramowanie przycisku
        {

            if (!Print())
                MessageBox.Show("Error");
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            string pathPicture = @"C:\Users\KONJI\Desktop\obrazek.png";
            System.Drawing.Image img = System.Drawing.Image.FromFile(pathPicture); //bilbioteka do drukowania obrazka
			Point location = new Point(100, 100);
			e.Graphics.DrawImage(img, location);
        }

		private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
