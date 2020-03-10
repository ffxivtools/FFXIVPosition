using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FFXIVPosition.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		internal Resources()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("FFXIVPosition.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

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

		internal static Bitmap dn
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("dn", Resources.resourceCulture);
			}
		}

		internal static Bitmap fdn
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("fdn", Resources.resourceCulture);
			}
		}

		internal static Bitmap fup
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("fup", Resources.resourceCulture);
			}
		}

		internal static Bitmap lt
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("lt", Resources.resourceCulture);
			}
		}

		internal static Bitmap rt
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("rt", Resources.resourceCulture);
			}
		}

		internal static Bitmap up
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("up", Resources.resourceCulture);
			}
		}

		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;
	}
}
