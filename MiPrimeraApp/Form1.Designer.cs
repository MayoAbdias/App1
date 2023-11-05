namespace MiPrimeraApp
{
    partial class MiApp
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
            this.buttonHolaMundo = new System.Windows.Forms.Button();
            this.labelMiApp = new System.Windows.Forms.Label();
            this.textBoxMiApli = new System.Windows.Forms.TextBox();
            this.textBoxMiapli2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonHolaMundo
            // 
            this.buttonHolaMundo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHolaMundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHolaMundo.Location = new System.Drawing.Point(296, 153);
            this.buttonHolaMundo.Name = "buttonHolaMundo";
            this.buttonHolaMundo.Size = new System.Drawing.Size(158, 64);
            this.buttonHolaMundo.TabIndex = 0;
            this.buttonHolaMundo.Text = "Hola Mundo";
            this.buttonHolaMundo.UseVisualStyleBackColor = false;
            this.buttonHolaMundo.Click += new System.EventHandler(this.buttonHolaMundo_Click);
            this.buttonHolaMundo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonHolaMundo_MouseMove);
            // 
            // labelMiApp
            // 
            this.labelMiApp.AutoSize = true;
            this.labelMiApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMiApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiApp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMiApp.Location = new System.Drawing.Point(48, 9);
            this.labelMiApp.Name = "labelMiApp";
            this.labelMiApp.Size = new System.Drawing.Size(230, 27);
            this.labelMiApp.TabIndex = 1;
            this.labelMiApp.Text = "Bienvenido a mi App";
            this.labelMiApp.MouseLeave += new System.EventHandler(this.labelMiApp_MouseLeave);
            this.labelMiApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMiApp_MouseMove);
            // 
            // textBoxMiApli
            // 
            this.textBoxMiApli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMiApli.Location = new System.Drawing.Point(278, 59);
            this.textBoxMiApli.MaxLength = 100;
            this.textBoxMiApli.Name = "textBoxMiApli";
            this.textBoxMiApli.Size = new System.Drawing.Size(176, 20);
            this.textBoxMiApli.TabIndex = 2;
            this.textBoxMiApli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiApli_KeyPress);
            // 
            // textBoxMiapli2
            // 
            this.textBoxMiapli2.Location = new System.Drawing.Point(278, 85);
            this.textBoxMiapli2.Multiline = true;
            this.textBoxMiapli2.Name = "textBoxMiapli2";
            this.textBoxMiapli2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMiapli2.Size = new System.Drawing.Size(176, 62);
            this.textBoxMiapli2.TabIndex = 3;
            this.textBoxMiapli2.Leave += new System.EventHandler(this.textBoxMiapli2_Leave);
            // 
            // MiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMiapli2);
            this.Controls.Add(this.textBoxMiApli);
            this.Controls.Add(this.labelMiApp);
            this.Controls.Add(this.buttonHolaMundo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiApp_FormClosed);
            this.Load += new System.EventHandler(this.MiApp_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MiApp_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHolaMundo;
        private System.Windows.Forms.Label labelMiApp;
        private System.Windows.Forms.TextBox textBoxMiApli;
        private System.Windows.Forms.TextBox textBoxMiapli2;
    }
}

