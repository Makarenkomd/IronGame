namespace IronGame
{
    partial class FormOpponent
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOtherGamers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOpponent = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите своё имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOtherGamers
            // 
            this.comboBoxOtherGamers.FormattingEnabled = true;
            this.comboBoxOtherGamers.Location = new System.Drawing.Point(30, 95);
            this.comboBoxOtherGamers.Name = "comboBoxOtherGamers";
            this.comboBoxOtherGamers.Size = new System.Drawing.Size(144, 21);
            this.comboBoxOtherGamers.TabIndex = 3;
            this.comboBoxOtherGamers.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtherGamers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Или авторизуйтесь здесь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOpponent
            // 
            this.textBoxOpponent.Location = new System.Drawing.Point(30, 192);
            this.textBoxOpponent.Name = "textBoxOpponent";
            this.textBoxOpponent.Size = new System.Drawing.Size(144, 20);
            this.textBoxOpponent.TabIndex = 5;
            this.textBoxOpponent.TextChanged += new System.EventHandler(this.textBoxOpponent_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(12, 238);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(200, 71);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Начинаем соревнование!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormOpponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(224, 321);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxOpponent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOtherGamers);
            this.Controls.Add(this.label1);
            this.Name = "FormOpponent";
            this.Text = "Ваш соперник";
            this.Load += new System.EventHandler(this.FormOpponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOtherGamers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOpponent;
        private System.Windows.Forms.Button buttonStart;
    }
}