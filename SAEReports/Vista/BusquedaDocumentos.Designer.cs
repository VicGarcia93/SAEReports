namespace SAEReports.Vista
{
    partial class BusquedaDocumentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBuscarDoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBuscarDoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarDoc = new System.Windows.Forms.Button();
            this.txtBuscarDoc = new System.Windows.Forms.TextBox();
            this.btnCerrarBusquedaDocumentos = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarDoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBuscarDoc);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 253);
            this.panel1.TabIndex = 0;
            // 
            // dgvBuscarDoc
            // 
            this.dgvBuscarDoc.AllowUserToAddRows = false;
            this.dgvBuscarDoc.AllowUserToDeleteRows = false;
            this.dgvBuscarDoc.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvBuscarDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarDoc.Location = new System.Drawing.Point(3, 3);
            this.dgvBuscarDoc.Name = "dgvBuscarDoc";
            this.dgvBuscarDoc.ReadOnly = true;
            this.dgvBuscarDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvBuscarDoc.Size = new System.Drawing.Size(776, 250);
            this.dgvBuscarDoc.TabIndex = 0;
            this.dgvBuscarDoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarDoc_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbBuscarDoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBuscarDoc);
            this.panel2.Controls.Add(this.txtBuscarDoc);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 46);
            this.panel2.TabIndex = 1;
            // 
            // cmbBuscarDoc
            // 
            this.cmbBuscarDoc.FormattingEnabled = true;
            this.cmbBuscarDoc.Items.AddRange(new object[] {
            "Todo",
            "Clave",
            "Cliente",
            "Fecha de elaboración",
            "Importe",
            "Almacén",
            "",
            ""});
            this.cmbBuscarDoc.Location = new System.Drawing.Point(356, 10);
            this.cmbBuscarDoc.Name = "cmbBuscarDoc";
            this.cmbBuscarDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarDoc.TabIndex = 3;
            this.cmbBuscarDoc.Text = "Todo";
            this.cmbBuscarDoc.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarDoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por:";
            // 
            // btnBuscarDoc
            // 
            this.btnBuscarDoc.Location = new System.Drawing.Point(658, 10);
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarDoc.TabIndex = 1;
            this.btnBuscarDoc.Text = "Buscar";
            this.btnBuscarDoc.UseVisualStyleBackColor = true;
            this.btnBuscarDoc.Click += new System.EventHandler(this.btnBuscarDoc_Click);
            // 
            // txtBuscarDoc
            // 
            this.txtBuscarDoc.Location = new System.Drawing.Point(492, 10);
            this.txtBuscarDoc.Name = "txtBuscarDoc";
            this.txtBuscarDoc.Size = new System.Drawing.Size(151, 20);
            this.txtBuscarDoc.TabIndex = 0;
            this.txtBuscarDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCerrarBusquedaDocumentos
            // 
            this.btnCerrarBusquedaDocumentos.Location = new System.Drawing.Point(720, 12);
            this.btnCerrarBusquedaDocumentos.Name = "btnCerrarBusquedaDocumentos";
            this.btnCerrarBusquedaDocumentos.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarBusquedaDocumentos.TabIndex = 2;
            this.btnCerrarBusquedaDocumentos.Text = "Cerrar";
            this.btnCerrarBusquedaDocumentos.UseVisualStyleBackColor = true;
            this.btnCerrarBusquedaDocumentos.Click += new System.EventHandler(this.btnCerrarBusquedaDocumentos_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(492, 11);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Visible = false;
            // 
            // BusquedaDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 378);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarBusquedaDocumentos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "BusquedaDocumentos";
            this.Text = "BusquedaDocumentos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarDoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBuscarDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarDoc;
        private System.Windows.Forms.TextBox txtBuscarDoc;
        private System.Windows.Forms.DataGridView dgvBuscarDoc;
        private System.Windows.Forms.Button btnCerrarBusquedaDocumentos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}