namespace Kyrs
{
    partial class Form3
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Pers = new System.Windows.Forms.Button();
            this.Rasp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numer = new System.Windows.Forms.TextBox();
            this.buy = new System.Windows.Forms.Button();
            this.PunktB = new System.Windows.Forms.TextBox();
            this.PunktA = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.surename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rasp)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1168, 537);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 41);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Вернуться к расписанию";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(1227, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 25);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Pers
            // 
            this.Pers.Location = new System.Drawing.Point(12, 12);
            this.Pers.Name = "Pers";
            this.Pers.Size = new System.Drawing.Size(77, 40);
            this.Pers.TabIndex = 12;
            this.Pers.Text = "Личный кабинет";
            this.Pers.UseVisualStyleBackColor = true;
            this.Pers.Click += new System.EventHandler(this.Pers_Click);
            // 
            // Rasp
            // 
            this.Rasp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rasp.Location = new System.Drawing.Point(214, 263);
            this.Rasp.Name = "Rasp";
            this.Rasp.Size = new System.Drawing.Size(845, 266);
            this.Rasp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(803, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите номер рейса на который хотите купить билет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numer
            // 
            this.numer.Location = new System.Drawing.Point(797, 173);
            this.numer.Name = "numer";
            this.numer.Size = new System.Drawing.Size(147, 20);
            this.numer.TabIndex = 15;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(965, 210);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(114, 23);
            this.buy.TabIndex = 16;
            this.buy.Text = "Купить";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // PunktB
            // 
            this.PunktB.Location = new System.Drawing.Point(452, 173);
            this.PunktB.Name = "PunktB";
            this.PunktB.Size = new System.Drawing.Size(172, 20);
            this.PunktB.TabIndex = 19;
            // 
            // PunktA
            // 
            this.PunktA.Location = new System.Drawing.Point(214, 173);
            this.PunktA.Name = "PunktA";
            this.PunktA.Size = new System.Drawing.Size(167, 20);
            this.PunktA.TabIndex = 18;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(378, 210);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 17;
            this.searchbutton.Text = "Поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите в эти поля место посадки, и место прибытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "что-бы узнать номер рейса";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(950, 173);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 20);
            this.name.TabIndex = 22;
            // 
            // surename
            // 
            this.surename.Location = new System.Drawing.Point(1103, 173);
            this.surename.Name = "surename";
            this.surename.Size = new System.Drawing.Size(147, 20);
            this.surename.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(921, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "а также имя и фамилию";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PunktB);
            this.Controls.Add(this.PunktA);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.numer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rasp);
            this.Controls.Add(this.Pers);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackButton);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Rasp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button Pers;
        private System.Windows.Forms.DataGridView Rasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numer;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.TextBox PunktB;
        private System.Windows.Forms.TextBox PunktA;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surename;
        private System.Windows.Forms.Label label4;
    }
}