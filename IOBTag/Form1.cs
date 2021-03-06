﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOBTag
{
    public partial class Form1 : Form
    {
        public String fileName;
        public String[] lines;
        public int index;
        public List<Post> posts = new List<Post>();
        Post currentPost;
        public List<String> drugList = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveTags()
        {
            String[] tags = getTags();
            if (tags != null && tags.Length==currentPost.Words.Length)
            {
                currentPost.IOBS = getTags();
                updateSavedLabel();
            }
            
        }

        private void loadFile()
        {
            posts.Clear();

            lines = File.ReadAllLines(fileName);
            Tuple<int?, int?, int?, int?, int?, int?> colIndex = getColumns(lines.ElementAt(0));
            for (int i=1; i<lines.Length; i++)
            {
                Post post = new Post(lines.ElementAt(i), colIndex);
                posts.Add(post);
            }
            index = 0;
            getPost();
        }

        private Tuple<int?,int?,int?,int?, int?, int?> getColumns(string header)
        {
            String[] cols = header.Split('|');
            int? bodyCol = null;
            int? wordlenCol = null;
            int? posCol = null;
            int? wordsCol = null;
            int? iobsCol = null;
            int? adrCol = null;

            for (int i =0; i<cols.Length;i++)
            {
                String col = cols.ElementAt(i).ToLower().Trim(); ;

                switch(col)
                {
                    case "body":
                        bodyCol = i;
                        break;

                    case "wordlen":
                        wordlenCol = i;
                        break;

                    case "words":
                        wordsCol = i;
                        break;

                    case "pos":
                        posCol = i;
                        break;

                    case "iob":
                        iobsCol = i;
                        break;

                    case "adr":
                        adrCol = i;
                        break;
                }
            }

            var colIndex = Tuple.Create(bodyCol, wordlenCol, wordsCol, posCol, iobsCol, adrCol);

            return colIndex;
        }

        private void getPost()
        {
            currentPost = posts.ElementAt(index);
            bodyTextBox.Text = currentPost.Body;
            addControls();
            updateCurrentLabel();

        }

        private void getNextPost()
        {
            if ((index+1)<posts.Count)
            {
                saveTags();
                index++;
                getPost();

            }
            
        }

        private void getPrevPost()
        {
            if ((index -1) >= 0)
            {
                saveTags();
                index--;
                getPost();
            }
        }

        private String[] getTags()
        {
            List<String> tags = new List<String>();

            foreach (FlowLayoutPanel l in wordsPanel.Controls)
            {
                foreach (Control ctrl in l.Controls)
                {
                    if(ctrl is ComboBox)
                    {
                        if(((ComboBox)ctrl).SelectedItem!=null)
                        {
                            tags.Add(((ComboBox)ctrl).SelectedItem.ToString());
                        }
                        
                    }
                }
            }

            return tags.ToArray();
        }

        private void addControls()
        {
            String[] words = currentPost.Words;
            String[] iobs = currentPost.IOBS;

            wordsPanel.Controls.Clear();

            for (int i=0; i<words.Length; i++)
            {
                FlowLayoutPanel tLayout = new FlowLayoutPanel();
                tLayout.FlowDirection = FlowDirection.TopDown;
             
                TextBox w = new TextBox();
                w.Text = words.ElementAt(i);
                w.ReadOnly = true;
                w.BackColor = Color.White;
                w.TabStop = false;
                w.Font = new Font("Microsoft Sans Serif", 10);
                w.Name = "boxSentIndex" + i.ToString();

                ComboBox c = new ComboBox();
                c.Name = "comboSentIndex" + i.ToString();
                c.Width = w.Width;
                c.Items.Add("O");
                c.Items.Add("B-ADR");
                c.Items.Add("I-ADR");
                c.Items.Add("B-IND");
                c.Items.Add("I-IND");
                c.Items.Add("M");
                if (iobs != null)
                {
                    String iob = iobs.ElementAt(i);
                    c.SelectedItem = iob;
                } else if(drugList.Contains(w.Text)) {
                    c.SelectedItem = "M";
                }
                c.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.combo_MouseWheel);

                tLayout.Controls.Add(w);
                tLayout.Controls.Add(c);

                tLayout.AutoSize = true;
                tLayout.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
                //tLayout.BorderStyle = BorderStyle.FixedSingle;

                wordsPanel.Controls.Add(tLayout);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            fileName = open.FileName;
            if (fileName != null)
            {
                loadFile();
                back.Enabled = true;
                skip.Enabled = true;
                fill.Enabled = true;
                jump.Enabled = true;
                jumpBox.Enabled = true;
            }
            
        }

        private void skip_Click(object sender, EventArgs e)
        {
            getNextPost();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateCurrentLabel()
        {
            currentLabel.Text = "Line " + (index+1).ToString() + " of " + (posts.Count).ToString() + " - " + currentPost.Words.Length.ToString() + " words";
        }

        private void updateSavedLabel()
        {
            int totalSaved = 0;
            foreach (Post post in posts)
            {
                if (post.IOBS!=null)
                {
                    totalSaved++;
                }
            }
            savedLabel.Text = totalSaved.ToString() + " lines tagged";
        }

        private void back_Click(object sender, EventArgs e)
        {
            getPrevPost();
        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        //if (lines.ElementAt(0).Split('|').Length > 4)
                        //{
                        //    tw.WriteLine(lines.ElementAt(0));
                        //} else
                        //{
                        //    tw.WriteLine(lines.ElementAt(0) + "|iob|adr");
                        //}
                        tw.WriteLine("body|wordlen|words|pos|iob|adr");

                        foreach (Post post in posts)
                        {
                            tw.WriteLine(post.getString());
                        }
                    }
                }
            }
        }

        private void fill_Click(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel l in wordsPanel.Controls)
            {
                foreach (Control ctrl in l.Controls)
                {
                    if (ctrl is ComboBox)
                    {
                        if (((ComboBox)ctrl).SelectedItem == null)
                        {
                            ((ComboBox)ctrl).SelectedItem = "O";
                        }

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instruct.Text = "O: Out    |    M : Medication    |    B-ADR : Begin Negative Reaction    |    I-ADR : Part of Negative Reaction    |    B-IND : Begin Positive or Unrelated Reaction    |    I-IND : Part of Positive or Unrelated Reaction";
            instruct.Width = this.Width;
            fillDrugList();
        }

        void combo_MouseWheel(object sender, MouseEventArgs e)
        {
            ComboBox control = (ComboBox)sender;
            if (!control.DroppedDown)
            {
                ((HandledMouseEventArgs)e).Handled = true;
            }
              
        }

        private void fillDrugList()
        {
            drugList.Clear();
            drugList.Add("abilify");
            drugList.Add("alprazolam");
            drugList.Add("amitriptyline");
            drugList.Add("aplenzin");
            drugList.Add("aripiprazole");
            drugList.Add("atenolol");
            drugList.Add("ativan");
            drugList.Add("budeprion");
            drugList.Add("bupropion");
            drugList.Add("buspar");
            drugList.Add("buspirone");
            drugList.Add("celexa");
            drugList.Add("citalopram");
            drugList.Add("clonazepam");
            drugList.Add("clonidine");
            drugList.Add("cymbalta");
            drugList.Add("deplin");
            drugList.Add("desvenlafaxine");
            drugList.Add("desyrel");
            drugList.Add("diazepam");
            drugList.Add("doxepin");
            drugList.Add("duloxetine");
            drugList.Add("effexor");
            drugList.Add("escitalopram");
            drugList.Add("fetzima");
            drugList.Add("fluoxetine");
            drugList.Add("forfivo");
            drugList.Add("gabapentin");
            drugList.Add("hydroxyzine");
            drugList.Add("lamotrigine");
            drugList.Add("lexapro");
            drugList.Add("librium");
            drugList.Add("lorazepam");
            drugList.Add("methylphenidate");
            drugList.Add("mirtazapine");
            drugList.Add("nortriptyline");
            drugList.Add("olanzapine");
            drugList.Add("oleptro");
            drugList.Add("paroxetine");
            drugList.Add("paxil");
            drugList.Add("pristiq");
            drugList.Add("propranolol");
            drugList.Add("prozac");
            drugList.Add("quetiapine");
            drugList.Add("remeron");
            drugList.Add("seroquel");
            drugList.Add("sertraline");
            drugList.Add("tenormin");
            drugList.Add("tramadol");
            drugList.Add("trazodone");
            drugList.Add("trintellix");
            drugList.Add("valium");
            drugList.Add("venlafaxine");
            drugList.Add("viibryd");
            drugList.Add("vistaril");
            drugList.Add("wellbutrin");
            drugList.Add("xanax");
            drugList.Add("zoloft");
            drugList.Add("zyprexa");

        }

        private void jump_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (jumpBox.Text!=null && jumpBox.Text!=String.Empty && int.TryParse(jumpBox.Text, out parsedValue) 
                && Convert.ToInt32(jumpBox.Text)<=posts.Count && Convert.ToInt32(jumpBox.Text) > 0)
            {
                index = Convert.ToInt32(jumpBox.Text) - 1;
                getPost();
            }
        }
    }
}
