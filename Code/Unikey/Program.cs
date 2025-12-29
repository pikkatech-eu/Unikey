namespace Unikey
{
	internal static class Program
	{
		private static Mutex mutex = new Mutex(true, "{B0A98D84-4C3F-47E7-975F-7B5A2E5F5F62}");

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			if (mutex.WaitOne(TimeSpan.Zero, true))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				ApplicationConfiguration.Initialize();
				Application.Run(new UnikeyForm());
				mutex.ReleaseMutex();  // Release the mutex when the app exits
			}
			else
			{
				MessageBox.Show("An instance of the application is already running.", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}