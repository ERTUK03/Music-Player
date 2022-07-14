using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        string[] path, file;
        public Form1()
        {
            InitializeComponent();
        }

        private void Music_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[Music.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                file = ofd.SafeFileNames;
                path = ofd.FileNames;

                for(int i = 0;i< file.Length; i++)
                {
                    Music.Items.Add(file[i]);
                }
            }
        }
    }
}
