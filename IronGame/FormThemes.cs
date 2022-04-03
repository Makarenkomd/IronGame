using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IronGame
{
    public partial class FormThemes : Form
    {
        public string s = " ";
        public FormThemes()
        {
            InitializeComponent();
        }
        private void buttonGraphicsMods_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("themes.txt");
            file.Dispose();
            file = new StreamWriter("themes.txt");
            file.WriteLine(s);
            file.Close();
            FormDifficulties form = new FormDifficulties();
            form.Show();
        }
        

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            FormMods form=new FormMods();
            form.Show();
        }

        private void radioButtonFood_Click(object sender, EventArgs e)
        {
            s = "Еда";
            buttonGraphicsMods.Enabled = true;
            
        }

        private void radioButtonAnimals_Click(object sender, EventArgs e)
        {
            s = "Животные";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonPlants_Click(object sender, EventArgs e)
        {
            s = "Растения";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonMath_Click(object sender, EventArgs e)
        {
            s = "Математика";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonGeography_Click(object sender, EventArgs e)
        {
            s = "География";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonBuildings_Click(object sender, EventArgs e)
        {
            s = "Сооружения";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonOssetia_Click(object sender, EventArgs e)
        {
            s = "Моя Осетия";
            buttonGraphicsMods.Enabled = true;
        }

        private void radioButtonAll_Click(object sender, EventArgs e)
        {
            s = "Все темы";
            buttonGraphicsMods.Enabled = true;
        }

    }
}
