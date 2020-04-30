namespace ProjectWork_Simonova_AV.Forms
{
    partial class AddCategory
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
            this.CancelSpendAdd = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelSpendAdd
            // 
            this.CancelSpendAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSpendAdd.Location = new System.Drawing.Point(497, 435);
            this.CancelSpendAdd.Name = "CancelSpendAdd";
            this.CancelSpendAdd.Size = new System.Drawing.Size(168, 46);
            this.CancelSpendAdd.TabIndex = 28;
            this.CancelSpendAdd.Text = "Отменить";
            this.CancelSpendAdd.UseVisualStyleBackColor = true;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryButton.Location = new System.Drawing.Point(202, 435);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(205, 46);
            this.AddCategoryButton.TabIndex = 27;
            this.AddCategoryButton.Text = "Добавить";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(421, 217);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(329, 20);
            this.categoryName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "Введи название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Добавить новую категорию";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.CancelSpendAdd);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelSpendAdd;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}