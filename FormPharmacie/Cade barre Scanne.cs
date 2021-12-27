using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace FormPharmacie
{
    public partial class Cade_barre_Scanne : Form
    {
        public Cade_barre_Scanne()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice VideoCaptureDevice;


        private void Button1_Click_1(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filter[gunaComboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            //var result = reader.Decode(bitmap);
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo devise in filter)
                gunaComboBox1.Items.Add(devise.Name);
            gunaComboBox1.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }
    }
}
