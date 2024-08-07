﻿namespace PSSDKInternalStorageExample
{
    partial class FrmInternalStorageBrowser
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
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.psCommSimpleWinForms = new PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.numUDTargetItem = new System.Windows.Forms.NumericUpDown();
            this.grpInternalStorage = new System.Windows.Forms.GroupBox();
            this.lbInternalStorage = new System.Windows.Forms.ListBox();
            this.grpConnection.SuspendLayout();
            this.grpConsole.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTargetItem)).BeginInit();
            this.grpInternalStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnection.Controls.Add(this.cmbDevices);
            this.grpConnection.Controls.Add(this.btnRefresh);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Location = new System.Drawing.Point(16, 15);
            this.grpConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnection.Size = new System.Drawing.Size(369, 97);
            this.grpConnection.TabIndex = 5;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // cmbDevices
            // 
            this.cmbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(8, 23);
            this.cmbDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(347, 24);
            this.cmbDevices.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(8, 57);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(115, 57);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpConsole
            // 
            this.grpConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConsole.Controls.Add(this.lbConsole);
            this.grpConsole.Location = new System.Drawing.Point(16, 116);
            this.grpConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConsole.Size = new System.Drawing.Size(369, 377);
            this.grpConsole.TabIndex = 8;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "Console";
            // 
            // lbConsole
            // 
            this.lbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.HorizontalScrollbar = true;
            this.lbConsole.ItemHeight = 16;
            this.lbConsole.Location = new System.Drawing.Point(9, 23);
            this.lbConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(351, 340);
            this.lbConsole.TabIndex = 0;
            // 
            // btnListFiles
            // 
            this.btnListFiles.Enabled = false;
            this.btnListFiles.Location = new System.Drawing.Point(8, 23);
            this.btnListFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(100, 28);
            this.btnListFiles.TabIndex = 3;
            this.btnListFiles.Text = "List Files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // psCommSimpleWinForms
            // 
            this.psCommSimpleWinForms.EnableBluetooth = false;
            this.psCommSimpleWinForms.EnableSerialPort = false;
            this.psCommSimpleWinForms.Parent = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.numUDTargetItem);
            this.groupBox1.Controls.Add(this.btnListFiles);
            this.groupBox1.Location = new System.Drawing.Point(395, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(403, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Storage Commands";
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(116, 57);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // numUDTargetItem
            // 
            this.numUDTargetItem.Enabled = false;
            this.numUDTargetItem.Location = new System.Drawing.Point(8, 60);
            this.numUDTargetItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUDTargetItem.Name = "numUDTargetItem";
            this.numUDTargetItem.Size = new System.Drawing.Size(100, 22);
            this.numUDTargetItem.TabIndex = 4;
            this.numUDTargetItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDTargetItem.ValueChanged += new System.EventHandler(this.numUDTargetItem_ValueChanged);
            // 
            // grpInternalStorage
            // 
            this.grpInternalStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInternalStorage.Controls.Add(this.lbInternalStorage);
            this.grpInternalStorage.Location = new System.Drawing.Point(395, 116);
            this.grpInternalStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInternalStorage.Name = "grpInternalStorage";
            this.grpInternalStorage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInternalStorage.Size = new System.Drawing.Size(403, 377);
            this.grpInternalStorage.TabIndex = 10;
            this.grpInternalStorage.TabStop = false;
            this.grpInternalStorage.Text = "Internal Storage";
            // 
            // lbInternalStorage
            // 
            this.lbInternalStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInternalStorage.FormattingEnabled = true;
            this.lbInternalStorage.ItemHeight = 16;
            this.lbInternalStorage.Location = new System.Drawing.Point(9, 23);
            this.lbInternalStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbInternalStorage.Name = "lbInternalStorage";
            this.lbInternalStorage.Size = new System.Drawing.Size(384, 340);
            this.lbInternalStorage.TabIndex = 0;
            this.lbInternalStorage.SelectedIndexChanged += new System.EventHandler(this.lbInternalStorage_SelectedIndexChanged);
            this.lbInternalStorage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInternalStorage_MouseDoubleClick);
            // 
            // FrmInternalStorageBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 503);
            this.Controls.Add(this.grpInternalStorage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInternalStorageBrowser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInternalStorageBrowser_Load);
            this.grpConnection.ResumeLayout(false);
            this.grpConsole.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDTargetItem)).EndInit();
            this.grpInternalStorage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.ListBox lbConsole;
        private PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms psCommSimpleWinForms;
        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.NumericUpDown numUDTargetItem;
        private System.Windows.Forms.GroupBox grpInternalStorage;
        private System.Windows.Forms.ListBox lbInternalStorage;
    }
}

