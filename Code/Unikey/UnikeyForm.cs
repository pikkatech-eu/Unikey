
using Unikey.Properties;

namespace Unikey
{
	public partial class UnikeyForm : Form
	{
		private NotifyIcon trayIcon;
		private ContextMenuStrip trayMenu;
		private Settings	_settings			= new Settings();
		private const string SETTING_FILE_NAME	= "settings.json";

		public UnikeyForm()
		{
			InitializeComponent();

			this.ShowInTaskbar		= false;
			this.WindowState		= FormWindowState.Normal;

			this._settings.Load(SETTING_FILE_NAME);
			this.Opacity			= this._settings.Opacity;

			this.InitializeTray();

			switch (this._settings.LastKeyboard.ToUpper())
			{
				case "FA":
					this._pbKeyboard.Image	= Resources.unikey_fa;
					break;

				case "HE":
					this._pbKeyboard.Image	= Resources.unikey_he;
					break;

				case "UK":
					this._pbKeyboard.Image	= Resources.unikey_uk;
					break;

				case "ES":
					this._pbKeyboard.Image	= Resources.unikey_es;
					break;

				default:
					break;
			}
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

			var farsiItem = new ToolStripMenuItem("FA");
			farsiItem.Click += (s, e) => this.SetFarsiKeyboard();

			var hebrewItem = new ToolStripMenuItem("HE");
			hebrewItem.Click += (s, e) => this.SetHebrewKeyboard();

			var ukrainianItem = new ToolStripMenuItem("UK");
			ukrainianItem.Click += (s, e) => this.SetUkrainianKeyboard();

			var spanishItem = new ToolStripMenuItem("ES");
			spanishItem.Click += (s, e) => this.SetSpanishKeyboard();

			var settingsItem = new ToolStripMenuItem("Settings");
			settingsItem.Click += (s, e) => ShowSettings();

			var exitItem = new ToolStripMenuItem("Quit");
			exitItem.Click += (s, e) => ExitApplication();

			trayMenu.Items.Add(toggleItem);
			trayMenu.Items.Add(new ToolStripSeparator());

			trayMenu.Items.Add(farsiItem);
			trayMenu.Items.Add(hebrewItem);
			trayMenu.Items.Add(ukrainianItem);
			trayMenu.Items.Add(spanishItem);

			trayMenu.Items.Add(new ToolStripSeparator());

			trayMenu.Items.Add(settingsItem);
			trayMenu.Items.Add(new ToolStripSeparator());
			trayMenu.Items.Add(exitItem);

			trayIcon = new NotifyIcon
			{
				Text = "Unikey",
				Icon = this.Icon, // or load a custom .ico
				ContextMenuStrip = trayMenu,
				Visible = true
			};

			trayIcon.DoubleClick += (s, e) => ToggleDisplay(toggleItem);
		}

		private void SetFarsiKeyboard()
		{
			this._pbKeyboard.Image = Properties.Resources.unikey_fa;
			this._settings.LastKeyboard	= "FA";
			this._settings.Save(SETTING_FILE_NAME);
		}

		private void SetHebrewKeyboard()
		{
			this._pbKeyboard.Image = Properties.Resources.unikey_he;
			this._settings.LastKeyboard	= "HE";
			this._settings.Save(SETTING_FILE_NAME);
		}

		private void SetUkrainianKeyboard()
		{
			this._pbKeyboard.Image = Properties.Resources.unikey_uk;
			this._settings.LastKeyboard	= "UK";
			this._settings.Save(SETTING_FILE_NAME);
		}

		private void SetSpanishKeyboard()
		{
			this._pbKeyboard.Image = Properties.Resources.unikey_es;
			this._settings.LastKeyboard	= "ES";
			this._settings.Save(SETTING_FILE_NAME);
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
			SettingsDialog dialog	= new SettingsDialog();
			dialog.Settings			= this._settings;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._settings = dialog.Settings;
				this._settings.Save(SETTING_FILE_NAME);

				this.Opacity	= this._settings.Opacity;
				this.Refresh(); 
			}
		}

		private void ExitApplication()
		{
			trayIcon.Visible = false;
			trayIcon.Dispose();
			Application.Exit();

			Environment.Exit(0);
		}
	}
}
