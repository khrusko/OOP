namespace WFApp
{
    partial class StartingSettings
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.gBoxChampionship = new System.Windows.Forms.GroupBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.rBtnWomen = new System.Windows.Forms.RadioButton();
			this.rBtnMen = new System.Windows.Forms.RadioButton();
			this.gBoxLanguage = new System.Windows.Forms.GroupBox();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.rBtnEnglish = new System.Windows.Forms.RadioButton();
			this.rBtnCroatian = new System.Windows.Forms.RadioButton();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.gBoxChampionship.SuspendLayout();
			this.gBoxLanguage.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(169, 23);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(446, 39);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Football championship app";
			// 
			// gBoxChampionship
			// 
			this.gBoxChampionship.Controls.Add(this.lblGender);
			this.gBoxChampionship.Controls.Add(this.rBtnWomen);
			this.gBoxChampionship.Controls.Add(this.rBtnMen);
			this.gBoxChampionship.Location = new System.Drawing.Point(108, 113);
			this.gBoxChampionship.Name = "gBoxChampionship";
			this.gBoxChampionship.Size = new System.Drawing.Size(256, 162);
			this.gBoxChampionship.TabIndex = 4;
			this.gBoxChampionship.TabStop = false;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.Location = new System.Drawing.Point(28, 42);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(132, 16);
			this.lblGender.TabIndex = 4;
			this.lblGender.Text = "Which championship:";
			// 
			// rBtnWomen
			// 
			this.rBtnWomen.AutoSize = true;
			this.rBtnWomen.Location = new System.Drawing.Point(176, 81);
			this.rBtnWomen.Name = "rBtnWomen";
			this.rBtnWomen.Size = new System.Drawing.Size(62, 17);
			this.rBtnWomen.TabIndex = 3;
			this.rBtnWomen.Text = "Women";
			this.rBtnWomen.UseVisualStyleBackColor = true;
			// 
			// rBtnMen
			// 
			this.rBtnMen.AutoSize = true;
			this.rBtnMen.Checked = true;
			this.rBtnMen.Location = new System.Drawing.Point(176, 42);
			this.rBtnMen.Name = "rBtnMen";
			this.rBtnMen.Size = new System.Drawing.Size(46, 17);
			this.rBtnMen.TabIndex = 2;
			this.rBtnMen.TabStop = true;
			this.rBtnMen.Text = "Men";
			this.rBtnMen.UseVisualStyleBackColor = true;
			// 
			// gBoxLanguage
			// 
			this.gBoxLanguage.Controls.Add(this.lblLanguage);
			this.gBoxLanguage.Controls.Add(this.rBtnEnglish);
			this.gBoxLanguage.Controls.Add(this.rBtnCroatian);
			this.gBoxLanguage.Location = new System.Drawing.Point(478, 113);
			this.gBoxLanguage.Name = "gBoxLanguage";
			this.gBoxLanguage.Size = new System.Drawing.Size(200, 162);
			this.gBoxLanguage.TabIndex = 5;
			this.gBoxLanguage.TabStop = false;
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLanguage.Location = new System.Drawing.Point(17, 42);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(69, 16);
			this.lblLanguage.TabIndex = 5;
			this.lblLanguage.Text = "Langauge:";
			// 
			// rBtnEnglish
			// 
			this.rBtnEnglish.AutoSize = true;
			this.rBtnEnglish.Checked = true;
			this.rBtnEnglish.Location = new System.Drawing.Point(92, 42);
			this.rBtnEnglish.Name = "rBtnEnglish";
			this.rBtnEnglish.Size = new System.Drawing.Size(59, 17);
			this.rBtnEnglish.TabIndex = 1;
			this.rBtnEnglish.TabStop = true;
			this.rBtnEnglish.Text = "English";
			this.rBtnEnglish.UseVisualStyleBackColor = true;
			// 
			// rBtnCroatian
			// 
			this.rBtnCroatian.AutoSize = true;
			this.rBtnCroatian.Location = new System.Drawing.Point(92, 81);
			this.rBtnCroatian.Name = "rBtnCroatian";
			this.rBtnCroatian.Size = new System.Drawing.Size(64, 17);
			this.rBtnCroatian.TabIndex = 0;
			this.rBtnCroatian.Text = "Croatian";
			this.rBtnCroatian.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.Lime;
			this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(217, 317);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(350, 38);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// StartingSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.gBoxLanguage);
			this.Controls.Add(this.gBoxChampionship);
			this.Controls.Add(this.lblTitle);
			this.Name = "StartingSettings";
			this.Text = "StartMenu";
			this.Load += new System.EventHandler(this.StartingSettings_Load);
			this.gBoxChampionship.ResumeLayout(false);
			this.gBoxChampionship.PerformLayout();
			this.gBoxLanguage.ResumeLayout(false);
			this.gBoxLanguage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gBoxChampionship;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rBtnWomen;
        private System.Windows.Forms.RadioButton rBtnMen;
        private System.Windows.Forms.GroupBox gBoxLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.RadioButton rBtnEnglish;
        private System.Windows.Forms.RadioButton rBtnCroatian;
        private System.Windows.Forms.Button btnSubmit;
    }
}

