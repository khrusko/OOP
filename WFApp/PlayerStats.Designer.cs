namespace WFApp
{
	partial class PlayerStats
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
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNumberOfGoals = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblYellowCards = new System.Windows.Forms.Label();
			this.pbPlayerImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Location = new System.Drawing.Point(120, 13);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
			this.lblPlayerName.TabIndex = 0;
			this.lblPlayerName.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Goals";
			// 
			// lblNumberOfGoals
			// 
			this.lblNumberOfGoals.AutoSize = true;
			this.lblNumberOfGoals.Location = new System.Drawing.Point(169, 47);
			this.lblNumberOfGoals.Name = "lblNumberOfGoals";
			this.lblNumberOfGoals.Size = new System.Drawing.Size(34, 13);
			this.lblNumberOfGoals.TabIndex = 2;
			this.lblNumberOfGoals.Text = "Goals";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Yellow cards: ";
			// 
			// lblYellowCards
			// 
			this.lblYellowCards.AutoSize = true;
			this.lblYellowCards.Location = new System.Drawing.Point(188, 89);
			this.lblYellowCards.Name = "lblYellowCards";
			this.lblYellowCards.Size = new System.Drawing.Size(33, 13);
			this.lblYellowCards.TabIndex = 4;
			this.lblYellowCards.Text = "cards";
			// 
			// pbPlayerImage
			// 
			this.pbPlayerImage.Location = new System.Drawing.Point(3, 3);
			this.pbPlayerImage.Name = "pbPlayerImage";
			this.pbPlayerImage.Size = new System.Drawing.Size(111, 132);
			this.pbPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPlayerImage.TabIndex = 5;
			this.pbPlayerImage.TabStop = false;
			// 
			// PlayerStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Controls.Add(this.pbPlayerImage);
			this.Controls.Add(this.lblYellowCards);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNumberOfGoals);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPlayerName);
			this.Name = "PlayerStats";
			this.Size = new System.Drawing.Size(236, 138);
			((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPlayerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNumberOfGoals;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblYellowCards;
		private System.Windows.Forms.PictureBox pbPlayerImage;
	}
}
