namespace ProjectWork_Simonova_AV.Forms
{
    partial class AddIncome
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
            this.incomeSum = new System.Windows.Forms.NumericUpDown();
            this.addInc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeSum)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeSum
            // 
            this.incomeSum.Location = new System.Drawing.Point(328, 159);
            this.incomeSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.incomeSum.Name = "incomeSum";
            this.incomeSum.Size = new System.Drawing.Size(120, 20);
            this.incomeSum.TabIndex = 0;
            // 
            // addInc
            // 
            this.addInc.Location = new System.Drawing.Point(353, 264);
            this.addInc.Name = "addInc";
            this.addInc.Size = new System.Drawing.Size(75, 23);
            this.addInc.TabIndex = 1;
            this.addInc.Text = "Добавить";
            this.addInc.UseVisualStyleBackColor = true;
            this.addInc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addInc);
            this.Controls.Add(this.incomeSum);
            this.Name = "AddIncome";
            this.Text = "Добавить денег в кошелек";
            this.Load += new System.EventHandler(this.AddIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown incomeSum;
        private System.Windows.Forms.Button addInc;
        private System.Windows.Forms.Label label1;
    }
}