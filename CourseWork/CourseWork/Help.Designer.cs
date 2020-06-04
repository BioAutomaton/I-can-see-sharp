namespace CourseWork
{
    partial class Help
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
            this.HelpRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GeneralBtn = new System.Windows.Forms.Button();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.RemoveClientBtn = new System.Windows.Forms.Button();
            this.EditClientBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ImpExpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelpRichTextBox
            // 
            this.HelpRichTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpRichTextBox.Location = new System.Drawing.Point(246, 12);
            this.HelpRichTextBox.Name = "HelpRichTextBox";
            this.HelpRichTextBox.ReadOnly = true;
            this.HelpRichTextBox.Size = new System.Drawing.Size(412, 234);
            this.HelpRichTextBox.TabIndex = 0;
            this.HelpRichTextBox.Text = "";
            // 
            // GeneralBtn
            // 
            this.GeneralBtn.FlatAppearance.BorderSize = 0;
            this.GeneralBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.GeneralBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GeneralBtn.Location = new System.Drawing.Point(12, 12);
            this.GeneralBtn.Name = "GeneralBtn";
            this.GeneralBtn.Size = new System.Drawing.Size(228, 34);
            this.GeneralBtn.TabIndex = 10;
            this.GeneralBtn.Text = "General";
            this.GeneralBtn.UseVisualStyleBackColor = true;
            this.GeneralBtn.Click += new System.EventHandler(this.GeneralBtn_Click);
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.FlatAppearance.BorderSize = 0;
            this.AddClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.AddClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddClientBtn.Location = new System.Drawing.Point(12, 52);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(228, 34);
            this.AddClientBtn.TabIndex = 11;
            this.AddClientBtn.Text = "Add client";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // RemoveClientBtn
            // 
            this.RemoveClientBtn.FlatAppearance.BorderSize = 0;
            this.RemoveClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveClientBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.RemoveClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveClientBtn.Location = new System.Drawing.Point(12, 92);
            this.RemoveClientBtn.Name = "RemoveClientBtn";
            this.RemoveClientBtn.Size = new System.Drawing.Size(228, 34);
            this.RemoveClientBtn.TabIndex = 12;
            this.RemoveClientBtn.Text = "Remove client";
            this.RemoveClientBtn.UseVisualStyleBackColor = true;
            this.RemoveClientBtn.Click += new System.EventHandler(this.RemoveClientBtn_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.FlatAppearance.BorderSize = 0;
            this.EditClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditClientBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.EditClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditClientBtn.Location = new System.Drawing.Point(12, 132);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Size = new System.Drawing.Size(228, 34);
            this.EditClientBtn.TabIndex = 13;
            this.EditClientBtn.Text = "Edit client";
            this.EditClientBtn.UseVisualStyleBackColor = true;
            this.EditClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBtn.Location = new System.Drawing.Point(12, 212);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(228, 34);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ImpExpBtn
            // 
            this.ImpExpBtn.FlatAppearance.BorderSize = 0;
            this.ImpExpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpExpBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.ImpExpBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImpExpBtn.Location = new System.Drawing.Point(12, 172);
            this.ImpExpBtn.Name = "ImpExpBtn";
            this.ImpExpBtn.Size = new System.Drawing.Size(228, 34);
            this.ImpExpBtn.TabIndex = 15;
            this.ImpExpBtn.Text = "Import / Export";
            this.ImpExpBtn.UseVisualStyleBackColor = true;
            this.ImpExpBtn.Click += new System.EventHandler(this.ImpExpBtn_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 257);
            this.Controls.Add(this.ImpExpBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.EditClientBtn);
            this.Controls.Add(this.RemoveClientBtn);
            this.Controls.Add(this.AddClientBtn);
            this.Controls.Add(this.GeneralBtn);
            this.Controls.Add(this.HelpRichTextBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HelpRichTextBox;
        private System.Windows.Forms.Button GeneralBtn;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button RemoveClientBtn;
        private System.Windows.Forms.Button EditClientBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ImpExpBtn;
    }
}