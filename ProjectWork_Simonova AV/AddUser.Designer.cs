namespace ProjectWork_Simonova_AV
{
    partial class AddUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserPassField = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 85);
            this.panel1.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Location = new System.Drawing.Point(363, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 25);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intro ", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameField
            // 
            this.UserNameField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UserNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameField.ForeColor = System.Drawing.Color.Black;
            this.UserNameField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserNameField.Location = new System.Drawing.Point(19, 172);
            this.UserNameField.Multiline = true;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(317, 58);
            this.UserNameField.TabIndex = 8;
            this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("PT Sans Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(12, 114);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(226, 42);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Имя пользователя:";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // UserPassField
            // 
            this.UserPassField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UserPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPassField.ForeColor = System.Drawing.Color.Black;
            this.UserPassField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserPassField.Location = new System.Drawing.Point(22, 319);
            this.UserPassField.Name = "UserPassField";
            this.UserPassField.Size = new System.Drawing.Size(317, 31);
            this.UserPassField.TabIndex = 10;
            this.UserPassField.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("PT Sans Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(15, 262);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 42);
            this.Password.TabIndex = 9;
            this.Password.Text = "Пароль:";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.RegisterButton.Font = new System.Drawing.Font("Intro ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(28, 392);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(311, 46);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 490);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UserPassField);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.Text = "NewUser";
            this.Enter += new System.EventHandler(this.AddUser_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserPassField;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button RegisterButton;
    }
}