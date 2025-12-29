
namespace Unikey
{
	public partial class UnikeyForm : Form
	{
		public UnikeyForm()
		{
			InitializeComponent();

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

			int margin = 0;	// -> settings
			int y = wa.Bottom - this.Height - margin;

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(x, y);
		}
	}
}
