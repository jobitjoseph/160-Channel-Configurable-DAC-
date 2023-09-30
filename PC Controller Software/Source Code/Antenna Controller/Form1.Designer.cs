using System.Drawing;

namespace Antenna_Controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviceStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.voltageComboBox = new System.Windows.Forms.ComboBox();
            this.setVoltageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.ModeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.V0 = new System.Windows.Forms.ComboBox();
            this.V159 = new System.Windows.Forms.ComboBox();
            this.V144 = new System.Windows.Forms.ComboBox();
            this.V158 = new System.Windows.Forms.ComboBox();
            this.V157 = new System.Windows.Forms.ComboBox();
            this.V143 = new System.Windows.Forms.ComboBox();
            this.V156 = new System.Windows.Forms.ComboBox();
            this.V155 = new System.Windows.Forms.ComboBox();
            this.V154 = new System.Windows.Forms.ComboBox();
            this.V153 = new System.Windows.Forms.ComboBox();
            this.V128 = new System.Windows.Forms.ComboBox();
            this.V152 = new System.Windows.Forms.ComboBox();
            this.V151 = new System.Windows.Forms.ComboBox();
            this.V142 = new System.Windows.Forms.ComboBox();
            this.V150 = new System.Windows.Forms.ComboBox();
            this.V149 = new System.Windows.Forms.ComboBox();
            this.V148 = new System.Windows.Forms.ComboBox();
            this.V147 = new System.Windows.Forms.ComboBox();
            this.V141 = new System.Windows.Forms.ComboBox();
            this.V146 = new System.Windows.Forms.ComboBox();
            this.V145 = new System.Windows.Forms.ComboBox();
            this.V127 = new System.Windows.Forms.ComboBox();
            this.V140 = new System.Windows.Forms.ComboBox();
            this.V139 = new System.Windows.Forms.ComboBox();
            this.V138 = new System.Windows.Forms.ComboBox();
            this.V137 = new System.Windows.Forms.ComboBox();
            this.V112 = new System.Windows.Forms.ComboBox();
            this.V136 = new System.Windows.Forms.ComboBox();
            this.V135 = new System.Windows.Forms.ComboBox();
            this.V126 = new System.Windows.Forms.ComboBox();
            this.V134 = new System.Windows.Forms.ComboBox();
            this.V133 = new System.Windows.Forms.ComboBox();
            this.V132 = new System.Windows.Forms.ComboBox();
            this.V131 = new System.Windows.Forms.ComboBox();
            this.V125 = new System.Windows.Forms.ComboBox();
            this.V130 = new System.Windows.Forms.ComboBox();
            this.V129 = new System.Windows.Forms.ComboBox();
            this.V111 = new System.Windows.Forms.ComboBox();
            this.V124 = new System.Windows.Forms.ComboBox();
            this.V123 = new System.Windows.Forms.ComboBox();
            this.V122 = new System.Windows.Forms.ComboBox();
            this.V121 = new System.Windows.Forms.ComboBox();
            this.V96 = new System.Windows.Forms.ComboBox();
            this.V120 = new System.Windows.Forms.ComboBox();
            this.V119 = new System.Windows.Forms.ComboBox();
            this.V110 = new System.Windows.Forms.ComboBox();
            this.V118 = new System.Windows.Forms.ComboBox();
            this.V117 = new System.Windows.Forms.ComboBox();
            this.V116 = new System.Windows.Forms.ComboBox();
            this.V115 = new System.Windows.Forms.ComboBox();
            this.V109 = new System.Windows.Forms.ComboBox();
            this.V114 = new System.Windows.Forms.ComboBox();
            this.V113 = new System.Windows.Forms.ComboBox();
            this.V95 = new System.Windows.Forms.ComboBox();
            this.V108 = new System.Windows.Forms.ComboBox();
            this.V107 = new System.Windows.Forms.ComboBox();
            this.V106 = new System.Windows.Forms.ComboBox();
            this.V105 = new System.Windows.Forms.ComboBox();
            this.V80 = new System.Windows.Forms.ComboBox();
            this.V104 = new System.Windows.Forms.ComboBox();
            this.V103 = new System.Windows.Forms.ComboBox();
            this.V94 = new System.Windows.Forms.ComboBox();
            this.V102 = new System.Windows.Forms.ComboBox();
            this.V101 = new System.Windows.Forms.ComboBox();
            this.V100 = new System.Windows.Forms.ComboBox();
            this.V99 = new System.Windows.Forms.ComboBox();
            this.V93 = new System.Windows.Forms.ComboBox();
            this.V98 = new System.Windows.Forms.ComboBox();
            this.V97 = new System.Windows.Forms.ComboBox();
            this.V79 = new System.Windows.Forms.ComboBox();
            this.V92 = new System.Windows.Forms.ComboBox();
            this.V91 = new System.Windows.Forms.ComboBox();
            this.V90 = new System.Windows.Forms.ComboBox();
            this.V89 = new System.Windows.Forms.ComboBox();
            this.V64 = new System.Windows.Forms.ComboBox();
            this.V88 = new System.Windows.Forms.ComboBox();
            this.V87 = new System.Windows.Forms.ComboBox();
            this.V78 = new System.Windows.Forms.ComboBox();
            this.V86 = new System.Windows.Forms.ComboBox();
            this.V85 = new System.Windows.Forms.ComboBox();
            this.V84 = new System.Windows.Forms.ComboBox();
            this.V83 = new System.Windows.Forms.ComboBox();
            this.V77 = new System.Windows.Forms.ComboBox();
            this.V82 = new System.Windows.Forms.ComboBox();
            this.V81 = new System.Windows.Forms.ComboBox();
            this.V63 = new System.Windows.Forms.ComboBox();
            this.V76 = new System.Windows.Forms.ComboBox();
            this.V75 = new System.Windows.Forms.ComboBox();
            this.V74 = new System.Windows.Forms.ComboBox();
            this.V73 = new System.Windows.Forms.ComboBox();
            this.V48 = new System.Windows.Forms.ComboBox();
            this.V72 = new System.Windows.Forms.ComboBox();
            this.V71 = new System.Windows.Forms.ComboBox();
            this.V62 = new System.Windows.Forms.ComboBox();
            this.V70 = new System.Windows.Forms.ComboBox();
            this.V69 = new System.Windows.Forms.ComboBox();
            this.V68 = new System.Windows.Forms.ComboBox();
            this.V67 = new System.Windows.Forms.ComboBox();
            this.V61 = new System.Windows.Forms.ComboBox();
            this.V66 = new System.Windows.Forms.ComboBox();
            this.V65 = new System.Windows.Forms.ComboBox();
            this.V60 = new System.Windows.Forms.ComboBox();
            this.V59 = new System.Windows.Forms.ComboBox();
            this.V58 = new System.Windows.Forms.ComboBox();
            this.V57 = new System.Windows.Forms.ComboBox();
            this.V33 = new System.Windows.Forms.ComboBox();
            this.V56 = new System.Windows.Forms.ComboBox();
            this.V55 = new System.Windows.Forms.ComboBox();
            this.V54 = new System.Windows.Forms.ComboBox();
            this.V53 = new System.Windows.Forms.ComboBox();
            this.V52 = new System.Windows.Forms.ComboBox();
            this.V51 = new System.Windows.Forms.ComboBox();
            this.V50 = new System.Windows.Forms.ComboBox();
            this.V49 = new System.Windows.Forms.ComboBox();
            this.V31 = new System.Windows.Forms.ComboBox();
            this.V30 = new System.Windows.Forms.ComboBox();
            this.V29 = new System.Windows.Forms.ComboBox();
            this.V28 = new System.Windows.Forms.ComboBox();
            this.V27 = new System.Windows.Forms.ComboBox();
            this.V25 = new System.Windows.Forms.ComboBox();
            this.V26 = new System.Windows.Forms.ComboBox();
            this.V24 = new System.Windows.Forms.ComboBox();
            this.V23 = new System.Windows.Forms.ComboBox();
            this.V22 = new System.Windows.Forms.ComboBox();
            this.V21 = new System.Windows.Forms.ComboBox();
            this.V20 = new System.Windows.Forms.ComboBox();
            this.V18 = new System.Windows.Forms.ComboBox();
            this.V16 = new System.Windows.Forms.ComboBox();
            this.V1 = new System.Windows.Forms.ComboBox();
            this.V2 = new System.Windows.Forms.ComboBox();
            this.V3 = new System.Windows.Forms.ComboBox();
            this.V4 = new System.Windows.Forms.ComboBox();
            this.V5 = new System.Windows.Forms.ComboBox();
            this.V6 = new System.Windows.Forms.ComboBox();
            this.V7 = new System.Windows.Forms.ComboBox();
            this.V8 = new System.Windows.Forms.ComboBox();
            this.V9 = new System.Windows.Forms.ComboBox();
            this.V10 = new System.Windows.Forms.ComboBox();
            this.V11 = new System.Windows.Forms.ComboBox();
            this.V12 = new System.Windows.Forms.ComboBox();
            this.V13 = new System.Windows.Forms.ComboBox();
            this.V14 = new System.Windows.Forms.ComboBox();
            this.V15 = new System.Windows.Forms.ComboBox();
            this.V17 = new System.Windows.Forms.ComboBox();
            this.V19 = new System.Windows.Forms.ComboBox();
            this.V32 = new System.Windows.Forms.ComboBox();
            this.V34 = new System.Windows.Forms.ComboBox();
            this.V35 = new System.Windows.Forms.ComboBox();
            this.V36 = new System.Windows.Forms.ComboBox();
            this.V37 = new System.Windows.Forms.ComboBox();
            this.V38 = new System.Windows.Forms.ComboBox();
            this.V39 = new System.Windows.Forms.ComboBox();
            this.V40 = new System.Windows.Forms.ComboBox();
            this.V41 = new System.Windows.Forms.ComboBox();
            this.V42 = new System.Windows.Forms.ComboBox();
            this.V43 = new System.Windows.Forms.ComboBox();
            this.V44 = new System.Windows.Forms.ComboBox();
            this.V45 = new System.Windows.Forms.ComboBox();
            this.V46 = new System.Windows.Forms.ComboBox();
            this.V47 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LoadButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OnOffButton = new CustomControls.RJControls.RJToggleButton();
            this.S144 = new CustomControls.RJControls.RJToggleButton();
            this.S159 = new CustomControls.RJControls.RJToggleButton();
            this.S158 = new CustomControls.RJControls.RJToggleButton();
            this.S128 = new CustomControls.RJControls.RJToggleButton();
            this.S157 = new CustomControls.RJControls.RJToggleButton();
            this.S156 = new CustomControls.RJControls.RJToggleButton();
            this.S155 = new CustomControls.RJControls.RJToggleButton();
            this.S143 = new CustomControls.RJControls.RJToggleButton();
            this.S154 = new CustomControls.RJControls.RJToggleButton();
            this.S153 = new CustomControls.RJControls.RJToggleButton();
            this.S152 = new CustomControls.RJControls.RJToggleButton();
            this.S151 = new CustomControls.RJControls.RJToggleButton();
            this.S142 = new CustomControls.RJControls.RJToggleButton();
            this.S150 = new CustomControls.RJControls.RJToggleButton();
            this.S149 = new CustomControls.RJControls.RJToggleButton();
            this.S112 = new CustomControls.RJControls.RJToggleButton();
            this.S148 = new CustomControls.RJControls.RJToggleButton();
            this.S147 = new CustomControls.RJControls.RJToggleButton();
            this.S141 = new CustomControls.RJControls.RJToggleButton();
            this.S146 = new CustomControls.RJControls.RJToggleButton();
            this.S145 = new CustomControls.RJControls.RJToggleButton();
            this.S140 = new CustomControls.RJControls.RJToggleButton();
            this.S139 = new CustomControls.RJControls.RJToggleButton();
            this.S127 = new CustomControls.RJControls.RJToggleButton();
            this.S138 = new CustomControls.RJControls.RJToggleButton();
            this.S137 = new CustomControls.RJControls.RJToggleButton();
            this.S136 = new CustomControls.RJControls.RJToggleButton();
            this.S135 = new CustomControls.RJControls.RJToggleButton();
            this.S126 = new CustomControls.RJControls.RJToggleButton();
            this.S134 = new CustomControls.RJControls.RJToggleButton();
            this.S133 = new CustomControls.RJControls.RJToggleButton();
            this.S96 = new CustomControls.RJControls.RJToggleButton();
            this.S132 = new CustomControls.RJControls.RJToggleButton();
            this.S131 = new CustomControls.RJControls.RJToggleButton();
            this.S125 = new CustomControls.RJControls.RJToggleButton();
            this.S130 = new CustomControls.RJControls.RJToggleButton();
            this.S129 = new CustomControls.RJControls.RJToggleButton();
            this.S124 = new CustomControls.RJControls.RJToggleButton();
            this.S123 = new CustomControls.RJControls.RJToggleButton();
            this.S111 = new CustomControls.RJControls.RJToggleButton();
            this.S122 = new CustomControls.RJControls.RJToggleButton();
            this.S121 = new CustomControls.RJControls.RJToggleButton();
            this.S120 = new CustomControls.RJControls.RJToggleButton();
            this.S119 = new CustomControls.RJControls.RJToggleButton();
            this.S110 = new CustomControls.RJControls.RJToggleButton();
            this.S118 = new CustomControls.RJControls.RJToggleButton();
            this.S117 = new CustomControls.RJControls.RJToggleButton();
            this.S80 = new CustomControls.RJControls.RJToggleButton();
            this.S116 = new CustomControls.RJControls.RJToggleButton();
            this.S115 = new CustomControls.RJControls.RJToggleButton();
            this.S109 = new CustomControls.RJControls.RJToggleButton();
            this.S114 = new CustomControls.RJControls.RJToggleButton();
            this.S113 = new CustomControls.RJControls.RJToggleButton();
            this.S108 = new CustomControls.RJControls.RJToggleButton();
            this.S107 = new CustomControls.RJControls.RJToggleButton();
            this.S95 = new CustomControls.RJControls.RJToggleButton();
            this.S106 = new CustomControls.RJControls.RJToggleButton();
            this.S105 = new CustomControls.RJControls.RJToggleButton();
            this.S104 = new CustomControls.RJControls.RJToggleButton();
            this.S103 = new CustomControls.RJControls.RJToggleButton();
            this.S94 = new CustomControls.RJControls.RJToggleButton();
            this.S102 = new CustomControls.RJControls.RJToggleButton();
            this.S101 = new CustomControls.RJControls.RJToggleButton();
            this.S64 = new CustomControls.RJControls.RJToggleButton();
            this.S100 = new CustomControls.RJControls.RJToggleButton();
            this.S99 = new CustomControls.RJControls.RJToggleButton();
            this.S93 = new CustomControls.RJControls.RJToggleButton();
            this.S98 = new CustomControls.RJControls.RJToggleButton();
            this.S97 = new CustomControls.RJControls.RJToggleButton();
            this.S92 = new CustomControls.RJControls.RJToggleButton();
            this.S91 = new CustomControls.RJControls.RJToggleButton();
            this.S79 = new CustomControls.RJControls.RJToggleButton();
            this.S90 = new CustomControls.RJControls.RJToggleButton();
            this.S89 = new CustomControls.RJControls.RJToggleButton();
            this.S88 = new CustomControls.RJControls.RJToggleButton();
            this.S87 = new CustomControls.RJControls.RJToggleButton();
            this.S78 = new CustomControls.RJControls.RJToggleButton();
            this.S86 = new CustomControls.RJControls.RJToggleButton();
            this.S85 = new CustomControls.RJControls.RJToggleButton();
            this.S48 = new CustomControls.RJControls.RJToggleButton();
            this.S84 = new CustomControls.RJControls.RJToggleButton();
            this.S83 = new CustomControls.RJControls.RJToggleButton();
            this.S77 = new CustomControls.RJControls.RJToggleButton();
            this.S82 = new CustomControls.RJControls.RJToggleButton();
            this.S81 = new CustomControls.RJControls.RJToggleButton();
            this.S76 = new CustomControls.RJControls.RJToggleButton();
            this.S75 = new CustomControls.RJControls.RJToggleButton();
            this.S63 = new CustomControls.RJControls.RJToggleButton();
            this.S74 = new CustomControls.RJControls.RJToggleButton();
            this.S73 = new CustomControls.RJControls.RJToggleButton();
            this.S72 = new CustomControls.RJControls.RJToggleButton();
            this.S71 = new CustomControls.RJControls.RJToggleButton();
            this.S62 = new CustomControls.RJControls.RJToggleButton();
            this.S70 = new CustomControls.RJControls.RJToggleButton();
            this.S69 = new CustomControls.RJControls.RJToggleButton();
            this.S32 = new CustomControls.RJControls.RJToggleButton();
            this.S68 = new CustomControls.RJControls.RJToggleButton();
            this.S67 = new CustomControls.RJControls.RJToggleButton();
            this.S61 = new CustomControls.RJControls.RJToggleButton();
            this.S66 = new CustomControls.RJControls.RJToggleButton();
            this.S65 = new CustomControls.RJControls.RJToggleButton();
            this.S60 = new CustomControls.RJControls.RJToggleButton();
            this.S59 = new CustomControls.RJControls.RJToggleButton();
            this.S47 = new CustomControls.RJControls.RJToggleButton();
            this.S58 = new CustomControls.RJControls.RJToggleButton();
            this.S57 = new CustomControls.RJControls.RJToggleButton();
            this.S16 = new CustomControls.RJControls.RJToggleButton();
            this.S56 = new CustomControls.RJControls.RJToggleButton();
            this.S55 = new CustomControls.RJControls.RJToggleButton();
            this.S46 = new CustomControls.RJControls.RJToggleButton();
            this.S54 = new CustomControls.RJControls.RJToggleButton();
            this.S53 = new CustomControls.RJControls.RJToggleButton();
            this.S31 = new CustomControls.RJControls.RJToggleButton();
            this.S52 = new CustomControls.RJControls.RJToggleButton();
            this.S51 = new CustomControls.RJControls.RJToggleButton();
            this.S45 = new CustomControls.RJControls.RJToggleButton();
            this.S50 = new CustomControls.RJControls.RJToggleButton();
            this.S49 = new CustomControls.RJControls.RJToggleButton();
            this.S44 = new CustomControls.RJControls.RJToggleButton();
            this.S30 = new CustomControls.RJControls.RJToggleButton();
            this.S43 = new CustomControls.RJControls.RJToggleButton();
            this.S0 = new CustomControls.RJControls.RJToggleButton();
            this.S42 = new CustomControls.RJControls.RJToggleButton();
            this.S29 = new CustomControls.RJControls.RJToggleButton();
            this.S41 = new CustomControls.RJControls.RJToggleButton();
            this.S40 = new CustomControls.RJControls.RJToggleButton();
            this.S28 = new CustomControls.RJControls.RJToggleButton();
            this.S39 = new CustomControls.RJControls.RJToggleButton();
            this.S38 = new CustomControls.RJControls.RJToggleButton();
            this.S27 = new CustomControls.RJControls.RJToggleButton();
            this.S37 = new CustomControls.RJControls.RJToggleButton();
            this.S36 = new CustomControls.RJControls.RJToggleButton();
            this.S26 = new CustomControls.RJControls.RJToggleButton();
            this.S35 = new CustomControls.RJControls.RJToggleButton();
            this.S34 = new CustomControls.RJControls.RJToggleButton();
            this.S25 = new CustomControls.RJControls.RJToggleButton();
            this.S33 = new CustomControls.RJControls.RJToggleButton();
            this.S24 = new CustomControls.RJControls.RJToggleButton();
            this.S23 = new CustomControls.RJControls.RJToggleButton();
            this.S22 = new CustomControls.RJControls.RJToggleButton();
            this.S21 = new CustomControls.RJControls.RJToggleButton();
            this.S20 = new CustomControls.RJControls.RJToggleButton();
            this.S19 = new CustomControls.RJControls.RJToggleButton();
            this.S18 = new CustomControls.RJControls.RJToggleButton();
            this.S17 = new CustomControls.RJControls.RJToggleButton();
            this.S15 = new CustomControls.RJControls.RJToggleButton();
            this.S14 = new CustomControls.RJControls.RJToggleButton();
            this.S8 = new CustomControls.RJControls.RJToggleButton();
            this.S13 = new CustomControls.RJControls.RJToggleButton();
            this.S12 = new CustomControls.RJControls.RJToggleButton();
            this.S1 = new CustomControls.RJControls.RJToggleButton();
            this.S11 = new CustomControls.RJControls.RJToggleButton();
            this.S10 = new CustomControls.RJControls.RJToggleButton();
            this.S9 = new CustomControls.RJControls.RJToggleButton();
            this.S2 = new CustomControls.RJControls.RJToggleButton();
            this.S3 = new CustomControls.RJControls.RJToggleButton();
            this.S4 = new CustomControls.RJControls.RJToggleButton();
            this.S5 = new CustomControls.RJControls.RJToggleButton();
            this.S6 = new CustomControls.RJControls.RJToggleButton();
            this.S7 = new CustomControls.RJControls.RJToggleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deviceStatusPictureBox);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 49);
            this.panel1.TabIndex = 0;
            // 
            // deviceStatusPictureBox
            // 
            this.deviceStatusPictureBox.Location = new System.Drawing.Point(3, 4);
            this.deviceStatusPictureBox.Name = "deviceStatusPictureBox";
            this.deviceStatusPictureBox.Size = new System.Drawing.Size(42, 42);
            this.deviceStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deviceStatusPictureBox.TabIndex = 4;
            this.deviceStatusPictureBox.TabStop = false;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(51, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(169, 39);
            this.connectButton.TabIndex = 3;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // voltageComboBox
            // 
            this.voltageComboBox.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageComboBox.FormattingEnabled = true;
            this.voltageComboBox.ItemHeight = 26;
            this.voltageComboBox.Location = new System.Drawing.Point(3, 9);
            this.voltageComboBox.Name = "voltageComboBox";
            this.voltageComboBox.Size = new System.Drawing.Size(101, 34);
            this.voltageComboBox.TabIndex = 0;
            this.voltageComboBox.SelectedIndexChanged += new System.EventHandler(this.voltageComboBox_SelectedIndexChanged);
            // 
            // setVoltageButton
            // 
            this.setVoltageButton.Location = new System.Drawing.Point(110, 5);
            this.setVoltageButton.Name = "setVoltageButton";
            this.setVoltageButton.Size = new System.Drawing.Size(106, 39);
            this.setVoltageButton.TabIndex = 2;
            this.setVoltageButton.Text = "Set";
            this.setVoltageButton.UseVisualStyleBackColor = true;
            this.setVoltageButton.Click += new System.EventHandler(this.setVoltageButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.setVoltageButton);
            this.panel2.Controls.Add(this.voltageComboBox);
            this.panel2.Location = new System.Drawing.Point(462, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 49);
            this.panel2.TabIndex = 1;
            // 
            // ModeRadioButton1
            // 
            this.ModeRadioButton1.AutoSize = true;
            this.ModeRadioButton1.Location = new System.Drawing.Point(24, 15);
            this.ModeRadioButton1.Name = "ModeRadioButton1";
            this.ModeRadioButton1.Size = new System.Drawing.Size(58, 17);
            this.ModeRadioButton1.TabIndex = 0;
            this.ModeRadioButton1.TabStop = true;
            this.ModeRadioButton1.Text = "Mode1";
            this.ModeRadioButton1.UseVisualStyleBackColor = true;
            this.ModeRadioButton1.CheckedChanged += new System.EventHandler(this.ModeRadioButton1_CheckedChanged);
            // 
            // ModeRadioButton2
            // 
            this.ModeRadioButton2.AutoSize = true;
            this.ModeRadioButton2.Location = new System.Drawing.Point(113, 15);
            this.ModeRadioButton2.Name = "ModeRadioButton2";
            this.ModeRadioButton2.Size = new System.Drawing.Size(61, 17);
            this.ModeRadioButton2.TabIndex = 1;
            this.ModeRadioButton2.TabStop = true;
            this.ModeRadioButton2.Text = "Mode 2";
            this.ModeRadioButton2.UseVisualStyleBackColor = true;
            this.ModeRadioButton2.CheckedChanged += new System.EventHandler(this.ModeRadioButton2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ModeRadioButton2);
            this.panel3.Controls.Add(this.ModeRadioButton1);
            this.panel3.Location = new System.Drawing.Point(235, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 49);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 16;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.Controls.Add(this.V0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.S144, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.S159, 15, 19);
            this.tableLayoutPanel1.Controls.Add(this.V159, 15, 18);
            this.tableLayoutPanel1.Controls.Add(this.S158, 14, 19);
            this.tableLayoutPanel1.Controls.Add(this.S128, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.S157, 13, 19);
            this.tableLayoutPanel1.Controls.Add(this.V144, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.S156, 12, 19);
            this.tableLayoutPanel1.Controls.Add(this.V158, 14, 18);
            this.tableLayoutPanel1.Controls.Add(this.S155, 11, 19);
            this.tableLayoutPanel1.Controls.Add(this.S143, 15, 17);
            this.tableLayoutPanel1.Controls.Add(this.S154, 10, 19);
            this.tableLayoutPanel1.Controls.Add(this.V157, 13, 18);
            this.tableLayoutPanel1.Controls.Add(this.S153, 9, 19);
            this.tableLayoutPanel1.Controls.Add(this.V143, 15, 16);
            this.tableLayoutPanel1.Controls.Add(this.S152, 8, 19);
            this.tableLayoutPanel1.Controls.Add(this.V156, 12, 18);
            this.tableLayoutPanel1.Controls.Add(this.S151, 7, 19);
            this.tableLayoutPanel1.Controls.Add(this.S142, 14, 17);
            this.tableLayoutPanel1.Controls.Add(this.S150, 6, 19);
            this.tableLayoutPanel1.Controls.Add(this.V155, 11, 18);
            this.tableLayoutPanel1.Controls.Add(this.S149, 5, 19);
            this.tableLayoutPanel1.Controls.Add(this.S112, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.S148, 4, 19);
            this.tableLayoutPanel1.Controls.Add(this.V154, 10, 18);
            this.tableLayoutPanel1.Controls.Add(this.S147, 3, 19);
            this.tableLayoutPanel1.Controls.Add(this.S141, 13, 17);
            this.tableLayoutPanel1.Controls.Add(this.S146, 2, 19);
            this.tableLayoutPanel1.Controls.Add(this.V153, 9, 18);
            this.tableLayoutPanel1.Controls.Add(this.S145, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.V128, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.V152, 8, 18);
            this.tableLayoutPanel1.Controls.Add(this.S140, 12, 17);
            this.tableLayoutPanel1.Controls.Add(this.V151, 7, 18);
            this.tableLayoutPanel1.Controls.Add(this.V142, 14, 16);
            this.tableLayoutPanel1.Controls.Add(this.V150, 6, 18);
            this.tableLayoutPanel1.Controls.Add(this.S139, 11, 17);
            this.tableLayoutPanel1.Controls.Add(this.V149, 5, 18);
            this.tableLayoutPanel1.Controls.Add(this.S127, 15, 15);
            this.tableLayoutPanel1.Controls.Add(this.V148, 4, 18);
            this.tableLayoutPanel1.Controls.Add(this.S138, 10, 17);
            this.tableLayoutPanel1.Controls.Add(this.V147, 3, 18);
            this.tableLayoutPanel1.Controls.Add(this.V141, 13, 16);
            this.tableLayoutPanel1.Controls.Add(this.V146, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.S137, 9, 17);
            this.tableLayoutPanel1.Controls.Add(this.V145, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.V127, 15, 14);
            this.tableLayoutPanel1.Controls.Add(this.S136, 8, 17);
            this.tableLayoutPanel1.Controls.Add(this.V140, 12, 16);
            this.tableLayoutPanel1.Controls.Add(this.S135, 7, 17);
            this.tableLayoutPanel1.Controls.Add(this.S126, 14, 15);
            this.tableLayoutPanel1.Controls.Add(this.S134, 6, 17);
            this.tableLayoutPanel1.Controls.Add(this.V139, 11, 16);
            this.tableLayoutPanel1.Controls.Add(this.S133, 5, 17);
            this.tableLayoutPanel1.Controls.Add(this.S96, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.S132, 4, 17);
            this.tableLayoutPanel1.Controls.Add(this.V138, 10, 16);
            this.tableLayoutPanel1.Controls.Add(this.S131, 3, 17);
            this.tableLayoutPanel1.Controls.Add(this.S125, 13, 15);
            this.tableLayoutPanel1.Controls.Add(this.S130, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.V137, 9, 16);
            this.tableLayoutPanel1.Controls.Add(this.S129, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.V112, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.V136, 8, 16);
            this.tableLayoutPanel1.Controls.Add(this.S124, 12, 15);
            this.tableLayoutPanel1.Controls.Add(this.V135, 7, 16);
            this.tableLayoutPanel1.Controls.Add(this.V126, 14, 14);
            this.tableLayoutPanel1.Controls.Add(this.V134, 6, 16);
            this.tableLayoutPanel1.Controls.Add(this.S123, 11, 15);
            this.tableLayoutPanel1.Controls.Add(this.V133, 5, 16);
            this.tableLayoutPanel1.Controls.Add(this.S111, 15, 13);
            this.tableLayoutPanel1.Controls.Add(this.V132, 4, 16);
            this.tableLayoutPanel1.Controls.Add(this.S122, 10, 15);
            this.tableLayoutPanel1.Controls.Add(this.V131, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.V125, 13, 14);
            this.tableLayoutPanel1.Controls.Add(this.V130, 2, 16);
            this.tableLayoutPanel1.Controls.Add(this.S121, 9, 15);
            this.tableLayoutPanel1.Controls.Add(this.V129, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.V111, 15, 12);
            this.tableLayoutPanel1.Controls.Add(this.S120, 8, 15);
            this.tableLayoutPanel1.Controls.Add(this.V124, 12, 14);
            this.tableLayoutPanel1.Controls.Add(this.S119, 7, 15);
            this.tableLayoutPanel1.Controls.Add(this.S110, 14, 13);
            this.tableLayoutPanel1.Controls.Add(this.S118, 6, 15);
            this.tableLayoutPanel1.Controls.Add(this.V123, 11, 14);
            this.tableLayoutPanel1.Controls.Add(this.S117, 5, 15);
            this.tableLayoutPanel1.Controls.Add(this.S80, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.S116, 4, 15);
            this.tableLayoutPanel1.Controls.Add(this.V122, 10, 14);
            this.tableLayoutPanel1.Controls.Add(this.S115, 3, 15);
            this.tableLayoutPanel1.Controls.Add(this.S109, 13, 13);
            this.tableLayoutPanel1.Controls.Add(this.S114, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.V121, 9, 14);
            this.tableLayoutPanel1.Controls.Add(this.S113, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.V96, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.V120, 8, 14);
            this.tableLayoutPanel1.Controls.Add(this.S108, 12, 13);
            this.tableLayoutPanel1.Controls.Add(this.V119, 7, 14);
            this.tableLayoutPanel1.Controls.Add(this.V110, 14, 12);
            this.tableLayoutPanel1.Controls.Add(this.V118, 6, 14);
            this.tableLayoutPanel1.Controls.Add(this.S107, 11, 13);
            this.tableLayoutPanel1.Controls.Add(this.V117, 5, 14);
            this.tableLayoutPanel1.Controls.Add(this.S95, 15, 11);
            this.tableLayoutPanel1.Controls.Add(this.V116, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.S106, 10, 13);
            this.tableLayoutPanel1.Controls.Add(this.V115, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.V109, 13, 12);
            this.tableLayoutPanel1.Controls.Add(this.V114, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.S105, 9, 13);
            this.tableLayoutPanel1.Controls.Add(this.V113, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.V95, 15, 10);
            this.tableLayoutPanel1.Controls.Add(this.S104, 8, 13);
            this.tableLayoutPanel1.Controls.Add(this.V108, 12, 12);
            this.tableLayoutPanel1.Controls.Add(this.S103, 7, 13);
            this.tableLayoutPanel1.Controls.Add(this.S94, 14, 11);
            this.tableLayoutPanel1.Controls.Add(this.S102, 6, 13);
            this.tableLayoutPanel1.Controls.Add(this.V107, 11, 12);
            this.tableLayoutPanel1.Controls.Add(this.S101, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.S64, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.S100, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.V106, 10, 12);
            this.tableLayoutPanel1.Controls.Add(this.S99, 3, 13);
            this.tableLayoutPanel1.Controls.Add(this.S93, 13, 11);
            this.tableLayoutPanel1.Controls.Add(this.S98, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.V105, 9, 12);
            this.tableLayoutPanel1.Controls.Add(this.S97, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.V80, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.V104, 8, 12);
            this.tableLayoutPanel1.Controls.Add(this.S92, 12, 11);
            this.tableLayoutPanel1.Controls.Add(this.V103, 7, 12);
            this.tableLayoutPanel1.Controls.Add(this.V94, 14, 10);
            this.tableLayoutPanel1.Controls.Add(this.V102, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.S91, 11, 11);
            this.tableLayoutPanel1.Controls.Add(this.V101, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.S79, 15, 9);
            this.tableLayoutPanel1.Controls.Add(this.V100, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.S90, 10, 11);
            this.tableLayoutPanel1.Controls.Add(this.V99, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.V93, 13, 10);
            this.tableLayoutPanel1.Controls.Add(this.V98, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.S89, 9, 11);
            this.tableLayoutPanel1.Controls.Add(this.V97, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.V79, 15, 8);
            this.tableLayoutPanel1.Controls.Add(this.S88, 8, 11);
            this.tableLayoutPanel1.Controls.Add(this.V92, 12, 10);
            this.tableLayoutPanel1.Controls.Add(this.S87, 7, 11);
            this.tableLayoutPanel1.Controls.Add(this.S78, 14, 9);
            this.tableLayoutPanel1.Controls.Add(this.S86, 6, 11);
            this.tableLayoutPanel1.Controls.Add(this.V91, 11, 10);
            this.tableLayoutPanel1.Controls.Add(this.S85, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.S48, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.S84, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.V90, 10, 10);
            this.tableLayoutPanel1.Controls.Add(this.S83, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.S77, 13, 9);
            this.tableLayoutPanel1.Controls.Add(this.S82, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.V89, 9, 10);
            this.tableLayoutPanel1.Controls.Add(this.S81, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.V64, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.V88, 8, 10);
            this.tableLayoutPanel1.Controls.Add(this.S76, 12, 9);
            this.tableLayoutPanel1.Controls.Add(this.V87, 7, 10);
            this.tableLayoutPanel1.Controls.Add(this.V78, 14, 8);
            this.tableLayoutPanel1.Controls.Add(this.V86, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.S75, 11, 9);
            this.tableLayoutPanel1.Controls.Add(this.V85, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.S63, 15, 7);
            this.tableLayoutPanel1.Controls.Add(this.V84, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.S74, 10, 9);
            this.tableLayoutPanel1.Controls.Add(this.V83, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.V77, 13, 8);
            this.tableLayoutPanel1.Controls.Add(this.V82, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.S73, 9, 9);
            this.tableLayoutPanel1.Controls.Add(this.V81, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.V63, 15, 6);
            this.tableLayoutPanel1.Controls.Add(this.S72, 8, 9);
            this.tableLayoutPanel1.Controls.Add(this.V76, 12, 8);
            this.tableLayoutPanel1.Controls.Add(this.S71, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.S62, 14, 7);
            this.tableLayoutPanel1.Controls.Add(this.S70, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.V75, 11, 8);
            this.tableLayoutPanel1.Controls.Add(this.S69, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.S32, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.S68, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.V74, 10, 8);
            this.tableLayoutPanel1.Controls.Add(this.S67, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.S61, 13, 7);
            this.tableLayoutPanel1.Controls.Add(this.S66, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.V73, 9, 8);
            this.tableLayoutPanel1.Controls.Add(this.S65, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.V48, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.V72, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.S60, 12, 7);
            this.tableLayoutPanel1.Controls.Add(this.V71, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.V62, 14, 6);
            this.tableLayoutPanel1.Controls.Add(this.V70, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.S59, 11, 7);
            this.tableLayoutPanel1.Controls.Add(this.V69, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.S47, 15, 5);
            this.tableLayoutPanel1.Controls.Add(this.V68, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.S58, 10, 7);
            this.tableLayoutPanel1.Controls.Add(this.V67, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.V61, 13, 6);
            this.tableLayoutPanel1.Controls.Add(this.V66, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.S57, 9, 7);
            this.tableLayoutPanel1.Controls.Add(this.V65, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.S16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.S56, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.V60, 12, 6);
            this.tableLayoutPanel1.Controls.Add(this.S55, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.S46, 14, 5);
            this.tableLayoutPanel1.Controls.Add(this.S54, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.V59, 11, 6);
            this.tableLayoutPanel1.Controls.Add(this.S53, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.S31, 15, 3);
            this.tableLayoutPanel1.Controls.Add(this.S52, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.V58, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.S51, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.S45, 13, 5);
            this.tableLayoutPanel1.Controls.Add(this.S50, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.V57, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.S49, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.V33, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.V56, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.S44, 12, 5);
            this.tableLayoutPanel1.Controls.Add(this.V55, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.S30, 14, 3);
            this.tableLayoutPanel1.Controls.Add(this.V54, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.S43, 11, 5);
            this.tableLayoutPanel1.Controls.Add(this.V53, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.S0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.V52, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.S42, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.V51, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.S29, 13, 3);
            this.tableLayoutPanel1.Controls.Add(this.V50, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.S41, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.V49, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.V31, 15, 2);
            this.tableLayoutPanel1.Controls.Add(this.S40, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.S28, 12, 3);
            this.tableLayoutPanel1.Controls.Add(this.S39, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.V30, 14, 2);
            this.tableLayoutPanel1.Controls.Add(this.S38, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.S27, 11, 3);
            this.tableLayoutPanel1.Controls.Add(this.S37, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.V29, 13, 2);
            this.tableLayoutPanel1.Controls.Add(this.S36, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.S26, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.S35, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.S34, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.S25, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.S33, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.V28, 12, 2);
            this.tableLayoutPanel1.Controls.Add(this.S24, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.V27, 11, 2);
            this.tableLayoutPanel1.Controls.Add(this.S23, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.V25, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.S22, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.V26, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.S21, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.V24, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.S20, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.V23, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.S19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.V22, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.S18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.V21, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.S17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.V20, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.V18, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.V16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.S15, 15, 1);
            this.tableLayoutPanel1.Controls.Add(this.S14, 14, 1);
            this.tableLayoutPanel1.Controls.Add(this.S8, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.S13, 13, 1);
            this.tableLayoutPanel1.Controls.Add(this.S12, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.S1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.S11, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.V1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.S10, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.V2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.S9, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.V3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.S2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.S3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.V4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.V5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.V6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.V7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.S4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.S5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.S6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.S7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.V8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.V9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.V10, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.V11, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.V12, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.V13, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.V14, 14, 0);
            this.tableLayoutPanel1.Controls.Add(this.V15, 15, 0);
            this.tableLayoutPanel1.Controls.Add(this.V17, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.V19, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.V32, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.V34, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.V35, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.V36, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.V37, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.V38, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.V39, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.V40, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.V41, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.V42, 10, 4);
            this.tableLayoutPanel1.Controls.Add(this.V43, 11, 4);
            this.tableLayoutPanel1.Controls.Add(this.V44, 12, 4);
            this.tableLayoutPanel1.Controls.Add(this.V45, 13, 4);
            this.tableLayoutPanel1.Controls.Add(this.V46, 14, 4);
            this.tableLayoutPanel1.Controls.Add(this.V47, 15, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1472, 750);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // V0
            // 
            this.V0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V0.FormattingEnabled = true;
            this.V0.Location = new System.Drawing.Point(3, 3);
            this.V0.Name = "V0";
            this.V0.Size = new System.Drawing.Size(85, 28);
            this.V0.TabIndex = 5;
            // 
            // V159
            // 
            this.V159.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V159.FormattingEnabled = true;
            this.V159.Location = new System.Drawing.Point(1383, 678);
            this.V159.Name = "V159";
            this.V159.Size = new System.Drawing.Size(85, 28);
            this.V159.TabIndex = 138;
            // 
            // V144
            // 
            this.V144.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V144.FormattingEnabled = true;
            this.V144.Location = new System.Drawing.Point(3, 678);
            this.V144.Name = "V144";
            this.V144.Size = new System.Drawing.Size(85, 28);
            this.V144.TabIndex = 139;
            // 
            // V158
            // 
            this.V158.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V158.FormattingEnabled = true;
            this.V158.Location = new System.Drawing.Point(1291, 678);
            this.V158.Name = "V158";
            this.V158.Size = new System.Drawing.Size(85, 28);
            this.V158.TabIndex = 140;
            // 
            // V157
            // 
            this.V157.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V157.FormattingEnabled = true;
            this.V157.Location = new System.Drawing.Point(1199, 678);
            this.V157.Name = "V157";
            this.V157.Size = new System.Drawing.Size(85, 28);
            this.V157.TabIndex = 141;
            // 
            // V143
            // 
            this.V143.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V143.FormattingEnabled = true;
            this.V143.Location = new System.Drawing.Point(1383, 603);
            this.V143.Name = "V143";
            this.V143.Size = new System.Drawing.Size(85, 28);
            this.V143.TabIndex = 122;
            // 
            // V156
            // 
            this.V156.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V156.FormattingEnabled = true;
            this.V156.Location = new System.Drawing.Point(1107, 678);
            this.V156.Name = "V156";
            this.V156.Size = new System.Drawing.Size(85, 28);
            this.V156.TabIndex = 142;
            // 
            // V155
            // 
            this.V155.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V155.FormattingEnabled = true;
            this.V155.Location = new System.Drawing.Point(1015, 678);
            this.V155.Name = "V155";
            this.V155.Size = new System.Drawing.Size(85, 28);
            this.V155.TabIndex = 143;
            // 
            // V154
            // 
            this.V154.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V154.FormattingEnabled = true;
            this.V154.Location = new System.Drawing.Point(923, 678);
            this.V154.Name = "V154";
            this.V154.Size = new System.Drawing.Size(85, 28);
            this.V154.TabIndex = 144;
            // 
            // V153
            // 
            this.V153.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V153.FormattingEnabled = true;
            this.V153.Location = new System.Drawing.Point(831, 678);
            this.V153.Name = "V153";
            this.V153.Size = new System.Drawing.Size(85, 28);
            this.V153.TabIndex = 145;
            // 
            // V128
            // 
            this.V128.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V128.FormattingEnabled = true;
            this.V128.Location = new System.Drawing.Point(3, 603);
            this.V128.Name = "V128";
            this.V128.Size = new System.Drawing.Size(85, 28);
            this.V128.TabIndex = 123;
            // 
            // V152
            // 
            this.V152.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V152.FormattingEnabled = true;
            this.V152.Location = new System.Drawing.Point(739, 678);
            this.V152.Name = "V152";
            this.V152.Size = new System.Drawing.Size(85, 28);
            this.V152.TabIndex = 146;
            // 
            // V151
            // 
            this.V151.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V151.FormattingEnabled = true;
            this.V151.Location = new System.Drawing.Point(647, 678);
            this.V151.Name = "V151";
            this.V151.Size = new System.Drawing.Size(85, 28);
            this.V151.TabIndex = 147;
            // 
            // V142
            // 
            this.V142.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V142.FormattingEnabled = true;
            this.V142.Location = new System.Drawing.Point(1291, 603);
            this.V142.Name = "V142";
            this.V142.Size = new System.Drawing.Size(85, 28);
            this.V142.TabIndex = 124;
            // 
            // V150
            // 
            this.V150.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V150.FormattingEnabled = true;
            this.V150.Location = new System.Drawing.Point(555, 678);
            this.V150.Name = "V150";
            this.V150.Size = new System.Drawing.Size(85, 28);
            this.V150.TabIndex = 148;
            // 
            // V149
            // 
            this.V149.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V149.FormattingEnabled = true;
            this.V149.Location = new System.Drawing.Point(463, 678);
            this.V149.Name = "V149";
            this.V149.Size = new System.Drawing.Size(85, 28);
            this.V149.TabIndex = 149;
            // 
            // V148
            // 
            this.V148.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V148.FormattingEnabled = true;
            this.V148.Location = new System.Drawing.Point(371, 678);
            this.V148.Name = "V148";
            this.V148.Size = new System.Drawing.Size(85, 28);
            this.V148.TabIndex = 150;
            // 
            // V147
            // 
            this.V147.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V147.FormattingEnabled = true;
            this.V147.Location = new System.Drawing.Point(279, 678);
            this.V147.Name = "V147";
            this.V147.Size = new System.Drawing.Size(85, 28);
            this.V147.TabIndex = 151;
            // 
            // V141
            // 
            this.V141.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V141.FormattingEnabled = true;
            this.V141.Location = new System.Drawing.Point(1199, 603);
            this.V141.Name = "V141";
            this.V141.Size = new System.Drawing.Size(85, 28);
            this.V141.TabIndex = 125;
            // 
            // V146
            // 
            this.V146.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V146.FormattingEnabled = true;
            this.V146.Location = new System.Drawing.Point(187, 678);
            this.V146.Name = "V146";
            this.V146.Size = new System.Drawing.Size(85, 28);
            this.V146.TabIndex = 152;
            // 
            // V145
            // 
            this.V145.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V145.FormattingEnabled = true;
            this.V145.Location = new System.Drawing.Point(95, 678);
            this.V145.Name = "V145";
            this.V145.Size = new System.Drawing.Size(85, 28);
            this.V145.TabIndex = 153;
            // 
            // V127
            // 
            this.V127.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V127.FormattingEnabled = true;
            this.V127.Location = new System.Drawing.Point(1383, 528);
            this.V127.Name = "V127";
            this.V127.Size = new System.Drawing.Size(85, 28);
            this.V127.TabIndex = 106;
            // 
            // V140
            // 
            this.V140.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V140.FormattingEnabled = true;
            this.V140.Location = new System.Drawing.Point(1107, 603);
            this.V140.Name = "V140";
            this.V140.Size = new System.Drawing.Size(85, 28);
            this.V140.TabIndex = 126;
            // 
            // V139
            // 
            this.V139.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V139.FormattingEnabled = true;
            this.V139.Location = new System.Drawing.Point(1015, 603);
            this.V139.Name = "V139";
            this.V139.Size = new System.Drawing.Size(85, 28);
            this.V139.TabIndex = 127;
            // 
            // V138
            // 
            this.V138.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V138.FormattingEnabled = true;
            this.V138.Location = new System.Drawing.Point(923, 603);
            this.V138.Name = "V138";
            this.V138.Size = new System.Drawing.Size(85, 28);
            this.V138.TabIndex = 128;
            // 
            // V137
            // 
            this.V137.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V137.FormattingEnabled = true;
            this.V137.Location = new System.Drawing.Point(831, 603);
            this.V137.Name = "V137";
            this.V137.Size = new System.Drawing.Size(85, 28);
            this.V137.TabIndex = 129;
            // 
            // V112
            // 
            this.V112.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V112.FormattingEnabled = true;
            this.V112.Location = new System.Drawing.Point(3, 528);
            this.V112.Name = "V112";
            this.V112.Size = new System.Drawing.Size(85, 28);
            this.V112.TabIndex = 107;
            // 
            // V136
            // 
            this.V136.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V136.FormattingEnabled = true;
            this.V136.Location = new System.Drawing.Point(739, 603);
            this.V136.Name = "V136";
            this.V136.Size = new System.Drawing.Size(85, 28);
            this.V136.TabIndex = 130;
            // 
            // V135
            // 
            this.V135.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V135.FormattingEnabled = true;
            this.V135.Location = new System.Drawing.Point(647, 603);
            this.V135.Name = "V135";
            this.V135.Size = new System.Drawing.Size(85, 28);
            this.V135.TabIndex = 131;
            // 
            // V126
            // 
            this.V126.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V126.FormattingEnabled = true;
            this.V126.Location = new System.Drawing.Point(1291, 528);
            this.V126.Name = "V126";
            this.V126.Size = new System.Drawing.Size(85, 28);
            this.V126.TabIndex = 108;
            // 
            // V134
            // 
            this.V134.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V134.FormattingEnabled = true;
            this.V134.Location = new System.Drawing.Point(555, 603);
            this.V134.Name = "V134";
            this.V134.Size = new System.Drawing.Size(85, 28);
            this.V134.TabIndex = 132;
            // 
            // V133
            // 
            this.V133.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V133.FormattingEnabled = true;
            this.V133.Location = new System.Drawing.Point(463, 603);
            this.V133.Name = "V133";
            this.V133.Size = new System.Drawing.Size(85, 28);
            this.V133.TabIndex = 133;
            // 
            // V132
            // 
            this.V132.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V132.FormattingEnabled = true;
            this.V132.Location = new System.Drawing.Point(371, 603);
            this.V132.Name = "V132";
            this.V132.Size = new System.Drawing.Size(85, 28);
            this.V132.TabIndex = 134;
            // 
            // V131
            // 
            this.V131.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V131.FormattingEnabled = true;
            this.V131.Location = new System.Drawing.Point(279, 603);
            this.V131.Name = "V131";
            this.V131.Size = new System.Drawing.Size(85, 28);
            this.V131.TabIndex = 135;
            // 
            // V125
            // 
            this.V125.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V125.FormattingEnabled = true;
            this.V125.Location = new System.Drawing.Point(1199, 528);
            this.V125.Name = "V125";
            this.V125.Size = new System.Drawing.Size(85, 28);
            this.V125.TabIndex = 109;
            // 
            // V130
            // 
            this.V130.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V130.FormattingEnabled = true;
            this.V130.Location = new System.Drawing.Point(187, 603);
            this.V130.Name = "V130";
            this.V130.Size = new System.Drawing.Size(85, 28);
            this.V130.TabIndex = 136;
            // 
            // V129
            // 
            this.V129.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V129.FormattingEnabled = true;
            this.V129.Location = new System.Drawing.Point(95, 603);
            this.V129.Name = "V129";
            this.V129.Size = new System.Drawing.Size(85, 28);
            this.V129.TabIndex = 137;
            // 
            // V111
            // 
            this.V111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V111.FormattingEnabled = true;
            this.V111.Location = new System.Drawing.Point(1383, 453);
            this.V111.Name = "V111";
            this.V111.Size = new System.Drawing.Size(85, 28);
            this.V111.TabIndex = 90;
            // 
            // V124
            // 
            this.V124.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V124.FormattingEnabled = true;
            this.V124.Location = new System.Drawing.Point(1107, 528);
            this.V124.Name = "V124";
            this.V124.Size = new System.Drawing.Size(85, 28);
            this.V124.TabIndex = 110;
            // 
            // V123
            // 
            this.V123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V123.FormattingEnabled = true;
            this.V123.Location = new System.Drawing.Point(1015, 528);
            this.V123.Name = "V123";
            this.V123.Size = new System.Drawing.Size(85, 28);
            this.V123.TabIndex = 111;
            // 
            // V122
            // 
            this.V122.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V122.FormattingEnabled = true;
            this.V122.Location = new System.Drawing.Point(923, 528);
            this.V122.Name = "V122";
            this.V122.Size = new System.Drawing.Size(85, 28);
            this.V122.TabIndex = 112;
            // 
            // V121
            // 
            this.V121.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V121.FormattingEnabled = true;
            this.V121.Location = new System.Drawing.Point(831, 528);
            this.V121.Name = "V121";
            this.V121.Size = new System.Drawing.Size(85, 28);
            this.V121.TabIndex = 113;
            // 
            // V96
            // 
            this.V96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V96.FormattingEnabled = true;
            this.V96.Location = new System.Drawing.Point(3, 453);
            this.V96.Name = "V96";
            this.V96.Size = new System.Drawing.Size(85, 28);
            this.V96.TabIndex = 91;
            // 
            // V120
            // 
            this.V120.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V120.FormattingEnabled = true;
            this.V120.Location = new System.Drawing.Point(739, 528);
            this.V120.Name = "V120";
            this.V120.Size = new System.Drawing.Size(85, 28);
            this.V120.TabIndex = 114;
            // 
            // V119
            // 
            this.V119.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V119.FormattingEnabled = true;
            this.V119.Location = new System.Drawing.Point(647, 528);
            this.V119.Name = "V119";
            this.V119.Size = new System.Drawing.Size(85, 28);
            this.V119.TabIndex = 115;
            // 
            // V110
            // 
            this.V110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V110.FormattingEnabled = true;
            this.V110.Location = new System.Drawing.Point(1291, 453);
            this.V110.Name = "V110";
            this.V110.Size = new System.Drawing.Size(85, 28);
            this.V110.TabIndex = 92;
            // 
            // V118
            // 
            this.V118.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V118.FormattingEnabled = true;
            this.V118.Location = new System.Drawing.Point(555, 528);
            this.V118.Name = "V118";
            this.V118.Size = new System.Drawing.Size(85, 28);
            this.V118.TabIndex = 116;
            // 
            // V117
            // 
            this.V117.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V117.FormattingEnabled = true;
            this.V117.Location = new System.Drawing.Point(463, 528);
            this.V117.Name = "V117";
            this.V117.Size = new System.Drawing.Size(85, 28);
            this.V117.TabIndex = 117;
            // 
            // V116
            // 
            this.V116.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V116.FormattingEnabled = true;
            this.V116.Location = new System.Drawing.Point(371, 528);
            this.V116.Name = "V116";
            this.V116.Size = new System.Drawing.Size(85, 28);
            this.V116.TabIndex = 118;
            // 
            // V115
            // 
            this.V115.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V115.FormattingEnabled = true;
            this.V115.Location = new System.Drawing.Point(279, 528);
            this.V115.Name = "V115";
            this.V115.Size = new System.Drawing.Size(85, 28);
            this.V115.TabIndex = 119;
            // 
            // V109
            // 
            this.V109.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V109.FormattingEnabled = true;
            this.V109.Location = new System.Drawing.Point(1199, 453);
            this.V109.Name = "V109";
            this.V109.Size = new System.Drawing.Size(85, 28);
            this.V109.TabIndex = 93;
            // 
            // V114
            // 
            this.V114.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V114.FormattingEnabled = true;
            this.V114.Location = new System.Drawing.Point(187, 528);
            this.V114.Name = "V114";
            this.V114.Size = new System.Drawing.Size(85, 28);
            this.V114.TabIndex = 120;
            // 
            // V113
            // 
            this.V113.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V113.FormattingEnabled = true;
            this.V113.Location = new System.Drawing.Point(95, 528);
            this.V113.Name = "V113";
            this.V113.Size = new System.Drawing.Size(85, 28);
            this.V113.TabIndex = 121;
            // 
            // V95
            // 
            this.V95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V95.FormattingEnabled = true;
            this.V95.Location = new System.Drawing.Point(1383, 378);
            this.V95.Name = "V95";
            this.V95.Size = new System.Drawing.Size(85, 28);
            this.V95.TabIndex = 74;
            // 
            // V108
            // 
            this.V108.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V108.FormattingEnabled = true;
            this.V108.Location = new System.Drawing.Point(1107, 453);
            this.V108.Name = "V108";
            this.V108.Size = new System.Drawing.Size(85, 28);
            this.V108.TabIndex = 94;
            // 
            // V107
            // 
            this.V107.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V107.FormattingEnabled = true;
            this.V107.Location = new System.Drawing.Point(1015, 453);
            this.V107.Name = "V107";
            this.V107.Size = new System.Drawing.Size(85, 28);
            this.V107.TabIndex = 95;
            // 
            // V106
            // 
            this.V106.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V106.FormattingEnabled = true;
            this.V106.Location = new System.Drawing.Point(923, 453);
            this.V106.Name = "V106";
            this.V106.Size = new System.Drawing.Size(85, 28);
            this.V106.TabIndex = 96;
            // 
            // V105
            // 
            this.V105.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V105.FormattingEnabled = true;
            this.V105.Location = new System.Drawing.Point(831, 453);
            this.V105.Name = "V105";
            this.V105.Size = new System.Drawing.Size(85, 28);
            this.V105.TabIndex = 97;
            // 
            // V80
            // 
            this.V80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V80.FormattingEnabled = true;
            this.V80.Location = new System.Drawing.Point(3, 378);
            this.V80.Name = "V80";
            this.V80.Size = new System.Drawing.Size(85, 28);
            this.V80.TabIndex = 75;
            // 
            // V104
            // 
            this.V104.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V104.FormattingEnabled = true;
            this.V104.Location = new System.Drawing.Point(739, 453);
            this.V104.Name = "V104";
            this.V104.Size = new System.Drawing.Size(85, 28);
            this.V104.TabIndex = 98;
            // 
            // V103
            // 
            this.V103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V103.FormattingEnabled = true;
            this.V103.Location = new System.Drawing.Point(647, 453);
            this.V103.Name = "V103";
            this.V103.Size = new System.Drawing.Size(85, 28);
            this.V103.TabIndex = 99;
            // 
            // V94
            // 
            this.V94.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V94.FormattingEnabled = true;
            this.V94.Location = new System.Drawing.Point(1291, 378);
            this.V94.Name = "V94";
            this.V94.Size = new System.Drawing.Size(85, 28);
            this.V94.TabIndex = 76;
            // 
            // V102
            // 
            this.V102.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V102.FormattingEnabled = true;
            this.V102.Location = new System.Drawing.Point(555, 453);
            this.V102.Name = "V102";
            this.V102.Size = new System.Drawing.Size(85, 28);
            this.V102.TabIndex = 100;
            // 
            // V101
            // 
            this.V101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V101.FormattingEnabled = true;
            this.V101.Location = new System.Drawing.Point(463, 453);
            this.V101.Name = "V101";
            this.V101.Size = new System.Drawing.Size(85, 28);
            this.V101.TabIndex = 101;
            // 
            // V100
            // 
            this.V100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V100.FormattingEnabled = true;
            this.V100.Location = new System.Drawing.Point(371, 453);
            this.V100.Name = "V100";
            this.V100.Size = new System.Drawing.Size(85, 28);
            this.V100.TabIndex = 102;
            // 
            // V99
            // 
            this.V99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V99.FormattingEnabled = true;
            this.V99.Location = new System.Drawing.Point(279, 453);
            this.V99.Name = "V99";
            this.V99.Size = new System.Drawing.Size(85, 28);
            this.V99.TabIndex = 103;
            // 
            // V93
            // 
            this.V93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V93.FormattingEnabled = true;
            this.V93.Location = new System.Drawing.Point(1199, 378);
            this.V93.Name = "V93";
            this.V93.Size = new System.Drawing.Size(85, 28);
            this.V93.TabIndex = 77;
            // 
            // V98
            // 
            this.V98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V98.FormattingEnabled = true;
            this.V98.Location = new System.Drawing.Point(187, 453);
            this.V98.Name = "V98";
            this.V98.Size = new System.Drawing.Size(85, 28);
            this.V98.TabIndex = 104;
            // 
            // V97
            // 
            this.V97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V97.FormattingEnabled = true;
            this.V97.Location = new System.Drawing.Point(95, 453);
            this.V97.Name = "V97";
            this.V97.Size = new System.Drawing.Size(85, 28);
            this.V97.TabIndex = 105;
            // 
            // V79
            // 
            this.V79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V79.FormattingEnabled = true;
            this.V79.Location = new System.Drawing.Point(1383, 303);
            this.V79.Name = "V79";
            this.V79.Size = new System.Drawing.Size(85, 28);
            this.V79.TabIndex = 58;
            // 
            // V92
            // 
            this.V92.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V92.FormattingEnabled = true;
            this.V92.Location = new System.Drawing.Point(1107, 378);
            this.V92.Name = "V92";
            this.V92.Size = new System.Drawing.Size(85, 28);
            this.V92.TabIndex = 78;
            // 
            // V91
            // 
            this.V91.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V91.FormattingEnabled = true;
            this.V91.Location = new System.Drawing.Point(1015, 378);
            this.V91.Name = "V91";
            this.V91.Size = new System.Drawing.Size(85, 28);
            this.V91.TabIndex = 79;
            // 
            // V90
            // 
            this.V90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V90.FormattingEnabled = true;
            this.V90.Location = new System.Drawing.Point(923, 378);
            this.V90.Name = "V90";
            this.V90.Size = new System.Drawing.Size(85, 28);
            this.V90.TabIndex = 80;
            // 
            // V89
            // 
            this.V89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V89.FormattingEnabled = true;
            this.V89.Location = new System.Drawing.Point(831, 378);
            this.V89.Name = "V89";
            this.V89.Size = new System.Drawing.Size(85, 28);
            this.V89.TabIndex = 81;
            // 
            // V64
            // 
            this.V64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V64.FormattingEnabled = true;
            this.V64.Location = new System.Drawing.Point(3, 303);
            this.V64.Name = "V64";
            this.V64.Size = new System.Drawing.Size(85, 28);
            this.V64.TabIndex = 59;
            // 
            // V88
            // 
            this.V88.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V88.FormattingEnabled = true;
            this.V88.Location = new System.Drawing.Point(739, 378);
            this.V88.Name = "V88";
            this.V88.Size = new System.Drawing.Size(85, 28);
            this.V88.TabIndex = 82;
            // 
            // V87
            // 
            this.V87.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V87.FormattingEnabled = true;
            this.V87.Location = new System.Drawing.Point(647, 378);
            this.V87.Name = "V87";
            this.V87.Size = new System.Drawing.Size(85, 28);
            this.V87.TabIndex = 83;
            // 
            // V78
            // 
            this.V78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V78.FormattingEnabled = true;
            this.V78.Location = new System.Drawing.Point(1291, 303);
            this.V78.Name = "V78";
            this.V78.Size = new System.Drawing.Size(85, 28);
            this.V78.TabIndex = 60;
            // 
            // V86
            // 
            this.V86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V86.FormattingEnabled = true;
            this.V86.Location = new System.Drawing.Point(555, 378);
            this.V86.Name = "V86";
            this.V86.Size = new System.Drawing.Size(85, 28);
            this.V86.TabIndex = 84;
            // 
            // V85
            // 
            this.V85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V85.FormattingEnabled = true;
            this.V85.Location = new System.Drawing.Point(463, 378);
            this.V85.Name = "V85";
            this.V85.Size = new System.Drawing.Size(85, 28);
            this.V85.TabIndex = 85;
            // 
            // V84
            // 
            this.V84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V84.FormattingEnabled = true;
            this.V84.Location = new System.Drawing.Point(371, 378);
            this.V84.Name = "V84";
            this.V84.Size = new System.Drawing.Size(85, 28);
            this.V84.TabIndex = 86;
            // 
            // V83
            // 
            this.V83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V83.FormattingEnabled = true;
            this.V83.Location = new System.Drawing.Point(279, 378);
            this.V83.Name = "V83";
            this.V83.Size = new System.Drawing.Size(85, 28);
            this.V83.TabIndex = 87;
            // 
            // V77
            // 
            this.V77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V77.FormattingEnabled = true;
            this.V77.Location = new System.Drawing.Point(1199, 303);
            this.V77.Name = "V77";
            this.V77.Size = new System.Drawing.Size(85, 28);
            this.V77.TabIndex = 61;
            // 
            // V82
            // 
            this.V82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V82.FormattingEnabled = true;
            this.V82.Location = new System.Drawing.Point(187, 378);
            this.V82.Name = "V82";
            this.V82.Size = new System.Drawing.Size(85, 28);
            this.V82.TabIndex = 88;
            // 
            // V81
            // 
            this.V81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V81.FormattingEnabled = true;
            this.V81.Location = new System.Drawing.Point(95, 378);
            this.V81.Name = "V81";
            this.V81.Size = new System.Drawing.Size(85, 28);
            this.V81.TabIndex = 89;
            // 
            // V63
            // 
            this.V63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V63.FormattingEnabled = true;
            this.V63.Location = new System.Drawing.Point(1383, 228);
            this.V63.Name = "V63";
            this.V63.Size = new System.Drawing.Size(85, 28);
            this.V63.TabIndex = 42;
            // 
            // V76
            // 
            this.V76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V76.FormattingEnabled = true;
            this.V76.Location = new System.Drawing.Point(1107, 303);
            this.V76.Name = "V76";
            this.V76.Size = new System.Drawing.Size(85, 28);
            this.V76.TabIndex = 62;
            // 
            // V75
            // 
            this.V75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V75.FormattingEnabled = true;
            this.V75.Location = new System.Drawing.Point(1015, 303);
            this.V75.Name = "V75";
            this.V75.Size = new System.Drawing.Size(85, 28);
            this.V75.TabIndex = 63;
            // 
            // V74
            // 
            this.V74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V74.FormattingEnabled = true;
            this.V74.Location = new System.Drawing.Point(923, 303);
            this.V74.Name = "V74";
            this.V74.Size = new System.Drawing.Size(85, 28);
            this.V74.TabIndex = 64;
            // 
            // V73
            // 
            this.V73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V73.FormattingEnabled = true;
            this.V73.Location = new System.Drawing.Point(831, 303);
            this.V73.Name = "V73";
            this.V73.Size = new System.Drawing.Size(85, 28);
            this.V73.TabIndex = 65;
            // 
            // V48
            // 
            this.V48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V48.FormattingEnabled = true;
            this.V48.Location = new System.Drawing.Point(3, 228);
            this.V48.Name = "V48";
            this.V48.Size = new System.Drawing.Size(85, 28);
            this.V48.TabIndex = 43;
            // 
            // V72
            // 
            this.V72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V72.FormattingEnabled = true;
            this.V72.Location = new System.Drawing.Point(739, 303);
            this.V72.Name = "V72";
            this.V72.Size = new System.Drawing.Size(85, 28);
            this.V72.TabIndex = 66;
            // 
            // V71
            // 
            this.V71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V71.FormattingEnabled = true;
            this.V71.Location = new System.Drawing.Point(647, 303);
            this.V71.Name = "V71";
            this.V71.Size = new System.Drawing.Size(85, 28);
            this.V71.TabIndex = 67;
            // 
            // V62
            // 
            this.V62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V62.FormattingEnabled = true;
            this.V62.Location = new System.Drawing.Point(1291, 228);
            this.V62.Name = "V62";
            this.V62.Size = new System.Drawing.Size(85, 28);
            this.V62.TabIndex = 44;
            // 
            // V70
            // 
            this.V70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V70.FormattingEnabled = true;
            this.V70.Location = new System.Drawing.Point(555, 303);
            this.V70.Name = "V70";
            this.V70.Size = new System.Drawing.Size(85, 28);
            this.V70.TabIndex = 68;
            // 
            // V69
            // 
            this.V69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V69.FormattingEnabled = true;
            this.V69.Location = new System.Drawing.Point(463, 303);
            this.V69.Name = "V69";
            this.V69.Size = new System.Drawing.Size(85, 28);
            this.V69.TabIndex = 69;
            // 
            // V68
            // 
            this.V68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V68.FormattingEnabled = true;
            this.V68.Location = new System.Drawing.Point(371, 303);
            this.V68.Name = "V68";
            this.V68.Size = new System.Drawing.Size(85, 28);
            this.V68.TabIndex = 70;
            // 
            // V67
            // 
            this.V67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V67.FormattingEnabled = true;
            this.V67.Location = new System.Drawing.Point(279, 303);
            this.V67.Name = "V67";
            this.V67.Size = new System.Drawing.Size(85, 28);
            this.V67.TabIndex = 71;
            // 
            // V61
            // 
            this.V61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V61.FormattingEnabled = true;
            this.V61.Location = new System.Drawing.Point(1199, 228);
            this.V61.Name = "V61";
            this.V61.Size = new System.Drawing.Size(85, 28);
            this.V61.TabIndex = 45;
            // 
            // V66
            // 
            this.V66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V66.FormattingEnabled = true;
            this.V66.Location = new System.Drawing.Point(187, 303);
            this.V66.Name = "V66";
            this.V66.Size = new System.Drawing.Size(85, 28);
            this.V66.TabIndex = 72;
            // 
            // V65
            // 
            this.V65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V65.FormattingEnabled = true;
            this.V65.Location = new System.Drawing.Point(95, 303);
            this.V65.Name = "V65";
            this.V65.Size = new System.Drawing.Size(85, 28);
            this.V65.TabIndex = 73;
            // 
            // V60
            // 
            this.V60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V60.FormattingEnabled = true;
            this.V60.Location = new System.Drawing.Point(1107, 228);
            this.V60.Name = "V60";
            this.V60.Size = new System.Drawing.Size(85, 28);
            this.V60.TabIndex = 46;
            // 
            // V59
            // 
            this.V59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V59.FormattingEnabled = true;
            this.V59.Location = new System.Drawing.Point(1015, 228);
            this.V59.Name = "V59";
            this.V59.Size = new System.Drawing.Size(85, 28);
            this.V59.TabIndex = 47;
            // 
            // V58
            // 
            this.V58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V58.FormattingEnabled = true;
            this.V58.Location = new System.Drawing.Point(923, 228);
            this.V58.Name = "V58";
            this.V58.Size = new System.Drawing.Size(85, 28);
            this.V58.TabIndex = 48;
            // 
            // V57
            // 
            this.V57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V57.FormattingEnabled = true;
            this.V57.Location = new System.Drawing.Point(831, 228);
            this.V57.Name = "V57";
            this.V57.Size = new System.Drawing.Size(85, 28);
            this.V57.TabIndex = 49;
            // 
            // V33
            // 
            this.V33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V33.FormattingEnabled = true;
            this.V33.Location = new System.Drawing.Point(95, 153);
            this.V33.Name = "V33";
            this.V33.Size = new System.Drawing.Size(85, 28);
            this.V33.TabIndex = 5;
            // 
            // V56
            // 
            this.V56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V56.FormattingEnabled = true;
            this.V56.Location = new System.Drawing.Point(739, 228);
            this.V56.Name = "V56";
            this.V56.Size = new System.Drawing.Size(85, 28);
            this.V56.TabIndex = 50;
            // 
            // V55
            // 
            this.V55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V55.FormattingEnabled = true;
            this.V55.Location = new System.Drawing.Point(647, 228);
            this.V55.Name = "V55";
            this.V55.Size = new System.Drawing.Size(85, 28);
            this.V55.TabIndex = 51;
            // 
            // V54
            // 
            this.V54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V54.FormattingEnabled = true;
            this.V54.Location = new System.Drawing.Point(555, 228);
            this.V54.Name = "V54";
            this.V54.Size = new System.Drawing.Size(85, 28);
            this.V54.TabIndex = 52;
            // 
            // V53
            // 
            this.V53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V53.FormattingEnabled = true;
            this.V53.Location = new System.Drawing.Point(463, 228);
            this.V53.Name = "V53";
            this.V53.Size = new System.Drawing.Size(85, 28);
            this.V53.TabIndex = 53;
            // 
            // V52
            // 
            this.V52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V52.FormattingEnabled = true;
            this.V52.Location = new System.Drawing.Point(371, 228);
            this.V52.Name = "V52";
            this.V52.Size = new System.Drawing.Size(85, 28);
            this.V52.TabIndex = 54;
            // 
            // V51
            // 
            this.V51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V51.FormattingEnabled = true;
            this.V51.Location = new System.Drawing.Point(279, 228);
            this.V51.Name = "V51";
            this.V51.Size = new System.Drawing.Size(85, 28);
            this.V51.TabIndex = 55;
            // 
            // V50
            // 
            this.V50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V50.FormattingEnabled = true;
            this.V50.Location = new System.Drawing.Point(187, 228);
            this.V50.Name = "V50";
            this.V50.Size = new System.Drawing.Size(85, 28);
            this.V50.TabIndex = 56;
            // 
            // V49
            // 
            this.V49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V49.FormattingEnabled = true;
            this.V49.Location = new System.Drawing.Point(95, 228);
            this.V49.Name = "V49";
            this.V49.Size = new System.Drawing.Size(85, 28);
            this.V49.TabIndex = 57;
            // 
            // V31
            // 
            this.V31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V31.FormattingEnabled = true;
            this.V31.Location = new System.Drawing.Point(1383, 78);
            this.V31.Name = "V31";
            this.V31.Size = new System.Drawing.Size(85, 28);
            this.V31.TabIndex = 5;
            // 
            // V30
            // 
            this.V30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V30.FormattingEnabled = true;
            this.V30.Location = new System.Drawing.Point(1291, 78);
            this.V30.Name = "V30";
            this.V30.Size = new System.Drawing.Size(85, 28);
            this.V30.TabIndex = 5;
            // 
            // V29
            // 
            this.V29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V29.FormattingEnabled = true;
            this.V29.Location = new System.Drawing.Point(1199, 78);
            this.V29.Name = "V29";
            this.V29.Size = new System.Drawing.Size(85, 28);
            this.V29.TabIndex = 5;
            // 
            // V28
            // 
            this.V28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V28.FormattingEnabled = true;
            this.V28.Location = new System.Drawing.Point(1107, 78);
            this.V28.Name = "V28";
            this.V28.Size = new System.Drawing.Size(85, 28);
            this.V28.TabIndex = 5;
            // 
            // V27
            // 
            this.V27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V27.FormattingEnabled = true;
            this.V27.Location = new System.Drawing.Point(1015, 78);
            this.V27.Name = "V27";
            this.V27.Size = new System.Drawing.Size(85, 28);
            this.V27.TabIndex = 6;
            // 
            // V25
            // 
            this.V25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V25.FormattingEnabled = true;
            this.V25.Location = new System.Drawing.Point(831, 78);
            this.V25.Name = "V25";
            this.V25.Size = new System.Drawing.Size(85, 28);
            this.V25.TabIndex = 5;
            // 
            // V26
            // 
            this.V26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V26.FormattingEnabled = true;
            this.V26.Location = new System.Drawing.Point(923, 78);
            this.V26.Name = "V26";
            this.V26.Size = new System.Drawing.Size(85, 28);
            this.V26.TabIndex = 5;
            // 
            // V24
            // 
            this.V24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V24.FormattingEnabled = true;
            this.V24.Location = new System.Drawing.Point(739, 78);
            this.V24.Name = "V24";
            this.V24.Size = new System.Drawing.Size(85, 28);
            this.V24.TabIndex = 5;
            // 
            // V23
            // 
            this.V23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V23.FormattingEnabled = true;
            this.V23.Location = new System.Drawing.Point(647, 78);
            this.V23.Name = "V23";
            this.V23.Size = new System.Drawing.Size(85, 28);
            this.V23.TabIndex = 5;
            // 
            // V22
            // 
            this.V22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V22.FormattingEnabled = true;
            this.V22.Location = new System.Drawing.Point(555, 78);
            this.V22.Name = "V22";
            this.V22.Size = new System.Drawing.Size(85, 28);
            this.V22.TabIndex = 5;
            // 
            // V21
            // 
            this.V21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V21.FormattingEnabled = true;
            this.V21.Location = new System.Drawing.Point(463, 78);
            this.V21.Name = "V21";
            this.V21.Size = new System.Drawing.Size(85, 28);
            this.V21.TabIndex = 5;
            // 
            // V20
            // 
            this.V20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V20.FormattingEnabled = true;
            this.V20.Location = new System.Drawing.Point(371, 78);
            this.V20.Name = "V20";
            this.V20.Size = new System.Drawing.Size(85, 28);
            this.V20.TabIndex = 5;
            // 
            // V18
            // 
            this.V18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V18.FormattingEnabled = true;
            this.V18.Location = new System.Drawing.Point(187, 78);
            this.V18.Name = "V18";
            this.V18.Size = new System.Drawing.Size(85, 28);
            this.V18.TabIndex = 5;
            // 
            // V16
            // 
            this.V16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V16.FormattingEnabled = true;
            this.V16.Location = new System.Drawing.Point(3, 78);
            this.V16.Name = "V16";
            this.V16.Size = new System.Drawing.Size(85, 28);
            this.V16.TabIndex = 5;
            // 
            // V1
            // 
            this.V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V1.FormattingEnabled = true;
            this.V1.Location = new System.Drawing.Point(95, 3);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(85, 28);
            this.V1.TabIndex = 4;
            // 
            // V2
            // 
            this.V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V2.FormattingEnabled = true;
            this.V2.Location = new System.Drawing.Point(187, 3);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(85, 28);
            this.V2.TabIndex = 7;
            // 
            // V3
            // 
            this.V3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V3.FormattingEnabled = true;
            this.V3.Location = new System.Drawing.Point(279, 3);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(85, 28);
            this.V3.TabIndex = 8;
            // 
            // V4
            // 
            this.V4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V4.FormattingEnabled = true;
            this.V4.Location = new System.Drawing.Point(371, 3);
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(85, 28);
            this.V4.TabIndex = 12;
            // 
            // V5
            // 
            this.V5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V5.FormattingEnabled = true;
            this.V5.Location = new System.Drawing.Point(463, 3);
            this.V5.Name = "V5";
            this.V5.Size = new System.Drawing.Size(85, 28);
            this.V5.TabIndex = 11;
            // 
            // V6
            // 
            this.V6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V6.FormattingEnabled = true;
            this.V6.Location = new System.Drawing.Point(555, 3);
            this.V6.Name = "V6";
            this.V6.Size = new System.Drawing.Size(85, 28);
            this.V6.TabIndex = 15;
            // 
            // V7
            // 
            this.V7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V7.FormattingEnabled = true;
            this.V7.Location = new System.Drawing.Point(647, 3);
            this.V7.Name = "V7";
            this.V7.Size = new System.Drawing.Size(85, 28);
            this.V7.TabIndex = 16;
            // 
            // V8
            // 
            this.V8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V8.FormattingEnabled = true;
            this.V8.Location = new System.Drawing.Point(739, 3);
            this.V8.Name = "V8";
            this.V8.Size = new System.Drawing.Size(85, 28);
            this.V8.TabIndex = 23;
            // 
            // V9
            // 
            this.V9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V9.FormattingEnabled = true;
            this.V9.Location = new System.Drawing.Point(831, 3);
            this.V9.Name = "V9";
            this.V9.Size = new System.Drawing.Size(85, 28);
            this.V9.TabIndex = 22;
            // 
            // V10
            // 
            this.V10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V10.FormattingEnabled = true;
            this.V10.Location = new System.Drawing.Point(923, 3);
            this.V10.Name = "V10";
            this.V10.Size = new System.Drawing.Size(85, 28);
            this.V10.TabIndex = 21;
            // 
            // V11
            // 
            this.V11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V11.FormattingEnabled = true;
            this.V11.Location = new System.Drawing.Point(1015, 3);
            this.V11.Name = "V11";
            this.V11.Size = new System.Drawing.Size(85, 28);
            this.V11.TabIndex = 24;
            // 
            // V12
            // 
            this.V12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V12.FormattingEnabled = true;
            this.V12.Location = new System.Drawing.Point(1107, 3);
            this.V12.Name = "V12";
            this.V12.Size = new System.Drawing.Size(85, 28);
            this.V12.TabIndex = 20;
            // 
            // V13
            // 
            this.V13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V13.FormattingEnabled = true;
            this.V13.Location = new System.Drawing.Point(1199, 3);
            this.V13.Name = "V13";
            this.V13.Size = new System.Drawing.Size(85, 28);
            this.V13.TabIndex = 25;
            // 
            // V14
            // 
            this.V14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V14.FormattingEnabled = true;
            this.V14.Location = new System.Drawing.Point(1291, 3);
            this.V14.Name = "V14";
            this.V14.Size = new System.Drawing.Size(85, 28);
            this.V14.TabIndex = 19;
            // 
            // V15
            // 
            this.V15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V15.FormattingEnabled = true;
            this.V15.Location = new System.Drawing.Point(1383, 3);
            this.V15.Name = "V15";
            this.V15.Size = new System.Drawing.Size(85, 28);
            this.V15.TabIndex = 18;
            // 
            // V17
            // 
            this.V17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V17.FormattingEnabled = true;
            this.V17.Location = new System.Drawing.Point(95, 78);
            this.V17.Name = "V17";
            this.V17.Size = new System.Drawing.Size(85, 28);
            this.V17.TabIndex = 26;
            // 
            // V19
            // 
            this.V19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V19.FormattingEnabled = true;
            this.V19.Location = new System.Drawing.Point(279, 78);
            this.V19.Name = "V19";
            this.V19.Size = new System.Drawing.Size(85, 28);
            this.V19.TabIndex = 27;
            // 
            // V32
            // 
            this.V32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V32.FormattingEnabled = true;
            this.V32.Location = new System.Drawing.Point(3, 153);
            this.V32.Name = "V32";
            this.V32.Size = new System.Drawing.Size(85, 28);
            this.V32.TabIndex = 5;
            // 
            // V34
            // 
            this.V34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V34.FormattingEnabled = true;
            this.V34.Location = new System.Drawing.Point(187, 153);
            this.V34.Name = "V34";
            this.V34.Size = new System.Drawing.Size(85, 28);
            this.V34.TabIndex = 28;
            // 
            // V35
            // 
            this.V35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V35.FormattingEnabled = true;
            this.V35.Location = new System.Drawing.Point(279, 153);
            this.V35.Name = "V35";
            this.V35.Size = new System.Drawing.Size(85, 28);
            this.V35.TabIndex = 29;
            // 
            // V36
            // 
            this.V36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V36.FormattingEnabled = true;
            this.V36.Location = new System.Drawing.Point(371, 153);
            this.V36.Name = "V36";
            this.V36.Size = new System.Drawing.Size(85, 28);
            this.V36.TabIndex = 30;
            // 
            // V37
            // 
            this.V37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V37.FormattingEnabled = true;
            this.V37.Location = new System.Drawing.Point(463, 153);
            this.V37.Name = "V37";
            this.V37.Size = new System.Drawing.Size(85, 28);
            this.V37.TabIndex = 31;
            // 
            // V38
            // 
            this.V38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V38.FormattingEnabled = true;
            this.V38.Location = new System.Drawing.Point(555, 153);
            this.V38.Name = "V38";
            this.V38.Size = new System.Drawing.Size(85, 28);
            this.V38.TabIndex = 32;
            // 
            // V39
            // 
            this.V39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V39.FormattingEnabled = true;
            this.V39.Location = new System.Drawing.Point(647, 153);
            this.V39.Name = "V39";
            this.V39.Size = new System.Drawing.Size(85, 28);
            this.V39.TabIndex = 33;
            // 
            // V40
            // 
            this.V40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V40.FormattingEnabled = true;
            this.V40.Location = new System.Drawing.Point(739, 153);
            this.V40.Name = "V40";
            this.V40.Size = new System.Drawing.Size(85, 28);
            this.V40.TabIndex = 34;
            // 
            // V41
            // 
            this.V41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V41.FormattingEnabled = true;
            this.V41.Location = new System.Drawing.Point(831, 153);
            this.V41.Name = "V41";
            this.V41.Size = new System.Drawing.Size(85, 28);
            this.V41.TabIndex = 35;
            // 
            // V42
            // 
            this.V42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V42.FormattingEnabled = true;
            this.V42.Location = new System.Drawing.Point(923, 153);
            this.V42.Name = "V42";
            this.V42.Size = new System.Drawing.Size(85, 28);
            this.V42.TabIndex = 36;
            // 
            // V43
            // 
            this.V43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V43.FormattingEnabled = true;
            this.V43.Location = new System.Drawing.Point(1015, 153);
            this.V43.Name = "V43";
            this.V43.Size = new System.Drawing.Size(85, 28);
            this.V43.TabIndex = 37;
            // 
            // V44
            // 
            this.V44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V44.FormattingEnabled = true;
            this.V44.Location = new System.Drawing.Point(1107, 153);
            this.V44.Name = "V44";
            this.V44.Size = new System.Drawing.Size(85, 28);
            this.V44.TabIndex = 38;
            // 
            // V45
            // 
            this.V45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V45.FormattingEnabled = true;
            this.V45.Location = new System.Drawing.Point(1199, 153);
            this.V45.Name = "V45";
            this.V45.Size = new System.Drawing.Size(85, 28);
            this.V45.TabIndex = 39;
            // 
            // V46
            // 
            this.V46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V46.FormattingEnabled = true;
            this.V46.Location = new System.Drawing.Point(1291, 153);
            this.V46.Name = "V46";
            this.V46.Size = new System.Drawing.Size(85, 28);
            this.V46.TabIndex = 40;
            // 
            // V47
            // 
            this.V47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V47.FormattingEnabled = true;
            this.V47.Location = new System.Drawing.Point(1383, 153);
            this.V47.Name = "V47";
            this.V47.Size = new System.Drawing.Size(85, 28);
            this.V47.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OnOffButton);
            this.panel4.Location = new System.Drawing.Point(726, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 49);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SaveButton);
            this.panel5.Location = new System.Drawing.Point(1121, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 49);
            this.panel5.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(9, 6);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(77, 36);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Export";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LoadButton);
            this.panel6.Location = new System.Drawing.Point(1301, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 49);
            this.panel6.TabIndex = 9;
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoadButton.Depth = 0;
            this.LoadButton.HighEmphasis = true;
            this.LoadButton.Icon = null;
            this.LoadButton.Location = new System.Drawing.Point(4, 7);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoadButton.Size = new System.Drawing.Size(76, 36);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Import";
            this.LoadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoadButton.UseAccentColor = false;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Antenna_Controller.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::Antenna_Controller.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(937, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // OnOffButton
            // 
            this.OnOffButton.AutoSize = true;
            this.OnOffButton.Location = new System.Drawing.Point(17, 3);
            this.OnOffButton.MinimumSize = new System.Drawing.Size(80, 45);
            this.OnOffButton.Name = "OnOffButton";
            this.OnOffButton.OffBackColor = System.Drawing.Color.Gray;
            this.OnOffButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.OnOffButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OnOffButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.OnOffButton.Size = new System.Drawing.Size(80, 45);
            this.OnOffButton.TabIndex = 6;
            this.OnOffButton.UseVisualStyleBackColor = true;
            this.OnOffButton.CheckedChanged += new System.EventHandler(this.OnOffButton_CheckedChanged_1);
            // 
            // S144
            // 
            this.S144.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S144.AutoSize = true;
            this.S144.Location = new System.Drawing.Point(13, 713);
            this.S144.MinimumSize = new System.Drawing.Size(66, 35);
            this.S144.Name = "S144";
            this.S144.OffBackColor = System.Drawing.Color.LightGreen;
            this.S144.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S144.OnBackColor = System.Drawing.Color.Red;
            this.S144.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S144.Size = new System.Drawing.Size(66, 35);
            this.S144.TabIndex = 146;
            this.S144.UseVisualStyleBackColor = true;
            // 
            // S159
            // 
            this.S159.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S159.AutoSize = true;
            this.S159.Location = new System.Drawing.Point(1393, 713);
            this.S159.MinimumSize = new System.Drawing.Size(66, 35);
            this.S159.Name = "S159";
            this.S159.OffBackColor = System.Drawing.Color.LightGreen;
            this.S159.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S159.OnBackColor = System.Drawing.Color.Red;
            this.S159.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S159.Size = new System.Drawing.Size(66, 35);
            this.S159.TabIndex = 147;
            this.S159.UseVisualStyleBackColor = true;
            // 
            // S158
            // 
            this.S158.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S158.AutoSize = true;
            this.S158.Location = new System.Drawing.Point(1301, 713);
            this.S158.MinimumSize = new System.Drawing.Size(66, 35);
            this.S158.Name = "S158";
            this.S158.OffBackColor = System.Drawing.Color.LightGreen;
            this.S158.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S158.OnBackColor = System.Drawing.Color.Red;
            this.S158.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S158.Size = new System.Drawing.Size(66, 35);
            this.S158.TabIndex = 157;
            this.S158.UseVisualStyleBackColor = true;
            // 
            // S128
            // 
            this.S128.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S128.AutoSize = true;
            this.S128.Location = new System.Drawing.Point(13, 638);
            this.S128.MinimumSize = new System.Drawing.Size(66, 35);
            this.S128.Name = "S128";
            this.S128.OffBackColor = System.Drawing.Color.LightGreen;
            this.S128.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S128.OnBackColor = System.Drawing.Color.Red;
            this.S128.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S128.Size = new System.Drawing.Size(66, 35);
            this.S128.TabIndex = 130;
            this.S128.UseVisualStyleBackColor = true;
            // 
            // S157
            // 
            this.S157.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S157.AutoSize = true;
            this.S157.Location = new System.Drawing.Point(1209, 713);
            this.S157.MinimumSize = new System.Drawing.Size(66, 35);
            this.S157.Name = "S157";
            this.S157.OffBackColor = System.Drawing.Color.LightGreen;
            this.S157.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S157.OnBackColor = System.Drawing.Color.Red;
            this.S157.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S157.Size = new System.Drawing.Size(66, 35);
            this.S157.TabIndex = 148;
            this.S157.UseVisualStyleBackColor = true;
            // 
            // S156
            // 
            this.S156.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S156.AutoSize = true;
            this.S156.Location = new System.Drawing.Point(1117, 713);
            this.S156.MinimumSize = new System.Drawing.Size(66, 35);
            this.S156.Name = "S156";
            this.S156.OffBackColor = System.Drawing.Color.LightGreen;
            this.S156.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S156.OnBackColor = System.Drawing.Color.Red;
            this.S156.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S156.Size = new System.Drawing.Size(66, 35);
            this.S156.TabIndex = 155;
            this.S156.UseVisualStyleBackColor = true;
            // 
            // S155
            // 
            this.S155.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S155.AutoSize = true;
            this.S155.Location = new System.Drawing.Point(1025, 713);
            this.S155.MinimumSize = new System.Drawing.Size(66, 35);
            this.S155.Name = "S155";
            this.S155.OffBackColor = System.Drawing.Color.LightGreen;
            this.S155.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S155.OnBackColor = System.Drawing.Color.Red;
            this.S155.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S155.Size = new System.Drawing.Size(66, 35);
            this.S155.TabIndex = 154;
            this.S155.UseVisualStyleBackColor = true;
            // 
            // S143
            // 
            this.S143.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S143.AutoSize = true;
            this.S143.Location = new System.Drawing.Point(1393, 638);
            this.S143.MinimumSize = new System.Drawing.Size(66, 35);
            this.S143.Name = "S143";
            this.S143.OffBackColor = System.Drawing.Color.LightGreen;
            this.S143.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S143.OnBackColor = System.Drawing.Color.Red;
            this.S143.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S143.Size = new System.Drawing.Size(66, 35);
            this.S143.TabIndex = 131;
            this.S143.UseVisualStyleBackColor = true;
            // 
            // S154
            // 
            this.S154.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S154.AutoSize = true;
            this.S154.Location = new System.Drawing.Point(933, 713);
            this.S154.MinimumSize = new System.Drawing.Size(66, 35);
            this.S154.Name = "S154";
            this.S154.OffBackColor = System.Drawing.Color.LightGreen;
            this.S154.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S154.OnBackColor = System.Drawing.Color.Red;
            this.S154.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S154.Size = new System.Drawing.Size(66, 35);
            this.S154.TabIndex = 149;
            this.S154.UseVisualStyleBackColor = true;
            // 
            // S153
            // 
            this.S153.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S153.AutoSize = true;
            this.S153.Location = new System.Drawing.Point(841, 713);
            this.S153.MinimumSize = new System.Drawing.Size(66, 35);
            this.S153.Name = "S153";
            this.S153.OffBackColor = System.Drawing.Color.LightGreen;
            this.S153.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S153.OnBackColor = System.Drawing.Color.Red;
            this.S153.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S153.Size = new System.Drawing.Size(66, 35);
            this.S153.TabIndex = 153;
            this.S153.UseVisualStyleBackColor = true;
            // 
            // S152
            // 
            this.S152.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S152.AutoSize = true;
            this.S152.Location = new System.Drawing.Point(749, 713);
            this.S152.MinimumSize = new System.Drawing.Size(66, 35);
            this.S152.Name = "S152";
            this.S152.OffBackColor = System.Drawing.Color.LightGreen;
            this.S152.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S152.OnBackColor = System.Drawing.Color.Red;
            this.S152.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S152.Size = new System.Drawing.Size(66, 35);
            this.S152.TabIndex = 151;
            this.S152.UseVisualStyleBackColor = true;
            // 
            // S151
            // 
            this.S151.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S151.AutoSize = true;
            this.S151.Location = new System.Drawing.Point(657, 713);
            this.S151.MinimumSize = new System.Drawing.Size(66, 35);
            this.S151.Name = "S151";
            this.S151.OffBackColor = System.Drawing.Color.LightGreen;
            this.S151.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S151.OnBackColor = System.Drawing.Color.Red;
            this.S151.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S151.Size = new System.Drawing.Size(66, 35);
            this.S151.TabIndex = 150;
            this.S151.UseVisualStyleBackColor = true;
            // 
            // S142
            // 
            this.S142.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S142.AutoSize = true;
            this.S142.Location = new System.Drawing.Point(1301, 638);
            this.S142.MinimumSize = new System.Drawing.Size(66, 35);
            this.S142.Name = "S142";
            this.S142.OffBackColor = System.Drawing.Color.LightGreen;
            this.S142.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S142.OnBackColor = System.Drawing.Color.Red;
            this.S142.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S142.Size = new System.Drawing.Size(66, 35);
            this.S142.TabIndex = 141;
            this.S142.UseVisualStyleBackColor = true;
            // 
            // S150
            // 
            this.S150.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S150.AutoSize = true;
            this.S150.Location = new System.Drawing.Point(565, 713);
            this.S150.MinimumSize = new System.Drawing.Size(66, 35);
            this.S150.Name = "S150";
            this.S150.OffBackColor = System.Drawing.Color.LightGreen;
            this.S150.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S150.OnBackColor = System.Drawing.Color.Red;
            this.S150.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S150.Size = new System.Drawing.Size(66, 35);
            this.S150.TabIndex = 152;
            this.S150.UseVisualStyleBackColor = true;
            // 
            // S149
            // 
            this.S149.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S149.AutoSize = true;
            this.S149.Location = new System.Drawing.Point(473, 713);
            this.S149.MinimumSize = new System.Drawing.Size(66, 35);
            this.S149.Name = "S149";
            this.S149.OffBackColor = System.Drawing.Color.LightGreen;
            this.S149.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S149.OnBackColor = System.Drawing.Color.Red;
            this.S149.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S149.Size = new System.Drawing.Size(66, 35);
            this.S149.TabIndex = 156;
            this.S149.UseVisualStyleBackColor = true;
            // 
            // S112
            // 
            this.S112.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S112.AutoSize = true;
            this.S112.Location = new System.Drawing.Point(13, 563);
            this.S112.MinimumSize = new System.Drawing.Size(66, 35);
            this.S112.Name = "S112";
            this.S112.OffBackColor = System.Drawing.Color.LightGreen;
            this.S112.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S112.OnBackColor = System.Drawing.Color.Red;
            this.S112.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S112.Size = new System.Drawing.Size(66, 35);
            this.S112.TabIndex = 114;
            this.S112.UseVisualStyleBackColor = true;
            // 
            // S148
            // 
            this.S148.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S148.AutoSize = true;
            this.S148.Location = new System.Drawing.Point(381, 713);
            this.S148.MinimumSize = new System.Drawing.Size(66, 35);
            this.S148.Name = "S148";
            this.S148.OffBackColor = System.Drawing.Color.LightGreen;
            this.S148.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S148.OnBackColor = System.Drawing.Color.Red;
            this.S148.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S148.Size = new System.Drawing.Size(66, 35);
            this.S148.TabIndex = 159;
            this.S148.UseVisualStyleBackColor = true;
            // 
            // S147
            // 
            this.S147.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S147.AutoSize = true;
            this.S147.Location = new System.Drawing.Point(289, 713);
            this.S147.MinimumSize = new System.Drawing.Size(66, 35);
            this.S147.Name = "S147";
            this.S147.OffBackColor = System.Drawing.Color.LightGreen;
            this.S147.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S147.OnBackColor = System.Drawing.Color.Red;
            this.S147.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S147.Size = new System.Drawing.Size(66, 35);
            this.S147.TabIndex = 158;
            this.S147.UseVisualStyleBackColor = true;
            // 
            // S141
            // 
            this.S141.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S141.AutoSize = true;
            this.S141.Location = new System.Drawing.Point(1209, 638);
            this.S141.MinimumSize = new System.Drawing.Size(66, 35);
            this.S141.Name = "S141";
            this.S141.OffBackColor = System.Drawing.Color.LightGreen;
            this.S141.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S141.OnBackColor = System.Drawing.Color.Red;
            this.S141.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S141.Size = new System.Drawing.Size(66, 35);
            this.S141.TabIndex = 132;
            this.S141.UseVisualStyleBackColor = true;
            // 
            // S146
            // 
            this.S146.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S146.AutoSize = true;
            this.S146.Location = new System.Drawing.Point(197, 713);
            this.S146.MinimumSize = new System.Drawing.Size(66, 35);
            this.S146.Name = "S146";
            this.S146.OffBackColor = System.Drawing.Color.LightGreen;
            this.S146.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S146.OnBackColor = System.Drawing.Color.Red;
            this.S146.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S146.Size = new System.Drawing.Size(66, 35);
            this.S146.TabIndex = 160;
            this.S146.UseVisualStyleBackColor = true;
            // 
            // S145
            // 
            this.S145.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S145.AutoSize = true;
            this.S145.Location = new System.Drawing.Point(105, 713);
            this.S145.MinimumSize = new System.Drawing.Size(66, 35);
            this.S145.Name = "S145";
            this.S145.OffBackColor = System.Drawing.Color.LightGreen;
            this.S145.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S145.OnBackColor = System.Drawing.Color.Red;
            this.S145.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S145.Size = new System.Drawing.Size(66, 35);
            this.S145.TabIndex = 161;
            this.S145.UseVisualStyleBackColor = true;
            // 
            // S140
            // 
            this.S140.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S140.AutoSize = true;
            this.S140.Location = new System.Drawing.Point(1117, 638);
            this.S140.MinimumSize = new System.Drawing.Size(66, 35);
            this.S140.Name = "S140";
            this.S140.OffBackColor = System.Drawing.Color.LightGreen;
            this.S140.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S140.OnBackColor = System.Drawing.Color.Red;
            this.S140.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S140.Size = new System.Drawing.Size(66, 35);
            this.S140.TabIndex = 139;
            this.S140.UseVisualStyleBackColor = true;
            // 
            // S139
            // 
            this.S139.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S139.AutoSize = true;
            this.S139.Location = new System.Drawing.Point(1025, 638);
            this.S139.MinimumSize = new System.Drawing.Size(66, 35);
            this.S139.Name = "S139";
            this.S139.OffBackColor = System.Drawing.Color.LightGreen;
            this.S139.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S139.OnBackColor = System.Drawing.Color.Red;
            this.S139.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S139.Size = new System.Drawing.Size(66, 35);
            this.S139.TabIndex = 138;
            this.S139.UseVisualStyleBackColor = true;
            // 
            // S127
            // 
            this.S127.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S127.AutoSize = true;
            this.S127.Location = new System.Drawing.Point(1393, 563);
            this.S127.MinimumSize = new System.Drawing.Size(66, 35);
            this.S127.Name = "S127";
            this.S127.OffBackColor = System.Drawing.Color.LightGreen;
            this.S127.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S127.OnBackColor = System.Drawing.Color.Red;
            this.S127.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S127.Size = new System.Drawing.Size(66, 35);
            this.S127.TabIndex = 115;
            this.S127.UseVisualStyleBackColor = true;
            // 
            // S138
            // 
            this.S138.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S138.AutoSize = true;
            this.S138.Location = new System.Drawing.Point(933, 638);
            this.S138.MinimumSize = new System.Drawing.Size(66, 35);
            this.S138.Name = "S138";
            this.S138.OffBackColor = System.Drawing.Color.LightGreen;
            this.S138.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S138.OnBackColor = System.Drawing.Color.Red;
            this.S138.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S138.Size = new System.Drawing.Size(66, 35);
            this.S138.TabIndex = 133;
            this.S138.UseVisualStyleBackColor = true;
            // 
            // S137
            // 
            this.S137.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S137.AutoSize = true;
            this.S137.Location = new System.Drawing.Point(841, 638);
            this.S137.MinimumSize = new System.Drawing.Size(66, 35);
            this.S137.Name = "S137";
            this.S137.OffBackColor = System.Drawing.Color.LightGreen;
            this.S137.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S137.OnBackColor = System.Drawing.Color.Red;
            this.S137.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S137.Size = new System.Drawing.Size(66, 35);
            this.S137.TabIndex = 137;
            this.S137.UseVisualStyleBackColor = true;
            // 
            // S136
            // 
            this.S136.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S136.AutoSize = true;
            this.S136.Location = new System.Drawing.Point(749, 638);
            this.S136.MinimumSize = new System.Drawing.Size(66, 35);
            this.S136.Name = "S136";
            this.S136.OffBackColor = System.Drawing.Color.LightGreen;
            this.S136.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S136.OnBackColor = System.Drawing.Color.Red;
            this.S136.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S136.Size = new System.Drawing.Size(66, 35);
            this.S136.TabIndex = 135;
            this.S136.UseVisualStyleBackColor = true;
            // 
            // S135
            // 
            this.S135.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S135.AutoSize = true;
            this.S135.Location = new System.Drawing.Point(657, 638);
            this.S135.MinimumSize = new System.Drawing.Size(66, 35);
            this.S135.Name = "S135";
            this.S135.OffBackColor = System.Drawing.Color.LightGreen;
            this.S135.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S135.OnBackColor = System.Drawing.Color.Red;
            this.S135.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S135.Size = new System.Drawing.Size(66, 35);
            this.S135.TabIndex = 134;
            this.S135.UseVisualStyleBackColor = true;
            // 
            // S126
            // 
            this.S126.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S126.AutoSize = true;
            this.S126.Location = new System.Drawing.Point(1301, 563);
            this.S126.MinimumSize = new System.Drawing.Size(66, 35);
            this.S126.Name = "S126";
            this.S126.OffBackColor = System.Drawing.Color.LightGreen;
            this.S126.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S126.OnBackColor = System.Drawing.Color.Red;
            this.S126.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S126.Size = new System.Drawing.Size(66, 35);
            this.S126.TabIndex = 125;
            this.S126.UseVisualStyleBackColor = true;
            // 
            // S134
            // 
            this.S134.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S134.AutoSize = true;
            this.S134.Location = new System.Drawing.Point(565, 638);
            this.S134.MinimumSize = new System.Drawing.Size(66, 35);
            this.S134.Name = "S134";
            this.S134.OffBackColor = System.Drawing.Color.LightGreen;
            this.S134.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S134.OnBackColor = System.Drawing.Color.Red;
            this.S134.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S134.Size = new System.Drawing.Size(66, 35);
            this.S134.TabIndex = 136;
            this.S134.UseVisualStyleBackColor = true;
            // 
            // S133
            // 
            this.S133.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S133.AutoSize = true;
            this.S133.Location = new System.Drawing.Point(473, 638);
            this.S133.MinimumSize = new System.Drawing.Size(66, 35);
            this.S133.Name = "S133";
            this.S133.OffBackColor = System.Drawing.Color.LightGreen;
            this.S133.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S133.OnBackColor = System.Drawing.Color.Red;
            this.S133.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S133.Size = new System.Drawing.Size(66, 35);
            this.S133.TabIndex = 140;
            this.S133.UseVisualStyleBackColor = true;
            // 
            // S96
            // 
            this.S96.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S96.AutoSize = true;
            this.S96.Location = new System.Drawing.Point(13, 488);
            this.S96.MinimumSize = new System.Drawing.Size(66, 35);
            this.S96.Name = "S96";
            this.S96.OffBackColor = System.Drawing.Color.LightGreen;
            this.S96.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S96.OnBackColor = System.Drawing.Color.Red;
            this.S96.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S96.Size = new System.Drawing.Size(66, 35);
            this.S96.TabIndex = 98;
            this.S96.UseVisualStyleBackColor = true;
            // 
            // S132
            // 
            this.S132.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S132.AutoSize = true;
            this.S132.Location = new System.Drawing.Point(381, 638);
            this.S132.MinimumSize = new System.Drawing.Size(66, 35);
            this.S132.Name = "S132";
            this.S132.OffBackColor = System.Drawing.Color.LightGreen;
            this.S132.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S132.OnBackColor = System.Drawing.Color.Red;
            this.S132.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S132.Size = new System.Drawing.Size(66, 35);
            this.S132.TabIndex = 143;
            this.S132.UseVisualStyleBackColor = true;
            // 
            // S131
            // 
            this.S131.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S131.AutoSize = true;
            this.S131.Location = new System.Drawing.Point(289, 638);
            this.S131.MinimumSize = new System.Drawing.Size(66, 35);
            this.S131.Name = "S131";
            this.S131.OffBackColor = System.Drawing.Color.LightGreen;
            this.S131.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S131.OnBackColor = System.Drawing.Color.Red;
            this.S131.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S131.Size = new System.Drawing.Size(66, 35);
            this.S131.TabIndex = 142;
            this.S131.UseVisualStyleBackColor = true;
            // 
            // S125
            // 
            this.S125.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S125.AutoSize = true;
            this.S125.Location = new System.Drawing.Point(1209, 563);
            this.S125.MinimumSize = new System.Drawing.Size(66, 35);
            this.S125.Name = "S125";
            this.S125.OffBackColor = System.Drawing.Color.LightGreen;
            this.S125.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S125.OnBackColor = System.Drawing.Color.Red;
            this.S125.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S125.Size = new System.Drawing.Size(66, 35);
            this.S125.TabIndex = 116;
            this.S125.UseVisualStyleBackColor = true;
            // 
            // S130
            // 
            this.S130.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S130.AutoSize = true;
            this.S130.Location = new System.Drawing.Point(197, 638);
            this.S130.MinimumSize = new System.Drawing.Size(66, 35);
            this.S130.Name = "S130";
            this.S130.OffBackColor = System.Drawing.Color.LightGreen;
            this.S130.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S130.OnBackColor = System.Drawing.Color.Red;
            this.S130.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S130.Size = new System.Drawing.Size(66, 35);
            this.S130.TabIndex = 144;
            this.S130.UseVisualStyleBackColor = true;
            // 
            // S129
            // 
            this.S129.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S129.AutoSize = true;
            this.S129.Location = new System.Drawing.Point(105, 638);
            this.S129.MinimumSize = new System.Drawing.Size(66, 35);
            this.S129.Name = "S129";
            this.S129.OffBackColor = System.Drawing.Color.LightGreen;
            this.S129.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S129.OnBackColor = System.Drawing.Color.Red;
            this.S129.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S129.Size = new System.Drawing.Size(66, 35);
            this.S129.TabIndex = 145;
            this.S129.UseVisualStyleBackColor = true;
            // 
            // S124
            // 
            this.S124.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S124.AutoSize = true;
            this.S124.Location = new System.Drawing.Point(1117, 563);
            this.S124.MinimumSize = new System.Drawing.Size(66, 35);
            this.S124.Name = "S124";
            this.S124.OffBackColor = System.Drawing.Color.LightGreen;
            this.S124.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S124.OnBackColor = System.Drawing.Color.Red;
            this.S124.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S124.Size = new System.Drawing.Size(66, 35);
            this.S124.TabIndex = 123;
            this.S124.UseVisualStyleBackColor = true;
            // 
            // S123
            // 
            this.S123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S123.AutoSize = true;
            this.S123.Location = new System.Drawing.Point(1025, 563);
            this.S123.MinimumSize = new System.Drawing.Size(66, 35);
            this.S123.Name = "S123";
            this.S123.OffBackColor = System.Drawing.Color.LightGreen;
            this.S123.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S123.OnBackColor = System.Drawing.Color.Red;
            this.S123.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S123.Size = new System.Drawing.Size(66, 35);
            this.S123.TabIndex = 122;
            this.S123.UseVisualStyleBackColor = true;
            // 
            // S111
            // 
            this.S111.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S111.AutoSize = true;
            this.S111.Location = new System.Drawing.Point(1393, 488);
            this.S111.MinimumSize = new System.Drawing.Size(66, 35);
            this.S111.Name = "S111";
            this.S111.OffBackColor = System.Drawing.Color.LightGreen;
            this.S111.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S111.OnBackColor = System.Drawing.Color.Red;
            this.S111.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S111.Size = new System.Drawing.Size(66, 35);
            this.S111.TabIndex = 99;
            this.S111.UseVisualStyleBackColor = true;
            // 
            // S122
            // 
            this.S122.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S122.AutoSize = true;
            this.S122.Location = new System.Drawing.Point(933, 563);
            this.S122.MinimumSize = new System.Drawing.Size(66, 35);
            this.S122.Name = "S122";
            this.S122.OffBackColor = System.Drawing.Color.LightGreen;
            this.S122.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S122.OnBackColor = System.Drawing.Color.Red;
            this.S122.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S122.Size = new System.Drawing.Size(66, 35);
            this.S122.TabIndex = 117;
            this.S122.UseVisualStyleBackColor = true;
            // 
            // S121
            // 
            this.S121.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S121.AutoSize = true;
            this.S121.Location = new System.Drawing.Point(841, 563);
            this.S121.MinimumSize = new System.Drawing.Size(66, 35);
            this.S121.Name = "S121";
            this.S121.OffBackColor = System.Drawing.Color.LightGreen;
            this.S121.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S121.OnBackColor = System.Drawing.Color.Red;
            this.S121.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S121.Size = new System.Drawing.Size(66, 35);
            this.S121.TabIndex = 121;
            this.S121.UseVisualStyleBackColor = true;
            // 
            // S120
            // 
            this.S120.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S120.AutoSize = true;
            this.S120.Location = new System.Drawing.Point(749, 563);
            this.S120.MinimumSize = new System.Drawing.Size(66, 35);
            this.S120.Name = "S120";
            this.S120.OffBackColor = System.Drawing.Color.LightGreen;
            this.S120.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S120.OnBackColor = System.Drawing.Color.Red;
            this.S120.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S120.Size = new System.Drawing.Size(66, 35);
            this.S120.TabIndex = 119;
            this.S120.UseVisualStyleBackColor = true;
            // 
            // S119
            // 
            this.S119.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S119.AutoSize = true;
            this.S119.Location = new System.Drawing.Point(657, 563);
            this.S119.MinimumSize = new System.Drawing.Size(66, 35);
            this.S119.Name = "S119";
            this.S119.OffBackColor = System.Drawing.Color.LightGreen;
            this.S119.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S119.OnBackColor = System.Drawing.Color.Red;
            this.S119.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S119.Size = new System.Drawing.Size(66, 35);
            this.S119.TabIndex = 118;
            this.S119.UseVisualStyleBackColor = true;
            // 
            // S110
            // 
            this.S110.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S110.AutoSize = true;
            this.S110.Location = new System.Drawing.Point(1301, 488);
            this.S110.MinimumSize = new System.Drawing.Size(66, 35);
            this.S110.Name = "S110";
            this.S110.OffBackColor = System.Drawing.Color.LightGreen;
            this.S110.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S110.OnBackColor = System.Drawing.Color.Red;
            this.S110.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S110.Size = new System.Drawing.Size(66, 35);
            this.S110.TabIndex = 109;
            this.S110.UseVisualStyleBackColor = true;
            // 
            // S118
            // 
            this.S118.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S118.AutoSize = true;
            this.S118.Location = new System.Drawing.Point(565, 563);
            this.S118.MinimumSize = new System.Drawing.Size(66, 35);
            this.S118.Name = "S118";
            this.S118.OffBackColor = System.Drawing.Color.LightGreen;
            this.S118.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S118.OnBackColor = System.Drawing.Color.Red;
            this.S118.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S118.Size = new System.Drawing.Size(66, 35);
            this.S118.TabIndex = 120;
            this.S118.UseVisualStyleBackColor = true;
            // 
            // S117
            // 
            this.S117.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S117.AutoSize = true;
            this.S117.Location = new System.Drawing.Point(473, 563);
            this.S117.MinimumSize = new System.Drawing.Size(66, 35);
            this.S117.Name = "S117";
            this.S117.OffBackColor = System.Drawing.Color.LightGreen;
            this.S117.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S117.OnBackColor = System.Drawing.Color.Red;
            this.S117.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S117.Size = new System.Drawing.Size(66, 35);
            this.S117.TabIndex = 124;
            this.S117.UseVisualStyleBackColor = true;
            // 
            // S80
            // 
            this.S80.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S80.AutoSize = true;
            this.S80.Location = new System.Drawing.Point(13, 413);
            this.S80.MinimumSize = new System.Drawing.Size(66, 35);
            this.S80.Name = "S80";
            this.S80.OffBackColor = System.Drawing.Color.LightGreen;
            this.S80.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S80.OnBackColor = System.Drawing.Color.Red;
            this.S80.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S80.Size = new System.Drawing.Size(66, 35);
            this.S80.TabIndex = 82;
            this.S80.UseVisualStyleBackColor = true;
            // 
            // S116
            // 
            this.S116.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S116.AutoSize = true;
            this.S116.Location = new System.Drawing.Point(381, 563);
            this.S116.MinimumSize = new System.Drawing.Size(66, 35);
            this.S116.Name = "S116";
            this.S116.OffBackColor = System.Drawing.Color.LightGreen;
            this.S116.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S116.OnBackColor = System.Drawing.Color.Red;
            this.S116.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S116.Size = new System.Drawing.Size(66, 35);
            this.S116.TabIndex = 127;
            this.S116.UseVisualStyleBackColor = true;
            // 
            // S115
            // 
            this.S115.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S115.AutoSize = true;
            this.S115.Location = new System.Drawing.Point(289, 563);
            this.S115.MinimumSize = new System.Drawing.Size(66, 35);
            this.S115.Name = "S115";
            this.S115.OffBackColor = System.Drawing.Color.LightGreen;
            this.S115.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S115.OnBackColor = System.Drawing.Color.Red;
            this.S115.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S115.Size = new System.Drawing.Size(66, 35);
            this.S115.TabIndex = 126;
            this.S115.UseVisualStyleBackColor = true;
            // 
            // S109
            // 
            this.S109.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S109.AutoSize = true;
            this.S109.Location = new System.Drawing.Point(1209, 488);
            this.S109.MinimumSize = new System.Drawing.Size(66, 35);
            this.S109.Name = "S109";
            this.S109.OffBackColor = System.Drawing.Color.LightGreen;
            this.S109.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S109.OnBackColor = System.Drawing.Color.Red;
            this.S109.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S109.Size = new System.Drawing.Size(66, 35);
            this.S109.TabIndex = 100;
            this.S109.UseVisualStyleBackColor = true;
            // 
            // S114
            // 
            this.S114.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S114.AutoSize = true;
            this.S114.Location = new System.Drawing.Point(197, 563);
            this.S114.MinimumSize = new System.Drawing.Size(66, 35);
            this.S114.Name = "S114";
            this.S114.OffBackColor = System.Drawing.Color.LightGreen;
            this.S114.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S114.OnBackColor = System.Drawing.Color.Red;
            this.S114.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S114.Size = new System.Drawing.Size(66, 35);
            this.S114.TabIndex = 128;
            this.S114.UseVisualStyleBackColor = true;
            // 
            // S113
            // 
            this.S113.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S113.AutoSize = true;
            this.S113.Location = new System.Drawing.Point(105, 563);
            this.S113.MinimumSize = new System.Drawing.Size(66, 35);
            this.S113.Name = "S113";
            this.S113.OffBackColor = System.Drawing.Color.LightGreen;
            this.S113.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S113.OnBackColor = System.Drawing.Color.Red;
            this.S113.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S113.Size = new System.Drawing.Size(66, 35);
            this.S113.TabIndex = 129;
            this.S113.UseVisualStyleBackColor = true;
            // 
            // S108
            // 
            this.S108.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S108.AutoSize = true;
            this.S108.Location = new System.Drawing.Point(1117, 488);
            this.S108.MinimumSize = new System.Drawing.Size(66, 35);
            this.S108.Name = "S108";
            this.S108.OffBackColor = System.Drawing.Color.LightGreen;
            this.S108.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S108.OnBackColor = System.Drawing.Color.Red;
            this.S108.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S108.Size = new System.Drawing.Size(66, 35);
            this.S108.TabIndex = 107;
            this.S108.UseVisualStyleBackColor = true;
            // 
            // S107
            // 
            this.S107.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S107.AutoSize = true;
            this.S107.Location = new System.Drawing.Point(1025, 488);
            this.S107.MinimumSize = new System.Drawing.Size(66, 35);
            this.S107.Name = "S107";
            this.S107.OffBackColor = System.Drawing.Color.LightGreen;
            this.S107.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S107.OnBackColor = System.Drawing.Color.Red;
            this.S107.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S107.Size = new System.Drawing.Size(66, 35);
            this.S107.TabIndex = 106;
            this.S107.UseVisualStyleBackColor = true;
            // 
            // S95
            // 
            this.S95.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S95.AutoSize = true;
            this.S95.Location = new System.Drawing.Point(1393, 413);
            this.S95.MinimumSize = new System.Drawing.Size(66, 35);
            this.S95.Name = "S95";
            this.S95.OffBackColor = System.Drawing.Color.LightGreen;
            this.S95.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S95.OnBackColor = System.Drawing.Color.Red;
            this.S95.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S95.Size = new System.Drawing.Size(66, 35);
            this.S95.TabIndex = 83;
            this.S95.UseVisualStyleBackColor = true;
            // 
            // S106
            // 
            this.S106.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S106.AutoSize = true;
            this.S106.Location = new System.Drawing.Point(933, 488);
            this.S106.MinimumSize = new System.Drawing.Size(66, 35);
            this.S106.Name = "S106";
            this.S106.OffBackColor = System.Drawing.Color.LightGreen;
            this.S106.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S106.OnBackColor = System.Drawing.Color.Red;
            this.S106.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S106.Size = new System.Drawing.Size(66, 35);
            this.S106.TabIndex = 101;
            this.S106.UseVisualStyleBackColor = true;
            // 
            // S105
            // 
            this.S105.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S105.AutoSize = true;
            this.S105.Location = new System.Drawing.Point(841, 488);
            this.S105.MinimumSize = new System.Drawing.Size(66, 35);
            this.S105.Name = "S105";
            this.S105.OffBackColor = System.Drawing.Color.LightGreen;
            this.S105.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S105.OnBackColor = System.Drawing.Color.Red;
            this.S105.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S105.Size = new System.Drawing.Size(66, 35);
            this.S105.TabIndex = 105;
            this.S105.UseVisualStyleBackColor = true;
            // 
            // S104
            // 
            this.S104.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S104.AutoSize = true;
            this.S104.Location = new System.Drawing.Point(749, 488);
            this.S104.MinimumSize = new System.Drawing.Size(66, 35);
            this.S104.Name = "S104";
            this.S104.OffBackColor = System.Drawing.Color.LightGreen;
            this.S104.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S104.OnBackColor = System.Drawing.Color.Red;
            this.S104.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S104.Size = new System.Drawing.Size(66, 35);
            this.S104.TabIndex = 103;
            this.S104.UseVisualStyleBackColor = true;
            // 
            // S103
            // 
            this.S103.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S103.AutoSize = true;
            this.S103.Location = new System.Drawing.Point(657, 488);
            this.S103.MinimumSize = new System.Drawing.Size(66, 35);
            this.S103.Name = "S103";
            this.S103.OffBackColor = System.Drawing.Color.LightGreen;
            this.S103.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S103.OnBackColor = System.Drawing.Color.Red;
            this.S103.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S103.Size = new System.Drawing.Size(66, 35);
            this.S103.TabIndex = 102;
            this.S103.UseVisualStyleBackColor = true;
            // 
            // S94
            // 
            this.S94.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S94.AutoSize = true;
            this.S94.Location = new System.Drawing.Point(1301, 413);
            this.S94.MinimumSize = new System.Drawing.Size(66, 35);
            this.S94.Name = "S94";
            this.S94.OffBackColor = System.Drawing.Color.LightGreen;
            this.S94.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S94.OnBackColor = System.Drawing.Color.Red;
            this.S94.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S94.Size = new System.Drawing.Size(66, 35);
            this.S94.TabIndex = 93;
            this.S94.UseVisualStyleBackColor = true;
            // 
            // S102
            // 
            this.S102.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S102.AutoSize = true;
            this.S102.Location = new System.Drawing.Point(565, 488);
            this.S102.MinimumSize = new System.Drawing.Size(66, 35);
            this.S102.Name = "S102";
            this.S102.OffBackColor = System.Drawing.Color.LightGreen;
            this.S102.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S102.OnBackColor = System.Drawing.Color.Red;
            this.S102.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S102.Size = new System.Drawing.Size(66, 35);
            this.S102.TabIndex = 104;
            this.S102.UseVisualStyleBackColor = true;
            // 
            // S101
            // 
            this.S101.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S101.AutoSize = true;
            this.S101.Location = new System.Drawing.Point(473, 488);
            this.S101.MinimumSize = new System.Drawing.Size(66, 35);
            this.S101.Name = "S101";
            this.S101.OffBackColor = System.Drawing.Color.LightGreen;
            this.S101.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S101.OnBackColor = System.Drawing.Color.Red;
            this.S101.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S101.Size = new System.Drawing.Size(66, 35);
            this.S101.TabIndex = 108;
            this.S101.UseVisualStyleBackColor = true;
            // 
            // S64
            // 
            this.S64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S64.AutoSize = true;
            this.S64.Location = new System.Drawing.Point(13, 338);
            this.S64.MinimumSize = new System.Drawing.Size(66, 35);
            this.S64.Name = "S64";
            this.S64.OffBackColor = System.Drawing.Color.LightGreen;
            this.S64.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S64.OnBackColor = System.Drawing.Color.Red;
            this.S64.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S64.Size = new System.Drawing.Size(66, 35);
            this.S64.TabIndex = 66;
            this.S64.UseVisualStyleBackColor = true;
            // 
            // S100
            // 
            this.S100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S100.AutoSize = true;
            this.S100.Location = new System.Drawing.Point(381, 488);
            this.S100.MinimumSize = new System.Drawing.Size(66, 35);
            this.S100.Name = "S100";
            this.S100.OffBackColor = System.Drawing.Color.LightGreen;
            this.S100.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S100.OnBackColor = System.Drawing.Color.Red;
            this.S100.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S100.Size = new System.Drawing.Size(66, 35);
            this.S100.TabIndex = 111;
            this.S100.UseVisualStyleBackColor = true;
            // 
            // S99
            // 
            this.S99.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S99.AutoSize = true;
            this.S99.Location = new System.Drawing.Point(289, 488);
            this.S99.MinimumSize = new System.Drawing.Size(66, 35);
            this.S99.Name = "S99";
            this.S99.OffBackColor = System.Drawing.Color.LightGreen;
            this.S99.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S99.OnBackColor = System.Drawing.Color.Red;
            this.S99.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S99.Size = new System.Drawing.Size(66, 35);
            this.S99.TabIndex = 110;
            this.S99.UseVisualStyleBackColor = true;
            // 
            // S93
            // 
            this.S93.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S93.AutoSize = true;
            this.S93.Location = new System.Drawing.Point(1209, 413);
            this.S93.MinimumSize = new System.Drawing.Size(66, 35);
            this.S93.Name = "S93";
            this.S93.OffBackColor = System.Drawing.Color.LightGreen;
            this.S93.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S93.OnBackColor = System.Drawing.Color.Red;
            this.S93.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S93.Size = new System.Drawing.Size(66, 35);
            this.S93.TabIndex = 84;
            this.S93.UseVisualStyleBackColor = true;
            // 
            // S98
            // 
            this.S98.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S98.AutoSize = true;
            this.S98.Location = new System.Drawing.Point(197, 488);
            this.S98.MinimumSize = new System.Drawing.Size(66, 35);
            this.S98.Name = "S98";
            this.S98.OffBackColor = System.Drawing.Color.LightGreen;
            this.S98.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S98.OnBackColor = System.Drawing.Color.Red;
            this.S98.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S98.Size = new System.Drawing.Size(66, 35);
            this.S98.TabIndex = 112;
            this.S98.UseVisualStyleBackColor = true;
            // 
            // S97
            // 
            this.S97.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S97.AutoSize = true;
            this.S97.Location = new System.Drawing.Point(105, 488);
            this.S97.MinimumSize = new System.Drawing.Size(66, 35);
            this.S97.Name = "S97";
            this.S97.OffBackColor = System.Drawing.Color.LightGreen;
            this.S97.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S97.OnBackColor = System.Drawing.Color.Red;
            this.S97.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S97.Size = new System.Drawing.Size(66, 35);
            this.S97.TabIndex = 113;
            this.S97.UseVisualStyleBackColor = true;
            // 
            // S92
            // 
            this.S92.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S92.AutoSize = true;
            this.S92.Location = new System.Drawing.Point(1117, 413);
            this.S92.MinimumSize = new System.Drawing.Size(66, 35);
            this.S92.Name = "S92";
            this.S92.OffBackColor = System.Drawing.Color.LightGreen;
            this.S92.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S92.OnBackColor = System.Drawing.Color.Red;
            this.S92.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S92.Size = new System.Drawing.Size(66, 35);
            this.S92.TabIndex = 91;
            this.S92.UseVisualStyleBackColor = true;
            // 
            // S91
            // 
            this.S91.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S91.AutoSize = true;
            this.S91.Location = new System.Drawing.Point(1025, 413);
            this.S91.MinimumSize = new System.Drawing.Size(66, 35);
            this.S91.Name = "S91";
            this.S91.OffBackColor = System.Drawing.Color.LightGreen;
            this.S91.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S91.OnBackColor = System.Drawing.Color.Red;
            this.S91.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S91.Size = new System.Drawing.Size(66, 35);
            this.S91.TabIndex = 90;
            this.S91.UseVisualStyleBackColor = true;
            // 
            // S79
            // 
            this.S79.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S79.AutoSize = true;
            this.S79.Location = new System.Drawing.Point(1393, 338);
            this.S79.MinimumSize = new System.Drawing.Size(66, 35);
            this.S79.Name = "S79";
            this.S79.OffBackColor = System.Drawing.Color.LightGreen;
            this.S79.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S79.OnBackColor = System.Drawing.Color.Red;
            this.S79.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S79.Size = new System.Drawing.Size(66, 35);
            this.S79.TabIndex = 67;
            this.S79.UseVisualStyleBackColor = true;
            // 
            // S90
            // 
            this.S90.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S90.AutoSize = true;
            this.S90.Location = new System.Drawing.Point(933, 413);
            this.S90.MinimumSize = new System.Drawing.Size(66, 35);
            this.S90.Name = "S90";
            this.S90.OffBackColor = System.Drawing.Color.LightGreen;
            this.S90.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S90.OnBackColor = System.Drawing.Color.Red;
            this.S90.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S90.Size = new System.Drawing.Size(66, 35);
            this.S90.TabIndex = 85;
            this.S90.UseVisualStyleBackColor = true;
            // 
            // S89
            // 
            this.S89.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S89.AutoSize = true;
            this.S89.Location = new System.Drawing.Point(841, 413);
            this.S89.MinimumSize = new System.Drawing.Size(66, 35);
            this.S89.Name = "S89";
            this.S89.OffBackColor = System.Drawing.Color.LightGreen;
            this.S89.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S89.OnBackColor = System.Drawing.Color.Red;
            this.S89.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S89.Size = new System.Drawing.Size(66, 35);
            this.S89.TabIndex = 89;
            this.S89.UseVisualStyleBackColor = true;
            // 
            // S88
            // 
            this.S88.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S88.AutoSize = true;
            this.S88.Location = new System.Drawing.Point(749, 413);
            this.S88.MinimumSize = new System.Drawing.Size(66, 35);
            this.S88.Name = "S88";
            this.S88.OffBackColor = System.Drawing.Color.LightGreen;
            this.S88.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S88.OnBackColor = System.Drawing.Color.Red;
            this.S88.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S88.Size = new System.Drawing.Size(66, 35);
            this.S88.TabIndex = 87;
            this.S88.UseVisualStyleBackColor = true;
            // 
            // S87
            // 
            this.S87.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S87.AutoSize = true;
            this.S87.Location = new System.Drawing.Point(657, 413);
            this.S87.MinimumSize = new System.Drawing.Size(66, 35);
            this.S87.Name = "S87";
            this.S87.OffBackColor = System.Drawing.Color.LightGreen;
            this.S87.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S87.OnBackColor = System.Drawing.Color.Red;
            this.S87.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S87.Size = new System.Drawing.Size(66, 35);
            this.S87.TabIndex = 86;
            this.S87.UseVisualStyleBackColor = true;
            // 
            // S78
            // 
            this.S78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S78.AutoSize = true;
            this.S78.Location = new System.Drawing.Point(1301, 338);
            this.S78.MinimumSize = new System.Drawing.Size(66, 35);
            this.S78.Name = "S78";
            this.S78.OffBackColor = System.Drawing.Color.LightGreen;
            this.S78.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S78.OnBackColor = System.Drawing.Color.Red;
            this.S78.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S78.Size = new System.Drawing.Size(66, 35);
            this.S78.TabIndex = 77;
            this.S78.UseVisualStyleBackColor = true;
            // 
            // S86
            // 
            this.S86.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S86.AutoSize = true;
            this.S86.Location = new System.Drawing.Point(565, 413);
            this.S86.MinimumSize = new System.Drawing.Size(66, 35);
            this.S86.Name = "S86";
            this.S86.OffBackColor = System.Drawing.Color.LightGreen;
            this.S86.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S86.OnBackColor = System.Drawing.Color.Red;
            this.S86.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S86.Size = new System.Drawing.Size(66, 35);
            this.S86.TabIndex = 88;
            this.S86.UseVisualStyleBackColor = true;
            // 
            // S85
            // 
            this.S85.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S85.AutoSize = true;
            this.S85.Location = new System.Drawing.Point(473, 413);
            this.S85.MinimumSize = new System.Drawing.Size(66, 35);
            this.S85.Name = "S85";
            this.S85.OffBackColor = System.Drawing.Color.LightGreen;
            this.S85.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S85.OnBackColor = System.Drawing.Color.Red;
            this.S85.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S85.Size = new System.Drawing.Size(66, 35);
            this.S85.TabIndex = 92;
            this.S85.UseVisualStyleBackColor = true;
            // 
            // S48
            // 
            this.S48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S48.AutoSize = true;
            this.S48.Location = new System.Drawing.Point(13, 263);
            this.S48.MinimumSize = new System.Drawing.Size(66, 35);
            this.S48.Name = "S48";
            this.S48.OffBackColor = System.Drawing.Color.LightGreen;
            this.S48.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S48.OnBackColor = System.Drawing.Color.Red;
            this.S48.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S48.Size = new System.Drawing.Size(66, 35);
            this.S48.TabIndex = 50;
            this.S48.UseVisualStyleBackColor = true;
            // 
            // S84
            // 
            this.S84.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S84.AutoSize = true;
            this.S84.Location = new System.Drawing.Point(381, 413);
            this.S84.MinimumSize = new System.Drawing.Size(66, 35);
            this.S84.Name = "S84";
            this.S84.OffBackColor = System.Drawing.Color.LightGreen;
            this.S84.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S84.OnBackColor = System.Drawing.Color.Red;
            this.S84.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S84.Size = new System.Drawing.Size(66, 35);
            this.S84.TabIndex = 95;
            this.S84.UseVisualStyleBackColor = true;
            // 
            // S83
            // 
            this.S83.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S83.AutoSize = true;
            this.S83.Location = new System.Drawing.Point(289, 413);
            this.S83.MinimumSize = new System.Drawing.Size(66, 35);
            this.S83.Name = "S83";
            this.S83.OffBackColor = System.Drawing.Color.LightGreen;
            this.S83.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S83.OnBackColor = System.Drawing.Color.Red;
            this.S83.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S83.Size = new System.Drawing.Size(66, 35);
            this.S83.TabIndex = 94;
            this.S83.UseVisualStyleBackColor = true;
            // 
            // S77
            // 
            this.S77.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S77.AutoSize = true;
            this.S77.Location = new System.Drawing.Point(1209, 338);
            this.S77.MinimumSize = new System.Drawing.Size(66, 35);
            this.S77.Name = "S77";
            this.S77.OffBackColor = System.Drawing.Color.LightGreen;
            this.S77.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S77.OnBackColor = System.Drawing.Color.Red;
            this.S77.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S77.Size = new System.Drawing.Size(66, 35);
            this.S77.TabIndex = 68;
            this.S77.UseVisualStyleBackColor = true;
            // 
            // S82
            // 
            this.S82.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S82.AutoSize = true;
            this.S82.Location = new System.Drawing.Point(197, 413);
            this.S82.MinimumSize = new System.Drawing.Size(66, 35);
            this.S82.Name = "S82";
            this.S82.OffBackColor = System.Drawing.Color.LightGreen;
            this.S82.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S82.OnBackColor = System.Drawing.Color.Red;
            this.S82.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S82.Size = new System.Drawing.Size(66, 35);
            this.S82.TabIndex = 96;
            this.S82.UseVisualStyleBackColor = true;
            // 
            // S81
            // 
            this.S81.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S81.AutoSize = true;
            this.S81.Location = new System.Drawing.Point(105, 413);
            this.S81.MinimumSize = new System.Drawing.Size(66, 35);
            this.S81.Name = "S81";
            this.S81.OffBackColor = System.Drawing.Color.LightGreen;
            this.S81.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S81.OnBackColor = System.Drawing.Color.Red;
            this.S81.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S81.Size = new System.Drawing.Size(66, 35);
            this.S81.TabIndex = 97;
            this.S81.UseVisualStyleBackColor = true;
            // 
            // S76
            // 
            this.S76.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S76.AutoSize = true;
            this.S76.Location = new System.Drawing.Point(1117, 338);
            this.S76.MinimumSize = new System.Drawing.Size(66, 35);
            this.S76.Name = "S76";
            this.S76.OffBackColor = System.Drawing.Color.LightGreen;
            this.S76.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S76.OnBackColor = System.Drawing.Color.Red;
            this.S76.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S76.Size = new System.Drawing.Size(66, 35);
            this.S76.TabIndex = 75;
            this.S76.UseVisualStyleBackColor = true;
            // 
            // S75
            // 
            this.S75.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S75.AutoSize = true;
            this.S75.Location = new System.Drawing.Point(1025, 338);
            this.S75.MinimumSize = new System.Drawing.Size(66, 35);
            this.S75.Name = "S75";
            this.S75.OffBackColor = System.Drawing.Color.LightGreen;
            this.S75.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S75.OnBackColor = System.Drawing.Color.Red;
            this.S75.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S75.Size = new System.Drawing.Size(66, 35);
            this.S75.TabIndex = 74;
            this.S75.UseVisualStyleBackColor = true;
            // 
            // S63
            // 
            this.S63.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S63.AutoSize = true;
            this.S63.Location = new System.Drawing.Point(1393, 263);
            this.S63.MinimumSize = new System.Drawing.Size(66, 35);
            this.S63.Name = "S63";
            this.S63.OffBackColor = System.Drawing.Color.LightGreen;
            this.S63.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S63.OnBackColor = System.Drawing.Color.Red;
            this.S63.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S63.Size = new System.Drawing.Size(66, 35);
            this.S63.TabIndex = 51;
            this.S63.UseVisualStyleBackColor = true;
            // 
            // S74
            // 
            this.S74.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S74.AutoSize = true;
            this.S74.Location = new System.Drawing.Point(933, 338);
            this.S74.MinimumSize = new System.Drawing.Size(66, 35);
            this.S74.Name = "S74";
            this.S74.OffBackColor = System.Drawing.Color.LightGreen;
            this.S74.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S74.OnBackColor = System.Drawing.Color.Red;
            this.S74.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S74.Size = new System.Drawing.Size(66, 35);
            this.S74.TabIndex = 69;
            this.S74.UseVisualStyleBackColor = true;
            // 
            // S73
            // 
            this.S73.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S73.AutoSize = true;
            this.S73.Location = new System.Drawing.Point(841, 338);
            this.S73.MinimumSize = new System.Drawing.Size(66, 35);
            this.S73.Name = "S73";
            this.S73.OffBackColor = System.Drawing.Color.LightGreen;
            this.S73.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S73.OnBackColor = System.Drawing.Color.Red;
            this.S73.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S73.Size = new System.Drawing.Size(66, 35);
            this.S73.TabIndex = 73;
            this.S73.UseVisualStyleBackColor = true;
            // 
            // S72
            // 
            this.S72.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S72.AutoSize = true;
            this.S72.Location = new System.Drawing.Point(749, 338);
            this.S72.MinimumSize = new System.Drawing.Size(66, 35);
            this.S72.Name = "S72";
            this.S72.OffBackColor = System.Drawing.Color.LightGreen;
            this.S72.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S72.OnBackColor = System.Drawing.Color.Red;
            this.S72.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S72.Size = new System.Drawing.Size(66, 35);
            this.S72.TabIndex = 71;
            this.S72.UseVisualStyleBackColor = true;
            // 
            // S71
            // 
            this.S71.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S71.AutoSize = true;
            this.S71.Location = new System.Drawing.Point(657, 338);
            this.S71.MinimumSize = new System.Drawing.Size(66, 35);
            this.S71.Name = "S71";
            this.S71.OffBackColor = System.Drawing.Color.LightGreen;
            this.S71.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S71.OnBackColor = System.Drawing.Color.Red;
            this.S71.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S71.Size = new System.Drawing.Size(66, 35);
            this.S71.TabIndex = 70;
            this.S71.UseVisualStyleBackColor = true;
            // 
            // S62
            // 
            this.S62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S62.AutoSize = true;
            this.S62.Location = new System.Drawing.Point(1301, 263);
            this.S62.MinimumSize = new System.Drawing.Size(66, 35);
            this.S62.Name = "S62";
            this.S62.OffBackColor = System.Drawing.Color.LightGreen;
            this.S62.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S62.OnBackColor = System.Drawing.Color.Red;
            this.S62.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S62.Size = new System.Drawing.Size(66, 35);
            this.S62.TabIndex = 61;
            this.S62.UseVisualStyleBackColor = true;
            // 
            // S70
            // 
            this.S70.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S70.AutoSize = true;
            this.S70.Location = new System.Drawing.Point(565, 338);
            this.S70.MinimumSize = new System.Drawing.Size(66, 35);
            this.S70.Name = "S70";
            this.S70.OffBackColor = System.Drawing.Color.LightGreen;
            this.S70.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S70.OnBackColor = System.Drawing.Color.Red;
            this.S70.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S70.Size = new System.Drawing.Size(66, 35);
            this.S70.TabIndex = 72;
            this.S70.UseVisualStyleBackColor = true;
            // 
            // S69
            // 
            this.S69.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S69.AutoSize = true;
            this.S69.Location = new System.Drawing.Point(473, 338);
            this.S69.MinimumSize = new System.Drawing.Size(66, 35);
            this.S69.Name = "S69";
            this.S69.OffBackColor = System.Drawing.Color.LightGreen;
            this.S69.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S69.OnBackColor = System.Drawing.Color.Red;
            this.S69.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S69.Size = new System.Drawing.Size(66, 35);
            this.S69.TabIndex = 76;
            this.S69.UseVisualStyleBackColor = true;
            // 
            // S32
            // 
            this.S32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S32.AutoSize = true;
            this.S32.Location = new System.Drawing.Point(13, 188);
            this.S32.MinimumSize = new System.Drawing.Size(66, 35);
            this.S32.Name = "S32";
            this.S32.OffBackColor = System.Drawing.Color.LightGreen;
            this.S32.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S32.OnBackColor = System.Drawing.Color.Red;
            this.S32.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S32.Size = new System.Drawing.Size(66, 35);
            this.S32.TabIndex = 34;
            this.S32.UseVisualStyleBackColor = true;
            // 
            // S68
            // 
            this.S68.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S68.AutoSize = true;
            this.S68.Location = new System.Drawing.Point(381, 338);
            this.S68.MinimumSize = new System.Drawing.Size(66, 35);
            this.S68.Name = "S68";
            this.S68.OffBackColor = System.Drawing.Color.LightGreen;
            this.S68.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S68.OnBackColor = System.Drawing.Color.Red;
            this.S68.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S68.Size = new System.Drawing.Size(66, 35);
            this.S68.TabIndex = 79;
            this.S68.UseVisualStyleBackColor = true;
            // 
            // S67
            // 
            this.S67.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S67.AutoSize = true;
            this.S67.Location = new System.Drawing.Point(289, 338);
            this.S67.MinimumSize = new System.Drawing.Size(66, 35);
            this.S67.Name = "S67";
            this.S67.OffBackColor = System.Drawing.Color.LightGreen;
            this.S67.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S67.OnBackColor = System.Drawing.Color.Red;
            this.S67.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S67.Size = new System.Drawing.Size(66, 35);
            this.S67.TabIndex = 78;
            this.S67.UseVisualStyleBackColor = true;
            // 
            // S61
            // 
            this.S61.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S61.AutoSize = true;
            this.S61.Location = new System.Drawing.Point(1209, 263);
            this.S61.MinimumSize = new System.Drawing.Size(66, 35);
            this.S61.Name = "S61";
            this.S61.OffBackColor = System.Drawing.Color.LightGreen;
            this.S61.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S61.OnBackColor = System.Drawing.Color.Red;
            this.S61.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S61.Size = new System.Drawing.Size(66, 35);
            this.S61.TabIndex = 52;
            this.S61.UseVisualStyleBackColor = true;
            // 
            // S66
            // 
            this.S66.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S66.AutoSize = true;
            this.S66.Location = new System.Drawing.Point(197, 338);
            this.S66.MinimumSize = new System.Drawing.Size(66, 35);
            this.S66.Name = "S66";
            this.S66.OffBackColor = System.Drawing.Color.LightGreen;
            this.S66.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S66.OnBackColor = System.Drawing.Color.Red;
            this.S66.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S66.Size = new System.Drawing.Size(66, 35);
            this.S66.TabIndex = 80;
            this.S66.UseVisualStyleBackColor = true;
            // 
            // S65
            // 
            this.S65.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S65.AutoSize = true;
            this.S65.Location = new System.Drawing.Point(105, 338);
            this.S65.MinimumSize = new System.Drawing.Size(66, 35);
            this.S65.Name = "S65";
            this.S65.OffBackColor = System.Drawing.Color.LightGreen;
            this.S65.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S65.OnBackColor = System.Drawing.Color.Red;
            this.S65.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S65.Size = new System.Drawing.Size(66, 35);
            this.S65.TabIndex = 81;
            this.S65.UseVisualStyleBackColor = true;
            // 
            // S60
            // 
            this.S60.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S60.AutoSize = true;
            this.S60.Location = new System.Drawing.Point(1117, 263);
            this.S60.MinimumSize = new System.Drawing.Size(66, 35);
            this.S60.Name = "S60";
            this.S60.OffBackColor = System.Drawing.Color.LightGreen;
            this.S60.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S60.OnBackColor = System.Drawing.Color.Red;
            this.S60.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S60.Size = new System.Drawing.Size(66, 35);
            this.S60.TabIndex = 59;
            this.S60.UseVisualStyleBackColor = true;
            // 
            // S59
            // 
            this.S59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S59.AutoSize = true;
            this.S59.Location = new System.Drawing.Point(1025, 263);
            this.S59.MinimumSize = new System.Drawing.Size(66, 35);
            this.S59.Name = "S59";
            this.S59.OffBackColor = System.Drawing.Color.LightGreen;
            this.S59.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S59.OnBackColor = System.Drawing.Color.Red;
            this.S59.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S59.Size = new System.Drawing.Size(66, 35);
            this.S59.TabIndex = 58;
            this.S59.UseVisualStyleBackColor = true;
            // 
            // S47
            // 
            this.S47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S47.AutoSize = true;
            this.S47.Location = new System.Drawing.Point(1393, 188);
            this.S47.MinimumSize = new System.Drawing.Size(66, 35);
            this.S47.Name = "S47";
            this.S47.OffBackColor = System.Drawing.Color.LightGreen;
            this.S47.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S47.OnBackColor = System.Drawing.Color.Red;
            this.S47.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S47.Size = new System.Drawing.Size(66, 35);
            this.S47.TabIndex = 35;
            this.S47.UseVisualStyleBackColor = true;
            // 
            // S58
            // 
            this.S58.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S58.AutoSize = true;
            this.S58.Location = new System.Drawing.Point(933, 263);
            this.S58.MinimumSize = new System.Drawing.Size(66, 35);
            this.S58.Name = "S58";
            this.S58.OffBackColor = System.Drawing.Color.LightGreen;
            this.S58.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S58.OnBackColor = System.Drawing.Color.Red;
            this.S58.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S58.Size = new System.Drawing.Size(66, 35);
            this.S58.TabIndex = 53;
            this.S58.UseVisualStyleBackColor = true;
            // 
            // S57
            // 
            this.S57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S57.AutoSize = true;
            this.S57.Location = new System.Drawing.Point(841, 263);
            this.S57.MinimumSize = new System.Drawing.Size(66, 35);
            this.S57.Name = "S57";
            this.S57.OffBackColor = System.Drawing.Color.LightGreen;
            this.S57.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S57.OnBackColor = System.Drawing.Color.Red;
            this.S57.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S57.Size = new System.Drawing.Size(66, 35);
            this.S57.TabIndex = 57;
            this.S57.UseVisualStyleBackColor = true;
            // 
            // S16
            // 
            this.S16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S16.AutoSize = true;
            this.S16.Location = new System.Drawing.Point(13, 113);
            this.S16.MinimumSize = new System.Drawing.Size(66, 35);
            this.S16.Name = "S16";
            this.S16.OffBackColor = System.Drawing.Color.LightGreen;
            this.S16.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S16.OnBackColor = System.Drawing.Color.Red;
            this.S16.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S16.Size = new System.Drawing.Size(66, 35);
            this.S16.TabIndex = 18;
            this.S16.UseVisualStyleBackColor = true;
            // 
            // S56
            // 
            this.S56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S56.AutoSize = true;
            this.S56.Location = new System.Drawing.Point(749, 263);
            this.S56.MinimumSize = new System.Drawing.Size(66, 35);
            this.S56.Name = "S56";
            this.S56.OffBackColor = System.Drawing.Color.LightGreen;
            this.S56.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S56.OnBackColor = System.Drawing.Color.Red;
            this.S56.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S56.Size = new System.Drawing.Size(66, 35);
            this.S56.TabIndex = 55;
            this.S56.UseVisualStyleBackColor = true;
            // 
            // S55
            // 
            this.S55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S55.AutoSize = true;
            this.S55.Location = new System.Drawing.Point(657, 263);
            this.S55.MinimumSize = new System.Drawing.Size(66, 35);
            this.S55.Name = "S55";
            this.S55.OffBackColor = System.Drawing.Color.LightGreen;
            this.S55.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S55.OnBackColor = System.Drawing.Color.Red;
            this.S55.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S55.Size = new System.Drawing.Size(66, 35);
            this.S55.TabIndex = 54;
            this.S55.UseVisualStyleBackColor = true;
            // 
            // S46
            // 
            this.S46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S46.AutoSize = true;
            this.S46.Location = new System.Drawing.Point(1301, 188);
            this.S46.MinimumSize = new System.Drawing.Size(66, 35);
            this.S46.Name = "S46";
            this.S46.OffBackColor = System.Drawing.Color.LightGreen;
            this.S46.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S46.OnBackColor = System.Drawing.Color.Red;
            this.S46.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S46.Size = new System.Drawing.Size(66, 35);
            this.S46.TabIndex = 45;
            this.S46.UseVisualStyleBackColor = true;
            // 
            // S54
            // 
            this.S54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S54.AutoSize = true;
            this.S54.Location = new System.Drawing.Point(565, 263);
            this.S54.MinimumSize = new System.Drawing.Size(66, 35);
            this.S54.Name = "S54";
            this.S54.OffBackColor = System.Drawing.Color.LightGreen;
            this.S54.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S54.OnBackColor = System.Drawing.Color.Red;
            this.S54.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S54.Size = new System.Drawing.Size(66, 35);
            this.S54.TabIndex = 56;
            this.S54.UseVisualStyleBackColor = true;
            // 
            // S53
            // 
            this.S53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S53.AutoSize = true;
            this.S53.Location = new System.Drawing.Point(473, 263);
            this.S53.MinimumSize = new System.Drawing.Size(66, 35);
            this.S53.Name = "S53";
            this.S53.OffBackColor = System.Drawing.Color.LightGreen;
            this.S53.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S53.OnBackColor = System.Drawing.Color.Red;
            this.S53.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S53.Size = new System.Drawing.Size(66, 35);
            this.S53.TabIndex = 60;
            this.S53.UseVisualStyleBackColor = true;
            // 
            // S31
            // 
            this.S31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S31.AutoSize = true;
            this.S31.Location = new System.Drawing.Point(1393, 113);
            this.S31.MinimumSize = new System.Drawing.Size(66, 35);
            this.S31.Name = "S31";
            this.S31.OffBackColor = System.Drawing.Color.LightGreen;
            this.S31.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S31.OnBackColor = System.Drawing.Color.Red;
            this.S31.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S31.Size = new System.Drawing.Size(66, 35);
            this.S31.TabIndex = 19;
            this.S31.UseVisualStyleBackColor = true;
            // 
            // S52
            // 
            this.S52.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S52.AutoSize = true;
            this.S52.Location = new System.Drawing.Point(381, 263);
            this.S52.MinimumSize = new System.Drawing.Size(66, 35);
            this.S52.Name = "S52";
            this.S52.OffBackColor = System.Drawing.Color.LightGreen;
            this.S52.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S52.OnBackColor = System.Drawing.Color.Red;
            this.S52.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S52.Size = new System.Drawing.Size(66, 35);
            this.S52.TabIndex = 63;
            this.S52.UseVisualStyleBackColor = true;
            // 
            // S51
            // 
            this.S51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S51.AutoSize = true;
            this.S51.Location = new System.Drawing.Point(289, 263);
            this.S51.MinimumSize = new System.Drawing.Size(66, 35);
            this.S51.Name = "S51";
            this.S51.OffBackColor = System.Drawing.Color.LightGreen;
            this.S51.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S51.OnBackColor = System.Drawing.Color.Red;
            this.S51.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S51.Size = new System.Drawing.Size(66, 35);
            this.S51.TabIndex = 62;
            this.S51.UseVisualStyleBackColor = true;
            // 
            // S45
            // 
            this.S45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S45.AutoSize = true;
            this.S45.Location = new System.Drawing.Point(1209, 188);
            this.S45.MinimumSize = new System.Drawing.Size(66, 35);
            this.S45.Name = "S45";
            this.S45.OffBackColor = System.Drawing.Color.LightGreen;
            this.S45.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S45.OnBackColor = System.Drawing.Color.Red;
            this.S45.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S45.Size = new System.Drawing.Size(66, 35);
            this.S45.TabIndex = 36;
            this.S45.UseVisualStyleBackColor = true;
            // 
            // S50
            // 
            this.S50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S50.AutoSize = true;
            this.S50.Location = new System.Drawing.Point(197, 263);
            this.S50.MinimumSize = new System.Drawing.Size(66, 35);
            this.S50.Name = "S50";
            this.S50.OffBackColor = System.Drawing.Color.LightGreen;
            this.S50.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S50.OnBackColor = System.Drawing.Color.Red;
            this.S50.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S50.Size = new System.Drawing.Size(66, 35);
            this.S50.TabIndex = 64;
            this.S50.UseVisualStyleBackColor = true;
            // 
            // S49
            // 
            this.S49.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S49.AutoSize = true;
            this.S49.Location = new System.Drawing.Point(105, 263);
            this.S49.MinimumSize = new System.Drawing.Size(66, 35);
            this.S49.Name = "S49";
            this.S49.OffBackColor = System.Drawing.Color.LightGreen;
            this.S49.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S49.OnBackColor = System.Drawing.Color.Red;
            this.S49.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S49.Size = new System.Drawing.Size(66, 35);
            this.S49.TabIndex = 65;
            this.S49.UseVisualStyleBackColor = true;
            // 
            // S44
            // 
            this.S44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S44.AutoSize = true;
            this.S44.Location = new System.Drawing.Point(1117, 188);
            this.S44.MinimumSize = new System.Drawing.Size(66, 35);
            this.S44.Name = "S44";
            this.S44.OffBackColor = System.Drawing.Color.LightGreen;
            this.S44.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S44.OnBackColor = System.Drawing.Color.Red;
            this.S44.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S44.Size = new System.Drawing.Size(66, 35);
            this.S44.TabIndex = 43;
            this.S44.UseVisualStyleBackColor = true;
            // 
            // S30
            // 
            this.S30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S30.AutoSize = true;
            this.S30.Location = new System.Drawing.Point(1301, 113);
            this.S30.MinimumSize = new System.Drawing.Size(66, 35);
            this.S30.Name = "S30";
            this.S30.OffBackColor = System.Drawing.Color.LightGreen;
            this.S30.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S30.OnBackColor = System.Drawing.Color.Red;
            this.S30.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S30.Size = new System.Drawing.Size(66, 35);
            this.S30.TabIndex = 29;
            this.S30.UseVisualStyleBackColor = true;
            // 
            // S43
            // 
            this.S43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S43.AutoSize = true;
            this.S43.Location = new System.Drawing.Point(1025, 188);
            this.S43.MinimumSize = new System.Drawing.Size(66, 35);
            this.S43.Name = "S43";
            this.S43.OffBackColor = System.Drawing.Color.LightGreen;
            this.S43.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S43.OnBackColor = System.Drawing.Color.Red;
            this.S43.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S43.Size = new System.Drawing.Size(66, 35);
            this.S43.TabIndex = 42;
            this.S43.UseVisualStyleBackColor = true;
            // 
            // S0
            // 
            this.S0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S0.AutoSize = true;
            this.S0.Location = new System.Drawing.Point(13, 38);
            this.S0.MinimumSize = new System.Drawing.Size(66, 35);
            this.S0.Name = "S0";
            this.S0.OffBackColor = System.Drawing.Color.LightGreen;
            this.S0.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S0.OnBackColor = System.Drawing.Color.Red;
            this.S0.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S0.Size = new System.Drawing.Size(66, 35);
            this.S0.TabIndex = 3;
            this.S0.UseVisualStyleBackColor = true;
            // 
            // S42
            // 
            this.S42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S42.AutoSize = true;
            this.S42.Location = new System.Drawing.Point(933, 188);
            this.S42.MinimumSize = new System.Drawing.Size(66, 35);
            this.S42.Name = "S42";
            this.S42.OffBackColor = System.Drawing.Color.LightGreen;
            this.S42.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S42.OnBackColor = System.Drawing.Color.Red;
            this.S42.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S42.Size = new System.Drawing.Size(66, 35);
            this.S42.TabIndex = 37;
            this.S42.UseVisualStyleBackColor = true;
            // 
            // S29
            // 
            this.S29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S29.AutoSize = true;
            this.S29.Location = new System.Drawing.Point(1209, 113);
            this.S29.MinimumSize = new System.Drawing.Size(66, 35);
            this.S29.Name = "S29";
            this.S29.OffBackColor = System.Drawing.Color.LightGreen;
            this.S29.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S29.OnBackColor = System.Drawing.Color.Red;
            this.S29.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S29.Size = new System.Drawing.Size(66, 35);
            this.S29.TabIndex = 20;
            this.S29.UseVisualStyleBackColor = true;
            // 
            // S41
            // 
            this.S41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S41.AutoSize = true;
            this.S41.Location = new System.Drawing.Point(841, 188);
            this.S41.MinimumSize = new System.Drawing.Size(66, 35);
            this.S41.Name = "S41";
            this.S41.OffBackColor = System.Drawing.Color.LightGreen;
            this.S41.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S41.OnBackColor = System.Drawing.Color.Red;
            this.S41.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S41.Size = new System.Drawing.Size(66, 35);
            this.S41.TabIndex = 41;
            this.S41.UseVisualStyleBackColor = true;
            // 
            // S40
            // 
            this.S40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S40.AutoSize = true;
            this.S40.Location = new System.Drawing.Point(749, 188);
            this.S40.MinimumSize = new System.Drawing.Size(66, 35);
            this.S40.Name = "S40";
            this.S40.OffBackColor = System.Drawing.Color.LightGreen;
            this.S40.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S40.OnBackColor = System.Drawing.Color.Red;
            this.S40.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S40.Size = new System.Drawing.Size(66, 35);
            this.S40.TabIndex = 39;
            this.S40.UseVisualStyleBackColor = true;
            // 
            // S28
            // 
            this.S28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S28.AutoSize = true;
            this.S28.Location = new System.Drawing.Point(1117, 113);
            this.S28.MinimumSize = new System.Drawing.Size(66, 35);
            this.S28.Name = "S28";
            this.S28.OffBackColor = System.Drawing.Color.LightGreen;
            this.S28.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S28.OnBackColor = System.Drawing.Color.Red;
            this.S28.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S28.Size = new System.Drawing.Size(66, 35);
            this.S28.TabIndex = 27;
            this.S28.UseVisualStyleBackColor = true;
            // 
            // S39
            // 
            this.S39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S39.AutoSize = true;
            this.S39.Location = new System.Drawing.Point(657, 188);
            this.S39.MinimumSize = new System.Drawing.Size(66, 35);
            this.S39.Name = "S39";
            this.S39.OffBackColor = System.Drawing.Color.LightGreen;
            this.S39.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S39.OnBackColor = System.Drawing.Color.Red;
            this.S39.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S39.Size = new System.Drawing.Size(66, 35);
            this.S39.TabIndex = 38;
            this.S39.UseVisualStyleBackColor = true;
            // 
            // S38
            // 
            this.S38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S38.AutoSize = true;
            this.S38.Location = new System.Drawing.Point(565, 188);
            this.S38.MinimumSize = new System.Drawing.Size(66, 35);
            this.S38.Name = "S38";
            this.S38.OffBackColor = System.Drawing.Color.LightGreen;
            this.S38.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S38.OnBackColor = System.Drawing.Color.Red;
            this.S38.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S38.Size = new System.Drawing.Size(66, 35);
            this.S38.TabIndex = 40;
            this.S38.UseVisualStyleBackColor = true;
            // 
            // S27
            // 
            this.S27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S27.AutoSize = true;
            this.S27.Location = new System.Drawing.Point(1025, 113);
            this.S27.MinimumSize = new System.Drawing.Size(66, 35);
            this.S27.Name = "S27";
            this.S27.OffBackColor = System.Drawing.Color.LightGreen;
            this.S27.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S27.OnBackColor = System.Drawing.Color.Red;
            this.S27.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S27.Size = new System.Drawing.Size(66, 35);
            this.S27.TabIndex = 26;
            this.S27.UseVisualStyleBackColor = true;
            // 
            // S37
            // 
            this.S37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S37.AutoSize = true;
            this.S37.Location = new System.Drawing.Point(473, 188);
            this.S37.MinimumSize = new System.Drawing.Size(66, 35);
            this.S37.Name = "S37";
            this.S37.OffBackColor = System.Drawing.Color.LightGreen;
            this.S37.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S37.OnBackColor = System.Drawing.Color.Red;
            this.S37.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S37.Size = new System.Drawing.Size(66, 35);
            this.S37.TabIndex = 44;
            this.S37.UseVisualStyleBackColor = true;
            // 
            // S36
            // 
            this.S36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S36.AutoSize = true;
            this.S36.Location = new System.Drawing.Point(381, 188);
            this.S36.MinimumSize = new System.Drawing.Size(66, 35);
            this.S36.Name = "S36";
            this.S36.OffBackColor = System.Drawing.Color.LightGreen;
            this.S36.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S36.OnBackColor = System.Drawing.Color.Red;
            this.S36.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S36.Size = new System.Drawing.Size(66, 35);
            this.S36.TabIndex = 47;
            this.S36.UseVisualStyleBackColor = true;
            // 
            // S26
            // 
            this.S26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S26.AutoSize = true;
            this.S26.Location = new System.Drawing.Point(933, 113);
            this.S26.MinimumSize = new System.Drawing.Size(66, 35);
            this.S26.Name = "S26";
            this.S26.OffBackColor = System.Drawing.Color.LightGreen;
            this.S26.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S26.OnBackColor = System.Drawing.Color.Red;
            this.S26.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S26.Size = new System.Drawing.Size(66, 35);
            this.S26.TabIndex = 21;
            this.S26.UseVisualStyleBackColor = true;
            // 
            // S35
            // 
            this.S35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S35.AutoSize = true;
            this.S35.Location = new System.Drawing.Point(289, 188);
            this.S35.MinimumSize = new System.Drawing.Size(66, 35);
            this.S35.Name = "S35";
            this.S35.OffBackColor = System.Drawing.Color.LightGreen;
            this.S35.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S35.OnBackColor = System.Drawing.Color.Red;
            this.S35.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S35.Size = new System.Drawing.Size(66, 35);
            this.S35.TabIndex = 46;
            this.S35.UseVisualStyleBackColor = true;
            // 
            // S34
            // 
            this.S34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S34.AutoSize = true;
            this.S34.Location = new System.Drawing.Point(197, 188);
            this.S34.MinimumSize = new System.Drawing.Size(66, 35);
            this.S34.Name = "S34";
            this.S34.OffBackColor = System.Drawing.Color.LightGreen;
            this.S34.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S34.OnBackColor = System.Drawing.Color.Red;
            this.S34.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S34.Size = new System.Drawing.Size(66, 35);
            this.S34.TabIndex = 48;
            this.S34.UseVisualStyleBackColor = true;
            // 
            // S25
            // 
            this.S25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S25.AutoSize = true;
            this.S25.Location = new System.Drawing.Point(841, 113);
            this.S25.MinimumSize = new System.Drawing.Size(66, 35);
            this.S25.Name = "S25";
            this.S25.OffBackColor = System.Drawing.Color.LightGreen;
            this.S25.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S25.OnBackColor = System.Drawing.Color.Red;
            this.S25.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S25.Size = new System.Drawing.Size(66, 35);
            this.S25.TabIndex = 25;
            this.S25.UseVisualStyleBackColor = true;
            // 
            // S33
            // 
            this.S33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S33.AutoSize = true;
            this.S33.Location = new System.Drawing.Point(105, 188);
            this.S33.MinimumSize = new System.Drawing.Size(66, 35);
            this.S33.Name = "S33";
            this.S33.OffBackColor = System.Drawing.Color.LightGreen;
            this.S33.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S33.OnBackColor = System.Drawing.Color.Red;
            this.S33.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S33.Size = new System.Drawing.Size(66, 35);
            this.S33.TabIndex = 49;
            this.S33.UseVisualStyleBackColor = true;
            // 
            // S24
            // 
            this.S24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S24.AutoSize = true;
            this.S24.Location = new System.Drawing.Point(749, 113);
            this.S24.MinimumSize = new System.Drawing.Size(66, 35);
            this.S24.Name = "S24";
            this.S24.OffBackColor = System.Drawing.Color.LightGreen;
            this.S24.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S24.OnBackColor = System.Drawing.Color.Red;
            this.S24.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S24.Size = new System.Drawing.Size(66, 35);
            this.S24.TabIndex = 23;
            this.S24.UseVisualStyleBackColor = true;
            // 
            // S23
            // 
            this.S23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S23.AutoSize = true;
            this.S23.Location = new System.Drawing.Point(657, 113);
            this.S23.MinimumSize = new System.Drawing.Size(66, 35);
            this.S23.Name = "S23";
            this.S23.OffBackColor = System.Drawing.Color.LightGreen;
            this.S23.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S23.OnBackColor = System.Drawing.Color.Red;
            this.S23.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S23.Size = new System.Drawing.Size(66, 35);
            this.S23.TabIndex = 22;
            this.S23.UseVisualStyleBackColor = true;
            // 
            // S22
            // 
            this.S22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S22.AutoSize = true;
            this.S22.Location = new System.Drawing.Point(565, 113);
            this.S22.MinimumSize = new System.Drawing.Size(66, 35);
            this.S22.Name = "S22";
            this.S22.OffBackColor = System.Drawing.Color.LightGreen;
            this.S22.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S22.OnBackColor = System.Drawing.Color.Red;
            this.S22.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S22.Size = new System.Drawing.Size(66, 35);
            this.S22.TabIndex = 24;
            this.S22.UseVisualStyleBackColor = true;
            // 
            // S21
            // 
            this.S21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S21.AutoSize = true;
            this.S21.Location = new System.Drawing.Point(473, 113);
            this.S21.MinimumSize = new System.Drawing.Size(66, 35);
            this.S21.Name = "S21";
            this.S21.OffBackColor = System.Drawing.Color.LightGreen;
            this.S21.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S21.OnBackColor = System.Drawing.Color.Red;
            this.S21.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S21.Size = new System.Drawing.Size(66, 35);
            this.S21.TabIndex = 28;
            this.S21.UseVisualStyleBackColor = true;
            // 
            // S20
            // 
            this.S20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S20.AutoSize = true;
            this.S20.Location = new System.Drawing.Point(381, 113);
            this.S20.MinimumSize = new System.Drawing.Size(66, 35);
            this.S20.Name = "S20";
            this.S20.OffBackColor = System.Drawing.Color.LightGreen;
            this.S20.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S20.OnBackColor = System.Drawing.Color.Red;
            this.S20.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S20.Size = new System.Drawing.Size(66, 35);
            this.S20.TabIndex = 31;
            this.S20.UseVisualStyleBackColor = true;
            // 
            // S19
            // 
            this.S19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S19.AutoSize = true;
            this.S19.Location = new System.Drawing.Point(289, 113);
            this.S19.MinimumSize = new System.Drawing.Size(66, 35);
            this.S19.Name = "S19";
            this.S19.OffBackColor = System.Drawing.Color.LightGreen;
            this.S19.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S19.OnBackColor = System.Drawing.Color.Red;
            this.S19.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S19.Size = new System.Drawing.Size(66, 35);
            this.S19.TabIndex = 30;
            this.S19.UseVisualStyleBackColor = true;
            // 
            // S18
            // 
            this.S18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S18.AutoSize = true;
            this.S18.Location = new System.Drawing.Point(197, 113);
            this.S18.MinimumSize = new System.Drawing.Size(66, 35);
            this.S18.Name = "S18";
            this.S18.OffBackColor = System.Drawing.Color.LightGreen;
            this.S18.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S18.OnBackColor = System.Drawing.Color.Red;
            this.S18.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S18.Size = new System.Drawing.Size(66, 35);
            this.S18.TabIndex = 32;
            this.S18.UseVisualStyleBackColor = true;
            // 
            // S17
            // 
            this.S17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S17.AutoSize = true;
            this.S17.Location = new System.Drawing.Point(105, 113);
            this.S17.MinimumSize = new System.Drawing.Size(66, 35);
            this.S17.Name = "S17";
            this.S17.OffBackColor = System.Drawing.Color.LightGreen;
            this.S17.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S17.OnBackColor = System.Drawing.Color.Red;
            this.S17.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S17.Size = new System.Drawing.Size(66, 35);
            this.S17.TabIndex = 33;
            this.S17.UseVisualStyleBackColor = true;
            // 
            // S15
            // 
            this.S15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S15.AutoSize = true;
            this.S15.Location = new System.Drawing.Point(1393, 38);
            this.S15.MinimumSize = new System.Drawing.Size(66, 35);
            this.S15.Name = "S15";
            this.S15.OffBackColor = System.Drawing.Color.LightGreen;
            this.S15.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S15.OnBackColor = System.Drawing.Color.Red;
            this.S15.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S15.Size = new System.Drawing.Size(66, 35);
            this.S15.TabIndex = 5;
            this.S15.UseVisualStyleBackColor = true;
            // 
            // S14
            // 
            this.S14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S14.AutoSize = true;
            this.S14.Location = new System.Drawing.Point(1301, 38);
            this.S14.MinimumSize = new System.Drawing.Size(66, 35);
            this.S14.Name = "S14";
            this.S14.OffBackColor = System.Drawing.Color.LightGreen;
            this.S14.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S14.OnBackColor = System.Drawing.Color.Red;
            this.S14.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S14.Size = new System.Drawing.Size(66, 35);
            this.S14.TabIndex = 10;
            this.S14.UseVisualStyleBackColor = true;
            // 
            // S8
            // 
            this.S8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S8.AutoSize = true;
            this.S8.Location = new System.Drawing.Point(749, 38);
            this.S8.MinimumSize = new System.Drawing.Size(66, 35);
            this.S8.Name = "S8";
            this.S8.OffBackColor = System.Drawing.Color.LightGreen;
            this.S8.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S8.OnBackColor = System.Drawing.Color.Red;
            this.S8.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S8.Size = new System.Drawing.Size(66, 35);
            this.S8.TabIndex = 5;
            this.S8.UseVisualStyleBackColor = true;
            // 
            // S13
            // 
            this.S13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S13.AutoSize = true;
            this.S13.Location = new System.Drawing.Point(1209, 38);
            this.S13.MinimumSize = new System.Drawing.Size(66, 35);
            this.S13.Name = "S13";
            this.S13.OffBackColor = System.Drawing.Color.LightGreen;
            this.S13.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S13.OnBackColor = System.Drawing.Color.Red;
            this.S13.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S13.Size = new System.Drawing.Size(66, 35);
            this.S13.TabIndex = 9;
            this.S13.UseVisualStyleBackColor = true;
            // 
            // S12
            // 
            this.S12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S12.AutoSize = true;
            this.S12.Location = new System.Drawing.Point(1117, 38);
            this.S12.MinimumSize = new System.Drawing.Size(66, 35);
            this.S12.Name = "S12";
            this.S12.OffBackColor = System.Drawing.Color.LightGreen;
            this.S12.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S12.OnBackColor = System.Drawing.Color.Red;
            this.S12.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S12.Size = new System.Drawing.Size(66, 35);
            this.S12.TabIndex = 8;
            this.S12.UseVisualStyleBackColor = true;
            // 
            // S1
            // 
            this.S1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S1.AutoSize = true;
            this.S1.Location = new System.Drawing.Point(105, 38);
            this.S1.MinimumSize = new System.Drawing.Size(66, 35);
            this.S1.Name = "S1";
            this.S1.OffBackColor = System.Drawing.Color.LightGreen;
            this.S1.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S1.OnBackColor = System.Drawing.Color.Red;
            this.S1.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S1.Size = new System.Drawing.Size(66, 35);
            this.S1.TabIndex = 5;
            this.S1.UseVisualStyleBackColor = true;
            // 
            // S11
            // 
            this.S11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S11.AutoSize = true;
            this.S11.Location = new System.Drawing.Point(1025, 38);
            this.S11.MinimumSize = new System.Drawing.Size(66, 35);
            this.S11.Name = "S11";
            this.S11.OffBackColor = System.Drawing.Color.LightGreen;
            this.S11.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S11.OnBackColor = System.Drawing.Color.Red;
            this.S11.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S11.Size = new System.Drawing.Size(66, 35);
            this.S11.TabIndex = 7;
            this.S11.UseVisualStyleBackColor = true;
            // 
            // S10
            // 
            this.S10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S10.AutoSize = true;
            this.S10.Location = new System.Drawing.Point(933, 38);
            this.S10.MinimumSize = new System.Drawing.Size(66, 35);
            this.S10.Name = "S10";
            this.S10.OffBackColor = System.Drawing.Color.LightGreen;
            this.S10.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S10.OnBackColor = System.Drawing.Color.Red;
            this.S10.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S10.Size = new System.Drawing.Size(66, 35);
            this.S10.TabIndex = 6;
            this.S10.UseVisualStyleBackColor = true;
            // 
            // S9
            // 
            this.S9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S9.AutoSize = true;
            this.S9.Location = new System.Drawing.Point(841, 38);
            this.S9.MinimumSize = new System.Drawing.Size(66, 35);
            this.S9.Name = "S9";
            this.S9.OffBackColor = System.Drawing.Color.LightGreen;
            this.S9.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S9.OnBackColor = System.Drawing.Color.Red;
            this.S9.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S9.Size = new System.Drawing.Size(66, 35);
            this.S9.TabIndex = 5;
            this.S9.UseVisualStyleBackColor = true;
            // 
            // S2
            // 
            this.S2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S2.AutoSize = true;
            this.S2.Location = new System.Drawing.Point(197, 38);
            this.S2.MinimumSize = new System.Drawing.Size(66, 35);
            this.S2.Name = "S2";
            this.S2.OffBackColor = System.Drawing.Color.LightGreen;
            this.S2.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S2.OnBackColor = System.Drawing.Color.Red;
            this.S2.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S2.Size = new System.Drawing.Size(66, 35);
            this.S2.TabIndex = 6;
            this.S2.UseVisualStyleBackColor = true;
            // 
            // S3
            // 
            this.S3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S3.AutoSize = true;
            this.S3.Location = new System.Drawing.Point(289, 38);
            this.S3.MinimumSize = new System.Drawing.Size(66, 35);
            this.S3.Name = "S3";
            this.S3.OffBackColor = System.Drawing.Color.LightGreen;
            this.S3.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S3.OnBackColor = System.Drawing.Color.Red;
            this.S3.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S3.Size = new System.Drawing.Size(66, 35);
            this.S3.TabIndex = 9;
            this.S3.UseVisualStyleBackColor = true;
            // 
            // S4
            // 
            this.S4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S4.AutoSize = true;
            this.S4.Location = new System.Drawing.Point(381, 38);
            this.S4.MinimumSize = new System.Drawing.Size(66, 35);
            this.S4.Name = "S4";
            this.S4.OffBackColor = System.Drawing.Color.LightGreen;
            this.S4.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S4.OnBackColor = System.Drawing.Color.Red;
            this.S4.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S4.Size = new System.Drawing.Size(66, 35);
            this.S4.TabIndex = 13;
            this.S4.UseVisualStyleBackColor = true;
            // 
            // S5
            // 
            this.S5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S5.AutoSize = true;
            this.S5.Location = new System.Drawing.Point(473, 38);
            this.S5.MinimumSize = new System.Drawing.Size(66, 35);
            this.S5.Name = "S5";
            this.S5.OffBackColor = System.Drawing.Color.LightGreen;
            this.S5.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S5.OnBackColor = System.Drawing.Color.Red;
            this.S5.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S5.Size = new System.Drawing.Size(66, 35);
            this.S5.TabIndex = 10;
            this.S5.UseVisualStyleBackColor = true;
            // 
            // S6
            // 
            this.S6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S6.AutoSize = true;
            this.S6.Location = new System.Drawing.Point(565, 38);
            this.S6.MinimumSize = new System.Drawing.Size(66, 35);
            this.S6.Name = "S6";
            this.S6.OffBackColor = System.Drawing.Color.LightGreen;
            this.S6.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S6.OnBackColor = System.Drawing.Color.Red;
            this.S6.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S6.Size = new System.Drawing.Size(66, 35);
            this.S6.TabIndex = 14;
            this.S6.UseVisualStyleBackColor = true;
            // 
            // S7
            // 
            this.S7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.S7.AutoSize = true;
            this.S7.Location = new System.Drawing.Point(657, 38);
            this.S7.MinimumSize = new System.Drawing.Size(66, 35);
            this.S7.Name = "S7";
            this.S7.OffBackColor = System.Drawing.Color.LightGreen;
            this.S7.OffToggleColor = System.Drawing.Color.DarkGreen;
            this.S7.OnBackColor = System.Drawing.Color.Red;
            this.S7.OnToggleColor = System.Drawing.Color.DarkRed;
            this.S7.Size = new System.Drawing.Size(66, 35);
            this.S7.TabIndex = 17;
            this.S7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1484, 903);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antenna Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox voltageComboBox;
        private System.Windows.Forms.Button setVoltageButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ModeRadioButton1;
        private System.Windows.Forms.RadioButton ModeRadioButton2;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJToggleButton S0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox V1;
        private System.Windows.Forms.ComboBox V2;
        private System.Windows.Forms.ComboBox V3;
        private System.Windows.Forms.ComboBox V4;
        private System.Windows.Forms.ComboBox V5;
        private System.Windows.Forms.ComboBox V6;
        private System.Windows.Forms.ComboBox V7;
        private System.Windows.Forms.ComboBox V8;
        private System.Windows.Forms.ComboBox V9;
        private System.Windows.Forms.ComboBox V10;
        private System.Windows.Forms.ComboBox V11;
        private System.Windows.Forms.ComboBox V12;
        private System.Windows.Forms.ComboBox V13;
        private System.Windows.Forms.ComboBox V14;
        private System.Windows.Forms.ComboBox V15;
        private System.Windows.Forms.ComboBox V16;
        private System.Windows.Forms.ComboBox V17;
        private System.Windows.Forms.ComboBox V18;
        private System.Windows.Forms.ComboBox V19;
        private System.Windows.Forms.ComboBox V20;
        private System.Windows.Forms.ComboBox V21;
        private System.Windows.Forms.ComboBox V22;
        private System.Windows.Forms.ComboBox V23;
        private System.Windows.Forms.ComboBox V24;
        private System.Windows.Forms.ComboBox V25;
        private System.Windows.Forms.ComboBox V26;
        private System.Windows.Forms.ComboBox V27;
        private System.Windows.Forms.ComboBox V28;
        private System.Windows.Forms.ComboBox V29;
        private System.Windows.Forms.ComboBox V30;
        private System.Windows.Forms.ComboBox V31;
        private System.Windows.Forms.ComboBox V32;
        private System.Windows.Forms.ComboBox V33;
        private System.Windows.Forms.ComboBox V34;
        private System.Windows.Forms.ComboBox V35;
        private System.Windows.Forms.ComboBox V36;
        private System.Windows.Forms.ComboBox V37;
        private System.Windows.Forms.ComboBox V38;
        private System.Windows.Forms.ComboBox V39;
        private System.Windows.Forms.ComboBox V40;
        private System.Windows.Forms.ComboBox V41;
        private System.Windows.Forms.ComboBox V42;
        private System.Windows.Forms.ComboBox V43;
        private System.Windows.Forms.ComboBox V44;
        private System.Windows.Forms.ComboBox V45;
        private System.Windows.Forms.ComboBox V46;
        private System.Windows.Forms.ComboBox V47;
        private System.Windows.Forms.ComboBox V48;
        private System.Windows.Forms.ComboBox V49;
        private System.Windows.Forms.ComboBox V50;
        private System.Windows.Forms.ComboBox V51;
        private System.Windows.Forms.ComboBox V52;
        private System.Windows.Forms.ComboBox V53;
        private System.Windows.Forms.ComboBox V54;
        private System.Windows.Forms.ComboBox V55;
        private System.Windows.Forms.ComboBox V56;
        private System.Windows.Forms.ComboBox V57;
        private System.Windows.Forms.ComboBox V58;
        private System.Windows.Forms.ComboBox V59;
        private System.Windows.Forms.ComboBox V60;
        private System.Windows.Forms.ComboBox V61;
        private System.Windows.Forms.ComboBox V62;
        private System.Windows.Forms.ComboBox V63;
        private System.Windows.Forms.ComboBox V64;
        private System.Windows.Forms.ComboBox V65;
        private System.Windows.Forms.ComboBox V66;
        private System.Windows.Forms.ComboBox V67;
        private System.Windows.Forms.ComboBox V68;
        private System.Windows.Forms.ComboBox V69;
        private System.Windows.Forms.ComboBox V70;
        private System.Windows.Forms.ComboBox V71;
        private System.Windows.Forms.ComboBox V72;
        private System.Windows.Forms.ComboBox V73;
        private System.Windows.Forms.ComboBox V74;
        private System.Windows.Forms.ComboBox V75;
        private System.Windows.Forms.ComboBox V76;
        private System.Windows.Forms.ComboBox V77;
        private System.Windows.Forms.ComboBox V78;
        private System.Windows.Forms.ComboBox V79;
        private System.Windows.Forms.ComboBox V80;
        private System.Windows.Forms.ComboBox V81;
        private System.Windows.Forms.ComboBox V82;
        private System.Windows.Forms.ComboBox V83;
        private System.Windows.Forms.ComboBox V84;
        private System.Windows.Forms.ComboBox V85;
        private System.Windows.Forms.ComboBox V86;
        private System.Windows.Forms.ComboBox V87;
        private System.Windows.Forms.ComboBox V88;
        private System.Windows.Forms.ComboBox V89;
        private System.Windows.Forms.ComboBox V90;
        private System.Windows.Forms.ComboBox V91;
        private System.Windows.Forms.ComboBox V92;
        private System.Windows.Forms.ComboBox V93;
        private System.Windows.Forms.ComboBox V94;
        private System.Windows.Forms.ComboBox V95;
        private System.Windows.Forms.ComboBox V96;
        private System.Windows.Forms.ComboBox V97;
        private System.Windows.Forms.ComboBox V98;
        private System.Windows.Forms.ComboBox V99;
        private System.Windows.Forms.ComboBox V100;
        private System.Windows.Forms.ComboBox V101;
        private System.Windows.Forms.ComboBox V102;
        private System.Windows.Forms.ComboBox V103;
        private System.Windows.Forms.ComboBox V104;
        private System.Windows.Forms.ComboBox V105;
        private System.Windows.Forms.ComboBox V106;
        private System.Windows.Forms.ComboBox V107;
        private System.Windows.Forms.ComboBox V108;
        private System.Windows.Forms.ComboBox V109;
        private System.Windows.Forms.ComboBox V110;
        private System.Windows.Forms.ComboBox V111;
        private System.Windows.Forms.ComboBox V112;
        private System.Windows.Forms.ComboBox V113;
        private System.Windows.Forms.ComboBox V114;
        private System.Windows.Forms.ComboBox V115;
        private System.Windows.Forms.ComboBox V116;
        private System.Windows.Forms.ComboBox V117;
        private System.Windows.Forms.ComboBox V118;
        private System.Windows.Forms.ComboBox V119;
        private System.Windows.Forms.ComboBox V120;
        private System.Windows.Forms.ComboBox V121;
        private System.Windows.Forms.ComboBox V122;
        private System.Windows.Forms.ComboBox V123;
        private System.Windows.Forms.ComboBox V124;
        private System.Windows.Forms.ComboBox V125;
        private System.Windows.Forms.ComboBox V126;
        private System.Windows.Forms.ComboBox V127;
        private System.Windows.Forms.ComboBox V128;
        private System.Windows.Forms.ComboBox V129;
        private System.Windows.Forms.ComboBox V130;
        private System.Windows.Forms.ComboBox V131;
        private System.Windows.Forms.ComboBox V132;
        private System.Windows.Forms.ComboBox V133;
        private System.Windows.Forms.ComboBox V134;
        private System.Windows.Forms.ComboBox V135;
        private System.Windows.Forms.ComboBox V136;
        private System.Windows.Forms.ComboBox V137;
        private System.Windows.Forms.ComboBox V138;
        private System.Windows.Forms.ComboBox V139;
        private System.Windows.Forms.ComboBox V140;
        private System.Windows.Forms.ComboBox V141;
        private System.Windows.Forms.ComboBox V142;
        private System.Windows.Forms.ComboBox V143;
        private System.Windows.Forms.ComboBox V144;
        private System.Windows.Forms.ComboBox V145;
        private System.Windows.Forms.ComboBox V146;
        private System.Windows.Forms.ComboBox V147;
        private System.Windows.Forms.ComboBox V148;
        private System.Windows.Forms.ComboBox V149;
        private System.Windows.Forms.ComboBox V150;
        private System.Windows.Forms.ComboBox V151;
        private System.Windows.Forms.ComboBox V152;
        private System.Windows.Forms.ComboBox V153;
        private System.Windows.Forms.ComboBox V154;
        private System.Windows.Forms.ComboBox V155;
        private System.Windows.Forms.ComboBox V156;
        private System.Windows.Forms.ComboBox V157;
        private System.Windows.Forms.ComboBox V158;
        private System.Windows.Forms.ComboBox V159;

        private CustomControls.RJControls.RJToggleButton S1;
        private CustomControls.RJControls.RJToggleButton S2;
        private CustomControls.RJControls.RJToggleButton S3;
        private CustomControls.RJControls.RJToggleButton S4;
        private CustomControls.RJControls.RJToggleButton S5;
        private CustomControls.RJControls.RJToggleButton S6;
        private CustomControls.RJControls.RJToggleButton S7;
        private CustomControls.RJControls.RJToggleButton S15;
        private CustomControls.RJControls.RJToggleButton S14;
        private CustomControls.RJControls.RJToggleButton S8;
        private CustomControls.RJControls.RJToggleButton S13;
        private CustomControls.RJControls.RJToggleButton S12;
        private CustomControls.RJControls.RJToggleButton S11;
        private CustomControls.RJControls.RJToggleButton S10;
        private CustomControls.RJControls.RJToggleButton S9;
        private CustomControls.RJControls.RJToggleButton S16;
        private CustomControls.RJControls.RJToggleButton S31;
        private CustomControls.RJControls.RJToggleButton S30;
        private CustomControls.RJControls.RJToggleButton S29;
        private CustomControls.RJControls.RJToggleButton S28;
        private CustomControls.RJControls.RJToggleButton S27;
        private CustomControls.RJControls.RJToggleButton S26;
        private CustomControls.RJControls.RJToggleButton S25;
        private CustomControls.RJControls.RJToggleButton S24;
        private CustomControls.RJControls.RJToggleButton S23;
        private CustomControls.RJControls.RJToggleButton S22;
        private CustomControls.RJControls.RJToggleButton S21;
        private CustomControls.RJControls.RJToggleButton S20;
        private CustomControls.RJControls.RJToggleButton S19;
        private CustomControls.RJControls.RJToggleButton S18;
        private CustomControls.RJControls.RJToggleButton S17;
        private CustomControls.RJControls.RJToggleButton S32;
        private CustomControls.RJControls.RJToggleButton S47;
        private CustomControls.RJControls.RJToggleButton S46;
        private CustomControls.RJControls.RJToggleButton S45;
        private CustomControls.RJControls.RJToggleButton S44;
        private CustomControls.RJControls.RJToggleButton S43;
        private CustomControls.RJControls.RJToggleButton S42;
        private CustomControls.RJControls.RJToggleButton S41;
        private CustomControls.RJControls.RJToggleButton S40;
        private CustomControls.RJControls.RJToggleButton S39;
        private CustomControls.RJControls.RJToggleButton S38;
        private CustomControls.RJControls.RJToggleButton S37;
        private CustomControls.RJControls.RJToggleButton S36;
        private CustomControls.RJControls.RJToggleButton S35;
        private CustomControls.RJControls.RJToggleButton S34;
        private CustomControls.RJControls.RJToggleButton S33;
        private CustomControls.RJControls.RJToggleButton S48;
        private CustomControls.RJControls.RJToggleButton S63;
        private CustomControls.RJControls.RJToggleButton S62;
        private CustomControls.RJControls.RJToggleButton S61;
        private CustomControls.RJControls.RJToggleButton S60;
        private CustomControls.RJControls.RJToggleButton S59;
        private CustomControls.RJControls.RJToggleButton S58;
        private CustomControls.RJControls.RJToggleButton S57;
        private CustomControls.RJControls.RJToggleButton S56;
        private CustomControls.RJControls.RJToggleButton S55;
        private CustomControls.RJControls.RJToggleButton S54;
        private CustomControls.RJControls.RJToggleButton S53;
        private CustomControls.RJControls.RJToggleButton S52;
        private CustomControls.RJControls.RJToggleButton S51;
        private CustomControls.RJControls.RJToggleButton S50;
        private CustomControls.RJControls.RJToggleButton S49;
        private CustomControls.RJControls.RJToggleButton S64;
        private CustomControls.RJControls.RJToggleButton S79;
        private CustomControls.RJControls.RJToggleButton S78;
        private CustomControls.RJControls.RJToggleButton S77;
        private CustomControls.RJControls.RJToggleButton S76;
        private CustomControls.RJControls.RJToggleButton S75;
        private CustomControls.RJControls.RJToggleButton S74;
        private CustomControls.RJControls.RJToggleButton S73;
        private CustomControls.RJControls.RJToggleButton S72;
        private CustomControls.RJControls.RJToggleButton S71;
        private CustomControls.RJControls.RJToggleButton S70;
        private CustomControls.RJControls.RJToggleButton S69;
        private CustomControls.RJControls.RJToggleButton S68;
        private CustomControls.RJControls.RJToggleButton S67;
        private CustomControls.RJControls.RJToggleButton S66;
        private CustomControls.RJControls.RJToggleButton S65;
        private CustomControls.RJControls.RJToggleButton S80;
        private CustomControls.RJControls.RJToggleButton S95;
        private CustomControls.RJControls.RJToggleButton S94;
        private CustomControls.RJControls.RJToggleButton S93;
        private CustomControls.RJControls.RJToggleButton S92;
        private CustomControls.RJControls.RJToggleButton S91;
        private CustomControls.RJControls.RJToggleButton S90;
        private CustomControls.RJControls.RJToggleButton S89;
        private CustomControls.RJControls.RJToggleButton S88;
        private CustomControls.RJControls.RJToggleButton S87;
        private CustomControls.RJControls.RJToggleButton S86;
        private CustomControls.RJControls.RJToggleButton S85;
        private CustomControls.RJControls.RJToggleButton S84;
        private CustomControls.RJControls.RJToggleButton S83;
        private CustomControls.RJControls.RJToggleButton S82;
        private CustomControls.RJControls.RJToggleButton S81;
        private CustomControls.RJControls.RJToggleButton S96;
        private CustomControls.RJControls.RJToggleButton S111;
        private CustomControls.RJControls.RJToggleButton S110;
        private CustomControls.RJControls.RJToggleButton S109;
        private CustomControls.RJControls.RJToggleButton S108;
        private CustomControls.RJControls.RJToggleButton S107;
        private CustomControls.RJControls.RJToggleButton S106;
        private CustomControls.RJControls.RJToggleButton S105;
        private CustomControls.RJControls.RJToggleButton S104;
        private CustomControls.RJControls.RJToggleButton S103;
        private CustomControls.RJControls.RJToggleButton S102;
        private CustomControls.RJControls.RJToggleButton S101;
        private CustomControls.RJControls.RJToggleButton S100;
        private CustomControls.RJControls.RJToggleButton S99;
        private CustomControls.RJControls.RJToggleButton S98;
        private CustomControls.RJControls.RJToggleButton S97;
        private CustomControls.RJControls.RJToggleButton S112;
        private CustomControls.RJControls.RJToggleButton S127;
        private CustomControls.RJControls.RJToggleButton S126;
        private CustomControls.RJControls.RJToggleButton S125;
        private CustomControls.RJControls.RJToggleButton S124;
        private CustomControls.RJControls.RJToggleButton S123;
        private CustomControls.RJControls.RJToggleButton S122;
        private CustomControls.RJControls.RJToggleButton S121;
        private CustomControls.RJControls.RJToggleButton S120;
        private CustomControls.RJControls.RJToggleButton S119;
        private CustomControls.RJControls.RJToggleButton S118;
        private CustomControls.RJControls.RJToggleButton S117;
        private CustomControls.RJControls.RJToggleButton S116;
        private CustomControls.RJControls.RJToggleButton S115;
        private CustomControls.RJControls.RJToggleButton S114;
        private CustomControls.RJControls.RJToggleButton S113;
        private CustomControls.RJControls.RJToggleButton S128;
        private CustomControls.RJControls.RJToggleButton S143;
        private CustomControls.RJControls.RJToggleButton S142;
        private CustomControls.RJControls.RJToggleButton S141;
        private CustomControls.RJControls.RJToggleButton S140;
        private CustomControls.RJControls.RJToggleButton S139;
        private CustomControls.RJControls.RJToggleButton S138;
        private CustomControls.RJControls.RJToggleButton S137;
        private CustomControls.RJControls.RJToggleButton S136;
        private CustomControls.RJControls.RJToggleButton S135;
        private CustomControls.RJControls.RJToggleButton S134;
        private CustomControls.RJControls.RJToggleButton S133;
        private CustomControls.RJControls.RJToggleButton S132;
        private CustomControls.RJControls.RJToggleButton S131;
        private CustomControls.RJControls.RJToggleButton S130;
        private CustomControls.RJControls.RJToggleButton S129;
        private CustomControls.RJControls.RJToggleButton S144;
        private CustomControls.RJControls.RJToggleButton S159;
        private CustomControls.RJControls.RJToggleButton S158;
        private CustomControls.RJControls.RJToggleButton S157;
        private CustomControls.RJControls.RJToggleButton S156;
        private CustomControls.RJControls.RJToggleButton S155;
        private CustomControls.RJControls.RJToggleButton S154;
        private CustomControls.RJControls.RJToggleButton S153;
        private CustomControls.RJControls.RJToggleButton S152;
        private CustomControls.RJControls.RJToggleButton S151;
        private CustomControls.RJControls.RJToggleButton S150;
        private CustomControls.RJControls.RJToggleButton S149;
        private CustomControls.RJControls.RJToggleButton S148;
        private CustomControls.RJControls.RJToggleButton S147;
        private CustomControls.RJControls.RJToggleButton S146;
        private CustomControls.RJControls.RJToggleButton S145;
        private System.Windows.Forms.ComboBox V0;
        private System.Windows.Forms.PictureBox deviceStatusPictureBox;
        private CustomControls.RJControls.RJToggleButton OnOffButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialButton LoadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

