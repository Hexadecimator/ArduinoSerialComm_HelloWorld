using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ArduinoSerialComm_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redLEDBUTTON_Click(object sender, EventArgs e)
        {
            // red led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("1");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void greenLEDBUTTON_Click(object sender, EventArgs e)
        {
            // green led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("2");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blueLEDBUTTON_Click(object sender, EventArgs e)
        {
            // blue led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("3");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void redLEDOFF_Click(object sender, EventArgs e)
        {
            // red led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("4");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void greenLEDOFF_Click(object sender, EventArgs e)
        {
            // green led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("5");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blueLEDOFF_Click(object sender, EventArgs e)
        {
            // blue led button
            try
            {
                SerialPort _serialPort = new SerialPort("COM3", 9600);
                _serialPort.Open();
                _serialPort.Write("6");
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
