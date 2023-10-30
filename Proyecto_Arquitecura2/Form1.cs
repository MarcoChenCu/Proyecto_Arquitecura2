using Proyecto_Arquitecura2.BD_ProyectoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Arquitecura2
{
    public partial class Form1 : Form
    {
        //Variables para los progressbar
        int ID=0, tiempo=1;
        double Temperatura=0,MinTemp=1,MaxTemp=2.30;
        double Humedad = 0,MinHum = 0,MaxHum = 15;
        double Luminosidad = 0, MinLum = 0.01, MaxLum = 15;
        string HoraGuardado;

        //Variable para el puerto serial
        System.IO.Ports.SerialPort Puerto;

        //Variables de diseño
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            Puerto = new System.IO.Ports.SerialPort();
            //Intentar detecar el puerto del arduino
            Puerto.PortName = "COM6";
            Puerto.Open();
            Puerto.BaudRate = 9600;
            Puerto.DataReceived += SerialPort1_DataReceived;
        }
        //Evento que se ejecuta cuando se recibe un dato del arduino
        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = Puerto.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            //Recibe los datos del arduino y elimina los espacios en blanco
            line = line.Trim();
            if(line.Length == 0)
            {
                return;
            }
            //Si el valor tiene una T al inicio es la temperatura
            if (line[0] == 'T')
            {
                try
                {
                    //Muestra la temperatura en el label (Se elimina la T)
                    PbTemp.Text = line.Remove(0, 1) + " °C";
                    Temperatura = float.Parse(line.Remove(0, 1));
                }catch{}
            }
            //Si el valor tiene una H al inicio es la humedad
            else if (line[0] == 'H')
            {
                try
                {
                    //Muestra la humedad en el label (Se elimina la H)
                    PbHumedad.Text = line.Remove(0, 1) + " %";
                    Humedad = float.Parse(line.Remove(0, 1));
                }
                catch{}
            }

            else if (line[0]=='L')
            {
                try
                {
                    //Muestra la humedad en el label (Se elimina la L)
                    PbLuminosidad.Text = line.Remove(0,1) + " %";
                    Luminosidad = float.Parse(line.Remove(0,1));
                }
                catch{}
            }
            else
            {
                //si no es ninguno de los anteriores se muestra en el label
                LbInfo.Text = line;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(difference));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FrmNewConfig_Close(object sender, EventArgs e)
        {
            // Esta función se ejecutará cuando el formulario hijo se cierre
            this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet1.TbConfig);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmNewConfig CrearConfig = new FrmNewConfig();
            CrearConfig.ChildFormClosed += FrmNewConfig_Close;
            CrearConfig.ShowDialog();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmViewConfigs VerConfiguraciones = new FrmViewConfigs();
            VerConfiguraciones.ChildFormClosed += FrmNewConfig_Close;
            VerConfiguraciones.ShowDialog();
        }

        private void BtnDatos_Click(object sender, EventArgs e)
        {
            FrmDatos FrmVerDatos = new FrmDatos(ID);
            FrmVerDatos.ShowDialog();
        }

        private void CbConfiguraciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Obtener los datos de la configuración seleccionada
                ID = Convert.ToInt32(tbConfigTableAdapter.GetID(CbConfiguraciones.Text));
                if(ID>0)
                {
                    timer1.Stop();
                    //Establecer la hora de guardado
                    tiempo = Convert.ToInt32(tbConfigTableAdapter.GetTiempo(ID));
                    MinTemp = Convert.ToDouble(tbConfigTableAdapter.GetMinTemp(ID));
                    MaxTemp = Convert.ToDouble(tbConfigTableAdapter.GetMaxTemp(ID));
                    MinHum = Convert.ToDouble(tbConfigTableAdapter.GetMinHumedad(ID));
                    MaxHum = Convert.ToDouble(tbConfigTableAdapter.GetMaxHumedad(ID));
                    MinLum = Convert.ToDouble(tbConfigTableAdapter.GetMinLum(ID));
                    MaxLum = Convert.ToDouble(tbConfigTableAdapter.GetMaxLum(ID));
                    timer1.Start();
                    LbTempData.Text = MinTemp.ToString()+" °C - "+MaxTemp.ToString()+" °C"; 
                    LbHumData.Text = MinHum.ToString() + " % - " + MaxHum.ToString() + " %";
                    LbLumData.Text = MinLum.ToString() + " % - " + MaxLum.ToString() + " %";
                    GuardarDatos();
                    LbEstado.Text = "Configuración cargada";
                    LbEstado.ForeColor = Color.Green;
                }

            }catch
            {
                LbEstado.Text = "Error al cargar la configuración";
                LbEstado.ForeColor = Color.Red;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            //close app
            Application.Exit();

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            //minimize app
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet1.TbDatos' table. You can move, or remove it, as needed.
            this.tbDatosTableAdapter.Fill(this.bD_ProyectoDataSet1.TbDatos);
            // TODO: This line of code loads data into the 'bD_ProyectoDataSet1.TbConfig' table. You can move, or remove it, as needed.
            this.tbConfigTableAdapter.Fill(this.bD_ProyectoDataSet1.TbConfig);
            //fill ComboBox whit data from database
            timer1.Start();
        }
        //El timer actualiza los valores de los progressbar
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            string Ahora = hora.ToString("HH:mm:ss"); 
            if (String.Equals(Ahora, HoraGuardado))
            {             
                try
                {
                    hora = DateTime.Now;
                    tbDatosTableAdapter.InsertMediciones(1,Temperatura, Humedad, Luminosidad, hora.ToString());
                }catch
                {
                    MessageBox.Show("Error al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            //El valor de los progressbar se obtiene de la función GetPorcent
            PbTemp.Value = GetPorcent(Temperatura, MinTemp, MaxTemp);
            PbHumedad.Value = GetPorcent(Humedad, MinHum, MaxHum);
            PbLuminosidad.Value = GetPorcent(Luminosidad, MinLum, MaxLum);
            //Se calcular el valor de los colores
            int green = 238 - (int)(PbTemp.Value / 100.0 * (238 - 38));
            int green2 = 232 - (int)(PbHumedad.Value / 100.0 * (232 - 46));
            int red = 233 + (int)(PbLuminosidad.Value / 100.0 * (255-233));//233; 202; 56
            int green3 = 202 + (int)(PbLuminosidad.Value / 100.0 * (255-202));
            int blue = 56 + (int)(PbLuminosidad.Value / 100.0 * (255-56));
            //Se cambia el color de los progressbar
            PbTemp.ProgressColor = Color.FromArgb(240, green, 38); //<--Color Progressbar
            PbTemp.ForeColor = Color.FromArgb(240, green, 38);     //<--Color Texto Progressbar
            PbHumedad.ProgressColor = Color.FromArgb(46, green2, 241);
            PbHumedad.ForeColor = Color.FromArgb(46, green2,241);
            PbLuminosidad.ProgressColor = Color.FromArgb(red, green3,blue);
            PbLuminosidad.ForeColor = Color.FromArgb(red, green3, blue);
        }
        //Función que detecta el puerto en el que está conectado el Arduino
        public string GetPort()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                try
                {
                    SerialPort testPort = new SerialPort(port);
                    testPort.Open();
                    testPort.Write("V"); // Envía un carácter de prueba
                    System.Threading.Thread.Sleep(100); // Espera una respuesta
                    string response = testPort.ReadExisting();
                    testPort.Close();

                    if (response.Contains("Arduino"))
                    {
                        return port;
                    }
                }
                catch
                {
                    // Ignora errores y pasa al siguiente puerto
                }
            }

            return null; // Arduino no encontrado en ningún puerto
        }

        //Función que mapea un valor a un rango de 0 a 100
        public int GetPorcent(double val, double min, double max)
        {
            // Realiza el mapeo
            double mappedValue = (val - min) / (max - min) * 100;

            // Mapear el valor a un rango de 0 a 100
            mappedValue = Math.Max(0, Math.Min(100, mappedValue));
            return Convert.ToInt32(mappedValue);
        }

        private void GuardarDatos()
        {
            DateTime hora = DateTime.Now;
            LbEstado.Text = "----";
            LbEstado.ForeColor = Color.FromArgb(64, 64, 64);
            //Si la hora actual es igual a la hora de guardado se guarda la información
            hora = hora.AddMinutes(tiempo);
            HoraGuardado = hora.ToString("HH:mm:ss");
            LbInfo.Text = "Siguiente guardado:\n" + "     " + HoraGuardado;

        }
    }
}
