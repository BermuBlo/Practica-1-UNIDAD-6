using System;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;

namespace Practica_3_Sensor_de_nivel_lluvia
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            button1.Click += button1_Click;
            timer1.Interval = 500; //Intervalo de parpadeo en milisengundos
            timer1.Tick += timer1_Tick;
            soundPlayer = new SoundPlayer("C:\\Users\\one_c\\Downloads\\emergency_effects\\Emergency Effects\\Emergency Siren Police Yelp 02.wav"); // Ruta del archivo de sonido
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                label1.Text = "Sensor Status: " + (data.Trim() == "0" ? "Water Detected" : "No Water Detected");
                if (data.Trim() == "0")
                {
                    if (!isBlinking)
                    {
                        timer1.Start();
                        soundPlayer.PlayLooping();
                        pictureBox1.BackColor = System.Drawing.Color.Red;
                        isBlinking = true;
                    }
                }
                else
                {
                    if (isBlinking)
                    {
                        soundPlayer.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Gray;
                        isBlinking = false;
                    }
                }
            }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isBlinking)
            {
                pictureBox1.BackColor = pictureBox1.BackColor == System.Drawing.Color.Red ? System.Drawing.Color.Gray : System.Drawing.Color.Red;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Application.Exit();
        }
    }
}
