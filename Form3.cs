using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Encoder
{
    public partial class Form3 : Form
    {string filename;
    Boolean edit = false;
    int selected = -1;
        List<char> charlist = new List<char>();
        List<string> enclist = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }
         void encodingfilereader(string path)
        {
            int lines = 0;
            string[] st = File.ReadAllLines(path);
            foreach (string s in st)
            {
                if (s.StartsWith("\n"))
                {
                    listBox1.Items.Add("\n");
                }
                
                listBox1.Items.Add(s.ElementAt(0).ToString());
                lines += 1;
            }
        }
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {if (filename != "")
            {
                File.Delete(filename);
                int x = 0;
                foreach (ListViewItem item in listBox1.Items)
                {
                   
                    File.AppendAllText(filename, item.Text + "->" + listBox1.Items[x].SubItems[0].Text + Environment.NewLine);
                    x += 1;
                }

            }
            else
            {
                MessageBox.Show("No open file to save");
            }
        
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {if (filename != "")
            {
            if (nradiobut.Checked)
            {
                savefile.Filter = "Encoded files |*.encoding|All files|*.*";
            }
            else
            {
                savefile.Filter = "Encoded files |*.encodingb|All files|*.*";
            }
            savefile.ShowDialog();
            int x = 0;
            foreach(ListViewItem item in listBox1.Items)
            {   
       
                File.AppendAllText(savefile.FileName,item.Text + "->" + listBox1.Items[x].SubItems[0].Text + Environment.NewLine);
                x += 1;
            }
            }
        else
        {
            MessageBox.Show("No open file to save");
        }
        
        }

        private void openEncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {openfile.ShowDialog();
            string path = openfile.FileName;
            filename = path;
            int lines = 0;
            string[] st = File.ReadAllLines(path);
             if (filename != "")
            {
            foreach (string s in File.ReadAllLines(path))
            {
                ListViewItem lv = new ListViewItem();
                ListViewItem lv2 = new ListViewItem();
                lv.Text = s.ElementAt(0).ToString();
                charlist.Add(s.ElementAt(0));
                enclist.Add(s.Remove(0, s.IndexOf("->") + 2));
                listBox1.Items.Add(lv);
                listBox1.Items[listBox1.Items.IndexOf(lv)].SubItems.Add(lv2.Text = s.Remove(0, s.IndexOf("->") + 2));
                lines += 1;
                
            }


            if (path.EndsWith(".encodinb"))
            {
                
            }
            }
             else
             {
                 MessageBox.Show("No open file to save");
             }
        
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {chrtextbox.Text = listBox1.SelectedItems[0].Text;
            idtextbox.Text = listBox1.SelectedItems[0].SubItems[0].Text;
            selected = listBox1.SelectedIndices[0];

            }
            catch (Exception)
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {ListViewItem lv = new ListViewItem();
            lv.Text = "{new}";
            lv.SubItems.Add("{new}");
            listBox1.Items.Add(lv);
            listBox1.Items[listBox1.Items.IndexOf(lv)].Selected = true;
            selected += 1;
            idtextbox.Text = "";
            chrtextbox.Text = "";
            chrtextbox.Focus();
            edit = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem();
            lv.Text = chrtextbox.Text;
            lv.SubItems.Add(idtextbox.Text);
            listBox1.Items.RemoveAt(selected);
            listBox1.Items.Insert(selected, lv);
            
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chrtextbox.Text != "" & chrtextbox.Text != "{new}" & idtextbox.Text != "" & idtextbox.Text != "{new}")
                {
                    editbut.PerformClick();
                    if (edit == true)
                    {
                        newchbut.PerformClick();
                        
                    }
                    
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (chrtextbox.Focused)
                {
                        idtextbox.Focus();
                }
                        
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {int ind = listBox1.SelectedItems[0].Index;
            ListViewItem lv = listBox1.SelectedItems[0];
            listBox1.Items[listBox1.SelectedItems[0].Index].Remove();
            listBox1.Items.Insert(ind - 1, lv);

            }
            catch (Exception)
            {
                MessageBox.Show("Select an item to move");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ind = listBox1.SelectedItems[0].Index;
                ListViewItem lv = listBox1.SelectedItems[0];
                listBox1.Items[listBox1.SelectedItems[0].Index].Remove();
                listBox1.Items.Insert(ind + 1, lv);

            }
            catch (Exception)
            {
                MessageBox.Show("Select an item to move");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedItems[0].Remove();
            }
            catch (Exception)
            {
                MessageBox.Show("Select an item to remove");
            }
            
        }

    }
    }

