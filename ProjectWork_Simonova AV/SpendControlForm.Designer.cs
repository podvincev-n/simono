namespace ProjectWork_Simonova_AV
{
    partial class SpendControlForm
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
            this.components = new System.ComponentModel.Container();
            this.LimitDay = new System.Windows.Forms.Label();
            this.SpendMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddSpend = new System.Windows.Forms.Button();
            this.SpendStatistic = new System.Windows.Forms.Button();
            this.Wallets = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrentDate = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LimitDay
            // 
            this.LimitDay.AutoSize = true;
            this.LimitDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitDay.Location = new System.Drawing.Point(162, 144);
            this.LimitDay.Name = "LimitDay";
            this.LimitDay.Size = new System.Drawing.Size(266, 37);
            this.LimitDay.TabIndex = 1;
            this.LimitDay.Text = "Лимит на сегодня";
            // 
            // SpendMoney
            // 
            this.SpendMoney.AutoSize = true;
            this.SpendMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpendMoney.Location = new System.Drawing.Point(26, 299);
            this.SpendMoney.Name = "SpendMoney";
            this.SpendMoney.Size = new System.Drawing.Size(181, 37);
            this.SpendMoney.TabIndex = 2;
            this.SpendMoney.Text = "Потрачено:";
            this.SpendMoney.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Осталось:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectWork_Simonova_AV.Properties.Resources._318_9776;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 83);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddSpend
            // 
            this.AddSpend.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpend.Location = new System.Drawing.Point(470, 324);
            this.AddSpend.Name = "AddSpend";
            this.AddSpend.Size = new System.Drawing.Size(186, 58);
            this.AddSpend.TabIndex = 7;
            this.AddSpend.Text = "Добавить трату";
            this.AddSpend.UseVisualStyleBackColor = false;
            this.AddSpend.Click += new System.EventHandler(this.AddSpend_Click);
            // 
            // SpendStatistic
            // 
            this.SpendStatistic.BackColor = System.Drawing.Color.LightCoral;
            this.SpendStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpendStatistic.Location = new System.Drawing.Point(470, 526);
            this.SpendStatistic.Name = "SpendStatistic";
            this.SpendStatistic.Size = new System.Drawing.Size(186, 58);
            this.SpendStatistic.TabIndex = 8;
            this.SpendStatistic.Text = "Анализ трат";
            this.SpendStatistic.UseVisualStyleBackColor = false;
            this.SpendStatistic.Click += new System.EventHandler(this.SpendStat_Click);
            // 
            // Wallets
            // 
            this.Wallets.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Wallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wallets.Location = new System.Drawing.Point(37, 526);
            this.Wallets.Name = "Wallets";
            this.Wallets.Size = new System.Drawing.Size(186, 58);
            this.Wallets.TabIndex = 9;
            this.Wallets.Text = "Кошелёк";
            this.Wallets.UseVisualStyleBackColor = false;
            this.Wallets.Click += new System.EventHandler(this.Wallets_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Здесь выводить статус (транжира, молодец)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CurrentDate
            // 
            this.CurrentDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(137, 38);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(165, 58);
            this.CurrentDate.TabIndex = 11;
            this.CurrentDate.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(193, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 74);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(33, 445);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 47);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(206, 299);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(142, 42);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(193, 363);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(142, 42);
            this.richTextBox4.TabIndex = 15;
            this.richTextBox4.Text = "";
            // 
            // SpendControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 611);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wallets);
            this.Controls.Add(this.SpendStatistic);
            this.Controls.Add(this.AddSpend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpendMoney);
            this.Controls.Add(this.LimitDay);
            this.Name = "SpendControlForm";
            this.Text = "Расходы на сегодня";
            this.Load += new System.EventHandler(this.SpendControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LimitDay;
        private System.Windows.Forms.Label SpendMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddSpend;
        private System.Windows.Forms.Button SpendStatistic;
        private System.Windows.Forms.Button Wallets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox CurrentDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}