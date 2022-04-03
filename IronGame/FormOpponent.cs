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
    public partial class FormOpponent : Form
    {
        public string gamer1 = "";
        public string gamer2 = "";
        List<string>opponents=new List<string>();
        public FormOpponent()
        {
            InitializeComponent();
        }
        static List<string> CreateOpponents(StreamReader file,string a)
        {
            List<string> list = new List<string>();
            while(!file.EndOfStream)
            {
                string line = file.ReadLine();
                if(a!=line) list.Add(line);
            }
            return list;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            gamer2=textBoxOpponent.Text;
            if (textBoxOpponent.Text != String.Empty)
            {
                if (antirepeat(opponents, gamer2) != false || Convert.ToString(comboBoxOtherGamers.SelectedItem) == gamer2)
                {
                    MessageBox.Show("Весёлой игры "+gamer1+" и "+gamer2+". Пусть победит сильнейший!");
                    if (antirepeat(opponents, gamer2) == true) opponents.Add(gamer2);
                    opponents.Add(gamer1);
                    StreamWriter file1 = new StreamWriter("profiles.txt");
                    for (int i = 0; i < opponents.Count; i++)
                    {
                        file1.WriteLine(opponents[i]);
                    }
                    file1.Close();
                    StreamWriter filename = new StreamWriter(gamer2);
                }
                else
                {
                    MessageBox.Show("К сожалению, пользователь " + gamer2 + " уже существует. Придумайте новое имя или выберите своё из списка!");
                    textBoxOpponent.Text = String.Empty;
                    buttonStart.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ввод имени обязателен для игры");
                buttonStart.Enabled = false;
            }
        }

        private void FormOpponent_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("profiles.txt");
            opponents = CreateOpponents(file, gamer1);
            file.Close();
            fillCombobox(comboBoxOtherGamers, opponents);
        }
        void fillCombobox(ComboBox combo, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                combo.Items.Add(list[i]);
            }
        }
        static bool antirepeat(List<string> list, string a)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (a == list[i])
                    return false;
            }
            return true;
        }

        private void comboBoxOtherGamers_SelectedIndexChanged(object sender, EventArgs e)
        {
            gamer2 = comboBoxOtherGamers.SelectedItem.ToString();
            textBoxOpponent.Text = gamer2;
        }

        private void textBoxOpponent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOpponent.Text != String.Empty)
                buttonStart.Enabled = true;
        }
    }
}
