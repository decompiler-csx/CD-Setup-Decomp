using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace soniccd_setup.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002886 File Offset: 0x00000A86
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002890 File Offset: 0x00000A90
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("soniccd_setup.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000028CF File Offset: 0x00000ACF
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000028D6 File Offset: 0x00000AD6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000028E0 File Offset: 0x00000AE0
		internal static Bitmap ref_config1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("ref_config1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400000C RID: 12
		private static ResourceManager resourceMan;

		// Token: 0x0400000D RID: 13
		private static CultureInfo resourceCulture;
	}
}
