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
            this.grpSexo.SuspendLayout();
            this.grpEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.MascBtn);
            this.grpSexo.Controls.Add(this.FemBtn);
            this.grpSexo.Location = new System.Drawing.Point(68, 30);
            this.grpSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSexo.Size = new System.Drawing.Size(148, 105);
            this.grpSexo.TabIndex = 0;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // MascBtn
            // 
            this.MascBtn.AutoSize = true;
            this.MascBtn.Location = new System.Drawing.Point(20, 58);
            this.MascBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MascBtn.Name = "MascBtn";
            this.MascBtn.Size = new System.Drawing.Size(73, 17);
            this.MascBtn.TabIndex = 1;
            this.MascBtn.Text = "Masculino";
            this.MascBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MascBtn.UseVisualStyleBackColor = true;
            // 
            // FemBtn
            // 
            this.FemBtn.AutoSize = true;
            this.FemBtn.Checked = true;
            this.FemBtn.Location = new System.Drawing.Point(20, 37);
            this.FemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FemBtn.Name = "FemBtn";
            this.FemBtn.Size = new System.Drawing.Size(71, 17);
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
            this.grpEstadoCivil.Location = new System.Drawing.Point(510, 30);
            this.grpEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.grpEstadoCivil.Name = "grpEstadoCivil";
            this.grpEstadoCivil.Padding = new System.Windows.Forms.Padding(2);
            this.grpEstadoCivil.Size = new System.Drawing.Size(148, 105);
            this.grpEstadoCivil.TabIndex = 2;
            this.grpEstadoCivil.TabStop = false;
            this.grpEstadoCivil.Text = "Estado Civil";
            // 
            // btnSoltero
            // 
            this.btnSoltero.AutoSize = true;
            this.btnSoltero.Location = new System.Drawing.Point(20, 58);
            this.btnSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoltero.Name = "btnSoltero";
            this.btnSoltero.Size = new System.Drawing.Size(58, 17);
            this.btnSoltero.TabIndex = 1;
            this.btnSoltero.Text = "Soltero";
            this.btnSoltero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSoltero.UseVisualStyleBackColor = true;
            // 
            // btnCasado
            // 
            this.btnCasado.AutoSize = true;
            this.btnCasado.Checked = true;
            this.btnCasado.Location = new System.Drawing.Point(20, 37);
            this.btnCasado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCasado.Name = "btnCasado";
            this.btnCasado.Size = new System.Drawing.Size(61, 17);
            this.btnCasado.TabIndex = 0;
            this.btnCasado.TabStop = true;
            this.btnCasado.Text = "Casado";
            this.btnCasado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCasado.UseVisualStyleBackColor = true;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEstadoCivil);
            this.Controls.Add(this.grpSexo);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpEstadoCivil.ResumeLayout(false);
            this.grpEstadoCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton MascBtn;
        private System.Windows.Forms.RadioButton FemBtn;
        private System.Windows.Forms.GroupBox grpEstadoCivil;
        private System.Windows.Forms.RadioButton btnSoltero;
        private System.Windows.Forms.RadioButton btnCasado;
    }
}