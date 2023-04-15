using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using soniccd_setup.Properties;

namespace soniccd_setup
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205E File Offset: 0x0000025E
		private void ValueChanged(object sender, EventArgs args)
		{
			if (this.availableModes != null && this.VideoModeBox.SelectedIndex >= 0)
			{
				this.SelectVideoMode(this.availableModes[this.VideoModeBox.SelectedIndex]);
				this.ApplyButton.Enabled = true;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209E File Offset: 0x0000029E
		private void ApplyChanges(object sender, EventArgs args)
		{
			this.SaveConfigFile();
			this.ApplyButton.Enabled = false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020FC File Offset: 0x000002FC
		private void EnumerateVideoModes()
		{
			this.VideoModeBox.Items.Clear();
			this.availableModes = new List<DisplayMode>();
			DisplayMode mode;
			foreach (object obj in Manager.Adapters.Default.SupportedDisplayModes)
			{
				mode = (DisplayMode)obj;
				if (!this.availableModes.Exists(delegate(DisplayMode x)
				{
					int height = x.Height;
					DisplayMode mode = mode;
					if (height == mode.Height)
					{
						int width = x.Width;
						DisplayMode mode2 = mode;
						return width == mode2.Width;
					}
					return false;
				}))
				{
					this.availableModes.Add(mode);
				}
			}
			this.availableModes.Sort(new Form1.ModeComparer());
			foreach (DisplayMode displayMode in this.availableModes)
			{
				this.VideoModeBox.Items.Add(displayMode.Width + " x " + displayMode.Height);
				if (displayMode.Width == this.savedWidth && displayMode.Height == this.savedHeight)
				{
					this.VideoModeBox.SelectedIndex = this.VideoModeBox.Items.Count - 1;
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000226C File Offset: 0x0000046C
		private string ConfigFilePath
		{
			get
			{
				string text = Program.SteamUserDataPath();
				if (text == null)
				{
					return null;
				}
				return text + "\\setup.dat";
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002290 File Offset: 0x00000490
		private void ReadConfigFile()
		{
			FileStream fileStream = null;
			try
			{
				fileStream = File.OpenRead(this.ConfigFilePath);
			}
			catch (Exception)
			{
			}
			if (fileStream == null)
			{
				return;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			this.savedWidth = binaryReader.ReadInt32();
			this.savedHeight = binaryReader.ReadInt32();
			this.savedRefresh = binaryReader.ReadInt32();
			this.WindowedCheck.Checked = binaryReader.ReadBoolean();
			binaryReader.Close();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002308 File Offset: 0x00000508
		[FileIOPermission(SecurityAction.Assert, Write = "C:\\")]
		private void SaveConfigFile()
		{
			FileStream output = File.Create(this.ConfigFilePath);
			BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.Write(this.savedWidth);
			binaryWriter.Write(this.savedHeight);
			binaryWriter.Write(this.savedRefresh);
			binaryWriter.Write(this.WindowedCheck.Checked);
			binaryWriter.Close();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002363 File Offset: 0x00000563
		private void SelectVideoMode(DisplayMode mode)
		{
			this.savedWidth = mode.Width;
			this.savedHeight = mode.Height;
			this.savedRefresh = mode.RefreshRate;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000238C File Offset: 0x0000058C
		private void Form1_Load(object sender, EventArgs e)
		{
			this.SelectVideoMode(Manager.Adapters.Default.CurrentDisplayMode);
			this.ReadConfigFile();
			this.EnumerateVideoModes();
			this.VideoModeBox.SelectedIndexChanged += this.ValueChanged;
			this.WindowedCheck.CheckedChanged += this.ValueChanged;
			this.ApplyButton.Click += this.ApplyChanges;
		}

		// Token: 0x04000001 RID: 1
		private int savedWidth;

		// Token: 0x04000002 RID: 2
		private int savedHeight;

		// Token: 0x04000003 RID: 3
		private int savedRefresh;

		// Token: 0x04000004 RID: 4
		private List<DisplayMode> availableModes;

		// Token: 0x02000003 RID: 3
		private class ModeComparer : IComparer<DisplayMode>
		{
			// Token: 0x0600000C RID: 12 RVA: 0x000027A4 File Offset: 0x000009A4
			public int Compare(DisplayMode x, DisplayMode y)
			{
				int num = x.Width << 16 | x.Height;
				int num2 = y.Width << 16 | y.Height;
				return num - num2;
			}
		}
	}
}
