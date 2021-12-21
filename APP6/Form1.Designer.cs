namespace APP6
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
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.tctrlApp = new MaterialSkin.Controls.MaterialTabControl();
            this.tabSubscrise = new System.Windows.Forms.TabPage();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnUnsubscrise = new MaterialSkin.Controls.MaterialButton();
            this.lblWelcome2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblWelcome1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSubscrise = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.swMode = new MaterialSkin.Controls.MaterialSwitch();
            this.fbtnControl = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.sliSpeed = new MaterialSkin.Controls.MaterialSlider();
            this.swLamp2 = new MaterialSkin.Controls.MaterialSwitch();
            this.swFan = new MaterialSkin.Controls.MaterialSwitch();
            this.swLamp1 = new MaterialSkin.Controls.MaterialSwitch();
            this.fbtnGas = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblGasStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblGas = new MaterialSkin.Controls.MaterialLabel();
            this.fbtnHum = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblHum = new MaterialSkin.Controls.MaterialLabel();
            this.fbtnTemp = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.crdTemp = new MaterialSkin.Controls.MaterialCard();
            this.lblHeat = new MaterialSkin.Controls.MaterialLabel();
            this.tctrlApp.SuspendLayout();
            this.tabSubscrise.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.crdTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "home.png");
            this.imgIcon.Images.SetKeyName(1, "server.png");
            this.imgIcon.Images.SetKeyName(2, "eye.png");
            this.imgIcon.Images.SetKeyName(3, "heat.png");
            this.imgIcon.Images.SetKeyName(4, "gas.png");
            this.imgIcon.Images.SetKeyName(5, "humidity.png");
            // 
            // tctrlApp
            // 
            this.tctrlApp.Controls.Add(this.tabSubscrise);
            this.tctrlApp.Controls.Add(this.tabMain);
            this.tctrlApp.Depth = 0;
            this.tctrlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlApp.ImageList = this.imgIcon;
            this.tctrlApp.Location = new System.Drawing.Point(3, 64);
            this.tctrlApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tctrlApp.Multiline = true;
            this.tctrlApp.Name = "tctrlApp";
            this.tctrlApp.SelectedIndex = 0;
            this.tctrlApp.Size = new System.Drawing.Size(749, 383);
            this.tctrlApp.TabIndex = 0;
            // 
            // tabSubscrise
            // 
            this.tabSubscrise.Controls.Add(this.lblEmpty);
            this.tabSubscrise.Controls.Add(this.lblMessage);
            this.tabSubscrise.Controls.Add(this.btnUnsubscrise);
            this.tabSubscrise.Controls.Add(this.lblWelcome2);
            this.tabSubscrise.Controls.Add(this.lblWelcome1);
            this.tabSubscrise.Controls.Add(this.btnSubscrise);
            this.tabSubscrise.Controls.Add(this.txtPassword);
            this.tabSubscrise.Controls.Add(this.txtUsername);
            this.tabSubscrise.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabSubscrise.ImageKey = "server.png";
            this.tabSubscrise.Location = new System.Drawing.Point(4, 31);
            this.tabSubscrise.Name = "tabSubscrise";
            this.tabSubscrise.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubscrise.Size = new System.Drawing.Size(741, 348);
            this.tabSubscrise.TabIndex = 0;
            this.tabSubscrise.Text = "Subscrise";
            this.tabSubscrise.ToolTipText = "Subscrise";
            this.tabSubscrise.UseVisualStyleBackColor = true;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEmpty.Location = new System.Drawing.Point(221, 292);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(255, 20);
            this.lblEmpty.TabIndex = 8;
            this.lblEmpty.Text = "Username or Password is Empty";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.Location = new System.Drawing.Point(492, 23);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1, 0);
            this.lblMessage.TabIndex = 7;
            // 
            // btnUnsubscrise
            // 
            this.btnUnsubscrise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnsubscrise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUnsubscrise.Depth = 0;
            this.btnUnsubscrise.HighEmphasis = true;
            this.btnUnsubscrise.Icon = null;
            this.btnUnsubscrise.Location = new System.Drawing.Point(313, 250);
            this.btnUnsubscrise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUnsubscrise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUnsubscrise.Name = "btnUnsubscrise";
            this.btnUnsubscrise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUnsubscrise.Size = new System.Drawing.Size(118, 36);
            this.btnUnsubscrise.TabIndex = 6;
            this.btnUnsubscrise.Text = "UNSUBSCRISE";
            this.btnUnsubscrise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUnsubscrise.UseAccentColor = false;
            this.btnUnsubscrise.UseVisualStyleBackColor = true;
            this.btnUnsubscrise.Click += new System.EventHandler(this.btnUnsubscrise_Click);
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.Depth = 0;
            this.lblWelcome2.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome2.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblWelcome2.Location = new System.Drawing.Point(256, 170);
            this.lblWelcome2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(220, 72);
            this.lblWelcome2.TabIndex = 5;
            this.lblWelcome2.Text = "IOT APP";
            this.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.Depth = 0;
            this.lblWelcome1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblWelcome1.Location = new System.Drawing.Point(139, 95);
            this.lblWelcome1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(471, 72);
            this.lblWelcome1.TabIndex = 4;
            this.lblWelcome1.Text = "WELCOME HOME";
            this.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubscrise
            // 
            this.btnSubscrise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubscrise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubscrise.Depth = 0;
            this.btnSubscrise.HighEmphasis = true;
            this.btnSubscrise.Icon = null;
            this.btnSubscrise.Location = new System.Drawing.Point(281, 215);
            this.btnSubscrise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubscrise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubscrise.Name = "btnSubscrise";
            this.btnSubscrise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubscrise.Size = new System.Drawing.Size(98, 36);
            this.btnSubscrise.TabIndex = 3;
            this.btnSubscrise.Text = "SUBSCRISE";
            this.btnSubscrise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubscrise.UseAccentColor = false;
            this.btnSubscrise.UseVisualStyleBackColor = true;
            this.btnSubscrise.Click += new System.EventHandler(this.btnSubscrise_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = false;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HidePromptOnLeave = false;
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "PASSWORD";
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(151, 119);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(385, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = global::APP6.Properties.Resources.eye;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.ValidatingType = null;
            this.txtPassword.TrailingIconClick += new System.EventHandler(this.txtPassword_TrailingIconClick);
            // 
            // txtUsername
            // 
            this.txtUsername.AllowPromptAsInput = true;
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.AsciiOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.BeepOnError = false;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.HidePromptOnLeave = false;
            this.txtUsername.HideSelection = true;
            this.txtUsername.Hint = "USERNAME";
            this.txtUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(151, 44);
            this.txtUsername.Mask = "";
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.PromptChar = '_';
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RejectInputOnFirstFailure = false;
            this.txtUsername.ResetOnPrompt = true;
            this.txtUsername.ResetOnSpace = true;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(385, 48);
            this.txtUsername.SkipLiterals = true;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.ValidatingType = null;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.swMode);
            this.tabMain.Controls.Add(this.fbtnControl);
            this.tabMain.Controls.Add(this.materialCard3);
            this.tabMain.Controls.Add(this.fbtnGas);
            this.tabMain.Controls.Add(this.materialCard2);
            this.tabMain.Controls.Add(this.fbtnHum);
            this.tabMain.Controls.Add(this.materialCard1);
            this.tabMain.Controls.Add(this.fbtnTemp);
            this.tabMain.Controls.Add(this.crdTemp);
            this.tabMain.ImageKey = "home.png";
            this.tabMain.Location = new System.Drawing.Point(4, 31);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(741, 348);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Main";
            this.tabMain.ToolTipText = "Main App";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // swMode
            // 
            this.swMode.AutoSize = true;
            this.swMode.BackColor = System.Drawing.Color.RoyalBlue;
            this.swMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swMode.Checked = true;
            this.swMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.swMode.Depth = 0;
            this.swMode.Location = new System.Drawing.Point(569, 8);
            this.swMode.Margin = new System.Windows.Forms.Padding(0);
            this.swMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.swMode.Name = "swMode";
            this.swMode.Ripple = true;
            this.swMode.Size = new System.Drawing.Size(99, 37);
            this.swMode.TabIndex = 8;
            this.swMode.Text = "DARK";
            this.swMode.UseVisualStyleBackColor = false;
            this.swMode.CheckedChanged += new System.EventHandler(this.swMode_CheckedChanged);
            // 
            // fbtnControl
            // 
            this.fbtnControl.Depth = 0;
            this.fbtnControl.Icon = global::APP6.Properties.Resources.tablet;
            this.fbtnControl.ImageKey = "heat.png";
            this.fbtnControl.ImageList = this.imgIcon;
            this.fbtnControl.Location = new System.Drawing.Point(472, 35);
            this.fbtnControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnControl.Name = "fbtnControl";
            this.fbtnControl.Size = new System.Drawing.Size(56, 56);
            this.fbtnControl.TabIndex = 7;
            this.fbtnControl.Text = "materialFloatingActionButton1";
            this.fbtnControl.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialFloatingActionButton3);
            this.materialCard3.Controls.Add(this.materialFloatingActionButton2);
            this.materialCard3.Controls.Add(this.materialFloatingActionButton1);
            this.materialCard3.Controls.Add(this.sliSpeed);
            this.materialCard3.Controls.Add(this.swLamp2);
            this.materialCard3.Controls.Add(this.swFan);
            this.materialCard3.Controls.Add(this.swLamp1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(334, 68);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(334, 246);
            this.materialCard3.TabIndex = 6;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = global::APP6.Properties.Resources.idea;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(26, 90);
            this.materialFloatingActionButton3.Mini = true;
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton3.TabIndex = 6;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = global::APP6.Properties.Resources.fan;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(26, 147);
            this.materialFloatingActionButton2.Mini = true;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton2.TabIndex = 5;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::APP6.Properties.Resources.lamp1;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(26, 35);
            this.materialFloatingActionButton1.Mini = true;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton1.TabIndex = 4;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // sliSpeed
            // 
            this.sliSpeed.Depth = 0;
            this.sliSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliSpeed.Location = new System.Drawing.Point(23, 189);
            this.sliSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliSpeed.Name = "sliSpeed";
            this.sliSpeed.RangeMax = 255;
            this.sliSpeed.Size = new System.Drawing.Size(294, 40);
            this.sliSpeed.TabIndex = 3;
            this.sliSpeed.Text = "Speed";
            this.sliSpeed.Value = 0;
            this.sliSpeed.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliSpeed_onValueChanged);
            // 
            // swLamp2
            // 
            this.swLamp2.AutoSize = true;
            this.swLamp2.Depth = 0;
            this.swLamp2.Location = new System.Drawing.Point(83, 91);
            this.swLamp2.Margin = new System.Windows.Forms.Padding(0);
            this.swLamp2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swLamp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.swLamp2.Name = "swLamp2";
            this.swLamp2.Ripple = true;
            this.swLamp2.Size = new System.Drawing.Size(87, 37);
            this.swLamp2.TabIndex = 2;
            this.swLamp2.Text = "OFF";
            this.swLamp2.UseVisualStyleBackColor = true;
            this.swLamp2.CheckedChanged += new System.EventHandler(this.swLamp2_CheckedChanged);
            // 
            // swFan
            // 
            this.swFan.AutoSize = true;
            this.swFan.Depth = 0;
            this.swFan.Location = new System.Drawing.Point(83, 151);
            this.swFan.Margin = new System.Windows.Forms.Padding(0);
            this.swFan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swFan.MouseState = MaterialSkin.MouseState.HOVER;
            this.swFan.Name = "swFan";
            this.swFan.Ripple = true;
            this.swFan.Size = new System.Drawing.Size(87, 37);
            this.swFan.TabIndex = 1;
            this.swFan.Text = "OFF";
            this.swFan.UseVisualStyleBackColor = true;
            this.swFan.CheckedChanged += new System.EventHandler(this.swFan_CheckedChanged);
            // 
            // swLamp1
            // 
            this.swLamp1.AutoSize = true;
            this.swLamp1.Depth = 0;
            this.swLamp1.Location = new System.Drawing.Point(83, 36);
            this.swLamp1.Margin = new System.Windows.Forms.Padding(0);
            this.swLamp1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swLamp1.MouseState = MaterialSkin.MouseState.HOVER;
            this.swLamp1.Name = "swLamp1";
            this.swLamp1.Ripple = true;
            this.swLamp1.Size = new System.Drawing.Size(87, 37);
            this.swLamp1.TabIndex = 0;
            this.swLamp1.Text = "OFF";
            this.swLamp1.UseVisualStyleBackColor = true;
            this.swLamp1.CheckedChanged += new System.EventHandler(this.swLamp1_CheckedChanged);
            // 
            // fbtnGas
            // 
            this.fbtnGas.Depth = 0;
            this.fbtnGas.Icon = global::APP6.Properties.Resources.gas;
            this.fbtnGas.ImageKey = "heat.png";
            this.fbtnGas.ImageList = this.imgIcon;
            this.fbtnGas.Location = new System.Drawing.Point(206, 244);
            this.fbtnGas.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnGas.Name = "fbtnGas";
            this.fbtnGas.Size = new System.Drawing.Size(56, 56);
            this.fbtnGas.TabIndex = 5;
            this.fbtnGas.Text = "materialFloatingActionButton1";
            this.fbtnGas.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblGasStatus);
            this.materialCard2.Controls.Add(this.lblGas);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(16, 233);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(218, 81);
            this.materialCard2.TabIndex = 4;
            // 
            // lblGasStatus
            // 
            this.lblGasStatus.AutoSize = true;
            this.lblGasStatus.Depth = 0;
            this.lblGasStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGasStatus.Location = new System.Drawing.Point(17, 14);
            this.lblGasStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGasStatus.Name = "lblGasStatus";
            this.lblGasStatus.Size = new System.Drawing.Size(123, 19);
            this.lblGasStatus.TabIndex = 3;
            this.lblGasStatus.Text = "Không có khí gas";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Depth = 0;
            this.lblGas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGas.Location = new System.Drawing.Point(17, 48);
            this.lblGas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(10, 19);
            this.lblGas.TabIndex = 2;
            this.lblGas.Text = "0";
            // 
            // fbtnHum
            // 
            this.fbtnHum.Depth = 0;
            this.fbtnHum.Icon = global::APP6.Properties.Resources.humidity;
            this.fbtnHum.ImageKey = "heat.png";
            this.fbtnHum.ImageList = this.imgIcon;
            this.fbtnHum.Location = new System.Drawing.Point(206, 140);
            this.fbtnHum.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnHum.Name = "fbtnHum";
            this.fbtnHum.Size = new System.Drawing.Size(56, 56);
            this.fbtnHum.TabIndex = 3;
            this.fbtnHum.Text = "materialFloatingActionButton1";
            this.fbtnHum.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblHum);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 129);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(218, 81);
            this.materialCard1.TabIndex = 2;
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Depth = 0;
            this.lblHum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHum.Location = new System.Drawing.Point(17, 31);
            this.lblHum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(22, 19);
            this.lblHum.TabIndex = 1;
            this.lblHum.Text = "0%";
            // 
            // fbtnTemp
            // 
            this.fbtnTemp.Depth = 0;
            this.fbtnTemp.Icon = global::APP6.Properties.Resources.heat;
            this.fbtnTemp.ImageKey = "heat.png";
            this.fbtnTemp.ImageList = this.imgIcon;
            this.fbtnTemp.Location = new System.Drawing.Point(206, 35);
            this.fbtnTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnTemp.Name = "fbtnTemp";
            this.fbtnTemp.Size = new System.Drawing.Size(56, 56);
            this.fbtnTemp.TabIndex = 1;
            this.fbtnTemp.Text = "materialFloatingActionButton1";
            this.fbtnTemp.UseVisualStyleBackColor = true;
            // 
            // crdTemp
            // 
            this.crdTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crdTemp.Controls.Add(this.lblHeat);
            this.crdTemp.Depth = 0;
            this.crdTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crdTemp.Location = new System.Drawing.Point(16, 24);
            this.crdTemp.Margin = new System.Windows.Forms.Padding(14);
            this.crdTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.crdTemp.Name = "crdTemp";
            this.crdTemp.Padding = new System.Windows.Forms.Padding(14);
            this.crdTemp.Size = new System.Drawing.Size(218, 81);
            this.crdTemp.TabIndex = 0;
            // 
            // lblHeat
            // 
            this.lblHeat.AutoSize = true;
            this.lblHeat.Depth = 0;
            this.lblHeat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeat.Location = new System.Drawing.Point(17, 31);
            this.lblHeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeat.Name = "lblHeat";
            this.lblHeat.Size = new System.Drawing.Size(26, 19);
            this.lblHeat.TabIndex = 0;
            this.lblHeat.Text = "0°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.tctrlApp);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tctrlApp;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOT APP";
            this.tctrlApp.ResumeLayout(false);
            this.tabSubscrise.ResumeLayout(false);
            this.tabSubscrise.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.crdTemp.ResumeLayout(false);
            this.crdTemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgIcon;
        private MaterialSkin.Controls.MaterialTabControl tctrlApp;
        private System.Windows.Forms.TabPage tabSubscrise;
        private System.Windows.Forms.TabPage tabMain;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private MaterialSkin.Controls.MaterialButton btnSubscrise;
        private MaterialSkin.Controls.MaterialLabel lblWelcome1;
        private MaterialSkin.Controls.MaterialLabel lblWelcome2;
        private MaterialSkin.Controls.MaterialButton btnUnsubscrise;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialFloatingActionButton fbtnTemp;
        private MaterialSkin.Controls.MaterialCard crdTemp;
        private MaterialSkin.Controls.MaterialFloatingActionButton fbtnGas;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialFloatingActionButton fbtnHum;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblGas;
        private MaterialSkin.Controls.MaterialLabel lblHum;
        private MaterialSkin.Controls.MaterialLabel lblHeat;
        private MaterialSkin.Controls.MaterialFloatingActionButton fbtnControl;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblGasStatus;
        private MaterialSkin.Controls.MaterialSlider sliSpeed;
        private MaterialSkin.Controls.MaterialSwitch swLamp2;
        private MaterialSkin.Controls.MaterialSwitch swFan;
        private MaterialSkin.Controls.MaterialSwitch swLamp1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialSwitch swMode;
        private System.Windows.Forms.Label lblEmpty;
    }
}

