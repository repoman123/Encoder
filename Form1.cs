using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace Encoder
{
    public partial class Form1 : Form
    {

        string encf;
        Boolean encint;
        int linecount = 0;
        int count = 0;
        int column = 0;
        int progress;
        int textlenght;
        List<int> intlist = new List<int>();
        List<string> enclist = new List<string>();
        List<string> charlist = new List<string>();
        List<string> stringlist = new List<string>();
        List<char> errorcharacterlist = new List<char>();
        List<string> linelist = new List<string>();
        List<int> errorlinelist = new List<int>();
        List<int> errorindexlist = new List<int>();
        List<int> errorlist = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            decimal d = (decimal)textBox1.Font.Size;
            fontbox.Text = textBox1.Font.Name;
            numericUpDown1.Value = d;
        }
        void encodingfilereader(string path)
        {
            int lines = 0;
            string[] st = File.ReadAllLines(path);

            foreach (string s in st)
            {
                listBox1.Items.Add(s.Remove(s.IndexOf("-"), s.Length - s.IndexOf("-")) + " = " + s.Remove(0, s.IndexOf("->") + 2));
                charlist.Add(s.Remove(s.IndexOf("-"), s.Length - s.IndexOf("-")));
                enclist.Add(s.Remove(0, s.IndexOf("-")));

                lines += 1;
                encint = true;
            }


            if (path.EndsWith(".encodinb"))
            {
                foreach (string s in st)
                {
                    stringlist.Add(s.Remove(s.IndexOf("->"), s.Length));
                    enclist.Add(s.Remove(0, s.IndexOf("->")));
                    listBox1.Items.Add(s.ElementAt(0));
                    encint = false;
                    lines += 1;
                }
            }
        }
        void encfilereader(string path)
        {
            if (path.EndsWith(".enc"))
            {
                intlist.Clear();
                int x = 0;
                int errors = 0;
                string[] st = File.ReadAllLines(path);
                changestatus(status.reading);
                ProgressBar1.Maximum = st.Length;
                textlenght = st.Length;
                if (encint == true & charlist.Count == enclist.Count)
                {
                    try
                    {
                        foreach (string s in st)
                        {
                            if (s.StartsWith("\n"))
                            {
                                textBox1.Text += Environment.NewLine;
                            }
                            else
                            {
                                string i = s.Remove(0, s.IndexOf("->") + 1);
                                listBox1.Items.Add(i);
                                x += 1;
                                textBox1.Text += charlist[Convert.ToInt32(enclist.IndexOf(i))].ToString();
                                ProgressBar1.Value = x;
                                progress = x;
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    changestatus(status.idle);
                }

                if (errors > 0)
                {
                    MessageBox.Show(errors.ToString() + " error(s) occured during de-encoding");
                }
            }
            if (path.EndsWith(".binenc"))
            {
                byte[] bs = File.ReadAllBytes(path);
                foreach (byte b in bs)
                {
                    textBox1.Text += b + " ";

                }
            }
        }

        void encfilewriter(string filepath)
        {
            int x = 0;
            File.Create(filepath).Close();
            textBox1.Text = textBox1.Text.Replace("\n", "\n");
            changestatus(status.writing);
            ProgressBar1.Maximum = textBox1.TextLength * 2;
            progressupdater.Start();
            if (encint == true)
            {
                foreach (char c in textBox1.Text)
                {
                    x += 1;
                    ProgressBar1.Value = x;

                    intlist.Add(Convert.ToInt32(enclist[charlist.IndexOf(c.ToString())]));
                }

                foreach (int item in intlist)
                {
                    File.AppendAllText(filepath, item + Environment.NewLine);
                    ProgressBar1.Value += 1;
                }
            }
            changestatus(status.idle);

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {//encoding error check
            linelist.Clear();
            errorindexlist.Clear();
            errorcharacterlist.Clear();
            errorlinelist.Clear();
            listBox2.Items.Clear();
            errorlist.Clear();
            column = 0;
            count = 0;
            linecount = 0;


            foreach (string line in textBox1.Lines)
            {
                linelist.Add(line);
            }
            foreach (string st in linelist)
            {
                linecount += 1;
                column = 0;
                foreach (char c in st)
                {
                    column += 1;
                    if (charlist.Contains(c.ToString()) != true)
                    {
                        textBox1.Text = textBox1.Text.Replace(c.ToString(), "▲");
                        count += 1;
                        errorlinelist.Add(linecount);
                        errorindexlist.Add(column);
                        errorcharacterlist.Add(c);
                        errorlist.Add(count);
                        label1.Text = count.ToString();
                        listBox2.Items.Add(c.ToString() + " Line: " + linecount.ToString() + " Column: " + column);

                    }
                    else
                    {
                        textBox1.ForeColor = Color.Black;
                    }
                }
            }

            foreach (int i in errorlist)
            {//auto error highlighter
                try
                {
                    Point p = new Point((errorindexlist[i]) * 5, 13 * ((errorlinelist[i])));
                    Size s = new Size(5, 2);
                    Rectangle r = new Rectangle(p, s);
                    textBox1.CreateGraphics().FillRectangle(Brushes.Red, r);

                }
                catch (Exception)
                {

                }

            }
        }

        enum status
        {
            reading,
            writing,
            idle
        }
        void changestatus(status st)
        {
            if (st == status.idle)
            {
                // changes app status to idle

                ProgressBar1.Visible = false;
                progressupdater.Stop();
            }
            if (st == status.reading)
            {
                // changes app status to reading

                ProgressBar1.Visible = true;
            }
            if (st == status.writing)
            {
                // changes app status to writing

                ProgressBar1.Visible = true;
            }
        }

        private void progressupdater_Tick(object sender, EventArgs e)
        {
            progresslabel2.Text = progress + " out of " + textlenght;
        }

        private void fontbox_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            fontbox.Text = fontDialog1.Font.Name;
            numericUpDown1.Value = (decimal)fontDialog1.Font.Size;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float f = (float)numericUpDown1.Value;
            textBox1.Font = new Font(textBox1.Font.FontFamily, f, FontStyle.Regular, GraphicsUnit.Point);
        }

        #region FileAssociation
         public static void SetAssociation(string Extension, string KeyName, string OpenWith, string FileDescription)
        {
            // The stuff that was above here is basically the same
            RegistryKey BaseKey;
            RegistryKey OpenMethod;
            RegistryKey Shell;
            RegistryKey CurrentUser;

            BaseKey = Registry.ClassesRoot.CreateSubKey(Extension);
            BaseKey.SetValue("", KeyName);

            OpenMethod = Registry.ClassesRoot.CreateSubKey(KeyName);
            OpenMethod.SetValue("", FileDescription);
            OpenMethod.CreateSubKey("DefaultIcon").SetValue("", "\"" + OpenWith + "\",0");
            Shell = OpenMethod.CreateSubKey("Shell");
            Shell.CreateSubKey("edit").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            Shell.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            BaseKey.Close();
            OpenMethod.Close();
            Shell.Close();

            // Delete the key instead of trying to change it
            CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + Extension, true);
            CurrentUser.DeleteSubKey("UserChoice", false);
            CurrentUser.Close();

            // Tell explorer the file association has been changed
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            SetAssociation(".enc", ".enc", "Encoder.exe", "Encoded File");
            SetAssociation(".encoding", ".encoding", "Encoder.exe", "Encoding File");
        }
        #region menustrip
        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                openfile.ShowDialog();
                encfilereader(openfile.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }  
        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            savefile.ShowDialog();
            encfilewriter(savefile.FileName);
        }
        private void openCustomEncodingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                openfile2.ShowDialog();
                encf = openfile2.FileName;
                encodingfilereader(encf);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void createOrEditEncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
        }
        #endregion

        

       

       
      
    }
}
