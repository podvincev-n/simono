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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.todayLimit = new System.Windows.Forms.Label();
            this.todaySpendSum = new System.Windows.Forms.Label();
            this.todaybalance = new System.Windows.Forms.Label();
            this.richStatus = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
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
            this.Wallets.Text = "Кошельки";
            this.Wallets.UseVisualStyleBackColor = false;
            this.Wallets.Click += new System.EventHandler(this.Wallets_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // todayLimit
            // 
            this.todayLimit.AutoSize = true;
            this.todayLimit.Location = new System.Drawing.Point(172, 206);
            this.todayLimit.Name = "todayLimit";
            this.todayLimit.Size = new System.Drawing.Size(13, 13);
            this.todayLimit.TabIndex = 16;
            this.todayLimit.Text = "0";
            // 
            // todaySpendSum
            // 
            this.todaySpendSum.AutoSize = true;
            this.todaySpendSum.Location = new System.Drawing.Point(214, 309);
            this.todaySpendSum.Name = "todaySpendSum";
            this.todaySpendSum.Size = new System.Drawing.Size(13, 13);
            this.todaySpendSum.TabIndex = 17;
            this.todaySpendSum.Text = "0";
            // 
            // todaybalance
            // 
            this.todaybalance.AutoSize = true;
            this.todaybalance.Location = new System.Drawing.Point(197, 374);
            this.todaybalance.Name = "todaybalance";
            this.todaybalance.Size = new System.Drawing.Size(13, 13);
            this.todaybalance.TabIndex = 18;
            this.todaybalance.Text = "0";
            // 
            // richStatus
            // 
            this.richStatus.AutoSize = true;
            this.richStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.richStatus.Location = new System.Drawing.Point(37, 459);
            this.richStatus.Name = "richStatus";
            this.richStatus.Size = new System.Drawing.Size(0, 31);
            this.richStatus.TabIndex = 19;
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CurrentDate.Location = new System.Drawing.Point(154, 56);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(0, 31);
            this.CurrentDate.TabIndex = 20;
            // 
            // SpendControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 611);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.richStatus);
            this.Controls.Add(this.todaybalance);
            this.Controls.Add(this.todaySpendSum);
            this.Controls.Add(this.todayLimit);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label todayLimit;
        private System.Windows.Forms.Label todaySpendSum;
        private System.Windows.Forms.Label todaybalance;
        private System.Windows.Forms.Label richStatus;
        private System.Windows.Forms.Label CurrentDate;
    }
}