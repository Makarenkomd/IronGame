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
    public partial class FormDifficulties : Form
    {
        public string d = " ";
        public FormDifficulties()
        {
            InitializeComponent();
        }

        private void buttonGraphicsMods_Click(object sender, EventArgs e)
        {
            StreamWriter file=new StreamWriter("levelOfDifficulty.txt");
            file.WriteLine(d);
            file.Close();
            FormMods form=new FormMods();
            form.Show();
            
        }


        private void radioButtonEasyLevel_CheckedChanged(object sender, EventArgs e)
        {
            d = "Лёгкий";
        }

        private void radioButtonMedLevel_CheckedChanged(object sender, EventArgs e)
        {
            d = "Средний";
        }

        private void radioButtonHardLevel_CheckedChanged(object sender, EventArgs e)
        {
            d = "Сложный";
        }
    }
}
