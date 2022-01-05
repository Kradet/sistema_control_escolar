
namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    partial class Frm_ServiciosEscolares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ServiciosEscolares));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgUsuario = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblUserName = new Guna.UI.WinForms.GunaLabel();
            this.lblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirAlumnos = new Guna.UI.WinForms.GunaButton();
            this.btnVinculación = new Guna.UI.WinForms.GunaButton();
            this.btnVerAlumnos = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnElegirImagen = new Guna.UI.WinForms.GunaCircleButton();
            this.panelLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateral.Controls.Add(this.panel2);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.gunaSeparator1);
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(245, 681);
            this.panelLateral.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnElegirImagen);
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
            this.lblAdmin.Location = new System.Drawing.Point(41, 166);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(147, 17);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "SERVICIOS ESCOLARES";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAñadirAlumnos);
            this.panel1.Controls.Add(this.btnVinculación);
            this.panel1.Controls.Add(this.btnVerAlumnos);
            this.panel1.Location = new System.Drawing.Point(3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 475);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información escolar";
            // 
            // btnAñadirAlumnos
            // 
            this.btnAñadirAlumnos.AnimationHoverSpeed = 0.07F;
            this.btnAñadirAlumnos.AnimationSpeed = 0.03F;
            this.btnAñadirAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirAlumnos.BaseColor = System.Drawing.Color.White;
            this.btnAñadirAlumnos.BorderColor = System.Drawing.Color.Black;
            this.btnAñadirAlumnos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAñadirAlumnos.FocusedColor = System.Drawing.Color.Empty;
            this.btnAñadirAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAñadirAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirAlumnos.Image")));
            this.btnAñadirAlumnos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAñadirAlumnos.Location = new System.Drawing.Point(13, 122);
            this.btnAñadirAlumnos.Name = "btnAñadirAlumnos";
            this.btnAñadirAlumnos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnAñadirAlumnos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAñadirAlumnos.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAñadirAlumnos.OnHoverImage = null;
            this.btnAñadirAlumnos.OnPressedColor = System.Drawing.Color.Black;
            this.btnAñadirAlumnos.Radius = 20;
            this.btnAñadirAlumnos.Size = new System.Drawing.Size(216, 42);
            this.btnAñadirAlumnos.TabIndex = 0;
            this.btnAñadirAlumnos.Text = "Añadir alumnos";
            this.btnAñadirAlumnos.TextOffsetX = 5;
            this.btnAñadirAlumnos.Click += new System.EventHandler(this.btnAñadirAlumnos_Click);
            // 
            // btnVinculación
            // 
            this.btnVinculación.AnimationHoverSpeed = 0.07F;
            this.btnVinculación.AnimationSpeed = 0.03F;
            this.btnVinculación.BackColor = System.Drawing.Color.Transparent;
            this.btnVinculación.BaseColor = System.Drawing.Color.White;
            this.btnVinculación.BorderColor = System.Drawing.Color.Black;
            this.btnVinculación.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVinculación.FocusedColor = System.Drawing.Color.Empty;
            this.btnVinculación.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinculación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnVinculación.Image = ((System.Drawing.Image)(resources.GetObject("btnVinculación.Image")));
            this.btnVinculación.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVinculación.Location = new System.Drawing.Point(13, 202);
            this.btnVinculación.Name = "btnVinculación";
            this.btnVinculación.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnVinculación.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVinculación.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVinculación.OnHoverImage = null;
            this.btnVinculación.OnPressedColor = System.Drawing.Color.Black;
            this.btnVinculación.Radius = 20;
            this.btnVinculación.Size = new System.Drawing.Size(216, 42);
            this.btnVinculación.TabIndex = 0;
            this.btnVinculación.Text = "Vinculación";
            this.btnVinculación.TextOffsetX = 5;
            this.btnVinculación.Click += new System.EventHandler(this.btnVinculación_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.AnimationHoverSpeed = 0.07F;
            this.btnVerAlumnos.AnimationSpeed = 0.03F;
            this.btnVerAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerAlumnos.BaseColor = System.Drawing.Color.White;
            this.btnVerAlumnos.BorderColor = System.Drawing.Color.Black;
            this.btnVerAlumnos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerAlumnos.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnVerAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerAlumnos.Image")));
            this.btnVerAlumnos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVerAlumnos.Location = new System.Drawing.Point(13, 36);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnVerAlumnos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerAlumnos.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVerAlumnos.OnHoverImage = null;
            this.btnVerAlumnos.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerAlumnos.Radius = 20;
            this.btnVerAlumnos.Size = new System.Drawing.Size(216, 42);
            this.btnVerAlumnos.TabIndex = 0;
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.TextOffsetX = 5;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
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
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(238, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1052, 681);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnElegirImagen
            // 
            this.btnElegirImagen.AnimationHoverSpeed = 0.07F;
            this.btnElegirImagen.AnimationSpeed = 0.03F;
            this.btnElegirImagen.BackColor = System.Drawing.Color.White;
            this.btnElegirImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElegirImagen.BackgroundImage")));
            this.btnElegirImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnElegirImagen.BaseColor = System.Drawing.Color.Transparent;
            this.btnElegirImagen.BorderColor = System.Drawing.Color.Black;
            this.btnElegirImagen.BorderSize = 1;
            this.btnElegirImagen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnElegirImagen.FocusedColor = System.Drawing.Color.Empty;
            this.btnElegirImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElegirImagen.ForeColor = System.Drawing.Color.Transparent;
            this.btnElegirImagen.Image = null;
            this.btnElegirImagen.ImageSize = new System.Drawing.Size(40, 40);
            this.btnElegirImagen.Location = new System.Drawing.Point(164, 100);
            this.btnElegirImagen.Name = "btnElegirImagen";
            this.btnElegirImagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnElegirImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnElegirImagen.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnElegirImagen.OnHoverImage = null;
            this.btnElegirImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnElegirImagen.Size = new System.Drawing.Size(40, 40);
            this.btnElegirImagen.TabIndex = 6;
            this.btnElegirImagen.Click += new System.EventHandler(this.btnElegirImagen_Click);
            // 
            // Frm_ServiciosEscolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "Frm_ServiciosEscolares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de Servicios Escolares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ServiciosEscolares_Load);
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
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCirclePictureBox imgUsuario;
        private Guna.UI.WinForms.GunaLabel lblUserName;
        private Guna.UI.WinForms.GunaLabel lblAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAñadirAlumnos;
        private Guna.UI.WinForms.GunaButton btnVinculación;
        private Guna.UI.WinForms.GunaButton btnVerAlumnos;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI.WinForms.GunaCircleButton btnElegirImagen;
    }
}