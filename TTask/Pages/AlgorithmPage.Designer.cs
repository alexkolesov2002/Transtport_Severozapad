
namespace TTask.Pages
{
    partial class AlgorithmPage
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.nTxb = new System.Windows.Forms.TextBox();
            this.mTxb = new System.Windows.Forms.TextBox();
            this.mVecDGV = new System.Windows.Forms.DataGridView();
            this.nVecDGV = new System.Windows.Forms.DataGridView();
            this.aMatrDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mVecDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVecDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMatrDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(894, 450);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "Расчет";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // nTxb
            // 
            this.nTxb.Location = new System.Drawing.Point(193, 58);
            this.nTxb.Name = "nTxb";
            this.nTxb.Size = new System.Drawing.Size(100, 22);
            this.nTxb.TabIndex = 4;
            this.nTxb.TextChanged += new System.EventHandler(this.NTxb_TextChanged);
            // 
            // mTxb
            // 
            this.mTxb.Location = new System.Drawing.Point(193, 18);
            this.mTxb.Name = "mTxb";
            this.mTxb.Size = new System.Drawing.Size(100, 22);
            this.mTxb.TabIndex = 5;
            this.mTxb.TextChanged += new System.EventHandler(this.MTxb_TextChanged);
            // 
            // mVecDGV
            // 
            this.mVecDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mVecDGV.Location = new System.Drawing.Point(312, 79);
            this.mVecDGV.Name = "mVecDGV";
            this.mVecDGV.RowTemplate.Height = 24;
            this.mVecDGV.Size = new System.Drawing.Size(88, 358);
            this.mVecDGV.TabIndex = 6;
            // 
            // nVecDGV
            // 
            this.nVecDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nVecDGV.Location = new System.Drawing.Point(417, 9);
            this.nVecDGV.Name = "nVecDGV";
            this.nVecDGV.RowTemplate.Height = 24;
            this.nVecDGV.Size = new System.Drawing.Size(552, 40);
            this.nVecDGV.TabIndex = 7;
            // 
            // aMatrDGV
            // 
            this.aMatrDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aMatrDGV.Location = new System.Drawing.Point(417, 79);
            this.aMatrDGV.Name = "aMatrDGV";
            this.aMatrDGV.RowTemplate.Height = 24;
            this.aMatrDGV.Size = new System.Drawing.Size(552, 358);
            this.aMatrDGV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество поставщиков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество потребителей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "A";
            // 
            // AlgorithmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aMatrDGV);
            this.Controls.Add(this.nVecDGV);
            this.Controls.Add(this.mVecDGV);
            this.Controls.Add(this.mTxb);
            this.Controls.Add(this.nTxb);
            this.Controls.Add(this.calcBtn);
            this.Name = "AlgorithmPage";
            this.Size = new System.Drawing.Size(972, 486);
            ((System.ComponentModel.ISupportInitialize)(this.mVecDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVecDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMatrDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox nTxb;
        private System.Windows.Forms.TextBox mTxb;
        private System.Windows.Forms.DataGridView mVecDGV;
        private System.Windows.Forms.DataGridView nVecDGV;
        private System.Windows.Forms.DataGridView aMatrDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
