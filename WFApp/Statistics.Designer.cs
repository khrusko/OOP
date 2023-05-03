namespace WFApp
{
	partial class Statistics
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
			this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
			this.flpAttendance = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPrintMatches = new System.Windows.Forms.Button();
			this.btnPrintPlayers = new System.Windows.Forms.Button();
			this.printPreviewDialogPlayers = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocumentPlayers = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialogMatches = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocumentMatches = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// flpStatistics
			// 
			this.flpStatistics.AllowDrop = true;
			this.flpStatistics.AutoScroll = true;
			this.flpStatistics.Location = new System.Drawing.Point(34, 54);
			this.flpStatistics.Name = "flpStatistics";
			this.flpStatistics.Size = new System.Drawing.Size(302, 425);
			this.flpStatistics.TabIndex = 0;
			// 
			// flpAttendance
			// 
			this.flpAttendance.AllowDrop = true;
			this.flpAttendance.AutoScroll = true;
			this.flpAttendance.Location = new System.Drawing.Point(527, 54);
			this.flpAttendance.Name = "flpAttendance";
			this.flpAttendance.Size = new System.Drawing.Size(310, 425);
			this.flpAttendance.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(106, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Player statistics";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(637, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Attendance";
			// 
			// btnPrintMatches
			// 
			this.btnPrintMatches.Location = new System.Drawing.Point(383, 238);
			this.btnPrintMatches.Name = "btnPrintMatches";
			this.btnPrintMatches.Size = new System.Drawing.Size(87, 36);
			this.btnPrintMatches.TabIndex = 5;
			this.btnPrintMatches.Text = "Print matches";
			this.btnPrintMatches.UseVisualStyleBackColor = true;
			this.btnPrintMatches.Click += new System.EventHandler(this.btnPrintMatches_Click);
			// 
			// btnPrintPlayers
			// 
			this.btnPrintPlayers.Location = new System.Drawing.Point(383, 164);
			this.btnPrintPlayers.Name = "btnPrintPlayers";
			this.btnPrintPlayers.Size = new System.Drawing.Size(87, 36);
			this.btnPrintPlayers.TabIndex = 10;
			this.btnPrintPlayers.Text = "Print players";
			this.btnPrintPlayers.UseVisualStyleBackColor = true;
			this.btnPrintPlayers.Click += new System.EventHandler(this.btnPrintPlayers_Click);
			// 
			// printPreviewDialogPlayers
			// 
			this.printPreviewDialogPlayers.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialogPlayers.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialogPlayers.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialogPlayers.Document = this.printDocumentPlayers;
			this.printPreviewDialogPlayers.Enabled = true;
			this.printPreviewDialogPlayers.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPlayers.Icon")));
			this.printPreviewDialogPlayers.Name = "printPreviewDialogPlayers";
			this.printPreviewDialogPlayers.Visible = false;
			// 
			// printDocumentPlayers
			// 
			this.printDocumentPlayers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPlayers_PrintPage);
			// 
			// printPreviewDialogMatches
			// 
			this.printPreviewDialogMatches.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialogMatches.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialogMatches.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialogMatches.Document = this.printDocumentMatches;
			this.printPreviewDialogMatches.Enabled = true;
			this.printPreviewDialogMatches.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogMatches.Icon")));
			this.printPreviewDialogMatches.Name = "printPreviewDialogMatches";
			this.printPreviewDialogMatches.Visible = false;
			// 
			// printDocumentMatches
			// 
			this.printDocumentMatches.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentMatches_PrintPage);
			// 
			// Statistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 500);
			this.Controls.Add(this.btnPrintPlayers);
			this.Controls.Add(this.btnPrintMatches);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flpAttendance);
			this.Controls.Add(this.flpStatistics);
			this.Name = "Statistics";
			this.Text = "Statistics";
			this.Load += new System.EventHandler(this.Statistics_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpStatistics;
		private System.Windows.Forms.FlowLayoutPanel flpAttendance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPrintMatches;
		private System.Windows.Forms.Button btnPrintPlayers;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPlayers;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialogMatches;
		private System.Drawing.Printing.PrintDocument printDocumentPlayers;
		private System.Drawing.Printing.PrintDocument printDocumentMatches;
	}
}