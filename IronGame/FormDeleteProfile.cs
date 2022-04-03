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
    public partial class FormDeleteProfile : Form
    {
        List<string>users=new List<string>();
        public string deleter = string.Empty;
        public FormDeleteProfile()
        {
            InitializeComponent();
        }

        private void buttonNotDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("profiles.txt");
            while(!file.EndOfStream)
            {
                users.Add(file.ReadLine());
            }
            file.Close();
            StreamWriter file1 = new StreamWriter("profiles.txt");
            for (int i = 0; i < users.Count; i++)
            {
                if(users[i]!=deleter)
                {
                    file1.WriteLine(users[i]);
                }
            }
            file1.Close();
            File.Delete(deleter);
            FormProfile form = new FormProfile();
            form.Show();
        }

        private void FormDeleteProfile_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("current.txt");
            deleter = file.ReadLine();
            file.Close();
        }
    }
}
