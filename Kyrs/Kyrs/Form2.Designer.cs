namespace Kyrs
{
    partial class Form2
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
            this.Rasp = new System.Windows.Forms.DataGridView();
            this.buybutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.PunktA = new System.Windows.Forms.TextBox();
            this.viewbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PunktB = new System.Windows.Forms.TextBox();
            this.rebuybutton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Pers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rasp)).BeginInit();
            this.SuspendLayout();
            // 
            // Rasp
            // 
            this.Rasp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rasp.Location = new System.Drawing.Point(214, 263);
            this.Rasp.Name = "Rasp";
            this.Rasp.Size = new System.Drawing.Size(845, 266);
            this.Rasp.TabIndex = 0;
            // 
            // buybutton
            // 
            this.buybutton.Location = new System.Drawing.Point(1146, 30);
            this.buybutton.Name = "buybutton";
            this.buybutton.Size = new System.Drawing.Size(75, 37);
            this.buybutton.TabIndex = 1;
            this.buybutton.Text = "Купить билет";
            this.buybutton.UseVisualStyleBackColor = true;
            this.buybutton.Click += new System.EventHandler(this.buybutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(584, 96);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // PunktA
            // 
            this.PunktA.Location = new System.Drawing.Point(416, 70);
            this.PunktA.Name = "PunktA";
            this.PunktA.Size = new System.Drawing.Size(167, 20);
            this.PunktA.TabIndex = 3;
            this.PunktA.TextChanged += new System.EventHandler(this.PunktA_TextChanged);
            // 
            // viewbutton
            // 
            this.viewbutton.Location = new System.Drawing.Point(214, 88);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(75, 39);
            this.viewbutton.TabIndex = 4;
            this.viewbutton.Text = "Вывести расписание";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(755, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск рейсов по пункту отбытия и прибытия, отсортированых по времени";
            // 
            // PunktB
            // 
            this.PunktB.Location = new System.Drawing.Point(661, 70);
            this.PunktB.Name = "PunktB";
            this.PunktB.Size = new System.Drawing.Size(172, 20);
            this.PunktB.TabIndex = 8;
            // 
            // rebuybutton
            // 
            this.rebuybutton.Location = new System.Drawing.Point(1146, 263);
            this.rebuybutton.Name = "rebuybutton";
            this.rebuybutton.Size = new System.Drawing.Size(75, 37);
            this.rebuybutton.TabIndex = 9;
            this.rebuybutton.Text = "Возврат билетов";
            this.rebuybutton.UseVisualStyleBackColor = true;
            this.rebuybutton.Click += new System.EventHandler(this.rebuybutton_Click);
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
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Pers
            // 
            this.Pers.Location = new System.Drawing.Point(12, 9);
            this.Pers.Name = "Pers";
            this.Pers.Size = new System.Drawing.Size(77, 40);
            this.Pers.TabIndex = 11;
            this.Pers.Text = "Личный кабинет";
            this.Pers.UseVisualStyleBackColor = true;
            this.Pers.Click += new System.EventHandler(this.Pers_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 587);
            this.Controls.Add(this.Pers);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.rebuybutton);
            this.Controls.Add(this.PunktB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.PunktA);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.buybutton);
            this.Controls.Add(this.Rasp);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Rasp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Rasp;
        private System.Windows.Forms.Button buybutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox PunktA;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PunktB;
        private System.Windows.Forms.Button rebuybutton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button Pers;
    }
}