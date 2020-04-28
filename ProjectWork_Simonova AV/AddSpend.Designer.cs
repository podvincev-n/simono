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
            this.SpendCategoryList = new System.Windows.Forms.ListBox();
            this.AddSum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSpendButton = new System.Windows.Forms.Button();
            this.CancelSpendAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategorySpend
            // 
            this.CategorySpend.AutoSize = true;
            this.CategorySpend.Font = new System.Drawing.Font("Intro ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySpend.Location = new System.Drawing.Point(12, 124);
            this.CategorySpend.Name = "CategorySpend";
            this.CategorySpend.Size = new System.Drawing.Size(351, 35);
            this.CategorySpend.TabIndex = 0;
            this.CategorySpend.Text = "Выбери категорию:";
            this.CategorySpend.Click += new System.EventHandler(this.CategorySpend_Click);
            // 
            // SpendCategoryList
            // 
            this.SpendCategoryList.Font = new System.Drawing.Font("PT Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpendCategoryList.FormattingEnabled = true;
            this.SpendCategoryList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpendCategoryList.ItemHeight = 27;
            this.SpendCategoryList.Items.AddRange(new object[] {
            "Займ",
            "Одежда",
            "Кафе,рестораны",
            "Косметика",
            "Кредиты",
            "Одежда",
            "Подарки ",
            "Продукты",
            "Рабочие обеды",
            "Связь",
            "Транспорт",
            "Товары для дома",
            "Товары для кошек",
            "Отпуск",
            "Учеба"});
            this.SpendCategoryList.Location = new System.Drawing.Point(375, 124);
            this.SpendCategoryList.Name = "SpendCategoryList";
            this.SpendCategoryList.Size = new System.Drawing.Size(309, 301);
            this.SpendCategoryList.TabIndex = 1;
            this.SpendCategoryList.SelectedIndexChanged += new System.EventHandler(this.SpendCategoryList_SelectedIndexChanged);
            // 
            // AddSum
            // 
            this.AddSum.AutoSize = true;
            this.AddSum.Font = new System.Drawing.Font("Intro ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSum.Location = new System.Drawing.Point(12, 483);
            this.AddSum.Name = "AddSum";
            this.AddSum.Size = new System.Drawing.Size(244, 35);
            this.AddSum.TabIndex = 2;
            this.AddSum.Text = "Введи сумму:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 483);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 35);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intro ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить новую трату";
            // 
            // AddSpendButton
            // 
            this.AddSpendButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddSpendButton.Font = new System.Drawing.Font("Intro ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpendButton.Location = new System.Drawing.Point(468, 600);
            this.AddSpendButton.Name = "AddSpendButton";
            this.AddSpendButton.Size = new System.Drawing.Size(216, 54);
            this.AddSpendButton.TabIndex = 5;
            this.AddSpendButton.Text = "Добавить";
            this.AddSpendButton.UseVisualStyleBackColor = false;
            // 
            // CancelSpendAdd
            // 
            this.CancelSpendAdd.BackColor = System.Drawing.Color.LightCoral;
            this.CancelSpendAdd.Font = new System.Drawing.Font("Intro ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSpendAdd.Location = new System.Drawing.Point(12, 600);
            this.CancelSpendAdd.Name = "CancelSpendAdd";
            this.CancelSpendAdd.Size = new System.Drawing.Size(221, 54);
            this.CancelSpendAdd.TabIndex = 6;
            this.CancelSpendAdd.Text = "Отменить";
            this.CancelSpendAdd.UseVisualStyleBackColor = false;
            this.CancelSpendAdd.Click += new System.EventHandler(this.CancelSpendAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Sans", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(241, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "или создай новую";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // AddSpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelSpendAdd);
            this.Controls.Add(this.AddSpendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddSum);
            this.Controls.Add(this.SpendCategoryList);
            this.Controls.Add(this.CategorySpend);
            this.Name = "AddSpend";
            this.Text = "Добавить трату";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategorySpend;
        private System.Windows.Forms.ListBox SpendCategoryList;
        private System.Windows.Forms.Label AddSum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpendButton;
        private System.Windows.Forms.Button CancelSpendAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}