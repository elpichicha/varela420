namespace varela420
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
            this.LBLTextoA = new System.Windows.Forms.Label();
            this.LBLTextoB = new System.Windows.Forms.Label();
            this.LBLFecha = new System.Windows.Forms.Label();
            this.TXTtextoA = new System.Windows.Forms.TextBox();
            this.TXTtextoB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTNCOMPARAR = new System.Windows.Forms.Button();
            this.BTNCONVERTIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNremplazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLTextoA
            // 
            this.LBLTextoA.AutoSize = true;
            this.LBLTextoA.Location = new System.Drawing.Point(70, 62);
            this.LBLTextoA.Name = "LBLTextoA";
            this.LBLTextoA.Size = new System.Drawing.Size(41, 13);
            this.LBLTextoA.TabIndex = 0;
            this.LBLTextoA.Text = "TextoA";
            // 
            // LBLTextoB
            // 
            this.LBLTextoB.AutoSize = true;
            this.LBLTextoB.Location = new System.Drawing.Point(70, 94);
            this.LBLTextoB.Name = "LBLTextoB";
            this.LBLTextoB.Size = new System.Drawing.Size(41, 13);
            this.LBLTextoB.TabIndex = 1;
            this.LBLTextoB.Text = "TextoB";
            // 
            // LBLFecha
            // 
            this.LBLFecha.AutoSize = true;
            this.LBLFecha.Location = new System.Drawing.Point(70, 126);
            this.LBLFecha.Name = "LBLFecha";
            this.LBLFecha.Size = new System.Drawing.Size(37, 13);
            this.LBLFecha.TabIndex = 2;
            this.LBLFecha.Text = "Fecha";
            // 
            // TXTtextoA
            // 
            this.TXTtextoA.Location = new System.Drawing.Point(135, 59);
            this.TXTtextoA.Name = "TXTtextoA";
            this.TXTtextoA.Size = new System.Drawing.Size(61, 20);
            this.TXTtextoA.TabIndex = 3;
            this.TXTtextoA.TextChanged += new System.EventHandler(this.TXTtextoA_TextChanged);
            // 
            // TXTtextoB
            // 
            this.TXTtextoB.Location = new System.Drawing.Point(135, 94);
            this.TXTtextoB.Name = "TXTtextoB";
            this.TXTtextoB.Size = new System.Drawing.Size(61, 20);
            this.TXTtextoB.TabIndex = 4;
            this.TXTtextoB.TextChanged += new System.EventHandler(this.TXTtextoB_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // BTNCOMPARAR
            // 
            this.BTNCOMPARAR.Location = new System.Drawing.Point(135, 175);
            this.BTNCOMPARAR.Name = "BTNCOMPARAR";
            this.BTNCOMPARAR.Size = new System.Drawing.Size(94, 30);
            this.BTNCOMPARAR.TabIndex = 7;
            this.BTNCOMPARAR.Text = "COMPARAR";
            this.BTNCOMPARAR.UseVisualStyleBackColor = true;
            this.BTNCOMPARAR.Click += new System.EventHandler(this.BTNCOMPARAR_Click);
            // 
            // BTNCONVERTIR
            // 
            this.BTNCONVERTIR.Location = new System.Drawing.Point(135, 211);
            this.BTNCONVERTIR.Name = "BTNCONVERTIR";
            this.BTNCONVERTIR.Size = new System.Drawing.Size(94, 36);
            this.BTNCONVERTIR.TabIndex = 8;
            this.BTNCONVERTIR.Text = "CONVERTIR";
            this.BTNCONVERTIR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // BTNremplazar
            // 
            this.BTNremplazar.Location = new System.Drawing.Point(135, 253);
            this.BTNremplazar.Name = "BTNremplazar";
            this.BTNremplazar.Size = new System.Drawing.Size(94, 33);
            this.BTNremplazar.TabIndex = 11;
            this.BTNremplazar.Text = "Remplazar";
            this.BTNremplazar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 511);
            this.Controls.Add(this.BTNremplazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNCONVERTIR);
            this.Controls.Add(this.BTNCOMPARAR);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TXTtextoB);
            this.Controls.Add(this.TXTtextoA);
            this.Controls.Add(this.LBLFecha);
            this.Controls.Add(this.LBLTextoB);
            this.Controls.Add(this.LBLTextoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTextoA;
        private System.Windows.Forms.Label LBLTextoB;
        private System.Windows.Forms.Label LBLFecha;
        private System.Windows.Forms.TextBox TXTtextoA;
        private System.Windows.Forms.TextBox TXTtextoB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BTNCOMPARAR;
        private System.Windows.Forms.Button BTNCONVERTIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNremplazar;
    }
}

