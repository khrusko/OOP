namespace WFApp
{
	partial class UCMatchResult
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
			this.lblLocation = new System.Windows.Forms.Label();
			this.lblAttendance = new System.Windows.Forms.Label();
			this.lblHomeTeam = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAwayTeam = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(16, 12);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(48, 13);
			this.lblLocation.TabIndex = 0;
			this.lblLocation.Text = "Location";
			// 
			// lblAttendance
			// 
			this.lblAttendance.AutoSize = true;
			this.lblAttendance.Location = new System.Drawing.Point(152, 12);
			this.lblAttendance.Name = "lblAttendance";
			this.lblAttendance.Size = new System.Drawing.Size(62, 13);
			this.lblAttendance.TabIndex = 1;
			this.lblAttendance.Text = "Attendance";
			// 
			// lblHomeTeam
			// 
			this.lblHomeTeam.AutoSize = true;
			this.lblHomeTeam.Location = new System.Drawing.Point(16, 77);
			this.lblHomeTeam.Name = "lblHomeTeam";
			this.lblHomeTeam.Size = new System.Drawing.Size(35, 13);
			this.lblHomeTeam.TabIndex = 2;
			this.lblHomeTeam.Text = "Home";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(100, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "vs";
			// 
			// lblAwayTeam
			// 
			this.lblAwayTeam.AutoSize = true;
			this.lblAwayTeam.Location = new System.Drawing.Point(179, 77);
			this.lblAwayTeam.Name = "lblAwayTeam";
			this.lblAwayTeam.Size = new System.Drawing.Size(35, 13);
			this.lblAwayTeam.TabIndex = 4;
			this.lblAwayTeam.Text = "Guest";
			// 
			// UCMatchResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Controls.Add(this.lblAwayTeam);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblHomeTeam);
			this.Controls.Add(this.lblAttendance);
			this.Controls.Add(this.lblLocation);
			this.Name = "UCMatchResult";
			this.Size = new System.Drawing.Size(261, 116);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label lblAttendance;
		private System.Windows.Forms.Label lblHomeTeam;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAwayTeam;
	}
}
