namespace PracricaTema7
{
    partial class PracticaTema7
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbMovil = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(95, 38);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 44);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbMovil
            // 
            this.lbMovil.AutoSize = true;
            this.lbMovil.Location = new System.Drawing.Point(527, 45);
            this.lbMovil.Name = "lbMovil";
            this.lbMovil.Size = new System.Drawing.Size(32, 13);
            this.lbMovil.TabIndex = 3;
            this.lbMovil.Text = "Movil";
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(589, 41);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(145, 20);
            this.tTelefono.TabIndex = 2;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(260, 44);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(49, 13);
            this.lbApellidos.TabIndex = 5;
            this.lbApellidos.Text = "Apellidos";
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(326, 38);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(136, 20);
            this.tApellidos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(60, 143);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.Size = new System.Drawing.Size(674, 192);
            this.tListaSocios.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista Socios";
            // 
            // PracticaTema7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 347);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.lbMovil);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tNombre);
            this.Name = "PracticaTema7";
            this.Text = "PracticaTema7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbMovil;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.Label label5;
    }
}

