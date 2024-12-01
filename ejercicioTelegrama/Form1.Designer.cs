namespace ejercicioTelegrama
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblTextTelegrama = new System.Windows.Forms.Label();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.radioBtnOrdinario = new System.Windows.Forms.RadioButton();
            this.radioBtnUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelegrama.Location = new System.Drawing.Point(64, 126);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(650, 150);
            this.txtTelegrama.TabIndex = 0;
            // 
            // lblTextTelegrama
            // 
            this.lblTextTelegrama.AutoSize = true;
            this.lblTextTelegrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTelegrama.Location = new System.Drawing.Point(59, 84);
            this.lblTextTelegrama.Name = "lblTextTelegrama";
            this.lblTextTelegrama.Size = new System.Drawing.Size(86, 25);
            this.lblTextTelegrama.TabIndex = 1;
            this.lblTextTelegrama.Text = "TEXTO";
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(61, 368);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(76, 25);
            this.lblCoste.TabIndex = 3;
            this.lblCoste.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(143, 363);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 30);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecio.Location = new System.Drawing.Point(561, 337);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(152, 55);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // radioBtnOrdinario
            // 
            this.radioBtnOrdinario.AutoSize = true;
            this.radioBtnOrdinario.Checked = true;
            this.radioBtnOrdinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOrdinario.Location = new System.Drawing.Point(64, 306);
            this.radioBtnOrdinario.Name = "radioBtnOrdinario";
            this.radioBtnOrdinario.Size = new System.Drawing.Size(118, 28);
            this.radioBtnOrdinario.TabIndex = 6;
            this.radioBtnOrdinario.TabStop = true;
            this.radioBtnOrdinario.Text = "Ordinario";
            this.radioBtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioBtnUrgente
            // 
            this.radioBtnUrgente.AutoSize = true;
            this.radioBtnUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUrgente.Location = new System.Drawing.Point(192, 306);
            this.radioBtnUrgente.Name = "radioBtnUrgente";
            this.radioBtnUrgente.Size = new System.Drawing.Size(105, 28);
            this.radioBtnUrgente.TabIndex = 7;
            this.radioBtnUrgente.TabStop = true;
            this.radioBtnUrgente.Text = "Urgente";
            this.radioBtnUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtnUrgente);
            this.Controls.Add(this.radioBtnOrdinario);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblTextTelegrama);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblTextTelegrama;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.RadioButton radioBtnOrdinario;
        private System.Windows.Forms.RadioButton radioBtnUrgente;
    }
}

