
namespace app_sistema_escolar.Formularios.Cobranzas.frm_hijos
{
    partial class frm_cobranzas_CrearConceptos
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
            this.dgvConceptosDisponibles = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCrearConcepto = new Guna.UI.WinForms.GunaButton();
            this.txtConcepto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrecio = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosDisponibles)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::app_sistema_escolar.Properties.Resources.Rectángulo_37;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvConceptosDisponibles);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Location = new System.Drawing.Point(12, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 358);
            this.panel1.TabIndex = 9;
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
            this.dgvConceptosDisponibles.Size = new System.Drawing.Size(830, 277);
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
            this.gunaLabel6.Size = new System.Drawing.Size(305, 23);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Conceptos de Pago Disponibles";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::app_sistema_escolar.Properties.Resources.Rectángulo_37;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnCrearConcepto);
            this.panel2.Controls.Add(this.txtConcepto);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaLabel7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 193);
            this.panel2.TabIndex = 8;
            // 
            // btnCrearConcepto
            // 
            this.btnCrearConcepto.AnimationHoverSpeed = 0.07F;
            this.btnCrearConcepto.AnimationSpeed = 0.03F;
            this.btnCrearConcepto.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearConcepto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCrearConcepto.BorderColor = System.Drawing.Color.Black;
            this.btnCrearConcepto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCrearConcepto.FocusedColor = System.Drawing.Color.Empty;
            this.btnCrearConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearConcepto.ForeColor = System.Drawing.Color.White;
            this.btnCrearConcepto.Image = null;
            this.btnCrearConcepto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCrearConcepto.Location = new System.Drawing.Point(345, 146);
            this.btnCrearConcepto.Name = "btnCrearConcepto";
            this.btnCrearConcepto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.btnCrearConcepto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCrearConcepto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCrearConcepto.OnHoverImage = null;
            this.btnCrearConcepto.OnPressedColor = System.Drawing.Color.Black;
            this.btnCrearConcepto.Radius = 15;
            this.btnCrearConcepto.Size = new System.Drawing.Size(188, 34);
            this.btnCrearConcepto.TabIndex = 16;
            this.btnCrearConcepto.Text = "Crear Concepto";
            this.btnCrearConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCrearConcepto.Click += new System.EventHandler(this.btnCrearConcepto_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.Transparent;
            this.txtConcepto.BaseColor = System.Drawing.Color.White;
            this.txtConcepto.BorderColor = System.Drawing.Color.Silver;
            this.txtConcepto.BorderSize = 3;
            this.txtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConcepto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConcepto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtConcepto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConcepto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.ForeColor = System.Drawing.Color.DimGray;
            this.txtConcepto.Location = new System.Drawing.Point(91, 93);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.PasswordChar = '\0';
            this.txtConcepto.Radius = 15;
            this.txtConcepto.Size = new System.Drawing.Size(442, 34);
            this.txtConcepto.TabIndex = 15;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaLabel1.Location = new System.Drawing.Point(92, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 19);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Concepto";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BaseColor = System.Drawing.Color.White;
            this.txtPrecio.BorderColor = System.Drawing.Color.Silver;
            this.txtPrecio.BorderSize = 3;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrecio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.txtPrecio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(542, 93);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.Radius = 15;
            this.txtPrecio.Size = new System.Drawing.Size(181, 34);
            this.txtPrecio.TabIndex = 15;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaLabel2.Location = new System.Drawing.Point(546, 66);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(57, 19);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Precio";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(22, 22);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(244, 23);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Crear Concepto de Pago";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_cobranzas_CrearConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cobranzas_CrearConceptos";
            this.Text = "frm_cobranzasCrearConceptos";
            this.Load += new System.EventHandler(this.frm_cobranzas_CrearConceptos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosDisponibles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnCrearConcepto;
        private Guna.UI.WinForms.GunaTextBox txtConcepto;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtPrecio;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dgvConceptosDisponibles;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}