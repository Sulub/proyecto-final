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
            this.btn_Contractil = new System.Windows.Forms.PictureBox();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Marco_Menu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Contractil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.Marco_Menu.SuspendLayout();
            this.perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_Titulo
            // 
            this.barra_Titulo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.barra_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barra_Titulo.Controls.Add(this.btn_Contractil);
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
            // btn_Contractil
            // 
            this.btn_Contractil.Image = global::Proyecto_final.Properties.Resources.menu;
            this.btn_Contractil.Location = new System.Drawing.Point(-1, 1);
            this.btn_Contractil.Name = "btn_Contractil";
            this.btn_Contractil.Size = new System.Drawing.Size(35, 33);
            this.btn_Contractil.TabIndex = 0;
            this.btn_Contractil.TabStop = false;
            this.btn_Contractil.Click += new System.EventHandler(this.btn_Contractil_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Image = global::Proyecto_final.Properties.Resources.res;
            this.btn_Restaurar.Location = new System.Drawing.Point(1230, 4);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 3;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.Image = global::Proyecto_final.Properties.Resources.minimazar;
            this.btn_Minimizar.Location = new System.Drawing.Point(1194, 4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(25, 25);
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
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = global::Proyecto_final.Properties.Resources.cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(1270, 4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Marco_Menu
            // 
            this.Marco_Menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Marco_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marco_Menu.Controls.Add(this.panel4);
            this.Marco_Menu.Controls.Add(this.panel2);
            this.Marco_Menu.Controls.Add(this.panel3);
            this.Marco_Menu.Controls.Add(this.button3);
            this.Marco_Menu.Controls.Add(this.button2);
            this.Marco_Menu.Controls.Add(this.button1);
            this.Marco_Menu.Controls.Add(this.perfil);
            this.Marco_Menu.Controls.Add(this.panel1);
            this.Marco_Menu.Controls.Add(this.btn_Empleado);
            this.Marco_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Marco_Menu.Location = new System.Drawing.Point(0, 35);
            this.Marco_Menu.Name = "Marco_Menu";
            this.Marco_Menu.Size = new System.Drawing.Size(220, 615);
            this.Marco_Menu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(7, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(7, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(7, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cliente";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Empleado";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cajones";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.perfil.Controls.Add(this.label1);
            this.perfil.Controls.Add(this.btn_Salir);
            this.perfil.Controls.Add(this.usuario);
            this.perfil.Location = new System.Drawing.Point(0, 1);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(218, 131);
            this.perfil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(138, 27);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // usuario
            // 
            this.usuario.Image = global::Proyecto_final.Properties.Resources.hombre;
            this.usuario.Location = new System.Drawing.Point(7, 4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(125, 84);
            this.usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usuario.TabIndex = 0;
            this.usuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(7, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Empleado.FlatAppearance.BorderSize = 0;
            this.btn_Empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btn_Empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleado.Image = global::Proyecto_final.Properties.Resources.empresario__1_;
            this.btn_Empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleado.Location = new System.Drawing.Point(7, 150);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(212, 29);
            this.btn_Empleado.TabIndex = 1;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = false;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(220, 35);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1080, 615);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_Contractil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.Marco_Menu.ResumeLayout(false);
            this.perfil.ResumeLayout(false);
            this.perfil.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel perfil;
        private System.Windows.Forms.PictureBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox btn_Contractil;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}