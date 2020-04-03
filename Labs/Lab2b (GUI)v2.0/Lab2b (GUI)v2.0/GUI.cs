using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2b__GUI_
{
    public partial class GUI : Form
    {
        public Storage database;
        private int seed = 0;

        public GUI()
        {
            InitializeComponent();

        }
        
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            database = new Storage();
            Output.Text = ""; // clear output window
            ErrMsgBox.Text = ""; // clear error box
            try
            {
                int QuadrNumber = Convert.ToInt32(QuadranglesNumber.Text);
                int RectNumber = Convert.ToInt32(RectanglesNumber.Text);
                seed = database.Generate(QuadrNumber, RectNumber, seed);
                AvgQuadSquare.Text = database.AvgQuadrSquare.ToString("n");
                AvgRectSquare.Text = database.AvgRectSquare.ToString("n");
                LesserQuadrangles.Text = database.LesserSquareCounter.ToString("N0");

                for (int i = 0; i < QuadrNumber; i++)
                {
                    Output.Text += $"Quadrangle #{i + 1}:\n";
                    Output.Text += database.Quadrangles[i].PrintData();
                    Output.Text += "\n------------------------------------------------\n\n";
                }
                for (int i = 0; i < RectNumber; i++)
                {
                    Output.Text += $"Rectangle #{i + 1}:\n";
                    Output.Text += database.Rectangles[i].PrintData();
                    Output.Text += "\n------------------------------------------------\n\n";
                }
            }
            catch (Exception exc)
            {
                ErrMsgBox.Text = exc.Message;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void GUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                GenerateBtn.PerformClick();
            }
        }

        private void FieldsEntering(object sender, EventArgs e)
        {
            ActiveControl.Text = (ActiveControl.Text == "0" ? "" : ActiveControl.Text);
        }

        private void FieldsLeaving(object sender, EventArgs e)
        {
            QuadranglesNumber.Text = (QuadranglesNumber.Text == "" ? "0" : QuadranglesNumber.Text);
            RectanglesNumber.Text = (RectanglesNumber.Text == "" ? "0" : RectanglesNumber.Text);
        }
    }
}
