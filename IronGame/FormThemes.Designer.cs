namespace IronGame
{
    partial class FormThemes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGraphicsMods = new System.Windows.Forms.Button();
            this.radioButtonAnimals = new System.Windows.Forms.RadioButton();
            this.radioButtonFood = new System.Windows.Forms.RadioButton();
            this.radioButtonPlants = new System.Windows.Forms.RadioButton();
            this.radioButtonGeography = new System.Windows.Forms.RadioButton();
            this.radioButtonMath = new System.Windows.Forms.RadioButton();
            this.radioButtonBuildings = new System.Windows.Forms.RadioButton();
            this.radioButtonOssetia = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonCreateTheme = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGraphicsMods
            // 
            this.buttonGraphicsMods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGraphicsMods.Enabled = false;
            this.buttonGraphicsMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphicsMods.Location = new System.Drawing.Point(198, 367);
            this.buttonGraphicsMods.Name = "buttonGraphicsMods";
            this.buttonGraphicsMods.Size = new System.Drawing.Size(274, 85);
            this.buttonGraphicsMods.TabIndex = 7;
            this.buttonGraphicsMods.Text = "Выбрать тему";
            this.buttonGraphicsMods.UseVisualStyleBackColor = false;
            this.buttonGraphicsMods.Click += new System.EventHandler(this.buttonGraphicsMods_Click);
            // 
            // radioButtonAnimals
            // 
            this.radioButtonAnimals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAnimals.Location = new System.Drawing.Point(23, 130);
            this.radioButtonAnimals.Name = "radioButtonAnimals";
            this.radioButtonAnimals.Size = new System.Drawing.Size(223, 37);
            this.radioButtonAnimals.TabIndex = 8;
            this.radioButtonAnimals.TabStop = true;
            this.radioButtonAnimals.Text = "Животные";
            this.radioButtonAnimals.UseVisualStyleBackColor = false;
            this.radioButtonAnimals.Click += new System.EventHandler(this.radioButtonAnimals_Click);
            // 
            // radioButtonFood
            // 
            this.radioButtonFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFood.Location = new System.Drawing.Point(23, 42);
            this.radioButtonFood.Name = "radioButtonFood";
            this.radioButtonFood.Size = new System.Drawing.Size(223, 37);
            this.radioButtonFood.TabIndex = 9;
            this.radioButtonFood.TabStop = true;
            this.radioButtonFood.Text = "Съедобное";
            this.radioButtonFood.UseVisualStyleBackColor = false;
            this.radioButtonFood.Click += new System.EventHandler(this.radioButtonFood_Click);
            // 
            // radioButtonPlants
            // 
            this.radioButtonPlants.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonPlants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPlants.Location = new System.Drawing.Point(23, 216);
            this.radioButtonPlants.Name = "radioButtonPlants";
            this.radioButtonPlants.Size = new System.Drawing.Size(223, 37);
            this.radioButtonPlants.TabIndex = 10;
            this.radioButtonPlants.TabStop = true;
            this.radioButtonPlants.Text = "Растения";
            this.radioButtonPlants.UseVisualStyleBackColor = false;
            this.radioButtonPlants.Click += new System.EventHandler(this.radioButtonPlants_Click);
            // 
            // radioButtonGeography
            // 
            this.radioButtonGeography.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonGeography.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGeography.Location = new System.Drawing.Point(491, 42);
            this.radioButtonGeography.Name = "radioButtonGeography";
            this.radioButtonGeography.Size = new System.Drawing.Size(223, 37);
            this.radioButtonGeography.TabIndex = 11;
            this.radioButtonGeography.TabStop = true;
            this.radioButtonGeography.Text = "География";
            this.radioButtonGeography.UseVisualStyleBackColor = false;
            this.radioButtonGeography.Click += new System.EventHandler(this.radioButtonGeography_Click);
            // 
            // radioButtonMath
            // 
            this.radioButtonMath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMath.Location = new System.Drawing.Point(23, 296);
            this.radioButtonMath.Name = "radioButtonMath";
            this.radioButtonMath.Size = new System.Drawing.Size(223, 37);
            this.radioButtonMath.TabIndex = 12;
            this.radioButtonMath.Text = "Математика";
            this.radioButtonMath.UseVisualStyleBackColor = false;
            this.radioButtonMath.Click += new System.EventHandler(this.radioButtonMath_Click);
            // 
            // radioButtonBuildings
            // 
            this.radioButtonBuildings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBuildings.Location = new System.Drawing.Point(491, 130);
            this.radioButtonBuildings.Name = "radioButtonBuildings";
            this.radioButtonBuildings.Size = new System.Drawing.Size(223, 37);
            this.radioButtonBuildings.TabIndex = 13;
            this.radioButtonBuildings.TabStop = true;
            this.radioButtonBuildings.Text = "Прочее";
            this.radioButtonBuildings.UseVisualStyleBackColor = false;
            this.radioButtonBuildings.Click += new System.EventHandler(this.radioButtonBuildings_Click);
            // 
            // radioButtonOssetia
            // 
            this.radioButtonOssetia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonOssetia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOssetia.Location = new System.Drawing.Point(491, 216);
            this.radioButtonOssetia.Name = "radioButtonOssetia";
            this.radioButtonOssetia.Size = new System.Drawing.Size(223, 37);
            this.radioButtonOssetia.TabIndex = 14;
            this.radioButtonOssetia.TabStop = true;
            this.radioButtonOssetia.Text = "Моя Осетия";
            this.radioButtonOssetia.UseVisualStyleBackColor = false;
            this.radioButtonOssetia.Click += new System.EventHandler(this.radioButtonOssetia_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAll.Location = new System.Drawing.Point(491, 296);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(223, 37);
            this.radioButtonAll.TabIndex = 15;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все темы";
            this.radioButtonAll.UseVisualStyleBackColor = false;
            this.radioButtonAll.Click += new System.EventHandler(this.radioButtonAll_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSwitch.Location = new System.Drawing.Point(0, 376);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(96, 74);
            this.buttonSwitch.TabIndex = 16;
            this.buttonSwitch.Text = "<<<";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonCreateTheme
            // 
            this.buttonCreateTheme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreateTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTheme.Location = new System.Drawing.Point(488, 367);
            this.buttonCreateTheme.Name = "buttonCreateTheme";
            this.buttonCreateTheme.Size = new System.Drawing.Size(312, 85);
            this.buttonCreateTheme.TabIndex = 17;
            this.buttonCreateTheme.Text = "Создать свою тему!";
            this.buttonCreateTheme.UseVisualStyleBackColor = false;
            // 
            // FormThemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateTheme);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonOssetia);
            this.Controls.Add(this.radioButtonBuildings);
            this.Controls.Add(this.radioButtonMath);
            this.Controls.Add(this.radioButtonGeography);
            this.Controls.Add(this.radioButtonPlants);
            this.Controls.Add(this.radioButtonFood);
            this.Controls.Add(this.radioButtonAnimals);
            this.Controls.Add(this.buttonGraphicsMods);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormThemes";
            this.Text = "FormThemes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGraphicsMods;
        private System.Windows.Forms.RadioButton radioButtonAnimals;
        private System.Windows.Forms.RadioButton radioButtonFood;
        private System.Windows.Forms.RadioButton radioButtonPlants;
        private System.Windows.Forms.RadioButton radioButtonGeography;
        private System.Windows.Forms.RadioButton radioButtonMath;
        private System.Windows.Forms.RadioButton radioButtonBuildings;
        private System.Windows.Forms.RadioButton radioButtonOssetia;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonCreateTheme;
    }
}