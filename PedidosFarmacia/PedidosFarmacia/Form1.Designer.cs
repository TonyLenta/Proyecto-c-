namespace PedidosFarmacia
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreMedicamento = new System.Windows.Forms.Label();
            this.lblTipoMedicamento = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSucursalFarmacia = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.rdbCofarma = new System.Windows.Forms.RadioButton();
            this.rdbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rdbCemefar = new System.Windows.Forms.RadioButton();
            this.chckbPrincipal = new System.Windows.Forms.CheckBox();
            this.chkbSecunadria = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(296, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Realizar un nuevo pedido al provedor";
            // 
            // lblNombreMedicamento
            // 
            this.lblNombreMedicamento.AutoSize = true;
            this.lblNombreMedicamento.Location = new System.Drawing.Point(84, 81);
            this.lblNombreMedicamento.Name = "lblNombreMedicamento";
            this.lblNombreMedicamento.Size = new System.Drawing.Size(127, 13);
            this.lblNombreMedicamento.TabIndex = 1;
            this.lblNombreMedicamento.Text = "Nombre del medicamento";
            // 
            // lblTipoMedicamento
            // 
            this.lblTipoMedicamento.AutoSize = true;
            this.lblTipoMedicamento.Location = new System.Drawing.Point(84, 121);
            this.lblTipoMedicamento.Name = "lblTipoMedicamento";
            this.lblTipoMedicamento.Size = new System.Drawing.Size(109, 13);
            this.lblTipoMedicamento.TabIndex = 2;
            this.lblTipoMedicamento.Text = "Tipo de medicamento";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(84, 159);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(109, 13);
            this.lblCantidadProducto.TabIndex = 3;
            this.lblCantidadProducto.Text = "Cantidad de producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selecione distribuidor farmaceutico";
            // 
            // lblSucursalFarmacia
            // 
            this.lblSucursalFarmacia.AutoSize = true;
            this.lblSucursalFarmacia.Location = new System.Drawing.Point(84, 297);
            this.lblSucursalFarmacia.Name = "lblSucursalFarmacia";
            this.lblSucursalFarmacia.Size = new System.Drawing.Size(106, 13);
            this.lblSucursalFarmacia.TabIndex = 5;
            this.lblSucursalFarmacia.Text = "Sucursal de farmacia";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(360, 81);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(120, 20);
            this.txtNombreMedicamento.TabIndex = 6;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(360, 159);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadProducto.TabIndex = 7;
            
            // 
            // rdbCofarma
            // 
            this.rdbCofarma.AutoSize = true;
            this.rdbCofarma.Checked = true;
            this.rdbCofarma.Location = new System.Drawing.Point(360, 213);
            this.rdbCofarma.Name = "rdbCofarma";
            this.rdbCofarma.Size = new System.Drawing.Size(64, 17);
            this.rdbCofarma.TabIndex = 8;
            this.rdbCofarma.TabStop = true;
            this.rdbCofarma.Text = "Cofarma";
            this.rdbCofarma.UseVisualStyleBackColor = true;
            // 
            // rdbEmpsephar
            // 
            this.rdbEmpsephar.AutoSize = true;
            this.rdbEmpsephar.Location = new System.Drawing.Point(360, 236);
            this.rdbEmpsephar.Name = "rdbEmpsephar";
            this.rdbEmpsephar.Size = new System.Drawing.Size(78, 17);
            this.rdbEmpsephar.TabIndex = 9;
            this.rdbEmpsephar.TabStop = true;
            this.rdbEmpsephar.Text = "Empsephar";
            this.rdbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rdbCemefar
            // 
            this.rdbCemefar.AutoSize = true;
            this.rdbCemefar.Location = new System.Drawing.Point(360, 259);
            this.rdbCemefar.Name = "rdbCemefar";
            this.rdbCemefar.Size = new System.Drawing.Size(64, 17);
            this.rdbCemefar.TabIndex = 10;
            this.rdbCemefar.TabStop = true;
            this.rdbCemefar.Text = "Cemefar";
            this.rdbCemefar.UseVisualStyleBackColor = true;
            // 
            // chckbPrincipal
            // 
            this.chckbPrincipal.AutoSize = true;
            this.chckbPrincipal.Location = new System.Drawing.Point(360, 297);
            this.chckbPrincipal.Name = "chckbPrincipal";
            this.chckbPrincipal.Size = new System.Drawing.Size(66, 17);
            this.chckbPrincipal.TabIndex = 12;
            this.chckbPrincipal.Text = "Principal";
            this.chckbPrincipal.UseVisualStyleBackColor = true;
            // 
            // chkbSecunadria
            // 
            this.chkbSecunadria.AutoSize = true;
            this.chkbSecunadria.Location = new System.Drawing.Point(360, 320);
            this.chkbSecunadria.Name = "chkbSecunadria";
            this.chkbSecunadria.Size = new System.Drawing.Size(80, 17);
            this.chkbSecunadria.TabIndex = 13;
            this.chkbSecunadria.Text = "Secundaria";
            this.chkbSecunadria.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(210, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(360, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoMedicamento
            // 
            this.cmbTipoMedicamento.FormattingEnabled = true;
            this.cmbTipoMedicamento.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibióticos"});
            this.cmbTipoMedicamento.Location = new System.Drawing.Point(359, 121);
            this.cmbTipoMedicamento.Name = "cmbTipoMedicamento";
            this.cmbTipoMedicamento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMedicamento.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipoMedicamento);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkbSecunadria);
            this.Controls.Add(this.chckbPrincipal);
            this.Controls.Add(this.rdbCemefar);
            this.Controls.Add(this.rdbEmpsephar);
            this.Controls.Add(this.rdbCofarma);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.lblSucursalFarmacia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCantidadProducto);
            this.Controls.Add(this.lblTipoMedicamento);
            this.Controls.Add(this.lblNombreMedicamento);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreMedicamento;
        private System.Windows.Forms.Label lblTipoMedicamento;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSucursalFarmacia;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.RadioButton rdbCofarma;
        private System.Windows.Forms.RadioButton rdbEmpsephar;
        private System.Windows.Forms.RadioButton rdbCemefar;
        private System.Windows.Forms.CheckBox chckbPrincipal;
        private System.Windows.Forms.CheckBox chkbSecunadria;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbTipoMedicamento;
    }
}

