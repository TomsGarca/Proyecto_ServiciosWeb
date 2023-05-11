namespace Cliente
{
    partial class FormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            this.categoria = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.Label();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxMessage2 = new System.Windows.Forms.TextBox();
            this.textBoxCode2 = new System.Windows.Forms.TextBox();
            this.textBoxStatus2 = new System.Windows.Forms.TextBox();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelCode2 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelData2 = new System.Windows.Forms.Label();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(34, 78);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(86, 20);
            this.categoria.TabIndex = 0;
            this.categoria.Text = "Categoria: ";
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Location = new System.Drawing.Point(38, 140);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(81, 20);
            this.producto.TabIndex = 1;
            this.producto.Text = "Producto: ";
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(142, 78);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(303, 26);
            this.textBoxCat.TabIndex = 2;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(142, 140);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(303, 26);
            this.textBoxP.TabIndex = 3;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(155, 191);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(164, 58);
            this.buttonAction.TabIndex = 4;
            this.buttonAction.Text = "POST";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(42, 25);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(55, 20);
            this.labelIsbn.TabIndex = 6;
            this.labelIsbn.Text = "ISBN: ";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(142, 25);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(303, 26);
            this.textBoxIsbn.TabIndex = 7;
            // 
            // textBoxMessage2
            // 
            this.textBoxMessage2.Location = new System.Drawing.Point(142, 381);
            this.textBoxMessage2.Name = "textBoxMessage2";
            this.textBoxMessage2.ReadOnly = true;
            this.textBoxMessage2.Size = new System.Drawing.Size(333, 26);
            this.textBoxMessage2.TabIndex = 15;
            // 
            // textBoxCode2
            // 
            this.textBoxCode2.Location = new System.Drawing.Point(142, 332);
            this.textBoxCode2.Name = "textBoxCode2";
            this.textBoxCode2.ReadOnly = true;
            this.textBoxCode2.Size = new System.Drawing.Size(333, 26);
            this.textBoxCode2.TabIndex = 14;
            // 
            // textBoxStatus2
            // 
            this.textBoxStatus2.Location = new System.Drawing.Point(142, 276);
            this.textBoxStatus2.Name = "textBoxStatus2";
            this.textBoxStatus2.ReadOnly = true;
            this.textBoxStatus2.Size = new System.Drawing.Size(333, 26);
            this.textBoxStatus2.TabIndex = 13;
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(41, 381);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(74, 20);
            this.labelMessage2.TabIndex = 12;
            this.labelMessage2.Text = "Message";
            // 
            // labelCode2
            // 
            this.labelCode2.AutoSize = true;
            this.labelCode2.Location = new System.Drawing.Point(41, 332);
            this.labelCode2.Name = "labelCode2";
            this.labelCode2.Size = new System.Drawing.Size(47, 20);
            this.labelCode2.TabIndex = 10;
            this.labelCode2.Text = "Code";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Location = new System.Drawing.Point(41, 276);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(56, 20);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Status";
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Location = new System.Drawing.Point(41, 438);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(44, 20);
            this.labelData2.TabIndex = 16;
            this.labelData2.Text = "Data";
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(142, 438);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.ReadOnly = true;
            this.textBoxData2.Size = new System.Drawing.Size(333, 26);
            this.textBoxData2.TabIndex = 17;
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 634);
            this.Controls.Add(this.textBoxData2);
            this.Controls.Add(this.labelData2);
            this.Controls.Add(this.textBoxMessage2);
            this.Controls.Add(this.textBoxCode2);
            this.Controls.Add(this.textBoxStatus2);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelCode2);
            this.Controls.Add(this.labelStatus2);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.categoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormP";
            this.Text = "InsertProd";
            this.Load += new System.EventHandler(this.FormP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label producto;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxMessage2;
        private System.Windows.Forms.TextBox textBoxCode2;
        private System.Windows.Forms.TextBox textBoxStatus2;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.Label labelCode2;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.TextBox textBoxData2;
    }
}