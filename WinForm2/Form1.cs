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

namespace WinForm2
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.Add(new User() {Id=textBox1.Text ,Username=textBox2.Text });
        }

        private void button2_Click(object sender, EventArgs e)
        {
           bool b= users.Exists(x=>x.Username==textBox3.Text);
            if (b)
            {
                MessageBox.Show("Exists");
            }
            else
            {
                MessageBox.Show("Not Exists");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(users);
            using (StreamWriter streamWriter=new StreamWriter(@"C:\Users\HP\Desktop\test\users.json"))
            {
                streamWriter.WriteLine(json);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (StreamReader streamReader = new StreamReader(@"C:\Users\HP\Desktop\test\users.json"))
            {
               
                string jsonText = streamReader.ReadToEnd();
                if (!String.IsNullOrEmpty(jsonText))
                {
                    
                    users = JsonConvert.DeserializeObject<List<User>>(jsonText);
                }
               
            }
        }
    }
    class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
    }
}
