namespace IronGame
{
    partial class FormDeleteProfile
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
            this.buttonNotDelete = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы точно хотите удалить профиль? Весь ваш прогресс будет потерян.";
            // 
            // buttonNotDelete
            // 
            this.buttonNotDelete.BackColor = System.Drawing.Color.Lime;
            this.buttonNotDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNotDelete.Location = new System.Drawing.Point(6, 181);
            this.buttonNotDelete.Name = "buttonNotDelete";
            this.buttonNotDelete.Size = new System.Drawing.Size(165, 96);
            this.buttonNotDelete.TabIndex = 1;
            this.buttonNotDelete.Text = "Отмена";
            this.buttonNotDelete.UseVisualStyleBackColor = false;
            this.buttonNotDelete.Click += new System.EventHandler(this.buttonNotDelete_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(249, 181);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 96);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Да";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDeleteProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(426, 272);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNotDelete);
            this.Controls.Add(this.label1);
            this.Name = "FormDeleteProfile";
            this.Text = "FormDeleteProfile";
            this.Load += new System.EventHandler(this.FormDeleteProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNotDelete;
        private System.Windows.Forms.Button buttonDelete;
    }
}