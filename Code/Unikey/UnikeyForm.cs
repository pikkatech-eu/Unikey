
namespace Unikey
{
	public partial class UnikeyForm : Form
	{
		private NotifyIcon trayIcon;
		private ContextMenuStrip trayMenu;

		public UnikeyForm()
		{
			InitializeComponent();

			this.ShowInTaskbar = false;
			this.WindowState = FormWindowState.Normal;

			this.InitializeTray();

			string fileName = "C:\\pikkatech.eu\\Projects\\Active\\Unikey\\Images\\Raster\\ibisana++.jpg";

			this._pbKeyboard.Image = Image.FromFile(fileName);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			Screen targetScreen;

			if (Screen.AllScreens.Length > 1)
			{
				// Additional monitor (index 1)
				targetScreen = Screen.AllScreens[1];
			}
			else
			{
				// Only one monitor
				targetScreen = Screen.PrimaryScreen;
			}

			Rectangle wa = targetScreen.WorkingArea;

			int x = wa.Left + (wa.Width - this.Width) / 2;

			int margin = 0; // -> settings
			int y = wa.Bottom - this.Height - margin;

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(x, y);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}


		private void InitializeTray()
		{
			trayMenu = new ContextMenuStrip();

			var toggleItem = new ToolStripMenuItem("Hide Display");
			toggleItem.Click += (s, e) => ToggleDisplay(toggleItem);

			var settingsItem = new ToolStripMenuItem("Settings");
			settingsItem.Click += (s, e) => ShowSettings();

			var exitItem = new ToolStripMenuItem("Quit");
			exitItem.Click += (s, e) => ExitApplication();

			trayMenu.Items.Add(toggleItem);
			trayMenu.Items.Add(new ToolStripSeparator());
			trayMenu.Items.Add(settingsItem);
			trayMenu.Items.Add(new ToolStripSeparator());
			trayMenu.Items.Add(exitItem);

			trayIcon = new NotifyIcon
			{
				Text = "My Semi-Transparent Overlay",
				Icon = this.Icon, // or load a custom .ico
				ContextMenuStrip = trayMenu,
				Visible = true
			};

			trayIcon.DoubleClick += (s, e) => ToggleDisplay(toggleItem);
		}

		private void ToggleDisplay(ToolStripMenuItem menuItem)
		{
			if (this.Visible)
			{
				this.Hide();
				menuItem.Text = "Show Display";
			}
			else
			{
				this.Show();
				this.Activate();
				menuItem.Text = "Hide Display";
			}
		}


		private void ShowSettings()
		{
			MessageBox.Show(
				"Settings dialog goes here.",
				"Settings",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}


		private void ExitApplication()
		{
			trayIcon.Visible = false;
			trayIcon.Dispose();
			Application.Exit();
		}

	}
}
