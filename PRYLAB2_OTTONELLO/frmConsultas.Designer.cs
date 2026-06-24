namespace PRYLAB2_OTTONELLO
{
    partial class frmConsultas
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
            this.lblRubro = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lnkDatos = new System.Windows.Forms.LinkLabel();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument(); // CORREGIDO
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(29, 38);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(57, 20);
            this.lblRubro.TabIndex = 0;
            this.lblRubro.Text = "Rubro:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Stock,
            this.ValorStock});
            this.dgvDatos.Location = new System.Drawing.Point(33, 76);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(816, 198);
            this.dgvDatos.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 8;
            this.Costo.Name = "Costo";
            this.Costo.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.Width = 150;
            // 
            // ValorStock
            // 
            this.ValorStock.HeaderText = "Valor de Stock";
            this.ValorStock.MinimumWidth = 8;
            this.ValorStock.Name = "ValorStock";
            this.ValorStock.Width = 150;
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(92, 30);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(190, 28);
            this.cmbRubro.TabIndex = 2;
            this.cmbRubro.SelectedIndexChanged += new System.EventHandler(this.cmbRubro_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(506, 304);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(164, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de Articulos:";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(552, 356);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(118, 20);
            this.lblTotalStock.TabIndex = 4;
            this.lblTotalStock.Text = "Total del Stock:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(716, 344);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 32);
            this.lblTotal.TabIndex = 9;
            // 
            // lblCant
            // 
            this.lblCant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(716, 289);
            this.lblCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(102, 32);
            this.lblCant.TabIndex = 8;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(71, 299);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(195, 20);
            this.lblDatos.TabIndex = 10;
            this.lblDatos.Text = "Datos de la desarrolladora";
            // 
            // lnkDatos
            // 
            this.lnkDatos.AutoSize = true;
            this.lnkDatos.Location = new System.Drawing.Point(110, 327);
            this.lnkDatos.Name = "lnkDatos";
            this.lnkDatos.Size = new System.Drawing.Size(127, 20);
            this.lnkDatos.TabIndex = 11;
            this.lnkDatos.TabStop = true;
            this.lnkDatos.Text = "Más Información";
            this.lnkDatos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDatos_LinkClicked);
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage); // CORREGIDO
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(146, 455);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(136, 42);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(362, 455);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(136, 42);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(578, 455);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 42);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 569);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lnkDatos);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblTotalStock);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblRubro);
            this.Name = "frmConsultas";
            this.Text = "CONSULTA DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorStock;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.LinkLabel lnkDatos;
        private System.Drawing.Printing.PrintDocument prtDocumento; 
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnMostrar;
    }
}