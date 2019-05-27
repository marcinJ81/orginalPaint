namespace paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.nudTRackBar = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grbTools = new System.Windows.Forms.GroupBox();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.grbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Location = new System.Drawing.Point(12, 27);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(755, 460);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.SizeChanged += new System.EventHandler(this.canvasPanel_SizeChanged);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            this.canvasPanel.Resize += new System.EventHandler(this.canvasPanel_Resize);
            // 
            // gBox
            // 
            this.gBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBox.Controls.Add(this.nudTRackBar);
            this.gBox.Controls.Add(this.trackBar1);
            this.gBox.Controls.Add(this.colorPanel);
            this.gBox.Location = new System.Drawing.Point(12, 493);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(851, 98);
            this.gBox.TabIndex = 1;
            this.gBox.TabStop = false;
            this.gBox.Text = "Kolor i grubość";
            // 
            // nudTRackBar
            // 
            this.nudTRackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTRackBar.Location = new System.Drawing.Point(767, 38);
            this.nudTRackBar.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTRackBar.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTRackBar.Name = "nudTRackBar";
            this.nudTRackBar.Size = new System.Drawing.Size(60, 26);
            this.nudTRackBar.TabIndex = 3;
            this.nudTRackBar.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTRackBar.ValueChanged += new System.EventHandler(this.nudTRackBar_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(76, 25);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(698, 64);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(6, 25);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(64, 64);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPanel_Paint);
            this.colorPanel.DoubleClick += new System.EventHandler(this.colorPanel_DoubleClick);
            // 
            // grbTools
            // 
            this.grbTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTools.Controls.Add(this.nudAngle);
            this.grbTools.Controls.Add(this.button9);
            this.grbTools.Controls.Add(this.button8);
            this.grbTools.Controls.Add(this.button7);
            this.grbTools.Controls.Add(this.button6);
            this.grbTools.Controls.Add(this.button5);
            this.grbTools.Controls.Add(this.button4);
            this.grbTools.Controls.Add(this.button3);
            this.grbTools.Controls.Add(this.button2);
            this.grbTools.Controls.Add(this.button1);
            this.grbTools.Location = new System.Drawing.Point(773, 12);
            this.grbTools.Name = "grbTools";
            this.grbTools.Size = new System.Drawing.Size(103, 475);
            this.grbTools.TabIndex = 2;
            this.grbTools.TabStop = false;
            this.grbTools.Text = "Narzędzia";
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(7, 446);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(75, 26);
            this.nudAngle.TabIndex = 12;
            this.nudAngle.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 407);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "cofnij";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 28);
            this.button8.TabIndex = 10;
            this.button8.Text = "obrót";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 314);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 51);
            this.button7.TabIndex = 9;
            this.button7.Text = "rpostokat pelny";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 57);
            this.button6.TabIndex = 8;
            this.button6.Text = "gumka";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "elipsa pełna";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Elipsa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pęddzel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Linia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prostkąt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "toolStripButton1";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "toolStripButton2";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 603);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbTools);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.canvasPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.grbTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox grbTools;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown nudTRackBar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown nudAngle;
    }
}

