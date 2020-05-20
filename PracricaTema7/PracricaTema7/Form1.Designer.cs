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
            this.label2 = new System.Windows.Forms.Label();
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
            this.tNombre.Location = new System.Drawing.Point(127, 47);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(132, 22);
            this.tNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(39, 54);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono";
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(785, 50);
            this.tTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(192, 22);
            this.tTelefono.TabIndex = 2;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(347, 54);
            this.lbApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(65, 17);
            this.lbApellidos.TabIndex = 5;
            this.lbApellidos.Text = "Apellidos";
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(435, 47);
            this.tApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(180, 22);
            this.tApellidos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(80, 176);
            this.tListaSocios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.Size = new System.Drawing.Size(897, 235);
            this.tListaSocios.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista Socios";
            // 
            // PracticaTema7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PracticaTema7";
            this.Text = "PracticaTema7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.Label label5;
    }
}

