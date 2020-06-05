using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab6.Threads
{
    public partial class Form1 : Form
    {
        Storage data;
        Thread displayThread;
        public Form1()
        {
            InitializeComponent();
            data = new Storage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayFirst()
        {
            string temp = data.DisplayFirst();
            textBox1.Text = temp;
            FirstRTB.Text += temp;
        }

        private void DisplaySecond()
        {
            string temp = data.DisplaySecond();
            textBox2.Text = temp;
            SecondRTB.Text += temp;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            data.FirstThread.Start();
            data.SecondThread.Start();
            startDisplay();
            //displayThread = new Thread(startDisplay);
            //this.displayThread.Start();

        }

        private void startDisplay()
        {
            while(data.SecondThread.ThreadState != ThreadState.Stopped && data.FirstThread.ThreadState != ThreadState.Stopped)
            {
                DisplayFirst();
                DisplaySecond();
                Thread.Sleep(50);
            }
        }

        private void FirstRTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
