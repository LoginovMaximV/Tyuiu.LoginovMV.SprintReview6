
namespace Tyuiu.LoginovMV.SprintReview6.TaskReview
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_LMV = new System.Windows.Forms.PictureBox();
            this.labelAbout_LMV = new System.Windows.Forms.Label();
            this.buttonOK_LMV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LMV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_LMV
            // 
            this.pictureBoxAvatar_LMV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_LMV.Image")));
            this.pictureBoxAvatar_LMV.Location = new System.Drawing.Point(1, -1);
            this.pictureBoxAvatar_LMV.Name = "pictureBoxAvatar_LMV";
            this.pictureBoxAvatar_LMV.Size = new System.Drawing.Size(220, 212);
            this.pictureBoxAvatar_LMV.TabIndex = 1;
            this.pictureBoxAvatar_LMV.TabStop = false;
            // 
            // labelAbout_LMV
            // 
            this.labelAbout_LMV.AutoSize = true;
            this.labelAbout_LMV.Location = new System.Drawing.Point(227, 12);
            this.labelAbout_LMV.Name = "labelAbout_LMV";
            this.labelAbout_LMV.Size = new System.Drawing.Size(413, 180);
            this.labelAbout_LMV.TabIndex = 2;
            this.labelAbout_LMV.Text = resources.GetString("labelAbout_LMV.Text");
            // 
            // buttonOK_LMV
            // 
            this.buttonOK_LMV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK_LMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK_LMV.Location = new System.Drawing.Point(539, 234);
            this.buttonOK_LMV.Name = "buttonOK_LMV";
            this.buttonOK_LMV.Size = new System.Drawing.Size(101, 46);
            this.buttonOK_LMV.TabIndex = 3;
            this.buttonOK_LMV.Text = "OK";
            this.buttonOK_LMV.UseVisualStyleBackColor = false;
            this.buttonOK_LMV.Click += new System.EventHandler(this.buttonOK_LMV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 284);
            this.Controls.Add(this.buttonOK_LMV);
            this.Controls.Add(this.labelAbout_LMV);
            this.Controls.Add(this.pictureBoxAvatar_LMV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 340);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LMV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_LMV;
        private System.Windows.Forms.Label labelAbout_LMV;
        private System.Windows.Forms.Button buttonOK_LMV;
    }
}