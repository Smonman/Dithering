namespace Dithering_0 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox_display = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox_grayscale = new System.Windows.Forms.CheckBox();
			this.checkBox_showEveryStep = new System.Windows.Forms.CheckBox();
			this.checkBox_dither = new System.Windows.Forms.CheckBox();
			this.button_saveImage = new System.Windows.Forms.Button();
			this.button_dither = new System.Windows.Forms.Button();
			this.button_loadImage = new System.Windows.Forms.Button();
			this.backgroundWorker_ditherer = new System.ComponentModel.BackgroundWorker();
			this.toolTip_main = new System.Windows.Forms.ToolTip(this.components);
			this.numericUpDown_factor = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listBox_output = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_display)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_factor)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox_display, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 661);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox_display
			// 
			this.pictureBox_display.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_display.Location = new System.Drawing.Point(3, 3);
			this.pictureBox_display.Name = "pictureBox_display";
			this.pictureBox_display.Size = new System.Drawing.Size(578, 504);
			this.pictureBox_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_display.TabIndex = 0;
			this.pictureBox_display.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.button_saveImage);
			this.groupBox1.Controls.Add(this.button_dither);
			this.groupBox1.Controls.Add(this.button_loadImage);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 513);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(578, 145);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controls";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown_factor);
			this.groupBox2.Controls.Add(this.checkBox_grayscale);
			this.groupBox2.Controls.Add(this.checkBox_showEveryStep);
			this.groupBox2.Controls.Add(this.checkBox_dither);
			this.groupBox2.Location = new System.Drawing.Point(9, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 88);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// checkBox_grayscale
			// 
			this.checkBox_grayscale.AutoSize = true;
			this.checkBox_grayscale.Location = new System.Drawing.Point(6, 65);
			this.checkBox_grayscale.Name = "checkBox_grayscale";
			this.checkBox_grayscale.Size = new System.Drawing.Size(73, 17);
			this.checkBox_grayscale.TabIndex = 2;
			this.checkBox_grayscale.Text = "Grayscale";
			this.checkBox_grayscale.UseVisualStyleBackColor = true;
			// 
			// checkBox_showEveryStep
			// 
			this.checkBox_showEveryStep.AutoSize = true;
			this.checkBox_showEveryStep.Location = new System.Drawing.Point(6, 42);
			this.checkBox_showEveryStep.Name = "checkBox_showEveryStep";
			this.checkBox_showEveryStep.Size = new System.Drawing.Size(108, 17);
			this.checkBox_showEveryStep.TabIndex = 1;
			this.checkBox_showEveryStep.Text = "Show Every Step";
			this.toolTip_main.SetToolTip(this.checkBox_showEveryStep, "Shows every step in the process of compressing.\r\nThis is very time and RAM consum" +
        "ing.");
			this.checkBox_showEveryStep.UseVisualStyleBackColor = true;
			// 
			// checkBox_dither
			// 
			this.checkBox_dither.AutoSize = true;
			this.checkBox_dither.Location = new System.Drawing.Point(6, 19);
			this.checkBox_dither.Name = "checkBox_dither";
			this.checkBox_dither.Size = new System.Drawing.Size(54, 17);
			this.checkBox_dither.TabIndex = 0;
			this.checkBox_dither.Text = "Dither";
			this.toolTip_main.SetToolTip(this.checkBox_dither, "Also dithers the loaded image.");
			this.checkBox_dither.UseVisualStyleBackColor = true;
			// 
			// button_saveImage
			// 
			this.button_saveImage.Location = new System.Drawing.Point(171, 19);
			this.button_saveImage.Name = "button_saveImage";
			this.button_saveImage.Size = new System.Drawing.Size(75, 23);
			this.button_saveImage.TabIndex = 2;
			this.button_saveImage.Text = "Save Image";
			this.toolTip_main.SetToolTip(this.button_saveImage, "Saves the result image.");
			this.button_saveImage.UseVisualStyleBackColor = true;
			this.button_saveImage.Click += new System.EventHandler(this.button_saveImage_Click);
			// 
			// button_dither
			// 
			this.button_dither.Location = new System.Drawing.Point(90, 19);
			this.button_dither.Name = "button_dither";
			this.button_dither.Size = new System.Drawing.Size(75, 23);
			this.button_dither.TabIndex = 1;
			this.button_dither.Text = "Compress";
			this.toolTip_main.SetToolTip(this.button_dither, "Compresses and if checked dithers the loaded image.");
			this.button_dither.UseVisualStyleBackColor = true;
			this.button_dither.Click += new System.EventHandler(this.button_dither_Click);
			// 
			// button_loadImage
			// 
			this.button_loadImage.Location = new System.Drawing.Point(9, 19);
			this.button_loadImage.Name = "button_loadImage";
			this.button_loadImage.Size = new System.Drawing.Size(75, 23);
			this.button_loadImage.TabIndex = 0;
			this.button_loadImage.Text = "Load Image";
			this.toolTip_main.SetToolTip(this.button_loadImage, "Loads an image.");
			this.button_loadImage.UseVisualStyleBackColor = true;
			this.button_loadImage.Click += new System.EventHandler(this.button_loadImage_Click);
			// 
			// backgroundWorker_ditherer
			// 
			this.backgroundWorker_ditherer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_ditherer_DoWork);
			this.backgroundWorker_ditherer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_ditherer_RunWorkerCompleted);
			// 
			// numericUpDown_factor
			// 
			this.numericUpDown_factor.Location = new System.Drawing.Point(114, 16);
			this.numericUpDown_factor.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown_factor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_factor.Name = "numericUpDown_factor";
			this.numericUpDown_factor.Size = new System.Drawing.Size(70, 20);
			this.numericUpDown_factor.TabIndex = 3;
			this.toolTip_main.SetToolTip(this.numericUpDown_factor, "The higher the more colors are allowed. That means the\r\nimage file size will also" +
        " be higher but the image is\r\nmore recognizeable.");
			this.numericUpDown_factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.listBox_output);
			this.groupBox3.Location = new System.Drawing.Point(252, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(320, 117);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Infos";
			// 
			// listBox_output
			// 
			this.listBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_output.FormattingEnabled = true;
			this.listBox_output.Location = new System.Drawing.Point(3, 16);
			this.listBox_output.Name = "listBox_output";
			this.listBox_output.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox_output.Size = new System.Drawing.Size(314, 98);
			this.listBox_output.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 661);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(600, 700);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Compress Images";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_display)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_factor)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox_display;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button_saveImage;
		private System.Windows.Forms.Button button_dither;
		private System.Windows.Forms.Button button_loadImage;
		private System.ComponentModel.BackgroundWorker backgroundWorker_ditherer;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox_dither;
		private System.Windows.Forms.CheckBox checkBox_showEveryStep;
		private System.Windows.Forms.ToolTip toolTip_main;
		private System.Windows.Forms.CheckBox checkBox_grayscale;
		private System.Windows.Forms.NumericUpDown numericUpDown_factor;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBox_output;
	}
}

