using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronGame2v
{
    public partial class FormMods : Form
    {
        public FormMods()
        {
            InitializeComponent();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            FormMenu form=new FormMenu();
            form.Show();
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            FormSetOfGame game=new FormSetOfGame();
            game.Show();
        }
    }
}
