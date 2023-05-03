namespace WFApp
{
	partial class FavoritePlayers
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
			this.btnStatistics = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblasdasd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
			this.flpFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// btnStatistics
			// 
			this.btnStatistics.Location = new System.Drawing.Point(340, 399);
			this.btnStatistics.Name = "btnStatistics";
			this.btnStatistics.Size = new System.Drawing.Size(114, 23);
			this.btnStatistics.TabIndex = 0;
			this.btnStatistics.Text = "Go to statistics";
			this.btnStatistics.UseVisualStyleBackColor = true;
			this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(611, 399);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblasdasd
			// 
			this.lblasdasd.AutoSize = true;
			this.lblasdasd.Location = new System.Drawing.Point(129, 82);
			this.lblasdasd.Name = "lblasdasd";
			this.lblasdasd.Size = new System.Drawing.Size(54, 13);
			this.lblasdasd.TabIndex = 2;
			this.lblasdasd.Text = "All players";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(595, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Favorite players";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(221, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(350, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "Favorite player picker";
			// 
			// flpAllPlayers
			// 
			this.flpAllPlayers.AutoScroll = true;
			this.flpAllPlayers.Location = new System.Drawing.Point(67, 109);
			this.flpAllPlayers.Name = "flpAllPlayers";
			this.flpAllPlayers.Size = new System.Drawing.Size(272, 259);
			this.flpAllPlayers.TabIndex = 5;
			// 
			// flpFavoritePlayers
			// 
			this.flpFavoritePlayers.AllowDrop = true;
			this.flpFavoritePlayers.AutoScroll = true;
			this.flpFavoritePlayers.Location = new System.Drawing.Point(471, 109);
			this.flpFavoritePlayers.Name = "flpFavoritePlayers";
			this.flpFavoritePlayers.Size = new System.Drawing.Size(275, 259);
			this.flpFavoritePlayers.TabIndex = 6;
			this.flpFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragDrop);
			this.flpFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritePlayers_DragEnter);
			// 
			// FavoritePlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flpFavoritePlayers);
			this.Controls.Add(this.flpAllPlayers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblasdasd);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnStatistics);
			this.Name = "FavoritePlayers";
			this.Text = "FavoritePlayers";
			this.Load += new System.EventHandler(this.FavoritePlayers_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStatistics;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblasdasd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
		private System.Windows.Forms.FlowLayoutPanel flpFavoritePlayers;
	}
}