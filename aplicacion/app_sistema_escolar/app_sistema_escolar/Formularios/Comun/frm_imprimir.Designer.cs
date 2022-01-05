
namespace app_sistema_escolar.Formularios.Comun
{
    partial class frm_imprimir
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new Guna.UI.WinForms.GunaButton();
            this.btnCerra = new Guna.UI.WinForms.GunaButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnCerra);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Location = new System.Drawing.Point(-8, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 479);
            this.panel1.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AnimationHoverSpeed = 0.07F;
            this.btnImprimir.AnimationSpeed = 0.03F;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnImprimir.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = null;
            this.btnImprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimir.Location = new System.Drawing.Point(178, 375);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Radius = 20;
            this.btnImprimir.Size = new System.Drawing.Size(132, 42);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerra
            // 
            this.btnCerra.AnimationHoverSpeed = 0.07F;
            this.btnCerra.AnimationSpeed = 0.03F;
            this.btnCerra.BackColor = System.Drawing.Color.Transparent;
            this.btnCerra.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
            this.btnCerra.BorderColor = System.Drawing.Color.Black;
            this.btnCerra.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerra.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerra.ForeColor = System.Drawing.Color.White;
            this.btnCerra.Image = null;
            this.btnCerra.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerra.Location = new System.Drawing.Point(40, 375);
            this.btnCerra.Name = "btnCerra";
            this.btnCerra.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(30)))));
            this.btnCerra.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerra.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerra.OnHoverImage = null;
            this.btnCerra.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerra.Radius = 20;
            this.btnCerra.Size = new System.Drawing.Size(132, 42);
            this.btnCerra.TabIndex = 3;
            this.btnCerra.Text = "Cerrar";
            this.btnCerra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerra.Click += new System.EventHandler(this.btnCerra_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(20, 157);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(303, 82);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "MENSAJE";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // frm_imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 440);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_imprimir";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnImprimir;
        private Guna.UI.WinForms.GunaButton btnCerra;
        private System.Windows.Forms.Label lblMensaje;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}