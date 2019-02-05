namespace MDBoxProject
{
    partial class mainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaxPos = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkDefault = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowXAxis = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.trackXAxis = new System.Windows.Forms.TrackBar();
            this.numericXAxis = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackYAxis = new System.Windows.Forms.TrackBar();
            this.numericYAxis = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.trackZAxis = new System.Windows.Forms.TrackBar();
            this.numericZAxis = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.trackUAxis = new System.Windows.Forms.TrackBar();
            this.numericUAxis = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.trackVAxis = new System.Windows.Forms.TrackBar();
            this.numericVAxis = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.trackWAxis = new System.Windows.Forms.TrackBar();
            this.numericWAxis = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowContainer.SuspendLayout();
            this.flowXAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackXAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXAxis)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackYAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYAxis)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZAxis)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackUAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUAxis)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVAxis)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWAxis)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(346, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.TestButtonClick);
            // 
            // btnMaxPos
            // 
            this.btnMaxPos.Enabled = false;
            this.btnMaxPos.Location = new System.Drawing.Point(346, 103);
            this.btnMaxPos.Name = "btnMaxPos";
            this.btnMaxPos.Size = new System.Drawing.Size(75, 52);
            this.btnMaxPos.TabIndex = 1;
            this.btnMaxPos.Text = "Go To Max Position";
            this.btnMaxPos.UseVisualStyleBackColor = true;
            this.btnMaxPos.Click += new System.EventHandler(this.GoToMaxClick);
            // 
            // btnZero
            // 
            this.btnZero.Enabled = false;
            this.btnZero.Location = new System.Drawing.Point(346, 161);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 52);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "Go To Zero";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.GoToZeroClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Parameters";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.checkDefault);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(322, 66);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtIPAddress);
            this.flowLayoutPanel2.Controls.Add(this.btnConnect);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remotet:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIPAddress.Enabled = false;
            this.txtIPAddress.Location = new System.Drawing.Point(59, 4);
            this.txtIPAddress.Mask = "###.###.###.###";
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 2;
            this.txtIPAddress.Click += new System.EventHandler(this.IPSubnetGetFocus);
            this.txtIPAddress.Enter += new System.EventHandler(this.IPSubnetGetFocus);
            this.txtIPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPSubnetKeyPress);
            this.txtIPAddress.Validating += new System.ComponentModel.CancelEventHandler(this.IPSubNetValidating);
            this.txtIPAddress.Validated += new System.EventHandler(this.IPSubnetValidated);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(172, 3);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.ConnectClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(250, 0);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // checkDefault
            // 
            this.checkDefault.AutoSize = true;
            this.checkDefault.Checked = true;
            this.checkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDefault.Location = new System.Drawing.Point(3, 44);
            this.checkDefault.Name = "checkDefault";
            this.checkDefault.Size = new System.Drawing.Size(80, 17);
            this.checkDefault.TabIndex = 2;
            this.checkDefault.Text = "Use default";
            this.checkDefault.UseVisualStyleBackColor = true;
            this.checkDefault.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowContainer);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 276);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Axis Position";
            // 
            // flowContainer
            // 
            this.flowContainer.AutoSize = true;
            this.flowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowContainer.Controls.Add(this.flowXAxis);
            this.flowContainer.Controls.Add(this.flowLayoutPanel4);
            this.flowContainer.Controls.Add(this.flowLayoutPanel5);
            this.flowContainer.Controls.Add(this.flowLayoutPanel6);
            this.flowContainer.Controls.Add(this.flowLayoutPanel7);
            this.flowContainer.Controls.Add(this.flowLayoutPanel8);
            this.flowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContainer.Location = new System.Drawing.Point(3, 16);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(322, 257);
            this.flowContainer.TabIndex = 0;
            // 
            // flowXAxis
            // 
            this.flowXAxis.AutoSize = true;
            this.flowXAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowXAxis.Controls.Add(this.label2);
            this.flowXAxis.Controls.Add(this.trackXAxis);
            this.flowXAxis.Controls.Add(this.numericXAxis);
            this.flowXAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowXAxis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowXAxis.Location = new System.Drawing.Point(3, 3);
            this.flowXAxis.Name = "flowXAxis";
            this.flowXAxis.Size = new System.Drawing.Size(47, 251);
            this.flowXAxis.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackXAxis
            // 
            this.trackXAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackXAxis.Location = new System.Drawing.Point(3, 16);
            this.trackXAxis.Maximum = 100;
            this.trackXAxis.Name = "trackXAxis";
            this.trackXAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackXAxis.Size = new System.Drawing.Size(41, 206);
            this.trackXAxis.TabIndex = 10;
            this.trackXAxis.Tag = "0";
            this.trackXAxis.TickFrequency = 10;
            this.trackXAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericXAxis
            // 
            this.numericXAxis.AutoSize = true;
            this.numericXAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericXAxis.Location = new System.Drawing.Point(3, 228);
            this.numericXAxis.Name = "numericXAxis";
            this.numericXAxis.Size = new System.Drawing.Size(41, 20);
            this.numericXAxis.TabIndex = 11;
            this.numericXAxis.Tag = "0";
            this.numericXAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.trackYAxis);
            this.flowLayoutPanel4.Controls.Add(this.numericYAxis);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(56, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(47, 251);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackYAxis
            // 
            this.trackYAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackYAxis.Location = new System.Drawing.Point(3, 16);
            this.trackYAxis.Maximum = 100;
            this.trackYAxis.Name = "trackYAxis";
            this.trackYAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackYAxis.Size = new System.Drawing.Size(41, 206);
            this.trackYAxis.TabIndex = 12;
            this.trackYAxis.Tag = "1";
            this.trackYAxis.TickFrequency = 10;
            this.trackYAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericYAxis
            // 
            this.numericYAxis.AutoSize = true;
            this.numericYAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericYAxis.Location = new System.Drawing.Point(3, 228);
            this.numericYAxis.Name = "numericYAxis";
            this.numericYAxis.Size = new System.Drawing.Size(41, 20);
            this.numericYAxis.TabIndex = 13;
            this.numericYAxis.Tag = "1";
            this.numericYAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.label4);
            this.flowLayoutPanel5.Controls.Add(this.trackZAxis);
            this.flowLayoutPanel5.Controls.Add(this.numericZAxis);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(109, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(47, 251);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackZAxis
            // 
            this.trackZAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackZAxis.Location = new System.Drawing.Point(3, 16);
            this.trackZAxis.Maximum = 100;
            this.trackZAxis.Name = "trackZAxis";
            this.trackZAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackZAxis.Size = new System.Drawing.Size(41, 206);
            this.trackZAxis.TabIndex = 14;
            this.trackZAxis.Tag = "2";
            this.trackZAxis.TickFrequency = 10;
            this.trackZAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericZAxis
            // 
            this.numericZAxis.AutoSize = true;
            this.numericZAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericZAxis.Location = new System.Drawing.Point(3, 228);
            this.numericZAxis.Name = "numericZAxis";
            this.numericZAxis.Size = new System.Drawing.Size(41, 20);
            this.numericZAxis.TabIndex = 15;
            this.numericZAxis.Tag = "2";
            this.numericZAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.trackUAxis);
            this.flowLayoutPanel6.Controls.Add(this.numericUAxis);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(162, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(47, 251);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "U";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackUAxis
            // 
            this.trackUAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackUAxis.Location = new System.Drawing.Point(3, 16);
            this.trackUAxis.Maximum = 100;
            this.trackUAxis.Name = "trackUAxis";
            this.trackUAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackUAxis.Size = new System.Drawing.Size(41, 206);
            this.trackUAxis.TabIndex = 16;
            this.trackUAxis.Tag = "3";
            this.trackUAxis.TickFrequency = 10;
            this.trackUAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericUAxis
            // 
            this.numericUAxis.AutoSize = true;
            this.numericUAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUAxis.Location = new System.Drawing.Point(3, 228);
            this.numericUAxis.Name = "numericUAxis";
            this.numericUAxis.Size = new System.Drawing.Size(41, 20);
            this.numericUAxis.TabIndex = 17;
            this.numericUAxis.Tag = "3";
            this.numericUAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.label6);
            this.flowLayoutPanel7.Controls.Add(this.trackVAxis);
            this.flowLayoutPanel7.Controls.Add(this.numericVAxis);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(215, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(47, 251);
            this.flowLayoutPanel7.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "V";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackVAxis
            // 
            this.trackVAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackVAxis.Location = new System.Drawing.Point(3, 16);
            this.trackVAxis.Maximum = 100;
            this.trackVAxis.Name = "trackVAxis";
            this.trackVAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVAxis.Size = new System.Drawing.Size(41, 206);
            this.trackVAxis.TabIndex = 18;
            this.trackVAxis.Tag = "4";
            this.trackVAxis.TickFrequency = 10;
            this.trackVAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericVAxis
            // 
            this.numericVAxis.AutoSize = true;
            this.numericVAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericVAxis.Location = new System.Drawing.Point(3, 228);
            this.numericVAxis.Name = "numericVAxis";
            this.numericVAxis.Size = new System.Drawing.Size(41, 20);
            this.numericVAxis.TabIndex = 19;
            this.numericVAxis.Tag = "4";
            this.numericVAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.label7);
            this.flowLayoutPanel8.Controls.Add(this.trackWAxis);
            this.flowLayoutPanel8.Controls.Add(this.numericWAxis);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(268, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(47, 251);
            this.flowLayoutPanel8.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "W";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackWAxis
            // 
            this.trackWAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackWAxis.Location = new System.Drawing.Point(3, 16);
            this.trackWAxis.Maximum = 100;
            this.trackWAxis.Name = "trackWAxis";
            this.trackWAxis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackWAxis.Size = new System.Drawing.Size(41, 206);
            this.trackWAxis.TabIndex = 20;
            this.trackWAxis.Tag = "5";
            this.trackWAxis.TickFrequency = 10;
            this.trackWAxis.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // numericWAxis
            // 
            this.numericWAxis.AutoSize = true;
            this.numericWAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericWAxis.Location = new System.Drawing.Point(3, 228);
            this.numericWAxis.Name = "numericWAxis";
            this.numericWAxis.Size = new System.Drawing.Size(41, 20);
            this.numericWAxis.TabIndex = 21;
            this.numericWAxis.Tag = "5";
            this.numericWAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(346, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 52);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(346, 219);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 52);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 388);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMaxPos);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "MDBox Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowContainer.ResumeLayout(false);
            this.flowContainer.PerformLayout();
            this.flowXAxis.ResumeLayout(false);
            this.flowXAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackXAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXAxis)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackYAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYAxis)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZAxis)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackUAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUAxis)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVAxis)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWAxis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaxPos;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkDefault;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.FlowLayoutPanel flowXAxis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackXAxis;
        private System.Windows.Forms.NumericUpDown numericXAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackYAxis;
        private System.Windows.Forms.NumericUpDown numericYAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackZAxis;
        private System.Windows.Forms.NumericUpDown numericZAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackUAxis;
        private System.Windows.Forms.NumericUpDown numericUAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackVAxis;
        private System.Windows.Forms.NumericUpDown numericVAxis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackWAxis;
        private System.Windows.Forms.NumericUpDown numericWAxis;
    }
}

