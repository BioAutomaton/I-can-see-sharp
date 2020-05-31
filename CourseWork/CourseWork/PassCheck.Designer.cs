namespace CourseWork
{
    partial class PassCheck
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
            this.PasswordEntering = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ErrMsgBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordEntering
            // 
            this.PasswordEntering.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordEntering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordEntering.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEntering.Location = new System.Drawing.Point(19, 19);
            this.PasswordEntering.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.PasswordEntering.Name = "PasswordEntering";
            this.PasswordEntering.Size = new System.Drawing.Size(231, 27);
            this.PasswordEntering.TabIndex = 4;
            this.PasswordEntering.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswordEntering.UseSystemPasswordChar = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.CheckButton.Location = new System.Drawing.Point(19, 52);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(74, 29);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ErrMsgBox
            // 
            this.ErrMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrMsgBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrMsgBox.ForeColor = System.Drawing.Color.Red;
            this.ErrMsgBox.Location = new System.Drawing.Point(99, 52);
            this.ErrMsgBox.Margin = new System.Windows.Forms.Padding(3);
            this.ErrMsgBox.Name = "ErrMsgBox";
            this.ErrMsgBox.Size = new System.Drawing.Size(158, 29);
            this.ErrMsgBox.TabIndex = 1021;
            this.ErrMsgBox.Text = "Enter password";
            this.ErrMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 89);
            this.Controls.Add(this.ErrMsgBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.PasswordEntering);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PassCheck";
            this.Text = "PassCheck";
            this.Load += new System.EventHandler(this.PassCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordEntering;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label ErrMsgBox;
    }
}