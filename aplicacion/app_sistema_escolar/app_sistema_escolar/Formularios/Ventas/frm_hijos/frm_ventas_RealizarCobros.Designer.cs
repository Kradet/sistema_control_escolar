
namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    partial class frm_ventas_RealizarCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas_RealizarCobros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbMes = new Guna.UI.WinForms.GunaComboBox();
            this.cmbMetodoPago = new Guna.UI.WinForms.GunaComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagar = new Guna.UI.WinForms.GunaButton();
            this.txtDescuentos = new Guna.UI.WinForms.GunaTextBox();
            this.txtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.txtRecargos = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dvgHistorialPago = new Guna.UI.WinForms.GunaDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConcepto = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdCobro = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialPago)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(959, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 686);
            this.panel6.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.cmbMes);
            this.panel4.Controls.Add(this.cmbMetodoPago);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnPagar);
            this.panel4.Controls.Add(this.txtDescuentos);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.txtRecargos);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Location = new System.Drawing.Point(15, 9);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(278, 670);
            this.panel4.TabIndex = 4;
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.BaseColor = System.Drawing.Color.White;
            this.cmbMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Enabled = false;
            this.cmbMes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMes.ForeColor = System.Drawing.Color.Black;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Seleccione...",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE",
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO"});
            this.cmbMes.Location = new System.Drawing.Point(39, 217);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMes.Radius = 12;
            this.cmbMes.Size = new System.Drawing.Size(213, 26);
            this.cmbMes.TabIndex = 8;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cmbMetodoPago.BaseColor = System.Drawing.Color.White;
            this.cmbMetodoPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cmbMetodoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Enabled = false;
            this.cmbMetodoPago.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Seleccione...",
            "TDC",
            "TDD",
            "EFECTIVO",
            "CHEQUE",
            "DEPOSITO"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(39, 443);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMetodoPago.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMetodoPago.Radius = 12;
            this.cmbMetodoPago.Size = new System.Drawing.Size(213, 26);
            this.cmbMetodoPago.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label12.Location = new System.Drawing.Point(35, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Metodo de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resumen";
            // 
            // btnPagar
            // 
            this.btnPagar.AnimationHoverSpeed = 0.07F;
            this.btnPagar.AnimationSpeed = 0.03F;
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPagar.BorderColor = System.Drawing.Color.Black;
            this.btnPagar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPagar.Enabled = false;
            this.btnPagar.FocusedColor = System.Drawing.Color.Empty;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Image = null;
            this.btnPagar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPagar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPagar.Location = new System.Drawing.Point(52, 570);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.btnPagar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPagar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPagar.OnHoverImage = null;
            this.btnPagar.OnPressedColor = System.Drawing.Color.Black;
            this.btnPagar.Radius = 20;
            this.btnPagar.Size = new System.Drawing.Size(176, 42);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.BackColor = System.Drawing.Color.Transparent;
            this.txtDescuentos.BaseColor = System.Drawing.Color.White;
            this.txtDescuentos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtDescuentos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescuentos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescuentos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtDescuentos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescuentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentos.Location = new System.Drawing.Point(39, 359);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.PasswordChar = '\0';
            this.txtDescuentos.Radius = 14;
            this.txtDescuentos.Size = new System.Drawing.Size(213, 30);
            this.txtDescuentos.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BaseColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(39, 503);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.Radius = 14;
            this.txtTotal.Size = new System.Drawing.Size(213, 30);
            this.txtTotal.TabIndex = 2;
            // 
            // txtRecargos
            // 
            this.txtRecargos.BackColor = System.Drawing.Color.Transparent;
            this.txtRecargos.BaseColor = System.Drawing.Color.White;
            this.txtRecargos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtRecargos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecargos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRecargos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtRecargos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRecargos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecargos.Location = new System.Drawing.Point(39, 288);
            this.txtRecargos.Name = "txtRecargos";
            this.txtRecargos.PasswordChar = '\0';
            this.txtRecargos.Radius = 14;
            this.txtRecargos.Size = new System.Drawing.Size(213, 30);
            this.txtRecargos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(35, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total a pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label7.Location = new System.Drawing.Point(35, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "+ Recargos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(35, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "- Descuentos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblUsuario.Location = new System.Drawing.Point(35, 186);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(39, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Mes";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(2, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(966, 688);
            this.panel5.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.dvgHistorialPago);
            this.panel7.Location = new System.Drawing.Point(10, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 676);
            this.panel7.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(35, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Historial de Pago";
            // 
            // dvgHistorialPago
            // 
            this.dvgHistorialPago.AllowUserToAddRows = false;
            this.dvgHistorialPago.AllowUserToDeleteRows = false;
            this.dvgHistorialPago.AllowUserToOrderColumns = true;
            this.dvgHistorialPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dvgHistorialPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgHistorialPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgHistorialPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgHistorialPago.BackgroundColor = System.Drawing.Color.White;
            this.dvgHistorialPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgHistorialPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgHistorialPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgHistorialPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgHistorialPago.ColumnHeadersHeight = 25;
            this.dvgHistorialPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgHistorialPago.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgHistorialPago.EnableHeadersVisualStyles = false;
            this.dvgHistorialPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgHistorialPago.Location = new System.Drawing.Point(15, 83);
            this.dvgHistorialPago.MultiSelect = false;
            this.dvgHistorialPago.Name = "dvgHistorialPago";
            this.dvgHistorialPago.ReadOnly = true;
            this.dvgHistorialPago.RowHeadersVisible = false;
            this.dvgHistorialPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgHistorialPago.Size = new System.Drawing.Size(384, 531);
            this.dvgHistorialPago.TabIndex = 16;
            this.dvgHistorialPago.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dvgHistorialPago.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgHistorialPago.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgHistorialPago.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgHistorialPago.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgHistorialPago.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgHistorialPago.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgHistorialPago.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgHistorialPago.ThemeStyle.HeaderStyle.Height = 25;
            this.dvgHistorialPago.ThemeStyle.ReadOnly = true;
            this.dvgHistorialPago.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgHistorialPago.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgHistorialPago.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dvgHistorialPago.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgHistorialPago.ThemeStyle.RowsStyle.Height = 22;
            this.dvgHistorialPago.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgHistorialPago.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Location = new System.Drawing.Point(431, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 679);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dpFecha);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(26, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 327);
            this.panel1.TabIndex = 5;
            // 
            // dpFecha
            // 
            this.dpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dpFecha.BaseColor = System.Drawing.Color.White;
            this.dpFecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dpFecha.CustomFormat = null;
            this.dpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.dpFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.ForeColor = System.Drawing.Color.Black;
            this.dpFecha.Location = new System.Drawing.Point(55, 252);
            this.dpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpFecha.OnPressedColor = System.Drawing.Color.Black;
            this.dpFecha.Radius = 15;
            this.dpFecha.Size = new System.Drawing.Size(385, 34);
            this.dpFecha.TabIndex = 19;
            this.dpFecha.Text = "jueves, 2 de diciembre de 2021";
            this.dpFecha.Value = new System.DateTime(2021, 12, 2, 17, 5, 8, 49);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label11.Location = new System.Drawing.Point(55, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(53, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BaseColor = System.Drawing.Color.Azure;
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrecio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtPrecio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(55, 178);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '●';
            this.txtPrecio.Radius = 14;
            this.txtPrecio.Size = new System.Drawing.Size(389, 30);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label9.Location = new System.Drawing.Point(49, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.Transparent;
            this.txtConcepto.BaseColor = System.Drawing.Color.Azure;
            this.txtConcepto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConcepto.Enabled = false;
            this.txtConcepto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConcepto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtConcepto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConcepto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(51, 105);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.PasswordChar = '●';
            this.txtConcepto.Radius = 14;
            this.txtConcepto.Size = new System.Drawing.Size(393, 30);
            this.txtConcepto.TabIndex = 13;
            this.txtConcepto.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(44, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Datos de pago";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::app_sistema_escolar.Properties.Resources.Rectángulo_22;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtIdCobro);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNombreCompleto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(27, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 206);
            this.panel2.TabIndex = 6;
            // 
            // txtIdCobro
            // 
            this.txtIdCobro.BackColor = System.Drawing.Color.Transparent;
            this.txtIdCobro.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtIdCobro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdCobro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCobro.Enabled = false;
            this.txtIdCobro.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdCobro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtIdCobro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdCobro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCobro.Location = new System.Drawing.Point(160, 144);
            this.txtIdCobro.Name = "txtIdCobro";
            this.txtIdCobro.PasswordChar = '●';
            this.txtIdCobro.Radius = 14;
            this.txtIdCobro.Size = new System.Drawing.Size(92, 30);
            this.txtIdCobro.TabIndex = 14;
            this.txtIdCobro.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(52, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "ID de Cobro: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(46, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Matricula o CURP";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreCompleto.BaseColor = System.Drawing.Color.White;
            this.txtNombreCompleto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreCompleto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtNombreCompleto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(53, 94);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.PasswordChar = '●';
            this.txtNombreCompleto.Radius = 14;
            this.txtNombreCompleto.Size = new System.Drawing.Size(402, 30);
            this.txtNombreCompleto.TabIndex = 10;
            this.txtNombreCompleto.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datos del alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(56, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingresar Matrícula";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(385, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(117, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Enabled = false;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(56, 67);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '●';
            this.txtBuscar.Radius = 14;
            this.txtBuscar.Size = new System.Drawing.Size(314, 30);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.UseSystemPasswordChar = true;
            // 
            // frm_ventas_RealizarCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 694);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas_RealizarCobros";
            this.Text = "frm_ventasRealizarCobros";
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialPago)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnPagar;
        private Guna.UI.WinForms.GunaTextBox txtDescuentos;
        private Guna.UI.WinForms.GunaTextBox txtTotal;
        private Guna.UI.WinForms.GunaTextBox txtRecargos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtNombreCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtConcepto;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDateTimePicker dpFecha;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaDataGridView dvgHistorialPago;
        private Guna.UI.WinForms.GunaComboBox cmbMes;
        private Guna.UI.WinForms.GunaComboBox cmbMetodoPago;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaTextBox txtIdCobro;
        private System.Windows.Forms.Label label13;
    }
}