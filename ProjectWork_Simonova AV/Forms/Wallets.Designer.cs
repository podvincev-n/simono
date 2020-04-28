namespace ProjectWork_Simonova_AV.Forms
{
    partial class Wallets
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
            this.Return = new System.Windows.Forms.Button();
            this.AddWallet = new System.Windows.Forms.Button();
            this.walletList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.Location = new System.Drawing.Point(602, 380);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(186, 58);
            this.Return.TabIndex = 14;
            this.Return.Text = "Назад";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // AddWallet
            // 
            this.AddWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWallet.Location = new System.Drawing.Point(12, 380);
            this.AddWallet.Name = "AddWallet";
            this.AddWallet.Size = new System.Drawing.Size(210, 58);
            this.AddWallet.TabIndex = 13;
            this.AddWallet.Text = "Добавить кошелёк";
            this.AddWallet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddWallet.UseVisualStyleBackColor = true;
            this.AddWallet.Click += new System.EventHandler(this.AddWallet_Click);
            // 
            // walletList
            // 
            this.walletList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.balance,
            this.button});
            this.walletList.HideSelection = false;
            this.walletList.Location = new System.Drawing.Point(12, 12);
            this.walletList.Name = "walletList";
            this.walletList.Size = new System.Drawing.Size(776, 361);
            this.walletList.TabIndex = 16;
            this.walletList.UseCompatibleStateImageBehavior = false;
            this.walletList.SelectedIndexChanged += new System.EventHandler(this.walletList_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Название кошелька";
            // 
            // balance
            // 
            this.balance.Text = "Остаток";
            // 
            // button
            // 
            this.button.Text = "Добавить денег";
            // 
            // Wallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.walletList);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.AddWallet);
            this.Name = "Wallets";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Wallets_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button AddWallet;
        private System.Windows.Forms.ListView walletList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.ColumnHeader button;
    }
}