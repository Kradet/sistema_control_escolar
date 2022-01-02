
namespace app_sistema_escolar.Formularios.Admin
{
    partial class FormAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnAgregarPermisos = new FontAwesome.Sharp.IconButton();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.btnVerUsuarios = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnAgregarPermisos);
            this.panelMenu.Controls.Add(this.btnAgregarUsuario);
            this.panelMenu.Controls.Add(this.lblTipoUsuario);
            this.panelMenu.Controls.Add(this.lblNombre);
            this.panelMenu.Controls.Add(this.lblUserName);
            this.panelMenu.Controls.Add(this.pictureUser);
            this.panelMenu.Controls.Add(this.btnVerUsuarios);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconSize = 32;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 501);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrarSesion.Rotation = 0D;
            this.btnCerrarSesion.Size = new System.Drawing.Size(220, 60);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAgregarPermisos
            // 
            this.btnAgregarPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPermisos.FlatAppearance.BorderSize = 0;
            this.btnAgregarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPermisos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarPermisos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermisos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarPermisos.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnAgregarPermisos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarPermisos.IconSize = 32;
            this.btnAgregarPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPermisos.Location = new System.Drawing.Point(0, 246);
            this.btnAgregarPermisos.Name = "btnAgregarPermisos";
            this.btnAgregarPermisos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgregarPermisos.Rotation = 0D;
            this.btnAgregarPermisos.Size = new System.Drawing.Size(220, 60);
            this.btnAgregarPermisos.TabIndex = 2;
            this.btnAgregarPermisos.Text = "Agregar Permisos";
            this.btnAgregarPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPermisos.UseVisualStyleBackColor = true;
            this.btnAgregarPermisos.Click += new System.EventHandler(this.btnAgregarPermisos_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarUsuario.IconSize = 32;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(0, 186);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgregarUsuario.Rotation = 0D;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(220, 60);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuarios";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoUsuario.Location = new System.Drawing.Point(98, 72);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblTipoUsuario.TabIndex = 78;
            this.lblTipoUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(98, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 299;
            this.lblNombre.Text = "nombre";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(98, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 20);
            this.lblUserName.TabIndex = 90;
            this.lblUserName.Text = "username";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::app_sistema_escolar.Properties.Resources.userlogo;
            this.pictureUser.Location = new System.Drawing.Point(12, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(80, 80);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerUsuarios.FlatAppearance.BorderSize = 0;
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnVerUsuarios.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerUsuarios.IconSize = 32;
            this.btnVerUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerUsuarios.Location = new System.Drawing.Point(0, 126);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVerUsuarios.Rotation = 0D;
            this.btnVerUsuarios.Size = new System.Drawing.Size(220, 60);
            this.btnVerUsuarios.TabIndex = 0;
            this.btnVerUsuarios.Text = "Ver Usuarios";
            this.btnVerUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 126);
            this.panelLogo.TabIndex = 3;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(864, 561);
            this.panelContenedor.TabIndex = 1;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnVerUsuarios;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnAgregarPermisos;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}