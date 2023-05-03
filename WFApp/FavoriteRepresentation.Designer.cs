
namespace WFApp
{
    partial class FavoriteRepresentation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteRepresentation));
			this.cbRepresentation = new System.Windows.Forms.ComboBox();
			this.lblRepresentation = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSubmitRepresentation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbRepresentation
			// 
			resources.ApplyResources(this.cbRepresentation, "cbRepresentation");
			this.cbRepresentation.FormattingEnabled = true;
			this.cbRepresentation.Name = "cbRepresentation";
			// 
			// lblRepresentation
			// 
			resources.ApplyResources(this.lblRepresentation, "lblRepresentation");
			this.lblRepresentation.Name = "lblRepresentation";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// btnSubmitRepresentation
			// 
			resources.ApplyResources(this.btnSubmitRepresentation, "btnSubmitRepresentation");
			this.btnSubmitRepresentation.BackColor = System.Drawing.Color.Lime;
			this.btnSubmitRepresentation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSubmitRepresentation.Name = "btnSubmitRepresentation";
			this.btnSubmitRepresentation.UseVisualStyleBackColor = false;
			this.btnSubmitRepresentation.Click += new System.EventHandler(this.btnSubmitRepresentation_Click);
			// 
			// FavoriteRepresentation
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnSubmitRepresentation);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblRepresentation);
			this.Controls.Add(this.cbRepresentation);
			this.Name = "FavoriteRepresentation";
			this.Load += new System.EventHandler(this.FavoriteRepresentation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRepresentation;
        private System.Windows.Forms.Label lblRepresentation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitRepresentation;
    }
}