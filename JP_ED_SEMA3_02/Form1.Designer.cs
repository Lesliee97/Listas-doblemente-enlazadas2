namespace JP_ED_SEMA3_02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContarDes = new System.Windows.Forms.Label();
            this.lblContar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buscando = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnContar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lista});
            this.dgvLista.Location = new System.Drawing.Point(30, 200);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(408, 176);
            this.dgvLista.TabIndex = 0;
            // 
            // Lista
            // 
            this.Lista.HeaderText = "Lista";
            this.Lista.Name = "Lista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insertar Elemento de la lista";
            // 
            // lblContarDes
            // 
            this.lblContarDes.AutoSize = true;
            this.lblContarDes.Location = new System.Drawing.Point(46, 103);
            this.lblContarDes.Name = "lblContarDes";
            this.lblContarDes.Size = new System.Drawing.Size(43, 13);
            this.lblContarDes.TabIndex = 2;
            this.lblContarDes.Text = "............";
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Location = new System.Drawing.Point(43, 129);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(43, 13);
            this.lblContar.TabIndex = 3;
            this.lblContar.Text = "............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contando nodos";
            // 
            // buscando
            // 
            this.buscando.AutoSize = true;
            this.buscando.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscando.Location = new System.Drawing.Point(497, 145);
            this.buscando.Name = "buscando";
            this.buscando.Size = new System.Drawing.Size(122, 17);
            this.buscando.TabIndex = 5;
            this.buscando.Text = "Buscando dato...";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(585, 84);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 32);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "MOSTRAR TABLA";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(500, 200);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 7;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(500, 239);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(75, 23);
            this.BtnContar.TabIndex = 8;
            this.BtnContar.Text = "CONTAR";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(638, 143);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(500, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(648, 200);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "MOSTRAR";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(648, 239);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSiguiente.Location = new System.Drawing.Point(535, 279);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(132, 34);
            this.BtnSiguiente.TabIndex = 13;
            this.BtnSiguiente.Text = "SIGUIENTE LISTA";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(412, 41);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 14;
            this.txtnumero.Text = "(Número)";
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(623, 356);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(100, 20);
            this.txtdatos.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(476, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 70);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnContar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.buscando);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblContar);
            this.Controls.Add(this.lblContarDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContarDes;
        private System.Windows.Forms.Label lblContar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buscando;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumero;
    }
}

