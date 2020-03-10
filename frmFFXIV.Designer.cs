namespace FFXIVPosition
{
	public partial class frmFFXIV : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.buttonApply = new global::System.Windows.Forms.Button();
			this.buttonSet = new global::System.Windows.Forms.Button();
			this.curZ = new global::System.Windows.Forms.Label();
			this.curY = new global::System.Windows.Forms.Label();
			this.curX = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.threadSignatureScan = new global::System.ComponentModel.BackgroundWorker();
			this.threadUpdater = new global::System.ComponentModel.BackgroundWorker();
			this.checkSignature = new global::System.Windows.Forms.Timer(this.components);
			this.numX = new global::System.Windows.Forms.TextBox();
			this.numY = new global::System.Windows.Forms.TextBox();
			this.numZ = new global::System.Windows.Forms.TextBox();
			this.buttonReload = new global::System.Windows.Forms.Button();
			this.fdn = new global::System.Windows.Forms.Button();
			this.fup = new global::System.Windows.Forms.Button();
			this.lt = new global::System.Windows.Forms.Button();
			this.rt = new global::System.Windows.Forms.Button();
			this.dn = new global::System.Windows.Forms.Button();
			this.up = new global::System.Windows.Forms.Button();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			base.SuspendLayout();
			this.buttonApply.Location = new global::System.Drawing.Point(65, 88);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new global::System.Drawing.Size(59, 23);
			this.buttonApply.TabIndex = 20;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new global::System.EventHandler(this.ButtonApply_Click);
			this.buttonSet.Location = new global::System.Drawing.Point(0, 88);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new global::System.Drawing.Size(59, 23);
			this.buttonSet.TabIndex = 19;
			this.buttonSet.Text = "Populate";
			this.buttonSet.UseVisualStyleBackColor = true;
			this.buttonSet.Click += new global::System.EventHandler(this.ButtonSet_Click);
			this.curZ.Location = new global::System.Drawing.Point(81, 56);
			this.curZ.Name = "curZ";
			this.curZ.Size = new global::System.Drawing.Size(72, 13);
			this.curZ.TabIndex = 18;
			this.curY.Location = new global::System.Drawing.Point(81, 32);
			this.curY.Name = "curY";
			this.curY.Size = new global::System.Drawing.Size(72, 13);
			this.curY.TabIndex = 17;
			this.curX.Location = new global::System.Drawing.Point(81, 8);
			this.curX.Name = "curX";
			this.curX.Size = new global::System.Drawing.Size(72, 13);
			this.curX.TabIndex = 16;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(1, 53);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(17, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Z:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(1, 29);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(17, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Y:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(1, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(20, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "X: ";
			this.threadSignatureScan.WorkerReportsProgress = true;
			this.threadSignatureScan.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.ThreadSignatureScan_DoWork);
			this.threadSignatureScan.ProgressChanged += new global::System.ComponentModel.ProgressChangedEventHandler(this.ThreadSignatureScan_ProgressChanged);
			this.threadSignatureScan.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.ThreadSignatureScan_RunWorkerCompleted);
			this.threadUpdater.WorkerReportsProgress = true;
			this.threadUpdater.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.ThreadUpdater_DoWork);
			this.threadUpdater.ProgressChanged += new global::System.ComponentModel.ProgressChangedEventHandler(this.ThreadUpdater_ProgressChanged);
			this.checkSignature.Enabled = true;
			this.checkSignature.Interval = 1000;
			this.checkSignature.Tick += new global::System.EventHandler(this.CheckSignature_Tick);
			this.numX.Location = new global::System.Drawing.Point(18, 5);
			this.numX.Name = "numX";
			this.numX.Size = new global::System.Drawing.Size(60, 20);
			this.numX.TabIndex = 21;
			this.numY.Location = new global::System.Drawing.Point(18, 29);
			this.numY.Name = "numY";
			this.numY.Size = new global::System.Drawing.Size(60, 20);
			this.numY.TabIndex = 22;
			this.numZ.Location = new global::System.Drawing.Point(18, 53);
			this.numZ.Name = "numZ";
			this.numZ.Size = new global::System.Drawing.Size(60, 20);
			this.numZ.TabIndex = 23;
			this.buttonReload.Location = new global::System.Drawing.Point(130, 88);
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new global::System.Drawing.Size(59, 23);
			this.buttonReload.TabIndex = 24;
			this.buttonReload.Text = "Reload";
			this.buttonReload.UseVisualStyleBackColor = true;
			this.buttonReload.Click += new global::System.EventHandler(this.ButtonReload_Click);
			this.fdn.BackColor = global::System.Drawing.Color.Transparent;
			this.fdn.BackgroundImage = global::FFXIVPosition.Properties.Resources.fdn;
			this.fdn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.fdn.Location = new global::System.Drawing.Point(231, 57);
			this.fdn.Name = "fdn";
			this.fdn.Size = new global::System.Drawing.Size(24, 24);
			this.fdn.TabIndex = 29;
			this.fdn.UseVisualStyleBackColor = false;
			this.fdn.Click += new global::System.EventHandler(this.fdn_Click);
			this.fup.BackColor = global::System.Drawing.Color.Transparent;
			this.fup.BackgroundImage = global::FFXIVPosition.Properties.Resources.fup;
			this.fup.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.fup.Location = new global::System.Drawing.Point(231, 6);
			this.fup.Name = "fup";
			this.fup.Size = new global::System.Drawing.Size(24, 24);
			this.fup.TabIndex = 28;
			this.fup.UseVisualStyleBackColor = false;
			this.fup.Click += new global::System.EventHandler(this.fup_Click);
			this.lt.BackColor = global::System.Drawing.Color.Transparent;
			this.lt.BackgroundImage = global::FFXIVPosition.Properties.Resources.lt;
			this.lt.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.lt.Location = new global::System.Drawing.Point(154, 29);
			this.lt.Name = "lt";
			this.lt.Size = new global::System.Drawing.Size(24, 24);
			this.lt.TabIndex = 27;
			this.lt.UseVisualStyleBackColor = false;
			this.lt.Click += new global::System.EventHandler(this.lt_Click);
			this.rt.BackColor = global::System.Drawing.Color.Transparent;
			this.rt.BackgroundImage = global::FFXIVPosition.Properties.Resources.rt;
			this.rt.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.rt.Location = new global::System.Drawing.Point(201, 29);
			this.rt.Name = "rt";
			this.rt.Size = new global::System.Drawing.Size(24, 24);
			this.rt.TabIndex = 27;
			this.rt.UseVisualStyleBackColor = false;
			this.rt.Click += new global::System.EventHandler(this.rt_Click);
			this.dn.BackColor = global::System.Drawing.Color.Transparent;
			this.dn.BackgroundImage = global::FFXIVPosition.Properties.Resources.dn;
			this.dn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.dn.Location = new global::System.Drawing.Point(178, 55);
			this.dn.Name = "dn";
			this.dn.Size = new global::System.Drawing.Size(24, 24);
			this.dn.TabIndex = 26;
			this.dn.UseVisualStyleBackColor = false;
			this.dn.Click += new global::System.EventHandler(this.dn_Click);
			this.up.BackColor = global::System.Drawing.Color.Transparent;
			this.up.BackgroundImage = global::FFXIVPosition.Properties.Resources.up;
			this.up.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.up.Location = new global::System.Drawing.Point(178, 4);
			this.up.Name = "up";
			this.up.Size = new global::System.Drawing.Size(24, 24);
			this.up.TabIndex = 25;
			this.up.UseVisualStyleBackColor = false;
			this.up.Click += new global::System.EventHandler(this.up_Click);
			this.numericUpDown1.Location = new global::System.Drawing.Point(192, 88);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(60, 20);
			this.numericUpDown1.TabIndex = 30;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown2.Location = new global::System.Drawing.Point(192, 112);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = 999999;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(60, 20);
			this.numericUpDown2.TabIndex = 32;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown2;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(260, 115);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.fdn);
			base.Controls.Add(this.fup);
			base.Controls.Add(this.lt);
			base.Controls.Add(this.rt);
			base.Controls.Add(this.dn);
			base.Controls.Add(this.up);
			base.Controls.Add(this.buttonReload);
			base.Controls.Add(this.numZ);
			base.Controls.Add(this.numY);
			base.Controls.Add(this.numX);
			base.Controls.Add(this.buttonApply);
			base.Controls.Add(this.buttonSet);
			base.Controls.Add(this.curZ);
			base.Controls.Add(this.curY);
			base.Controls.Add(this.curX);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "frmFFXIV";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "FFXIVPosition";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Astellia_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Button buttonApply;

		private global::System.Windows.Forms.Button buttonSet;

		private global::System.Windows.Forms.Label curZ;

		private global::System.Windows.Forms.Label curY;

		private global::System.Windows.Forms.Label curX;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label1;

		public global::System.ComponentModel.BackgroundWorker threadSignatureScan;

		public global::System.ComponentModel.BackgroundWorker threadUpdater;

		private global::System.Windows.Forms.Timer checkSignature;

		private global::System.Windows.Forms.TextBox numX;

		private global::System.Windows.Forms.TextBox numY;

		private global::System.Windows.Forms.TextBox numZ;

		private global::System.Windows.Forms.Button buttonReload;

		private global::System.Windows.Forms.Button up;

		private global::System.Windows.Forms.Button dn;

		private global::System.Windows.Forms.Button rt;

		private global::System.Windows.Forms.Button lt;

		private global::System.Windows.Forms.Button fdn;

		private global::System.Windows.Forms.Button fup;

		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		private global::System.Windows.Forms.NumericUpDown numericUpDown2;
	}
}
