using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace Lab_1_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();

        private async void button1_Click(object sender, EventArgs e)
        {
            
            var responseString = await "https://localhost:44351/sum"
    .PostUrlEncodedAsync(new { x = textBox1.Text, y = textBox2.Text })
    .ReceiveString();
            
            textBox3.Text = responseString;
        }
    }
}
