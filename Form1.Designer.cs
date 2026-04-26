namespace preExamenRober
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
            this.buttonAbrirInscripciones = new System.Windows.Forms.Button();
            this.buttonAbrirReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrirInscripciones
            // 
            this.buttonAbrirInscripciones.Location = new System.Drawing.Point(50, 50);
            this.buttonAbrirInscripciones.Name = "buttonAbrirInscripciones";
            this.buttonAbrirInscripciones.Size = new System.Drawing.Size(200, 100);
            this.buttonAbrirInscripciones.TabIndex = 0;
            this.buttonAbrirInscripciones.Text = "Ir a Inscripciones";
            this.buttonAbrirInscripciones.UseVisualStyleBackColor = true;
            this.buttonAbrirInscripciones.Click += new System.EventHandler(this.buttonAbrirInscripciones_Click);
            // 
            // buttonAbrirReportes
            // 
            this.buttonAbrirReportes.Location = new System.Drawing.Point(300, 50);
            this.buttonAbrirReportes.Name = "buttonAbrirReportes";
            this.buttonAbrirReportes.Size = new System.Drawing.Size(200, 100);
            this.buttonAbrirReportes.TabIndex = 1;
            this.buttonAbrirReportes.Text = "Ver Reportes";
            this.buttonAbrirReportes.UseVisualStyleBackColor = true;
            this.buttonAbrirReportes.Click += new System.EventHandler(this.buttonAbrirReportes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.buttonAbrirReportes);
            this.Controls.Add(this.buttonAbrirInscripciones);
            this.Name = "Form1";
            this.Text = "Menú Principal - preExamenRober";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrirInscripciones;
        private System.Windows.Forms.Button buttonAbrirReportes;
    }
}

