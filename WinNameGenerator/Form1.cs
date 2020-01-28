using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace WinNameGenerator {
    public partial class Form1 : Form {

        string[] all;
        Random rand;
        string currentName;
        string previousName;
        string nextName;
        SpeechSynthesizer synth;

        public Form1() {
            rand = new Random();
            InitializeComponent();
            all = new string[] { "a", "o", "ar", "ky", "je", "ba", "bri", "val", "vi", "de", "cor", "em", "av", "dor", "ven", "dar", "sil",
            "el", "rin",  "ne", "ri", "or",  "a", "ra", "yn", 
            "ry", "sha", "is", "ma", "ette","lyn",
            "etta", "ella", "ica", "essa", "ina", "cia", "anna", "ia" };
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            nextName = Generate();
        }

        private string Generate() {
            string tempName;
            do {

                int parts = rand.Next(2, 4);
                int one = rand.Next(0, 17);
                int two = rand.Next(17, 25);
                int three = rand.Next(25, all.Length);
                if (parts == 2) {
                    tempName = all[one] + all[three];

                } else {
                    tempName = all[one] + all[two] + all[three];
                }

                tempName = char.ToUpper(tempName[0]) + tempName.Substring(1);
            }
            while (tempName.ToLower().Contains("aa")
                  || tempName.ToLower().Contains("ii") || tempName.ToLower().Contains("ee")
                  || tempName.ToLower().Contains("oo") || tempName.ToLower().Contains("uu"));
            return tempName;
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            infoLabel.Text = "";
            previousName = currentName;
            currentName = nextName;
            nameLabel.Text = currentName;
            synth.Speak(currentName);
            nextName = Generate();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            infoLabel.Text = "";
            if (nameListBox.Items.Count > 0) {
                string saveList = "";
                foreach (var item in nameListBox.Items) {
                    saveList += item.ToString() + "\n";
                }
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(
                    Environment.SpecialFolder.DesktopDirectory) + @"\NameList.txt", true);
                sw.Write(saveList);
                sw.Flush();
                sw.Close();
                infoLabel.Text = "List succesfully saved to desktop.";
            } else {
                infoLabel.Text = "There are no names to save!";
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            infoLabel.Text = "";
            if (currentName != null) {
                if (!nameListBox.Items.Contains(nameLabel.Text)) {
                    nameListBox.Items.Add(nameLabel.Text);
                } else {
                    infoLabel.Text = "The name has already been added to the list!";
                }
            } else {
                infoLabel.Text = "No name has been generated yet!";
            }
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e) {
            infoLabel.Text = "";
            nameLabel.Text = nameListBox.SelectedItem.ToString();
            synth.Speak(nameListBox.SelectedItem.ToString());
        }

        private void backUpButton_Click(object sender, EventArgs e) {
            infoLabel.Text = "";
            if (previousName != null) {
                nameLabel.Text = previousName;
                synth.Speak(previousName);
            } else {
                if (currentName == null) {
                    infoLabel.Text = "No name has been generated yet!";
                } else {
                    infoLabel.Text = "At least two names must have been generated!";
                }
            }
        }

        private void clearListButton_Click(object sender, EventArgs e) {
            nameListBox.Items.Clear();
        }
    }
}