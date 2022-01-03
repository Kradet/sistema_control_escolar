
namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    partial class frm_ventas_AperturarCajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas_AperturarCajas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dpFechaAbrirCaja = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblAbrirCerrarCaja = new System.Windows.Forms.Label();
            this.btnAperturarCerrarCaja = new Guna.UI.WinForms.GunaButton();
            this.txtUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.txtHora = new Guna.UI.WinForms.GunaTextBox();
            this.txtCantidadInicial = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvVistaSesionCaja = new Guna.UI.WinForms.GunaDataGridView();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaSesionCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(562, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(384, 561);
            this.panel6.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dpFechaAbrirCaja);
            this.panel4.Controls.Add(this.lblAbrirCerrarCaja);
            this.panel4.Controls.Add(this.btnAperturarCerrarCaja);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.txtHora);
            this.panel4.Controls.Add(this.txtCantidadInicial);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Location = new System.Drawing.Point(8, 9);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(366, 543);
            this.panel4.TabIndex = 4;
            // 
            // dpFechaAbrirCaja
            // 
            this.dpFechaAbrirCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dpFechaAbrirCaja.BackColor = System.Drawing.Color.Transparent;
            this.dpFechaAbrirCaja.BaseColor = System.Drawing.Color.White;
            this.dpFechaAbrirCaja.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dpFechaAbrirCaja.BorderSize = 3;
            this.dpFechaAbrirCaja.CustomFormat = null;
            this.dpFechaAbrirCaja.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFechaAbrirCaja.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.dpFechaAbrirCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaAbrirCaja.ForeColor = System.Drawing.Color.Black;
            this.dpFechaAbrirCaja.Location = new System.Drawing.Point(39, 310);
            this.dpFechaAbrirCaja.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFechaAbrirCaja.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFechaAbrirCaja.Name = "dpFechaAbrirCaja";
            this.dpFechaAbrirCaja.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpFechaAbrirCaja.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpFechaAbrirCaja.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpFechaAbrirCaja.OnPressedColor = System.Drawing.Color.Black;
            this.dpFechaAbrirCaja.Radius = 15;
            this.dpFechaAbrirCaja.Size = new System.Drawing.Size(313, 34);
            this.dpFechaAbrirCaja.TabIndex = 7;
            this.dpFechaAbrirCaja.Text = "jueves, 2 de diciembre de 2021";
            this.dpFechaAbrirCaja.Value = new System.DateTime(2021, 12, 2, 17, 5, 8, 49);
            this.dpFechaAbrirCaja.Visible = false;
            // 
            // lblAbrirCerrarCaja
            // 
            this.lblAbrirCerrarCaja.AutoSize = true;
            this.lblAbrirCerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrirCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirCerrarCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblAbrirCerrarCaja.Location = new System.Drawing.Point(129, 57);
            this.lblAbrirCerrarCaja.Name = "lblAbrirCerrarCaja";
            this.lblAbrirCerrarCaja.Size = new System.Drawing.Size(124, 19);
            this.lblAbrirCerrarCaja.TabIndex = 4;
            this.lblAbrirCerrarCaja.Text = "Aperturar Caja";
            // 
            // btnAperturarCerrarCaja
            // 
            this.btnAperturarCerrarCaja.AnimationHoverSpeed = 0.07F;
            this.btnAperturarCerrarCaja.AnimationSpeed = 0.03F;
            this.btnAperturarCerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnAperturarCerrarCaja.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAperturarCerrarCaja.BorderColor = System.Drawing.Color.Black;
            this.btnAperturarCerrarCaja.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAperturarCerrarCaja.FocusedColor = System.Drawing.Color.Empty;
            this.btnAperturarCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturarCerrarCaja.ForeColor = System.Drawing.Color.White;
            this.btnAperturarCerrarCaja.Image = null;
            this.btnAperturarCerrarCaja.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAperturarCerrarCaja.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAperturarCerrarCaja.Location = new System.Drawing.Point(77, 475);
            this.btnAperturarCerrarCaja.Name = "btnAperturarCerrarCaja";
            this.btnAperturarCerrarCaja.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.btnAperturarCerrarCaja.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAperturarCerrarCaja.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAperturarCerrarCaja.OnHoverImage = null;
            this.btnAperturarCerrarCaja.OnPressedColor = System.Drawing.Color.Black;
            this.btnAperturarCerrarCaja.Radius = 20;
            this.btnAperturarCerrarCaja.Size = new System.Drawing.Size(228, 42);
            this.btnAperturarCerrarCaja.TabIndex = 3;
            this.btnAperturarCerrarCaja.Text = "Abrir caja";
            this.btnAperturarCerrarCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAperturarCerrarCaja.Click += new System.EventHandler(this.btnAperturarCerrarCaja_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BaseColor = System.Drawing.Color.White;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(39, 166);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.Radius = 14;
            this.txtUsuario.Size = new System.Drawing.Size(306, 30);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.Transparent;
            this.txtHora.BaseColor = System.Drawing.Color.White;
            this.txtHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHora.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHora.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtHora.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(39, 377);
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.Radius = 14;
            this.txtHora.Size = new System.Drawing.Size(306, 30);
            this.txtHora.TabIndex = 2;
            this.txtHora.Visible = false;
            // 
            // txtCantidadInicial
            // 
            this.txtCantidadInicial.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidadInicial.BaseColor = System.Drawing.Color.White;
            this.txtCantidadInicial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCantidadInicial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadInicial.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCantidadInicial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtCantidadInicial.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCantidadInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadInicial.Location = new System.Drawing.Point(39, 238);
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.PasswordChar = '\0';
            this.txtCantidadInicial.Radius = 14;
            this.txtCantidadInicial.Size = new System.Drawing.Size(306, 30);
            this.txtCantidadInicial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(35, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            this.label3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label7.Location = new System.Drawing.Point(35, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha";
            this.label7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(35, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad Inicial";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblUsuario.Location = new System.Drawing.Point(35, 136);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvVistaSesionCaja);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 561);
            this.panel5.TabIndex = 7;
            // 
            // dgvVistaSesionCaja
            // 
            this.dgvVistaSesionCaja.AllowUserToAddRows = false;
            this.dgvVistaSesionCaja.AllowUserToDeleteRows = false;
            this.dgvVistaSesionCaja.AllowUserToOrderColumns = true;
            this.dgvVistaSesionCaja.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVistaSesionCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaSesionCaja.BackgroundColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVistaSesionCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVistaSesionCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaSesionCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVistaSesionCaja.ColumnHeadersHeight = 25;
            this.dgvVistaSesionCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaSesionCaja.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVistaSesionCaja.EnableHeadersVisualStyles = false;
            this.dgvVistaSesionCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVistaSesionCaja.Location = new System.Drawing.Point(10, 13);
            this.dgvVistaSesionCaja.MultiSelect = false;
            this.dgvVistaSesionCaja.Name = "dgvVistaSesionCaja";
            this.dgvVistaSesionCaja.ReadOnly = true;
            this.dgvVistaSesionCaja.RowHeadersVisible = false;
            this.dgvVistaSesionCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaSesionCaja.Size = new System.Drawing.Size(534, 532);
            this.dgvVistaSesionCaja.TabIndex = 2;
            this.dgvVistaSesionCaja.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvVistaSesionCaja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVistaSesionCaja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVistaSesionCaja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVistaSesionCaja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVistaSesionCaja.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVistaSesionCaja.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvVistaSesionCaja.ThemeStyle.ReadOnly = true;
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVistaSesionCaja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVistaSesionCaja.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaSesionCaja_CellMouseClick);
            // 
            // frm_ventas_AperturarCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 567);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas_AperturarCajas";
            this.Text = "frm_ventasAperturarCajas";
            this.Load += new System.EventHandler(this.frm_ventas_AperturarCajas_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaSesionCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAbrirCerrarCaja;
        private Guna.UI.WinForms.GunaButton btnAperturarCerrarCaja;
        private Guna.UI.WinForms.GunaTextBox txtUsuario;
        private Guna.UI.WinForms.GunaTextBox txtCantidadInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaDataGridView dgvVistaSesionCaja;
        private Guna.UI.WinForms.GunaDateTimePicker dpFechaAbrirCaja;
        private Guna.UI.WinForms.GunaTextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}