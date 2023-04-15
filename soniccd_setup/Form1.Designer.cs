namespace soniccd_setup
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000023FF File Offset: 0x000005FF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002420 File Offset: 0x00000620
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::soniccd_setup.Form1));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.VideoModeBox = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.WindowedCheck = new global::System.Windows.Forms.CheckBox();
			this.ApplyButton = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = global::soniccd_setup.Properties.Resources.ref_config1;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(420, 95);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.VideoModeBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoModeBox.FormattingEnabled = true;
			this.VideoModeBox.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.VideoModeBox.Location = new global::System.Drawing.Point(165, 149);
			this.VideoModeBox.Name = "VideoModeBox";
			this.VideoModeBox.Size = new global::System.Drawing.Size(154, 21);
			this.VideoModeBox.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(95, 152);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Video Mode";
			this.WindowedCheck.AutoSize = true;
			this.WindowedCheck.Location = new global::System.Drawing.Point(165, 195);
			this.WindowedCheck.Name = "WindowedCheck";
			this.WindowedCheck.Size = new global::System.Drawing.Size(77, 17);
			this.WindowedCheck.TabIndex = 3;
			this.WindowedCheck.Text = "Windowed";
			this.WindowedCheck.UseVisualStyleBackColor = true;
			this.ApplyButton.Enabled = false;
			this.ApplyButton.Location = new global::System.Drawing.Point(118, 258);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new global::System.Drawing.Size(185, 23);
			this.ApplyButton.TabIndex = 4;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(420, 307);
			base.Controls.Add(this.ApplyButton);
			base.Controls.Add(this.WindowedCheck);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.VideoModeBox);
			base.Controls.Add(this.pictureBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(436, 345);
			this.MinimumSize = new global::System.Drawing.Size(436, 345);
			base.Name = "Form1";
			this.Text = "Sonic CD Setup";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.ComboBox VideoModeBox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.CheckBox WindowedCheck;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button ApplyButton;
	}
}
