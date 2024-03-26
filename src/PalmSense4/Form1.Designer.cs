﻿using System;

namespace PalmSense4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCurrentRange = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPotential = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeviceStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDataViewSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvMeasurement = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.measurement_type = new System.Windows.Forms.ComboBox();
            this.PlotSettings = new System.Windows.Forms.MenuStrip();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGraphAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peakDetectationPlot = new System.Windows.Forms.ToolStripMenuItem();
            this.movingAvargeBaselineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILOP = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlotZoomSet = new System.Windows.Forms.ToolStripMenuItem();
            this.lODLOQCalculationTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIdrawHas = new System.Windows.Forms.ToolStripMenuItem();
            this.exportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILoadPeakLOD = new System.Windows.Forms.ToolStripMenuItem();
            this.plot = new SDKPlot.WinForms.Plot();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset_GramsToMoleCalc = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_NumberofMoles = new System.Windows.Forms.TextBox();
            this.textBox_Mass = new System.Windows.Forms.TextBox();
            this.radioButton_NumberofMoles = new System.Windows.Forms.RadioButton();
            this.radioButton_Mass = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox_Chemical_Select = new System.Windows.Forms.ComboBox();
            this.textBox_MolarMass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Chemical = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_pH = new System.Windows.Forms.TextBox();
            this.textBox_pOH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_OH = new System.Windows.Forms.TextBox();
            this.radioButton_OH = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.radioButton_H = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radioButton_molarity = new System.Windows.Forms.RadioButton();
            this.radioButton_molarmass = new System.Windows.Forms.RadioButton();
            this.radioButton_ppm = new System.Windows.Forms.RadioButton();
            this.textBox_MolarMass_ppm = new System.Windows.Forms.TextBox();
            this.comboBox_molarity_unit = new System.Windows.Forms.ComboBox();
            this.comboBox_ppm_unit = new System.Windows.Forms.ComboBox();
            this.textBox_Molarity = new System.Windows.Forms.TextBox();
            this.textBox_ppm = new System.Windows.Forms.TextBox();
            this.button_reset_ppm = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tbFinVol = new System.Windows.Forms.TextBox();
            this.tbFinConc = new System.Windows.Forms.TextBox();
            this.tbInitVol = new System.Windows.Forms.TextBox();
            this.tbInitConc = new System.Windows.Forms.TextBox();
            this.rbFinVol = new System.Windows.Forms.RadioButton();
            this.rbFinConc = new System.Windows.Forms.RadioButton();
            this.rbInitVol = new System.Windows.Forms.RadioButton();
            this.rbInitConc = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.psCommSimpleWinForms1 = new PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).BeginInit();
            this.panel14.SuspendLayout();
            this.PlotSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.cmbDevices);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 282);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(20, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 117);
            this.panel5.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblCurrentRange);
            this.panel8.Controls.Add(this.tbCurrent);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 72);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(371, 33);
            this.panel8.TabIndex = 4;
            // 
            // lblCurrentRange
            // 
            this.lblCurrentRange.AutoSize = true;
            this.lblCurrentRange.Location = new System.Drawing.Point(283, 8);
            this.lblCurrentRange.Name = "lblCurrentRange";
            this.lblCurrentRange.Size = new System.Drawing.Size(52, 16);
            this.lblCurrentRange.TabIndex = 2;
            this.lblCurrentRange.Text = "* 10 mA";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(71, 5);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.ReadOnly = true;
            this.tbCurrent.Size = new System.Drawing.Size(206, 22);
            this.tbCurrent.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.tbPotential);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(3, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(371, 33);
            this.panel7.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "V";
            // 
            // tbPotential
            // 
            this.tbPotential.Location = new System.Drawing.Point(71, 5);
            this.tbPotential.Name = "tbPotential";
            this.tbPotential.ReadOnly = true;
            this.tbPotential.Size = new System.Drawing.Size(206, 22);
            this.tbPotential.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Potential:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tbDeviceStatus);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 33);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 2;
            // 
            // tbDeviceStatus
            // 
            this.tbDeviceStatus.Location = new System.Drawing.Point(71, 5);
            this.tbDeviceStatus.Name = "tbDeviceStatus";
            this.tbDeviceStatus.ReadOnly = true;
            this.tbDeviceStatus.Size = new System.Drawing.Size(206, 22);
            this.tbDeviceStatus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 20);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connect Device";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(63, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 34);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(204, 96);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 34);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(122, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Bluetooth Connection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(63, 66);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(276, 24);
            this.cmbDevices.TabIndex = 4;
            // 
            // lbConsole
            // 
            this.lbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.ItemHeight = 16;
            this.lbConsole.Location = new System.Drawing.Point(3, 24);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(411, 128);
            this.lbConsole.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbConsole);
            this.panel2.Location = new System.Drawing.Point(12, 718);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 155);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 20);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(435, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.btnDataViewSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMeasurement);
            this.splitContainer1.Panel1.Controls.Add(this.panel14);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.splitContainer1.Panel2.Controls.Add(this.PlotSettings);
            this.splitContainer1.Panel2.Controls.Add(this.plot);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 861);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnDataViewSave
            // 
            this.btnDataViewSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataViewSave.Location = new System.Drawing.Point(202, 808);
            this.btnDataViewSave.Name = "btnDataViewSave";
            this.btnDataViewSave.Size = new System.Drawing.Size(185, 49);
            this.btnDataViewSave.TabIndex = 10;
            this.btnDataViewSave.Text = "Save";
            this.btnDataViewSave.UseVisualStyleBackColor = true;
            this.btnDataViewSave.Click += new System.EventHandler(this.btnDataViewSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(10, 808);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(185, 49);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvMeasurement
            // 
            this.dgvMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeasurement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMeasurement.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMeasurement.Location = new System.Drawing.Point(10, 100);
            this.dgvMeasurement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMeasurement.Name = "dgvMeasurement";
            this.dgvMeasurement.RowHeadersVisible = false;
            this.dgvMeasurement.RowHeadersWidth = 51;
            this.dgvMeasurement.Size = new System.Drawing.Size(376, 701);
            this.dgvMeasurement.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.Controls.Add(this.btnMeasure);
            this.panel14.Controls.Add(this.btnSaveSetting);
            this.panel14.Controls.Add(this.measurement_type);
            this.panel14.Location = new System.Drawing.Point(10, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(376, 89);
            this.panel14.TabIndex = 7;
            // 
            // btnMeasure
            // 
            this.btnMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeasure.Enabled = false;
            this.btnMeasure.Location = new System.Drawing.Point(3, 50);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(372, 33);
            this.btnMeasure.TabIndex = 8;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSetting.Enabled = false;
            this.btnSaveSetting.Location = new System.Drawing.Point(208, 9);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(167, 35);
            this.btnSaveSetting.TabIndex = 7;
            this.btnSaveSetting.Text = "Measure Settings";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // measurement_type
            // 
            this.measurement_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.measurement_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurement_type.Enabled = false;
            this.measurement_type.FormattingEnabled = true;
            this.measurement_type.Location = new System.Drawing.Point(3, 15);
            this.measurement_type.Name = "measurement_type";
            this.measurement_type.Size = new System.Drawing.Size(199, 24);
            this.measurement_type.TabIndex = 6;
            this.measurement_type.SelectedIndexChanged += new System.EventHandler(this.measurement_type_SelectedIndexChanged);
            // 
            // PlotSettings
            // 
            this.PlotSettings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.PlotSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PlotSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.zoomSettingsToolStripMenuItem,
            this.exportsToolStripMenuItem,
            this.TSMILoadPeakLOD});
            this.PlotSettings.Location = new System.Drawing.Point(0, 0);
            this.PlotSettings.Name = "PlotSettings";
            this.PlotSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PlotSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlotSettings.Size = new System.Drawing.Size(641, 28);
            this.PlotSettings.TabIndex = 6;
            this.PlotSettings.Text = "menuStrip2";
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMeasureToolStripMenuItem,
            this.exportGraphAsImageToolStripMenuItem,
            this.peakDetectationPlot,
            this.movingAvargeBaselineToolStripMenuItem,
            this.TSMILOP});
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.plotToolStripMenuItem.Text = "Plot";
            // 
            // loadMeasureToolStripMenuItem
            // 
            this.loadMeasureToolStripMenuItem.Name = "loadMeasureToolStripMenuItem";
            this.loadMeasureToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.loadMeasureToolStripMenuItem.Text = "Load Measure For Excel";
            // 
            // exportGraphAsImageToolStripMenuItem
            // 
            this.exportGraphAsImageToolStripMenuItem.Name = "exportGraphAsImageToolStripMenuItem";
            this.exportGraphAsImageToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.exportGraphAsImageToolStripMenuItem.Text = "Export Graph As Image";
            // 
            // peakDetectationPlot
            // 
            this.peakDetectationPlot.Name = "peakDetectationPlot";
            this.peakDetectationPlot.Size = new System.Drawing.Size(252, 26);
            this.peakDetectationPlot.Text = "Peak Detectation";
            // 
            // movingAvargeBaselineToolStripMenuItem
            // 
            this.movingAvargeBaselineToolStripMenuItem.Name = "movingAvargeBaselineToolStripMenuItem";
            this.movingAvargeBaselineToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.movingAvargeBaselineToolStripMenuItem.Text = "Moving Avarge Baseline";
            // 
            // TSMILOP
            // 
            this.TSMILOP.Name = "TSMILOP";
            this.TSMILOP.Size = new System.Drawing.Size(252, 26);
            this.TSMILOP.Text = "List Of The Peaks";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearPlotToolStripMenuItem,
            this.clearMeasureToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.clearToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // clearPlotToolStripMenuItem
            // 
            this.clearPlotToolStripMenuItem.Name = "clearPlotToolStripMenuItem";
            this.clearPlotToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.clearPlotToolStripMenuItem.Text = "Clear Plot";
            this.clearPlotToolStripMenuItem.Click += new System.EventHandler(this.clearPlotToolStripMenuItem_Click);
            // 
            // clearMeasureToolStripMenuItem
            // 
            this.clearMeasureToolStripMenuItem.Name = "clearMeasureToolStripMenuItem";
            this.clearMeasureToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.clearMeasureToolStripMenuItem.Text = "Clear  Measure";
            this.clearMeasureToolStripMenuItem.Click += new System.EventHandler(this.clearMeasureToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // zoomSettingsToolStripMenuItem
            // 
            this.zoomSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlotZoomSet,
            this.lODLOQCalculationTSMI,
            this.TSMIdrawHas});
            this.zoomSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomSettingsToolStripMenuItem.Name = "zoomSettingsToolStripMenuItem";
            this.zoomSettingsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.zoomSettingsToolStripMenuItem.Text = "Filter ";
            // 
            // PlotZoomSet
            // 
            this.PlotZoomSet.Name = "PlotZoomSet";
            this.PlotZoomSet.Size = new System.Drawing.Size(232, 26);
            this.PlotZoomSet.Text = "Filter Set";
            // 
            // lODLOQCalculationTSMI
            // 
            this.lODLOQCalculationTSMI.Name = "lODLOQCalculationTSMI";
            this.lODLOQCalculationTSMI.Size = new System.Drawing.Size(232, 26);
            this.lODLOQCalculationTSMI.Text = "LOD-LOQ Calculation";
            // 
            // TSMIdrawHas
            // 
            this.TSMIdrawHas.Name = "TSMIdrawHas";
            this.TSMIdrawHas.Size = new System.Drawing.Size(232, 26);
            this.TSMIdrawHas.Text = "New";
            // 
            // exportsToolStripMenuItem
            // 
            this.exportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.exportsToolStripMenuItem.Name = "exportsToolStripMenuItem";
            this.exportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.exportsToolStripMenuItem.Text = "Exports";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // TSMILoadPeakLOD
            // 
            this.TSMILoadPeakLOD.Name = "TSMILoadPeakLOD";
            this.TSMILoadPeakLOD.Size = new System.Drawing.Size(181, 24);
            this.TSMILoadPeakLOD.Text = "Load Peaks For LOD&LOQ";
            // 
            // plot
            // 
            this.plot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plot.BackColor = System.Drawing.Color.White;
            this.plot.Location = new System.Drawing.Point(4, 32);
            this.plot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plot.MarkerSize = 5;
            this.plot.MarkerType = OxyPlot.MarkerType.Circle;
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(633, 825);
            this.plot.TabIndex = 0;
            this.plot.Title = null;
            this.plot.XAxisLabel = null;
            this.plot.XAxisType = SDKPlot.AxisType.Linear;
            this.plot.YAxisLabel = null;
            this.plot.YAxisSecondaryLabel = null;
            this.plot.YAxisSecondaryType = SDKPlot.AxisType.Linear;
            this.plot.YAxisType = SDKPlot.AxisType.Linear;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 300);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 412);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LOD - LOQ Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReset_GramsToMoleCalc);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grams to Mole Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReset_GramsToMoleCalc
            // 
            this.btnReset_GramsToMoleCalc.Location = new System.Drawing.Point(9, 337);
            this.btnReset_GramsToMoleCalc.Name = "btnReset_GramsToMoleCalc";
            this.btnReset_GramsToMoleCalc.Size = new System.Drawing.Size(104, 39);
            this.btnReset_GramsToMoleCalc.TabIndex = 2;
            this.btnReset_GramsToMoleCalc.Text = "Reset";
            this.btnReset_GramsToMoleCalc.UseVisualStyleBackColor = true;
            this.btnReset_GramsToMoleCalc.Click += new System.EventHandler(this.btnReset_GramsToMoleCalc_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.textBox_NumberofMoles);
            this.panel10.Controls.Add(this.textBox_Mass);
            this.panel10.Controls.Add(this.radioButton_NumberofMoles);
            this.panel10.Controls.Add(this.radioButton_Mass);
            this.panel10.Location = new System.Drawing.Point(28, 186);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(326, 133);
            this.panel10.TabIndex = 1;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(284, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "mol";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(286, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "g";
            // 
            // textBox_NumberofMoles
            // 
            this.textBox_NumberofMoles.Location = new System.Drawing.Point(142, 85);
            this.textBox_NumberofMoles.Name = "textBox_NumberofMoles";
            this.textBox_NumberofMoles.ReadOnly = true;
            this.textBox_NumberofMoles.Size = new System.Drawing.Size(138, 22);
            this.textBox_NumberofMoles.TabIndex = 8;
            this.textBox_NumberofMoles.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_Mass
            // 
            this.textBox_Mass.Location = new System.Drawing.Point(142, 34);
            this.textBox_Mass.Name = "textBox_Mass";
            this.textBox_Mass.ReadOnly = true;
            this.textBox_Mass.Size = new System.Drawing.Size(138, 22);
            this.textBox_Mass.TabIndex = 7;
            this.textBox_Mass.TextChanged += new System.EventHandler(this.textBox_Mass_TextChanged);
            // 
            // radioButton_NumberofMoles
            // 
            this.radioButton_NumberofMoles.AutoSize = true;
            this.radioButton_NumberofMoles.Location = new System.Drawing.Point(3, 87);
            this.radioButton_NumberofMoles.Name = "radioButton_NumberofMoles";
            this.radioButton_NumberofMoles.Size = new System.Drawing.Size(133, 20);
            this.radioButton_NumberofMoles.TabIndex = 1;
            this.radioButton_NumberofMoles.TabStop = true;
            this.radioButton_NumberofMoles.Text = "Number of Moles:";
            this.radioButton_NumberofMoles.UseVisualStyleBackColor = true;
            this.radioButton_NumberofMoles.CheckedChanged += new System.EventHandler(this.radioButton_NumberofMoles_CheckedChanged);
            // 
            // radioButton_Mass
            // 
            this.radioButton_Mass.AutoSize = true;
            this.radioButton_Mass.Location = new System.Drawing.Point(3, 34);
            this.radioButton_Mass.Name = "radioButton_Mass";
            this.radioButton_Mass.Size = new System.Drawing.Size(64, 20);
            this.radioButton_Mass.TabIndex = 0;
            this.radioButton_Mass.TabStop = true;
            this.radioButton_Mass.Text = "Mass:";
            this.radioButton_Mass.UseVisualStyleBackColor = true;
            this.radioButton_Mass.CheckedChanged += new System.EventHandler(this.radioButton_Mass_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.comboBox_Chemical_Select);
            this.panel9.Controls.Add(this.textBox_MolarMass);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.comboBox_Chemical);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(28, 17);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(326, 163);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // comboBox_Chemical_Select
            // 
            this.comboBox_Chemical_Select.Enabled = false;
            this.comboBox_Chemical_Select.FormattingEnabled = true;
            this.comboBox_Chemical_Select.Location = new System.Drawing.Point(99, 58);
            this.comboBox_Chemical_Select.Name = "comboBox_Chemical_Select";
            this.comboBox_Chemical_Select.Size = new System.Drawing.Size(185, 24);
            this.comboBox_Chemical_Select.TabIndex = 7;
            this.comboBox_Chemical_Select.SelectedIndexChanged += new System.EventHandler(this.comboBox_Chemical_Select_SelectedIndexChanged);
            // 
            // textBox_MolarMass
            // 
            this.textBox_MolarMass.Location = new System.Drawing.Point(99, 119);
            this.textBox_MolarMass.Name = "textBox_MolarMass";
            this.textBox_MolarMass.ReadOnly = true;
            this.textBox_MolarMass.Size = new System.Drawing.Size(138, 22);
            this.textBox_MolarMass.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "g/mol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Molar Mass:";
            // 
            // comboBox_Chemical
            // 
            this.comboBox_Chemical.FormattingEnabled = true;
            this.comboBox_Chemical.Items.AddRange(new object[] {
            "Common Gases and Liquids",
            "Salts",
            "Acids",
            "Alkali",
            "Organic",
            "Pure Metals",
            "Other"});
            this.comboBox_Chemical.Location = new System.Drawing.Point(99, 16);
            this.comboBox_Chemical.Name = "comboBox_Chemical";
            this.comboBox_Chemical.Size = new System.Drawing.Size(185, 24);
            this.comboBox_Chemical.TabIndex = 1;
            this.comboBox_Chemical.SelectedIndexChanged += new System.EventHandler(this.comboBox_Chemical_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chemical:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "pH - pOH Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.textBox_pH);
            this.panel11.Controls.Add(this.textBox_pOH);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.textBox_OH);
            this.panel11.Controls.Add(this.radioButton_OH);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.textBox_H);
            this.panel11.Controls.Add(this.radioButton_H);
            this.panel11.Location = new System.Drawing.Point(15, 51);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(378, 222);
            this.panel11.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "pH:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "pOH:";
            // 
            // textBox_pH
            // 
            this.textBox_pH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pH.Location = new System.Drawing.Point(91, 66);
            this.textBox_pH.Name = "textBox_pH";
            this.textBox_pH.ReadOnly = true;
            this.textBox_pH.Size = new System.Drawing.Size(138, 22);
            this.textBox_pH.TabIndex = 18;
            // 
            // textBox_pOH
            // 
            this.textBox_pOH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pOH.Location = new System.Drawing.Point(91, 175);
            this.textBox_pOH.Name = "textBox_pOH";
            this.textBox_pOH.ReadOnly = true;
            this.textBox_pOH.Size = new System.Drawing.Size(138, 22);
            this.textBox_pOH.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(235, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "M";
            // 
            // textBox_OH
            // 
            this.textBox_OH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_OH.Location = new System.Drawing.Point(91, 130);
            this.textBox_OH.Name = "textBox_OH";
            this.textBox_OH.ReadOnly = true;
            this.textBox_OH.Size = new System.Drawing.Size(138, 22);
            this.textBox_OH.TabIndex = 15;
            this.textBox_OH.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // radioButton_OH
            // 
            this.radioButton_OH.AutoSize = true;
            this.radioButton_OH.Location = new System.Drawing.Point(9, 130);
            this.radioButton_OH.Name = "radioButton_OH";
            this.radioButton_OH.Size = new System.Drawing.Size(60, 20);
            this.radioButton_OH.TabIndex = 14;
            this.radioButton_OH.TabStop = true;
            this.radioButton_OH.Text = "[OH-]";
            this.radioButton_OH.UseVisualStyleBackColor = true;
            this.radioButton_OH.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(235, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "M";
            // 
            // textBox_H
            // 
            this.textBox_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_H.Location = new System.Drawing.Point(91, 21);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.ReadOnly = true;
            this.textBox_H.Size = new System.Drawing.Size(138, 22);
            this.textBox_H.TabIndex = 12;
            this.textBox_H.TextChanged += new System.EventHandler(this.textBox_H_TextChanged);
            // 
            // radioButton_H
            // 
            this.radioButton_H.AutoSize = true;
            this.radioButton_H.Location = new System.Drawing.Point(9, 21);
            this.radioButton_H.Name = "radioButton_H";
            this.radioButton_H.Size = new System.Drawing.Size(53, 20);
            this.radioButton_H.TabIndex = 11;
            this.radioButton_H.TabStop = true;
            this.radioButton_H.Text = "[H+]";
            this.radioButton_H.UseVisualStyleBackColor = true;
            this.radioButton_H.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel12);
            this.tabPage4.Controls.Add(this.button_reset_ppm);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 383);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ppm Calculator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.radioButton_molarity);
            this.panel12.Controls.Add(this.radioButton_molarmass);
            this.panel12.Controls.Add(this.radioButton_ppm);
            this.panel12.Controls.Add(this.textBox_MolarMass_ppm);
            this.panel12.Controls.Add(this.comboBox_molarity_unit);
            this.panel12.Controls.Add(this.comboBox_ppm_unit);
            this.panel12.Controls.Add(this.textBox_Molarity);
            this.panel12.Controls.Add(this.textBox_ppm);
            this.panel12.Location = new System.Drawing.Point(15, 51);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(378, 142);
            this.panel12.TabIndex = 33;
            // 
            // radioButton_molarity
            // 
            this.radioButton_molarity.AutoSize = true;
            this.radioButton_molarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_molarity.Location = new System.Drawing.Point(10, 98);
            this.radioButton_molarity.Name = "radioButton_molarity";
            this.radioButton_molarity.Size = new System.Drawing.Size(84, 20);
            this.radioButton_molarity.TabIndex = 32;
            this.radioButton_molarity.TabStop = true;
            this.radioButton_molarity.Text = "Molarity  :";
            this.radioButton_molarity.UseVisualStyleBackColor = true;
            this.radioButton_molarity.CheckedChanged += new System.EventHandler(this.radioButton_molarity_CheckedChanged);
            // 
            // radioButton_molarmass
            // 
            this.radioButton_molarmass.AutoSize = true;
            this.radioButton_molarmass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_molarmass.Location = new System.Drawing.Point(10, 58);
            this.radioButton_molarmass.Name = "radioButton_molarmass";
            this.radioButton_molarmass.Size = new System.Drawing.Size(107, 20);
            this.radioButton_molarmass.TabIndex = 31;
            this.radioButton_molarmass.TabStop = true;
            this.radioButton_molarmass.Text = "Molar Mass  :";
            this.radioButton_molarmass.UseVisualStyleBackColor = true;
            this.radioButton_molarmass.CheckedChanged += new System.EventHandler(this.radioButton_molarmass_CheckedChanged);
            // 
            // radioButton_ppm
            // 
            this.radioButton_ppm.AutoSize = true;
            this.radioButton_ppm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_ppm.Location = new System.Drawing.Point(10, 20);
            this.radioButton_ppm.Name = "radioButton_ppm";
            this.radioButton_ppm.Size = new System.Drawing.Size(64, 20);
            this.radioButton_ppm.TabIndex = 29;
            this.radioButton_ppm.TabStop = true;
            this.radioButton_ppm.Text = "ppm  :";
            this.radioButton_ppm.UseVisualStyleBackColor = true;
            this.radioButton_ppm.CheckedChanged += new System.EventHandler(this.radioButton_ppm_CheckedChanged);
            // 
            // textBox_MolarMass_ppm
            // 
            this.textBox_MolarMass_ppm.Location = new System.Drawing.Point(118, 57);
            this.textBox_MolarMass_ppm.Name = "textBox_MolarMass_ppm";
            this.textBox_MolarMass_ppm.ReadOnly = true;
            this.textBox_MolarMass_ppm.Size = new System.Drawing.Size(176, 22);
            this.textBox_MolarMass_ppm.TabIndex = 30;
            this.textBox_MolarMass_ppm.TextChanged += new System.EventHandler(this.textBox_MolarMass_ppm_TextChanged);
            // 
            // comboBox_molarity_unit
            // 
            this.comboBox_molarity_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_molarity_unit.FormattingEnabled = true;
            this.comboBox_molarity_unit.Location = new System.Drawing.Point(300, 96);
            this.comboBox_molarity_unit.Name = "comboBox_molarity_unit";
            this.comboBox_molarity_unit.Size = new System.Drawing.Size(69, 24);
            this.comboBox_molarity_unit.TabIndex = 28;
            this.comboBox_molarity_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox_molarity_unit_SelectedIndexChanged);
            // 
            // comboBox_ppm_unit
            // 
            this.comboBox_ppm_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ppm_unit.FormattingEnabled = true;
            this.comboBox_ppm_unit.Location = new System.Drawing.Point(300, 18);
            this.comboBox_ppm_unit.Name = "comboBox_ppm_unit";
            this.comboBox_ppm_unit.Size = new System.Drawing.Size(69, 24);
            this.comboBox_ppm_unit.TabIndex = 27;
            this.comboBox_ppm_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox_ppm_unit_SelectedIndexChanged);
            // 
            // textBox_Molarity
            // 
            this.textBox_Molarity.Location = new System.Drawing.Point(118, 96);
            this.textBox_Molarity.Name = "textBox_Molarity";
            this.textBox_Molarity.ReadOnly = true;
            this.textBox_Molarity.Size = new System.Drawing.Size(176, 22);
            this.textBox_Molarity.TabIndex = 26;
            this.textBox_Molarity.TextChanged += new System.EventHandler(this.textBox_Molarity_TextChanged);
            // 
            // textBox_ppm
            // 
            this.textBox_ppm.Location = new System.Drawing.Point(118, 18);
            this.textBox_ppm.Name = "textBox_ppm";
            this.textBox_ppm.ReadOnly = true;
            this.textBox_ppm.Size = new System.Drawing.Size(176, 22);
            this.textBox_ppm.TabIndex = 25;
            this.textBox_ppm.TextChanged += new System.EventHandler(this.textBox_ppm_TextChanged);
            // 
            // button_reset_ppm
            // 
            this.button_reset_ppm.Location = new System.Drawing.Point(9, 337);
            this.button_reset_ppm.Name = "button_reset_ppm";
            this.button_reset_ppm.Size = new System.Drawing.Size(104, 39);
            this.button_reset_ppm.TabIndex = 4;
            this.button_reset_ppm.Text = "Reset";
            this.button_reset_ppm.UseVisualStyleBackColor = true;
            this.button_reset_ppm.Click += new System.EventHandler(this.button_reset_ppm_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.panel13);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(409, 383);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Solution Diluation Calculator";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 39);
            this.button6.TabIndex = 29;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tbFinVol);
            this.panel13.Controls.Add(this.tbFinConc);
            this.panel13.Controls.Add(this.tbInitVol);
            this.panel13.Controls.Add(this.tbInitConc);
            this.panel13.Controls.Add(this.rbFinVol);
            this.panel13.Controls.Add(this.rbFinConc);
            this.panel13.Controls.Add(this.rbInitVol);
            this.panel13.Controls.Add(this.rbInitConc);
            this.panel13.Location = new System.Drawing.Point(15, 40);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(378, 170);
            this.panel13.TabIndex = 28;
            // 
            // tbFinVol
            // 
            this.tbFinVol.Location = new System.Drawing.Point(201, 125);
            this.tbFinVol.Name = "tbFinVol";
            this.tbFinVol.ReadOnly = true;
            this.tbFinVol.Size = new System.Drawing.Size(138, 22);
            this.tbFinVol.TabIndex = 27;
            this.tbFinVol.TextChanged += new System.EventHandler(this.tbFinVol_TextChanged);
            // 
            // tbFinConc
            // 
            this.tbFinConc.Location = new System.Drawing.Point(201, 88);
            this.tbFinConc.Name = "tbFinConc";
            this.tbFinConc.ReadOnly = true;
            this.tbFinConc.Size = new System.Drawing.Size(138, 22);
            this.tbFinConc.TabIndex = 26;
            this.tbFinConc.TextChanged += new System.EventHandler(this.tbFinConc_TextChanged);
            // 
            // tbInitVol
            // 
            this.tbInitVol.Location = new System.Drawing.Point(201, 53);
            this.tbInitVol.Name = "tbInitVol";
            this.tbInitVol.ReadOnly = true;
            this.tbInitVol.Size = new System.Drawing.Size(138, 22);
            this.tbInitVol.TabIndex = 25;
            this.tbInitVol.TextChanged += new System.EventHandler(this.tbInitVol_TextChanged);
            // 
            // tbInitConc
            // 
            this.tbInitConc.Location = new System.Drawing.Point(201, 18);
            this.tbInitConc.Name = "tbInitConc";
            this.tbInitConc.ReadOnly = true;
            this.tbInitConc.Size = new System.Drawing.Size(138, 22);
            this.tbInitConc.TabIndex = 24;
            this.tbInitConc.TextChanged += new System.EventHandler(this.tbInitConc_TextChanged);
            // 
            // rbFinVol
            // 
            this.rbFinVol.AutoSize = true;
            this.rbFinVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFinVol.Location = new System.Drawing.Point(22, 126);
            this.rbFinVol.Name = "rbFinVol";
            this.rbFinVol.Size = new System.Drawing.Size(148, 20);
            this.rbFinVol.TabIndex = 23;
            this.rbFinVol.TabStop = true;
            this.rbFinVol.Text = "Final Volume             :";
            this.rbFinVol.UseVisualStyleBackColor = true;
            this.rbFinVol.CheckedChanged += new System.EventHandler(this.rbFinVol_CheckedChanged);
            // 
            // rbFinConc
            // 
            this.rbFinConc.AutoSize = true;
            this.rbFinConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFinConc.Location = new System.Drawing.Point(22, 89);
            this.rbFinConc.Name = "rbFinConc";
            this.rbFinConc.Size = new System.Drawing.Size(154, 20);
            this.rbFinConc.TabIndex = 22;
            this.rbFinConc.TabStop = true;
            this.rbFinConc.Text = "Final Concentration   :";
            this.rbFinConc.UseVisualStyleBackColor = true;
            this.rbFinConc.CheckedChanged += new System.EventHandler(this.rbFinConc_CheckedChanged);
            // 
            // rbInitVol
            // 
            this.rbInitVol.AutoSize = true;
            this.rbInitVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInitVol.Location = new System.Drawing.Point(24, 54);
            this.rbInitVol.Name = "rbInitVol";
            this.rbInitVol.Size = new System.Drawing.Size(146, 20);
            this.rbInitVol.TabIndex = 21;
            this.rbInitVol.TabStop = true;
            this.rbInitVol.Text = "Initial Volume            :";
            this.rbInitVol.UseVisualStyleBackColor = true;
            this.rbInitVol.CheckedChanged += new System.EventHandler(this.rbInitVol_CheckedChanged);
            // 
            // rbInitConc
            // 
            this.rbInitConc.AutoSize = true;
            this.rbInitConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInitConc.Location = new System.Drawing.Point(24, 19);
            this.rbInitConc.Name = "rbInitConc";
            this.rbInitConc.Size = new System.Drawing.Size(152, 20);
            this.rbInitConc.TabIndex = 20;
            this.rbInitConc.TabStop = true;
            this.rbInitConc.Text = "Initial Concentration  :";
            this.rbInitConc.UseVisualStyleBackColor = true;
            this.rbInitConc.CheckedChanged += new System.EventHandler(this.rbInitConc_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // psCommSimpleWinForms1
            // 
            this.psCommSimpleWinForms1.EnableBluetooth = false;
            this.psCommSimpleWinForms1.EnableSerialPort = false;
            this.psCommSimpleWinForms1.Parent = this;
            this.psCommSimpleWinForms1.ReceiveStatus += new PalmSens.Comm.StatusEventHandler(this.psCommSimpleWinForms1_ReceiveStatus);
            this.psCommSimpleWinForms1.MeasurementStarted += new System.EventHandler(this.psCommSimpleWinForms1_MeasurementStarted);
            this.psCommSimpleWinForms1.MeasurementEnded += new System.EventHandler<System.Exception>(this.psCommSimpleWinForms1_MeasurementEnded);
            this.psCommSimpleWinForms1.SimpleCurveStartReceivingData += new PalmSens.Core.Simplified.PSCommSimple.SimpleCurveStartReceivingDataHandler(this.psCommSimpleWinForms1_SimpleCurveStartReceivingData);
            this.psCommSimpleWinForms1.StateChanged += new PalmSens.Comm.CommManager.StatusChangedEventHandler(this.psCommSimpleWinForms1_StateChanged);
            this.psCommSimpleWinForms1.Disconnected += new PalmSens.Core.Simplified.DisconnectedEventHandler(this.psCommSimpleWinForms1_Disconnected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1482, 885);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).EndInit();
            this.panel14.ResumeLayout(false);
            this.PlotSettings.ResumeLayout(false);
            this.PlotSettings.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeviceStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCurrentRange;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPotential;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox_Chemical;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioButton_Mass;
        private System.Windows.Forms.RadioButton radioButton_NumberofMoles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_NumberofMoles;
        private System.Windows.Forms.TextBox textBox_Mass;
        private System.Windows.Forms.TextBox textBox_MolarMass;
        private System.Windows.Forms.ComboBox comboBox_Chemical_Select;
        private System.Windows.Forms.Button btnReset_GramsToMoleCalc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.RadioButton radioButton_H;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_OH;
        private System.Windows.Forms.RadioButton radioButton_OH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_pH;
        private System.Windows.Forms.TextBox textBox_pOH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button_reset_ppm;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tbFinVol;
        private System.Windows.Forms.TextBox tbFinConc;
        private System.Windows.Forms.TextBox tbInitVol;
        private System.Windows.Forms.TextBox tbInitConc;
        private System.Windows.Forms.RadioButton rbFinVol;
        private System.Windows.Forms.RadioButton rbFinConc;
        private System.Windows.Forms.RadioButton rbInitVol;
        private System.Windows.Forms.RadioButton rbInitConc;
        private PalmSens.Core.Simplified.WinForms.PSCommSimpleWinForms psCommSimpleWinForms1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radioButton_molarity;
        private System.Windows.Forms.RadioButton radioButton_molarmass;
        private System.Windows.Forms.RadioButton radioButton_ppm;
        private System.Windows.Forms.TextBox textBox_MolarMass_ppm;
        public System.Windows.Forms.ComboBox comboBox_molarity_unit;
        public System.Windows.Forms.ComboBox comboBox_ppm_unit;
        private System.Windows.Forms.TextBox textBox_Molarity;
        private System.Windows.Forms.TextBox textBox_ppm;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnSaveSetting;
        public System.Windows.Forms.ComboBox measurement_type;
        private System.Windows.Forms.DataGridView dgvMeasurement;
        private SDKPlot.WinForms.Plot plot;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDataViewSave;
        private System.Windows.Forms.MenuStrip PlotSettings;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGraphAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peakDetectationPlot;
        private System.Windows.Forms.ToolStripMenuItem movingAvargeBaselineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMILOP;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlotZoomSet;
        private System.Windows.Forms.ToolStripMenuItem lODLOQCalculationTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIdrawHas;
        private System.Windows.Forms.ToolStripMenuItem TSMILoadPeakLOD;
        private System.Windows.Forms.ToolStripMenuItem exportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
    }
}

