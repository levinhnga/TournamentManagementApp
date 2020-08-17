using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIL
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// First of all, initialize the connection 
			BUL.InitializeConnections initializeConnection = new BUL.InitializeConnections();
			initializeConnection.InitializeConnection();

			Application.Run(new frmTournamentDashboard());
		}
	}
}
