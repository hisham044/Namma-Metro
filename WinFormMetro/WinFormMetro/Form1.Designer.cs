namespace WinFormMetro
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDestination = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboBoarding = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listRoute = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.txtStops = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSwitch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cboDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoarding)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to \r\nNamma Metro ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Boarding Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(32, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Destination Station";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboDestination
            // 
            this.cboDestination.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.cboDestination.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cboDestination.DropDownWidth = 182;
            this.cboDestination.Items.AddRange(new object[] {
            "Baiyappanahalli",
            "Swami Vivekananda Road",
            "Indiranagar",
            "Halasuru",
            "Trinity",
            "MG Road",
            "Cubbon Park",
            "Vidhan Soudha",
            "Sir Viswesaraya Station - Central College",
            "Majestic Station",
            "KSR Railway Station",
            "Magadi Road",
            "Hosahalli",
            "Vijayanagar",
            "Attiguppe",
            "Gitanjali Nagar",
            "Mysore Road",
            "Nayadanahalli",
            "Rajarajeshwari",
            "Jnanabharathi",
            "Pattanagere",
            "Kengeri Bus Terminal",
            "Kengeri",
            "",
            "Nagasandra",
            "Dasarahalli",
            "Jalahalli",
            "Peenya Industry",
            "Peenya",
            "Goraguntepalya",
            "Yeshwantpur",
            "Sandal Soap Factory",
            "Mahalakhsmi",
            "Rajajinagar",
            "Mahakavi Kuvempu Road",
            "Srirampura",
            "Mantri Square - Sampige Road",
            "Majestic",
            "Chikpete",
            "Krishna Rajendra Nagar",
            "National College",
            "Lalbagh",
            "South End Circle",
            "Jayanagar",
            "Rashtreeya Vidyalaya Road",
            "Banashankari",
            "Jaya Prakash Nagar",
            "Yelachenahalli",
            "Konanakunte Cross",
            "Doddakallasandra",
            "Vajrahalli",
            "Thalaghattapura",
            "Silk Institute"});
            this.cboDestination.Location = new System.Drawing.Point(37, 270);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(300, 37);
            this.cboDestination.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboDestination.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboDestination.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboDestination.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboDestination.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboDestination.StateCommon.ComboBox.Border.Rounding = 20;
            this.cboDestination.StateCommon.ComboBox.Border.Width = 1;
            this.cboDestination.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cboDestination.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cboDestination.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.cboDestination.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.cboDestination.TabIndex = 5;
            this.cboDestination.Text = "--Select From--";
            // 
            // cboBoarding
            // 
            this.cboBoarding.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.cboBoarding.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cboBoarding.DropDownWidth = 182;
            this.cboBoarding.Items.AddRange(new object[] {
            "Baiyappanahalli",
            "Swami Vivekananda Road",
            "Indiranagar",
            "Halasuru",
            "Trinity",
            "MG Road",
            "Cubbon Park",
            "Vidhan Soudha",
            "Sir Viswesaraya Station - Central College",
            "Majestic Station",
            "KSR Railway Station",
            "Magadi Road",
            "Hosahalli",
            "Vijayanagar",
            "Attiguppe",
            "Gitanjali Nagar",
            "Mysore Road",
            "Nayadanahalli",
            "Rajarajeshwari",
            "Jnanabharathi",
            "Pattanagere",
            "Kengeri Bus Terminal",
            "Kengeri",
            "",
            "Nagasandra",
            "Dasarahalli",
            "Jalahalli",
            "Peenya Industry",
            "Peenya",
            "Goraguntepalya",
            "Yeshwantpur",
            "Sandal Soap Factory",
            "Mahalakhsmi",
            "Rajajinagar",
            "Mahakavi Kuvempu Road",
            "Srirampura",
            "Mantri Square - Sampige Road",
            "Majestic",
            "Chikpete",
            "Krishna Rajendra Nagar",
            "National College",
            "Lalbagh",
            "South End Circle",
            "Jayanagar",
            "Rashtreeya Vidyalaya Road",
            "Banashankari",
            "Jaya Prakash Nagar",
            "Yelachenahalli",
            "Konanakunte Cross",
            "Doddakallasandra",
            "Vajrahalli",
            "Thalaghattapura",
            "Silk Institute"});
            this.cboBoarding.Location = new System.Drawing.Point(37, 185);
            this.cboBoarding.Name = "cboBoarding";
            this.cboBoarding.Size = new System.Drawing.Size(300, 37);
            this.cboBoarding.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboBoarding.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboBoarding.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboBoarding.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBoarding.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboBoarding.StateCommon.ComboBox.Border.Rounding = 20;
            this.cboBoarding.StateCommon.ComboBox.Border.Width = 1;
            this.cboBoarding.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.cboBoarding.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoarding.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cboBoarding.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.cboBoarding.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.cboBoarding.TabIndex = 6;
            this.cboBoarding.Text = "--Select From--";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(37, 342);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(128, 42);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 20;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 20;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Text = "Submit";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // listRoute
            // 
            this.listRoute.Location = new System.Drawing.Point(470, 73);
            this.listRoute.Name = "listRoute";
            this.listRoute.Size = new System.Drawing.Size(270, 246);
            this.listRoute.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listRoute.StateCommon.Border.Rounding = 20;
            this.listRoute.StateCommon.Border.Width = 1;
            this.listRoute.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoute.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listRoute.StateNormal.Border.Rounding = 20;
            this.listRoute.StateNormal.Border.Width = 1;
            this.listRoute.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoute.TabIndex = 8;
            // 
            // txtStops
            // 
            this.txtStops.Location = new System.Drawing.Point(470, 340);
            this.txtStops.Name = "txtStops";
            this.txtStops.Size = new System.Drawing.Size(132, 40);
            this.txtStops.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtStops.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStops.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStops.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStops.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtStops.StateCommon.Border.Rounding = 20;
            this.txtStops.StateCommon.Border.Width = 1;
            this.txtStops.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStops.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStops.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtStops.TabIndex = 9;
            this.txtStops.Text = "Total Stops";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(608, 340);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 40);
            this.txtPrice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPrice.StateCommon.Border.Rounding = 20;
            this.txtPrice.StateCommon.Border.Width = 1;
            this.txtPrice.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Text = "Travel Cost";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(470, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 28);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "Travel Route";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(40, 407);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(324, 25);
            this.lblMessage.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.lblMessage.StateCommon.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.lblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.StateNormal.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.lblMessage.StateNormal.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.lblMessage.StateNormal.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Values.Text = "Error: Invalid Boarding/ Desination given";
            this.lblMessage.Visible = false;
            // 
            // lblSwitch
            // 
            this.lblSwitch.Location = new System.Drawing.Point(470, 407);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(356, 25);
            this.lblSwitch.StateCommon.ShortText.Color1 = System.Drawing.Color.GreenYellow;
            this.lblSwitch.StateCommon.ShortText.Color2 = System.Drawing.Color.GreenYellow;
            this.lblSwitch.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch.StateNormal.ShortText.Color1 = System.Drawing.Color.OliveDrab;
            this.lblSwitch.StateNormal.ShortText.Color2 = System.Drawing.Color.OliveDrab;
            this.lblSwitch.StateNormal.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch.TabIndex = 13;
            this.lblSwitch.Values.Text = "You have to switch route at Majestic Station!";
            this.lblSwitch.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(859, 453);
            this.Controls.Add(this.lblSwitch);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStops);
            this.Controls.Add(this.listRoute);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.cboBoarding);
            this.Controls.Add(this.cboDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Namma Meto Ticketing Machine";
            ((System.ComponentModel.ISupportInitialize)(this.cboDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoarding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboDestination;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboBoarding;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox listRoute;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtStops;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSwitch;
    }
}

