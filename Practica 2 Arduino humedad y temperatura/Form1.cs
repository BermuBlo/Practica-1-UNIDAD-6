using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Practica_2_Arduino_humedad_y_temperatura
{
    public partial class Form1 : Form
    {
        SerialPort serialport;
        bool puertoCerrado = false;
        public Form1()
        {
            InitializeComponent();

            serialport = new SerialPort();
            serialport.PortName = "COM3"; // Cambia esto al puerto correcto
            serialport.BaudRate = 9600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoCerrado == false)
            {
                conectar();
            }
            else
            {
                noConectado();
            }
        }
        private void conectar()
        {
            try
            {
                if (!serialport.IsOpen)
                {
                    serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialport.Open();
                    puertoCerrado = true;
                    MessageBox.Show("Conectado al puerto " + serialport.PortName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialport.ReadLine();
            this.Invoke(new MethodInvoker(delegate
            {
                string[] values = data.Split('\t');
                if (values.Length == 2)
                {
                    label1.Text = values[1];
                    label2.Text = values[0];
                    listBox1.Items.Add(values[1] + " - " + values[0]);
                }
            }));
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void form1_load(object sender, EventArgs e)
        {

        }

        private void noConectado()
        {
            MessageBox.Show("El puerto ya está abierto.");
        }



        private void button1_Click_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
