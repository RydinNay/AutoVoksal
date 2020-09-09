namespace Kyrs
{
    partial class Form4
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
            this.rebuybuttonchek = new System.Windows.Forms.Button();
            this.rebuybutton = new System.Windows.Forms.Button();
            this.numerbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1166, 534);
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
            // rebuybuttonchek
            // 
            this.rebuybuttonchek.Location = new System.Drawing.Point(206, 91);
            this.rebuybuttonchek.Name = "rebuybuttonchek";
            this.rebuybuttonchek.Size = new System.Drawing.Size(75, 23);
            this.rebuybuttonchek.TabIndex = 13;
            this.rebuybuttonchek.Text = "Выбрать былет для возврата";
            this.rebuybuttonchek.UseVisualStyleBackColor = true;
            this.rebuybuttonchek.Click += new System.EventHandler(this.rebuybuttonchek_Click);
            // 
            // rebuybutton
            // 
            this.rebuybutton.Location = new System.Drawing.Point(182, 297);
            this.rebuybutton.Name = "rebuybutton";
            this.rebuybutton.Size = new System.Drawing.Size(99, 23);
            this.rebuybutton.TabIndex = 14;
            this.rebuybutton.Text = "Вернуть билет";
            this.rebuybutton.UseVisualStyleBackColor = true;
            this.rebuybutton.Click += new System.EventHandler(this.rebuybutton_Click);
            // 
            // numerbox
            // 
            this.numerbox.Location = new System.Drawing.Point(182, 326);
            this.numerbox.Name = "numerbox";
            this.numerbox.Size = new System.Drawing.Size(99, 20);
            this.numerbox.TabIndex = 15;
            this.numerbox.TextChanged += new System.EventHandler(this.numerbox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите номер выбранного вами билета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберете билет из тех которые вы купили";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numerbox);
            this.Controls.Add(this.rebuybutton);
            this.Controls.Add(this.rebuybuttonchek);
            this.Controls.Add(this.Pers);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackButton);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button Pers;
        private System.Windows.Forms.Button rebuybuttonchek;
        private System.Windows.Forms.Button rebuybutton;
        private System.Windows.Forms.TextBox numerbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}