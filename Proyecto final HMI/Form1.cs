namespace Proyecto_final_HMI

{
    using System.IO.Ports;  // Necesario para SerialPort
    using System.Drawing;   // Necesario para Color
    public partial class Form1 : Form
    {
        private SerialPort serialPortObject = new SerialPort();
        private Color myRed = Color.FromArgb(255, 0, 0);
        private Color myGreen = Color.FromArgb(0, 200, 0);

        // Solo si no están ya en el diseñador:
        private ComboBox comboBoxPortSelection;
        private ComboBox comboBoxBaudRate;
        private Label labelAppStatus;
        private PictureBox pictureBoxStatusLed;
        private Button buttonConnect;



        public Form1()
        {
            InitializeComponent();
            try
            {

                //start timer for digital clock
                timer1.Interval = 1000; //tick interval 1 sec.
                timer1.Start();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ResetAppToDefaultState()
        {
            // Reiniciar estado
        }

        private void ProcessDataFromArduino(string data)
        {
            // Procesar datos del Arduino
        }

        private void labelClockRealTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClockRealTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBoxMinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortObject.IsOpen)
                {
                    // change button UI  
                    buttonConnect.Text = "Disconnect";
                    // change the status of the app 
                    ChangeAppStatusIndication(true);
                    OpenSerialPort();
                    // register event to receiver data 
                    serialPortObject.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                }
                else
                {
                    // change button UI 
                    buttonConnect.Text = "Connect";
                    // change the status of the app 
                    ChangeAppStatusIndication(false);
                    // reset all the components to default state and also u can send a message to microcontroller to 
                    //reset the components that need it
                ResetAppToDefaultState();
                    CloseSerialPort();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                // change button UI 
                buttonConnect.Text = "Connect";
                // change the status of the app 
                ChangeAppStatusIndication(false);
            }
        }
        private void OpenSerialPort()
        {
            try
            {
                serialPortObject.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPortObject.PortName = comboBoxPortSelection.Text;
                serialPortObject.Open();
                serialPortObject.WriteLine("");
                serialPortObject.DiscardInBuffer();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void ChangeAppStatusIndication(bool turnOnStatus)
        {
            if (turnOnStatus)
            {
                labelAppStatus.Text = "Status:    Connected";
            }
            else
            {
                labelAppStatus.Text = "Status: Disconnected";
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPortObject.IsOpen && serialPortObject.BytesToRead > 0)
            {
                string line = serialPortObject.ReadLine();
                ProcessDataFromArduino(line);
            }
        }
        private void CloseSerialPort()
        {
            serialPortObject.Close();
        }
    }
    
}
