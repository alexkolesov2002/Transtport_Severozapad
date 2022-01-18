
namespace TTask.Pages
{
    partial class ResultPage
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
            this.toHomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resTxb = new System.Windows.Forms.TextBox();
            this.iterBtn = new System.Windows.Forms.Button();
            this.showResBtn = new System.Windows.Forms.Button();
            this.iterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toHomeBtn
            // 
            this.toHomeBtn.Location = new System.Drawing.Point(20, 23);
            this.toHomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toHomeBtn.Name = "toHomeBtn";
            this.toHomeBtn.Size = new System.Drawing.Size(112, 37);
            this.toHomeBtn.TabIndex = 5;
            this.toHomeBtn.Text = "Домой";
            this.toHomeBtn.UseVisualStyleBackColor = true;
            this.toHomeBtn.Click += new System.EventHandler(this.ToHomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результаты";
            // 
            // resTxb
            // 
            this.resTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resTxb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resTxb.Location = new System.Drawing.Point(0, 69);
            this.resTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resTxb.Multiline = true;
            this.resTxb.Name = "resTxb";
            this.resTxb.ReadOnly = true;
            this.resTxb.Size = new System.Drawing.Size(1268, 489);
            this.resTxb.TabIndex = 6;
            // 
            // iterBtn
            // 
            this.iterBtn.Location = new System.Drawing.Point(745, 22);
            this.iterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iterBtn.Name = "iterBtn";
            this.iterBtn.Size = new System.Drawing.Size(124, 37);
            this.iterBtn.TabIndex = 7;
            this.iterBtn.Text = "Итеративно";
            this.iterBtn.UseVisualStyleBackColor = true;
            this.iterBtn.Click += new System.EventHandler(this.IterBtn_Click);
            // 
            // showResBtn
            // 
            this.showResBtn.Location = new System.Drawing.Point(428, 23);
            this.showResBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showResBtn.Name = "showResBtn";
            this.showResBtn.Size = new System.Drawing.Size(209, 37);
            this.showResBtn.TabIndex = 8;
            this.showResBtn.Text = "Не итеративно";
            this.showResBtn.UseVisualStyleBackColor = true;
            this.showResBtn.Click += new System.EventHandler(this.ShowResBtn_Click);
            // 
            // iterLbl
            // 
            this.iterLbl.AutoSize = true;
            this.iterLbl.Location = new System.Drawing.Point(897, 31);
            this.iterLbl.Name = "iterLbl";
            this.iterLbl.Size = new System.Drawing.Size(54, 21);
            this.iterLbl.TabIndex = 9;
            this.iterLbl.Text = "label2";
            // 
            // ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iterLbl);
            this.Controls.Add(this.showResBtn);
            this.Controls.Add(this.iterBtn);
            this.Controls.Add(this.resTxb);
            this.Controls.Add(this.toHomeBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResultPage";
            this.Size = new System.Drawing.Size(1270, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toHomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resTxb;
        private System.Windows.Forms.Button iterBtn;
        private System.Windows.Forms.Button showResBtn;
        private System.Windows.Forms.Label iterLbl;
    }
}
