using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace APP6
{
    public partial class Form1 : MaterialForm
    {
        private MqttClient mqttClient = new MqttClient(getIP());
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Form1()
        {
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);

            txtPassword.UseSystemPasswordChar = true;

            setup();
            unConnectedState();

            mqttClient.MqttMsgPublishReceived += onMessageReceived;
        }

        private void onMessageReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

            EspData eData = JsonConvert.DeserializeObject<EspData>(message);

            TempProcess(eData.Temp);
            HumProcess(eData.Hum);
            GasProcess(eData.Gas, eData.GasStatus);
            Lamp1Process(eData.Lamp1);
            Lamp2Process(eData.Lamp2);
            FanProcess(eData.Fan, eData.FanSpeed);
        }

        //event
        private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (!txtPassword.UseSystemPasswordChar)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void btnUnsubscrise_Click(object sender, EventArgs e)
        {
            mqttClient.Connect("CS", txtUsername.Text, txtPassword.Text);
            mqttClient.Unsubscribe(new string[] { "CS" });

            unSubscriseStatusState();
            unSubscriseState();
            unConnectedState();
        }

        private void btnSubscrise_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblEmpty.Show();
            }
            else
            {
                try
                {
                    mqttClient.Connect("CS", txtUsername.Text, txtPassword.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to Broker \nWaiting to server");
                    lblEmpty.Hide();
                }

                mqttClient.Subscribe(new string[] { "CS" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                if (mqttClient.IsConnected)
                {
                    subscriseState();
                    connectedState();
                    lblEmpty.Hide();
                }
            }
        }

        private void swLamp1_CheckedChanged(object sender, EventArgs e)
        {
            if (swLamp1.Checked)
            {
                string message = Convert.ToString("LAMP1 ON");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
            else
            {
                string message = Convert.ToString("LAMP1 OFF");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
        }

        private void swLamp2_CheckedChanged(object sender, EventArgs e)
        {
            if (swLamp2.Checked)
            {
                string message = Convert.ToString("LAMP2 ON");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
            else
            {
                string message = Convert.ToString("LAMP2 OFF");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
        }

        private void swFan_CheckedChanged(object sender, EventArgs e)
        {
            if (swFan.Checked)
            {
                string message = Convert.ToString("FAN ON");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
            else
            {
                string message = Convert.ToString("FAN OFF");
                mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
            }
        }

        private void sliSpeed_onValueChanged(object sender, int newValue)
        {
            string message = Convert.ToString(sliSpeed.Value);
            mqttClient.Publish("MyLAP", Encoding.UTF8.GetBytes(message));
        }

        private void swMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swMode.Checked == true)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                swMode.Text = "DARK";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                swMode.Text = "LIGHT";
            }
        }

        //method

        private void setup()
        {
            lblWelcome1.Hide();
            lblWelcome2.Hide();
            btnUnsubscrise.Hide();
            lblEmpty.Hide();
        }

        private void subscriseState()
        {
            txtUsername.Hide();
            txtPassword.Hide();
            btnSubscrise.Hide();

            lblWelcome1.Show();
            lblWelcome2.Show();
            btnUnsubscrise.Show();
        }

        private void unSubscriseState()
        {
            txtUsername.Show();
            txtPassword.Show();
            btnSubscrise.Show();

            lblWelcome1.Hide();
            lblWelcome2.Hide();
            btnUnsubscrise.Hide();
        }

        private void unConnectedState()
        {
            swFan.Enabled = false;
            swLamp1.Enabled = false;
            swLamp2.Enabled = false;
            swMode.Enabled = false;
            sliSpeed.Enabled = false;
        }

        private void connectedState()
        {
            swFan.Enabled = true;
            swLamp1.Enabled = true;
            swLamp2.Enabled = true;
            swMode.Enabled = true;
            sliSpeed.Enabled = true;
        }

        private void unSubscriseStatusState()
        {
            lblHeat.Text = "0°C";
            lblHum.Text = "0%";
            lblGas.Text = "0";
            lblGasStatus.Text = "Không có khí gas";

            swLamp1.Checked = false;
            swLamp2.Checked = false;
            swFan.Checked = false;

            swLamp1.Text = "OFF";
            swLamp2.Text = "OFF";
            swFan.Text = "OFF";

            sliSpeed.Value = 0;
        }

        private static string getIP()
        {
            string IPAddress = "";
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }

            return IPAddress;
        }

        private void TempProcess(float heat)
        {
            if (this.IsHandleCreated)
            {
                lblHeat.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblHeat.Text = heat.ToString() + "°C";
                });
            }
        }

        private void HumProcess(float hum)
        {
            if (this.IsHandleCreated)
            {
                lblHum.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblHum.Text = hum.ToString() + "%";
                });
            }
        }

        private void GasProcess(float gas, int gasStatus)
        {
            if (this.IsHandleCreated)
            {
                lblGas.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblGas.Text = gas.ToString();
                });
            }

            if (gasStatus == 0)
            {
                if (this.IsHandleCreated)
                {
                    lblGasStatus.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblGasStatus.Text = "Không có khí gas";
                    });
                }
            }

            if (gasStatus == 1)
            {
                if (this.IsHandleCreated)
                {
                    lblGasStatus.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblGasStatus.Text = "Có khí gas";
                    });
                }
            }
        }

        private void Lamp1Process(int status)
        {
            if (status == 0)
            {
                if (this.IsHandleCreated)
                {
                    swLamp1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swLamp1.Checked = false;
                        swLamp1.Text = "OFF";
                    });
                }
            }

            if (status == 1)
            {
                if (this.IsHandleCreated)
                {
                    swLamp1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swLamp1.Checked = true;
                        swLamp1.Text = "ON";
                    });
                }
            }
        }

        private void Lamp2Process(int status)
        {
            if (status == 0)
            {
                if (this.IsHandleCreated)
                {
                    swLamp2.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swLamp2.Checked = false;
                        swLamp2.Text = "OFF";
                    });
                }
            }

            if (status == 1)
            {
                if (this.IsHandleCreated)
                {
                    swLamp2.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swLamp2.Checked = true;
                        swLamp2.Text = "ON";
                    });
                }
            }
        }

        private void FanProcess(int status, int speed)
        {
            if (status == 0)
            {
                if (this.IsHandleCreated)
                {
                    swFan.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swFan.Checked = false;
                        swFan.Text = "OFF";
                        sliSpeed.Value = speed;
                    });
                }
            }

            if (status == 1)
            {
                if (this.IsHandleCreated)
                {
                    swFan.BeginInvoke((MethodInvoker)delegate ()
                    {
                        swFan.Checked = true;
                        swFan.Text = "ON";
                        sliSpeed.Value = speed;
                    });
                }
            }
        }
    }

    public class EspData
    {
        public float Temp { get; set; }
        public float Hum { get; set; }
        public float Gas { get; set; }
        public int GasStatus { get; set; }
        public int Lamp1 { get; set; }
        public int Lamp2 { get; set; }
        public int Fan { get; set; }
        public int FanSpeed { get; set; }
    }
}