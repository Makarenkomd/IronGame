namespace IronGame
{
    partial class FormDifficulties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDifficulties));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonEasyLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonHardLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonMedLevel = new System.Windows.Forms.RadioButton();
            this.buttonGraphicsMods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выбери уровень сложности";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonEasyLevel
            // 
            this.radioButtonEasyLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonEasyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEasyLevel.Location = new System.Drawing.Point(162, 118);
            this.radioButtonEasyLevel.Name = "radioButtonEasyLevel";
            this.radioButtonEasyLevel.Size = new System.Drawing.Size(310, 47);
            this.radioButtonEasyLevel.TabIndex = 10;
            this.radioButtonEasyLevel.TabStop = true;
            this.radioButtonEasyLevel.Text = "Лёгкий";
            this.radioButtonEasyLevel.UseVisualStyleBackColor = false;
            this.radioButtonEasyLevel.CheckedChanged += new System.EventHandler(this.radioButtonEasyLevel_CheckedChanged);
            // 
            // radioButtonHardLevel
            // 
            this.radioButtonHardLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonHardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHardLevel.Location = new System.Drawing.Point(162, 259);
            this.radioButtonHardLevel.Name = "radioButtonHardLevel";
            this.radioButtonHardLevel.Size = new System.Drawing.Size(310, 47);
            this.radioButtonHardLevel.TabIndex = 11;
            this.radioButtonHardLevel.TabStop = true;
            this.radioButtonHardLevel.Text = "Сложный";
            this.radioButtonHardLevel.UseVisualStyleBackColor = false;
            this.radioButtonHardLevel.CheckedChanged += new System.EventHandler(this.radioButtonHardLevel_CheckedChanged);
            // 
            // radioButtonMedLevel
            // 
            this.radioButtonMedLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonMedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMedLevel.Location = new System.Drawing.Point(162, 188);
            this.radioButtonMedLevel.Name = "radioButtonMedLevel";
            this.radioButtonMedLevel.Size = new System.Drawing.Size(310, 47);
            this.radioButtonMedLevel.TabIndex = 12;
            this.radioButtonMedLevel.TabStop = true;
            this.radioButtonMedLevel.Text = "Средний";
            this.radioButtonMedLevel.UseVisualStyleBackColor = false;
            this.radioButtonMedLevel.CheckedChanged += new System.EventHandler(this.radioButtonMedLevel_CheckedChanged);
            // 
            // buttonGraphicsMods
            // 
            this.buttonGraphicsMods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGraphicsMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphicsMods.Location = new System.Drawing.Point(212, 342);
            this.buttonGraphicsMods.Name = "buttonGraphicsMods";
            this.buttonGraphicsMods.Size = new System.Drawing.Size(274, 85);
            this.buttonGraphicsMods.TabIndex = 13;
            this.buttonGraphicsMods.Text = "Готово";
            this.buttonGraphicsMods.UseVisualStyleBackColor = false;
            this.buttonGraphicsMods.Click += new System.EventHandler(this.buttonGraphicsMods_Click);
            // 
            // FormDifficulties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGraphicsMods);
            this.Controls.Add(this.radioButtonMedLevel);
            this.Controls.Add(this.radioButtonHardLevel);
            this.Controls.Add(this.radioButtonEasyLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDifficulties";
            this.Text = "FormDifficulties";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonEasyLevel;
        private System.Windows.Forms.RadioButton radioButtonHardLevel;
        private System.Windows.Forms.RadioButton radioButtonMedLevel;
        private System.Windows.Forms.Button buttonGraphicsMods;
    }
}