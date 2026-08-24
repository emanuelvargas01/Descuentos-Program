namespace Descuentos
{
    partial class Form1
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuentoD = new System.Windows.Forms.Label();
            this.lblDescuentoP = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuentoD = new System.Windows.Forms.TextBox();
            this.txtDescuentoP = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(61, 64);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(77, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta";
            this.lblValorVenta.Click += new System.EventHandler(this.lblValorVenta_Click);
            // 
            // lblDescuentoD
            // 
            this.lblDescuentoD.AutoSize = true;
            this.lblDescuentoD.Location = new System.Drawing.Point(61, 143);
            this.lblDescuentoD.Name = "lblDescuentoD";
            this.lblDescuentoD.Size = new System.Drawing.Size(82, 16);
            this.lblDescuentoD.TabIndex = 1;
            this.lblDescuentoD.Text = "Descuento $";
            this.lblDescuentoD.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescuentoP
            // 
            this.lblDescuentoP.AutoSize = true;
            this.lblDescuentoP.Location = new System.Drawing.Point(61, 230);
            this.lblDescuentoP.Name = "lblDescuentoP";
            this.lblDescuentoP.Size = new System.Drawing.Size(87, 16);
            this.lblDescuentoP.TabIndex = 2;
            this.lblDescuentoP.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(61, 329);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(188, 64);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 4;
            this.txtValorVenta.TextChanged += new System.EventHandler(this.txtValorVenta_TextChanged);
            // 
            // txtDescuentoD
            // 
            this.txtDescuentoD.Location = new System.Drawing.Point(188, 143);
            this.txtDescuentoD.Name = "txtDescuentoD";
            this.txtDescuentoD.ReadOnly = true;
            this.txtDescuentoD.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoD.TabIndex = 5;
            this.txtDescuentoD.TextChanged += new System.EventHandler(this.txtDescuentoD_TextChanged);
            // 
            // txtDescuentoP
            // 
            this.txtDescuentoP.Location = new System.Drawing.Point(188, 224);
            this.txtDescuentoP.Name = "txtDescuentoP";
            this.txtDescuentoP.ReadOnly = true;
            this.txtDescuentoP.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoP.TabIndex = 6;
            this.txtDescuentoP.TextChanged += new System.EventHandler(this.txtDescuentoP_TextChanged);
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(188, 329);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.ReadOnly = true;
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 7;
            this.txtVentaFinal.TextChanged += new System.EventHandler(this.txtVentaFinal_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(373, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(373, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(373, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoP);
            this.Controls.Add(this.txtDescuentoD);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoP);
            this.Controls.Add(this.lblDescuentoD);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Descuentos - Programado por Emanuel Vargas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuentoD;
        private System.Windows.Forms.Label lblDescuentoP;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuentoD;
        private System.Windows.Forms.TextBox txtDescuentoP;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

