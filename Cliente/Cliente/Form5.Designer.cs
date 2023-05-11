namespace Cliente
{
    partial class FormDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDel));
            this.labelIsbn = new System.Windows.Forms.Label();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxData3 = new System.Windows.Forms.TextBox();
            this.labelData3 = new System.Windows.Forms.Label();
            this.textBoxMessage3 = new System.Windows.Forms.TextBox();
            this.textBoxCode3 = new System.Windows.Forms.TextBox();
            this.textBoxStatus3 = new System.Windows.Forms.TextBox();
            this.labelMessage3 = new System.Windows.Forms.Label();
            this.labelCode3 = new System.Windows.Forms.Label();
            this.labelStatus3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(27, 34);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(51, 20);
            this.labelIsbn.TabIndex = 0;
            this.labelIsbn.Text = "ISBN:";
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(97, 27);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(360, 26);
            this.textBoxDel.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(175, 84);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(144, 57);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_ClickAsync);
            // 
            // textBoxData3
            // 
            this.textBoxData3.Location = new System.Drawing.Point(124, 328);
            this.textBoxData3.Name = "textBoxData3";
            this.textBoxData3.ReadOnly = true;
            this.textBoxData3.Size = new System.Drawing.Size(333, 26);
            this.textBoxData3.TabIndex = 25;
            // 
            // labelData3
            // 
            this.labelData3.AutoSize = true;
            this.labelData3.Location = new System.Drawing.Point(23, 328);
            this.labelData3.Name = "labelData3";
            this.labelData3.Size = new System.Drawing.Size(44, 20);
            this.labelData3.TabIndex = 24;
            this.labelData3.Text = "Data";
            // 
            // textBoxMessage3
            // 
            this.textBoxMessage3.Location = new System.Drawing.Point(124, 271);
            this.textBoxMessage3.Name = "textBoxMessage3";
            this.textBoxMessage3.ReadOnly = true;
            this.textBoxMessage3.Size = new System.Drawing.Size(333, 26);
            this.textBoxMessage3.TabIndex = 23;
            // 
            // textBoxCode3
            // 
            this.textBoxCode3.Location = new System.Drawing.Point(124, 222);
            this.textBoxCode3.Name = "textBoxCode3";
            this.textBoxCode3.ReadOnly = true;
            this.textBoxCode3.Size = new System.Drawing.Size(333, 26);
            this.textBoxCode3.TabIndex = 22;
            // 
            // textBoxStatus3
            // 
            this.textBoxStatus3.Location = new System.Drawing.Point(124, 166);
            this.textBoxStatus3.Name = "textBoxStatus3";
            this.textBoxStatus3.ReadOnly = true;
            this.textBoxStatus3.Size = new System.Drawing.Size(333, 26);
            this.textBoxStatus3.TabIndex = 21;
            // 
            // labelMessage3
            // 
            this.labelMessage3.AutoSize = true;
            this.labelMessage3.Location = new System.Drawing.Point(23, 271);
            this.labelMessage3.Name = "labelMessage3";
            this.labelMessage3.Size = new System.Drawing.Size(74, 20);
            this.labelMessage3.TabIndex = 20;
            this.labelMessage3.Text = "Message";
            // 
            // labelCode3
            // 
            this.labelCode3.AutoSize = true;
            this.labelCode3.Location = new System.Drawing.Point(23, 222);
            this.labelCode3.Name = "labelCode3";
            this.labelCode3.Size = new System.Drawing.Size(47, 20);
            this.labelCode3.TabIndex = 18;
            this.labelCode3.Text = "Code";
            // 
            // labelStatus3
            // 
            this.labelStatus3.AutoSize = true;
            this.labelStatus3.Location = new System.Drawing.Point(23, 166);
            this.labelStatus3.Name = "labelStatus3";
            this.labelStatus3.Size = new System.Drawing.Size(56, 20);
            this.labelStatus3.TabIndex = 19;
            this.labelStatus3.Text = "Status";
            // 
            // FormDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.textBoxData3);
            this.Controls.Add(this.labelData3);
            this.Controls.Add(this.textBoxMessage3);
            this.Controls.Add(this.textBoxCode3);
            this.Controls.Add(this.textBoxStatus3);
            this.Controls.Add(this.labelMessage3);
            this.Controls.Add(this.labelCode3);
            this.Controls.Add(this.labelStatus3);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxDel);
            this.Controls.Add(this.labelIsbn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDel";
            this.Text = "DELETE";
            this.Load += new System.EventHandler(this.FormDel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxData3;
        private System.Windows.Forms.Label labelData3;
        private System.Windows.Forms.TextBox textBoxMessage3;
        private System.Windows.Forms.TextBox textBoxCode3;
        private System.Windows.Forms.TextBox textBoxStatus3;
        private System.Windows.Forms.Label labelMessage3;
        private System.Windows.Forms.Label labelCode3;
        private System.Windows.Forms.Label labelStatus3;
    }
}