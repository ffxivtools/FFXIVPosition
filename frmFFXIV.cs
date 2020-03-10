using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FFXIVPosition.Properties;
using Memory;

namespace FFXIVPosition
{
	public partial class frmFFXIV : Form
	{
		private void CheckSignature_Tick(object sender, EventArgs e)
		{
			bool isBusy = this.threadSignatureScan.IsBusy;
		}

		private void ThreadSignatureScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage == 1)
			{
				this.Text = "Scanning...";
				this.buttonApply.Enabled = false;
				this.buttonSet.Enabled = false;
			}
			if (e.ProgressPercentage == 100)
			{
				this.Text = "FFXIV Position Tool";
				this.buttonApply.Enabled = true;
				this.buttonSet.Enabled = true;
			}
		}

		private void ButtonSet_Click(object sender, EventArgs e)
		{
			this.numX.Text = this.x.ToString();
			this.numY.Text = this.y.ToString();
			this.numZ.Text = this.z.ToString();
		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			if (this.numX.Text == "")
			{
				this.numX.Text = this.x.ToString();
			}
			if (this.numY.Text == "")
			{
				this.numY.Text = this.y.ToString();
			}
			if (this.numZ.Text == "")
			{
				this.numZ.Text = this.z.ToString();
			}
			this.m.writeMemory(this.X.ToString("X"), "float", this.numX.Text, "");
			this.m.writeMemory(this.Y.ToString("X"), "float", this.numY.Text, "");
			this.m.writeMemory(this.Z.ToString("X"), "float", this.numZ.Text, "");
		}

		private void ButtonReload_Click(object sender, EventArgs e)
		{
			this.threadSignatureScan.RunWorkerAsync();
		}

		private void up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		private void up_Click(object sender, EventArgs e)
		{
			try
			{
				float curz = float.Parse(this.curZ.Text) - (float)this.increment;
				this.m.writeMemory(this.Z.ToString("X"), "float", curz.ToString(), "");
			}
			catch
			{
			}
		}

		private void dn_Click(object sender, EventArgs e)
		{
			try
			{
				float curz = float.Parse(this.curZ.Text) + (float)this.increment;
				this.m.writeMemory(this.Z.ToString("X"), "float", curz.ToString(), "");
			}
			catch
			{
			}
		}

		private void lt_Click(object sender, EventArgs e)
		{
			try
			{
				float curx = float.Parse(this.curX.Text) - (float)this.increment;
				this.m.writeMemory(this.X.ToString("X"), "float", curx.ToString(), "");
			}
			catch
			{
			}
		}

		private void rt_Click(object sender, EventArgs e)
		{
			try
			{
				float curx = float.Parse(this.curX.Text) + (float)this.increment;
				this.m.writeMemory(this.X.ToString("X"), "float", curx.ToString(), "");
			}
			catch
			{
			}
		}

		private void currentZoom_Leave(object sender, EventArgs e)
		{
		}

		private void maximumZoom_ValueChanged(object sender, EventArgs e)
		{
		}

		private void maximumZoom_Leave(object sender, EventArgs e)
		{
		}

		private void fup_Click(object sender, EventArgs e)
		{
			try
			{
				float cury = float.Parse(this.curY.Text) + (float)this.increment;
				this.m.writeMemory(this.Y.ToString("X"), "float", cury.ToString(), "");
			}
			catch
			{
			}
		}

		private void fdn_Click(object sender, EventArgs e)
		{
			try
			{
				float cury = float.Parse(this.curY.Text) - (float)this.increment;
				this.m.writeMemory(this.Y.ToString("X"), "float", cury.ToString(), "");
			}
			catch
			{
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.increment = (int)this.numericUpDown1.Value;
		}

		private void ThreadUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.SetPos(this.x, this.y, this.z);
			this.SetZoom(this.curzoom, this.maxzoom);
		}

		private void ThreadSignatureScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!this.threadUpdater.IsBusy)
			{
				this.threadUpdater.RunWorkerAsync();
			}
		}

		private void ThreadUpdater_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				this.x = this.m.readFloat(string.Format("{0:X}", this.X), "", true);
				this.y = this.m.readFloat(string.Format("{0:X}", this.Y), "", true);
				this.z = this.m.readFloat(string.Format("{0:X}", this.Z), "", true);
				this.maxzoom = this.m.readFloat(string.Format("{0:X}", this._maxzoom), "", true);
				this.threadUpdater.ReportProgress(1);
				Thread.Sleep(200);
			}
		}

		private void ThreadSignatureScan_DoWork(object sender, DoWorkEventArgs e)
		{
			this.m = new Mem();
			this.curx = 0f;
			this.cury = 0f;
			this.curz = 0f;
			this.m.OpenProcess("ffxiv_dx11");
			this.threadSignatureScan.ReportProgress(1);
			this.Xbase = this.m.AoBScan(Settings.Default.positionAOB, true, true, "").Result.FirstOrDefault<long>();
			this.X = this.Xbase + 24L;
			this.Y = this.X + 4L;
			this.Z = this.X + 8L;
			this.Zoombase = 0L;//this.m.AoBScan(Settings.Default.zoomAOB, true, true, "").Result.FirstOrDefault<long>();
			this._maxzoom = 0L;// this.Zoombase + 16L;
			this.threadSignatureScan.ReportProgress(100);
		}

		public frmFFXIV()
		{
			this.InitializeComponent();
		}

		private void Astellia_Load(object sender, EventArgs e)
		{
			this.m = new Mem();
			this.curx = 0f;
			this.cury = 0f;
			this.curz = 0f;
			this.increment = (int)this.numericUpDown1.Value;
			this.m.OpenProcess("ffxiv_dx11");
			this.threadSignatureScan.RunWorkerAsync();
		}

		public void SetPos(float x, float y, float z)
		{
			this.curx = x;
			this.cury = y;
			this.curz = z;
			this.curX.Text = this.curx.ToString();
			this.curY.Text = this.cury.ToString();
			this.curZ.Text = this.curz.ToString();
		}

		public void SetZoom(float cur, float max)
		{
			this.curzoom = cur;
			this.maxzoom = max;
		}

		public float curx;

		public float cury;

		public float curz;

		public float x;

		public float y;

		public float z;

		public float curzoom;

		public float maxzoom;

		public long Xbase;

		public long X;

		public long Y;

		public long Z;

		public long Zoombase;

		public long _curzoom;

		public long _maxzoom;

		public int increment;

		public Mem m;
	}
}
