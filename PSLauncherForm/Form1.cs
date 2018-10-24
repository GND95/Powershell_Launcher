using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSLauncherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //adding all buttons to a list so I can interate over the list elements to change the button names dynamically
        {
            buttonList = new List<Button> { psBtn1, psBtn2, psBtn3, psBtn4, psBtn5, psBtn6, psBtn7, psBtn8, psBtn9, psBtn10, psBtn11, psBtn12, psBtn13, psBtn14, psBtn15, psBtn16, psBtn17, psBtn18, psBtn19, psBtn20, psBtn21, psBtn22, psBtn23, psBtn24, psBtn25, psBtn26, psBtn27, psBtn28, psBtn29, psBtn30, psBtn31, psBtn32, psBtn33, psBtn34, psBtn35, psBtn36, psBtn37, psBtn38, psBtn39, psBtn40 };
        }

        List<Button> buttonList;
        string[] files;

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //open menustrip button
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);

                    for (int i = 0; i < files.Length; i++) //dynamically naming all the buttons after the script names in the folder containing the powershell scripts
                    {
                        buttonList[i].Text = files[i].Split('\\').Last().Split('.').First();
                    }

                    if (files.Length > 0 && files.Length <= 20) //enabling the corresponding buttons based on the number of scripts in the folder
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            buttonList[i].Enabled = true;
                        }
                    }
                    else if (files.Length > 20 && files.Length <= 30)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            buttonList[i].Enabled = true;
                        }
                        this.Width = 425; //growing the form to accommodate more buttons
                    }
                    else if (files.Length > 30 && files.Length <= 40)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            buttonList[i].Enabled = true;
                        }
                        this.Width = 565; //growing the form to accommodate more buttons
                    }
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e) //info toolstrip button
        {
            MessageBox.Show("Use the Open button to select the folder that contains your Powershell scripts.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void executeScript(int scriptNumber) //where the powershell script file is read and executed
        {
                            // prior code -- Testing  StreamReader readFile = new StreamReader(files[scriptNumber]); //read the contents of the script file          
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = files[scriptNumber]; //this works great if you create a shortcut to the powershell script and in the shortcut use -powershell.exe -command then filepath of the original script. All of this will go in the "Target" field of the shortcut
            newProcessInfo.Verb = "runas"; //run the item as administrator
                           // prior code -- Testing    newProcessInfo.Arguments = @"powershell -noexit " + readFile.ReadToEnd(); //noexit switch keeps the powershell window from closing before you get to read the result

            System.Diagnostics.Process.Start(newProcessInfo); // execute powershell script 
        }

        private void psBtn1_Click(object sender, EventArgs e)
        {
            executeScript(0);
        }

        private void psBtn2_Click(object sender, EventArgs e)
        {
            executeScript(1);
        }

        private void psBtn3_Click(object sender, EventArgs e)
        {
            executeScript(2);
        }

        private void psBtn4_Click(object sender, EventArgs e)
        {
            executeScript(3);
        }

        private void psBtn5_Click(object sender, EventArgs e)
        {
            executeScript(4);
        }

        private void psBtn6_Click(object sender, EventArgs e)
        {
            executeScript(5);
        }

        private void psBtn7_Click(object sender, EventArgs e)
        {
            executeScript(6);
        }

        private void psBtn8_Click(object sender, EventArgs e)
        {
            executeScript(7);
        }

        private void psBtn9_Click(object sender, EventArgs e)
        {
            executeScript(8);
        }

        private void psBtn10_Click(object sender, EventArgs e)
        {
            executeScript(9);
        }

        private void psBtn11_Click(object sender, EventArgs e)
        {
            executeScript(10);
        }

        private void psBtn12_Click(object sender, EventArgs e)
        {
            executeScript(11);
        }

        private void psBtn13_Click(object sender, EventArgs e)
        {
            executeScript(12);
        }

        private void psBtn14_Click(object sender, EventArgs e)
        {
            executeScript(13);
        }

        private void psBtn15_Click(object sender, EventArgs e)
        {
            executeScript(14);
        }

        private void psBtn16_Click(object sender, EventArgs e)
        {
            executeScript(15);
        }

        private void psBtn17_Click(object sender, EventArgs e)
        {
            executeScript(16);
        }

        private void psBtn18_Click(object sender, EventArgs e)
        {
            executeScript(17);
        }

        private void psBtn19_Click(object sender, EventArgs e)
        {
            executeScript(18);
        }

        private void psBtn20_Click(object sender, EventArgs e)
        {
            executeScript(19);
        }

        private void psBtn21_Click(object sender, EventArgs e)
        {
            executeScript(20);
        }

        private void psBtn22_Click(object sender, EventArgs e)
        {
            executeScript(21);
        }

        private void psBtn23_Click(object sender, EventArgs e)
        {
            executeScript(22);
        }

        private void psBtn24_Click(object sender, EventArgs e)
        {
            executeScript(23);
        }

        private void psBtn25_Click(object sender, EventArgs e)
        {
            executeScript(24);
        }

        private void psBtn26_Click(object sender, EventArgs e)
        {
            executeScript(25);
        }

        private void psBtn27_Click(object sender, EventArgs e)
        {
            executeScript(26);
        }

        private void psBtn28_Click(object sender, EventArgs e)
        {
            executeScript(27);
        }

        private void psBtn29_Click(object sender, EventArgs e)
        {
            executeScript(28);
        }

        private void psBtn30_Click(object sender, EventArgs e)
        {
            executeScript(29);
        }

        private void psBtn31_Click(object sender, EventArgs e)
        {
            executeScript(30);
        }

        private void psBtn32_Click(object sender, EventArgs e)
        {
            executeScript(31);
        }

        private void psBtn33_Click(object sender, EventArgs e)
        {
            executeScript(32);
        }

        private void psBtn34_Click(object sender, EventArgs e)
        {
            executeScript(33);
        }

        private void psBtn35_Click(object sender, EventArgs e)
        {
            executeScript(34);
        }

        private void psBtn36_Click(object sender, EventArgs e)
        {
            executeScript(35);
        }

        private void psBtn37_Click(object sender, EventArgs e)
        {
            executeScript(36);
        }

        private void psBtn38_Click(object sender, EventArgs e)
        {
            executeScript(37);
        }

        private void psBtn39_Click(object sender, EventArgs e)
        {
            executeScript(38);
        }

        private void psBtn40_Click(object sender, EventArgs e)
        {
            executeScript(39);
        }
    }
}
