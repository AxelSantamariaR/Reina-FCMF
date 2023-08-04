namespace Capa_Presentacion.VistaGestor
{
    partial class InicioGestor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnResultados = new System.Windows.Forms.PictureBox();
            this.btnAlbum = new System.Windows.Forms.PictureBox();
            this.btnInscripciones = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(5)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "   Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Capa_Presentacion.Properties.Resources.CerrarSesion;
            this.btnCerrar.Location = new System.Drawing.Point(87, 544);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.Transparent;
            this.btnResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultados.Image = global::Capa_Presentacion.Properties.Resources.Gestor_Resultado;
            this.btnResultados.Location = new System.Drawing.Point(13, 342);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(189, 61);
            this.btnResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResultados.TabIndex = 9;
            this.btnResultados.TabStop = false;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            this.btnResultados.MouseEnter += new System.EventHandler(this.btnResultados_MouseEnter);
            this.btnResultados.MouseLeave += new System.EventHandler(this.btnResultados_MouseLeave);
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.Image = global::Capa_Presentacion.Properties.Resources.Gestor_Album;
            this.btnAlbum.Location = new System.Drawing.Point(13, 215);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(189, 61);
            this.btnAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAlbum.TabIndex = 8;
            this.btnAlbum.TabStop = false;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            this.btnAlbum.MouseEnter += new System.EventHandler(this.btnAsesores_MouseEnter);
            this.btnAlbum.MouseLeave += new System.EventHandler(this.btnAsesores_MouseLeave);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.BackColor = System.Drawing.Color.Transparent;
            this.btnInscripciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscripciones.Image = global::Capa_Presentacion.Properties.Resources.Gestor_Inscri;
            this.btnInscripciones.Location = new System.Drawing.Point(13, 82);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(189, 61);
            this.btnInscripciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInscripciones.TabIndex = 7;
            this.btnInscripciones.TabStop = false;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            this.btnInscripciones.MouseEnter += new System.EventHandler(this.btnInscripciones_MouseEnter);
            this.btnInscripciones.MouseLeave += new System.EventHandler(this.btnInscripciones_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.Fondo_Lateral_Inicio_Gestor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(216, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(725, 581);
            this.panelContenedor.TabIndex = 11;
            // 
            // InicioGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 619);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnInscripciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InicioGestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioGestor_FormClosing);
            this.Load += new System.EventHandler(this.InicioGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnResultados;
        private System.Windows.Forms.PictureBox btnAlbum;
        private System.Windows.Forms.PictureBox btnInscripciones;
        private System.Windows.Forms.Panel panelContenedor;
    }
}