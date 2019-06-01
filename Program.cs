using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPanel
{
	static class Program
	{
        private static String conn = "";

        public static String Oleconn
        {
            get { return conn; }
            set { conn = value; }
        }
        public static ApplicationContext Context { get; set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Application.Run(new LoginPanel());
			Context = new ApplicationContext(new LoginPanel());
			Application.Run(Context);
		}
	}
}
