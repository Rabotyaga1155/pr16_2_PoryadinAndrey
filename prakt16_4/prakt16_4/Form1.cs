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

namespace prakt16_4
{
    public partial class Form1 : Form
    {
        
        string path = "Strani.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long chislen = long.Parse(textBox1.Text);
            Dictionary<string, long> countries = new Dictionary<string, long>();
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] parts = line.Split(' ');
                string country = parts[0];
                if (long.TryParse(parts[1],out long pop)&& pop>chislen)
                {
                    countries.Add(country, pop);
                }



                //long pop = long.Parse(parts[1]);
                //if (pop>chislen)
                //{
                //    countries.Add(country, pop);
                //}
            }
            var sorted = countries.OrderBy(x => x.Key.Length).ThenBy(x => x.Key);
            listBox1.Items.Clear();
            foreach (var country in sorted)
            {
                listBox1.Items.Add($"{country.Key} ({country.Value})");
            }
        }
    }
}
