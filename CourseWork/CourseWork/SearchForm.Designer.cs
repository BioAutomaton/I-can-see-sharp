namespace CourseWork
{
    partial class SearchForm
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
            this.SearchValueTextBox = new System.Windows.Forms.TextBox();
            this.SearchOptionComboBox = new System.Windows.Forms.ComboBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ErrMsgBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchValueTextBox
            // 
            this.SearchValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchValueTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchValueTextBox.Location = new System.Drawing.Point(12, 47);
            this.SearchValueTextBox.Name = "SearchValueTextBox";
            this.SearchValueTextBox.Size = new System.Drawing.Size(304, 27);
            this.SearchValueTextBox.TabIndex = 3;
            this.SearchValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SearchOptionComboBox
            // 
            this.SearchOptionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchOptionComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Contract number",
            "Contract term",
            "Deposit sum"});
            this.SearchOptionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptionComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchOptionComboBox.FormattingEnabled = true;
            this.SearchOptionComboBox.Location = new System.Drawing.Point(173, 13);
            this.SearchOptionComboBox.Name = "SearchOptionComboBox";
            this.SearchOptionComboBox.Size = new System.Drawing.Size(143, 26);
            this.SearchOptionComboBox.TabIndex = 2;
            this.SearchOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchOptionComboBox_SelectedIndexChanged);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 16);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(155, 18);
            this.HeaderLabel.TabIndex = 1011;
            this.HeaderLabel.Text = "Perform search by";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfirmButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.ConfirmButton.Location = new System.Drawing.Point(12, 107);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(109, 34);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Search!";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HintLabel.Location = new System.Drawing.Point(12, 77);
            this.HintLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(34, 16);
            this.HintLabel.TabIndex = 1013;
            this.HintLabel.Text = "Hint";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ErrMsgBox
            // 
            this.ErrMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrMsgBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ErrMsgBox.ForeColor = System.Drawing.Color.Red;
            this.ErrMsgBox.Location = new System.Drawing.Point(127, 92);
            this.ErrMsgBox.Margin = new System.Windows.Forms.Padding(3);
            this.ErrMsgBox.Name = "ErrMsgBox";
            this.ErrMsgBox.Size = new System.Drawing.Size(189, 49);
            this.ErrMsgBox.TabIndex = 1021;
            this.ErrMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 153);
            this.Controls.Add(this.ErrMsgBox);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.SearchOptionComboBox);
            this.Controls.Add(this.SearchValueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchValueTextBox;
        private System.Windows.Forms.ComboBox SearchOptionComboBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label ErrMsgBox;
    }
}