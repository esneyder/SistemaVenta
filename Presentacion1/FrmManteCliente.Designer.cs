namespace Presentacion1
{
    partial class FrmManteCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.btnBuscardni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcelu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtdire = new System.Windows.Forms.TextBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActul = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(69, 10);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(115, 20);
            this.txtBuscarDni.TabIndex = 1;
            // 
            // btnBuscardni
            // 
            this.btnBuscardni.Location = new System.Drawing.Point(192, 10);
            this.btnBuscardni.Name = "btnBuscardni";
            this.btnBuscardni.Size = new System.Drawing.Size(75, 20);
            this.btnBuscardni.TabIndex = 2;
            this.btnBuscardni.Text = "BUSCAR";
            this.btnBuscardni.UseVisualStyleBackColor = true;
            this.btnBuscardni.Click += new System.EventHandler(this.btnBuscardni_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // txtcelu
            // 
            this.txtcelu.AutoSize = true;
            this.txtcelu.Location = new System.Drawing.Point(555, 272);
            this.txtcelu.Name = "txtcelu";
            this.txtcelu.Size = new System.Drawing.Size(39, 13);
            this.txtcelu.TabIndex = 8;
            this.txtcelu.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telefono";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(25, 290);
            this.txtdni.MaxLength = 10;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 10;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(131, 290);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(142, 20);
            this.txtnom.TabIndex = 11;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(279, 290);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(142, 20);
            this.txtape.TabIndex = 12;
            // 
            // txtdire
            // 
            this.txtdire.Location = new System.Drawing.Point(430, 289);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(122, 20);
            this.txtdire.TabIndex = 13;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(25, 343);
            this.txttele.MaxLength = 7;
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(122, 20);
            this.txttele.TabIndex = 16;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(192, 343);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 20);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(273, 343);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 20);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "GUARDAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActul
            // 
            this.btnActul.Location = new System.Drawing.Point(354, 343);
            this.btnActul.Name = "btnActul";
            this.btnActul.Size = new System.Drawing.Size(75, 20);
            this.btnActul.TabIndex = 19;
            this.btnActul.Text = "ACTUALIZAR";
            this.btnActul.UseVisualStyleBackColor = true;
            this.btnActul.Click += new System.EventHandler(this.btnActul_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.Location = new System.Drawing.Point(435, 343);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(75, 20);
            this.btnElimi.TabIndex = 20;
            this.btnElimi.Text = "ELIMINAR";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(25, 250);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(558, 288);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(122, 20);
            this.txtCelular.TabIndex = 23;
            // 
            // FrmManteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 384);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnElimi);
            this.Controls.Add(this.btnActul);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtdire);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcelu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscardni);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmManteCliente";
            this.Text = "Mantenimiento Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnBuscardni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtcelu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtdire;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActul;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelular;
    }
}

