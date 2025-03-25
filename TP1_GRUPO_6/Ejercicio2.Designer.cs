namespace TP1_GRUPO_6
{
    partial class Ejercicio2
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.groupBoxAgregar = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.groupBoxAgregar.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelNombre.Location = new System.Drawing.Point(6, 166);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(91, 24);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelApellido.Location = new System.Drawing.Point(6, 206);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(93, 24);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // groupBoxAgregar
            // 
            this.groupBoxAgregar.Controls.Add(this.buttonAgregar);
            this.groupBoxAgregar.Controls.Add(this.textBoxApellido);
            this.groupBoxAgregar.Controls.Add(this.textBoxNombre);
            this.groupBoxAgregar.Controls.Add(this.labelNombre);
            this.groupBoxAgregar.Controls.Add(this.labelApellido);
            this.groupBoxAgregar.Location = new System.Drawing.Point(33, 12);
            this.groupBoxAgregar.Name = "groupBoxAgregar";
            this.groupBoxAgregar.Size = new System.Drawing.Size(341, 426);
            this.groupBoxAgregar.TabIndex = 2;
            this.groupBoxAgregar.TabStop = false;
            this.groupBoxAgregar.Text = "Ingreso de Datos";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 167);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(158, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(104, 206);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(156, 22);
            this.textBoxApellido.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(104, 277);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(158, 47);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.buttonBorrar);
            this.groupBoxLista.Controls.Add(this.listBoxNombres);
            this.groupBoxLista.Location = new System.Drawing.Point(414, 12);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(341, 426);
            this.groupBoxLista.TabIndex = 3;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Elementos";
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.ItemHeight = 16;
            this.listBoxNombres.Location = new System.Drawing.Point(7, 22);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(328, 324);
            this.listBoxNombres.TabIndex = 0;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(105, 364);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(150, 42);
            this.buttonBorrar.TabIndex = 1;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxAgregar);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio2_FormClosed);
            this.groupBoxAgregar.ResumeLayout(false);
            this.groupBoxAgregar.PerformLayout();
            this.groupBoxLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.GroupBox groupBoxAgregar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.ListBox listBoxNombres;
    }
}