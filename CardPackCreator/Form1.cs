using CardPackCreator.src.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPackCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.Columns.Add("Title");
            listView.Columns.Add("Set");
            listView.Columns.Add("Description");
            listView.Columns.Add("Faction");
            listView.Columns.Add("Rarity");
            listView.Columns.Add("Value");
            listView.GridLines = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text))
            {
                UpdateLog("Cannot add card: Missing title");
            }
            else if (string.IsNullOrWhiteSpace(setBox.Text))
            {
                UpdateLog("Cannot add card: Missing set");
            }
            else if (string.IsNullOrWhiteSpace(descBox.Text))
            {
                UpdateLog("Cannot add card: Missing description");
            }
            else if (string.IsNullOrWhiteSpace(facBox.Text))
            {
                UpdateLog("Cannot add card: Missing faction");
            }
            else if (string.IsNullOrWhiteSpace(rareBox.Text))
            {
                UpdateLog("Cannot add card: Missing rarity");
            }
            else if (string.IsNullOrWhiteSpace(valBox.Text))
            {
                UpdateLog("Cannot add card: Missing value");
            }
            else
            {
                if (int.TryParse(valBox.Text, out int result))
                {
                    var c = new Card(titleBox.Text, setBox.Text, descBox.Text, facBox.Text, rareBox.Text, result);

                    var item = new ListViewItem(c.ArrayString());
                    item.Tag = c;
                    listView.Items.Add(item);
                }
                else
                {
                    UpdateLog("Error: Cannot convert the text for 'Value:' to an integer. Please enter an integer.");
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Selected)
                {
                    listView.Items.Remove(item);
                }
            }
        }

        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog brwsr = new FolderBrowserDialog();

            if (brwsr.ShowDialog() == DialogResult.Cancel)
                UpdateLog("Warning: Dialog closed, files not saved!");
            else
            {
                WriteFile(brwsr.SelectedPath);
            }
        }

        private void toolStripMenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json files (*.json)|*.json";

            if (open.ShowDialog() == DialogResult.OK)
            {
                ReadFile(open.FileName);
            }
            else
            {
                UpdateLog("Warning: Dialog closed, unable to load files!");
            }
        }

        public void ReadFile(String path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Card> card_list = (List<Card>)serializer.Deserialize(file, typeof(List<Card>));
                listView.Items.Clear();

                foreach (Card card in card_list)
                {
                    var item = new ListViewItem(card.ArrayString());
                    item.Tag = card;
                    listView.Items.Add(item);
                }

                UpdateLog("Successfully loaded data!");
            }
        }

        public void WriteFile(String path)
        {
            List<Card> card_list = new List<Card>();

            foreach (ListViewItem item in listView.Items)
            {
                card_list.Add((Card)item.Tag);
            }

            using (StreamWriter file = File.CreateText(path + "\\" + setBox.Text + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, card_list);
                UpdateLog("Successfully saved file to: " + path + "\\" + setBox.Text + ".json");
            }
        }

        public void UpdateLog(String message)
        {
            logBox.Text = message;
        }
    }
}
