
namespace app_sistema_escolar.Formularios.Admin
{
    partial class frm_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgUsuario = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblUserName = new Guna.UI.WinForms.GunaLabel();
            this.lblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.btnVentas = new Guna.UI.WinForms.GunaButton();
            this.btnServiciosEscolares = new Guna.UI.WinForms.GunaButton();
            this.btnAsignarPermisos = new Guna.UI.WinForms.GunaButton();
            this.btnCorteCaja = new Guna.UI.WinForms.GunaButton();
            this.btnVerUsuarios = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.panel2);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.gunaSeparator1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(249, 680);
            this.panelLateral.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.imgUsuario);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 192);
            this.panel2.TabIndex = 5;
            // 
            // imgUsuario
            // 
            this.imgUsuario.BaseColor = System.Drawing.Color.White;
            this.imgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgUsuario.Image")));
            this.imgUsuario.Location = new System.Drawing.Point(52, 9);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(120, 120);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 2;
            this.imgUsuario.TabStop = false;
            this.imgUsuario.UseTransfarantBackground = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(49, 143);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(119, 23);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "USER_NAME";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.lblAdmin.Location = new System.Drawing.Point(53, 166);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(111, 17);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "ADMINISTRADOR";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaSeparator2);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnServiciosEscolares);
            this.panel1.Controls.Add(this.btnAsignarPermisos);
            this.panel1.Controls.Add(this.btnCorteCaja);
            this.panel1.Controls.Add(this.btnVerUsuarios);
            this.panel1.Location = new System.Drawing.Point(3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 474);
            this.panel1.TabIndex = 5;
            // 
            // btnReportes
            // 
            this.btnReportes.AnimationHoverSpeed = 0.07F;
            this.btnReportes.AnimationSpeed = 0.03F;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BaseColor = System.Drawing.Color.White;
            this.btnReportes.BorderColor = System.Drawing.Color.Black;
            this.btnReportes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReportes.FocusedColor = System.Drawing.Color.Empty;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnReportes.Image = global::app_sistema_escolar.Properties.Resources.recibos;
            this.btnReportes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReportes.Location = new System.Drawing.Point(9, 362);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnReportes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReportes.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReportes.OnHoverImage = null;
            this.btnReportes.OnPressedColor = System.Drawing.Color.Black;
            this.btnReportes.Radius = 20;
            this.btnReportes.Size = new System.Drawing.Size(200, 42);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextOffsetX = 5;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(10, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administración";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración";
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaSeparator2.Location = new System.Drawing.Point(9, 141);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(216, 15);
            this.gunaSeparator2.TabIndex = 4;
            // 
            // btnVentas
            // 
            this.btnVentas.AnimationHoverSpeed = 0.07F;
            this.btnVentas.AnimationSpeed = 0.03F;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BaseColor = System.Drawing.Color.White;
            this.btnVentas.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVentas.FocusedColor = System.Drawing.Color.Empty;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVentas.Location = new System.Drawing.Point(13, 314);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnVentas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVentas.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVentas.OnHoverImage = null;
            this.btnVentas.OnPressedColor = System.Drawing.Color.Black;
            this.btnVentas.Radius = 20;
            this.btnVentas.Size = new System.Drawing.Size(216, 42);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextOffsetX = 5;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnServiciosEscolares
            // 
            this.btnServiciosEscolares.AnimationHoverSpeed = 0.07F;
            this.btnServiciosEscolares.AnimationSpeed = 0.03F;
            this.btnServiciosEscolares.BackColor = System.Drawing.Color.Transparent;
            this.btnServiciosEscolares.BaseColor = System.Drawing.Color.White;
            this.btnServiciosEscolares.BorderColor = System.Drawing.Color.Black;
            this.btnServiciosEscolares.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnServiciosEscolares.FocusedColor = System.Drawing.Color.Empty;
            this.btnServiciosEscolares.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiciosEscolares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnServiciosEscolares.Image = ((System.Drawing.Image)(resources.GetObject("btnServiciosEscolares.Image")));
            this.btnServiciosEscolares.ImageSize = new System.Drawing.Size(30, 30);
            this.btnServiciosEscolares.Location = new System.Drawing.Point(9, 206);
            this.btnServiciosEscolares.Name = "btnServiciosEscolares";
            this.btnServiciosEscolares.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnServiciosEscolares.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnServiciosEscolares.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnServiciosEscolares.OnHoverImage = null;
            this.btnServiciosEscolares.OnPressedColor = System.Drawing.Color.Black;
            this.btnServiciosEscolares.Radius = 20;
            this.btnServiciosEscolares.Size = new System.Drawing.Size(216, 42);
            this.btnServiciosEscolares.TabIndex = 0;
            this.btnServiciosEscolares.Text = "Servicios Escolares";
            this.btnServiciosEscolares.TextOffsetX = 5;
            this.btnServiciosEscolares.Click += new System.EventHandler(this.btnServiciosEscolares_Click);
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.AnimationHoverSpeed = 0.07F;
            this.btnAsignarPermisos.AnimationSpeed = 0.03F;
            this.btnAsignarPermisos.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarPermisos.BaseColor = System.Drawing.Color.White;
            this.btnAsignarPermisos.BorderColor = System.Drawing.Color.Black;
            this.btnAsignarPermisos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAsignarPermisos.FocusedColor = System.Drawing.Color.Empty;
            this.btnAsignarPermisos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAsignarPermisos.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarPermisos.Image")));
            this.btnAsignarPermisos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAsignarPermisos.Location = new System.Drawing.Point(13, 93);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnAsignarPermisos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAsignarPermisos.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAsignarPermisos.OnHoverImage = null;
            this.btnAsignarPermisos.OnPressedColor = System.Drawing.Color.Black;
            this.btnAsignarPermisos.Radius = 20;
            this.btnAsignarPermisos.Size = new System.Drawing.Size(216, 42);
            this.btnAsignarPermisos.TabIndex = 0;
            this.btnAsignarPermisos.Text = "Asignar Permisos";
            this.btnAsignarPermisos.TextOffsetX = 5;
            this.btnAsignarPermisos.Visible = false;
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.AnimationHoverSpeed = 0.07F;
            this.btnCorteCaja.AnimationSpeed = 0.03F;
            this.btnCorteCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCorteCaja.BaseColor = System.Drawing.Color.White;
            this.btnCorteCaja.BorderColor = System.Drawing.Color.Black;
            this.btnCorteCaja.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCorteCaja.FocusedColor = System.Drawing.Color.Empty;
            this.btnCorteCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCorteCaja.Image")));
            this.btnCorteCaja.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCorteCaja.Location = new System.Drawing.Point(9, 258);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnCorteCaja.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCorteCaja.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCorteCaja.OnHoverImage = null;
            this.btnCorteCaja.OnPressedColor = System.Drawing.Color.Black;
            this.btnCorteCaja.Radius = 20;
            this.btnCorteCaja.Size = new System.Drawing.Size(216, 42);
            this.btnCorteCaja.TabIndex = 0;
            this.btnCorteCaja.Text = "Cobranzas";
            this.btnCorteCaja.TextOffsetX = 5;
            this.btnCorteCaja.Click += new System.EventHandler(this.btnCorteCaja_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.AnimationHoverSpeed = 0.07F;
            this.btnVerUsuarios.AnimationSpeed = 0.03F;
            this.btnVerUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnVerUsuarios.BaseColor = System.Drawing.Color.White;
            this.btnVerUsuarios.BorderColor = System.Drawing.Color.Black;
            this.btnVerUsuarios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerUsuarios.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnVerUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVerUsuarios.Image")));
            this.btnVerUsuarios.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVerUsuarios.Location = new System.Drawing.Point(13, 35);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnVerUsuarios.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerUsuarios.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVerUsuarios.OnHoverImage = null;
            this.btnVerUsuarios.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerUsuarios.Radius = 20;
            this.btnVerUsuarios.Size = new System.Drawing.Size(216, 42);
            this.btnVerUsuarios.TabIndex = 0;
            this.btnVerUsuarios.Text = "Ver Usuarios";
            this.btnVerUsuarios.TextOffsetX = 5;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaSeparator1.Location = new System.Drawing.Point(8, 194);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(234, 13);
            this.gunaSeparator1.TabIndex = 4;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(249, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1035, 680);
            this.panelContenedor.TabIndex = 1;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 680);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.panelLateral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCirclePictureBox imgUsuario;
        private Guna.UI.WinForms.GunaLabel lblUserName;
        private Guna.UI.WinForms.GunaLabel lblAdmin;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnVerUsuarios;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaButton btnServiciosEscolares;
        private Guna.UI.WinForms.GunaButton btnAsignarPermisos;
        private Guna.UI.WinForms.GunaButton btnCorteCaja;
        private Guna.UI.WinForms.GunaButton btnVentas;
        private Guna.UI.WinForms.GunaButton btnReportes;
    }
}