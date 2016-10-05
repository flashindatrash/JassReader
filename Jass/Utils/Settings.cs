using System.Configuration;

namespace Jass
{
	public static class Settings
	{
		public static string InputFolder
		{
			get { return ConfigurationManager.AppSettings["input.folder"]; }
		}

		public static string OutputFolder
		{
			get { return ConfigurationManager.AppSettings["output.folder"]; }
		}

		public static string ClassTemplate
		{
			get { return ConfigurationManager.AppSettings["class.tpl"]; }
		}

		public static string ArrayTemplate
		{
			get { return ConfigurationManager.AppSettings["array.tpl"]; }
		}

		public static string Extension
		{
			get { return ConfigurationManager.AppSettings["extension"]; }
		}

		public static bool Debug
		{
			get { return ConfigurationManager.AppSettings["debug"]=="true"; }
		}

		public static string ClassAssociation(string name)
		{
			string association = ConfigurationManager.AppSettings[name];
			return string.IsNullOrEmpty(association) ? name : association;
		}
	}
}

