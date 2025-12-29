namespace Unikey
{
    partial class UnikeyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnikeyForm));
			this._pbKeyboard = new PictureBox();
			((System.ComponentModel.ISupportInitialize)this._pbKeyboard).BeginInit();
			this.SuspendLayout();
			// 
			// _pbKeyboard
			// 
			this._pbKeyboard.Dock = DockStyle.Fill;
			this._pbKeyboard.Location = new Point(0, 0);
			this._pbKeyboard.Margin = new Padding(0);
			this._pbKeyboard.Name = "_pbKeyboard";
			this._pbKeyboard.Size = new Size(556, 153);
			this._pbKeyboard.SizeMode = PictureBoxSizeMode.StretchImage;
			this._pbKeyboard.TabIndex = 0;
			this._pbKeyboard.TabStop = false;
			// 
			// UnikeyForm
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Fuchsia;
			this.ClientSize = new Size(556, 153);
			this.Controls.Add(this._pbKeyboard);
			this.Font = new Font("Consolas", 10F);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "UnikeyForm";
			this.Opacity = 0.75D;
			this.Text = "UniKey";
			this.TransparencyKey = Color.Fuchsia;
			((System.ComponentModel.ISupportInitialize)this._pbKeyboard).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private PictureBox _pbKeyboard;
	}
}
