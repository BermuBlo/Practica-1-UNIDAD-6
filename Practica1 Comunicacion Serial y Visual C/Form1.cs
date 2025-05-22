using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Practica1_Comunicacion_Serial_y_Visual_C
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //SerialPort serialPort
        public Form1()


        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM3", 9600);

            //Asegurate de que el puerto COM sea correcto

            Arduino.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("F"); //Enviar señal para apagar LED
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E"); //Enviar señal para encender LED
        }
    }
}
