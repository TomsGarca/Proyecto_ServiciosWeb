namespace Cliente
{
    partial class Formget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formget));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.action = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxStatus2 = new System.Windows.Forms.TextBox();
            this.textBoxCode2 = new System.Windows.Forms.TextBox();
            this.textBoxMessage2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 26);
            this.textBox1.TabIndex = 1;
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(178, 92);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(160, 60);
            this.action.TabIndex = 2;
            this.action.Text = "GET";
            this.action.UseVisualStyleBackColor = true;
            this.action.Click += new System.EventHandler(this.action_ClickAsync);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(38, 178);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(38, 234);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(47, 20);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Code";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(38, 283);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(74, 20);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(38, 336);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data";
            // 
            // textBoxStatus2
            // 
            this.textBoxStatus2.Location = new System.Drawing.Point(139, 178);
            this.textBoxStatus2.Name = "textBoxStatus2";
            this.textBoxStatus2.ReadOnly = true;
            this.textBoxStatus2.Size = new System.Drawing.Size(333, 26);
            this.textBoxStatus2.TabIndex = 7;
            // 
            // textBoxCode2
            // 
            this.textBoxCode2.Location = new System.Drawing.Point(139, 234);
            this.textBoxCode2.Name = "textBoxCode2";
            this.textBoxCode2.ReadOnly = true;
            this.textBoxCode2.Size = new System.Drawing.Size(333, 26);
            this.textBoxCode2.TabIndex = 8;
            // 
            // textBoxMessage2
            // 
            this.textBoxMessage2.Location = new System.Drawing.Point(139, 283);
            this.textBoxMessage2.Name = "textBoxMessage2";
            this.textBoxMessage2.ReadOnly = true;
            this.textBoxMessage2.Size = new System.Drawing.Size(333, 26);
            this.textBoxMessage2.TabIndex = 9;
            // 
            // Formget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 638);
            this.Controls.Add(this.textBoxMessage2);
            this.Controls.Add(this.textBoxCode2);
            this.Controls.Add(this.textBoxStatus2);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.action);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formget";
            this.Text = "getList()";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formget_FormClosing);
            this.Load += new System.EventHandler(this.Formget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxStatus2;
        private System.Windows.Forms.TextBox textBoxCode2;
        private System.Windows.Forms.TextBox textBoxMessage2;
    }
}