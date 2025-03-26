namespace TP1_GRUPO_6
{
    partial class Ejercicio3
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
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.MascBtn = new System.Windows.Forms.RadioButton();
            this.FemBtn = new System.Windows.Forms.RadioButton();
            this.grpEstadoCivil = new System.Windows.Forms.GroupBox();
            this.btnSoltero = new System.Windows.Forms.RadioButton();
            this.btnCasado = new System.Windows.Forms.RadioButton();
            this.checkedOpciones = new System.Windows.Forms.CheckedListBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.frase1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoSexo = new System.Windows.Forms.Label();
            this.resultadoEstCiv = new System.Windows.Forms.Label();
            this.resultadoOficio = new System.Windows.Forms.Label();
            this.grpSexo.SuspendLayout();
            this.grpEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.MascBtn);
            this.grpSexo.Controls.Add(this.FemBtn);
            this.grpSexo.Location = new System.Drawing.Point(17, 12);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(226, 119);
            this.grpSexo.TabIndex = 0;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // MascBtn
            // 
            this.MascBtn.AutoSize = true;
            this.MascBtn.Location = new System.Drawing.Point(26, 67);
            this.MascBtn.Name = "MascBtn";
            this.MascBtn.Size = new System.Drawing.Size(94, 22);
            this.MascBtn.TabIndex = 1;
            this.MascBtn.Text = "Masculino";
            this.MascBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MascBtn.UseVisualStyleBackColor = true;
            // 
            // FemBtn
            // 
            this.FemBtn.AutoSize = true;
            this.FemBtn.Checked = true;
            this.FemBtn.Location = new System.Drawing.Point(26, 38);
            this.FemBtn.Name = "FemBtn";
            this.FemBtn.Size = new System.Drawing.Size(92, 22);
            this.FemBtn.TabIndex = 0;
            this.FemBtn.TabStop = true;
            this.FemBtn.Text = "Femenino";
            this.FemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FemBtn.UseVisualStyleBackColor = true;
            // 
            // grpEstadoCivil
            // 
            this.grpEstadoCivil.Controls.Add(this.btnSoltero);
            this.grpEstadoCivil.Controls.Add(this.btnCasado);
            this.grpEstadoCivil.Location = new System.Drawing.Point(353, 12);
            this.grpEstadoCivil.Name = "grpEstadoCivil";
            this.grpEstadoCivil.Size = new System.Drawing.Size(222, 119);
            this.grpEstadoCivil.TabIndex = 2;
            this.grpEstadoCivil.TabStop = false;
            this.grpEstadoCivil.Text = "Estado Civil";
            // 
            // btnSoltero
            // 
            this.btnSoltero.AutoSize = true;
            this.btnSoltero.Location = new System.Drawing.Point(33, 67);
            this.btnSoltero.Name = "btnSoltero";
            this.btnSoltero.Size = new System.Drawing.Size(74, 22);
            this.btnSoltero.TabIndex = 1;
            this.btnSoltero.Text = "Soltero";
            this.btnSoltero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSoltero.UseVisualStyleBackColor = true;
            // 
            // btnCasado
            // 
            this.btnCasado.AutoSize = true;
            this.btnCasado.Checked = true;
            this.btnCasado.Location = new System.Drawing.Point(33, 38);
            this.btnCasado.Name = "btnCasado";
            this.btnCasado.Size = new System.Drawing.Size(78, 22);
            this.btnCasado.TabIndex = 0;
            this.btnCasado.TabStop = true;
            this.btnCasado.Text = "Casado";
            this.btnCasado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCasado.UseVisualStyleBackColor = true;
            // 
            // checkedOpciones
            // 
            this.checkedOpciones.CheckOnClick = true;
            this.checkedOpciones.FormattingEnabled = true;
            this.checkedOpciones.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkedOpciones.Location = new System.Drawing.Point(187, 147);
            this.checkedOpciones.Name = "checkedOpciones";
            this.checkedOpciones.Size = new System.Drawing.Size(223, 118);
            this.checkedOpciones.TabIndex = 3;
            this.checkedOpciones.SelectedIndexChanged += new System.EventHandler(this.checkedOpciones_SelectedIndexChanged);
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.Window;
            this.mostrar.Location = new System.Drawing.Point(187, 272);
            this.mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(223, 30);
            this.mostrar.TabIndex = 4;
            this.mostrar.Text = "Mostrar lo que se seleccionó";
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frase1
            // 
            this.frase1.AutoSize = true;
            this.frase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frase1.Location = new System.Drawing.Point(35, 316);
            this.frase1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frase1.Name = "frase1";
            this.frase1.Size = new System.Drawing.Size(336, 18);
            this.frase1.TabIndex = 5;
            this.frase1.Text = "Usted seleccionó los siguientes elementos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sexo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado civil :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Oficio :";
            // 
            // resultadoSexo
            // 
            this.resultadoSexo.AutoSize = true;
            this.resultadoSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoSexo.Location = new System.Drawing.Point(91, 335);
            this.resultadoSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoSexo.Name = "resultadoSexo";
            this.resultadoSexo.Size = new System.Drawing.Size(78, 18);
            this.resultadoSexo.TabIndex = 9;
            this.resultadoSexo.Text = "resultado";
            this.resultadoSexo.Visible = false;
            // 
            // resultadoEstCiv
            // 
            this.resultadoEstCiv.AutoSize = true;
            this.resultadoEstCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoEstCiv.Location = new System.Drawing.Point(139, 356);
            this.resultadoEstCiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoEstCiv.Name = "resultadoEstCiv";
            this.resultadoEstCiv.Size = new System.Drawing.Size(78, 18);
            this.resultadoEstCiv.TabIndex = 10;
            this.resultadoEstCiv.Text = "resultado";
            this.resultadoEstCiv.Visible = false;
            // 
            // resultadoOficio
            // 
            this.resultadoOficio.AutoSize = true;
            this.resultadoOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoOficio.Location = new System.Drawing.Point(103, 378);
            this.resultadoOficio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoOficio.Name = "resultadoOficio";
            this.resultadoOficio.Size = new System.Drawing.Size(0, 18);
            this.resultadoOficio.TabIndex = 11;
            this.resultadoOficio.Visible = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.resultadoOficio);
            this.Controls.Add(this.resultadoEstCiv);
            this.Controls.Add(this.resultadoSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frase1);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.checkedOpciones);
            this.Controls.Add(this.grpEstadoCivil);
            this.Controls.Add(this.grpSexo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio3";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpEstadoCivil.ResumeLayout(false);
            this.grpEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton MascBtn;
        private System.Windows.Forms.RadioButton FemBtn;
        private System.Windows.Forms.GroupBox grpEstadoCivil;
        private System.Windows.Forms.RadioButton btnSoltero;
        private System.Windows.Forms.RadioButton btnCasado;
        private System.Windows.Forms.CheckedListBox checkedOpciones;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Label frase1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultadoSexo;
        private System.Windows.Forms.Label resultadoEstCiv;
        private System.Windows.Forms.Label resultadoOficio;
    }
}