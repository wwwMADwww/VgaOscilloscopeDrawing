namespace vgarender
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
            this.vgaChannelMappingGb = new System.Windows.Forms.GroupBox();
            this.vgachannel1BitBlueChb = new System.Windows.Forms.CheckBox();
            this.vgachannel1BitGreenChb = new System.Windows.Forms.CheckBox();
            this.vgachannel1BitRedChb = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.channelMapRedCb = new System.Windows.Forms.ComboBox();
            this.channelMapGreenCb = new System.Windows.Forms.ComboBox();
            this.channelMapBlueCb = new System.Windows.Forms.ComboBox();
            this.swapxyB = new System.Windows.Forms.Button();
            this.sourceImagesGb = new System.Windows.Forms.GroupBox();
            this.captureAreaFullB = new System.Windows.Forms.Button();
            this.captureAreaHUd = new System.Windows.Forms.NumericUpDown();
            this.captureAreaWUd = new System.Windows.Forms.NumericUpDown();
            this.captureAreaXUd = new System.Windows.Forms.NumericUpDown();
            this.captureAreaYUd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.captureMonitorCb = new System.Windows.Forms.ComboBox();
            this.captureMonitorRefreshB = new System.Windows.Forms.Button();
            this.frameSourceScreenCaptureRb = new System.Windows.Forms.RadioButton();
            this.frameSourceFileRb = new System.Windows.Forms.RadioButton();
            this.allFramesFromDirChb = new System.Windows.Forms.CheckBox();
            this.framesdirpathed = new System.Windows.Forms.TextBox();
            this.selectFramesPathB = new System.Windows.Forms.Button();
            this.swapxyChb = new System.Windows.Forms.CheckBox();
            this.outputGb = new System.Windows.Forms.GroupBox();
            this.outBoundsFlipHB = new System.Windows.Forms.Button();
            this.outBoundsFlipVB = new System.Windows.Forms.Button();
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
            this.enableAntialiasingChb = new System.Windows.Forms.CheckBox();
            this.fpslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentmonitorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainWinTopmostChb = new System.Windows.Forms.CheckBox();
            this.drawWinFullscreenChb = new System.Windows.Forms.CheckBox();
            this.oneBitMethodGb = new System.Windows.Forms.GroupBox();
            this.oneBitOrderedMatrixSizeCb = new System.Windows.Forms.ComboBox();
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
            this.imageGb = new System.Windows.Forms.GroupBox();
            this.colorLevelsResetB = new System.Windows.Forms.Button();
            this.contrastUd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.brightnessUd = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.imageScaleYUd = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.imageScaleXUd = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.colorInvertChb = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.toneThreshWhiteUd = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.toneThreshBlackUd = new System.Windows.Forms.NumericUpDown();
            this.grayscaleBlueLabel = new System.Windows.Forms.Label();
            this.grayscaleGreenLabel = new System.Windows.Forms.Label();
            this.grayscaleRedLabel = new System.Windows.Forms.Label();
            this.gammaUd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grayscaleDefB = new System.Windows.Forms.Button();
            this.grayscaleBlueUd = new System.Windows.Forms.NumericUpDown();
            this.grayscaleGreenUd = new System.Windows.Forms.NumericUpDown();
            this.grayscaleRedUd = new System.Windows.Forms.NumericUpDown();
            this.oneBitLevelsGb = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nearestActiveDistanceUd = new System.Windows.Forms.NumericUpDown();
            this.nearestActiveNextChb = new System.Windows.Forms.CheckBox();
            this.nearestActivePrevChb = new System.Windows.Forms.CheckBox();
            this.oneBitBlankLevelsNearestActiveRb = new System.Windows.Forms.RadioButton();
            this.oneBitBlankLevelsConstantRb = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.blankValueTopUd = new System.Windows.Forms.NumericUpDown();
            this.blankValueBottomUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapByPosChb = new System.Windows.Forms.CheckBox();
            this.blankSwapEveryNFrameUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapEveryNFrameChb = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.blankSwapCheckerHUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapCheckerWUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapCheckeredRb = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.blankSwapAfterYUd = new System.Windows.Forms.NumericUpDown();
            this.blankSwapRandomRb = new System.Windows.Forms.RadioButton();
            this.blankSwapAfterRb = new System.Windows.Forms.RadioButton();
            this.blankSwapAfterXUd = new System.Windows.Forms.NumericUpDown();
            this.controlGb = new System.Windows.Forms.GroupBox();
            this.coordRangesGb = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.coordGradientDitherOrderedRb = new System.Windows.Forms.RadioButton();
            this.coordRangeYInvertB = new System.Windows.Forms.Button();
            this.coordGradientDitherRandomRb = new System.Windows.Forms.RadioButton();
            this.coordRangeXInvertB = new System.Windows.Forms.Button();
            this.coordGradientDitherNoneRb = new System.Windows.Forms.RadioButton();
            this.label38 = new System.Windows.Forms.Label();
            this.coordRangeCMaxUd = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.coordRangeCMinUd = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.coordRangeYMaxUd = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.coordRangeYMinUd = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.coordRangeXMaxUd = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.coordRangeXMinUd = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vgaChannelMappingGb.SuspendLayout();
            this.sourceImagesGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaHUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaWUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaYUd)).BeginInit();
            this.outputGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsBottomUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsRightUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsLeftUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsTopUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationFpsUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshrateud)).BeginInit();
            this.oneBitMethodGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftFrameUd)).BeginInit();
            this.imageGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageScaleYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageScaleXUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshWhiteUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshBlackUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBlueUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleGreenUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleRedUd)).BeginInit();
            this.oneBitLevelsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearestActiveDistanceUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueTopUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueBottomUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryNFrameUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapCheckerHUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapCheckerWUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterYUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterXUd)).BeginInit();
            this.controlGb.SuspendLayout();
            this.coordRangesGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeCMaxUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeCMinUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeYMaxUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeYMinUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeXMaxUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeXMinUd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(894, 19);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 23);
            this.startB.TabIndex = 3;
            this.startB.Text = "(re)start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(813, 19);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(75, 23);
            this.stopB.TabIndex = 2;
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
            // vgaChannelMappingGb
            // 
            this.vgaChannelMappingGb.Controls.Add(this.vgachannel1BitBlueChb);
            this.vgaChannelMappingGb.Controls.Add(this.vgachannel1BitGreenChb);
            this.vgaChannelMappingGb.Controls.Add(this.vgachannel1BitRedChb);
            this.vgaChannelMappingGb.Controls.Add(this.label8);
            this.vgaChannelMappingGb.Controls.Add(this.label7);
            this.vgaChannelMappingGb.Controls.Add(this.label6);
            this.vgaChannelMappingGb.Controls.Add(this.channelMapRedCb);
            this.vgaChannelMappingGb.Controls.Add(this.channelMapGreenCb);
            this.vgaChannelMappingGb.Controls.Add(this.channelMapBlueCb);
            this.vgaChannelMappingGb.Controls.Add(this.swapxyB);
            this.vgaChannelMappingGb.Location = new System.Drawing.Point(666, 160);
            this.vgaChannelMappingGb.Name = "vgaChannelMappingGb";
            this.vgaChannelMappingGb.Size = new System.Drawing.Size(321, 88);
            this.vgaChannelMappingGb.TabIndex = 5;
            this.vgaChannelMappingGb.TabStop = false;
            this.vgaChannelMappingGb.Text = "VGA channel mapping";
            // 
            // vgachannel1BitBlueChb
            // 
            this.vgachannel1BitBlueChb.AutoSize = true;
            this.vgachannel1BitBlueChb.Location = new System.Drawing.Point(163, 66);
            this.vgachannel1BitBlueChb.Name = "vgachannel1BitBlueChb";
            this.vgachannel1BitBlueChb.Size = new System.Drawing.Size(74, 17);
            this.vgachannel1BitBlueChb.TabIndex = 6;
            this.vgachannel1BitBlueChb.Text = "+ 1 bit img";
            this.vgachannel1BitBlueChb.UseVisualStyleBackColor = true;
            // 
            // vgachannel1BitGreenChb
            // 
            this.vgachannel1BitGreenChb.AutoSize = true;
            this.vgachannel1BitGreenChb.Location = new System.Drawing.Point(84, 66);
            this.vgachannel1BitGreenChb.Name = "vgachannel1BitGreenChb";
            this.vgachannel1BitGreenChb.Size = new System.Drawing.Size(74, 17);
            this.vgachannel1BitGreenChb.TabIndex = 5;
            this.vgachannel1BitGreenChb.Text = "+ 1 bit img";
            this.vgachannel1BitGreenChb.UseVisualStyleBackColor = true;
            // 
            // vgachannel1BitRedChb
            // 
            this.vgachannel1BitRedChb.AutoSize = true;
            this.vgachannel1BitRedChb.Location = new System.Drawing.Point(6, 66);
            this.vgachannel1BitRedChb.Name = "vgachannel1BitRedChb";
            this.vgachannel1BitRedChb.Size = new System.Drawing.Size(74, 17);
            this.vgachannel1BitRedChb.TabIndex = 4;
            this.vgachannel1BitRedChb.Text = "+ 1 bit img";
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
            this.channelMapRedCb.TabIndex = 0;
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
            this.channelMapGreenCb.TabIndex = 1;
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
            this.channelMapBlueCb.TabIndex = 2;
            // 
            // swapxyB
            // 
            this.swapxyB.Location = new System.Drawing.Point(241, 37);
            this.swapxyB.Name = "swapxyB";
            this.swapxyB.Size = new System.Drawing.Size(71, 23);
            this.swapxyB.TabIndex = 3;
            this.swapxyB.Text = "Swap X Y";
            this.swapxyB.UseVisualStyleBackColor = true;
            this.swapxyB.Click += new System.EventHandler(this.swapxyB_Click);
            // 
            // sourceImagesGb
            // 
            this.sourceImagesGb.Controls.Add(this.captureAreaFullB);
            this.sourceImagesGb.Controls.Add(this.captureAreaHUd);
            this.sourceImagesGb.Controls.Add(this.captureAreaWUd);
            this.sourceImagesGb.Controls.Add(this.captureAreaXUd);
            this.sourceImagesGb.Controls.Add(this.captureAreaYUd);
            this.sourceImagesGb.Controls.Add(this.label3);
            this.sourceImagesGb.Controls.Add(this.captureMonitorCb);
            this.sourceImagesGb.Controls.Add(this.captureMonitorRefreshB);
            this.sourceImagesGb.Controls.Add(this.frameSourceScreenCaptureRb);
            this.sourceImagesGb.Controls.Add(this.frameSourceFileRb);
            this.sourceImagesGb.Controls.Add(this.allFramesFromDirChb);
            this.sourceImagesGb.Controls.Add(this.framesdirpathed);
            this.sourceImagesGb.Controls.Add(this.selectFramesPathB);
            this.sourceImagesGb.Location = new System.Drawing.Point(12, 12);
            this.sourceImagesGb.Name = "sourceImagesGb";
            this.sourceImagesGb.Size = new System.Drawing.Size(321, 199);
            this.sourceImagesGb.TabIndex = 0;
            this.sourceImagesGb.TabStop = false;
            this.sourceImagesGb.Text = "Source";
            // 
            // captureAreaFullB
            // 
            this.captureAreaFullB.Location = new System.Drawing.Point(236, 129);
            this.captureAreaFullB.Name = "captureAreaFullB";
            this.captureAreaFullB.Size = new System.Drawing.Size(75, 23);
            this.captureAreaFullB.TabIndex = 59;
            this.captureAreaFullB.Text = "Full area";
            this.captureAreaFullB.UseVisualStyleBackColor = true;
            this.captureAreaFullB.Click += new System.EventHandler(this.captureAreaFullB_Click);
            // 
            // captureAreaHUd
            // 
            this.captureAreaHUd.Location = new System.Drawing.Point(134, 155);
            this.captureAreaHUd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.captureAreaHUd.Name = "captureAreaHUd";
            this.captureAreaHUd.Size = new System.Drawing.Size(63, 20);
            this.captureAreaHUd.TabIndex = 54;
            this.captureAreaHUd.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // captureAreaWUd
            // 
            this.captureAreaWUd.Location = new System.Drawing.Point(167, 129);
            this.captureAreaWUd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.captureAreaWUd.Name = "captureAreaWUd";
            this.captureAreaWUd.Size = new System.Drawing.Size(63, 20);
            this.captureAreaWUd.TabIndex = 56;
            this.captureAreaWUd.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // captureAreaXUd
            // 
            this.captureAreaXUd.Location = new System.Drawing.Point(92, 129);
            this.captureAreaXUd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.captureAreaXUd.Name = "captureAreaXUd";
            this.captureAreaXUd.Size = new System.Drawing.Size(63, 20);
            this.captureAreaXUd.TabIndex = 55;
            // 
            // captureAreaYUd
            // 
            this.captureAreaYUd.Location = new System.Drawing.Point(134, 103);
            this.captureAreaYUd.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.captureAreaYUd.Name = "captureAreaYUd";
            this.captureAreaYUd.Size = new System.Drawing.Size(63, 20);
            this.captureAreaYUd.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Capture area";
            // 
            // captureMonitorCb
            // 
            this.captureMonitorCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.captureMonitorCb.FormattingEnabled = true;
            this.captureMonitorCb.Location = new System.Drawing.Point(110, 74);
            this.captureMonitorCb.Name = "captureMonitorCb";
            this.captureMonitorCb.Size = new System.Drawing.Size(120, 21);
            this.captureMonitorCb.TabIndex = 51;
            // 
            // captureMonitorRefreshB
            // 
            this.captureMonitorRefreshB.Location = new System.Drawing.Point(236, 72);
            this.captureMonitorRefreshB.Name = "captureMonitorRefreshB";
            this.captureMonitorRefreshB.Size = new System.Drawing.Size(75, 23);
            this.captureMonitorRefreshB.TabIndex = 52;
            this.captureMonitorRefreshB.Text = "Refresh list";
            this.captureMonitorRefreshB.UseVisualStyleBackColor = true;
            this.captureMonitorRefreshB.Click += new System.EventHandler(this.captureMonitorRefreshB_Click);
            // 
            // frameSourceScreenCaptureRb
            // 
            this.frameSourceScreenCaptureRb.AutoSize = true;
            this.frameSourceScreenCaptureRb.Location = new System.Drawing.Point(6, 75);
            this.frameSourceScreenCaptureRb.Name = "frameSourceScreenCaptureRb";
            this.frameSourceScreenCaptureRb.Size = new System.Drawing.Size(98, 17);
            this.frameSourceScreenCaptureRb.TabIndex = 13;
            this.frameSourceScreenCaptureRb.Text = "Screen capture";
            this.frameSourceScreenCaptureRb.UseVisualStyleBackColor = true;
            // 
            // frameSourceFileRb
            // 
            this.frameSourceFileRb.AutoSize = true;
            this.frameSourceFileRb.Checked = true;
            this.frameSourceFileRb.Location = new System.Drawing.Point(6, 17);
            this.frameSourceFileRb.Name = "frameSourceFileRb";
            this.frameSourceFileRb.Size = new System.Drawing.Size(150, 17);
            this.frameSourceFileRb.TabIndex = 12;
            this.frameSourceFileRb.TabStop = true;
            this.frameSourceFileRb.Text = "Animation frames from disk";
            this.frameSourceFileRb.UseVisualStyleBackColor = true;
            // 
            // allFramesFromDirChb
            // 
            this.allFramesFromDirChb.AutoSize = true;
            this.allFramesFromDirChb.Location = new System.Drawing.Point(199, 18);
            this.allFramesFromDirChb.Name = "allFramesFromDirChb";
            this.allFramesFromDirChb.Size = new System.Drawing.Size(112, 17);
            this.allFramesFromDirChb.TabIndex = 11;
            this.allFramesFromDirChb.Text = "All files in directory";
            this.allFramesFromDirChb.UseVisualStyleBackColor = true;
            // 
            // framesdirpathed
            // 
            this.framesdirpathed.Location = new System.Drawing.Point(28, 40);
            this.framesdirpathed.MaxLength = 260;
            this.framesdirpathed.Name = "framesdirpathed";
            this.framesdirpathed.Size = new System.Drawing.Size(202, 20);
            this.framesdirpathed.TabIndex = 0;
            // 
            // selectFramesPathB
            // 
            this.selectFramesPathB.Location = new System.Drawing.Point(236, 38);
            this.selectFramesPathB.Name = "selectFramesPathB";
            this.selectFramesPathB.Size = new System.Drawing.Size(75, 23);
            this.selectFramesPathB.TabIndex = 1;
            this.selectFramesPathB.Text = "Select...";
            this.selectFramesPathB.UseVisualStyleBackColor = true;
            this.selectFramesPathB.Click += new System.EventHandler(this.selectFramesPathB_Click);
            // 
            // swapxyChb
            // 
            this.swapxyChb.AutoSize = true;
            this.swapxyChb.Location = new System.Drawing.Point(148, 46);
            this.swapxyChb.Name = "swapxyChb";
            this.swapxyChb.Size = new System.Drawing.Size(164, 17);
            this.swapxyChb.TabIndex = 3;
            this.swapxyChb.Text = "Rotate 90 degrees clockwise";
            this.swapxyChb.UseVisualStyleBackColor = true;
            // 
            // outputGb
            // 
            this.outputGb.Controls.Add(this.outBoundsFlipHB);
            this.outputGb.Controls.Add(this.outBoundsFlipVB);
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
            this.outputGb.Location = new System.Drawing.Point(666, 254);
            this.outputGb.Name = "outputGb";
            this.outputGb.Size = new System.Drawing.Size(321, 178);
            this.outputGb.TabIndex = 6;
            this.outputGb.TabStop = false;
            this.outputGb.Text = "Output";
            // 
            // outBoundsFlipHB
            // 
            this.outBoundsFlipHB.Location = new System.Drawing.Point(208, 125);
            this.outBoundsFlipHB.Name = "outBoundsFlipHB";
            this.outBoundsFlipHB.Size = new System.Drawing.Size(104, 23);
            this.outBoundsFlipHB.TabIndex = 13;
            this.outBoundsFlipHB.Text = "Flip Horizontally";
            this.outBoundsFlipHB.UseVisualStyleBackColor = true;
            this.outBoundsFlipHB.Click += new System.EventHandler(this.outBoundsFlipHB_Click);
            // 
            // outBoundsFlipVB
            // 
            this.outBoundsFlipVB.Location = new System.Drawing.Point(208, 99);
            this.outBoundsFlipVB.Name = "outBoundsFlipVB";
            this.outBoundsFlipVB.Size = new System.Drawing.Size(104, 23);
            this.outBoundsFlipVB.TabIndex = 12;
            this.outBoundsFlipVB.Text = "Flip Vertically";
            this.outBoundsFlipVB.UseVisualStyleBackColor = true;
            this.outBoundsFlipVB.Click += new System.EventHandler(this.outBoundsFlipVB_Click);
            // 
            // outputBoundsBottomUd
            // 
            this.outputBoundsBottomUd.DecimalPlaces = 4;
            this.outputBoundsBottomUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.outputBoundsBottomUd.Location = new System.Drawing.Point(93, 154);
            this.outputBoundsBottomUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsBottomUd.Name = "outputBoundsBottomUd";
            this.outputBoundsBottomUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsBottomUd.TabIndex = 9;
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
            131072});
            this.outputBoundsRightUd.Location = new System.Drawing.Point(126, 128);
            this.outputBoundsRightUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsRightUd.Name = "outputBoundsRightUd";
            this.outputBoundsRightUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsRightUd.TabIndex = 11;
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
            131072});
            this.outputBoundsLeftUd.Location = new System.Drawing.Point(51, 128);
            this.outputBoundsLeftUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsLeftUd.Name = "outputBoundsLeftUd";
            this.outputBoundsLeftUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsLeftUd.TabIndex = 10;
            // 
            // outputBoundsResetB
            // 
            this.outputBoundsResetB.Location = new System.Drawing.Point(208, 151);
            this.outputBoundsResetB.Name = "outputBoundsResetB";
            this.outputBoundsResetB.Size = new System.Drawing.Size(104, 23);
            this.outputBoundsResetB.TabIndex = 14;
            this.outputBoundsResetB.Text = "Reset";
            this.outputBoundsResetB.UseVisualStyleBackColor = true;
            this.outputBoundsResetB.Click += new System.EventHandler(this.outputBoundsResetB_Click);
            // 
            // outputBoundsTopUd
            // 
            this.outputBoundsTopUd.DecimalPlaces = 4;
            this.outputBoundsTopUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.outputBoundsTopUd.Location = new System.Drawing.Point(93, 102);
            this.outputBoundsTopUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputBoundsTopUd.Name = "outputBoundsTopUd";
            this.outputBoundsTopUd.Size = new System.Drawing.Size(63, 20);
            this.outputBoundsTopUd.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 104);
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
            this.animationFpsUd.TabIndex = 5;
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
            this.vsyncB.TabIndex = 3;
            this.vsyncB.Text = "VSync";
            this.vsyncB.UseVisualStyleBackColor = true;
            this.vsyncB.Click += new System.EventHandler(this.vsyncB_Click);
            // 
            // nofpsB
            // 
            this.nofpsB.Location = new System.Drawing.Point(294, 43);
            this.nofpsB.Name = "nofpsB";
            this.nofpsB.Size = new System.Drawing.Size(18, 23);
            this.nofpsB.TabIndex = 4;
            this.nofpsB.Text = "X";
            this.nofpsB.UseVisualStyleBackColor = true;
            this.nofpsB.Click += new System.EventHandler(this.nofpsB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Framerate (FPS)";
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
            // enableAntialiasingChb
            // 
            this.enableAntialiasingChb.AutoSize = true;
            this.enableAntialiasingChb.Checked = true;
            this.enableAntialiasingChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableAntialiasingChb.Location = new System.Drawing.Point(11, 46);
            this.enableAntialiasingChb.Name = "enableAntialiasingChb";
            this.enableAntialiasingChb.Size = new System.Drawing.Size(114, 17);
            this.enableAntialiasingChb.TabIndex = 2;
            this.enableAntialiasingChb.Text = "Enable antialiasing";
            this.enableAntialiasingChb.UseVisualStyleBackColor = true;
            // 
            // fpslabel
            // 
            this.fpslabel.AutoSize = true;
            this.fpslabel.Location = new System.Drawing.Point(552, 24);
            this.fpslabel.Name = "fpslabel";
            this.fpslabel.Size = new System.Drawing.Size(33, 13);
            this.fpslabel.TabIndex = 2;
            this.fpslabel.Text = "F P S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Current FPS ~";
            // 
            // currentmonitorlabel
            // 
            this.currentmonitorlabel.AutoSize = true;
            this.currentmonitorlabel.Location = new System.Drawing.Point(708, 24);
            this.currentmonitorlabel.Name = "currentmonitorlabel";
            this.currentmonitorlabel.Size = new System.Drawing.Size(76, 13);
            this.currentmonitorlabel.TabIndex = 43;
            this.currentmonitorlabel.Text = "M O N I T O R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 24);
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
            this.mainWinTopmostChb.Location = new System.Drawing.Point(6, 23);
            this.mainWinTopmostChb.Name = "mainWinTopmostChb";
            this.mainWinTopmostChb.Size = new System.Drawing.Size(121, 17);
            this.mainWinTopmostChb.TabIndex = 0;
            this.mainWinTopmostChb.Text = "Main window on top";
            this.mainWinTopmostChb.UseVisualStyleBackColor = true;
            this.mainWinTopmostChb.CheckedChanged += new System.EventHandler(this.mainWinTopmostChb_CheckedChanged);
            // 
            // drawWinFullscreenChb
            // 
            this.drawWinFullscreenChb.AutoSize = true;
            this.drawWinFullscreenChb.Checked = true;
            this.drawWinFullscreenChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawWinFullscreenChb.Location = new System.Drawing.Point(135, 23);
            this.drawWinFullscreenChb.Name = "drawWinFullscreenChb";
            this.drawWinFullscreenChb.Size = new System.Drawing.Size(113, 17);
            this.drawWinFullscreenChb.TabIndex = 1;
            this.drawWinFullscreenChb.Text = "Drawing fullscreen";
            this.drawWinFullscreenChb.UseVisualStyleBackColor = true;
            // 
            // oneBitMethodGb
            // 
            this.oneBitMethodGb.Controls.Add(this.oneBitOrderedMatrixSizeCb);
            this.oneBitMethodGb.Controls.Add(this.label11);
            this.oneBitMethodGb.Controls.Add(this.label23);
            this.oneBitMethodGb.Controls.Add(this.label22);
            this.oneBitMethodGb.Controls.Add(this.ditherOrderedShiftYUd);
            this.oneBitMethodGb.Controls.Add(this.ditherOrderedShiftXUd);
            this.oneBitMethodGb.Controls.Add(this.label21);
            this.oneBitMethodGb.Controls.Add(this.label20);
            this.oneBitMethodGb.Controls.Add(this.oneBitMethodPwmRb);
            this.oneBitMethodGb.Controls.Add(this.ditherOrderedShiftFrameUd);
            this.oneBitMethodGb.Controls.Add(this.oneBitMethodOrderedRb);
            this.oneBitMethodGb.Controls.Add(this.oneBitMethodRandomRb);
            this.oneBitMethodGb.Location = new System.Drawing.Point(339, 282);
            this.oneBitMethodGb.Name = "oneBitMethodGb";
            this.oneBitMethodGb.Size = new System.Drawing.Size(321, 150);
            this.oneBitMethodGb.TabIndex = 3;
            this.oneBitMethodGb.TabStop = false;
            this.oneBitMethodGb.Text = "1 bit encoding method";
            // 
            // oneBitOrderedMatrixSizeCb
            // 
            this.oneBitOrderedMatrixSizeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oneBitOrderedMatrixSizeCb.FormattingEnabled = true;
            this.oneBitOrderedMatrixSizeCb.Location = new System.Drawing.Point(253, 42);
            this.oneBitOrderedMatrixSizeCb.Name = "oneBitOrderedMatrixSizeCb";
            this.oneBitOrderedMatrixSizeCb.Size = new System.Drawing.Size(59, 21);
            this.oneBitOrderedMatrixSizeCb.TabIndex = 2;
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
            this.ditherOrderedShiftYUd.TabIndex = 7;
            this.ditherOrderedShiftYUd.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // ditherOrderedShiftXUd
            // 
            this.ditherOrderedShiftXUd.DecimalPlaces = 4;
            this.ditherOrderedShiftXUd.Location = new System.Drawing.Point(153, 95);
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
            this.ditherOrderedShiftXUd.TabIndex = 6;
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
            this.label21.TabIndex = 5;
            this.label21.Text = "by N pixels";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Shift pattern every Nth frame";
            // 
            // oneBitMethodPwmRb
            // 
            this.oneBitMethodPwmRb.AutoSize = true;
            this.oneBitMethodPwmRb.Location = new System.Drawing.Point(9, 120);
            this.oneBitMethodPwmRb.Name = "oneBitMethodPwmRb";
            this.oneBitMethodPwmRb.Size = new System.Drawing.Size(173, 17);
            this.oneBitMethodPwmRb.TabIndex = 8;
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
            this.ditherOrderedShiftFrameUd.TabIndex = 4;
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
            // imageGb
            // 
            this.imageGb.Controls.Add(this.colorLevelsResetB);
            this.imageGb.Controls.Add(this.contrastUd);
            this.imageGb.Controls.Add(this.label14);
            this.imageGb.Controls.Add(this.brightnessUd);
            this.imageGb.Controls.Add(this.label15);
            this.imageGb.Controls.Add(this.label41);
            this.imageGb.Controls.Add(this.imageScaleYUd);
            this.imageGb.Controls.Add(this.label42);
            this.imageGb.Controls.Add(this.imageScaleXUd);
            this.imageGb.Controls.Add(this.label27);
            this.imageGb.Controls.Add(this.swapxyChb);
            this.imageGb.Controls.Add(this.colorInvertChb);
            this.imageGb.Controls.Add(this.label18);
            this.imageGb.Controls.Add(this.toneThreshWhiteUd);
            this.imageGb.Controls.Add(this.label17);
            this.imageGb.Controls.Add(this.toneThreshBlackUd);
            this.imageGb.Controls.Add(this.grayscaleBlueLabel);
            this.imageGb.Controls.Add(this.grayscaleGreenLabel);
            this.imageGb.Controls.Add(this.grayscaleRedLabel);
            this.imageGb.Controls.Add(this.gammaUd);
            this.imageGb.Controls.Add(this.label12);
            this.imageGb.Controls.Add(this.enableAntialiasingChb);
            this.imageGb.Controls.Add(this.grayscaleDefB);
            this.imageGb.Controls.Add(this.grayscaleBlueUd);
            this.imageGb.Controls.Add(this.grayscaleGreenUd);
            this.imageGb.Controls.Add(this.grayscaleRedUd);
            this.imageGb.Location = new System.Drawing.Point(12, 211);
            this.imageGb.Name = "imageGb";
            this.imageGb.Size = new System.Drawing.Size(321, 221);
            this.imageGb.TabIndex = 1;
            this.imageGb.TabStop = false;
            this.imageGb.Text = "Image";
            // 
            // colorLevelsResetB
            // 
            this.colorLevelsResetB.Location = new System.Drawing.Point(240, 153);
            this.colorLevelsResetB.Name = "colorLevelsResetB";
            this.colorLevelsResetB.Size = new System.Drawing.Size(71, 23);
            this.colorLevelsResetB.TabIndex = 19;
            this.colorLevelsResetB.Text = "Reset";
            this.colorLevelsResetB.UseVisualStyleBackColor = true;
            this.colorLevelsResetB.Click += new System.EventHandler(this.colorLevelsResetB_Click);
            // 
            // contrastUd
            // 
            this.contrastUd.DecimalPlaces = 3;
            this.contrastUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.contrastUd.Location = new System.Drawing.Point(6, 156);
            this.contrastUd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.contrastUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.contrastUd.Name = "contrastUd";
            this.contrastUd.Size = new System.Drawing.Size(72, 20);
            this.contrastUd.TabIndex = 18;
            this.contrastUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Contrast";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessUd
            // 
            this.brightnessUd.DecimalPlaces = 3;
            this.brightnessUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.brightnessUd.Location = new System.Drawing.Point(84, 156);
            this.brightnessUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brightnessUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.brightnessUd.Name = "brightnessUd";
            this.brightnessUd.Size = new System.Drawing.Size(72, 20);
            this.brightnessUd.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(83, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Brightness";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(205, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Vertical";
            // 
            // imageScaleYUd
            // 
            this.imageScaleYUd.DecimalPlaces = 3;
            this.imageScaleYUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.imageScaleYUd.Location = new System.Drawing.Point(253, 19);
            this.imageScaleYUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imageScaleYUd.Name = "imageScaleYUd";
            this.imageScaleYUd.Size = new System.Drawing.Size(59, 20);
            this.imageScaleYUd.TabIndex = 1;
            this.imageScaleYUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(75, 21);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 13);
            this.label42.TabIndex = 1;
            this.label42.Text = "Horizontal";
            // 
            // imageScaleXUd
            // 
            this.imageScaleXUd.DecimalPlaces = 3;
            this.imageScaleXUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.imageScaleXUd.Location = new System.Drawing.Point(135, 19);
            this.imageScaleXUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imageScaleXUd.Name = "imageScaleXUd";
            this.imageScaleXUd.Size = new System.Drawing.Size(59, 20);
            this.imageScaleXUd.TabIndex = 0;
            this.imageScaleXUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Scale";
            // 
            // colorInvertChb
            // 
            this.colorInvertChb.AutoSize = true;
            this.colorInvertChb.Location = new System.Drawing.Point(11, 69);
            this.colorInvertChb.Name = "colorInvertChb";
            this.colorInvertChb.Size = new System.Drawing.Size(84, 17);
            this.colorInvertChb.TabIndex = 9;
            this.colorInvertChb.Text = "Invert colors";
            this.colorInvertChb.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Full white after";
            // 
            // toneThreshWhiteUd
            // 
            this.toneThreshWhiteUd.DecimalPlaces = 3;
            this.toneThreshWhiteUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.toneThreshWhiteUd.Location = new System.Drawing.Point(252, 191);
            this.toneThreshWhiteUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toneThreshWhiteUd.Name = "toneThreshWhiteUd";
            this.toneThreshWhiteUd.Size = new System.Drawing.Size(59, 20);
            this.toneThreshWhiteUd.TabIndex = 12;
            this.toneThreshWhiteUd.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Full black before";
            // 
            // toneThreshBlackUd
            // 
            this.toneThreshBlackUd.DecimalPlaces = 3;
            this.toneThreshBlackUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.toneThreshBlackUd.Location = new System.Drawing.Point(94, 191);
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
            // grayscaleBlueLabel
            // 
            this.grayscaleBlueLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayscaleBlueLabel.Location = new System.Drawing.Point(159, 91);
            this.grayscaleBlueLabel.Name = "grayscaleBlueLabel";
            this.grayscaleBlueLabel.Size = new System.Drawing.Size(75, 13);
            this.grayscaleBlueLabel.TabIndex = 9;
            this.grayscaleBlueLabel.Text = "Blue";
            this.grayscaleBlueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grayscaleBlueLabel.Click += new System.EventHandler(this.grayscaleBlueLabel_Click);
            // 
            // grayscaleGreenLabel
            // 
            this.grayscaleGreenLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayscaleGreenLabel.Location = new System.Drawing.Point(81, 91);
            this.grayscaleGreenLabel.Name = "grayscaleGreenLabel";
            this.grayscaleGreenLabel.Size = new System.Drawing.Size(75, 13);
            this.grayscaleGreenLabel.TabIndex = 8;
            this.grayscaleGreenLabel.Text = "Green";
            this.grayscaleGreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grayscaleGreenLabel.Click += new System.EventHandler(this.grayscaleGreenLabel_Click);
            // 
            // grayscaleRedLabel
            // 
            this.grayscaleRedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayscaleRedLabel.Location = new System.Drawing.Point(6, 91);
            this.grayscaleRedLabel.Name = "grayscaleRedLabel";
            this.grayscaleRedLabel.Size = new System.Drawing.Size(72, 13);
            this.grayscaleRedLabel.TabIndex = 7;
            this.grayscaleRedLabel.Text = "Red";
            this.grayscaleRedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grayscaleRedLabel.Click += new System.EventHandler(this.grayscaleRedLabel_Click);
            // 
            // gammaUd
            // 
            this.gammaUd.DecimalPlaces = 3;
            this.gammaUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gammaUd.Location = new System.Drawing.Point(162, 156);
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
            this.gammaUd.Size = new System.Drawing.Size(72, 20);
            this.gammaUd.TabIndex = 10;
            this.gammaUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(164, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Gamma";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grayscaleDefB
            // 
            this.grayscaleDefB.Location = new System.Drawing.Point(241, 104);
            this.grayscaleDefB.Name = "grayscaleDefB";
            this.grayscaleDefB.Size = new System.Drawing.Size(71, 23);
            this.grayscaleDefB.TabIndex = 8;
            this.grayscaleDefB.Text = "Default";
            this.grayscaleDefB.UseVisualStyleBackColor = true;
            this.grayscaleDefB.Click += new System.EventHandler(this.grayscaleDefB_Click);
            // 
            // grayscaleBlueUd
            // 
            this.grayscaleBlueUd.DecimalPlaces = 3;
            this.grayscaleBlueUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.grayscaleBlueUd.Location = new System.Drawing.Point(162, 107);
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
            this.grayscaleBlueUd.Size = new System.Drawing.Size(72, 20);
            this.grayscaleBlueUd.TabIndex = 7;
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
            131072});
            this.grayscaleGreenUd.Location = new System.Drawing.Point(84, 107);
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
            this.grayscaleGreenUd.Size = new System.Drawing.Size(72, 20);
            this.grayscaleGreenUd.TabIndex = 6;
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
            131072});
            this.grayscaleRedUd.Location = new System.Drawing.Point(6, 107);
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
            this.grayscaleRedUd.Size = new System.Drawing.Size(72, 20);
            this.grayscaleRedUd.TabIndex = 5;
            this.grayscaleRedUd.Value = new decimal(new int[] {
            299,
            0,
            0,
            196608});
            // 
            // oneBitLevelsGb
            // 
            this.oneBitLevelsGb.Controls.Add(this.label10);
            this.oneBitLevelsGb.Controls.Add(this.nearestActiveDistanceUd);
            this.oneBitLevelsGb.Controls.Add(this.nearestActiveNextChb);
            this.oneBitLevelsGb.Controls.Add(this.nearestActivePrevChb);
            this.oneBitLevelsGb.Controls.Add(this.oneBitBlankLevelsNearestActiveRb);
            this.oneBitLevelsGb.Controls.Add(this.oneBitBlankLevelsConstantRb);
            this.oneBitLevelsGb.Controls.Add(this.label29);
            this.oneBitLevelsGb.Controls.Add(this.label28);
            this.oneBitLevelsGb.Controls.Add(this.blankValueTopUd);
            this.oneBitLevelsGb.Controls.Add(this.blankValueBottomUd);
            this.oneBitLevelsGb.Location = new System.Drawing.Point(339, 12);
            this.oneBitLevelsGb.Name = "oneBitLevelsGb";
            this.oneBitLevelsGb.Size = new System.Drawing.Size(321, 112);
            this.oneBitLevelsGb.TabIndex = 2;
            this.oneBitLevelsGb.TabStop = false;
            this.oneBitLevelsGb.Text = "1 bit blanking levels";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(23, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Use value from Constant if distance more than";
            // 
            // nearestActiveDistanceUd
            // 
            this.nearestActiveDistanceUd.DecimalPlaces = 4;
            this.nearestActiveDistanceUd.Enabled = false;
            this.nearestActiveDistanceUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nearestActiveDistanceUd.Location = new System.Drawing.Point(253, 76);
            this.nearestActiveDistanceUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nearestActiveDistanceUd.Name = "nearestActiveDistanceUd";
            this.nearestActiveDistanceUd.Size = new System.Drawing.Size(59, 20);
            this.nearestActiveDistanceUd.TabIndex = 64;
            this.nearestActiveDistanceUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // nearestActiveNextChb
            // 
            this.nearestActiveNextChb.AutoSize = true;
            this.nearestActiveNextChb.Checked = true;
            this.nearestActiveNextChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nearestActiveNextChb.Enabled = false;
            this.nearestActiveNextChb.Location = new System.Drawing.Point(253, 53);
            this.nearestActiveNextChb.Name = "nearestActiveNextChb";
            this.nearestActiveNextChb.Size = new System.Drawing.Size(48, 17);
            this.nearestActiveNextChb.TabIndex = 63;
            this.nearestActiveNextChb.Text = "Next";
            this.nearestActiveNextChb.UseVisualStyleBackColor = true;
            // 
            // nearestActivePrevChb
            // 
            this.nearestActivePrevChb.AutoSize = true;
            this.nearestActivePrevChb.Checked = true;
            this.nearestActivePrevChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nearestActivePrevChb.Enabled = false;
            this.nearestActivePrevChb.Location = new System.Drawing.Point(156, 53);
            this.nearestActivePrevChb.Name = "nearestActivePrevChb";
            this.nearestActivePrevChb.Size = new System.Drawing.Size(67, 17);
            this.nearestActivePrevChb.TabIndex = 62;
            this.nearestActivePrevChb.Text = "Previous";
            this.nearestActivePrevChb.UseVisualStyleBackColor = true;
            // 
            // oneBitBlankLevelsNearestActiveRb
            // 
            this.oneBitBlankLevelsNearestActiveRb.AutoSize = true;
            this.oneBitBlankLevelsNearestActiveRb.Enabled = false;
            this.oneBitBlankLevelsNearestActiveRb.Location = new System.Drawing.Point(9, 52);
            this.oneBitBlankLevelsNearestActiveRb.Name = "oneBitBlankLevelsNearestActiveRb";
            this.oneBitBlankLevelsNearestActiveRb.Size = new System.Drawing.Size(138, 17);
            this.oneBitBlankLevelsNearestActiveRb.TabIndex = 61;
            this.oneBitBlankLevelsNearestActiveRb.Text = "Nearest active pixel pos";
            this.oneBitBlankLevelsNearestActiveRb.UseVisualStyleBackColor = true;
            // 
            // oneBitBlankLevelsConstantRb
            // 
            this.oneBitBlankLevelsConstantRb.AutoSize = true;
            this.oneBitBlankLevelsConstantRb.Checked = true;
            this.oneBitBlankLevelsConstantRb.Location = new System.Drawing.Point(7, 22);
            this.oneBitBlankLevelsConstantRb.Name = "oneBitBlankLevelsConstantRb";
            this.oneBitBlankLevelsConstantRb.Size = new System.Drawing.Size(67, 17);
            this.oneBitBlankLevelsConstantRb.TabIndex = 60;
            this.oneBitBlankLevelsConstantRb.TabStop = true;
            this.oneBitBlankLevelsConstantRb.Text = "Constant";
            this.oneBitBlankLevelsConstantRb.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(108, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 41;
            this.label29.Text = "Bottom";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(221, 24);
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
            131072});
            this.blankValueTopUd.Location = new System.Drawing.Point(253, 22);
            this.blankValueTopUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankValueTopUd.Name = "blankValueTopUd";
            this.blankValueTopUd.Size = new System.Drawing.Size(59, 20);
            this.blankValueTopUd.TabIndex = 1;
            this.blankValueTopUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blankValueBottomUd
            // 
            this.blankValueBottomUd.DecimalPlaces = 4;
            this.blankValueBottomUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.blankValueBottomUd.Location = new System.Drawing.Point(153, 22);
            this.blankValueBottomUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankValueBottomUd.Name = "blankValueBottomUd";
            this.blankValueBottomUd.Size = new System.Drawing.Size(59, 20);
            this.blankValueBottomUd.TabIndex = 0;
            // 
            // blankSwapByPosChb
            // 
            this.blankSwapByPosChb.AutoSize = true;
            this.blankSwapByPosChb.Location = new System.Drawing.Point(6, 42);
            this.blankSwapByPosChb.Name = "blankSwapByPosChb";
            this.blankSwapByPosChb.Size = new System.Drawing.Size(130, 17);
            this.blankSwapByPosChb.TabIndex = 4;
            this.blankSwapByPosChb.Text = "Swap by pixel position";
            this.blankSwapByPosChb.UseVisualStyleBackColor = true;
            // 
            // blankSwapEveryNFrameUd
            // 
            this.blankSwapEveryNFrameUd.DecimalPlaces = 4;
            this.blankSwapEveryNFrameUd.Location = new System.Drawing.Point(153, 18);
            this.blankSwapEveryNFrameUd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.blankSwapEveryNFrameUd.Name = "blankSwapEveryNFrameUd";
            this.blankSwapEveryNFrameUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapEveryNFrameUd.TabIndex = 3;
            this.blankSwapEveryNFrameUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blankSwapEveryNFrameChb
            // 
            this.blankSwapEveryNFrameChb.AutoSize = true;
            this.blankSwapEveryNFrameChb.Location = new System.Drawing.Point(6, 19);
            this.blankSwapEveryNFrameChb.Name = "blankSwapEveryNFrameChb";
            this.blankSwapEveryNFrameChb.Size = new System.Drawing.Size(137, 17);
            this.blankSwapEveryNFrameChb.TabIndex = 2;
            this.blankSwapEveryNFrameChb.Text = "Swap every Nth refresh";
            this.blankSwapEveryNFrameChb.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(232, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "H";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(129, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "W";
            // 
            // blankSwapCheckerHUd
            // 
            this.blankSwapCheckerHUd.DecimalPlaces = 4;
            this.blankSwapCheckerHUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.blankSwapCheckerHUd.Location = new System.Drawing.Point(253, 92);
            this.blankSwapCheckerHUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapCheckerHUd.Name = "blankSwapCheckerHUd";
            this.blankSwapCheckerHUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapCheckerHUd.TabIndex = 10;
            this.blankSwapCheckerHUd.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // blankSwapCheckerWUd
            // 
            this.blankSwapCheckerWUd.DecimalPlaces = 4;
            this.blankSwapCheckerWUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.blankSwapCheckerWUd.Location = new System.Drawing.Point(153, 92);
            this.blankSwapCheckerWUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapCheckerWUd.Name = "blankSwapCheckerWUd";
            this.blankSwapCheckerWUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapCheckerWUd.TabIndex = 9;
            this.blankSwapCheckerWUd.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // blankSwapCheckeredRb
            // 
            this.blankSwapCheckeredRb.AutoSize = true;
            this.blankSwapCheckeredRb.Location = new System.Drawing.Point(19, 92);
            this.blankSwapCheckeredRb.Name = "blankSwapCheckeredRb";
            this.blankSwapCheckeredRb.Size = new System.Drawing.Size(77, 17);
            this.blankSwapCheckeredRb.TabIndex = 8;
            this.blankSwapCheckeredRb.Text = "Checkered";
            this.blankSwapCheckeredRb.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(233, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 47;
            this.label30.Text = "Y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(133, 68);
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
            131072});
            this.blankSwapAfterYUd.Location = new System.Drawing.Point(253, 66);
            this.blankSwapAfterYUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapAfterYUd.Name = "blankSwapAfterYUd";
            this.blankSwapAfterYUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapAfterYUd.TabIndex = 7;
            this.blankSwapAfterYUd.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blankSwapRandomRb
            // 
            this.blankSwapRandomRb.AutoSize = true;
            this.blankSwapRandomRb.Location = new System.Drawing.Point(19, 117);
            this.blankSwapRandomRb.Name = "blankSwapRandomRb";
            this.blankSwapRandomRb.Size = new System.Drawing.Size(65, 17);
            this.blankSwapRandomRb.TabIndex = 11;
            this.blankSwapRandomRb.Text = "Random";
            this.blankSwapRandomRb.UseVisualStyleBackColor = true;
            // 
            // blankSwapAfterRb
            // 
            this.blankSwapAfterRb.AutoSize = true;
            this.blankSwapAfterRb.Checked = true;
            this.blankSwapAfterRb.Location = new System.Drawing.Point(19, 66);
            this.blankSwapAfterRb.Name = "blankSwapAfterRb";
            this.blankSwapAfterRb.Size = new System.Drawing.Size(86, 17);
            this.blankSwapAfterRb.TabIndex = 5;
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
            131072});
            this.blankSwapAfterXUd.Location = new System.Drawing.Point(153, 66);
            this.blankSwapAfterXUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blankSwapAfterXUd.Name = "blankSwapAfterXUd";
            this.blankSwapAfterXUd.Size = new System.Drawing.Size(59, 20);
            this.blankSwapAfterXUd.TabIndex = 6;
            // 
            // controlGb
            // 
            this.controlGb.Controls.Add(this.mainWinTopmostChb);
            this.controlGb.Controls.Add(this.startB);
            this.controlGb.Controls.Add(this.stopB);
            this.controlGb.Controls.Add(this.drawWinFullscreenChb);
            this.controlGb.Controls.Add(this.fpslabel);
            this.controlGb.Controls.Add(this.label2);
            this.controlGb.Controls.Add(this.label5);
            this.controlGb.Controls.Add(this.currentmonitorlabel);
            this.controlGb.Location = new System.Drawing.Point(12, 438);
            this.controlGb.Name = "controlGb";
            this.controlGb.Size = new System.Drawing.Size(975, 51);
            this.controlGb.TabIndex = 7;
            this.controlGb.TabStop = false;
            this.controlGb.Text = "Status and control";
            // 
            // coordRangesGb
            // 
            this.coordRangesGb.Controls.Add(this.label13);
            this.coordRangesGb.Controls.Add(this.coordGradientDitherOrderedRb);
            this.coordRangesGb.Controls.Add(this.coordRangeYInvertB);
            this.coordRangesGb.Controls.Add(this.coordGradientDitherRandomRb);
            this.coordRangesGb.Controls.Add(this.coordRangeXInvertB);
            this.coordRangesGb.Controls.Add(this.coordGradientDitherNoneRb);
            this.coordRangesGb.Controls.Add(this.label38);
            this.coordRangesGb.Controls.Add(this.coordRangeCMaxUd);
            this.coordRangesGb.Controls.Add(this.label39);
            this.coordRangesGb.Controls.Add(this.coordRangeCMinUd);
            this.coordRangesGb.Controls.Add(this.label40);
            this.coordRangesGb.Controls.Add(this.label35);
            this.coordRangesGb.Controls.Add(this.coordRangeYMaxUd);
            this.coordRangesGb.Controls.Add(this.label36);
            this.coordRangesGb.Controls.Add(this.coordRangeYMinUd);
            this.coordRangesGb.Controls.Add(this.label37);
            this.coordRangesGb.Controls.Add(this.label34);
            this.coordRangesGb.Controls.Add(this.coordRangeXMaxUd);
            this.coordRangesGb.Controls.Add(this.label33);
            this.coordRangesGb.Controls.Add(this.coordRangeXMinUd);
            this.coordRangesGb.Controls.Add(this.label32);
            this.coordRangesGb.Location = new System.Drawing.Point(666, 12);
            this.coordRangesGb.Name = "coordRangesGb";
            this.coordRangesGb.Size = new System.Drawing.Size(321, 144);
            this.coordRangesGb.TabIndex = 4;
            this.coordRangesGb.TabStop = false;
            this.coordRangesGb.Text = "Coordinate ranges";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Dithering";
            // 
            // coordGradientDitherOrderedRb
            // 
            this.coordGradientDitherOrderedRb.AutoSize = true;
            this.coordGradientDitherOrderedRb.Location = new System.Drawing.Point(235, 121);
            this.coordGradientDitherOrderedRb.Name = "coordGradientDitherOrderedRb";
            this.coordGradientDitherOrderedRb.Size = new System.Drawing.Size(78, 17);
            this.coordGradientDitherOrderedRb.TabIndex = 2;
            this.coordGradientDitherOrderedRb.Text = "Ordered 16";
            this.coordGradientDitherOrderedRb.UseVisualStyleBackColor = true;
            // 
            // coordRangeYInvertB
            // 
            this.coordRangeYInvertB.Location = new System.Drawing.Point(47, 45);
            this.coordRangeYInvertB.Name = "coordRangeYInvertB";
            this.coordRangeYInvertB.Size = new System.Drawing.Size(53, 23);
            this.coordRangeYInvertB.TabIndex = 3;
            this.coordRangeYInvertB.Text = "Invert";
            this.coordRangeYInvertB.UseVisualStyleBackColor = true;
            this.coordRangeYInvertB.Click += new System.EventHandler(this.coordRangeYInvertB_Click);
            // 
            // coordGradientDitherRandomRb
            // 
            this.coordGradientDitherRandomRb.AutoSize = true;
            this.coordGradientDitherRandomRb.Checked = true;
            this.coordGradientDitherRandomRb.Location = new System.Drawing.Point(126, 121);
            this.coordGradientDitherRandomRb.Name = "coordGradientDitherRandomRb";
            this.coordGradientDitherRandomRb.Size = new System.Drawing.Size(93, 17);
            this.coordGradientDitherRandomRb.TabIndex = 1;
            this.coordGradientDitherRandomRb.TabStop = true;
            this.coordGradientDitherRandomRb.Text = "Random noise";
            this.coordGradientDitherRandomRb.UseVisualStyleBackColor = true;
            // 
            // coordRangeXInvertB
            // 
            this.coordRangeXInvertB.Location = new System.Drawing.Point(47, 19);
            this.coordRangeXInvertB.Name = "coordRangeXInvertB";
            this.coordRangeXInvertB.Size = new System.Drawing.Size(53, 23);
            this.coordRangeXInvertB.TabIndex = 0;
            this.coordRangeXInvertB.Text = "Invert";
            this.coordRangeXInvertB.UseVisualStyleBackColor = true;
            this.coordRangeXInvertB.Click += new System.EventHandler(this.coordRangeXInvertB_Click);
            // 
            // coordGradientDitherNoneRb
            // 
            this.coordGradientDitherNoneRb.AutoSize = true;
            this.coordGradientDitherNoneRb.Location = new System.Drawing.Point(47, 121);
            this.coordGradientDitherNoneRb.Name = "coordGradientDitherNoneRb";
            this.coordGradientDitherNoneRb.Size = new System.Drawing.Size(51, 17);
            this.coordGradientDitherNoneRb.TabIndex = 0;
            this.coordGradientDitherNoneRb.Text = "None";
            this.coordGradientDitherNoneRb.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(221, 76);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(27, 13);
            this.label38.TabIndex = 14;
            this.label38.Text = "Max";
            // 
            // coordRangeCMaxUd
            // 
            this.coordRangeCMaxUd.DecimalPlaces = 4;
            this.coordRangeCMaxUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeCMaxUd.Location = new System.Drawing.Point(254, 74);
            this.coordRangeCMaxUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeCMaxUd.Name = "coordRangeCMaxUd";
            this.coordRangeCMaxUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeCMaxUd.TabIndex = 7;
            this.coordRangeCMaxUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(106, 76);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(24, 13);
            this.label39.TabIndex = 12;
            this.label39.Text = "Min";
            // 
            // coordRangeCMinUd
            // 
            this.coordRangeCMinUd.DecimalPlaces = 4;
            this.coordRangeCMinUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeCMinUd.Location = new System.Drawing.Point(136, 74);
            this.coordRangeCMinUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeCMinUd.Name = "coordRangeCMinUd";
            this.coordRangeCMinUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeCMinUd.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(7, 76);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 13);
            this.label40.TabIndex = 10;
            this.label40.Text = "Constant";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(221, 50);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Max";
            // 
            // coordRangeYMaxUd
            // 
            this.coordRangeYMaxUd.DecimalPlaces = 4;
            this.coordRangeYMaxUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeYMaxUd.Location = new System.Drawing.Point(254, 48);
            this.coordRangeYMaxUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeYMaxUd.Name = "coordRangeYMaxUd";
            this.coordRangeYMaxUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeYMaxUd.TabIndex = 5;
            this.coordRangeYMaxUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(106, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(24, 13);
            this.label36.TabIndex = 7;
            this.label36.Text = "Min";
            // 
            // coordRangeYMinUd
            // 
            this.coordRangeYMinUd.DecimalPlaces = 4;
            this.coordRangeYMinUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeYMinUd.Location = new System.Drawing.Point(136, 48);
            this.coordRangeYMinUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeYMinUd.Name = "coordRangeYMinUd";
            this.coordRangeYMinUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeYMinUd.TabIndex = 4;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 5;
            this.label37.Text = "Y";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(221, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 4;
            this.label34.Text = "Max";
            // 
            // coordRangeXMaxUd
            // 
            this.coordRangeXMaxUd.DecimalPlaces = 4;
            this.coordRangeXMaxUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeXMaxUd.Location = new System.Drawing.Point(254, 22);
            this.coordRangeXMaxUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeXMaxUd.Name = "coordRangeXMaxUd";
            this.coordRangeXMaxUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeXMaxUd.TabIndex = 2;
            this.coordRangeXMaxUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(106, 24);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Min";
            // 
            // coordRangeXMinUd
            // 
            this.coordRangeXMinUd.DecimalPlaces = 4;
            this.coordRangeXMinUd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.coordRangeXMinUd.Location = new System.Drawing.Point(136, 22);
            this.coordRangeXMinUd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coordRangeXMinUd.Name = "coordRangeXMinUd";
            this.coordRangeXMinUd.Size = new System.Drawing.Size(59, 20);
            this.coordRangeXMinUd.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blankSwapEveryNFrameChb);
            this.groupBox1.Controls.Add(this.blankSwapAfterXUd);
            this.groupBox1.Controls.Add(this.blankSwapByPosChb);
            this.groupBox1.Controls.Add(this.blankSwapAfterRb);
            this.groupBox1.Controls.Add(this.blankSwapEveryNFrameUd);
            this.groupBox1.Controls.Add(this.blankSwapRandomRb);
            this.groupBox1.Controls.Add(this.blankSwapAfterYUd);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.blankSwapCheckerHUd);
            this.groupBox1.Controls.Add(this.blankSwapCheckeredRb);
            this.groupBox1.Controls.Add(this.blankSwapCheckerWUd);
            this.groupBox1.Location = new System.Drawing.Point(339, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 bit blanking level changing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourceImagesGb);
            this.Controls.Add(this.imageGb);
            this.Controls.Add(this.oneBitLevelsGb);
            this.Controls.Add(this.oneBitMethodGb);
            this.Controls.Add(this.coordRangesGb);
            this.Controls.Add(this.vgaChannelMappingGb);
            this.Controls.Add(this.outputGb);
            this.Controls.Add(this.controlGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGA oscilloscope drawing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.vgaChannelMappingGb.ResumeLayout(false);
            this.vgaChannelMappingGb.PerformLayout();
            this.sourceImagesGb.ResumeLayout(false);
            this.sourceImagesGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaHUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaWUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureAreaYUd)).EndInit();
            this.outputGb.ResumeLayout(false);
            this.outputGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsBottomUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsRightUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsLeftUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoundsTopUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationFpsUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshrateud)).EndInit();
            this.oneBitMethodGb.ResumeLayout(false);
            this.oneBitMethodGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ditherOrderedShiftFrameUd)).EndInit();
            this.imageGb.ResumeLayout(false);
            this.imageGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageScaleYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageScaleXUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshWhiteUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toneThreshBlackUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBlueUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleGreenUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleRedUd)).EndInit();
            this.oneBitLevelsGb.ResumeLayout(false);
            this.oneBitLevelsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearestActiveDistanceUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueTopUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankValueBottomUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapEveryNFrameUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapCheckerHUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapCheckerWUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterYUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankSwapAfterXUd)).EndInit();
            this.controlGb.ResumeLayout(false);
            this.controlGb.PerformLayout();
            this.coordRangesGb.ResumeLayout(false);
            this.coordRangesGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeCMaxUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeCMinUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeYMaxUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeYMinUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeXMaxUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordRangeXMinUd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox vgaChannelMappingGb;
        private System.Windows.Forms.ComboBox channelMapBlueCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox channelMapGreenCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox channelMapRedCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox sourceImagesGb;
        private System.Windows.Forms.Button selectFramesPathB;
        private System.Windows.Forms.TextBox framesdirpathed;
        private System.Windows.Forms.GroupBox outputGb;
        private System.Windows.Forms.CheckBox enableAntialiasingChb;
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
        private System.Windows.Forms.GroupBox oneBitMethodGb;
        private System.Windows.Forms.RadioButton oneBitMethodPwmRb;
        private System.Windows.Forms.RadioButton oneBitMethodOrderedRb;
        private System.Windows.Forms.RadioButton oneBitMethodRandomRb;
        private System.Windows.Forms.GroupBox imageGb;
        private System.Windows.Forms.NumericUpDown grayscaleRedUd;
        private System.Windows.Forms.NumericUpDown gammaUd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button grayscaleDefB;
        private System.Windows.Forms.NumericUpDown grayscaleBlueUd;
        private System.Windows.Forms.NumericUpDown grayscaleGreenUd;
        private System.Windows.Forms.Label grayscaleBlueLabel;
        private System.Windows.Forms.Label grayscaleGreenLabel;
        private System.Windows.Forms.Label grayscaleRedLabel;
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
        private System.Windows.Forms.GroupBox oneBitLevelsGb;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown blankValueTopUd;
        private System.Windows.Forms.NumericUpDown blankValueBottomUd;
        private System.Windows.Forms.RadioButton blankSwapRandomRb;
        private System.Windows.Forms.RadioButton blankSwapAfterRb;
        private System.Windows.Forms.NumericUpDown blankSwapAfterXUd;
        private System.Windows.Forms.CheckBox vgachannel1BitGreenChb;
        private System.Windows.Forms.CheckBox vgachannel1BitRedChb;
        private System.Windows.Forms.CheckBox vgachannel1BitBlueChb;
        private System.Windows.Forms.GroupBox controlGb;
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
        private System.Windows.Forms.NumericUpDown blankSwapCheckerHUd;
        private System.Windows.Forms.NumericUpDown blankSwapCheckerWUd;
        private System.Windows.Forms.RadioButton blankSwapCheckeredRb;
        private System.Windows.Forms.CheckBox colorInvertChb;
        private System.Windows.Forms.GroupBox coordRangesGb;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown coordRangeYMaxUd;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown coordRangeYMinUd;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown coordRangeXMaxUd;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown coordRangeXMinUd;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown coordRangeCMaxUd;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown coordRangeCMinUd;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button coordRangeYInvertB;
        private System.Windows.Forms.Button coordRangeXInvertB;
        private System.Windows.Forms.NumericUpDown blankSwapEveryNFrameUd;
        private System.Windows.Forms.CheckBox blankSwapEveryNFrameChb;
        private System.Windows.Forms.CheckBox blankSwapByPosChb;
        private System.Windows.Forms.ComboBox oneBitOrderedMatrixSizeCb;
        private System.Windows.Forms.Button outBoundsFlipHB;
        private System.Windows.Forms.Button outBoundsFlipVB;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown imageScaleYUd;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown imageScaleXUd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton coordGradientDitherOrderedRb;
        private System.Windows.Forms.RadioButton coordGradientDitherRandomRb;
        private System.Windows.Forms.RadioButton coordGradientDitherNoneRb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown captureAreaHUd;
        private System.Windows.Forms.NumericUpDown captureAreaWUd;
        private System.Windows.Forms.NumericUpDown captureAreaXUd;
        private System.Windows.Forms.NumericUpDown captureAreaYUd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox captureMonitorCb;
        private System.Windows.Forms.Button captureMonitorRefreshB;
        private System.Windows.Forms.RadioButton frameSourceScreenCaptureRb;
        private System.Windows.Forms.RadioButton frameSourceFileRb;
        private System.Windows.Forms.CheckBox allFramesFromDirChb;
        private System.Windows.Forms.NumericUpDown brightnessUd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button captureAreaFullB;
        private System.Windows.Forms.NumericUpDown contrastUd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button colorLevelsResetB;
        private System.Windows.Forms.RadioButton oneBitBlankLevelsNearestActiveRb;
        private System.Windows.Forms.RadioButton oneBitBlankLevelsConstantRb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nearestActiveNextChb;
        private System.Windows.Forms.CheckBox nearestActivePrevChb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nearestActiveDistanceUd;
    }
}