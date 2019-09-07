namespace PedidosFarmacia
{
    partial class Form2Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMedicamentoSolicitado = new System.Windows.Forms.TextBox();
            this.txtDireccionSolicitada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicamento Solicitado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion de envio :";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(110, 247);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMedicamentoSolicitado
            // 
            this.txtMedicamentoSolicitado.Location = new System.Drawing.Point(12, 54);
            this.txtMedicamentoSolicitado.Multiline = true;
            this.txtMedicamentoSolicitado.Name = "txtMedicamentoSolicitado";
            this.txtMedicamentoSolicitado.Size = new System.Drawing.Size(431, 66);
            this.txtMedicamentoSolicitado.TabIndex = 6;
            this.txtMedicamentoSolicitado.TextChanged += new System.EventHandler(this.txtMedicamentoSolicitado_TextChanged);
            // 
            // txtDireccionSolicitada
            // 
            this.txtDireccionSolicitada.Location = new System.Drawing.Point(12, 153);
            this.txtDireccionSolicitada.Multiline = true;
            this.txtDireccionSolicitada.Name = "txtDireccionSolicitada";
            this.txtDireccionSolicitada.Size = new System.Drawing.Size(431, 66);
            this.txtDireccionSolicitada.TabIndex = 7;
            // 
            // Form2Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 318);
            this.Controls.Add(this.txtDireccionSolicitada);
            this.Controls.Add(this.txtMedicamentoSolicitado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2Pedido";

            Form1 n = new Form1();
            
            this.Text = "Form2Pedido";
            this.Load += new System.EventHandler(this.Form2Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMedicamentoSolicitado;
        private System.Windows.Forms.TextBox txtDireccionSolicitada;
    }
}