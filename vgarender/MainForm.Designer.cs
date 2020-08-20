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
            this.topmostChb = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vgachannelinvertBlueChb = new System.Windows.Forms.CheckBox();
            this.vgachannelinvertGreenChb = new System.Windows.Forms.CheckBox();
            this.vgachannelinvertRedChb = new System.Windows.Forms.CheckBox();
            this.channelMapBlueCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.channelMapGreenCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.channelMapRedCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectFramesPathB = new System.Windows.Forms.Button();
            this.framesdirpathed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathFileRb = new System.Windows.Forms.RadioButton();
            this.pathDirRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.blankFramesUd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.frameintervalud = new System.Windows.Forms.NumericUpDown();
            this.refreshMonitoListB = new System.Windows.Forms.Button();
            this.monitorListCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disableAntialiasingChb = new System.Windows.Forms.CheckBox();
            this.imageColorZCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.frameproctimelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentmonitorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.swapxyChb = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blankFramesUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameintervalud)).BeginInit();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(338, 404);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(75, 23);
            this.startB.TabIndex = 0;
            this.startB.Text = "(re)start";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(338, 375);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(75, 23);
            this.stopB.TabIndex = 1;
            this.stopB.Text = "stop";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topmostChb
            // 
            this.topmostChb.AutoSize = true;
            this.topmostChb.Checked = true;
            this.topmostChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topmostChb.Location = new System.Drawing.Point(252, 408);
            this.topmostChb.Name = "topmostChb";
            this.topmostChb.Size = new System.Drawing.Size(80, 17);
            this.topmostChb.TabIndex = 11;
            this.topmostChb.Text = "Stay on top";
            this.topmostChb.UseVisualStyleBackColor = true;
            this.topmostChb.CheckedChanged += new System.EventHandler(this.topmostChb_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "dir";
            this.openFileDialog1.Filter = "BMP|*.bmp|All files|*.*";
            this.openFileDialog1.ValidateNames = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vgachannelinvertBlueChb);
            this.groupBox3.Controls.Add(this.vgachannelinvertGreenChb);
            this.groupBox3.Controls.Add(this.vgachannelinvertRedChb);
            this.groupBox3.Controls.Add(this.channelMapBlueCb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.channelMapGreenCb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.channelMapRedCb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 102);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VGA channel mapping";
            // 
            // vgachannelinvertBlueChb
            // 
            this.vgachannelinvertBlueChb.AutoSize = true;
            this.vgachannelinvertBlueChb.Location = new System.Drawing.Point(44, 75);
            this.vgachannelinvertBlueChb.Name = "vgachannelinvertBlueChb";
            this.vgachannelinvertBlueChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertBlueChb.TabIndex = 22;
            this.vgachannelinvertBlueChb.Text = "Invert";
            this.vgachannelinvertBlueChb.UseVisualStyleBackColor = true;
            // 
            // vgachannelinvertGreenChb
            // 
            this.vgachannelinvertGreenChb.AutoSize = true;
            this.vgachannelinvertGreenChb.Location = new System.Drawing.Point(44, 48);
            this.vgachannelinvertGreenChb.Name = "vgachannelinvertGreenChb";
            this.vgachannelinvertGreenChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertGreenChb.TabIndex = 21;
            this.vgachannelinvertGreenChb.Text = "Invert";
            this.vgachannelinvertGreenChb.UseVisualStyleBackColor = true;
            // 
            // vgachannelinvertRedChb
            // 
            this.vgachannelinvertRedChb.AutoSize = true;
            this.vgachannelinvertRedChb.Location = new System.Drawing.Point(44, 21);
            this.vgachannelinvertRedChb.Name = "vgachannelinvertRedChb";
            this.vgachannelinvertRedChb.Size = new System.Drawing.Size(53, 17);
            this.vgachannelinvertRedChb.TabIndex = 20;
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
            this.channelMapBlueCb.TabIndex = 19;
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
            this.channelMapGreenCb.TabIndex = 17;
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
            this.channelMapRedCb.TabIndex = 15;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageColorZCb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pathDirRb);
            this.groupBox1.Controls.Add(this.pathFileRb);
            this.groupBox1.Controls.Add(this.selectFramesPathB);
            this.groupBox1.Controls.Add(this.framesdirpathed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 98);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source images";
            // 
            // selectFramesPathB
            // 
            this.selectFramesPathB.Location = new System.Drawing.Point(326, 17);
            this.selectFramesPathB.Name = "selectFramesPathB";
            this.selectFramesPathB.Size = new System.Drawing.Size(75, 23);
            this.selectFramesPathB.TabIndex = 12;
            this.selectFramesPathB.Text = "Select...";
            this.selectFramesPathB.UseVisualStyleBackColor = true;
            this.selectFramesPathB.Click += new System.EventHandler(this.selectFramesPathB_Click);
            // 
            // framesdirpathed
            // 
            this.framesdirpathed.Location = new System.Drawing.Point(44, 19);
            this.framesdirpathed.Name = "framesdirpathed";
            this.framesdirpathed.Size = new System.Drawing.Size(276, 20);
            this.framesdirpathed.TabIndex = 11;
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
            // pathFileRb
            // 
            this.pathFileRb.AutoSize = true;
            this.pathFileRb.Checked = true;
            this.pathFileRb.Location = new System.Drawing.Point(9, 45);
            this.pathFileRb.Name = "pathFileRb";
            this.pathFileRb.Size = new System.Drawing.Size(105, 17);
            this.pathFileRb.TabIndex = 13;
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
            this.pathDirRb.TabIndex = 14;
            this.pathDirRb.Text = "All files in directory";
            this.pathDirRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.swapxyChb);
            this.groupBox2.Controls.Add(this.disableAntialiasingChb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.blankFramesUd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.frameintervalud);
            this.groupBox2.Controls.Add(this.refreshMonitoListB);
            this.groupBox2.Controls.Add(this.monitorListCb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 145);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Blank frames";
            // 
            // blankFramesUd
            // 
            this.blankFramesUd.Location = new System.Drawing.Point(107, 72);
            this.blankFramesUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.blankFramesUd.Name = "blankFramesUd";
            this.blankFramesUd.Size = new System.Drawing.Size(213, 20);
            this.blankFramesUd.TabIndex = 36;
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
            this.frameintervalud.TabIndex = 34;
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
            this.refreshMonitoListB.TabIndex = 33;
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
            this.monitorListCb.TabIndex = 32;
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
            // disableAntialiasingChb
            // 
            this.disableAntialiasingChb.AutoSize = true;
            this.disableAntialiasingChb.Location = new System.Drawing.Point(9, 121);
            this.disableAntialiasingChb.Name = "disableAntialiasingChb";
            this.disableAntialiasingChb.Size = new System.Drawing.Size(116, 17);
            this.disableAntialiasingChb.TabIndex = 42;
            this.disableAntialiasingChb.Text = "Disable antialiasing";
            this.disableAntialiasingChb.UseVisualStyleBackColor = true;
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
            this.imageColorZCb.Location = new System.Drawing.Point(107, 68);
            this.imageColorZCb.Name = "imageColorZCb";
            this.imageColorZCb.Size = new System.Drawing.Size(213, 21);
            this.imageColorZCb.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Image color for Z";
            // 
            // frameproctimelabel
            // 
            this.frameproctimelabel.AutoSize = true;
            this.frameproctimelabel.Location = new System.Drawing.Point(178, 407);
            this.frameproctimelabel.Name = "frameproctimelabel";
            this.frameproctimelabel.Size = new System.Drawing.Size(10, 13);
            this.frameproctimelabel.TabIndex = 45;
            this.frameproctimelabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Last frame processing time (ms)";
            // 
            // currentmonitorlabel
            // 
            this.currentmonitorlabel.AutoSize = true;
            this.currentmonitorlabel.Location = new System.Drawing.Point(116, 385);
            this.currentmonitorlabel.Name = "currentmonitorlabel";
            this.currentmonitorlabel.Size = new System.Drawing.Size(25, 13);
            this.currentmonitorlabel.TabIndex = 43;
            this.currentmonitorlabel.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Current monitor";
            // 
            // rotateImageChb
            // 
            this.swapxyChb.AutoSize = true;
            this.swapxyChb.Location = new System.Drawing.Point(9, 98);
            this.swapxyChb.Name = "rotateImageChb";
            this.swapxyChb.Size = new System.Drawing.Size(220, 17);
            this.swapxyChb.TabIndex = 43;
            this.swapxyChb.Text = "Rotate image 90 degrees (swap X and Y)";
            this.swapxyChb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 436);
            this.Controls.Add(this.frameproctimelabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentmonitorlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.topmostChb);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.startB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGA oscilloscope drawing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blankFramesUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameintervalud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox topmostChb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox channelMapBlueCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox channelMapGreenCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox channelMapRedCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox vgachannelinvertBlueChb;
        private System.Windows.Forms.CheckBox vgachannelinvertGreenChb;
        private System.Windows.Forms.CheckBox vgachannelinvertRedChb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pathDirRb;
        private System.Windows.Forms.RadioButton pathFileRb;
        private System.Windows.Forms.Button selectFramesPathB;
        private System.Windows.Forms.TextBox framesdirpathed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox imageColorZCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox disableAntialiasingChb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown blankFramesUd;
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
    }
}