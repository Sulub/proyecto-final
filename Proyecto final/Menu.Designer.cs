namespace Proyecto_final
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_Empleado = new MetroFramework.Controls.MetroButton();
            this.btn_Cerrar_sesion = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cliente = new MetroFramework.Controls.MetroButton();
            this.btn_Cajones = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Cerrar_sesion);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 502);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroButton3);
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Controls.Add(this.btn_Cajones);
            this.panel2.Controls.Add(this.btn_Cliente);
            this.panel2.Controls.Add(this.btn_Empleado);
            this.panel2.Location = new System.Drawing.Point(1, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 351);
            this.panel2.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(34, 35);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Location = new System.Drawing.Point(24, 21);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(75, 23);
            this.btn_Empleado.TabIndex = 0;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseSelectable = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // btn_Cerrar_sesion
            // 
            this.btn_Cerrar_sesion.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Cerrar_sesion.Location = new System.Drawing.Point(71, 113);
            this.btn_Cerrar_sesion.Name = "btn_Cerrar_sesion";
            this.btn_Cerrar_sesion.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar_sesion.TabIndex = 5;
            this.btn_Cerrar_sesion.Text = "Cerrar sesión";
            this.btn_Cerrar_sesion.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = global::Proyecto_final.Properties.Resources.empleado_011;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Proyecto_final.Properties.Resources.icon_username_52934723;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(24, 61);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_Cliente.TabIndex = 1;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseSelectable = true;
            // 
            // btn_Cajones
            // 
            this.btn_Cajones.Location = new System.Drawing.Point(24, 100);
            this.btn_Cajones.Name = "btn_Cajones";
            this.btn_Cajones.Size = new System.Drawing.Size(75, 23);
            this.btn_Cajones.TabIndex = 2;
            this.btn_Cajones.Text = "Cajones";
            this.btn_Cajones.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(24, 141);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Sucursales";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(24, 185);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Reportes";
            this.metroButton3.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Location = new System.Drawing.Point(174, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 502);
            this.panel3.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(733, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_Cerrar_sesion;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_Cajones;
        private MetroFramework.Controls.MetroButton btn_Cliente;
        private MetroFramework.Controls.MetroButton btn_Empleado;
        private System.Windows.Forms.Panel panel3;
    }
}