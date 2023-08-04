namespace Capa_Presentacion.VistaAdministracion
{
    partial class InicioAdministracion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEstudiantes = new System.Windows.Forms.PictureBox();
            this.btnAsesores = new System.Windows.Forms.PictureBox();
            this.btnAdministradores = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdministradores)).BeginInit();
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
            this.label1.TabIndex = 4;
            this.label1.Text = "   Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(216, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 412);
            this.panel1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Capa_Presentacion.Properties.Resources.Administrador_Boton_Agregar;
            this.btnAgregar.Location = new System.Drawing.Point(562, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 43);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(5)))), ((int)(((byte)(114)))));
            this.lbTitle.Location = new System.Drawing.Point(22, 36);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(167, 25);
            this.lbTitle.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(5)))), ((int)(((byte)(114)))));
            this.dataGridView1.Location = new System.Drawing.Point(26, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(673, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Capa_Presentacion.Properties.Resources.CerrarSesion;
            this.btnCerrar.Location = new System.Drawing.Point(86, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiantes.Image = global::Capa_Presentacion.Properties.Resources.Administrador_Estudiante;
            this.btnEstudiantes.Location = new System.Drawing.Point(12, 314);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(189, 61);
            this.btnEstudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEstudiantes.TabIndex = 3;
            this.btnEstudiantes.TabStop = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            this.btnEstudiantes.MouseEnter += new System.EventHandler(this.btnEstudiantes_MouseEnter);
            this.btnEstudiantes.MouseLeave += new System.EventHandler(this.btnEstudiantes_MouseLeave);
            // 
            // btnAsesores
            // 
            this.btnAsesores.BackColor = System.Drawing.Color.Transparent;
            this.btnAsesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsesores.Image = global::Capa_Presentacion.Properties.Resources.Administrador_Gestor;
            this.btnAsesores.Location = new System.Drawing.Point(12, 209);
            this.btnAsesores.Name = "btnAsesores";
            this.btnAsesores.Size = new System.Drawing.Size(189, 61);
            this.btnAsesores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAsesores.TabIndex = 2;
            this.btnAsesores.TabStop = false;
            this.btnAsesores.Click += new System.EventHandler(this.btnAsesores_Click);
            this.btnAsesores.MouseEnter += new System.EventHandler(this.btnAsesores_MouseEnter);
            this.btnAsesores.MouseLeave += new System.EventHandler(this.btnAsesores_MouseLeave);
            // 
            // btnAdministradores
            // 
            this.btnAdministradores.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministradores.Image = global::Capa_Presentacion.Properties.Resources.Administrador_Admi;
            this.btnAdministradores.Location = new System.Drawing.Point(12, 102);
            this.btnAdministradores.Name = "btnAdministradores";
            this.btnAdministradores.Size = new System.Drawing.Size(189, 61);
            this.btnAdministradores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdministradores.TabIndex = 1;
            this.btnAdministradores.TabStop = false;
            this.btnAdministradores.Click += new System.EventHandler(this.btnAdministradores_Click);
            this.btnAdministradores.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.btnAdministradores.MouseLeave += new System.EventHandler(this.btnAdministradores_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.Fondo_Lateral_Inicio_Administrador;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InicioAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.btnAsesores);
            this.Controls.Add(this.btnAdministradores);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InicioAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioAdministracion_FormClosing);
            this.Load += new System.EventHandler(this.InicioAdministracion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdministradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAdministradores;
        private System.Windows.Forms.PictureBox btnAsesores;
        private System.Windows.Forms.PictureBox btnEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}