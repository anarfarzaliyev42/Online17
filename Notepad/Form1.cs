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

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter streamWriter=null;
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = richTextBox1.Text;
            if (streamWriter != null)
            {

                using (streamWriter = new StreamWriter(openFileDialog1.FileName))
                {
                    streamWriter.WriteLine(richTextBox1.Text);
                }

            }
            else
            {
                var result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    using (streamWriter = new StreamWriter(fileName))
                    {
                        streamWriter.WriteLine(richTextBox1.Text);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
           
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter streamWriter=new StreamWriter(saveFileDialog1.FileName))
                {
               
                    streamWriter.WriteLine(richTextBox1.Text);
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result= openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                using (StreamReader streamReader=new StreamReader(fileName))
                {
                    richTextBox1.Text = streamReader.ReadToEnd();
                }
            }

            //if (openFileDialog1.FileName == null)
            //{
            //    saveFileDialog1.ShowDialog();
            //    if (String.IsNullOrEmpty(openFileDialog1.FileName))
            //    {
            //        using (StreamWriter streamWriter=new StreamWriter(openFileDialog1.FileName))
            //        {
            //            streamWriter.WriteLine(richTextBox1.Text);
            //        }
            //    }
            //}
            //else
            //{
            //    if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            //    {
            //        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
            //        {
            //            streamWriter.WriteLine(richTextBox1.Text);
            //        }
            //    }
               
            //}
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
