namespace Unikey
{
	partial class SettingsDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._pgSettings = new PropertyGrid();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = Color.FromArgb(0, 48, 96);
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 370);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = Color.FromArgb(0, 48, 96);
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 370);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _pgSettings
			// 
			this._pgSettings.BackColor = Color.FromArgb(0, 48, 96);
			this._pgSettings.Dock = DockStyle.Top;
			this._pgSettings.Location = new Point(0, 0);
			this._pgSettings.Name = "_pgSettings";
			this._pgSettings.Size = new Size(261, 357);
			this._pgSettings.TabIndex = 1;
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.ClientSize = new Size(261, 411);
			this.Controls.Add(this._pgSettings);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "SettingsDialog";
			this.Text = "Unikey Settings";
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private PropertyGrid _pgSettings;
	}
}