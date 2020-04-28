namespace ProjectWork_Simonova_AV.Forms
{
    partial class AddWallet
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
            this.walletSum = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CancelSpendAdd = new System.Windows.Forms.Button();
            this.AddWalletButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.walletName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.walletSum)).BeginInit();
            this.SuspendLayout();
            // 
            // walletSum
            // 
            this.walletSum.Location = new System.Drawing.Point(535, 289);
            this.walletSum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.walletSum.Name = "walletSum";
            this.walletSum.Size = new System.Drawing.Size(226, 20);
            this.walletSum.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(110, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(373, 37);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Отобразить в кошельках";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CancelSpendAdd
            // 
            this.CancelSpendAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSpendAdd.Location = new System.Drawing.Point(537, 516);
            this.CancelSpendAdd.Name = "CancelSpendAdd";
            this.CancelSpendAdd.Size = new System.Drawing.Size(168, 46);
            this.CancelSpendAdd.TabIndex = 20;
            this.CancelSpendAdd.Text = "Отменить";
            this.CancelSpendAdd.UseVisualStyleBackColor = true;
            this.CancelSpendAdd.Click += new System.EventHandler(this.CancelSpendAdd_Click);
            // 
            // AddWalletButton
            // 
            this.AddWalletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWalletButton.Location = new System.Drawing.Point(242, 516);
            this.AddWalletButton.Name = "AddWalletButton";
            this.AddWalletButton.Size = new System.Drawing.Size(205, 46);
            this.AddWalletButton.TabIndex = 19;
            this.AddWalletButton.Text = "Добавить";
            this.AddWalletButton.UseVisualStyleBackColor = true;
            this.AddWalletButton.Click += new System.EventHandler(this.AddWalletButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Добавь в него деньги:";
            // 
            // walletName
            // 
            this.walletName.Location = new System.Drawing.Point(457, 171);
            this.walletName.Name = "walletName";
            this.walletName.Size = new System.Drawing.Size(329, 20);
            this.walletName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введи название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить новый кошелёк";
            // 
            // AddWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 595);
            this.Controls.Add(this.walletSum);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CancelSpendAdd);
            this.Controls.Add(this.AddWalletButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.walletName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWallet";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.walletSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown walletSum;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button CancelSpendAdd;
        private System.Windows.Forms.Button AddWalletButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox walletName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}