namespace JSPartsInfo
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
            this.pbx_CPU = new System.Windows.Forms.PictureBox();
            this.pbx_BoardID = new System.Windows.Forms.PictureBox();
            this.pbx_Board = new System.Windows.Forms.PictureBox();
            this.txb_CPU = new System.Windows.Forms.TextBox();
            this.lbl_Board = new System.Windows.Forms.Label();
            this.txb_BoardID = new System.Windows.Forms.TextBox();
            this.lbl_CPU = new System.Windows.Forms.Label();
            this.txb_Mainboard = new System.Windows.Forms.TextBox();
            this.lbl_BoardID = new System.Windows.Forms.Label();
            this.pbx_RAMSlots = new System.Windows.Forms.PictureBox();
            this.pbx_RAM = new System.Windows.Forms.PictureBox();
            this.pbx_CPUSpeed = new System.Windows.Forms.PictureBox();
            this.txb_RAMSlots = new System.Windows.Forms.TextBox();
            this.lbl_CPUSpeed = new System.Windows.Forms.Label();
            this.txb_RAM = new System.Windows.Forms.TextBox();
            this.lbl_RAMSlots = new System.Windows.Forms.Label();
            this.txb_CPUSpeed = new System.Windows.Forms.TextBox();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.pbx_BISOCap = new System.Windows.Forms.PictureBox();
            this.txb_BIOSCap = new System.Windows.Forms.TextBox();
            this.lbl_BIOSCap = new System.Windows.Forms.Label();
            this.pbx_BISOSN = new System.Windows.Forms.PictureBox();
            this.pbx_BIOS = new System.Windows.Forms.PictureBox();
            this.pbx_HDD = new System.Windows.Forms.PictureBox();
            this.txb_BIOSSN = new System.Windows.Forms.TextBox();
            this.lbl_HDD = new System.Windows.Forms.Label();
            this.txb_BIOS = new System.Windows.Forms.TextBox();
            this.lbl_BIOSSN = new System.Windows.Forms.Label();
            this.txb_HDD = new System.Windows.Forms.TextBox();
            this.lbl_BIOS = new System.Windows.Forms.Label();
            this.pbx_Info = new System.Windows.Forms.PictureBox();
            this.ddl_Language = new System.Windows.Forms.ComboBox();
            this.btn_InfosAuslesen = new System.Windows.Forms.Button();
            this.pbx_CopyAll = new System.Windows.Forms.PictureBox();
            this.ttp_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BoardID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_RAMSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CPUSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BISOCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BISOSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_CPU
            // 
            this.pbx_CPU.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CPU.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_CPU.Location = new System.Drawing.Point(398, 61);
            this.pbx_CPU.Name = "pbx_CPU";
            this.pbx_CPU.Size = new System.Drawing.Size(20, 20);
            this.pbx_CPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CPU.TabIndex = 31;
            this.pbx_CPU.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CPU, "Copy CPU!");
            this.pbx_CPU.Click += new System.EventHandler(this.pxb_CPU_Click);
            // 
            // pbx_BoardID
            // 
            this.pbx_BoardID.BackColor = System.Drawing.Color.Transparent;
            this.pbx_BoardID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_BoardID.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_BoardID.Location = new System.Drawing.Point(398, 35);
            this.pbx_BoardID.Name = "pbx_BoardID";
            this.pbx_BoardID.Size = new System.Drawing.Size(20, 20);
            this.pbx_BoardID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_BoardID.TabIndex = 30;
            this.pbx_BoardID.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_BoardID, "Copy Board S/N!");
            this.pbx_BoardID.Click += new System.EventHandler(this.pbx_BoardID_Click);
            // 
            // pbx_Board
            // 
            this.pbx_Board.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Board.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_Board.Location = new System.Drawing.Point(398, 9);
            this.pbx_Board.Name = "pbx_Board";
            this.pbx_Board.Size = new System.Drawing.Size(20, 20);
            this.pbx_Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Board.TabIndex = 29;
            this.pbx_Board.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_Board, "Copy Board!");
            this.pbx_Board.Click += new System.EventHandler(this.pbx_Board_Click);
            // 
            // txb_CPU
            // 
            this.txb_CPU.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CPU.Location = new System.Drawing.Point(148, 61);
            this.txb_CPU.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CPU.Name = "txb_CPU";
            this.txb_CPU.Size = new System.Drawing.Size(245, 20);
            this.txb_CPU.TabIndex = 28;
            // 
            // lbl_Board
            // 
            this.lbl_Board.AutoSize = true;
            this.lbl_Board.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Board.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Board.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Board.Location = new System.Drawing.Point(14, 12);
            this.lbl_Board.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Board.Name = "lbl_Board";
            this.lbl_Board.Size = new System.Drawing.Size(44, 13);
            this.lbl_Board.TabIndex = 27;
            this.lbl_Board.Text = "Board:";
            // 
            // txb_BoardID
            // 
            this.txb_BoardID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_BoardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_BoardID.Location = new System.Drawing.Point(148, 35);
            this.txb_BoardID.Margin = new System.Windows.Forms.Padding(2);
            this.txb_BoardID.Name = "txb_BoardID";
            this.txb_BoardID.Size = new System.Drawing.Size(245, 20);
            this.txb_BoardID.TabIndex = 26;
            // 
            // lbl_CPU
            // 
            this.lbl_CPU.AutoSize = true;
            this.lbl_CPU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CPU.Location = new System.Drawing.Point(14, 65);
            this.lbl_CPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CPU.Name = "lbl_CPU";
            this.lbl_CPU.Size = new System.Drawing.Size(36, 13);
            this.lbl_CPU.TabIndex = 25;
            this.lbl_CPU.Text = "CPU:";
            // 
            // txb_Mainboard
            // 
            this.txb_Mainboard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_Mainboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Mainboard.Location = new System.Drawing.Point(148, 9);
            this.txb_Mainboard.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Mainboard.Name = "txb_Mainboard";
            this.txb_Mainboard.Size = new System.Drawing.Size(245, 20);
            this.txb_Mainboard.TabIndex = 24;
            // 
            // lbl_BoardID
            // 
            this.lbl_BoardID.AutoSize = true;
            this.lbl_BoardID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BoardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoardID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BoardID.Location = new System.Drawing.Point(14, 39);
            this.lbl_BoardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BoardID.Name = "lbl_BoardID";
            this.lbl_BoardID.Size = new System.Drawing.Size(71, 13);
            this.lbl_BoardID.TabIndex = 23;
            this.lbl_BoardID.Text = "Board-S/N:";
            // 
            // pbx_RAMSlots
            // 
            this.pbx_RAMSlots.BackColor = System.Drawing.Color.Transparent;
            this.pbx_RAMSlots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_RAMSlots.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_RAMSlots.Location = new System.Drawing.Point(398, 139);
            this.pbx_RAMSlots.Name = "pbx_RAMSlots";
            this.pbx_RAMSlots.Size = new System.Drawing.Size(20, 20);
            this.pbx_RAMSlots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_RAMSlots.TabIndex = 43;
            this.pbx_RAMSlots.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_RAMSlots, "Copy RAM slots!");
            this.pbx_RAMSlots.Click += new System.EventHandler(this.pbx_RAMSlots_Click);
            // 
            // pbx_RAM
            // 
            this.pbx_RAM.BackColor = System.Drawing.Color.Transparent;
            this.pbx_RAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_RAM.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_RAM.Location = new System.Drawing.Point(398, 113);
            this.pbx_RAM.Name = "pbx_RAM";
            this.pbx_RAM.Size = new System.Drawing.Size(20, 20);
            this.pbx_RAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_RAM.TabIndex = 42;
            this.pbx_RAM.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_RAM, "Copy RAM!");
            this.pbx_RAM.Click += new System.EventHandler(this.pbx_RAM_Click);
            // 
            // pbx_CPUSpeed
            // 
            this.pbx_CPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CPUSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CPUSpeed.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_CPUSpeed.Location = new System.Drawing.Point(398, 87);
            this.pbx_CPUSpeed.Name = "pbx_CPUSpeed";
            this.pbx_CPUSpeed.Size = new System.Drawing.Size(20, 20);
            this.pbx_CPUSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CPUSpeed.TabIndex = 41;
            this.pbx_CPUSpeed.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CPUSpeed, "Copy CPU speed!");
            this.pbx_CPUSpeed.Click += new System.EventHandler(this.pxb_CPUSpeed_Click);
            // 
            // txb_RAMSlots
            // 
            this.txb_RAMSlots.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_RAMSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RAMSlots.Location = new System.Drawing.Point(148, 139);
            this.txb_RAMSlots.Margin = new System.Windows.Forms.Padding(2);
            this.txb_RAMSlots.Name = "txb_RAMSlots";
            this.txb_RAMSlots.Size = new System.Drawing.Size(245, 20);
            this.txb_RAMSlots.TabIndex = 40;
            // 
            // lbl_CPUSpeed
            // 
            this.lbl_CPUSpeed.AutoSize = true;
            this.lbl_CPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPUSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CPUSpeed.Location = new System.Drawing.Point(14, 90);
            this.lbl_CPUSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CPUSpeed.Name = "lbl_CPUSpeed";
            this.lbl_CPUSpeed.Size = new System.Drawing.Size(58, 13);
            this.lbl_CPUSpeed.TabIndex = 39;
            this.lbl_CPUSpeed.Text = "Taktung:";
            // 
            // txb_RAM
            // 
            this.txb_RAM.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RAM.Location = new System.Drawing.Point(148, 113);
            this.txb_RAM.Margin = new System.Windows.Forms.Padding(2);
            this.txb_RAM.Name = "txb_RAM";
            this.txb_RAM.Size = new System.Drawing.Size(245, 20);
            this.txb_RAM.TabIndex = 38;
            // 
            // lbl_RAMSlots
            // 
            this.lbl_RAMSlots.AutoSize = true;
            this.lbl_RAMSlots.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RAMSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RAMSlots.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RAMSlots.Location = new System.Drawing.Point(14, 143);
            this.lbl_RAMSlots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RAMSlots.Name = "lbl_RAMSlots";
            this.lbl_RAMSlots.Size = new System.Drawing.Size(89, 13);
            this.lbl_RAMSlots.TabIndex = 37;
            this.lbl_RAMSlots.Text = "Anzahl Riegel:";
            // 
            // txb_CPUSpeed
            // 
            this.txb_CPUSpeed.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_CPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CPUSpeed.Location = new System.Drawing.Point(148, 87);
            this.txb_CPUSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CPUSpeed.Name = "txb_CPUSpeed";
            this.txb_CPUSpeed.Size = new System.Drawing.Size(245, 20);
            this.txb_CPUSpeed.TabIndex = 36;
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RAM.Location = new System.Drawing.Point(14, 117);
            this.lbl_RAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(92, 13);
            this.lbl_RAM.TabIndex = 35;
            this.lbl_RAM.Text = "RAM-Speicher:";
            // 
            // pbx_BISOCap
            // 
            this.pbx_BISOCap.BackColor = System.Drawing.Color.Transparent;
            this.pbx_BISOCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_BISOCap.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_BISOCap.Location = new System.Drawing.Point(398, 242);
            this.pbx_BISOCap.Name = "pbx_BISOCap";
            this.pbx_BISOCap.Size = new System.Drawing.Size(20, 20);
            this.pbx_BISOCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_BISOCap.TabIndex = 58;
            this.pbx_BISOCap.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_BISOCap, "Copy Bios Caption!");
            this.pbx_BISOCap.Click += new System.EventHandler(this.pbx_BIOSCap_Click);
            // 
            // txb_BIOSCap
            // 
            this.txb_BIOSCap.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_BIOSCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_BIOSCap.Location = new System.Drawing.Point(148, 242);
            this.txb_BIOSCap.Margin = new System.Windows.Forms.Padding(2);
            this.txb_BIOSCap.Name = "txb_BIOSCap";
            this.txb_BIOSCap.Size = new System.Drawing.Size(245, 20);
            this.txb_BIOSCap.TabIndex = 57;
            // 
            // lbl_BIOSCap
            // 
            this.lbl_BIOSCap.AutoSize = true;
            this.lbl_BIOSCap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BIOSCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BIOSCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BIOSCap.Location = new System.Drawing.Point(14, 246);
            this.lbl_BIOSCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BIOSCap.Name = "lbl_BIOSCap";
            this.lbl_BIOSCap.Size = new System.Drawing.Size(86, 13);
            this.lbl_BIOSCap.TabIndex = 56;
            this.lbl_BIOSCap.Text = "BIOS-Version:";
            // 
            // pbx_BISOSN
            // 
            this.pbx_BISOSN.BackColor = System.Drawing.Color.Transparent;
            this.pbx_BISOSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_BISOSN.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_BISOSN.Location = new System.Drawing.Point(398, 216);
            this.pbx_BISOSN.Name = "pbx_BISOSN";
            this.pbx_BISOSN.Size = new System.Drawing.Size(20, 20);
            this.pbx_BISOSN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_BISOSN.TabIndex = 55;
            this.pbx_BISOSN.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_BISOSN, "Copy BIOS S/N!");
            this.pbx_BISOSN.Click += new System.EventHandler(this.pbx_BIOSSN_Click);
            // 
            // pbx_BIOS
            // 
            this.pbx_BIOS.BackColor = System.Drawing.Color.Transparent;
            this.pbx_BIOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_BIOS.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_BIOS.Location = new System.Drawing.Point(398, 190);
            this.pbx_BIOS.Name = "pbx_BIOS";
            this.pbx_BIOS.Size = new System.Drawing.Size(20, 20);
            this.pbx_BIOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_BIOS.TabIndex = 54;
            this.pbx_BIOS.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_BIOS, "Copy BIOS!");
            this.pbx_BIOS.Click += new System.EventHandler(this.pbx_BIOS_Click);
            // 
            // pbx_HDD
            // 
            this.pbx_HDD.BackColor = System.Drawing.Color.Transparent;
            this.pbx_HDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_HDD.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_HDD.Location = new System.Drawing.Point(398, 164);
            this.pbx_HDD.Name = "pbx_HDD";
            this.pbx_HDD.Size = new System.Drawing.Size(20, 20);
            this.pbx_HDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_HDD.TabIndex = 53;
            this.pbx_HDD.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_HDD, "Copy HDD S/N!");
            this.pbx_HDD.Click += new System.EventHandler(this.pbx_HDD_Click);
            // 
            // txb_BIOSSN
            // 
            this.txb_BIOSSN.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_BIOSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_BIOSSN.Location = new System.Drawing.Point(148, 216);
            this.txb_BIOSSN.Margin = new System.Windows.Forms.Padding(2);
            this.txb_BIOSSN.Name = "txb_BIOSSN";
            this.txb_BIOSSN.Size = new System.Drawing.Size(245, 20);
            this.txb_BIOSSN.TabIndex = 52;
            // 
            // lbl_HDD
            // 
            this.lbl_HDD.AutoSize = true;
            this.lbl_HDD.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HDD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_HDD.Location = new System.Drawing.Point(14, 167);
            this.lbl_HDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HDD.Name = "lbl_HDD";
            this.lbl_HDD.Size = new System.Drawing.Size(101, 13);
            this.lbl_HDD.TabIndex = 51;
            this.lbl_HDD.Text = "Festplatten-S/N:";
            // 
            // txb_BIOS
            // 
            this.txb_BIOS.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_BIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_BIOS.Location = new System.Drawing.Point(148, 190);
            this.txb_BIOS.Margin = new System.Windows.Forms.Padding(2);
            this.txb_BIOS.Name = "txb_BIOS";
            this.txb_BIOS.Size = new System.Drawing.Size(245, 20);
            this.txb_BIOS.TabIndex = 50;
            // 
            // lbl_BIOSSN
            // 
            this.lbl_BIOSSN.AutoSize = true;
            this.lbl_BIOSSN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BIOSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BIOSSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BIOSSN.Location = new System.Drawing.Point(14, 220);
            this.lbl_BIOSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BIOSSN.Name = "lbl_BIOSSN";
            this.lbl_BIOSSN.Size = new System.Drawing.Size(67, 13);
            this.lbl_BIOSSN.TabIndex = 49;
            this.lbl_BIOSSN.Text = "BIOS-S/N:";
            // 
            // txb_HDD
            // 
            this.txb_HDD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_HDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_HDD.Location = new System.Drawing.Point(148, 164);
            this.txb_HDD.Margin = new System.Windows.Forms.Padding(2);
            this.txb_HDD.Name = "txb_HDD";
            this.txb_HDD.Size = new System.Drawing.Size(245, 20);
            this.txb_HDD.TabIndex = 48;
            // 
            // lbl_BIOS
            // 
            this.lbl_BIOS.AutoSize = true;
            this.lbl_BIOS.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BIOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BIOS.Location = new System.Drawing.Point(14, 194);
            this.lbl_BIOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BIOS.Name = "lbl_BIOS";
            this.lbl_BIOS.Size = new System.Drawing.Size(98, 13);
            this.lbl_BIOS.TabIndex = 47;
            this.lbl_BIOS.Text = "BIOS-Hersteller:";
            this.lbl_BIOS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbx_Info
            // 
            this.pbx_Info.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Info.Image = global::JSPartsInfo.Properties.Resources.information_icon_white;
            this.pbx_Info.Location = new System.Drawing.Point(148, 283);
            this.pbx_Info.Name = "pbx_Info";
            this.pbx_Info.Size = new System.Drawing.Size(21, 21);
            this.pbx_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Info.TabIndex = 61;
            this.pbx_Info.TabStop = false;
            this.pbx_Info.Click += new System.EventHandler(this.pbx_Info_Click);
            // 
            // ddl_Language
            // 
            this.ddl_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddl_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Language.FormattingEnabled = true;
            this.ddl_Language.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.ddl_Language.Location = new System.Drawing.Point(17, 283);
            this.ddl_Language.Name = "ddl_Language";
            this.ddl_Language.Size = new System.Drawing.Size(121, 21);
            this.ddl_Language.TabIndex = 60;
            this.ttp_ToolTips.SetToolTip(this.ddl_Language, "Select Language!");
            this.ddl_Language.SelectedIndexChanged += new System.EventHandler(this.ddl_Language_Changed);
            this.ddl_Language.Click += new System.EventHandler(this.ddl_Language_Changed);
            // 
            // btn_InfosAuslesen
            // 
            this.btn_InfosAuslesen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_InfosAuslesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InfosAuslesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfosAuslesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfosAuslesen.Location = new System.Drawing.Point(398, 283);
            this.btn_InfosAuslesen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_InfosAuslesen.Name = "btn_InfosAuslesen";
            this.btn_InfosAuslesen.Size = new System.Drawing.Size(75, 23);
            this.btn_InfosAuslesen.TabIndex = 59;
            this.btn_InfosAuslesen.Text = "erneuern...";
            this.ttp_ToolTips.SetToolTip(this.btn_InfosAuslesen, "Refresh Data!");
            this.btn_InfosAuslesen.UseVisualStyleBackColor = false;
            this.btn_InfosAuslesen.Click += new System.EventHandler(this.btn_InfosAuslesen_Click);
            // 
            // pbx_CopyAll
            // 
            this.pbx_CopyAll.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CopyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CopyAll.Image = global::JSPartsInfo.Properties.Resources.copy;
            this.pbx_CopyAll.Location = new System.Drawing.Point(428, 113);
            this.pbx_CopyAll.Name = "pbx_CopyAll";
            this.pbx_CopyAll.Size = new System.Drawing.Size(45, 45);
            this.pbx_CopyAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CopyAll.TabIndex = 62;
            this.pbx_CopyAll.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CopyAll, "Copy All!");
            this.pbx_CopyAll.Click += new System.EventHandler(this.pbx_CopyAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSPartsInfo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 320);
            this.Controls.Add(this.pbx_CopyAll);
            this.Controls.Add(this.pbx_Info);
            this.Controls.Add(this.ddl_Language);
            this.Controls.Add(this.btn_InfosAuslesen);
            this.Controls.Add(this.pbx_BISOCap);
            this.Controls.Add(this.txb_BIOSCap);
            this.Controls.Add(this.lbl_BIOSCap);
            this.Controls.Add(this.pbx_BISOSN);
            this.Controls.Add(this.pbx_BIOS);
            this.Controls.Add(this.pbx_HDD);
            this.Controls.Add(this.txb_BIOSSN);
            this.Controls.Add(this.lbl_HDD);
            this.Controls.Add(this.txb_BIOS);
            this.Controls.Add(this.lbl_BIOSSN);
            this.Controls.Add(this.txb_HDD);
            this.Controls.Add(this.lbl_BIOS);
            this.Controls.Add(this.pbx_RAMSlots);
            this.Controls.Add(this.pbx_RAM);
            this.Controls.Add(this.pbx_CPUSpeed);
            this.Controls.Add(this.txb_RAMSlots);
            this.Controls.Add(this.lbl_CPUSpeed);
            this.Controls.Add(this.txb_RAM);
            this.Controls.Add(this.lbl_RAMSlots);
            this.Controls.Add(this.txb_CPUSpeed);
            this.Controls.Add(this.lbl_RAM);
            this.Controls.Add(this.pbx_CPU);
            this.Controls.Add(this.pbx_BoardID);
            this.Controls.Add(this.pbx_Board);
            this.Controls.Add(this.txb_CPU);
            this.Controls.Add(this.lbl_Board);
            this.Controls.Add(this.txb_BoardID);
            this.Controls.Add(this.lbl_CPU);
            this.Controls.Add(this.txb_Mainboard);
            this.Controls.Add(this.lbl_BoardID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "JSPartsInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BoardID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_RAMSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CPUSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BISOCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BISOSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbx_CPU;
        private System.Windows.Forms.PictureBox pbx_BoardID;
        private System.Windows.Forms.PictureBox pbx_Board;
        private System.Windows.Forms.TextBox txb_CPU;
        private System.Windows.Forms.Label lbl_Board;
        private System.Windows.Forms.TextBox txb_BoardID;
        private System.Windows.Forms.Label lbl_CPU;
        private System.Windows.Forms.TextBox txb_Mainboard;
        private System.Windows.Forms.Label lbl_BoardID;
        private System.Windows.Forms.PictureBox pbx_RAMSlots;
        private System.Windows.Forms.PictureBox pbx_RAM;
        private System.Windows.Forms.PictureBox pbx_CPUSpeed;
        private System.Windows.Forms.TextBox txb_RAMSlots;
        private System.Windows.Forms.Label lbl_CPUSpeed;
        private System.Windows.Forms.TextBox txb_RAM;
        private System.Windows.Forms.Label lbl_RAMSlots;
        private System.Windows.Forms.TextBox txb_CPUSpeed;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.PictureBox pbx_BISOCap;
        private System.Windows.Forms.TextBox txb_BIOSCap;
        private System.Windows.Forms.Label lbl_BIOSCap;
        private System.Windows.Forms.PictureBox pbx_BISOSN;
        private System.Windows.Forms.PictureBox pbx_BIOS;
        private System.Windows.Forms.PictureBox pbx_HDD;
        private System.Windows.Forms.TextBox txb_BIOSSN;
        private System.Windows.Forms.Label lbl_HDD;
        private System.Windows.Forms.TextBox txb_BIOS;
        private System.Windows.Forms.Label lbl_BIOSSN;
        private System.Windows.Forms.TextBox txb_HDD;
        private System.Windows.Forms.Label lbl_BIOS;
        private System.Windows.Forms.PictureBox pbx_Info;
        private System.Windows.Forms.ComboBox ddl_Language;
        private System.Windows.Forms.Button btn_InfosAuslesen;
        private System.Windows.Forms.PictureBox pbx_CopyAll;
        private System.Windows.Forms.ToolTip ttp_ToolTips;
    }
}

