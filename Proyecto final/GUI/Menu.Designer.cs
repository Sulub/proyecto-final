﻿namespace Proyecto_final
{
    partial class Menu
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
            this.barra_Titulo = new System.Windows.Forms.Panel();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Marco_Menu = new System.Windows.Forms.Panel();
            this.btn_Estacionamiento = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Panel();
            this.usuario = new System.Windows.Forms.PictureBox();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.Marco_Menu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_Titulo
            // 
            this.barra_Titulo.BackColor = System.Drawing.Color.Navy;
            this.barra_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barra_Titulo.Controls.Add(this.btn_Restaurar);
            this.barra_Titulo.Controls.Add(this.btn_Minimizar);
            this.barra_Titulo.Controls.Add(this.btn_Maximizar);
            this.barra_Titulo.Controls.Add(this.btn_Cerrar);
            this.barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.barra_Titulo.Name = "barra_Titulo";
            this.barra_Titulo.Size = new System.Drawing.Size(1300, 35);
            this.barra_Titulo.TabIndex = 0;
            this.barra_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barra_Titulo_Paint);
            this.barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_Titulo_MouseDown);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Restaurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Restaurar.Image = global::Proyecto_final.Properties.Resources.res;
            this.btn_Restaurar.Location = new System.Drawing.Point(1225, 4);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(39, 26);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 3;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Minimizar.Image = global::Proyecto_final.Properties.Resources.minimazar;
            this.btn_Minimizar.Location = new System.Drawing.Point(1185, 4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(34, 26);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Maximizar.Image = global::Proyecto_final.Properties.Resources.maxi;
            this.btn_Maximizar.Location = new System.Drawing.Point(1230, 4);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(25, 25);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Maximizar.TabIndex = 1;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = global::Proyecto_final.Properties.Resources.cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(1266, 4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(29, 26);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Marco_Menu
            // 
            this.Marco_Menu.BackColor = System.Drawing.Color.Navy;
            this.Marco_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marco_Menu.Controls.Add(this.btn_Estacionamiento);
            this.Marco_Menu.Controls.Add(this.btn_Cliente);
            this.Marco_Menu.Controls.Add(this.btn_Empleado);
            this.Marco_Menu.Controls.Add(this.button1);
            this.Marco_Menu.Controls.Add(this.btn_Salir);
            this.Marco_Menu.Controls.Add(this.panel5);
            this.Marco_Menu.Controls.Add(this.perfil);
            this.Marco_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Marco_Menu.Location = new System.Drawing.Point(0, 35);
            this.Marco_Menu.Name = "Marco_Menu";
            this.Marco_Menu.Size = new System.Drawing.Size(247, 615);
            this.Marco_Menu.TabIndex = 1;
            this.Marco_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Marco_Menu_Paint);
            // 
            // btn_Estacionamiento
            // 
            this.btn_Estacionamiento.BackColor = System.Drawing.Color.Navy;
            this.btn_Estacionamiento.FlatAppearance.BorderSize = 0;
            this.btn_Estacionamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btn_Estacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Estacionamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estacionamiento.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estacionamiento.ForeColor = System.Drawing.Color.White;
            this.btn_Estacionamiento.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.btn_Estacionamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estacionamiento.Location = new System.Drawing.Point(4, 196);
            this.btn_Estacionamiento.Name = "btn_Estacionamiento";
            this.btn_Estacionamiento.Size = new System.Drawing.Size(232, 51);
            this.btn_Estacionamiento.TabIndex = 5;
            this.btn_Estacionamiento.Text = "Estacionamiento";
            this.btn_Estacionamiento.UseVisualStyleBackColor = false;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Navy;
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btn_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.ForeColor = System.Drawing.Color.White;
            this.btn_Cliente.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cliente.Location = new System.Drawing.Point(4, 367);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(232, 51);
            this.btn_Cliente.TabIndex = 6;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = false;
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.BackColor = System.Drawing.Color.Navy;
            this.btn_Empleado.FlatAppearance.BorderSize = 0;
            this.btn_Empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btn_Empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleado.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Empleado.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.btn_Empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleado.Location = new System.Drawing.Point(4, 253);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(232, 51);
            this.btn_Empleado.TabIndex = 1;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = false;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cajones";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.btn_Salir.Location = new System.Drawing.Point(63, 554);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(112, 39);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(38, 424);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 111);
            this.panel5.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Pensionado";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "Esporadico";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.Navy;
            this.perfil.Controls.Add(this.usuario);
            this.perfil.ForeColor = System.Drawing.Color.White;
            this.perfil.Location = new System.Drawing.Point(24, -1);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(192, 191);
            this.perfil.TabIndex = 3;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.Lavender;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usuario.Image = global::Proyecto_final.Properties.Resources.hombre;
            this.usuario.Location = new System.Drawing.Point(0, 0);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(193, 191);
            this.usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usuario.TabIndex = 0;
            this.usuario.TabStop = false;
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.MintCream;
            this.Panel_Contenedor.BackgroundImage = global::Proyecto_final.Properties.Resources.ddd2f89dd03c4698f1af4f26fb6b01e4;
            this.Panel_Contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(247, 35);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1053, 615);
            this.Panel_Contenedor.TabIndex = 2;
            this.Panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Contenedor_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.Marco_Menu);
            this.Controls.Add(this.barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.Marco_Menu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra_Titulo;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel Marco_Menu;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.Panel perfil;
        private System.Windows.Forms.PictureBox usuario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Estacionamiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}