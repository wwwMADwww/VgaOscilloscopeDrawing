﻿namespace vgarender
{
    partial class MainForm
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
            this.startB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mapGb = new System.Windows.Forms.GroupBox();
            this.vgachannelClearAllB = new System.Windows.Forms.Button();
            this.vgachannel1BitBlueChb = new System.Windows.Forms.CheckBox();
            this.vgachannel1BitGreenChb = new System.Windows.Forms.CheckBox();
            this.vgachannel1BitRedChb = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vgachannelinvertRedChb = new System.Windows.Forms.CheckBox();
            this.channelMapRedCb = new System.Windows.Forms.ComboBox();
            this.vgachannelinvertGreenChb = new System.Windows.Forms.CheckBox();
            this.channelMapGreenCb = new System.Windows.Forms.ComboBox();
            this.vgachannelinvertBlueChb = new System.Windows.Forms.CheckBox();
            this.channelMapBlueCb = new System.Windows.Forms.ComboBox();
            this.swapxyB = new System.Windows.Forms.Button();
            this.sourceGb = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.framesdirpathed = new System.Windows.Forms.TextBox();
            this.selectFramesPathB = new System.Windows.Forms.Button();
            this.pathFileRb = new System.Windows.Forms.RadioButton();
            this.pathDirRb = new System.Windows.Forms.RadioButton();
            this.swapxyChb = new System.Windows.Forms.CheckBox();
            this.outputGb = new System.Windows.Forms.GroupBox();
            this.outputOrigArB = new System.Windows.Forms.Button();
            this.outputBoundsBottomUd = new System.Windows.Forms.NumericUpDown();
            this.outputBoundsRightUd = new System.Windows.Forms.NumericUpDown();
            this.outputBoundsLeftUd = new System.Windows.Forms.NumericUpDown();
            this.outputBoundsResetB = new System.Windows.Forms.Button();
            this.outputBoundsTopUd = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.animationFpsUd = new System.Windows.Forms.NumericUpDown();
            this.vsyncB = new System.Windows.Forms.Button();
            this.nofpsB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitorListCb = new System.Windows.Forms.ComboBox();
            this.refreshMonitoListB = new System.Windows.Forms.Button();
            this.refreshrateud = new System.Windows.Forms.NumericUpDown();
            this.disableAntialiasingChb = new System.Windows.Forms.CheckBox();
            this.fpslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentmonitorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainWinTopmostChb = new System.Windows.Forms.CheckBox();
            this.drawWinFullscreenChb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ditherOrderedMatrixUd = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ditherOrderedShiftYUd = new System.Windows.Forms.NumericUpDown();
            this.ditherOrderedShiftXUd = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.oneBitMethodPwmRb = new System.Windows.Forms.RadioButton();
            this.ditherOrderedShiftFrameUd = new System.Windows.Forms.NumericUpDown();
            this.oneBitMethodOrderedRb = new System.Windows.Forms.RadioButton();
            this.oneBitMethodRandomRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.toneThreshWhiteUd = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.toneThreshBlackUd = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gammaUd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grayscaleDefB = new System.Windows.Forms.Button();
            this.grayscaleBlueUd = new System.Windows.Forms.NumericUpDown();
            this.grayscaleGreenUd = new System.Windows.Forms.NumericUpDown();
            this.grayscaleRedUd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.blankSwapEveryYUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapEveryXUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapEveryRb = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.blankSwapAfterYUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapRandomRb = new System.Windows.Forms.RadioButton();
            this.blankSwapAfterRb = new System.Windows.Forms.RadioButton();
            this.blankSwapAfterXUd = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.blankValueTopUd = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.blankValueBottomUd = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mapGb.SuspendLayout();
            this.sourceGb.SuspendLayout();
            this.outputGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsBottomUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsRightUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsLeftUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsTopUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationFpsUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshrateud)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedMatrixUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftFrameUd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshWhiteUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshBlackUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBlueUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleGreenUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleRedUd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueTopUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueBottomUd)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(564, 44);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 23);
            this.startB.TabIndex = 8;
            this.startB.Text = "(re)start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(483, 44);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(75, 23);
            this.stopB.TabIndex = 7;
            this.stopB.Text = "stop";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "dir";
            this.openFileDialog1.Filter = "BMP, PNG, JPG, GIF|*.bmp;*.png;*jpg;*.gif|All files|*.*";
            this.openFileDialog1.ValidateNames = false;
            // 
            // mapGb
            // 
            this.mapGb.Controls.Add(this.vgachannelClearAllB);
            this.mapGb.Controls.Add(this.vgachannel1BitBlueChb);
            this.mapGb.Controls.Add(this.vgachannel1BitGreenChb);
            this.mapGb.Controls.Add(this.vgachannel1BitRedChb);
            this.mapGb.Controls.Add(this.label8);
            this.mapGb.Controls.Add(this.label7);
            this.mapGb.Controls.Add(this.label6);
            this.mapGb.Controls.Add(this.vgachannelinvertRedChb);
            this.mapGb.Controls.Add(this.channelMapRedCb);
            this.mapGb.Controls.Add(this.vgachannelinvertGreenChb);
            this.mapGb.Controls.Add(this.channelMapGreenCb);
            this.mapGb.Controls.Add(this.vgachannelinvertBlueChb);
            this.mapGb.Controls.Add(this.channelMapBlueCb);
            this.mapGb.Controls.Add(this.swapxyB);
            this.mapGb.Location = new System.Drawing.Point(12, 106);
            this.mapGb.Name = "mapGb";
            this.mapGb.Size = new System.Drawing.Size(321, 112);
            this.mapGb.TabIndex = 1;
            this.mapGb.TabStop = false;
            this.mapGb.Text = "VGA channel mapping";
            // 
            // vgachannelClearAllB
            // 
            this.vgachannelClearAllB.Location = new System.Drawing.Point(241, 83);
            this.vgachannelClearAllB.Name = "vgachannelClearAllB";
            this.vgachannelClearAllB.Size = new System.Drawing.Size(71, 23);
            this.vgachannelClearAllB.TabIndex = 23;
            this.vgachannelClearAllB.Text = "Clear all";
            this.vgachannelClearAllB.UseVisualStyleBackColor = true;
            // 
            // vgachannel1BitBlueChb
            // 
            this.vgachannel1BitBlueChb.AutoSize = true;
            this.vgachannel1BitBlueChb.Location = new System.Drawing.Point(164, 89);
            this.vgachannel1BitBlueChb.Name = "vgachannel1BitBlueChb";
            this.vgachannel1BitBlueChb.Size = new System.Drawing.Size(72, 17);
            this.vgachannel1BitBlueChb.TabIndex = 22;
            this.vgachannel1BitBlueChb.Text = "1 bit color";
            this.vgachannel1BitBlueChb.UseVisualStyleBackColor = true;
            // 
            // vgachannel1BitGreenChb
            // 
            this.vgachannel1BitGreenChb.AutoSize = true;
            this.vgachannel1BitGreenChb.Location = new System.Drawing.Point(84, 89);
            this.vgachannel1BitGreenChb.Name = "vgachannel1BitGreenChb";
            this.vgachannel1BitGreenChb.Size = new System.Drawing.Size(72, 17);
            this.vgachannel1BitGreenChb.TabIndex = 21;
            this.vgachannel1BitGreenChb.Text = "1 bit color";
            this.vgachannel1BitGreenChb.UseVisualStyleBackColor = true;
            // 
            // vgachannel1BitRedChb
            // 
            this.vgachannel1BitRedChb.AutoSize = true;
            this.vgachannel1BitRedChb.Location = new System.Drawing.Point(6, 89);
            this.vgachannel1BitRedChb.Name = "vgachannel1BitRedChb";
            this.vgachannel1BitRedChb.Size = new System.Drawing.Size(72, 17);
            this.vgachannel1BitRedChb.TabIndex = 20;
            this.vgachannel1BitRedChb.Text = "1 bit color";
            this.vgachannel1BitRedChb.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(161, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Blue";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(81, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Green";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Red";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vgachannelinvertRedChb
            // 
            this.vgachannelinvertRedChb.AutoSize = true;
            this.vgachannelinvertRedChb.Location = new System.Drawing.Point(6, 66);
            this.vgachannelinvertRedChb.Name = "vgachannelinvertRedChb";
            this.vgachannelinvertRedChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertRedChb.TabIndex = 1;
            this.vgachannelinvertRedChb.Text = "Invert";
            this.vgachannelinvertRedChb.UseVisualStyleBackColor = true;
            // 
            // channelMapRedCb
            // 
            this.channelMapRedCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapRedCb.FormattingEnabled = true;
            this.channelMapRedCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Gray color"});
            this.channelMapRedCb.Location = new System.Drawing.Point(6, 39);
            this.channelMapRedCb.Name = "channelMapRedCb";
            this.channelMapRedCb.Size = new System.Drawing.Size(72, 21);
            this.channelMapRedCb.TabIndex = 2;
            // 
            // vgachannelinvertGreenChb
            // 
            this.vgachannelinvertGreenChb.AutoSize = true;
            this.vgachannelinvertGreenChb.Location = new System.Drawing.Point(84, 67);
            this.vgachannelinvertGreenChb.Name = "vgachannelinvertGreenChb";
            this.vgachannelinvertGreenChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertGreenChb.TabIndex = 3;
            this.vgachannelinvertGreenChb.Text = "Invert";
            this.vgachannelinvertGreenChb.UseVisualStyleBackColor = true;
            // 
            // channelMapGreenCb
            // 
            this.channelMapGreenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapGreenCb.FormattingEnabled = true;
            this.channelMapGreenCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Gray color"});
            this.channelMapGreenCb.Location = new System.Drawing.Point(84, 39);
            this.channelMapGreenCb.Name = "channelMapGreenCb";
            this.channelMapGreenCb.Size = new System.Drawing.Size(72, 21);
            this.channelMapGreenCb.TabIndex = 4;
            // 
            // vgachannelinvertBlueChb
            // 
            this.vgachannelinvertBlueChb.AutoSize = true;
            this.vgachannelinvertBlueChb.Location = new System.Drawing.Point(164, 66);
            this.vgachannelinvertBlueChb.Name = "vgachannelinvertBlueChb";
            this.vgachannelinvertBlueChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertBlueChb.TabIndex = 5;
            this.vgachannelinvertBlueChb.Text = "Invert";
            this.vgachannelinvertBlueChb.UseVisualStyleBackColor = true;
            // 
            // channelMapBlueCb
            // 
            this.channelMapBlueCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapBlueCb.FormattingEnabled = true;
            this.channelMapBlueCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Gray color"});
            this.channelMapBlueCb.Location = new System.Drawing.Point(163, 39);
            this.channelMapBlueCb.Name = "channelMapBlueCb";
            this.channelMapBlueCb.Size = new System.Drawing.Size(72, 21);
            this.channelMapBlueCb.TabIndex = 6;
            // 
            // swapxyB
            // 
            this.swapxyB.Location = new System.Drawing.Point(241, 37);
            this.swapxyB.Name = "swapxyB";
            this.swapxyB.Size = new System.Drawing.Size(71, 23);
            this.swapxyB.TabIndex = 7;
            this.swapxyB.Text = "Swap X Y";
            this.swapxyB.UseVisualStyleBackColor = true;
            this.swapxyB.Click += new System.EventHandler(this.swapxyB_Click);
            // 
            // sourceGb
            // 
            this.sourceGb.Controls.Add(this.label3);
            this.sourceGb.Controls.Add(this.framesdirpathed);
            this.sourceGb.Controls.Add(this.selectFramesPathB);
            this.sourceGb.Controls.Add(this.pathFileRb);
            this.sourceGb.Controls.Add(this.pathDirRb);
            this.sourceGb.Controls.Add(this.swapxyChb);
            this.sourceGb.Location = new System.Drawing.Point(12, 12);
            this.sourceGb.Name = "sourceGb";
            this.sourceGb.Size = new System.Drawing.Size(321, 91);
            this.sourceGb.TabIndex = 0;
            this.sourceGb.TabStop = false;
            this.sourceGb.Text = "Source images";
            this.sourceGb.Enter += new System.EventHandler(this.sourceGb_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path";
            // 
            // framesdirpathed
            // 
            this.framesdirpathed.Location = new System.Drawing.Point(44, 19);
            this.framesdirpathed.MaxLength = 260;
            this.framesdirpathed.Name = "framesdirpathed";
            this.framesdirpathed.Size = new System.Drawing.Size(187, 20);
            this.framesdirpathed.TabIndex = 0;
            // 
            // selectFramesPathB
            // 
            this.selectFramesPathB.Location = new System.Drawing.Point(237, 17);
            this.selectFramesPathB.Name = "selectFramesPathB";
            this.selectFramesPathB.Size = new System.Drawing.Size(75, 23);
            this.selectFramesPathB.TabIndex = 1;
            this.selectFramesPathB.Text = "Select...";
            this.selectFramesPathB.UseVisualStyleBackColor = true;
            this.selectFramesPathB.Click += new System.EventHandler(this.selectFramesPathB_Click);
            // 
            // pathFileRb
            // 
            this.pathFileRb.AutoSize = true;
            this.pathFileRb.Checked = true;
            this.pathFileRb.Location = new System.Drawing.Point(9, 45);
            this.pathFileRb.Name = "pathFileRb";
            this.pathFileRb.Size = new System.Drawing.Size(105, 17);
            this.pathFileRb.TabIndex = 2;
            this.pathFileRb.TabStop = true;
            this.pathFileRb.Text = "Selected file only";
            this.pathFileRb.UseVisualStyleBackColor = true;
            // 
            // pathDirRb
            // 
            this.pathDirRb.AutoSize = true;
            this.pathDirRb.Location = new System.Drawing.Point(120, 45);
            this.pathDirRb.Name = "pathDirRb";
            this.pathDirRb.Size = new System.Drawing.Size(111, 17);
            this.pathDirRb.TabIndex = 3;
            this.pathDirRb.Text = "All files in directory";
            this.pathDirRb.UseVisualStyleBackColor = true;
            // 
            // swapxyChb
            // 
            this.swapxyChb.AutoSize = true;
            this.swapxyChb.Location = new System.Drawing.Point(9, 68);
            this.swapxyChb.Name = "swapxyChb";
            this.swapxyChb.Size = new System.Drawing.Size(195, 17);
            this.swapxyChb.TabIndex = 4;
            this.swapxyChb.Text = "Rotate image 90 degrees clockwise";
            this.swapxyChb.UseVisualStyleBackColor = true;
            // 
            // outputGb
            // 
            this.outputGb.Controls.Add(this.outputOrigArB);
            this.outputGb.Controls.Add(this.outputBoundsBottomUd);
            this.outputGb.Controls.Add(this.outputBoundsRightUd);
            this.outputGb.Controls.Add(this.outputBoundsLeftUd);
            this.outputGb.Controls.Add(this.outputBoundsResetB);
            this.outputGb.Controls.Add(this.outputBoundsTopUd);
            this.outputGb.Controls.Add(this.label19);
            this.outputGb.Controls.Add(this.label9);
            this.outputGb.Controls.Add(this.animationFpsUd);
            this.outputGb.Controls.Add(this.vsyncB);
            this.outputGb.Controls.Add(this.nofpsB);
            this.outputGb.Controls.Add(this.label4);
            this.outputGb.Controls.Add(this.label1);
            this.outputGb.Controls.Add(this.monitorListCb);
            this.outputGb.Controls.Add(this.refreshMonitoListB);
            this.outputGb.Controls.Add(this.refreshrateud);
            this.outputGb.Controls.Add(this.disableAntialiasingChb);
            this.outputGb.Location = new System.Drawing.Point(12, 224);
            this.outputGb.Name = "outputGb";
            this.outputGb.Size = new System.Drawing.Size(321, 224);
            this.outputGb.TabIndex = 2;
            this.outputGb.TabStop = false;
            this.outputGb.Text = "Output";
            // 
            // outputOrigArB
            // 
            this.outputOrigArB.Location = new System.Drawing.Point(198, 187);
            this.outputOrigArB.Name = "outputOrigArB";
            this.outputOrigArB.Size = new System.Drawing.Size(114, 23);
            this.outputOrigArB.TabIndex = 56;
            this.outputOrigArB.Text = "Original aspect ratio";
            this.outputOrigArB.UseVisualStyleBackColor = true;
            // 
            // outputBoundsBottomUd
            // 
            this.outputBoundsBottomUd.DecimalPlaces = 4;
            this.outputBoundsBottomUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outputBoundsBottomUd.Location = new System.Drawing.Point(51, 190);
            this.outputBoundsBottomUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsBottomUd.Name = "outputBoundsBottomUd";
            this.outputBoundsBottomUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsBottomUd.TabIndex = 55;
            this.outputBoundsBottomUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // outputBoundsRightUd
            // 
            this.outputBoundsRightUd.DecimalPlaces = 4;
            this.outputBoundsRightUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outputBoundsRightUd.Location = new System.Drawing.Point(84, 164);
            this.outputBoundsRightUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsRightUd.Name = "outputBoundsRightUd";
            this.outputBoundsRightUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsRightUd.TabIndex = 54;
            this.outputBoundsRightUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // outputBoundsLeftUd
            // 
            this.outputBoundsLeftUd.DecimalPlaces = 4;
            this.outputBoundsLeftUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outputBoundsLeftUd.Location = new System.Drawing.Point(9, 164);
            this.outputBoundsLeftUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsLeftUd.Name = "outputBoundsLeftUd";
            this.outputBoundsLeftUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsLeftUd.TabIndex = 53;
            // 
            // outputBoundsResetB
            // 
            this.outputBoundsResetB.Location = new System.Drawing.Point(198, 161);
            this.outputBoundsResetB.Name = "outputBoundsResetB";
            this.outputBoundsResetB.Size = new System.Drawing.Size(114, 23);
            this.outputBoundsResetB.TabIndex = 52;
            this.outputBoundsResetB.Text = "Reset";
            this.outputBoundsResetB.UseVisualStyleBackColor = true;
            // 
            // outputBoundsTopUd
            // 
            this.outputBoundsTopUd.DecimalPlaces = 4;
            this.outputBoundsTopUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outputBoundsTopUd.Location = new System.Drawing.Point(51, 138);
            this.outputBoundsTopUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsTopUd.Name = "outputBoundsTopUd";
            this.outputBoundsTopUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsTopUd.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Output bounds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Animation speed (FPS)";
            // 
            // animationFpsUd
            // 
            this.animationFpsUd.Location = new System.Drawing.Point(126, 73);
            this.animationFpsUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.animationFpsUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.animationFpsUd.Name = "animationFpsUd";
            this.animationFpsUd.Size = new System.Drawing.Size(105, 20);
            this.animationFpsUd.TabIndex = 48;
            this.animationFpsUd.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // vsyncB
            // 
            this.vsyncB.Location = new System.Drawing.Point(237, 43);
            this.vsyncB.Name = "vsyncB";
            this.vsyncB.Size = new System.Drawing.Size(51, 23);
            this.vsyncB.TabIndex = 47;
            this.vsyncB.Text = "VSync";
            this.vsyncB.UseVisualStyleBackColor = true;
            this.vsyncB.Click += new System.EventHandler(this.vsyncB_Click);
            // 
            // nofpsB
            // 
            this.nofpsB.Location = new System.Drawing.Point(294, 43);
            this.nofpsB.Name = "nofpsB";
            this.nofpsB.Size = new System.Drawing.Size(18, 23);
            this.nofpsB.TabIndex = 46;
            this.nofpsB.Text = "X";
            this.nofpsB.UseVisualStyleBackColor = true;
            this.nofpsB.Click += new System.EventHandler(this.nofpsB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Refresh rate (FPS)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Monitor to draw on";
            // 
            // monitorListCb
            // 
            this.monitorListCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorListCb.FormattingEnabled = true;
            this.monitorListCb.Location = new System.Drawing.Point(126, 19);
            this.monitorListCb.Name = "monitorListCb";
            this.monitorListCb.Size = new System.Drawing.Size(105, 21);
            this.monitorListCb.TabIndex = 0;
            // 
            // refreshMonitoListB
            // 
            this.refreshMonitoListB.Location = new System.Drawing.Point(237, 17);
            this.refreshMonitoListB.Name = "refreshMonitoListB";
            this.refreshMonitoListB.Size = new System.Drawing.Size(75, 23);
            this.refreshMonitoListB.TabIndex = 1;
            this.refreshMonitoListB.Text = "Refresh list";
            this.refreshMonitoListB.UseVisualStyleBackColor = true;
            this.refreshMonitoListB.Click += new System.EventHandler(this.refreshMonitoListB_Click);
            // 
            // refreshrateud
            // 
            this.refreshrateud.Location = new System.Drawing.Point(126, 46);
            this.refreshrateud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.refreshrateud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.refreshrateud.Name = "refreshrateud";
            this.refreshrateud.Size = new System.Drawing.Size(105, 20);
            this.refreshrateud.TabIndex = 2;
            this.refreshrateud.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.refreshrateud.ValueChanged += new System.EventHandler(this.refreshrateud_ValueChanged);
            // 
            // disableAntialiasingChb
            // 
            this.disableAntialiasingChb.AutoSize = true;
            this.disableAntialiasingChb.Location = new System.Drawing.Point(9, 99);
            this.disableAntialiasingChb.Name = "disableAntialiasingChb";
            this.disableAntialiasingChb.Size = new System.Drawing.Size(116, 17);
            this.disableAntialiasingChb.TabIndex = 3;
            this.disableAntialiasingChb.Text = "Disable antialiasing";
            this.disableAntialiasingChb.UseVisualStyleBackColor = true;
            // 
            // fpslabel
            // 
            this.fpslabel.AutoSize = true;
            this.fpslabel.Location = new System.Drawing.Point(123, 49);
            this.fpslabel.Name = "fpslabel";
            this.fpslabel.Size = new System.Drawing.Size(33, 13);
            this.fpslabel.TabIndex = 2;
            this.fpslabel.Text = "F P S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Current refresh rate ~";
            // 
            // currentmonitorlabel
            // 
            this.currentmonitorlabel.AutoSize = true;
            this.currentmonitorlabel.Location = new System.Drawing.Point(265, 49);
            this.currentmonitorlabel.Name = "currentmonitorlabel";
            this.currentmonitorlabel.Size = new System.Drawing.Size(76, 13);
            this.currentmonitorlabel.TabIndex = 43;
            this.currentmonitorlabel.Text = "M O N I T O R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Current monitor";
            // 
            // mainWinTopmostChb
            // 
            this.mainWinTopmostChb.AutoSize = true;
            this.mainWinTopmostChb.Checked = true;
            this.mainWinTopmostChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainWinTopmostChb.Location = new System.Drawing.Point(9, 19);
            this.mainWinTopmostChb.Name = "mainWinTopmostChb";
            this.mainWinTopmostChb.Size = new System.Drawing.Size(121, 17);
            this.mainWinTopmostChb.TabIndex = 5;
            this.mainWinTopmostChb.Text = "Main window on top";
            this.mainWinTopmostChb.UseVisualStyleBackColor = true;
            this.mainWinTopmostChb.CheckedChanged += new System.EventHandler(this.mainWinTopmostChb_CheckedChanged);
            // 
            // drawWinFullscreenChb
            // 
            this.drawWinFullscreenChb.AutoSize = true;
            this.drawWinFullscreenChb.Checked = true;
            this.drawWinFullscreenChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawWinFullscreenChb.Location = new System.Drawing.Point(145, 19);
            this.drawWinFullscreenChb.Name = "drawWinFullscreenChb";
            this.drawWinFullscreenChb.Size = new System.Drawing.Size(113, 17);
            this.drawWinFullscreenChb.TabIndex = 6;
            this.drawWinFullscreenChb.Text = "Drawing fullscreen";
            this.drawWinFullscreenChb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ditherOrderedMatrixUd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.ditherOrderedShiftYUd);
            this.groupBox1.Controls.Add(this.ditherOrderedShiftXUd);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.oneBitMethodPwmRb);
            this.groupBox1.Controls.Add(this.ditherOrderedShiftFrameUd);
            this.groupBox1.Controls.Add(this.oneBitMethodOrderedRb);
            this.groupBox1.Controls.Add(this.oneBitMethodRandomRb);
            this.groupBox1.Location = new System.Drawing.Point(339, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 bit encoding method";
            // 
            // ditherOrderedMatrixUd
            // 
            this.ditherOrderedMatrixUd.Location = new System.Drawing.Point(253, 43);
            this.ditherOrderedMatrixUd.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.ditherOrderedMatrixUd.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ditherOrderedMatrixUd.Name = "ditherOrderedMatrixUd";
            this.ditherOrderedMatrixUd.Size = new System.Drawing.Size(59, 20);
            this.ditherOrderedMatrixUd.TabIndex = 38;
            this.ditherOrderedMatrixUd.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Matrix size";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(233, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Y";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(136, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "X";
            // 
            // ditherOrderedShiftYUd
            // 
            this.ditherOrderedShiftYUd.DecimalPlaces = 4;
            this.ditherOrderedShiftYUd.Location = new System.Drawing.Point(253, 95);
            this.ditherOrderedShiftYUd.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ditherOrderedShiftYUd.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            -2147483648});
            this.ditherOrderedShiftYUd.Name = "ditherOrderedShiftYUd";
            this.ditherOrderedShiftYUd.Size = new System.Drawing.Size(59, 20);
            this.ditherOrderedShiftYUd.TabIndex = 20;
            this.ditherOrderedShiftYUd.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // ditherOrderedShiftXUd
            // 
            this.ditherOrderedShiftXUd.DecimalPlaces = 4;
            this.ditherOrderedShiftXUd.Location = new System.Drawing.Point(156, 95);
            this.ditherOrderedShiftXUd.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ditherOrderedShiftXUd.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            -2147483648});
            this.ditherOrderedShiftXUd.Name = "ditherOrderedShiftXUd";
            this.ditherOrderedShiftXUd.Size = new System.Drawing.Size(59, 20);
            this.ditherOrderedShiftXUd.TabIndex = 19;
            this.ditherOrderedShiftXUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "by N pixels";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Shift pattern every Nth display refresh";
            // 
            // oneBitMethodPwmRb
            // 
            this.oneBitMethodPwmRb.AutoSize = true;
            this.oneBitMethodPwmRb.Location = new System.Drawing.Point(9, 120);
            this.oneBitMethodPwmRb.Name = "oneBitMethodPwmRb";
            this.oneBitMethodPwmRb.Size = new System.Drawing.Size(173, 17);
            this.oneBitMethodPwmRb.TabIndex = 2;
            this.oneBitMethodPwmRb.Text = "Pulse Width Modulation (PWM)";
            this.oneBitMethodPwmRb.UseVisualStyleBackColor = true;
            // 
            // ditherOrderedShiftFrameUd
            // 
            this.ditherOrderedShiftFrameUd.DecimalPlaces = 4;
            this.ditherOrderedShiftFrameUd.Location = new System.Drawing.Point(253, 69);
            this.ditherOrderedShiftFrameUd.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ditherOrderedShiftFrameUd.Name = "ditherOrderedShiftFrameUd";
            this.ditherOrderedShiftFrameUd.Size = new System.Drawing.Size(59, 20);
            this.ditherOrderedShiftFrameUd.TabIndex = 15;
            this.ditherOrderedShiftFrameUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // oneBitMethodOrderedRb
            // 
            this.oneBitMethodOrderedRb.AutoSize = true;
            this.oneBitMethodOrderedRb.Location = new System.Drawing.Point(9, 43);
            this.oneBitMethodOrderedRb.Name = "oneBitMethodOrderedRb";
            this.oneBitMethodOrderedRb.Size = new System.Drawing.Size(92, 17);
            this.oneBitMethodOrderedRb.TabIndex = 1;
            this.oneBitMethodOrderedRb.Text = "Ordered dither";
            this.oneBitMethodOrderedRb.UseVisualStyleBackColor = true;
            // 
            // oneBitMethodRandomRb
            // 
            this.oneBitMethodRandomRb.AutoSize = true;
            this.oneBitMethodRandomRb.Checked = true;
            this.oneBitMethodRandomRb.Location = new System.Drawing.Point(9, 19);
            this.oneBitMethodRandomRb.Name = "oneBitMethodRandomRb";
            this.oneBitMethodRandomRb.Size = new System.Drawing.Size(93, 17);
            this.oneBitMethodRandomRb.TabIndex = 0;
            this.oneBitMethodRandomRb.TabStop = true;
            this.oneBitMethodRandomRb.Text = "Random noise";
            this.oneBitMethodRandomRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.toneThreshWhiteUd);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.toneThreshBlackUd);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.gammaUd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.grayscaleDefB);
            this.groupBox2.Controls.Add(this.grayscaleBlueUd);
            this.groupBox2.Controls.Add(this.grayscaleGreenUd);
            this.groupBox2.Controls.Add(this.grayscaleRedUd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(216, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "White";
            // 
            // toneThreshWhiteUd
            // 
            this.toneThreshWhiteUd.DecimalPlaces = 3;
            this.toneThreshWhiteUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.toneThreshWhiteUd.Location = new System.Drawing.Point(253, 98);
            this.toneThreshWhiteUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toneThreshWhiteUd.Name = "toneThreshWhiteUd";
            this.toneThreshWhiteUd.Size = new System.Drawing.Size(59, 20);
            this.toneThreshWhiteUd.TabIndex = 13;
            this.toneThreshWhiteUd.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Black";
            // 
            // toneThreshBlackUd
            // 
            this.toneThreshBlackUd.DecimalPlaces = 3;
            this.toneThreshBlackUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.toneThreshBlackUd.Location = new System.Drawing.Point(156, 98);
            this.toneThreshBlackUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toneThreshBlackUd.Name = "toneThreshBlackUd";
            this.toneThreshBlackUd.Size = new System.Drawing.Size(59, 20);
            this.toneThreshBlackUd.TabIndex = 11;
            this.toneThreshBlackUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tone thresholds";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(221, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Blue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Green";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Red";
            // 
            // gammaUd
            // 
            this.gammaUd.DecimalPlaces = 3;
            this.gammaUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaUd.Location = new System.Drawing.Point(58, 71);
            this.gammaUd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gammaUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gammaUd.Name = "gammaUd";
            this.gammaUd.Size = new System.Drawing.Size(56, 20);
            this.gammaUd.TabIndex = 6;
            this.gammaUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Gamma";
            // 
            // grayscaleDefB
            // 
            this.grayscaleDefB.Location = new System.Drawing.Point(237, 17);
            this.grayscaleDefB.Name = "grayscaleDefB";
            this.grayscaleDefB.Size = new System.Drawing.Size(75, 23);
            this.grayscaleDefB.TabIndex = 4;
            this.grayscaleDefB.Text = "Default";
            this.grayscaleDefB.UseVisualStyleBackColor = true;
            // 
            // grayscaleBlueUd
            // 
            this.grayscaleBlueUd.DecimalPlaces = 3;
            this.grayscaleBlueUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grayscaleBlueUd.Location = new System.Drawing.Point(253, 45);
            this.grayscaleBlueUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grayscaleBlueUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.grayscaleBlueUd.Name = "grayscaleBlueUd";
            this.grayscaleBlueUd.Size = new System.Drawing.Size(59, 20);
            this.grayscaleBlueUd.TabIndex = 3;
            this.grayscaleBlueUd.Value = new decimal(new int[] {
            114,
            0,
            0,
            196608});
            // 
            // grayscaleGreenUd
            // 
            this.grayscaleGreenUd.DecimalPlaces = 3;
            this.grayscaleGreenUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grayscaleGreenUd.Location = new System.Drawing.Point(156, 45);
            this.grayscaleGreenUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grayscaleGreenUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.grayscaleGreenUd.Name = "grayscaleGreenUd";
            this.grayscaleGreenUd.Size = new System.Drawing.Size(59, 20);
            this.grayscaleGreenUd.TabIndex = 2;
            this.grayscaleGreenUd.Value = new decimal(new int[] {
            587,
            0,
            0,
            196608});
            // 
            // grayscaleRedUd
            // 
            this.grayscaleRedUd.DecimalPlaces = 3;
            this.grayscaleRedUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grayscaleRedUd.Location = new System.Drawing.Point(58, 45);
            this.grayscaleRedUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grayscaleRedUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.grayscaleRedUd.Name = "grayscaleRedUd";
            this.grayscaleRedUd.Size = new System.Drawing.Size(56, 20);
            this.grayscaleRedUd.TabIndex = 1;
            this.grayscaleRedUd.Value = new decimal(new int[] {
            299,
            0,
            0,
            196608});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Grayscale blending ratios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.blankSwapEveryYUd);
            this.groupBox3.Controls.Add(this.blankSwapEveryXUd);
            this.groupBox3.Controls.Add(this.blankSwapEveryRb);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.blankSwapAfterYUd);
            this.groupBox3.Controls.Add(this.blankSwapRandomRb);
            this.groupBox3.Controls.Add(this.blankSwapAfterRb);
            this.groupBox3.Controls.Add(this.blankSwapAfterXUd);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.blankValueTopUd);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.blankValueBottomUd);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Location = new System.Drawing.Point(339, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 150);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1 bit encoding levels";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(233, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "Y";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(136, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "X";
            // 
            // blankSwapEveryYUd
            // 
            this.blankSwapEveryYUd.Location = new System.Drawing.Point(253, 99);
            this.blankSwapEveryYUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.blankSwapEveryYUd.Name = "blankSwapEveryYUd";
            this.blankSwapEveryYUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapEveryYUd.TabIndex = 50;
            // 
            // blankSwapEveryXUd
            // 
            this.blankSwapEveryXUd.Location = new System.Drawing.Point(156, 99);
            this.blankSwapEveryXUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.blankSwapEveryXUd.Name = "blankSwapEveryXUd";
            this.blankSwapEveryXUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapEveryXUd.TabIndex = 49;
            // 
            // blankSwapEveryRb
            // 
            this.blankSwapEveryRb.AutoSize = true;
            this.blankSwapEveryRb.Location = new System.Drawing.Point(22, 99);
            this.blankSwapEveryRb.Name = "blankSwapEveryRb";
            this.blankSwapEveryRb.Size = new System.Drawing.Size(92, 17);
            this.blankSwapEveryRb.TabIndex = 48;
            this.blankSwapEveryRb.Text = "Every N pixels";
            this.blankSwapEveryRb.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(233, 75);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 47;
            this.label30.Text = "Y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(136, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "X";
            // 
            // blankSwapAfterYUd
            // 
            this.blankSwapAfterYUd.DecimalPlaces = 4;
            this.blankSwapAfterYUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blankSwapAfterYUd.Location = new System.Drawing.Point(253, 73);
            this.blankSwapAfterYUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapAfterYUd.Name = "blankSwapAfterYUd";
            this.blankSwapAfterYUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapAfterYUd.TabIndex = 45;
            this.blankSwapAfterYUd.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blankSwapRandomRb
            // 
            this.blankSwapRandomRb.AutoSize = true;
            this.blankSwapRandomRb.Location = new System.Drawing.Point(22, 124);
            this.blankSwapRandomRb.Name = "blankSwapRandomRb";
            this.blankSwapRandomRb.Size = new System.Drawing.Size(65, 17);
            this.blankSwapRandomRb.TabIndex = 44;
            this.blankSwapRandomRb.Text = "Random";
            this.blankSwapRandomRb.UseVisualStyleBackColor = true;
            // 
            // blankSwapAfterRb
            // 
            this.blankSwapAfterRb.AutoSize = true;
            this.blankSwapAfterRb.Checked = true;
            this.blankSwapAfterRb.Location = new System.Drawing.Point(22, 73);
            this.blankSwapAfterRb.Name = "blankSwapAfterRb";
            this.blankSwapAfterRb.Size = new System.Drawing.Size(86, 17);
            this.blankSwapAfterRb.TabIndex = 43;
            this.blankSwapAfterRb.TabStop = true;
            this.blankSwapAfterRb.Text = "After position";
            this.blankSwapAfterRb.UseVisualStyleBackColor = true;
            // 
            // blankSwapAfterXUd
            // 
            this.blankSwapAfterXUd.DecimalPlaces = 4;
            this.blankSwapAfterXUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blankSwapAfterXUd.Location = new System.Drawing.Point(156, 73);
            this.blankSwapAfterXUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapAfterXUd.Name = "blankSwapAfterXUd";
            this.blankSwapAfterXUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapAfterXUd.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(110, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 41;
            this.label29.Text = "Bottom";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(221, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "Top";
            // 
            // blankValueTopUd
            // 
            this.blankValueTopUd.DecimalPlaces = 4;
            this.blankValueTopUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blankValueTopUd.Location = new System.Drawing.Point(253, 19);
            this.blankValueTopUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankValueTopUd.Name = "blankValueTopUd";
            this.blankValueTopUd.Size = new System.Drawing.Size(59, 20);
            this.blankValueTopUd.TabIndex = 39;
            this.blankValueTopUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(204, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "Swap blanking values from Bottom to Top";
            // 
            // blankValueBottomUd
            // 
            this.blankValueBottomUd.DecimalPlaces = 4;
            this.blankValueBottomUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blankValueBottomUd.Location = new System.Drawing.Point(156, 19);
            this.blankValueBottomUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankValueBottomUd.Name = "blankValueBottomUd";
            this.blankValueBottomUd.Size = new System.Drawing.Size(59, 20);
            this.blankValueBottomUd.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Blanking value";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mainWinTopmostChb);
            this.groupBox4.Controls.Add(this.startB);
            this.groupBox4.Controls.Add(this.stopB);
            this.groupBox4.Controls.Add(this.drawWinFullscreenChb);
            this.groupBox4.Controls.Add(this.fpslabel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.currentmonitorlabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 454);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 536);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourceGb);
            this.Controls.Add(this.mapGb);
            this.Controls.Add(this.outputGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGA oscilloscope drawing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mapGb.ResumeLayout(false);
            this.mapGb.PerformLayout();
            this.sourceGb.ResumeLayout(false);
            this.sourceGb.PerformLayout();
            this.outputGb.ResumeLayout(false);
            this.outputGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsBottomUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsRightUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsLeftUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsTopUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationFpsUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshrateud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedMatrixUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftFrameUd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshWhiteUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshBlackUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBlueUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleGreenUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleRedUd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueTopUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueBottomUd)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox mapGb;
        private System.Windows.Forms.ComboBox channelMapBlueCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox channelMapGreenCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox channelMapRedCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox vgachannelinvertBlueChb;
        private System.Windows.Forms.CheckBox vgachannelinvertGreenChb;
        private System.Windows.Forms.CheckBox vgachannelinvertRedChb;
        private System.Windows.Forms.GroupBox sourceGb;
        private System.Windows.Forms.RadioButton pathDirRb;
        private System.Windows.Forms.RadioButton pathFileRb;
        private System.Windows.Forms.Button selectFramesPathB;
        private System.Windows.Forms.TextBox framesdirpathed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox outputGb;
        private System.Windows.Forms.CheckBox disableAntialiasingChb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown refreshrateud;
        private System.Windows.Forms.Button refreshMonitoListB;
        private System.Windows.Forms.ComboBox monitorListCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fpslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentmonitorlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox swapxyChb;
        private System.Windows.Forms.CheckBox drawWinFullscreenChb;
        private System.Windows.Forms.CheckBox mainWinTopmostChb;
        private System.Windows.Forms.Button swapxyB;
        private System.Windows.Forms.Button vsyncB;
        private System.Windows.Forms.Button nofpsB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown animationFpsUd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oneBitMethodPwmRb;
        private System.Windows.Forms.RadioButton oneBitMethodOrderedRb;
        private System.Windows.Forms.RadioButton oneBitMethodRandomRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown grayscaleRedUd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown gammaUd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button grayscaleDefB;
        private System.Windows.Forms.NumericUpDown grayscaleBlueUd;
        private System.Windows.Forms.NumericUpDown grayscaleGreenUd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown toneThreshWhiteUd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown toneThreshBlackUd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown ditherOrderedShiftYUd;
        private System.Windows.Forms.NumericUpDown ditherOrderedShiftXUd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown ditherOrderedShiftFrameUd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown blankValueTopUd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown blankValueBottomUd;
        private System.Windows.Forms.RadioButton blankSwapRandomRb;
        private System.Windows.Forms.RadioButton blankSwapAfterRb;
        private System.Windows.Forms.NumericUpDown blankSwapAfterXUd;
        private System.Windows.Forms.CheckBox vgachannel1BitGreenChb;
        private System.Windows.Forms.CheckBox vgachannel1BitRedChb;
        private System.Windows.Forms.Button vgachannelClearAllB;
        private System.Windows.Forms.CheckBox vgachannel1BitBlueChb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ditherOrderedMatrixUd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown outputBoundsBottomUd;
        private System.Windows.Forms.NumericUpDown outputBoundsRightUd;
        private System.Windows.Forms.NumericUpDown outputBoundsLeftUd;
        private System.Windows.Forms.Button outputBoundsResetB;
        private System.Windows.Forms.NumericUpDown outputBoundsTopUd;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown blankSwapAfterYUd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown blankSwapEveryYUd;
        private System.Windows.Forms.NumericUpDown blankSwapEveryXUd;
        private System.Windows.Forms.RadioButton blankSwapEveryRb;
        private System.Windows.Forms.Button outputOrigArB;
    }
}