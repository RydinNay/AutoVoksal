namespace Kyrs
{
    partial class Form5
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
            this.rebuybutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showtiketbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbox = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1166, 534);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 41);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Вернуться к расписанию";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // rebuybutton
            // 
            this.rebuybutton.Location = new System.Drawing.Point(1166, 40);
            this.rebuybutton.Name = "rebuybutton";
            this.rebuybutton.Size = new System.Drawing.Size(84, 41);
            this.rebuybutton.TabIndex = 2;
            this.rebuybutton.Text = "Возврат билетов";
            this.rebuybutton.UseVisualStyleBackColor = true;
            this.rebuybutton.Click += new System.EventHandler(this.rebuybutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 420);
            this.dataGridView1.TabIndex = 3;
            // 
            // showtiketbutton
            // 
            this.showtiketbutton.Location = new System.Drawing.Point(65, 126);
            this.showtiketbutton.Name = "showtiketbutton";
            this.showtiketbutton.Size = new System.Drawing.Size(240, 23);
            this.showtiketbutton.TabIndex = 4;
            this.showtiketbutton.Text = "Показать мои билеты";
            this.showtiketbutton.UseVisualStyleBackColor = true;
            this.showtiketbutton.Click += new System.EventHandler(this.showtiketbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 71);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // loginbox
            // 
            this.loginbox.AutoSize = true;
            this.loginbox.Location = new System.Drawing.Point(85, 12);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(0, 13);
            this.loginbox.TabIndex = 6;
            this.loginbox.Click += new System.EventHandler(this.loginbox_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(1233, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 25);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1262, 587);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showtiketbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rebuybutton);
            this.Controls.Add(this.BackButton);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button rebuybutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showtiketbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label loginbox;
        private System.Windows.Forms.Label CloseButton;
    }
}