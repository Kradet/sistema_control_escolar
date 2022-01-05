
namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    partial class frm_ventas_ReporteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas_ReporteCaja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbMesPago = new Guna.UI.WinForms.GunaComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimirReporte = new Guna.UI.WinForms.GunaButton();
            this.lblCondicional = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dgvFolios = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(813, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(353, 820);
            this.panel6.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.cmbMesPago);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnImprimirReporte);
            this.panel4.Controls.Add(this.lblCondicional);
            this.panel4.Location = new System.Drawing.Point(3, 9);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(347, 802);
            this.panel4.TabIndex = 4;
            // 
            // cmbMesPago
            // 
            this.cmbMesPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione...",
            "KINDER",
            "PRIMARIA",
            "SECUNDARIA"});
            this.cmbMesPago.BackColor = System.Drawing.Color.Transparent;
            this.cmbMesPago.BaseColor = System.Drawing.Color.White;
            this.cmbMesPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cmbMesPago.BorderSize = 3;
            this.cmbMesPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMesPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesPago.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMesPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMesPago.ForeColor = System.Drawing.Color.Black;
            this.cmbMesPago.FormattingEnabled = true;
            this.cmbMesPago.Items.AddRange(new object[] {
            "Seleccione...",
            "ENERO/2022",
            "FEBRERO/2022",
            "MARZO/2022",
            "ABRIL/2022",
            "MAYO/2022",
            "JUNIO/2022",
            "JULIO/2022",
            "AGOSTO/2022",
            "SEPTIEMBRE/2022",
            "OCTUBRE/2022",
            "NOVIEMBRE/2022",
            "DICIEMBRE/2022"});
            this.cmbMesPago.Location = new System.Drawing.Point(39, 166);
            this.cmbMesPago.Name = "cmbMesPago";
            this.cmbMesPago.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMesPago.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMesPago.Radius = 10;
            this.cmbMesPago.Size = new System.Drawing.Size(284, 26);
            this.cmbMesPago.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(101, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Reporte de Deudas";
            // 
            // btnImprimirReporte
            // 
            this.btnImprimirReporte.AnimationHoverSpeed = 0.07F;
            this.btnImprimirReporte.AnimationSpeed = 0.03F;
            this.btnImprimirReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnImprimirReporte.BorderColor = System.Drawing.Color.Black;
            this.btnImprimirReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimirReporte.Enabled = false;
            this.btnImprimirReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimirReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirReporte.ForeColor = System.Drawing.Color.White;
            this.btnImprimirReporte.Image = null;
            this.btnImprimirReporte.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimirReporte.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimirReporte.Location = new System.Drawing.Point(91, 235);
            this.btnImprimirReporte.Name = "btnImprimirReporte";
            this.btnImprimirReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.btnImprimirReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimirReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimirReporte.OnHoverImage = null;
            this.btnImprimirReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimirReporte.Radius = 20;
            this.btnImprimirReporte.Size = new System.Drawing.Size(176, 42);
            this.btnImprimirReporte.TabIndex = 3;
            this.btnImprimirReporte.Text = "Imprimir Reporte ";
            this.btnImprimirReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCondicional
            // 
            this.lblCondicional.AutoSize = true;
            this.lblCondicional.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicional.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblCondicional.Location = new System.Drawing.Point(35, 136);
            this.lblCondicional.Name = "lblCondicional";
            this.lblCondicional.Size = new System.Drawing.Size(84, 19);
            this.lblCondicional.TabIndex = 0;
            this.lblCondicional.Text = "Filtrar por ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 782);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.dgvFolios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 655);
            this.panel1.TabIndex = 5;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Enabled = false;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(232, 617);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(313, 42);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "Imprimir Recibo Seleccionado";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvFolios
            // 
            this.dgvFolios.AllowUserToAddRows = false;
            this.dgvFolios.AllowUserToDeleteRows = false;
            this.dgvFolios.AllowUserToOrderColumns = true;
            this.dgvFolios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFolios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFolios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFolios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFolios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFolios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFolios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFolios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFolios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFolios.ColumnHeadersHeight = 25;
            this.dgvFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFolios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFolios.EnableHeadersVisualStyles = false;
            this.dgvFolios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFolios.Location = new System.Drawing.Point(23, 84);
            this.dgvFolios.MultiSelect = false;
            this.dgvFolios.Name = "dgvFolios";
            this.dgvFolios.ReadOnly = true;
            this.dgvFolios.RowHeadersVisible = false;
            this.dgvFolios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFolios.Size = new System.Drawing.Size(711, 480);
            this.dgvFolios.TabIndex = 7;
            this.dgvFolios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvFolios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFolios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFolios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFolios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFolios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFolios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFolios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFolios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvFolios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFolios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFolios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFolios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFolios.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvFolios.ThemeStyle.ReadOnly = true;
            this.dgvFolios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFolios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFolios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFolios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFolios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFolios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFolios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recibos de Cobro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(54, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reportes";
            // 
            // frm_ventas_ReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 788);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas_ReporteCaja";
            this.Text = "frm_ventasReporteCaja";
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgvFolios;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaButton btnImprimirReporte;
        private System.Windows.Forms.Label lblCondicional;
        private Guna.UI.WinForms.GunaComboBox cmbMesPago;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label4;
    }
}