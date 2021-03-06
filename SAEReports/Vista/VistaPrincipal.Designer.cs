﻿namespace SAEReports.Vista
{
    partial class VistaPrincipal
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnInventarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.presentationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.btnSalir);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.btnResume);
            this.menuPanel.Controls.Add(this.btnProveedores);
            this.menuPanel.Controls.Add(this.btnCompras);
            this.menuPanel.Controls.Add(this.btnInventarios);
            this.menuPanel.Controls.Add(this.btnClientes);
            this.menuPanel.Controls.Add(this.btnVentas);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(274, 634);
            this.menuPanel.TabIndex = 0;
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(11, 227);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(243, 35);
            this.btnResume.TabIndex = 6;
            this.btnResume.Text = "RESUMEN";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(11, 477);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(243, 35);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(11, 427);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(243, 35);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnInventarios
            // 
            this.btnInventarios.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.Location = new System.Drawing.Point(11, 377);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(243, 35);
            this.btnInventarios.TabIndex = 3;
            this.btnInventarios.Text = "INVENTARIOS";
            this.btnInventarios.UseVisualStyleBackColor = true;
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(11, 327);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(243, 35);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(11, 277);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(243, 35);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // presentationPanel
            // 
            this.presentationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presentationPanel.BackColor = System.Drawing.Color.White;
            this.presentationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentationPanel.Location = new System.Drawing.Point(270, 0);
            this.presentationPanel.Name = "presentationPanel";
            this.presentationPanel.Size = new System.Drawing.Size(877, 634);
            this.presentationPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 206);
            this.panel1.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(11, 529);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SAEReports.Properties.Resources.veca_logo;
            this.pbLogo.Location = new System.Drawing.Point(8, -19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(272, 157);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 634);
            this.Controls.Add(this.presentationPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VistaPrincipal";
            this.Text = "VistaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel presentationPanel;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnInventarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}