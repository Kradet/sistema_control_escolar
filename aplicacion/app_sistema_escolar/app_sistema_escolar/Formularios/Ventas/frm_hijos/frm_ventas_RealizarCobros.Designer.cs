
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPagar = new Guna.UI.WinForms.GunaButton();
            this.txtMetodoPago = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescuentos = new Guna.UI.WinForms.GunaTextBox();
            this.txtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.txtRecargos = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdCobro = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dvgHistorialPago = new Guna.UI.WinForms.GunaDataGridView();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialPago)).BeginInit();
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
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnPagar);
            this.panel4.Controls.Add(this.txtMetodoPago);
            this.panel4.Controls.Add(this.txtDescuentos);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.txtRecargos);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(16, 9);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(278, 670);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(69, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Datos de pago";
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
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.txtMetodoPago.BaseColor = System.Drawing.Color.White;
            this.txtMetodoPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtMetodoPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMetodoPago.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMetodoPago.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtMetodoPago.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMetodoPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPago.Location = new System.Drawing.Point(39, 436);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.PasswordChar = '\0';
            this.txtMetodoPago.Radius = 14;
            this.txtMetodoPago.Size = new System.Drawing.Size(213, 30);
            this.txtMetodoPago.TabIndex = 2;
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
            this.txtDescuentos.TextChanged += new System.EventHandler(this.txtRecargos_TextChanged);
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
            this.txtTotal.ReadOnly = true;
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
            this.txtRecargos.TextChanged += new System.EventHandler(this.txtRecargos_TextChanged);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(2, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 688);
            this.panel5.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.btnBuscar);
            this.panel7.Controls.Add(this.txtBuscar);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.dvgHistorialPago);
            this.panel7.Location = new System.Drawing.Point(12, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(939, 676);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(56, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ingresar Matrícula o CURP";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(400, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(128)))), ((int)(((byte)(184)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(117, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(146)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(60, 113);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '●';
            this.txtBuscar.Radius = 14;
            this.txtBuscar.Size = new System.Drawing.Size(314, 30);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.UseSystemPasswordChar = true;
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
            this.panel2.Location = new System.Drawing.Point(43, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 206);
            this.panel2.TabIndex = 18;
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
            this.txtIdCobro.Visible = false;
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
            this.label13.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(46, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre Completo";
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
            this.txtNombreCompleto.ReadOnly = true;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(56, 38);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dvgHistorialPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgHistorialPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgHistorialPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgHistorialPago.BackgroundColor = System.Drawing.Color.White;
            this.dvgHistorialPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgHistorialPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgHistorialPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgHistorialPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgHistorialPago.ColumnHeadersHeight = 25;
            this.dvgHistorialPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgHistorialPago.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgHistorialPago.EnableHeadersVisualStyles = false;
            this.dvgHistorialPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgHistorialPago.Location = new System.Drawing.Point(43, 392);
            this.dvgHistorialPago.MultiSelect = false;
            this.dvgHistorialPago.Name = "dvgHistorialPago";
            this.dvgHistorialPago.ReadOnly = true;
            this.dvgHistorialPago.RowHeadersVisible = false;
            this.dvgHistorialPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgHistorialPago.Size = new System.Drawing.Size(855, 235);
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
            // frm_ventas_RealizarCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 694);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas_RealizarCobros";
            this.Text = "frm_ventasRealizarCobros";
            this.Load += new System.EventHandler(this.frm_ventas_RealizarCobros_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaButton btnPagar;
        private Guna.UI.WinForms.GunaTextBox txtDescuentos;
        private Guna.UI.WinForms.GunaTextBox txtTotal;
        private Guna.UI.WinForms.GunaTextBox txtRecargos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaDataGridView dvgHistorialPago;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtMetodoPago;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox txtIdCobro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtNombreCompleto;
        private System.Windows.Forms.Label label5;
    }
}