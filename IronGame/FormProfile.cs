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
    public partial class FormProfile : Form
    {
        public string name = " ";
        List<string> profiles = new List<string>();
        public FormProfile()
        {
            InitializeComponent();
            
        }

        static bool antirepeat(List<string>list,string a)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (a == list[i]) 
                    return false;
            }
            return true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            name = textBoxNames.Text;
            if(textBoxNames.Text!=String.Empty)
            {
                if (antirepeat(profiles, name) != false || Convert.ToString(comboBoxProfiles.SelectedItem) == name)
                {
                    MessageBox.Show("Привет, " + name + ". Приятной игры!");
                    FormMenu form = new FormMenu();
                    form.Show();
                    if (antirepeat(profiles, name) == true) profiles.Add(name);
                    StreamWriter file1 = new StreamWriter("profiles.txt");
                    WriteList(file1, profiles);
                    StreamWriter file = new StreamWriter("current.txt");
                    AddProfile(file, name);
                }
                else
                {
                    MessageBox.Show("К сожалению, пользователь " + name + " уже существует. Придумайте новое имя или выберите своё из списка!");
                    textBoxNames.Text = String.Empty;
                    buttonStart.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ввод имени обязателен для игры");
                buttonStart.Enabled = false;
            }
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("profiles.txt");
            InputList(file,profiles);
            fillCombobox(comboBoxProfiles, profiles);
            StreamWriter temp = new StreamWriter("current.txt");
            temp.Dispose();
            temp.Close();
        }

        private void comboBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBoxProfiles.SelectedItem.ToString();
            textBoxNames.Text = name;
        }

        private void textBoxNames_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNames.Text != String.Empty)
                buttonStart.Enabled = true;
        }
        void fillCombobox(ComboBox combo, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                combo.Items.Add(list[i]);
            }
        }
        void InputList(StreamReader file,List<string>list)
        {
            while (!file.EndOfStream)
            {
                list.Add(file.ReadLine());
            }
            file.Close();
        }
        void WriteList(StreamWriter file,List<string>list)
        {
            for (int i = 0; i < profiles.Count; i++)
            {
                file.WriteLine(profiles[i]);
            }
            file.Close();
        }
        void AddProfile(StreamWriter file,string a)
        {
            file.Write(a);
            file.Close();
            File.Create(a).Close();
        }
    }
}
