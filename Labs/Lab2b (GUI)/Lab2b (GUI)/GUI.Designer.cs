namespace Lab2b__GUI_
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgRectSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvgQuadSquare = new System.Windows.Forms.TextBox();
            this.QuadranglesNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RectanglesNumber = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.ErrMsgBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LesserQuadrangles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBtn.Location = new System.Drawing.Point(16, 84);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(166, 33);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "Generate!";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // AvgRectSquare
            // 
            this.AvgRectSquare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgRectSquare.Location = new System.Drawing.Point(297, 308);
            this.AvgRectSquare.Name = "AvgRectSquare";
            this.AvgRectSquare.ReadOnly = true;
            this.AvgRectSquare.Size = new System.Drawing.Size(62, 26);
            this.AvgRectSquare.TabIndex = 1;
            this.AvgRectSquare.TabStop = false;
            this.AvgRectSquare.Text = "0";
            this.AvgRectSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AvgRectSquare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Average square of Rectangles:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average square of Quadrangles:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AvgQuadSquare
            // 
            this.AvgQuadSquare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgQuadSquare.Location = new System.Drawing.Point(297, 208);
            this.AvgQuadSquare.Name = "AvgQuadSquare";
            this.AvgQuadSquare.ReadOnly = true;
            this.AvgQuadSquare.Size = new System.Drawing.Size(62, 26);
            this.AvgQuadSquare.TabIndex = 3;
            this.AvgQuadSquare.TabStop = false;
            this.AvgQuadSquare.Text = "0";
            this.AvgQuadSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AvgQuadSquare.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // QuadranglesNumber
            // 
            this.QuadranglesNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadranglesNumber.Location = new System.Drawing.Point(135, 12);
            this.QuadranglesNumber.Name = "QuadranglesNumber";
            this.QuadranglesNumber.Size = new System.Drawing.Size(47, 26);
            this.QuadranglesNumber.TabIndex = 0;
            this.QuadranglesNumber.Text = "0";
            this.QuadranglesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QuadranglesNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.QuadranglesNumber.Enter += new System.EventHandler(this.FieldsEntering);
            this.QuadranglesNumber.Leave += new System.EventHandler(this.FieldsLeaving);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quadrangles:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rectangles:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RectanglesNumber
            // 
            this.RectanglesNumber.AccessibleDescription = "Rectangles number";
            this.RectanglesNumber.AccessibleName = "L";
            this.RectanglesNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesNumber.Location = new System.Drawing.Point(135, 52);
            this.RectanglesNumber.Name = "RectanglesNumber";
            this.RectanglesNumber.Size = new System.Drawing.Size(47, 26);
            this.RectanglesNumber.TabIndex = 1;
            this.RectanglesNumber.Text = "0";
            this.RectanglesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RectanglesNumber.Enter += new System.EventHandler(this.FieldsEntering);
            this.RectanglesNumber.Leave += new System.EventHandler(this.FieldsLeaving);
            // 
            // Output
            // 
            this.Output.AccessibleName = "OutputConsole";
            this.Output.Location = new System.Drawing.Point(384, 12);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(404, 426);
            this.Output.TabIndex = 9;
            this.Output.TabStop = false;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // ErrMsgBox
            // 
            this.ErrMsgBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrMsgBox.ForeColor = System.Drawing.Color.Red;
            this.ErrMsgBox.Location = new System.Drawing.Point(188, 15);
            this.ErrMsgBox.Name = "ErrMsgBox";
            this.ErrMsgBox.Size = new System.Drawing.Size(190, 58);
            this.ErrMsgBox.TabIndex = 10;
            this.ErrMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrMsgBox.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity of Quadrangles with square less than average:";
            // 
            // LesserQuadrangles
            // 
            this.LesserQuadrangles.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LesserQuadrangles.Location = new System.Drawing.Point(297, 258);
            this.LesserQuadrangles.Name = "LesserQuadrangles";
            this.LesserQuadrangles.ReadOnly = true;
            this.LesserQuadrangles.Size = new System.Drawing.Size(62, 26);
            this.LesserQuadrangles.TabIndex = 12;
            this.LesserQuadrangles.TabStop = false;
            this.LesserQuadrangles.Text = "0";
            this.LesserQuadrangles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LesserQuadrangles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrMsgBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RectanglesNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuadranglesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvgQuadSquare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvgRectSquare);
            this.Controls.Add(this.GenerateBtn);
            this.KeyPreview = true;
            this.Name = "GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox AvgRectSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AvgQuadSquare;
        private System.Windows.Forms.TextBox QuadranglesNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RectanglesNumber;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label ErrMsgBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LesserQuadrangles;
    }
}

