namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getList = new System.Windows.Forms.Button();
            this.getDetalles = new System.Windows.Forms.Button();
            this.insertProd = new System.Windows.Forms.Button();
            this.updateP = new System.Windows.Forms.Button();
            this.deleteP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getList
            // 
            this.getList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getList.Location = new System.Drawing.Point(59, 93);
            this.getList.Name = "getList";
            this.getList.Size = new System.Drawing.Size(170, 66);
            this.getList.TabIndex = 0;
            this.getList.Text = "getList()";
            this.getList.UseVisualStyleBackColor = false;
            this.getList.Click += new System.EventHandler(this.valUser);
            // 
            // getDetalles
            // 
            this.getDetalles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getDetalles.Location = new System.Drawing.Point(252, 93);
            this.getDetalles.Name = "getDetalles";
            this.getDetalles.Size = new System.Drawing.Size(170, 66);
            this.getDetalles.TabIndex = 1;
            this.getDetalles.Text = "getDetalles()";
            this.getDetalles.UseVisualStyleBackColor = false;
            this.getDetalles.Click += new System.EventHandler(this.valUser);
            // 
            // insertProd
            // 
            this.insertProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertProd.Location = new System.Drawing.Point(440, 93);
            this.insertProd.Name = "insertProd";
            this.insertProd.Size = new System.Drawing.Size(170, 66);
            this.insertProd.TabIndex = 2;
            this.insertProd.Text = "insertProd()";
            this.insertProd.UseVisualStyleBackColor = false;
            this.insertProd.Click += new System.EventHandler(this.valUser);
            // 
            // updateP
            // 
            this.updateP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateP.Location = new System.Drawing.Point(146, 200);
            this.updateP.Name = "updateP";
            this.updateP.Size = new System.Drawing.Size(170, 66);
            this.updateP.TabIndex = 3;
            this.updateP.Text = "updateP()";
            this.updateP.UseVisualStyleBackColor = false;
            this.updateP.Click += new System.EventHandler(this.valUser);
            // 
            // deleteP
            // 
            this.deleteP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteP.Location = new System.Drawing.Point(357, 200);
            this.deleteP.Name = "deleteP";
            this.deleteP.Size = new System.Drawing.Size(170, 66);
            this.deleteP.TabIndex = 4;
            this.deleteP.Text = "deleteP()";
            this.deleteP.UseVisualStyleBackColor = false;
            this.deleteP.Click += new System.EventHandler(this.valUser);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido! que deseas hacer?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Cliente.Properties.Resources.AMr;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 302);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteP);
            this.Controls.Add(this.updateP);
            this.Controls.Add(this.insertProd);
            this.Controls.Add(this.getDetalles);
            this.Controls.Add(this.getList);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getList;
        private System.Windows.Forms.Button getDetalles;
        private System.Windows.Forms.Button insertProd;
        private System.Windows.Forms.Button updateP;
        private System.Windows.Forms.Button deleteP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

