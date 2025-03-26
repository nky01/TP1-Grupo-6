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
            this.FemBtn = new System.Windows.Forms.RadioButton();
            this.MascBtn = new System.Windows.Forms.RadioButton();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.MascBtn);
            this.grpSexo.Controls.Add(this.FemBtn);
            this.grpSexo.Location = new System.Drawing.Point(91, 37);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(197, 129);
            this.grpSexo.TabIndex = 0;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // FemBtn
            // 
            this.FemBtn.AutoSize = true;
            this.FemBtn.Checked = true;
            this.FemBtn.Location = new System.Drawing.Point(26, 46);
            this.FemBtn.Name = "FemBtn";
            this.FemBtn.Size = new System.Drawing.Size(88, 20);
            this.FemBtn.TabIndex = 0;
            this.FemBtn.TabStop = true;
            this.FemBtn.Text = "Femenino";
            this.FemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FemBtn.UseVisualStyleBackColor = true;
            // 
            // MascBtn
            // 
            this.MascBtn.AutoSize = true;
            this.MascBtn.Location = new System.Drawing.Point(26, 72);
            this.MascBtn.Name = "MascBtn";
            this.MascBtn.Size = new System.Drawing.Size(89, 20);
            this.MascBtn.TabIndex = 1;
            this.MascBtn.Text = "Masculino";
            this.MascBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MascBtn.UseVisualStyleBackColor = true;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpSexo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton MascBtn;
        private System.Windows.Forms.RadioButton FemBtn;
    }
}