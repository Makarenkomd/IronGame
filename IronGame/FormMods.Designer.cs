namespace IronGame
{
    partial class FormMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMods));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGraphics = new System.Windows.Forms.Button();
            this.buttonThemes = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonChangeProfile = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGraphics
            // 
            this.buttonGraphics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphics.Location = new System.Drawing.Point(172, 0);
            this.buttonGraphics.Name = "buttonGraphics";
            this.buttonGraphics.Size = new System.Drawing.Size(282, 85);
            this.buttonGraphics.TabIndex = 4;
            this.buttonGraphics.Text = "Игровое поле";
            this.buttonGraphics.UseVisualStyleBackColor = false;
            this.buttonGraphics.Click += new System.EventHandler(this.buttonGraphics_Click);
            // 
            // buttonThemes
            // 
            this.buttonThemes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThemes.Location = new System.Drawing.Point(460, 0);
            this.buttonThemes.Name = "buttonThemes";
            this.buttonThemes.Size = new System.Drawing.Size(282, 85);
            this.buttonThemes.TabIndex = 5;
            this.buttonThemes.Text = "Тематика*";
            this.buttonThemes.UseVisualStyleBackColor = false;
            this.buttonThemes.Click += new System.EventHandler(this.buttonThemes_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSwitch.Location = new System.Drawing.Point(0, 196);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(115, 74);
            this.buttonSwitch.TabIndex = 6;
            this.buttonSwitch.Text = "<<<";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonChangeProfile
            // 
            this.buttonChangeProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeProfile.Location = new System.Drawing.Point(172, 91);
            this.buttonChangeProfile.Name = "buttonChangeProfile";
            this.buttonChangeProfile.Size = new System.Drawing.Size(282, 85);
            this.buttonChangeProfile.TabIndex = 7;
            this.buttonChangeProfile.Text = "Сменить  профиль";
            this.buttonChangeProfile.UseVisualStyleBackColor = false;
            this.buttonChangeProfile.Click += new System.EventHandler(this.buttonChangeProfile_Click);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProfile.Location = new System.Drawing.Point(460, 91);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(282, 85);
            this.buttonDeleteProfile.TabIndex = 8;
            this.buttonDeleteProfile.Text = "Удалить текущий профиль";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Выбор наборов слов для режима \"Тренажёр\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteProfile);
            this.Controls.Add(this.buttonChangeProfile);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.buttonThemes);
            this.Controls.Add(this.buttonGraphics);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMods";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGraphics;
        private System.Windows.Forms.Button buttonThemes;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonChangeProfile;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Label label1;
    }
}