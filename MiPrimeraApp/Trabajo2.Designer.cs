namespace MiPrimeraApp
{
    partial class Trabajo2
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
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(47, 31);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 13);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "APELLIDO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(50, 71);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(50, 110);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(37, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "EDAD";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(50, 158);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(66, 13);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "DIRECCION";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxApellido.Location = new System.Drawing.Point(188, 31);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(195, 20);
            this.textBoxApellido.TabIndex = 4;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDireccion.Location = new System.Drawing.Point(188, 158);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(195, 20);
            this.textBoxDireccion.TabIndex = 5;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(188, 110);
            this.textBoxEdad.MaxLength = 40;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(74, 20);
            this.textBoxEdad.TabIndex = 6;
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombre.Location = new System.Drawing.Point(188, 64);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(195, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxResultado.Location = new System.Drawing.Point(53, 231);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(330, 145);
            this.textBoxResultado.TabIndex = 8;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(53, 212);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(73, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "RESULTADO";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(99, 382);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(267, 382);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Trabajo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Name = "Trabajo2";
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Trabajo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}