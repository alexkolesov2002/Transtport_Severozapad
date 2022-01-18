
namespace TTask.Pages
{
    partial class TaskDescriptionPage
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
            this.toAlgBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toAlgBtn
            // 
            this.toAlgBtn.Location = new System.Drawing.Point(21, 292);
            this.toAlgBtn.Name = "toAlgBtn";
            this.toAlgBtn.Size = new System.Drawing.Size(75, 23);
            this.toAlgBtn.TabIndex = 1;
            this.toAlgBtn.Text = "К задаче";
            this.toAlgBtn.UseVisualStyleBackColor = true;
            this.toAlgBtn.Click += new System.EventHandler(this.ToAlgBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::TTask.Properties.Resources.task;
            this.pictureBox1.Location = new System.Drawing.Point(124, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 605);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TaskDescriptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toAlgBtn);
            this.Name = "TaskDescriptionPage";
            this.Size = new System.Drawing.Size(1196, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toAlgBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
