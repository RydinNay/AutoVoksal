namespace Kyrs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.logtextBox1 = new System.Windows.Forms.TextBox();
            this.passtextBox1 = new System.Windows.Forms.TextBox();
            this.logtextBox2 = new System.Windows.Forms.TextBox();
            this.passtextBox2 = new System.Windows.Forms.TextBox();
            this.buttonregister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1262, 587);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в приложение былеты UA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(1238, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonlogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonlogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonlogin.Location = new System.Drawing.Point(200, 335);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(188, 40);
            this.buttonlogin.TabIndex = 2;
            this.buttonlogin.Text = "Продолжить";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // logtextBox1
            // 
            this.logtextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logtextBox1.Location = new System.Drawing.Point(200, 94);
            this.logtextBox1.Name = "logtextBox1";
            this.logtextBox1.Size = new System.Drawing.Size(188, 20);
            this.logtextBox1.TabIndex = 3;
            // 
            // passtextBox1
            // 
            this.passtextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passtextBox1.Location = new System.Drawing.Point(200, 192);
            this.passtextBox1.Name = "passtextBox1";
            this.passtextBox1.Size = new System.Drawing.Size(188, 20);
            this.passtextBox1.TabIndex = 4;
            // 
            // logtextBox2
            // 
            this.logtextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logtextBox2.Location = new System.Drawing.Point(915, 94);
            this.logtextBox2.Name = "logtextBox2";
            this.logtextBox2.Size = new System.Drawing.Size(188, 20);
            this.logtextBox2.TabIndex = 5;
            // 
            // passtextBox2
            // 
            this.passtextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passtextBox2.Location = new System.Drawing.Point(915, 192);
            this.passtextBox2.Name = "passtextBox2";
            this.passtextBox2.Size = new System.Drawing.Size(188, 20);
            this.passtextBox2.TabIndex = 6;
            // 
            // buttonregister
            // 
            this.buttonregister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonregister.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonregister.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonregister.Location = new System.Drawing.Point(915, 335);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(188, 40);
            this.buttonregister.TabIndex = 8;
            this.buttonregister.Text = "Зарегестрироваться";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите пароль";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(920, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите логин для регистрации";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите пароль для регистрации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.passtextBox2);
            this.Controls.Add(this.logtextBox2);
            this.Controls.Add(this.passtextBox1);
            this.Controls.Add(this.logtextBox1);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox logtextBox1;
        private System.Windows.Forms.TextBox passtextBox1;
        private System.Windows.Forms.TextBox logtextBox2;
        private System.Windows.Forms.TextBox passtextBox2;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

