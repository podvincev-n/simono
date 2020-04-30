namespace ProjectWork_Simonova_AV.Forms
{
    partial class DeleteWallet
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
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.notdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уверен, что хочешь удалить кошелек?";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(243, 72);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "ДА";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // notdelete
            // 
            this.notdelete.Location = new System.Drawing.Point(12, 72);
            this.notdelete.Name = "notdelete";
            this.notdelete.Size = new System.Drawing.Size(75, 23);
            this.notdelete.TabIndex = 2;
            this.notdelete.Text = "НЕТ";
            this.notdelete.UseVisualStyleBackColor = true;
            this.notdelete.Click += new System.EventHandler(this.notdelete_Click);
            // 
            // DeleteWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 119);
            this.Controls.Add(this.notdelete);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWallet";
            this.Text = "Удалить кошелек";
            this.Load += new System.EventHandler(this.DeleteWallet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button notdelete;
    }
}