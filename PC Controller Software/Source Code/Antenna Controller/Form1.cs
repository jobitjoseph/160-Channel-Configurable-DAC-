using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CustomControls.RJControls;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Threading;
using System.Management;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Antenna_Controller
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private List<CheckBox> toggleSwitches = new List<CheckBox>();
        private AutoResetEvent receiveSignal = new AutoResetEvent(false);
        private SerialPort serialPort;
        private bool isConnected = false;
        private System.Windows.Forms.Timer updateDeviceTimer;
        private List<ComboBox> voltageComboBoxes = new List<ComboBox>(); 
        byte lsb;
        byte msb;
        byte[] byteArray = new byte[20];
        short[] valuesArray = new short[160];
        short tempV;
        public Form1()
        {
            InitializeComponent();
            InitializeVoltageComboBox();
            UpdateDeviceStatus();
            voltageComboBoxes.AddRange(new[] { V0, V1, V2, V3, V4, V5, V6, V7, V8, V9, V10, V11, V12, V13, V14, V15, V16, V17, V18, V19, V20, V21, V22, V23, V24, V25, V26, V27, V28, V29, V30, V31, V32, V33, V34, V35, V36, V37, V38, V39, V40, V41, V42, V43, V44, V45, V46, V47, V48, V49, V50, V51, V52, V53, V54, V55, V56, V57, V58, V59, V60, V61, V62, V63, V64, V65, V66, V67, V68, V69, V70, V71, V72, V73, V74, V75, V76, V77, V78, V79, V80, V81, V82, V83, V84, V85, V86, V87, V88, V89, V90, V91, V92, V93, V94, V95, V96, V97, V98, V99, V100, V101, V102, V103, V104, V105, V106, V107, V108, V109, V110, V111, V112, V113, V114, V115, V116, V117, V118, V119, V120, V121, V122, V123, V124, V125, V126, V127, V128, V129, V130, V131, V132, V133, V134, V135, V136, V137, V138, V139, V140, V141, V142, V143, V144, V145, V146, V147, V148, V149, V150, V151, V152, V153, V154, V155, V156, V157, V158, V159 });
            for (int i = 0; i <= 159; i++)
            {
               InitializeV(i);
            }

            //InitializeSwitches();
            connectButton.Text = "Connect";
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Cyan200, MaterialSkin.TextShade.WHITE);
            ModeRadioButton1.Checked = true; 
            setVoltageButton.Font = new Font("Arial", 17);
            voltageComboBox.Font = new Font("Arial", 16);
            connectButton.Font = new Font("Arial", 17);
            //V0.Font = new Font("Arial", 16);
            //setVoltageButton.Text = "Set Voltage";
            voltageComboBox.Visible = ModeRadioButton1.Checked;

            foreach (var comboBox in voltageComboBoxes)
            {
                comboBox.Enabled = false;
            }

            /*
            V0.Visible = ModeRadioButton2.Checked;
            V1.Visible = ModeRadioButton2.Checked;
            V2.Visible = ModeRadioButton2.Checked;
            V3.Visible = ModeRadioButton2.Checked;
            V4.Visible = ModeRadioButton2.Checked;
            V5.Visible = ModeRadioButton2.Checked;
            V6.Visible = ModeRadioButton2.Checked;
            V7.Visible = ModeRadioButton2.Checked;
            V8.Visible = ModeRadioButton2.Checked;
            V9.Visible = ModeRadioButton2.Checked;
            V10.Visible = ModeRadioButton2.Checked;
            V11.Visible = ModeRadioButton2.Checked;
            V12.Visible = ModeRadioButton2.Checked;
            V13.Visible = ModeRadioButton2.Checked;
            V14.Visible = ModeRadioButton2.Checked;
            V15.Visible = ModeRadioButton2.Checked;
            V16.Visible = ModeRadioButton2.Checked;
            V17.Visible = ModeRadioButton2.Checked;
            V18.Visible = ModeRadioButton2.Checked;
            V19.Visible = ModeRadioButton2.Checked;
            V20.Visible = ModeRadioButton2.Checked;
            V21.Visible = ModeRadioButton2.Checked;
            V22.Visible = ModeRadioButton2.Checked;
            V23.Visible = ModeRadioButton2.Checked;
            V24.Visible = ModeRadioButton2.Checked;
            V25.Visible = ModeRadioButton2.Checked;
            V26.Visible = ModeRadioButton2.Checked;
            V27.Visible = ModeRadioButton2.Checked;
            V28.Visible = ModeRadioButton2.Checked;
            V29.Visible = ModeRadioButton2.Checked;
            V30.Visible = ModeRadioButton2.Checked;
            V31.Visible = ModeRadioButton2.Checked;
            V32.Visible = ModeRadioButton2.Checked;
            V33.Visible = ModeRadioButton2.Checked;
            V34.Visible = ModeRadioButton2.Checked;
            V35.Visible = ModeRadioButton2.Checked;
            V36.Visible = ModeRadioButton2.Checked;
            V37.Visible = ModeRadioButton2.Checked;
            V38.Visible = ModeRadioButton2.Checked;
            V39.Visible = ModeRadioButton2.Checked;
            V40.Visible = ModeRadioButton2.Checked;
            V41.Visible = ModeRadioButton2.Checked;
            V42.Visible = ModeRadioButton2.Checked;
            V43.Visible = ModeRadioButton2.Checked;
            V44.Visible = ModeRadioButton2.Checked;
            V45.Visible = ModeRadioButton2.Checked;
            V46.Visible = ModeRadioButton2.Checked;
            V47.Visible = ModeRadioButton2.Checked;
            V48.Visible = ModeRadioButton2.Checked;
            V49.Visible = ModeRadioButton2.Checked;
            V50.Visible = ModeRadioButton2.Checked;
            V51.Visible = ModeRadioButton2.Checked;
            V52.Visible = ModeRadioButton2.Checked;
            V53.Visible = ModeRadioButton2.Checked;
            V54.Visible = ModeRadioButton2.Checked;
            V55.Visible = ModeRadioButton2.Checked;
            V56.Visible = ModeRadioButton2.Checked;
            V57.Visible = ModeRadioButton2.Checked;
            V58.Visible = ModeRadioButton2.Checked;
            V59.Visible = ModeRadioButton2.Checked;
            V60.Visible = ModeRadioButton2.Checked;
            V61.Visible = ModeRadioButton2.Checked;
            V62.Visible = ModeRadioButton2.Checked;
            V63.Visible = ModeRadioButton2.Checked;
            V64.Visible = ModeRadioButton2.Checked;
            V65.Visible = ModeRadioButton2.Checked;
            V66.Visible = ModeRadioButton2.Checked;
            V67.Visible = ModeRadioButton2.Checked;
            V68.Visible = ModeRadioButton2.Checked;
            V69.Visible = ModeRadioButton2.Checked;
            V70.Visible = ModeRadioButton2.Checked;
            V71.Visible = ModeRadioButton2.Checked;
            V72.Visible = ModeRadioButton2.Checked;
            V73.Visible = ModeRadioButton2.Checked;
            V74.Visible = ModeRadioButton2.Checked;
            V75.Visible = ModeRadioButton2.Checked;
            V76.Visible = ModeRadioButton2.Checked;
            V77.Visible = ModeRadioButton2.Checked;
            V78.Visible = ModeRadioButton2.Checked;
            V79.Visible = ModeRadioButton2.Checked;
            V80.Visible = ModeRadioButton2.Checked;
            V81.Visible = ModeRadioButton2.Checked;
            V82.Visible = ModeRadioButton2.Checked;
            V83.Visible = ModeRadioButton2.Checked;
            V84.Visible = ModeRadioButton2.Checked;
            V85.Visible = ModeRadioButton2.Checked;
            V86.Visible = ModeRadioButton2.Checked;
            V87.Visible = ModeRadioButton2.Checked;
            V88.Visible = ModeRadioButton2.Checked;
            V89.Visible = ModeRadioButton2.Checked;
            V90.Visible = ModeRadioButton2.Checked;
            V91.Visible = ModeRadioButton2.Checked;
            V92.Visible = ModeRadioButton2.Checked;
            V93.Visible = ModeRadioButton2.Checked;
            V94.Visible = ModeRadioButton2.Checked;
            V95.Visible = ModeRadioButton2.Checked;
            V96.Visible = ModeRadioButton2.Checked;
            V97.Visible = ModeRadioButton2.Checked;
            V98.Visible = ModeRadioButton2.Checked;
            V99.Visible = ModeRadioButton2.Checked;
            V100.Visible = ModeRadioButton2.Checked;
            V101.Visible = ModeRadioButton2.Checked;
            V102.Visible = ModeRadioButton2.Checked;
            V103.Visible = ModeRadioButton2.Checked;
            V104.Visible = ModeRadioButton2.Checked;
            V105.Visible = ModeRadioButton2.Checked;
            V106.Visible = ModeRadioButton2.Checked;
            V107.Visible = ModeRadioButton2.Checked;
            V108.Visible = ModeRadioButton2.Checked;
            V109.Visible = ModeRadioButton2.Checked;
            V110.Visible = ModeRadioButton2.Checked;
            V111.Visible = ModeRadioButton2.Checked;
            V112.Visible = ModeRadioButton2.Checked;
            V113.Visible = ModeRadioButton2.Checked;
            V114.Visible = ModeRadioButton2.Checked;
            V115.Visible = ModeRadioButton2.Checked;
            V116.Visible = ModeRadioButton2.Checked;
            V117.Visible = ModeRadioButton2.Checked;
            V118.Visible = ModeRadioButton2.Checked;
            V119.Visible = ModeRadioButton2.Checked;
            V120.Visible = ModeRadioButton2.Checked;
            V121.Visible = ModeRadioButton2.Checked;
            V122.Visible = ModeRadioButton2.Checked;
            V123.Visible = ModeRadioButton2.Checked;
            V124.Visible = ModeRadioButton2.Checked;
            V125.Visible = ModeRadioButton2.Checked;
            V126.Visible = ModeRadioButton2.Checked;
            V127.Visible = ModeRadioButton2.Checked;
            V128.Visible = ModeRadioButton2.Checked;
            V129.Visible = ModeRadioButton2.Checked;
            V130.Visible = ModeRadioButton2.Checked;
            V131.Visible = ModeRadioButton2.Checked;
            V132.Visible = ModeRadioButton2.Checked;
            V133.Visible = ModeRadioButton2.Checked;
            V134.Visible = ModeRadioButton2.Checked;
            V135.Visible = ModeRadioButton2.Checked;
            V136.Visible = ModeRadioButton2.Checked;
            V137.Visible = ModeRadioButton2.Checked;
            V138.Visible = ModeRadioButton2.Checked;
            V139.Visible = ModeRadioButton2.Checked;
            V140.Visible = ModeRadioButton2.Checked;
            V141.Visible = ModeRadioButton2.Checked;
            V142.Visible = ModeRadioButton2.Checked;
            V143.Visible = ModeRadioButton2.Checked;
            V144.Visible = ModeRadioButton2.Checked;
            V145.Visible = ModeRadioButton2.Checked;
            V146.Visible = ModeRadioButton2.Checked;
            V147.Visible = ModeRadioButton2.Checked;
            V148.Visible = ModeRadioButton2.Checked;
            V149.Visible = ModeRadioButton2.Checked;
            V150.Visible = ModeRadioButton2.Checked;
            V151.Visible = ModeRadioButton2.Checked;
            V152.Visible = ModeRadioButton2.Checked;
            V153.Visible = ModeRadioButton2.Checked;
            V154.Visible = ModeRadioButton2.Checked;
            V155.Visible = ModeRadioButton2.Checked;
            V156.Visible = ModeRadioButton2.Checked;
            V157.Visible = ModeRadioButton2.Checked;
            V158.Visible = ModeRadioButton2.Checked;
            V159.Visible = ModeRadioButton2.Checked;
            */

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SaveToCSV(filePath);
                }
            }
        }
        private void SaveToCSV(string filePath)
        {
            List<string> lines = new List<string>();

            if (ModeRadioButton1.Checked)
            {
                for (int i = 0; i <= 159; i++)
                {
                    var toggleButton = tableLayoutPanel1.Controls["S" + i] as CheckBox;
                    if (toggleButton != null)
                    {
                        string state = toggleButton.Checked ? "1" : "0";

                        // Save voltageComboBox.SelectedItem only on the first row
                        string value = (i == 0) ? voltageComboBox.SelectedItem?.ToString() : "";

                        lines.Add($"{state},{value}");
                    }
                }
            }
            else
            {
                for (int i = 0; i <= 159; i++)
                {
                    var toggleButton = tableLayoutPanel1.Controls["S" + i] as CheckBox;
                    var comboBox = tableLayoutPanel1.Controls["V" + i] as ComboBox;

                    if (toggleButton != null && comboBox != null)
                    {
                        string state = toggleButton.Checked ? "1" : "0";
                        string value = comboBox.SelectedItem?.ToString();

                        lines.Add($"{state},{value}");
                    }
                }
            }

            try
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadFromCSV(filePath);
                }
            }
        }
        private void LoadFromCSV(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (ModeRadioButton1.Checked)
                {
                    for (int i = 0; i <= 159 && i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length != 2) continue;

                        var toggleButton = tableLayoutPanel1.Controls["S" + i] as CheckBox;
                        if (toggleButton != null)
                        {
                            toggleButton.Checked = parts[0] == "1";
                        }

                        if (i == 0)  // Only update voltageComboBox for the first line
                        {
                            voltageComboBox.SelectedItem = parts[1];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= 159 && i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length != 2) continue;

                        var toggleButton = tableLayoutPanel1.Controls["S" + i] as CheckBox;
                        var comboBox = tableLayoutPanel1.Controls["V" + i] as ComboBox;

                        if (toggleButton != null)
                        {
                            toggleButton.Checked = parts[0] == "1";
                        }

                        if (comboBox != null)
                        {
                            comboBox.SelectedItem = parts[1];
                        }
                    }
                }

                MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private List<string> GetComPortsByVidPid(string vid, string pid)
        {
            List<string> comPorts = new List<string>();
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["Name"] != null && queryObj["Name"].ToString().Contains("COM"))
                {
                    if (queryObj["PNPDeviceID"].ToString().Contains($"VID_{vid}&PID_{pid}"))
                    {
                        comPorts.Add(queryObj["Name"].ToString().Split('(')[1].Replace(")", "").Trim());
                    }
                }
            }
            return comPorts;
        }
        private void InitializeVoltageComboBox()
        {
            
            voltageComboBox.Items.Clear();
            for (int voltage = 0; voltage <= 18000; voltage += 100)
            {
                voltageComboBox.Items.Add(voltage.ToString());
            }
            voltageComboBox.SelectedIndex = 0;

        }
        private void UpdateDeviceStatus()
        {
            // Get the filtered COM ports based on VID and PID
            //var ports = GetComPortsByVidPid("2341", "0043"); //Arduino uno
            //var ports = GetComPortsByVidPid("1A86", "55D4");//CH340G/C
            //var ports = GetComPortsByVidPid("1A86", "7523");//CH9102
            var ports = GetComPortsByVidPid("1A86", "7522");// CH340K

            // If a port is found
            if (ports.Count > 0)
            {
                string selectedPort = ports[0]; // Take the first available port
                serialPort = new SerialPort(selectedPort, 115200);

                // ... (rest of your serial port initialization code) ...

                // Set the PictureBox to show the green circle
                deviceStatusPictureBox.Image = Properties.Resources.GreenCircle; // assuming the green circle image is named "GreenCircle"
            }
            else
            {
                // If no device is found, set the PictureBox to show the red circle
                deviceStatusPictureBox.Image = Properties.Resources.RedCircle; // assuming the red circle image is named "RedCircle"
            }

        }

        private void InitializeV(int index)
        {
            if (index < 0 || index >= voltageComboBoxes.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
            }

            var targetComboBox = voltageComboBoxes[index];

            targetComboBox.Items.Clear();
            for (int voltage = 0; voltage <= 18000; voltage += 100)
            {
                targetComboBox.Items.Add(voltage.ToString());
            }
            targetComboBox.SelectedIndex = 0;
        }

        /*
        private void InitializeV0()
        {
            V0.Items.Clear();
            for (int voltage = 0; voltage <= 18000; voltage += 100)
            {
                V0.Items.Add(voltage.ToString());
            }
            V0.SelectedIndex = 0;
        }
        */
        /*
        
        */

        private async void setVoltageButton_Click(object sender, EventArgs e)
        {

            
            if (serialPort != null && serialPort.IsOpen)
            {
                // Create a byte array of size 20 to store the states of 160 toggle switches

                for (int i = 0; i < 160; i += 8)
                {
                    byte value = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        Control control = tableLayoutPanel1.Controls["S" + (i + j)];
                        if (control is RJToggleButton toggleButton && toggleButton.Checked)
                        {
                            value |= (byte)(1 << j);
                        }
                    }

                    // Store the byte value in the appropriate position in the byteArray
                    byteArray[i / 8] = value;
                }

                int index = 0;

                for (int i = 0; i < 160; i++)
                {
                    Control control = tableLayoutPanel1.Controls["V" + i];
                    if (control is ComboBox comboBox)
                    {
                        // Assuming the ComboBox contains integers as its items.
                        short selectedValue = Convert.ToInt16(comboBox.SelectedItem);
                        valuesArray[index] = selectedValue;
                        index++;
                        Console.WriteLine(selectedValue);
                    }
                }


                serialPort.Write("AT+STSS:");
                if(OnOffButton.Checked)
                {
                    serialPort.Write(new byte[] { 1 }, 0, 1);
                }
                else
                {
                    serialPort.Write(new byte[] { 0 }, 0, 1);
                }
                if (ModeRadioButton1.Checked)
                {
                    serialPort.Write(new byte[] { 0 }, 0, 1);
                    serialPort.Write(byteArray, 0, byteArray.Length);
                    short tempV = CopySelectedValueToShort(voltageComboBox);
                    lsb = (byte)(tempV & 0xFF);         // Least Significant Byte
                    msb = (byte)((tempV >> 8) & 0xFF);  // Most Significant Byte
                    serialPort.Write(new byte[] { msb }, 0, 1);
                    serialPort.Write(new byte[] { lsb }, 0, 1);
                }
                else
                {
                    serialPort.Write(new byte[] { 1 }, 0, 1);
                    serialPort.Write(byteArray, 0, byteArray.Length);
                   
                    for( int i = 0; i < 160; i++)
                    {
                        tempV = valuesArray[i];
                        lsb = (byte)(tempV & 0xFF);         // Least Significant Byte
                        msb = (byte)((tempV >> 8) & 0xFF);  // Most Significant Byte
                        serialPort.Write(new byte[] { msb }, 0, 1);
                        serialPort.Write(new byte[] { lsb }, 0, 1);
                    }
                }
                //await Task.Delay(500);
                if (!receiveSignal.WaitOne(1000))
                {
                    // If this line is reached, then no response was received within 5 seconds
                    ShowWarning("Communication error");
                    return;
                }
                else
                {
                    ShowSuccess("Data Sent Successfully!!");
                    return;
                }
            }
            else
            {
                OnOffButton.Checked = false;
                ShowWarning("The port is closed. Please connect first.");
            }
            // ... [Any other code you might have at the end of the method]
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the data from the serial port
            string receivedData = serialPort.ReadExisting();

            // Check if received data is the expected response
            if (IsValidResponse(receivedData))
            {
                receiveSignal.Set();
            }
        }

        private bool IsValidResponse(string data)
        {
            return data.StartsWith("AT+ACK") ;
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                //var ports = GetComPortsByVidPid("2341", "0043");//Arduino uno
                //var ports = GetComPortsByVidPid("1A86", "55D4");//CH9102
                //var ports = GetComPortsByVidPid("1A86", "7523");//CH340G/C
                var ports = GetComPortsByVidPid("1A86", "7522");// CH340K

                // If no port is found
                if (ports.Count == 0)
                {
                    ShowWarning("Device not found.");
                    return;
                }
                //serialPort = new SerialPort(selectedPort, 115200);
                // Set Handshake to None
                serialPort.Handshake = Handshake.None;

                    serialPort.DtrEnable = false;  // Set DTR line to low
                    serialPort.Open();
                    connectButton.Text = "Disconnect";
                    isConnected = true;
                    System.Threading.Thread.Sleep(50);  // Wait for a short duration
                    serialPort.DtrEnable = true;   // Set DTR line to high
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                    //serialPort.Write(":");

            }
            else
            {
                serialPort.Close();
                connectButton.Text = "Connect"; 
                OnOffButton.Checked = false;
                isConnected = false;
            }
        }
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /*
        private void ShowWarning(string message)
        {
            WarningDialog warningDialog = new WarningDialog(message);
            warningDialog.StartPosition = FormStartPosition.CenterParent;
            warningDialog.ShowDialog(this);
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }
        */
        private short CopySelectedValueToShort(System.Windows.Forms.ComboBox comboBox)
        {
            if (short.TryParse(comboBox.Text, out short result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Invalid value selected.");
                return 0;
            }
        }


        public static void WriteRaw16BitToSerialPort(SerialPort serialPort, short value)
        {
            using (BinaryWriter writer = new BinaryWriter(serialPort.BaseStream))
            {
                writer.Write(value);
            }
        }
    private void Form1_Load(object sender, EventArgs e)
        {
             //Initialize the timer
            updateDeviceTimer = new System.Windows.Forms.Timer();
            updateDeviceTimer.Interval = 2000; // 2 seconds
            updateDeviceTimer.Tick += UpdateDeviceTimer_Tick;
            updateDeviceTimer.Start();
        }
        private void UpdateDeviceTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                connectButton.Text = "Connect";
                OnOffButton.Checked = false;
                UpdateDeviceStatus();
            }
        }
        private void comPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void voltageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(ModeRadioButton1.Checked)
            {
                V0.SelectedIndex = voltageComboBox.SelectedIndex;
                V1.SelectedIndex = voltageComboBox.SelectedIndex;
                V2.SelectedIndex = voltageComboBox.SelectedIndex;
                V3.SelectedIndex = voltageComboBox.SelectedIndex;
                V4.SelectedIndex = voltageComboBox.SelectedIndex;
                V5.SelectedIndex = voltageComboBox.SelectedIndex;
                V6.SelectedIndex = voltageComboBox.SelectedIndex;
                V7.SelectedIndex = voltageComboBox.SelectedIndex;
                V8.SelectedIndex = voltageComboBox.SelectedIndex;
                V9.SelectedIndex = voltageComboBox.SelectedIndex;
                V10.SelectedIndex = voltageComboBox.SelectedIndex;
                V11.SelectedIndex = voltageComboBox.SelectedIndex;
                V12.SelectedIndex = voltageComboBox.SelectedIndex;
                V13.SelectedIndex = voltageComboBox.SelectedIndex;
                V14.SelectedIndex = voltageComboBox.SelectedIndex;
                V15.SelectedIndex = voltageComboBox.SelectedIndex;
                V16.SelectedIndex = voltageComboBox.SelectedIndex;
                V17.SelectedIndex = voltageComboBox.SelectedIndex;
                V18.SelectedIndex = voltageComboBox.SelectedIndex;
                V19.SelectedIndex = voltageComboBox.SelectedIndex;
                V20.SelectedIndex = voltageComboBox.SelectedIndex;
                V21.SelectedIndex = voltageComboBox.SelectedIndex;
                V22.SelectedIndex = voltageComboBox.SelectedIndex;
                V23.SelectedIndex = voltageComboBox.SelectedIndex;
                V24.SelectedIndex = voltageComboBox.SelectedIndex;
                V25.SelectedIndex = voltageComboBox.SelectedIndex;
                V26.SelectedIndex = voltageComboBox.SelectedIndex;
                V27.SelectedIndex = voltageComboBox.SelectedIndex;
                V28.SelectedIndex = voltageComboBox.SelectedIndex;
                V29.SelectedIndex = voltageComboBox.SelectedIndex;
                V30.SelectedIndex = voltageComboBox.SelectedIndex;
                V31.SelectedIndex = voltageComboBox.SelectedIndex;
                V32.SelectedIndex = voltageComboBox.SelectedIndex;
                V33.SelectedIndex = voltageComboBox.SelectedIndex;
                V34.SelectedIndex = voltageComboBox.SelectedIndex;
                V35.SelectedIndex = voltageComboBox.SelectedIndex;
                V36.SelectedIndex = voltageComboBox.SelectedIndex;
                V37.SelectedIndex = voltageComboBox.SelectedIndex;
                V38.SelectedIndex = voltageComboBox.SelectedIndex;
                V39.SelectedIndex = voltageComboBox.SelectedIndex;
                V40.SelectedIndex = voltageComboBox.SelectedIndex;
                V41.SelectedIndex = voltageComboBox.SelectedIndex;
                V42.SelectedIndex = voltageComboBox.SelectedIndex;
                V43.SelectedIndex = voltageComboBox.SelectedIndex;
                V44.SelectedIndex = voltageComboBox.SelectedIndex;
                V45.SelectedIndex = voltageComboBox.SelectedIndex;
                V46.SelectedIndex = voltageComboBox.SelectedIndex;
                V47.SelectedIndex = voltageComboBox.SelectedIndex;
                V48.SelectedIndex = voltageComboBox.SelectedIndex;
                V49.SelectedIndex = voltageComboBox.SelectedIndex;
                V50.SelectedIndex = voltageComboBox.SelectedIndex;
                V51.SelectedIndex = voltageComboBox.SelectedIndex;
                V52.SelectedIndex = voltageComboBox.SelectedIndex;
                V53.SelectedIndex = voltageComboBox.SelectedIndex;
                V54.SelectedIndex = voltageComboBox.SelectedIndex;
                V55.SelectedIndex = voltageComboBox.SelectedIndex;
                V56.SelectedIndex = voltageComboBox.SelectedIndex;
                V57.SelectedIndex = voltageComboBox.SelectedIndex;
                V58.SelectedIndex = voltageComboBox.SelectedIndex;
                V59.SelectedIndex = voltageComboBox.SelectedIndex;
                V60.SelectedIndex = voltageComboBox.SelectedIndex;
                V61.SelectedIndex = voltageComboBox.SelectedIndex;
                V62.SelectedIndex = voltageComboBox.SelectedIndex;
                V63.SelectedIndex = voltageComboBox.SelectedIndex;
                V64.SelectedIndex = voltageComboBox.SelectedIndex;
                V65.SelectedIndex = voltageComboBox.SelectedIndex;
                V66.SelectedIndex = voltageComboBox.SelectedIndex;
                V67.SelectedIndex = voltageComboBox.SelectedIndex;
                V68.SelectedIndex = voltageComboBox.SelectedIndex;
                V69.SelectedIndex = voltageComboBox.SelectedIndex;
                V70.SelectedIndex = voltageComboBox.SelectedIndex;
                V71.SelectedIndex = voltageComboBox.SelectedIndex;
                V72.SelectedIndex = voltageComboBox.SelectedIndex;
                V73.SelectedIndex = voltageComboBox.SelectedIndex;
                V74.SelectedIndex = voltageComboBox.SelectedIndex;
                V75.SelectedIndex = voltageComboBox.SelectedIndex;
                V76.SelectedIndex = voltageComboBox.SelectedIndex;
                V77.SelectedIndex = voltageComboBox.SelectedIndex;
                V78.SelectedIndex = voltageComboBox.SelectedIndex;
                V79.SelectedIndex = voltageComboBox.SelectedIndex;
                V80.SelectedIndex = voltageComboBox.SelectedIndex;
                V81.SelectedIndex = voltageComboBox.SelectedIndex;
                V82.SelectedIndex = voltageComboBox.SelectedIndex;
                V83.SelectedIndex = voltageComboBox.SelectedIndex;
                V84.SelectedIndex = voltageComboBox.SelectedIndex;
                V85.SelectedIndex = voltageComboBox.SelectedIndex;
                V86.SelectedIndex = voltageComboBox.SelectedIndex;
                V87.SelectedIndex = voltageComboBox.SelectedIndex;
                V88.SelectedIndex = voltageComboBox.SelectedIndex;
                V89.SelectedIndex = voltageComboBox.SelectedIndex;
                V90.SelectedIndex = voltageComboBox.SelectedIndex;
                V91.SelectedIndex = voltageComboBox.SelectedIndex;
                V92.SelectedIndex = voltageComboBox.SelectedIndex;
                V93.SelectedIndex = voltageComboBox.SelectedIndex;
                V94.SelectedIndex = voltageComboBox.SelectedIndex;
                V95.SelectedIndex = voltageComboBox.SelectedIndex;
                V96.SelectedIndex = voltageComboBox.SelectedIndex;
                V97.SelectedIndex = voltageComboBox.SelectedIndex;
                V98.SelectedIndex = voltageComboBox.SelectedIndex;
                V99.SelectedIndex = voltageComboBox.SelectedIndex;
                V100.SelectedIndex = voltageComboBox.SelectedIndex;
                V101.SelectedIndex = voltageComboBox.SelectedIndex;
                V102.SelectedIndex = voltageComboBox.SelectedIndex;
                V103.SelectedIndex = voltageComboBox.SelectedIndex;
                V104.SelectedIndex = voltageComboBox.SelectedIndex;
                V105.SelectedIndex = voltageComboBox.SelectedIndex;
                V106.SelectedIndex = voltageComboBox.SelectedIndex;
                V107.SelectedIndex = voltageComboBox.SelectedIndex;
                V108.SelectedIndex = voltageComboBox.SelectedIndex;
                V109.SelectedIndex = voltageComboBox.SelectedIndex;
                V110.SelectedIndex = voltageComboBox.SelectedIndex;
                V111.SelectedIndex = voltageComboBox.SelectedIndex;
                V112.SelectedIndex = voltageComboBox.SelectedIndex;
                V113.SelectedIndex = voltageComboBox.SelectedIndex;
                V114.SelectedIndex = voltageComboBox.SelectedIndex;
                V115.SelectedIndex = voltageComboBox.SelectedIndex;
                V116.SelectedIndex = voltageComboBox.SelectedIndex;
                V117.SelectedIndex = voltageComboBox.SelectedIndex;
                V118.SelectedIndex = voltageComboBox.SelectedIndex;
                V119.SelectedIndex = voltageComboBox.SelectedIndex;
                V120.SelectedIndex = voltageComboBox.SelectedIndex;
                V121.SelectedIndex = voltageComboBox.SelectedIndex;
                V122.SelectedIndex = voltageComboBox.SelectedIndex;
                V123.SelectedIndex = voltageComboBox.SelectedIndex;
                V124.SelectedIndex = voltageComboBox.SelectedIndex;
                V125.SelectedIndex = voltageComboBox.SelectedIndex;
                V126.SelectedIndex = voltageComboBox.SelectedIndex;
                V127.SelectedIndex = voltageComboBox.SelectedIndex;
                V128.SelectedIndex = voltageComboBox.SelectedIndex;
                V129.SelectedIndex = voltageComboBox.SelectedIndex;
                V130.SelectedIndex = voltageComboBox.SelectedIndex;
                V131.SelectedIndex = voltageComboBox.SelectedIndex;
                V132.SelectedIndex = voltageComboBox.SelectedIndex;
                V133.SelectedIndex = voltageComboBox.SelectedIndex;
                V134.SelectedIndex = voltageComboBox.SelectedIndex;
                V135.SelectedIndex = voltageComboBox.SelectedIndex;
                V136.SelectedIndex = voltageComboBox.SelectedIndex;
                V137.SelectedIndex = voltageComboBox.SelectedIndex;
                V138.SelectedIndex = voltageComboBox.SelectedIndex;
                V139.SelectedIndex = voltageComboBox.SelectedIndex;
                V140.SelectedIndex = voltageComboBox.SelectedIndex;
                V141.SelectedIndex = voltageComboBox.SelectedIndex;
                V142.SelectedIndex = voltageComboBox.SelectedIndex;
                V143.SelectedIndex = voltageComboBox.SelectedIndex;
                V144.SelectedIndex = voltageComboBox.SelectedIndex;
                V145.SelectedIndex = voltageComboBox.SelectedIndex;
                V146.SelectedIndex = voltageComboBox.SelectedIndex;
                V147.SelectedIndex = voltageComboBox.SelectedIndex;
                V148.SelectedIndex = voltageComboBox.SelectedIndex;
                V149.SelectedIndex = voltageComboBox.SelectedIndex;
                V150.SelectedIndex = voltageComboBox.SelectedIndex;
                V151.SelectedIndex = voltageComboBox.SelectedIndex;
                V152.SelectedIndex = voltageComboBox.SelectedIndex;
                V153.SelectedIndex = voltageComboBox.SelectedIndex;
                V154.SelectedIndex = voltageComboBox.SelectedIndex;
                V155.SelectedIndex = voltageComboBox.SelectedIndex;
                V156.SelectedIndex = voltageComboBox.SelectedIndex;
                V157.SelectedIndex = voltageComboBox.SelectedIndex;
                V158.SelectedIndex = voltageComboBox.SelectedIndex;
                V159.SelectedIndex = voltageComboBox.SelectedIndex;

            }
            

        }

        private void ModeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            voltageComboBox.Visible = ModeRadioButton1.Checked;
            V0.Enabled = false;
            V1.Enabled = false;
            V2.Enabled = false;
            V3.Enabled = false;
            V4.Enabled = false;
            V5.Enabled = false;
            V6.Enabled = false;
            V7.Enabled = false;
            V8.Enabled = false;
            V9.Enabled = false;
            V10.Enabled = false;
            V11.Enabled = false;
            V12.Enabled = false;
            V13.Enabled = false;
            V14.Enabled = false;
            V15.Enabled = false;
            V16.Enabled = false;
            V17.Enabled = false;
            V18.Enabled = false;
            V19.Enabled = false;
            V20.Enabled = false;
            V21.Enabled = false;
            V22.Enabled = false;
            V23.Enabled = false;
            V24.Enabled = false;
            V25.Enabled = false;
            V26.Enabled = false;
            V27.Enabled = false;
            V28.Enabled = false;
            V29.Enabled = false;
            V30.Enabled = false;
            V31.Enabled = false;
            V32.Enabled = false;
            V33.Enabled = false;
            V34.Enabled = false;
            V35.Enabled = false;
            V36.Enabled = false;
            V37.Enabled = false;
            V38.Enabled = false;
            V39.Enabled = false;
            V40.Enabled = false;
            V41.Enabled = false;
            V42.Enabled = false;
            V43.Enabled = false;
            V44.Enabled = false;
            V45.Enabled = false;
            V46.Enabled = false;
            V47.Enabled = false;
            V48.Enabled = false;
            V49.Enabled = false;
            V50.Enabled = false;
            V51.Enabled = false;
            V52.Enabled = false;
            V53.Enabled = false;
            V54.Enabled = false;
            V55.Enabled = false;
            V56.Enabled = false;
            V57.Enabled = false;
            V58.Enabled = false;
            V59.Enabled = false;
            V60.Enabled = false;
            V61.Enabled = false;
            V62.Enabled = false;
            V63.Enabled = false;
            V64.Enabled = false;
            V65.Enabled = false;
            V66.Enabled = false;
            V67.Enabled = false;
            V68.Enabled = false;
            V69.Enabled = false;
            V70.Enabled = false;
            V71.Enabled = false;
            V72.Enabled = false;
            V73.Enabled = false;
            V74.Enabled = false;
            V75.Enabled = false;
            V76.Enabled = false;
            V77.Enabled = false;
            V78.Enabled = false;
            V79.Enabled = false;
            V80.Enabled = false;
            V81.Enabled = false;
            V82.Enabled = false;
            V83.Enabled = false;
            V84.Enabled = false;
            V85.Enabled = false;
            V86.Enabled = false;
            V87.Enabled = false;
            V88.Enabled = false;
            V89.Enabled = false;
            V90.Enabled = false;
            V91.Enabled = false;
            V92.Enabled = false;
            V93.Enabled = false;
            V94.Enabled = false;
            V95.Enabled = false;
            V96.Enabled = false;
            V97.Enabled = false;
            V98.Enabled = false;
            V99.Enabled = false;
            V100.Enabled = false;
            V101.Enabled = false;
            V102.Enabled = false;
            V103.Enabled = false;
            V104.Enabled = false;
            V105.Enabled = false;
            V106.Enabled = false;
            V107.Enabled = false;
            V108.Enabled = false;
            V109.Enabled = false;
            V110.Enabled = false;
            V111.Enabled = false;
            V112.Enabled = false;
            V113.Enabled = false;
            V114.Enabled = false;
            V115.Enabled = false;
            V116.Enabled = false;
            V117.Enabled = false;
            V118.Enabled = false;
            V119.Enabled = false;
            V120.Enabled = false;
            V121.Enabled = false;
            V122.Enabled = false;
            V123.Enabled = false;
            V124.Enabled = false;
            V125.Enabled = false;
            V126.Enabled = false;
            V127.Enabled = false;
            V128.Enabled = false;
            V129.Enabled = false;
            V130.Enabled = false;
            V131.Enabled = false;
            V132.Enabled = false;
            V133.Enabled = false;
            V134.Enabled = false;
            V135.Enabled = false;
            V136.Enabled = false;
            V137.Enabled = false;
            V138.Enabled = false;
            V139.Enabled = false;
            V140.Enabled = false;
            V141.Enabled = false;
            V142.Enabled = false;
            V143.Enabled = false;
            V144.Enabled = false;
            V145.Enabled = false;
            V146.Enabled = false;
            V147.Enabled = false;
            V148.Enabled = false;
            V149.Enabled = false;
            V150.Enabled = false;
            V151.Enabled = false;
            V152.Enabled = false;
            V153.Enabled = false;
            V154.Enabled = false;
            V155.Enabled = false;
            V156.Enabled = false;
            V157.Enabled = false;
            V158.Enabled = false;
            V159.Enabled = false;
        }

        private void ModeRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeRadioButton2.Checked)
            {



                V0.Enabled = true;
                V1.Enabled = true;
                V2.Enabled = true;
                V3.Enabled = true;
                V4.Enabled = true;
                V5.Enabled = true;
                V6.Enabled = true;
                V7.Enabled = true;
                V8.Enabled = true;
                V9.Enabled = true;
                V10.Enabled = true;
                V11.Enabled = true;
                V12.Enabled = true;
                V13.Enabled = true;
                V14.Enabled = true;
                V15.Enabled = true;
                V16.Enabled = true;
                V17.Enabled = true;
                V18.Enabled = true;
                V19.Enabled = true;
                V20.Enabled = true;
                V21.Enabled = true;
                V22.Enabled = true;
                V23.Enabled = true;
                V24.Enabled = true;
                V25.Enabled = true;
                V26.Enabled = true;
                V27.Enabled = true;
                V28.Enabled = true;
                V29.Enabled = true;
                V30.Enabled = true;
                V31.Enabled = true;
                V32.Enabled = true;
                V33.Enabled = true;
                V34.Enabled = true;
                V35.Enabled = true;
                V36.Enabled = true;
                V37.Enabled = true;
                V38.Enabled = true;
                V39.Enabled = true;
                V40.Enabled = true;
                V41.Enabled = true;
                V42.Enabled = true;
                V43.Enabled = true;
                V44.Enabled = true;
                V45.Enabled = true;
                V46.Enabled = true;
                V47.Enabled = true;
                V48.Enabled = true;
                V49.Enabled = true;
                V50.Enabled = true;
                V51.Enabled = true;
                V52.Enabled = true;
                V53.Enabled = true;
                V54.Enabled = true;
                V55.Enabled = true;
                V56.Enabled = true;
                V57.Enabled = true;
                V58.Enabled = true;
                V59.Enabled = true;
                V60.Enabled = true;
                V61.Enabled = true;
                V62.Enabled = true;
                V63.Enabled = true;
                V64.Enabled = true;
                V65.Enabled = true;
                V66.Enabled = true;
                V67.Enabled = true;
                V68.Enabled = true;
                V69.Enabled = true;
                V70.Enabled = true;
                V71.Enabled = true;
                V72.Enabled = true;
                V73.Enabled = true;
                V74.Enabled = true;
                V75.Enabled = true;
                V76.Enabled = true;
                V77.Enabled = true;
                V78.Enabled = true;
                V79.Enabled = true;
                V80.Enabled = true;
                V81.Enabled = true;
                V82.Enabled = true;
                V83.Enabled = true;
                V84.Enabled = true;
                V85.Enabled = true;
                V86.Enabled = true;
                V87.Enabled = true;
                V88.Enabled = true;
                V89.Enabled = true;
                V90.Enabled = true;
                V91.Enabled = true;
                V92.Enabled = true;
                V93.Enabled = true;
                V94.Enabled = true;
                V95.Enabled = true;
                V96.Enabled = true;
                V97.Enabled = true;
                V98.Enabled = true;
                V99.Enabled = true;
                V100.Enabled = true;
                V101.Enabled = true;
                V102.Enabled = true;
                V103.Enabled = true;
                V104.Enabled = true;
                V105.Enabled = true;
                V106.Enabled = true;
                V107.Enabled = true;
                V108.Enabled = true;
                V109.Enabled = true;
                V110.Enabled = true;
                V111.Enabled = true;
                V112.Enabled = true;
                V113.Enabled = true;
                V114.Enabled = true;
                V115.Enabled = true;
                V116.Enabled = true;
                V117.Enabled = true;
                V118.Enabled = true;
                V119.Enabled = true;
                V120.Enabled = true;
                V121.Enabled = true;
                V122.Enabled = true;
                V123.Enabled = true;
                V124.Enabled = true;
                V125.Enabled = true;
                V126.Enabled = true;
                V127.Enabled = true;
                V128.Enabled = true;
                V129.Enabled = true;
                V130.Enabled = true;
                V131.Enabled = true;
                V132.Enabled = true;
                V133.Enabled = true;
                V134.Enabled = true;
                V135.Enabled = true;
                V136.Enabled = true;
                V137.Enabled = true;
                V138.Enabled = true;
                V139.Enabled = true;
                V140.Enabled = true;
                V141.Enabled = true;
                V142.Enabled = true;
                V143.Enabled = true;
                V144.Enabled = true;
                V145.Enabled = true;
                V146.Enabled = true;
                V147.Enabled = true;
                V148.Enabled = true;
                V149.Enabled = true;
                V150.Enabled = true;
                V151.Enabled = true;
                V152.Enabled = true;
                V153.Enabled = true;
                V154.Enabled = true;
                V155.Enabled = true;
                V156.Enabled = true;
                V157.Enabled = true;
                V158.Enabled = true;
                V159.Enabled = true;



                V0.SelectedIndex = 0;
                V1.SelectedIndex = 0;
                V2.SelectedIndex = 0;
                V3.SelectedIndex = 0;
                V4.SelectedIndex = 0;
                V5.SelectedIndex = 0;
                V6.SelectedIndex = 0;
                V7.SelectedIndex = 0;
                V8.SelectedIndex = 0;
                V9.SelectedIndex = 0;
                V10.SelectedIndex = 0;
                V11.SelectedIndex = 0;
                V12.SelectedIndex = 0;
                V13.SelectedIndex = 0;
                V14.SelectedIndex = 0;
                V15.SelectedIndex = 0;
                V16.SelectedIndex = 0;
                V17.SelectedIndex = 0;
                V18.SelectedIndex = 0;
                V19.SelectedIndex = 0;
                V20.SelectedIndex = 0;
                V21.SelectedIndex = 0;
                V22.SelectedIndex = 0;
                V23.SelectedIndex = 0;
                V24.SelectedIndex = 0;
                V25.SelectedIndex = 0;
                V26.SelectedIndex = 0;
                V27.SelectedIndex = 0;
                V28.SelectedIndex = 0;
                V29.SelectedIndex = 0;
                V30.SelectedIndex = 0;
                V31.SelectedIndex = 0;
                V32.SelectedIndex = 0;
                V33.SelectedIndex = 0;
                V34.SelectedIndex = 0;
                V35.SelectedIndex = 0;
                V36.SelectedIndex = 0;
                V37.SelectedIndex = 0;
                V38.SelectedIndex = 0;
                V39.SelectedIndex = 0;
                V40.SelectedIndex = 0;
                V41.SelectedIndex = 0;
                V42.SelectedIndex = 0;
                V43.SelectedIndex = 0;
                V44.SelectedIndex = 0;
                V45.SelectedIndex = 0;
                V46.SelectedIndex = 0;
                V47.SelectedIndex = 0;
                V48.SelectedIndex = 0;
                V49.SelectedIndex = 0;
                V50.SelectedIndex = 0;
                V51.SelectedIndex = 0;
                V52.SelectedIndex = 0;
                V53.SelectedIndex = 0;
                V54.SelectedIndex = 0;
                V55.SelectedIndex = 0;
                V56.SelectedIndex = 0;
                V57.SelectedIndex = 0;
                V58.SelectedIndex = 0;
                V59.SelectedIndex = 0;
                V60.SelectedIndex = 0;
                V61.SelectedIndex = 0;
                V62.SelectedIndex = 0;
                V63.SelectedIndex = 0;
                V64.SelectedIndex = 0;
                V65.SelectedIndex = 0;
                V66.SelectedIndex = 0;
                V67.SelectedIndex = 0;
                V68.SelectedIndex = 0;
                V69.SelectedIndex = 0;
                V70.SelectedIndex = 0;
                V71.SelectedIndex = 0;
                V72.SelectedIndex = 0;
                V73.SelectedIndex = 0;
                V74.SelectedIndex = 0;
                V75.SelectedIndex = 0;
                V76.SelectedIndex = 0;
                V77.SelectedIndex = 0;
                V78.SelectedIndex = 0;
                V79.SelectedIndex = 0;
                V80.SelectedIndex = 0;
                V81.SelectedIndex = 0;
                V82.SelectedIndex = 0;
                V83.SelectedIndex = 0;
                V84.SelectedIndex = 0;
                V85.SelectedIndex = 0;
                V86.SelectedIndex = 0;
                V87.SelectedIndex = 0;
                V88.SelectedIndex = 0;
                V89.SelectedIndex = 0;
                V90.SelectedIndex = 0;
                V91.SelectedIndex = 0;
                V92.SelectedIndex = 0;
                V93.SelectedIndex = 0;
                V94.SelectedIndex = 0;
                V95.SelectedIndex = 0;
                V96.SelectedIndex = 0;
                V97.SelectedIndex = 0;
                V98.SelectedIndex = 0;
                V99.SelectedIndex = 0;
                V100.SelectedIndex = 0;
                V101.SelectedIndex = 0;
                V102.SelectedIndex = 0;
                V103.SelectedIndex = 0;
                V104.SelectedIndex = 0;
                V105.SelectedIndex = 0;
                V106.SelectedIndex = 0;
                V107.SelectedIndex = 0;
                V108.SelectedIndex = 0;
                V109.SelectedIndex = 0;
                V110.SelectedIndex = 0;
                V111.SelectedIndex = 0;
                V112.SelectedIndex = 0;
                V113.SelectedIndex = 0;
                V114.SelectedIndex = 0;
                V115.SelectedIndex = 0;
                V116.SelectedIndex = 0;
                V117.SelectedIndex = 0;
                V118.SelectedIndex = 0;
                V119.SelectedIndex = 0;
                V120.SelectedIndex = 0;
                V121.SelectedIndex = 0;
                V122.SelectedIndex = 0;
                V123.SelectedIndex = 0;
                V124.SelectedIndex = 0;
                V125.SelectedIndex = 0;
                V126.SelectedIndex = 0;
                V127.SelectedIndex = 0;
                V128.SelectedIndex = 0;
                V129.SelectedIndex = 0;
                V130.SelectedIndex = 0;
                V131.SelectedIndex = 0;
                V132.SelectedIndex = 0;
                V133.SelectedIndex = 0;
                V134.SelectedIndex = 0;
                V135.SelectedIndex = 0;
                V136.SelectedIndex = 0;
                V137.SelectedIndex = 0;
                V138.SelectedIndex = 0;
                V139.SelectedIndex = 0;
                V140.SelectedIndex = 0;
                V141.SelectedIndex = 0;
                V142.SelectedIndex = 0;
                V143.SelectedIndex = 0;
                V144.SelectedIndex = 0;
                V145.SelectedIndex = 0;
                V146.SelectedIndex = 0;
                V147.SelectedIndex = 0;
                V148.SelectedIndex = 0;
                V149.SelectedIndex = 0;
                V150.SelectedIndex = 0;
                V151.SelectedIndex = 0;
                V152.SelectedIndex = 0;
                V153.SelectedIndex = 0;
                V154.SelectedIndex = 0;
                V155.SelectedIndex = 0;
                V156.SelectedIndex = 0;
                V157.SelectedIndex = 0;
                V158.SelectedIndex = 0;
                V159.SelectedIndex = 0;

            }
            /*
            V0.Visible = ModeRadioButton2.Checked;
            V1.Visible = ModeRadioButton2.Checked;
            V2.Visible = ModeRadioButton2.Checked;
            V3.Visible = ModeRadioButton2.Checked;
            V4.Visible = ModeRadioButton2.Checked;
            V5.Visible = ModeRadioButton2.Checked;
            V6.Visible = ModeRadioButton2.Checked;
            V7.Visible = ModeRadioButton2.Checked;
            V8.Visible = ModeRadioButton2.Checked;
            V9.Visible = ModeRadioButton2.Checked;
            V10.Visible = ModeRadioButton2.Checked;
            V11.Visible = ModeRadioButton2.Checked;
            V12.Visible = ModeRadioButton2.Checked;
            V13.Visible = ModeRadioButton2.Checked;
            V14.Visible = ModeRadioButton2.Checked;
            V15.Visible = ModeRadioButton2.Checked;
            V16.Visible = ModeRadioButton2.Checked;
            V17.Visible = ModeRadioButton2.Checked;
            V18.Visible = ModeRadioButton2.Checked;
            V19.Visible = ModeRadioButton2.Checked;
            V20.Visible = ModeRadioButton2.Checked;
            V21.Visible = ModeRadioButton2.Checked;
            V22.Visible = ModeRadioButton2.Checked;
            V23.Visible = ModeRadioButton2.Checked;
            V24.Visible = ModeRadioButton2.Checked;
            V25.Visible = ModeRadioButton2.Checked;
            V26.Visible = ModeRadioButton2.Checked;
            V27.Visible = ModeRadioButton2.Checked;
            V28.Visible = ModeRadioButton2.Checked;
            V29.Visible = ModeRadioButton2.Checked;
            V30.Visible = ModeRadioButton2.Checked;
            V31.Visible = ModeRadioButton2.Checked;
            V32.Visible = ModeRadioButton2.Checked;
            V33.Visible = ModeRadioButton2.Checked;
            V34.Visible = ModeRadioButton2.Checked;
            V35.Visible = ModeRadioButton2.Checked;
            V36.Visible = ModeRadioButton2.Checked;
            V37.Visible = ModeRadioButton2.Checked;
            V38.Visible = ModeRadioButton2.Checked;
            V39.Visible = ModeRadioButton2.Checked;
            V40.Visible = ModeRadioButton2.Checked;
            V41.Visible = ModeRadioButton2.Checked;
            V42.Visible = ModeRadioButton2.Checked;
            V43.Visible = ModeRadioButton2.Checked;
            V44.Visible = ModeRadioButton2.Checked;
            V45.Visible = ModeRadioButton2.Checked;
            V46.Visible = ModeRadioButton2.Checked;
            V47.Visible = ModeRadioButton2.Checked;
            V48.Visible = ModeRadioButton2.Checked;
            V49.Visible = ModeRadioButton2.Checked;
            V50.Visible = ModeRadioButton2.Checked;
            V51.Visible = ModeRadioButton2.Checked;
            V52.Visible = ModeRadioButton2.Checked;
            V53.Visible = ModeRadioButton2.Checked;
            V54.Visible = ModeRadioButton2.Checked;
            V55.Visible = ModeRadioButton2.Checked;
            V56.Visible = ModeRadioButton2.Checked;
            V57.Visible = ModeRadioButton2.Checked;
            V58.Visible = ModeRadioButton2.Checked;
            V59.Visible = ModeRadioButton2.Checked;
            V60.Visible = ModeRadioButton2.Checked;
            V61.Visible = ModeRadioButton2.Checked;
            V62.Visible = ModeRadioButton2.Checked;
            V63.Visible = ModeRadioButton2.Checked;
            V64.Visible = ModeRadioButton2.Checked;
            V65.Visible = ModeRadioButton2.Checked;
            V66.Visible = ModeRadioButton2.Checked;
            V67.Visible = ModeRadioButton2.Checked;
            V68.Visible = ModeRadioButton2.Checked;
            V69.Visible = ModeRadioButton2.Checked;
            V70.Visible = ModeRadioButton2.Checked;
            V71.Visible = ModeRadioButton2.Checked;
            V72.Visible = ModeRadioButton2.Checked;
            V73.Visible = ModeRadioButton2.Checked;
            V74.Visible = ModeRadioButton2.Checked;
            V75.Visible = ModeRadioButton2.Checked;
            V76.Visible = ModeRadioButton2.Checked;
            V77.Visible = ModeRadioButton2.Checked;
            V78.Visible = ModeRadioButton2.Checked;
            V79.Visible = ModeRadioButton2.Checked;
            V80.Visible = ModeRadioButton2.Checked;
            V81.Visible = ModeRadioButton2.Checked;
            V82.Visible = ModeRadioButton2.Checked;
            V83.Visible = ModeRadioButton2.Checked;
            V84.Visible = ModeRadioButton2.Checked;
            V85.Visible = ModeRadioButton2.Checked;
            V86.Visible = ModeRadioButton2.Checked;
            V87.Visible = ModeRadioButton2.Checked;
            V88.Visible = ModeRadioButton2.Checked;
            V89.Visible = ModeRadioButton2.Checked;
            V90.Visible = ModeRadioButton2.Checked;
            V91.Visible = ModeRadioButton2.Checked;
            V92.Visible = ModeRadioButton2.Checked;
            V93.Visible = ModeRadioButton2.Checked;
            V94.Visible = ModeRadioButton2.Checked;
            V95.Visible = ModeRadioButton2.Checked;
            V96.Visible = ModeRadioButton2.Checked;
            V97.Visible = ModeRadioButton2.Checked;
            V98.Visible = ModeRadioButton2.Checked;
            V99.Visible = ModeRadioButton2.Checked;
            V100.Visible = ModeRadioButton2.Checked;
            V101.Visible = ModeRadioButton2.Checked;
            V102.Visible = ModeRadioButton2.Checked;
            V103.Visible = ModeRadioButton2.Checked;
            V104.Visible = ModeRadioButton2.Checked;
            V105.Visible = ModeRadioButton2.Checked;
            V106.Visible = ModeRadioButton2.Checked;
            V107.Visible = ModeRadioButton2.Checked;
            V108.Visible = ModeRadioButton2.Checked;
            V109.Visible = ModeRadioButton2.Checked;
            V110.Visible = ModeRadioButton2.Checked;
            V111.Visible = ModeRadioButton2.Checked;
            V112.Visible = ModeRadioButton2.Checked;
            V113.Visible = ModeRadioButton2.Checked;
            V114.Visible = ModeRadioButton2.Checked;
            V115.Visible = ModeRadioButton2.Checked;
            V116.Visible = ModeRadioButton2.Checked;
            V117.Visible = ModeRadioButton2.Checked;
            V118.Visible = ModeRadioButton2.Checked;
            V119.Visible = ModeRadioButton2.Checked;
            V120.Visible = ModeRadioButton2.Checked;
            V121.Visible = ModeRadioButton2.Checked;
            V122.Visible = ModeRadioButton2.Checked;
            V123.Visible = ModeRadioButton2.Checked;
            V124.Visible = ModeRadioButton2.Checked;
            V125.Visible = ModeRadioButton2.Checked;
            V126.Visible = ModeRadioButton2.Checked;
            V127.Visible = ModeRadioButton2.Checked;
            V128.Visible = ModeRadioButton2.Checked;
            V129.Visible = ModeRadioButton2.Checked;
            V130.Visible = ModeRadioButton2.Checked;
            V131.Visible = ModeRadioButton2.Checked;
            V132.Visible = ModeRadioButton2.Checked;
            V133.Visible = ModeRadioButton2.Checked;
            V134.Visible = ModeRadioButton2.Checked;
            V135.Visible = ModeRadioButton2.Checked;
            V136.Visible = ModeRadioButton2.Checked;
            V137.Visible = ModeRadioButton2.Checked;
            V138.Visible = ModeRadioButton2.Checked;
            V139.Visible = ModeRadioButton2.Checked;
            V140.Visible = ModeRadioButton2.Checked;
            V141.Visible = ModeRadioButton2.Checked;
            V142.Visible = ModeRadioButton2.Checked;
            V143.Visible = ModeRadioButton2.Checked;
            V144.Visible = ModeRadioButton2.Checked;
            V145.Visible = ModeRadioButton2.Checked;
            V146.Visible = ModeRadioButton2.Checked;
            V147.Visible = ModeRadioButton2.Checked;
            V148.Visible = ModeRadioButton2.Checked;
            V149.Visible = ModeRadioButton2.Checked;
            V150.Visible = ModeRadioButton2.Checked;
            V151.Visible = ModeRadioButton2.Checked;
            V152.Visible = ModeRadioButton2.Checked;
            V153.Visible = ModeRadioButton2.Checked;
            V154.Visible = ModeRadioButton2.Checked;
            V155.Visible = ModeRadioButton2.Checked;
            V156.Visible = ModeRadioButton2.Checked;
            V157.Visible = ModeRadioButton2.Checked;
            V158.Visible = ModeRadioButton2.Checked;
            V159.Visible = ModeRadioButton2.Checked;
            */

        }

  


        private void OnOffButton_CheckedChanged_1(object sender, EventArgs e)
        {


            if (serialPort != null && serialPort.IsOpen)
            {
                // Create a byte array of size 20 to store the states of 160 toggle switches

                for (int i = 0; i < 160; i += 8)
                {
                    byte value = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        Control control = tableLayoutPanel1.Controls["S" + (i + j)];
                        if (control is RJToggleButton toggleButton && toggleButton.Checked)
                        {
                            value |= (byte)(1 << j);
                        }
                    }

                    // Store the byte value in the appropriate position in the byteArray
                    byteArray[i / 8] = value;
                }

                int index = 0;

                for (int i = 0; i < 160; i++)
                {
                    Control control = tableLayoutPanel1.Controls["V" + i];
                    if (control is ComboBox comboBox)
                    {
                        // Assuming the ComboBox contains integers as its items.
                        short selectedValue = Convert.ToInt16(comboBox.SelectedItem);
                        valuesArray[index] = selectedValue;
                        index++;
                        Console.WriteLine(selectedValue);
                    }
                }


                serialPort.Write("AT+STSS:");
                if (OnOffButton.Checked)
                {
                    serialPort.Write(new byte[] { 1 }, 0, 1);
                }
                else
                {
                    serialPort.Write(new byte[] { 0 }, 0, 1);
                }
                if (ModeRadioButton1.Checked)
                {
                    serialPort.Write(new byte[] { 0 }, 0, 1);
                    serialPort.Write(byteArray, 0, byteArray.Length);
                    short tempV = CopySelectedValueToShort(voltageComboBox);
                    lsb = (byte)(tempV & 0xFF);         // Least Significant Byte
                    msb = (byte)((tempV >> 8) & 0xFF);  // Most Significant Byte
                    serialPort.Write(new byte[] { msb }, 0, 1);
                    serialPort.Write(new byte[] { lsb }, 0, 1);
                }
                else
                {
                    serialPort.Write(new byte[] { 1 }, 0, 1);
                    serialPort.Write(byteArray, 0, byteArray.Length);

                    for (int i = 0; i < 160; i++)
                    {
                        tempV = valuesArray[i];
                        lsb = (byte)(tempV & 0xFF);         // Least Significant Byte
                        msb = (byte)((tempV >> 8) & 0xFF);  // Most Significant Byte
                        serialPort.Write(new byte[] { msb }, 0, 1);
                        serialPort.Write(new byte[] { lsb }, 0, 1);
                    }
                }
                //await Task.Delay(500);
                if (!receiveSignal.WaitOne(1000))
                {
                    // If this line is reached, then no response was received within 5 seconds
                    ShowWarning("Communication error");
                    return;
                }
                else
                {
                    ShowSuccess("Data Sent Successfully!!");
                    return;
                }
            }
            else
            {
                OnOffButton.Checked = false;
                ShowWarning("The port is closed. Please connect first.");
            }
            // ... [Any other code you might have at the end of the method]
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
