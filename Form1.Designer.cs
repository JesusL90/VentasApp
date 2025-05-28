namespace VentasAPP

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;

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

        //<summary>
        ///Método requerido para admitir al diseñador - no se puede modificar
        ///</summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(331, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(302, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(331, 95);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(302, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(331, 150);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(302, 20);
            this.txtStock.TabIndex = 2;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(410, 195);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(139, 46);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "INSERTAR EN DB";
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(450, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "CÓDIGO:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(438, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "DESCRIPCIÓN:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(453, 132);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "STOCK:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProd,
            this.CodigoProd,
            this.DescripcionProd,
            this.StockProd});
            this.dataGridView1.Location = new System.Drawing.Point(261, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 232);
            this.dataGridView1.TabIndex = 7;
            // 
            // IdProd
            // 
            this.IdProd.HeaderText = "IdProd";
            this.IdProd.Name = "IdProd";
            // 
            // CodigoProd
            // 
            this.CodigoProd.HeaderText = "CodigoProd";
            this.CodigoProd.Name = "CodigoProd";
            // 
            // DescripcionProd
            // 
            this.DescripcionProd.HeaderText = "DescripcionProd";
            this.DescripcionProd.Name = "DescripcionProd";
            // 
            // StockProd
            // 
            this.StockProd.HeaderText = "StockProd";
            this.StockProd.Name = "StockProd";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblStock);
            this.Name = "Form1";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProd;
    }
}

