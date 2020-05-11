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
        private int seed = 100;
        int QuadrNumber = 0;
        int RectNumber = 0;
        public GUI()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            database = new Storage();
            ErrMsgBox.Text = ""; // clear error box
            FigureSelection.Items.Clear(); // clear selection list
            try
            {
                QuadrNumber = Convert.ToInt32(QuadranglesNumber.Text);
                RectNumber = Convert.ToInt32(RectanglesNumber.Text);
                seed = database.Generate(QuadrNumber, RectNumber, seed);
                AvgQuadSquare.Text = database.AvgQuadrSquare.ToString("N2");
                AvgRectSquare.Text = database.AvgRectSquare.ToString("N2");
                LesserQuadrangles.Text = database.LesserSquareCounter.ToString("N0");
                for (int i = 0; i < QuadrNumber; i++)
                {
                    FigureSelection.Items.Add($"Quadrangle #{i + 1:N0}");
                }
                for (int i = 0; i < RectNumber; i++)
                {
                    FigureSelection.Items.Add($"Rectangle  #{i + 1:N0}");
                }
                FigureSelection.SelectedIndex = (RectNumber == 0 ? 0 :  QuadrNumber);
                ActiveControl = FigureSelection;   
            }
            catch (Exception exc)
            {
                ErrMsgBox.Text = exc.Message;
            }
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

        private void SelectNewFigure(object sender, EventArgs e)
        {
            int i = FigureSelection.SelectedIndex;
            ClearTables();
            for (int j = 0; j < 4; j++)
            {
                PointsDataGrid.Rows.Add(database.Quadrangles[i].Points[j].x.ToString("N0"), database.Quadrangles[i].Points[j].y.ToString("N0"));
                SideLengthDataGrid.Rows.Add(database.Quadrangles[i].Length[j].ToString("N2"));
            }

            for (int j = 0; j < 2; j++)
            {
                DiagonalDataGrid.Rows.Add(database.Quadrangles[i].Diagonal[j].ToString("N2"));
                PSDataGrid.Rows.Add(((j == 0 ? database.Quadrangles[i].Perimeter.ToString("N2") : database.Quadrangles[i].Square.ToString("N2"))));
            }
            NameRowHeaders();
            DGsClearSelection();
            ViewFigure(i);
        }

        private void ClearTables()
        {
            PointsDataGrid.Rows.Clear(); // clear points table
            SideLengthDataGrid.Rows.Clear(); // clear side lenght table
            DiagonalDataGrid.Rows.Clear(); // clear diagonal lenght table
            PSDataGrid.Rows.Clear(); // cleare Perimeter & Square table
        }

        private void AssignZeroes()
        {
            for (int i = 0; i < 4; i++)
            {
                PointsDataGrid.Rows.Add("0", "0");
                SideLengthDataGrid.Rows.Add("0");
            }
            for (int i = 0; i < 2; i++)
            {
                DiagonalDataGrid.Rows.Add("0");
                PSDataGrid.Rows.Add("0");
            }
        }

        private void NameRowHeaders()
        {
            PointsDataGrid.Rows[0].HeaderCell.Value = "A";
            PointsDataGrid.Rows[1].HeaderCell.Value = "B";
            PointsDataGrid.Rows[2].HeaderCell.Value = "C";
            PointsDataGrid.Rows[3].HeaderCell.Value = "D";

            SideLengthDataGrid.Rows[0].HeaderCell.Value = "a";
            SideLengthDataGrid.Rows[1].HeaderCell.Value = "b";
            SideLengthDataGrid.Rows[2].HeaderCell.Value = "c";
            SideLengthDataGrid.Rows[3].HeaderCell.Value = "d";

            DiagonalDataGrid.Rows[0].HeaderCell.Value = "d1";
            DiagonalDataGrid.Rows[1].HeaderCell.Value = "d2";

            PSDataGrid.Rows[0].HeaderCell.Value = "Perimeter";
            PSDataGrid.Rows[1].HeaderCell.Value = "Square";
        }

        private void DGsClearSelection()
        {
            PointsDataGrid.CurrentCell = null;
            SideLengthDataGrid.CurrentCell = null;
            DiagonalDataGrid.CurrentCell = null;
            PSDataGrid.CurrentCell = null;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            AssignZeroes();
            NameRowHeaders();
            DGsClearSelection();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DiagonalDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void SideLengthDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PointsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewFigure(int N)
        {
            Bitmap bmp = new Bitmap(250, 250);
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.Black, 2);
            Pen punct = new Pen(Color.Red);
            Pen axis = new Pen(Color.Black, 4);
            float[] dashValues = { 4, 4 };
            punct.DashPattern = dashValues;
            Brush redBrush = new SolidBrush(Color.Red);
            Brush blackBrush = new SolidBrush(Color.Black);
            Font captionFont = new Font("Consolas",13, FontStyle.Regular);
            Font small = new Font("Consolas", 8, FontStyle.Regular);
            string[] PointsName = { "A", "B", "C", "D" };

            /*Axis drawing*/
            g.DrawLine(axis,0,0,0,250);
            g.DrawLine(axis, 0, 0, 250, 0);
            for (int i = 0; i <= 250; i+=20)
            {
                g.DrawLine(p, i, 0, i, 5);
                g.DrawLine(p, 0, i, 5, i);
            }

            /*Figure drawing*/
            for (int i = 0; i < 2; i++)
            {
                g.DrawLine(punct, database.Quadrangles[N].Points[i].x * 10, database.Quadrangles[N].Points[i].y * 10, database.Quadrangles[N].Points[(i + 2) % 4].x * 10, database.Quadrangles[N].Points[(i + 2) % 4].y * 10);
            }
            for (int i = 0; i < 4; i++)
            {
                g.DrawLine(p, database.Quadrangles[N].Points[i].x * 10, database.Quadrangles[N].Points[i].y * 10, database.Quadrangles[N].Points[(i + 1) % 4].x * 10, database.Quadrangles[N].Points[(i + 1) % 4].y * 10);
            }


            /*Flip figure*/
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);

            /*Add captions AFTER flipping so they won't be affectet by aforementioned transformation*/
            for (int i = 0; i < 4; i++)
            {
                g.DrawString(PointsName[i], captionFont, blackBrush, database.Quadrangles[N].Points[i].x * 10, 250 -database.Quadrangles[N].Points[i].y * 10);
                
            }
            g.DrawString("OY", captionFont, redBrush, 10, 0);
            g.DrawString("OX", captionFont, redBrush, 227, 225);
            for (int i = 20; i <= 220; i+= 20)
            {
                g.DrawString($"{i/10}", small, blackBrush, i-5, 230);
                g.DrawString($"{i/10}", small, blackBrush, 10, 243-i);
            }
            pictureBox1.Image = bmp;
        }
    }
}
