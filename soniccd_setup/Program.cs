using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace soniccd_setup
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000027E4 File Offset: 0x000009E4
		[STAThread]
		private static void Main()
		{
			AppDomain.CurrentDomain.AssemblyResolve += Program.CheckDirectXLoadFailure;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (Program.SteamUserDataPath() == null)
			{
				MessageBox.Show("Steam client is not running", "Sonic CD", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
				return;
			}
			Application.Run(new Form1());
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000283C File Offset: 0x00000A3C
		private static Assembly CheckDirectXLoadFailure(object sender, ResolveEventArgs args)
		{
			if (args.Name == "Microsoft.DirectX.Direct3D")
			{
				MessageBox.Show("Error loading DirectX. Please check DirectX is up to date");
				Application.Exit();
			}
			return null;
		}

		// Token: 0x06000010 RID: 16
		[DllImport("steam_w.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string SteamUserDataPath();
	}
}
