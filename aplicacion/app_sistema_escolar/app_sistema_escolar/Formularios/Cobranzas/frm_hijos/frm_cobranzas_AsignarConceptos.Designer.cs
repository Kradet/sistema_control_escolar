
namespace app_sistema_escolar.Formularios.Cobranzas.frm_hijos
{
    partial class frm_cobranzas_AsignarConceptos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsignar = new Guna.UI.WinForms.GunaButton();
            this.dgvConceptosDisponibles = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtCicloEscolar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtEstatus = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMatricula = new Guna.UI.WinForms.GunaTextBox();
            this.labelmatricula = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosDisponibles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::app_sistema_escolar.Properties.Resources.Rectángulo_371;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.dgvConceptosDisponibles);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.txtCicloEscolar);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Location = new System.Drawing.Point(12, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 375);
            this.panel1.TabIndex = 8;
            // 
            // btnAsignar
            // 
            this.btnAsignar.AnimationHoverSpeed = 0.07F;
            this.btnAsignar.AnimationSpeed = 0.03F;
            this.btnAsignar.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAsignar.BorderColor = System.Drawing.Color.Black;
            this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAsignar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Image = null;
            this.btnAsignar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAsignar.Location = new System.Drawing.Point(688, 327);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.btnAsignar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAsignar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAsignar.OnHoverImage = null;
            this.btnAsignar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAsignar.Radius = 15;
            this.btnAsignar.Size = new System.Drawing.Size(166, 34);
            this.btnAsignar.TabIndex = 17;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvConceptosDisponibles
            // 
            this.dgvConceptosDisponibles.AllowUserToAddRows = false;
            this.dgvConceptosDisponibles.AllowUserToDeleteRows = false;
            this.dgvConceptosDisponibles.AllowUserToOrderColumns = true;
            this.dgvConceptosDisponibles.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConceptosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConceptosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptosDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConceptosDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConceptosDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptosDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConceptosDisponibles.ColumnHeadersHeight = 25;
            this.dgvConceptosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptosDisponibles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConceptosDisponibles.EnableHeadersVisualStyles = false;
            this.dgvConceptosDisponibles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConceptosDisponibles.Location = new System.Drawing.Point(26, 61);
            this.dgvConceptosDisponibles.MultiSelect = false;
            this.dgvConceptosDisponibles.Name = "dgvConceptosDisponibles";
            this.dgvConceptosDisponibles.ReadOnly = true;
            this.dgvConceptosDisponibles.RowHeadersVisible = false;
            this.dgvConceptosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConceptosDisponibles.Size = new System.Drawing.Size(830, 246);
            this.dgvConceptosDisponibles.TabIndex = 14;
            this.dgvConceptosDisponibles.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvConceptosDisponibles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvConceptosDisponibles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvConceptosDisponibles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvConceptosDisponibles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvConceptosDisponibles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConceptosDisponibles.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvConceptosDisponibles.ThemeStyle.ReadOnly = true;
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.Height = 22;
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvConceptosDisponibles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel6.Location = new System.Drawing.Point(22, 22);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(250, 23);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Asignacion de Conceptos";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCicloEscolar
            // 
            this.txtCicloEscolar.BackColor = System.Drawing.Color.Transparent;
            this.txtCicloEscolar.BaseColor = System.Drawing.Color.White;
            this.txtCicloEscolar.BorderColor = System.Drawing.Color.Silver;
            this.txtCicloEscolar.BorderSize = 3;
            this.txtCicloEscolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCicloEscolar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCicloEscolar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtCicloEscolar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCicloEscolar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCicloEscolar.ForeColor = System.Drawing.Color.DimGray;
            this.txtCicloEscolar.Location = new System.Drawing.Point(152, 327);
            this.txtCicloEscolar.Name = "txtCicloEscolar";
            this.txtCicloEscolar.PasswordChar = '\0';
            this.txtCicloEscolar.Radius = 15;
            this.txtCicloEscolar.Size = new System.Drawing.Size(513, 34);
            this.txtCicloEscolar.TabIndex = 15;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaLabel3.Location = new System.Drawing.Point(32, 332);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(107, 19);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Ciclo Escolar";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::app_sistema_escolar.Properties.Resources.Rectángulo_37;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.txtEstatus);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.txtMatricula);
            this.panel2.Controls.Add(this.labelmatricula);
            this.panel2.Controls.Add(this.gunaLabel7);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 179);
            this.panel2.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderSize = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(222, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 15;
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(416, 34);
            this.txtNombre.TabIndex = 15;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaLabel1.Location = new System.Drawing.Point(227, 80);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(154, 19);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Nombre Completo";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.Color.Transparent;
            this.txtEstatus.BaseColor = System.Drawing.Color.White;
            this.txtEstatus.BorderColor = System.Drawing.Color.Silver;
            this.txtEstatus.BorderSize = 3;
            this.txtEstatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstatus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstatus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtEstatus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.ForeColor = System.Drawing.Color.DimGray;
            this.txtEstatus.Location = new System.Drawing.Point(648, 107);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.PasswordChar = '\0';
            this.txtEstatus.Radius = 15;
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(210, 34);
            this.txtEstatus.TabIndex = 15;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaLabel2.Location = new System.Drawing.Point(653, 80);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 19);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Estatus";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.Transparent;
            this.txtMatricula.BaseColor = System.Drawing.Color.White;
            this.txtMatricula.BorderColor = System.Drawing.Color.Silver;
            this.txtMatricula.BorderSize = 3;
            this.txtMatricula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatricula.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMatricula.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtMatricula.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatricula.Location = new System.Drawing.Point(29, 107);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.Radius = 15;
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(181, 34);
            this.txtMatricula.TabIndex = 15;
            // 
            // labelmatricula
            // 
            this.labelmatricula.AutoSize = true;
            this.labelmatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelmatricula.Location = new System.Drawing.Point(25, 80);
            this.labelmatricula.Name = "labelmatricula";
            this.labelmatricula.Size = new System.Drawing.Size(82, 19);
            this.labelmatricula.TabIndex = 14;
            this.labelmatricula.Text = "Matrícula";
            this.labelmatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(23, 31);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(215, 23);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Alumno Seleccionado";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_cobranzas_AsignarConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cobranzas_AsignarConceptos";
            this.Text = "frm_cobranzasAsignarConceptos";
            this.Load += new System.EventHandler(this.frm_cobranzas_AsignarConceptos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosDisponibles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel labelmatricula;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtEstatus;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtMatricula;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDataGridView dgvConceptosDisponibles;
        private Guna.UI.WinForms.GunaTextBox txtCicloEscolar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnAsignar;
    }
}