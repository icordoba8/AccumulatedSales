
namespace CapaPresentacion
{
    partial class FORM_PRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_PRINCIPAL));
            this.menu = new System.Windows.Forms.Panel();
            this.Wapper = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnComisiones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Flecha = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.menu.Controls.Add(this.btnSalir);
            this.menu.Controls.Add(this.Flecha);
            this.menu.Controls.Add(this.btnComisiones);
            this.menu.Controls.Add(this.btnVentas);
            this.menu.Controls.Add(this.btnPedido);
            this.menu.Controls.Add(this.btnDashboard);
            this.menu.Controls.Add(this.bunifuSeparator1);
            this.menu.Controls.Add(this.label1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(270, 900);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // Wapper
            // 
            this.Wapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Wapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wapper.Location = new System.Drawing.Point(270, 0);
            this.Wapper.Name = "Wapper";
            this.Wapper.Size = new System.Drawing.Size(870, 900);
            this.Wapper.TabIndex = 2;
            this.Wapper.Paint += new System.Windows.Forms.PaintEventHandler(this.wapper_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "DASHBOARD";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(33, 40);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(203, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 90D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(33, 119);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(161, 48);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedido.BorderRadius = 0;
            this.btnPedido.ButtonText = "PEDIDO";
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedido.Iconimage")));
            this.btnPedido.Iconimage_right = null;
            this.btnPedido.Iconimage_right_Selected = null;
            this.btnPedido.Iconimage_Selected = null;
            this.btnPedido.IconMarginLeft = 0;
            this.btnPedido.IconMarginRight = 0;
            this.btnPedido.IconRightVisible = true;
            this.btnPedido.IconRightZoom = 0D;
            this.btnPedido.IconVisible = true;
            this.btnPedido.IconZoom = 90D;
            this.btnPedido.IsTab = true;
            this.btnPedido.Location = new System.Drawing.Point(33, 212);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPedido.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPedido.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnPedido.selected = false;
            this.btnPedido.Size = new System.Drawing.Size(161, 48);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "PEDIDO";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Textcolor = System.Drawing.Color.White;
            this.btnPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 90D;
            this.btnVentas.IsTab = true;
            this.btnVentas.Location = new System.Drawing.Point(33, 303);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(161, 48);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnComisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnComisiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComisiones.BorderRadius = 0;
            this.btnComisiones.ButtonText = "COMISIONES";
            this.btnComisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComisiones.DisabledColor = System.Drawing.Color.Gray;
            this.btnComisiones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComisiones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnComisiones.Iconimage")));
            this.btnComisiones.Iconimage_right = null;
            this.btnComisiones.Iconimage_right_Selected = null;
            this.btnComisiones.Iconimage_Selected = null;
            this.btnComisiones.IconMarginLeft = 0;
            this.btnComisiones.IconMarginRight = 0;
            this.btnComisiones.IconRightVisible = true;
            this.btnComisiones.IconRightZoom = 0D;
            this.btnComisiones.IconVisible = true;
            this.btnComisiones.IconZoom = 90D;
            this.btnComisiones.IsTab = true;
            this.btnComisiones.Location = new System.Drawing.Point(33, 401);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnComisiones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnComisiones.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnComisiones.selected = false;
            this.btnComisiones.Size = new System.Drawing.Size(161, 48);
            this.btnComisiones.TabIndex = 8;
            this.btnComisiones.Text = "COMISIONES";
            this.btnComisiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComisiones.Textcolor = System.Drawing.Color.White;
            this.btnComisiones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // Flecha
            // 
            this.Flecha.Image = ((System.Drawing.Image)(resources.GetObject("Flecha.Image")));
            this.Flecha.Location = new System.Drawing.Point(228, 133);
            this.Flecha.Name = "Flecha";
            this.Flecha.Size = new System.Drawing.Size(46, 34);
            this.Flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Flecha.TabIndex = 9;
            this.Flecha.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label10.Location = new System.Drawing.Point(18, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "DASHBOARD";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.header.Controls.Add(this.label10);
            this.header.Cursor = System.Windows.Forms.Cursors.Hand;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(270, 0);
            this.header.MaximumSize = new System.Drawing.Size(1920, 56);
            this.header.MinimumSize = new System.Drawing.Size(1920, 56);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1920, 56);
            this.header.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(206, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FORM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 900);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Wapper);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_PRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_PRINCIPAL";
            this.Load += new System.EventHandler(this.FORM_PRINCIPAL_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel Wapper;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnComisiones;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnPedido;
        private System.Windows.Forms.PictureBox Flecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}