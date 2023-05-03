namespace WFApp
{
	partial class UCPlayer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pbImagePlayer = new System.Windows.Forms.PictureBox();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblCaptain = new System.Windows.Forms.Label();
			this.pbFavoritePlayer = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFavoritePlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// pbImagePlayer
			// 
			this.pbImagePlayer.Location = new System.Drawing.Point(3, 3);
			this.pbImagePlayer.Name = "pbImagePlayer";
			this.pbImagePlayer.Size = new System.Drawing.Size(108, 144);
			this.pbImagePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagePlayer.TabIndex = 0;
			this.pbImagePlayer.TabStop = false;
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Location = new System.Drawing.Point(117, 13);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
			this.lblPlayerName.TabIndex = 1;
			this.lblPlayerName.Text = "Name";
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(117, 43);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(44, 13);
			this.lblPosition.TabIndex = 2;
			this.lblPosition.Text = "Position";
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(117, 76);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(44, 13);
			this.lblNumber.TabIndex = 3;
			this.lblNumber.Text = "Number";
			// 
			// lblCaptain
			// 
			this.lblCaptain.AutoSize = true;
			this.lblCaptain.Location = new System.Drawing.Point(116, 106);
			this.lblCaptain.Name = "lblCaptain";
			this.lblCaptain.Size = new System.Drawing.Size(43, 13);
			this.lblCaptain.TabIndex = 4;
			this.lblCaptain.Text = "Captain";
			// 
			// pbFavoritePlayer
			// 
			this.pbFavoritePlayer.Location = new System.Drawing.Point(187, 97);
			this.pbFavoritePlayer.Name = "pbFavoritePlayer";
			this.pbFavoritePlayer.Size = new System.Drawing.Size(58, 50);
			this.pbFavoritePlayer.TabIndex = 5;
			this.pbFavoritePlayer.TabStop = false;
			// 
			// UCPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Controls.Add(this.pbFavoritePlayer);
			this.Controls.Add(this.lblCaptain);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblPlayerName);
			this.Controls.Add(this.pbImagePlayer);
			this.Name = "UCPlayer";
			this.Size = new System.Drawing.Size(248, 150);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCPlayer_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFavoritePlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbImagePlayer;
		private System.Windows.Forms.Label lblPlayerName;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label lblCaptain;
		private System.Windows.Forms.PictureBox pbFavoritePlayer;
	}
}
