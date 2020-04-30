namespace ProjectWork_Simonova_AV
{
    partial class AddSpend
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
            this.CategorySpend = new System.Windows.Forms.Label();
            this.AddSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSpendButton = new System.Windows.Forms.Button();
            this.CancelSpendAdd = new System.Windows.Forms.Button();
            this.addNewCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spendSum = new System.Windows.Forms.NumericUpDown();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.walletList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendSum)).BeginInit();
            this.SuspendLayout();
            // 
            // CategorySpend
            // 
            this.CategorySpend.AutoSize = true;
            this.CategorySpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySpend.Location = new System.Drawing.Point(12, 124);
            this.CategorySpend.Name = "CategorySpend";
            this.CategorySpend.Size = new System.Drawing.Size(277, 33);
            this.CategorySpend.TabIndex = 0;
            this.CategorySpend.Text = "Выбери категорию:";
            this.CategorySpend.Click += new System.EventHandler(this.CategorySpend_Click);
            // 
            // AddSum
            // 
            this.AddSum.AutoSize = true;
            this.AddSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSum.Location = new System.Drawing.Point(12, 483);
            this.AddSum.Name = "AddSum";
            this.AddSum.Size = new System.Drawing.Size(201, 33);
            this.AddSum.TabIndex = 2;
            this.AddSum.Text = "Введи сумму:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить новую трату";
            // 
            // AddSpendButton
            // 
            this.AddSpendButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddSpendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpendButton.Location = new System.Drawing.Point(468, 600);
            this.AddSpendButton.Name = "AddSpendButton";
            this.AddSpendButton.Size = new System.Drawing.Size(216, 54);
            this.AddSpendButton.TabIndex = 5;
            this.AddSpendButton.Text = "Добавить";
            this.AddSpendButton.UseVisualStyleBackColor = false;
            this.AddSpendButton.Click += new System.EventHandler(this.AddSpendButton_Click);
            // 
            // CancelSpendAdd
            // 
            this.CancelSpendAdd.BackColor = System.Drawing.Color.LightCoral;
            this.CancelSpendAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSpendAdd.Location = new System.Drawing.Point(12, 600);
            this.CancelSpendAdd.Name = "CancelSpendAdd";
            this.CancelSpendAdd.Size = new System.Drawing.Size(221, 54);
            this.CancelSpendAdd.TabIndex = 6;
            this.CancelSpendAdd.Text = "Отменить";
            this.CancelSpendAdd.UseVisualStyleBackColor = false;
            this.CancelSpendAdd.Click += new System.EventHandler(this.CancelSpendAdd_Click);
            // 
            // addNewCategory
            // 
            this.addNewCategory.AutoSize = true;
            this.addNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addNewCategory.Location = new System.Drawing.Point(241, 173);
            this.addNewCategory.Name = "addNewCategory";
            this.addNewCategory.Size = new System.Drawing.Size(127, 16);
            this.addNewCategory.TabIndex = 7;
            this.addNewCategory.Text = "или создай новую";
            this.addNewCategory.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 101);
            this.panel1.TabIndex = 8;
            // 
            // spendSum
            // 
            this.spendSum.Location = new System.Drawing.Point(244, 496);
            this.spendSum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spendSum.Name = "spendSum";
            this.spendSum.Size = new System.Drawing.Size(120, 20);
            this.spendSum.TabIndex = 10;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(468, 124);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(121, 21);
            this.categoryList.TabIndex = 11;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выбери кошелек";
            // 
            // walletList
            // 
            this.walletList.FormattingEnabled = true;
            this.walletList.Location = new System.Drawing.Point(458, 319);
            this.walletList.Name = "walletList";
            this.walletList.Size = new System.Drawing.Size(121, 21);
            this.walletList.TabIndex = 13;
            // 
            // AddSpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 683);
            this.Controls.Add(this.walletList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.spendSum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addNewCategory);
            this.Controls.Add(this.CancelSpendAdd);
            this.Controls.Add(this.AddSpendButton);
            this.Controls.Add(this.AddSum);
            this.Controls.Add(this.CategorySpend);
            this.Name = "AddSpend";
            this.Text = "Добавить трату";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategorySpend;
        private System.Windows.Forms.Label AddSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpendButton;
        private System.Windows.Forms.Button CancelSpendAdd;
        private System.Windows.Forms.Label addNewCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown spendSum;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox walletList;
    }
}