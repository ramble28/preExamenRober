namespace preExamenRober
{
    partial class FormInscripciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTaller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(92, 178);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(131, 58);
            this.buttonIngreso.TabIndex = 4;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Talleres";
            // 
            // comboBoxTaller
            // 
            this.comboBoxTaller.FormattingEnabled = true;
            this.comboBoxTaller.Location = new System.Drawing.Point(53, 94);
            this.comboBoxTaller.Name = "comboBoxTaller";
            this.comboBoxTaller.Size = new System.Drawing.Size(179, 24);
            this.comboBoxTaller.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre estudiantes";
            // 
            // comboBoxEstudiante
            // 
            this.comboBoxEstudiante.FormattingEnabled = true;
            this.comboBoxEstudiante.Location = new System.Drawing.Point(53, 33);
            this.comboBoxEstudiante.Name = "comboBoxEstudiante";
            this.comboBoxEstudiante.Size = new System.Drawing.Size(179, 24);
            this.comboBoxEstudiante.TabIndex = 0;
            // 
            // FormInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTaller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEstudiante);
            this.Name = "FormInscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.FormInscripciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEstudiante;
    }
}
