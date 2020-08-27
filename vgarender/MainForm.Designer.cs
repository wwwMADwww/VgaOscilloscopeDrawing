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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mapGb = new System.Windows.Forms.GroupBox();
            this.vgachannelinvertBlueChb = new System.Windows.Forms.CheckBox();
            this.vgachannelinvertGreenChb = new System.Windows.Forms.CheckBox();
            this.vgachannelinvertRedChb = new System.Windows.Forms.CheckBox();
            this.channelMapBlueCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.channelMapGreenCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.channelMapRedCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sourceGb = new System.Windows.Forms.GroupBox();
            this.imageColorZCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pathDirRb = new System.Windows.Forms.RadioButton();
            this.pathFileRb = new System.Windows.Forms.RadioButton();
            this.selectFramesPathB = new System.Windows.Forms.Button();
            this.framesdirpathed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputGb = new System.Windows.Forms.GroupBox();
            this.swapxyChb = new System.Windows.Forms.CheckBox();
            this.disableAntialiasingChb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frameintervalud = new System.Windows.Forms.NumericUpDown();
            this.refreshMonitoListB = new System.Windows.Forms.Button();
            this.monitorListCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frameproctimelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentmonitorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawWinFullscreenChb = new System.Windows.Forms.CheckBox();
            this.mainWinTopmostChb = new System.Windows.Forms.CheckBox();
            this.swapxyB = new System.Windows.Forms.Button();
            this.mapGb.SuspendLayout();
            this.sourceGb.SuspendLayout();
            this.outputGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameintervalud)).BeginInit();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(328, 163);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 23);
            this.startB.TabIndex = 8;
            this.startB.Text = "(re)start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(328, 134);
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
            this.openFileDialog1.Filter = "BMP|*.bmp|All files|*.*";
            this.openFileDialog1.ValidateNames = false;
            // 
            // mapGb
            // 
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
            this.mapGb.Location = new System.Drawing.Point(12, 142);
            this.mapGb.Name = "mapGb";
            this.mapGb.Size = new System.Drawing.Size(409, 102);
            this.mapGb.TabIndex = 1;
            this.mapGb.TabStop = false;
            this.mapGb.Text = "VGA channel mapping";
            // 
            // vgachannelinvertBlueChb
            // 
            this.vgachannelinvertBlueChb.AutoSize = true;
            this.vgachannelinvertBlueChb.Location = new System.Drawing.Point(44, 75);
            this.vgachannelinvertBlueChb.Name = "vgachannelinvertBlueChb";
            this.vgachannelinvertBlueChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertBlueChb.TabIndex = 5;
            this.vgachannelinvertBlueChb.Text = "Invert";
            this.vgachannelinvertBlueChb.UseVisualStyleBackColor = true;
            // 
            // vgachannelinvertGreenChb
            // 
            this.vgachannelinvertGreenChb.AutoSize = true;
            this.vgachannelinvertGreenChb.Location = new System.Drawing.Point(44, 48);
            this.vgachannelinvertGreenChb.Name = "vgachannelinvertGreenChb";
            this.vgachannelinvertGreenChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertGreenChb.TabIndex = 3;
            this.vgachannelinvertGreenChb.Text = "Invert";
            this.vgachannelinvertGreenChb.UseVisualStyleBackColor = true;
            // 
            // vgachannelinvertRedChb
            // 
            this.vgachannelinvertRedChb.AutoSize = true;
            this.vgachannelinvertRedChb.Location = new System.Drawing.Point(44, 21);
            this.vgachannelinvertRedChb.Name = "vgachannelinvertRedChb";
            this.vgachannelinvertRedChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertRedChb.TabIndex = 1;
            this.vgachannelinvertRedChb.Text = "Invert";
            this.vgachannelinvertRedChb.UseVisualStyleBackColor = true;
            // 
            // channelMapBlueCb
            // 
            this.channelMapBlueCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapBlueCb.FormattingEnabled = true;
            this.channelMapBlueCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.channelMapBlueCb.Location = new System.Drawing.Point(107, 73);
            this.channelMapBlueCb.Name = "channelMapBlueCb";
            this.channelMapBlueCb.Size = new System.Drawing.Size(213, 21);
            this.channelMapBlueCb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Blue";
            // 
            // channelMapGreenCb
            // 
            this.channelMapGreenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapGreenCb.FormattingEnabled = true;
            this.channelMapGreenCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.channelMapGreenCb.Location = new System.Drawing.Point(107, 46);
            this.channelMapGreenCb.Name = "channelMapGreenCb";
            this.channelMapGreenCb.Size = new System.Drawing.Size(213, 21);
            this.channelMapGreenCb.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Green";
            // 
            // channelMapRedCb
            // 
            this.channelMapRedCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelMapRedCb.FormattingEnabled = true;
            this.channelMapRedCb.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.channelMapRedCb.Location = new System.Drawing.Point(107, 19);
            this.channelMapRedCb.Name = "channelMapRedCb";
            this.channelMapRedCb.Size = new System.Drawing.Size(213, 21);
            this.channelMapRedCb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Red";
            // 
            // sourceGb
            // 
            this.sourceGb.Controls.Add(this.label11);
            this.sourceGb.Controls.Add(this.label3);
            this.sourceGb.Controls.Add(this.framesdirpathed);
            this.sourceGb.Controls.Add(this.selectFramesPathB);
            this.sourceGb.Controls.Add(this.pathFileRb);
            this.sourceGb.Controls.Add(this.pathDirRb);
            this.sourceGb.Controls.Add(this.swapxyChb);
            this.sourceGb.Controls.Add(this.imageColorZCb);
            this.sourceGb.Location = new System.Drawing.Point(12, 12);
            this.sourceGb.Name = "sourceGb";
            this.sourceGb.Size = new System.Drawing.Size(409, 124);
            this.sourceGb.TabIndex = 0;
            this.sourceGb.TabStop = false;
            this.sourceGb.Text = "Source images";
            // 
            // imageColorZCb
            // 
            this.imageColorZCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageColorZCb.FormattingEnabled = true;
            this.imageColorZCb.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Grayscale from all channels"});
            this.imageColorZCb.Location = new System.Drawing.Point(107, 91);
            this.imageColorZCb.Name = "imageColorZCb";
            this.imageColorZCb.Size = new System.Drawing.Size(213, 21);
            this.imageColorZCb.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Image color for Z";
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
            // selectFramesPathB
            // 
            this.selectFramesPathB.Location = new System.Drawing.Point(326, 17);
            this.selectFramesPathB.Name = "selectFramesPathB";
            this.selectFramesPathB.Size = new System.Drawing.Size(75, 23);
            this.selectFramesPathB.TabIndex = 1;
            this.selectFramesPathB.Text = "Select...";
            this.selectFramesPathB.UseVisualStyleBackColor = true;
            this.selectFramesPathB.Click += new System.EventHandler(this.selectFramesPathB_Click);
            // 
            // framesdirpathed
            // 
            this.framesdirpathed.Location = new System.Drawing.Point(44, 19);
            this.framesdirpathed.MaxLength = 260;
            this.framesdirpathed.Name = "framesdirpathed";
            this.framesdirpathed.Size = new System.Drawing.Size(276, 20);
            this.framesdirpathed.TabIndex = 0;
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
            // outputGb
            // 
            this.outputGb.Controls.Add(this.frameproctimelabel);
            this.outputGb.Controls.Add(this.label5);
            this.outputGb.Controls.Add(this.currentmonitorlabel);
            this.outputGb.Controls.Add(this.label2);
            this.outputGb.Controls.Add(this.label4);
            this.outputGb.Controls.Add(this.label1);
            this.outputGb.Controls.Add(this.monitorListCb);
            this.outputGb.Controls.Add(this.refreshMonitoListB);
            this.outputGb.Controls.Add(this.frameintervalud);
            this.outputGb.Controls.Add(this.disableAntialiasingChb);
            this.outputGb.Controls.Add(this.mainWinTopmostChb);
            this.outputGb.Controls.Add(this.drawWinFullscreenChb);
            this.outputGb.Controls.Add(this.stopB);
            this.outputGb.Controls.Add(this.startB);
            this.outputGb.Location = new System.Drawing.Point(12, 250);
            this.outputGb.Name = "outputGb";
            this.outputGb.Size = new System.Drawing.Size(409, 194);
            this.outputGb.TabIndex = 2;
            this.outputGb.TabStop = false;
            this.outputGb.Text = "Output";
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
            // disableAntialiasingChb
            // 
            this.disableAntialiasingChb.AutoSize = true;
            this.disableAntialiasingChb.Location = new System.Drawing.Point(9, 72);
            this.disableAntialiasingChb.Name = "disableAntialiasingChb";
            this.disableAntialiasingChb.Size = new System.Drawing.Size(116, 17);
            this.disableAntialiasingChb.TabIndex = 3;
            this.disableAntialiasingChb.Text = "Disable antialiasing";
            this.disableAntialiasingChb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Frame interval (ms)";
            // 
            // frameintervalud
            // 
            this.frameintervalud.Location = new System.Drawing.Point(107, 46);
            this.frameintervalud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frameintervalud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameintervalud.Name = "frameintervalud";
            this.frameintervalud.Size = new System.Drawing.Size(213, 20);
            this.frameintervalud.TabIndex = 2;
            this.frameintervalud.Value = new decimal(new int[] {
            66,
            0,
            0,
            0});
            // 
            // refreshMonitoListB
            // 
            this.refreshMonitoListB.Location = new System.Drawing.Point(326, 17);
            this.refreshMonitoListB.Name = "refreshMonitoListB";
            this.refreshMonitoListB.Size = new System.Drawing.Size(75, 23);
            this.refreshMonitoListB.TabIndex = 1;
            this.refreshMonitoListB.Text = "Refresh list";
            this.refreshMonitoListB.UseVisualStyleBackColor = true;
            this.refreshMonitoListB.Click += new System.EventHandler(this.refreshMonitoListB_Click);
            // 
            // monitorListCb
            // 
            this.monitorListCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorListCb.FormattingEnabled = true;
            this.monitorListCb.Location = new System.Drawing.Point(107, 19);
            this.monitorListCb.Name = "monitorListCb";
            this.monitorListCb.Size = new System.Drawing.Size(213, 21);
            this.monitorListCb.TabIndex = 0;
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
            // frameproctimelabel
            // 
            this.frameproctimelabel.AutoSize = true;
            this.frameproctimelabel.Location = new System.Drawing.Point(166, 166);
            this.frameproctimelabel.Name = "frameproctimelabel";
            this.frameproctimelabel.Size = new System.Drawing.Size(10, 13);
            this.frameproctimelabel.TabIndex = 2;
            this.frameproctimelabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Last frame processing time (ms)";
            // 
            // currentmonitorlabel
            // 
            this.currentmonitorlabel.AutoSize = true;
            this.currentmonitorlabel.Location = new System.Drawing.Point(104, 144);
            this.currentmonitorlabel.Name = "currentmonitorlabel";
            this.currentmonitorlabel.Size = new System.Drawing.Size(25, 13);
            this.currentmonitorlabel.TabIndex = 43;
            this.currentmonitorlabel.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Current monitor";
            // 
            // drawWinFullscreenChb
            // 
            this.drawWinFullscreenChb.AutoSize = true;
            this.drawWinFullscreenChb.Checked = true;
            this.drawWinFullscreenChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawWinFullscreenChb.Location = new System.Drawing.Point(9, 118);
            this.drawWinFullscreenChb.Name = "drawWinFullscreenChb";
            this.drawWinFullscreenChb.Size = new System.Drawing.Size(152, 17);
            this.drawWinFullscreenChb.TabIndex = 6;
            this.drawWinFullscreenChb.Text = "Drawing window fullscreen";
            this.drawWinFullscreenChb.UseVisualStyleBackColor = true;
            // 
            // mainWinTopmostChb
            // 
            this.mainWinTopmostChb.AutoSize = true;
            this.mainWinTopmostChb.Checked = true;
            this.mainWinTopmostChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainWinTopmostChb.Location = new System.Drawing.Point(9, 95);
            this.mainWinTopmostChb.Name = "mainWinTopmostChb";
            this.mainWinTopmostChb.Size = new System.Drawing.Size(143, 17);
            this.mainWinTopmostChb.TabIndex = 5;
            this.mainWinTopmostChb.Text = "Main window stay on top";
            this.mainWinTopmostChb.UseVisualStyleBackColor = true;
            // 
            // swapxyB
            // 
            this.swapxyB.Location = new System.Drawing.Point(326, 17);
            this.swapxyB.Name = "swapxyB";
            this.swapxyB.Size = new System.Drawing.Size(75, 23);
            this.swapxyB.TabIndex = 7;
            this.swapxyB.Text = "Swap X Y";
            this.swapxyB.UseVisualStyleBackColor = true;
            this.swapxyB.Click += new System.EventHandler(this.swapxyB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 454);
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
            ((System.ComponentModel.ISupportInitialize)(this.frameintervalud)).EndInit();
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
        private System.Windows.Forms.ComboBox imageColorZCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox outputGb;
        private System.Windows.Forms.CheckBox disableAntialiasingChb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown frameintervalud;
        private System.Windows.Forms.Button refreshMonitoListB;
        private System.Windows.Forms.ComboBox monitorListCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frameproctimelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentmonitorlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox swapxyChb;
        private System.Windows.Forms.CheckBox drawWinFullscreenChb;
        private System.Windows.Forms.CheckBox mainWinTopmostChb;
        private System.Windows.Forms.Button swapxyB;
    }
}