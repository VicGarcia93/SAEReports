namespace SAEReports.Vista
{
    partial class ResumeView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProveedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelProveedores, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelClientes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelCompras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelVentas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.label1);
            this.panelVentas.Controls.Add(this.chartVentas);
            this.panelVentas.Location = new System.Drawing.Point(3, 3);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(846, 141);
            this.panelVentas.TabIndex = 0;
            // 
            // panelCompras
            // 
            this.panelCompras.Controls.Add(this.label2);
            this.panelCompras.Controls.Add(this.chartCompras);
            this.panelCompras.Location = new System.Drawing.Point(3, 150);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(846, 141);
            this.panelCompras.TabIndex = 1;
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.label3);
            this.panelClientes.Controls.Add(this.chartClientes);
            this.panelClientes.Location = new System.Drawing.Point(3, 297);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(846, 141);
            this.panelClientes.TabIndex = 2;
            // 
            // panelProveedores
            // 
            this.panelProveedores.Controls.Add(this.label4);
            this.panelProveedores.Controls.Add(this.chartProveedores);
            this.panelProveedores.Location = new System.Drawing.Point(3, 444);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(846, 141);
            this.panelProveedores.TabIndex = 3;
            // 
            // chartVentas
            // 
            chartArea4.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartVentas.Legends.Add(legend4);
            this.chartVentas.Location = new System.Drawing.Point(404, 4);
            this.chartVentas.Name = "chartVentas";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartVentas.Series.Add(series4);
            this.chartVentas.Size = new System.Drawing.Size(429, 136);
            this.chartVentas.TabIndex = 0;
            this.chartVentas.Text = "chart1";
            // 
            // chartCompras
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCompras.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCompras.Legends.Add(legend3);
            this.chartCompras.Location = new System.Drawing.Point(408, 3);
            this.chartCompras.Name = "chartCompras";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCompras.Series.Add(series3);
            this.chartCompras.Size = new System.Drawing.Size(429, 136);
            this.chartCompras.TabIndex = 1;
            this.chartCompras.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compras";
            // 
            // chartClientes
            // 
            chartArea2.Name = "ChartArea1";
            this.chartClientes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartClientes.Legends.Add(legend2);
            this.chartClientes.Location = new System.Drawing.Point(410, 2);
            this.chartClientes.Name = "chartClientes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartClientes.Series.Add(series2);
            this.chartClientes.Size = new System.Drawing.Size(429, 136);
            this.chartClientes.TabIndex = 2;
            this.chartClientes.Text = "chart3";
            // 
            // chartProveedores
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProveedores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProveedores.Legends.Add(legend1);
            this.chartProveedores.Location = new System.Drawing.Point(412, 2);
            this.chartProveedores.Name = "chartProveedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProveedores.Series.Add(series1);
            this.chartProveedores.Size = new System.Drawing.Size(429, 136);
            this.chartProveedores.TabIndex = 3;
            this.chartProveedores.Text = "chart4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proveedores";
            // 
            // ResumeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResumeView";
            this.Text = "ResumeView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProveedores;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClientes;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompras;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
    }
}