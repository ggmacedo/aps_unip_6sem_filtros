namespace Filtros
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboFiltros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSalvarImagem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSelecionarImagem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureImagemFinal = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureImagemOriginal = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagemFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel2.Controls.Add(this.comboFiltros);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel2.Controls.Add(this.btnSalvarImagem);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel2.Controls.Add(this.btnSelecionarImagem);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 12;
            this.guna2Panel2.Size = new System.Drawing.Size(241, 540);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // comboFiltros
            // 
            this.comboFiltros.BackColor = System.Drawing.Color.MidnightBlue;
            this.comboFiltros.BorderColor = System.Drawing.Color.Black;
            this.comboFiltros.BorderRadius = 6;
            this.comboFiltros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltros.FillColor = System.Drawing.Color.MidnightBlue;
            this.comboFiltros.FocusedColor = System.Drawing.Color.Transparent;
            this.comboFiltros.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.comboFiltros.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.comboFiltros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFiltros.ForeColor = System.Drawing.Color.White;
            this.comboFiltros.ItemHeight = 30;
            this.comboFiltros.Location = new System.Drawing.Point(22, 316);
            this.comboFiltros.Name = "comboFiltros";
            this.comboFiltros.ShadowDecoration.BorderRadius = 12;
            this.comboFiltros.Size = new System.Drawing.Size(198, 36);
            this.comboFiltros.TabIndex = 5;
            this.comboFiltros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboFiltros.SelectedIndexChanged += new System.EventHandler(this.ComboFiltros_SelectedIndexChanged);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::Filtros.Properties.Resources.photo__1_;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(34, 268);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(31, 24);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 4;
            this.guna2PictureBox4.TabStop = false;
            // 
            // btnSalvarImagem
            // 
            this.btnSalvarImagem.Animated = true;
            this.btnSalvarImagem.BorderRadius = 6;
            this.btnSalvarImagem.BorderThickness = 1;
            this.btnSalvarImagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarImagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarImagem.FillColor = System.Drawing.Color.Transparent;
            this.btnSalvarImagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarImagem.ForeColor = System.Drawing.Color.White;
            this.btnSalvarImagem.Location = new System.Drawing.Point(22, 259);
            this.btnSalvarImagem.Name = "btnSalvarImagem";
            this.btnSalvarImagem.Size = new System.Drawing.Size(198, 33);
            this.btnSalvarImagem.TabIndex = 3;
            this.btnSalvarImagem.Text = "Salvar Imagem";
            this.btnSalvarImagem.Click += new System.EventHandler(this.BtnSalvarImagem_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::Filtros.Properties.Resources.photo__2_;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(34, 208);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Animated = true;
            this.btnSelecionarImagem.BorderRadius = 6;
            this.btnSelecionarImagem.BorderThickness = 1;
            this.btnSelecionarImagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelecionarImagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelecionarImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelecionarImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelecionarImagem.FillColor = System.Drawing.Color.Transparent;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(22, 200);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(198, 33);
            this.btnSelecionarImagem.TabIndex = 1;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.Click += new System.EventHandler(this.BtnSelecionarImagemClick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Filtros.Properties.Resources.paypal;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(80, 47);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(74, 120);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_2);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::Filtros.Properties.Resources.Banner_para_twitch_para_jogadores_e_streamers_moderno_rosa__1_1;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-564, -254);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(2542, 800);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Tag = "Filtros";
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureImagemFinal);
            this.guna2Panel1.Controls.Add(this.pictureImagemOriginal);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(203, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(950, 540);
            this.guna2Panel1.TabIndex = 2;
            // 
            // pictureImagemFinal
            // 
            this.pictureImagemFinal.BackColor = System.Drawing.Color.Transparent;
            this.pictureImagemFinal.BorderRadius = 12;
            this.pictureImagemFinal.FillColor = System.Drawing.Color.Black;
            this.pictureImagemFinal.ImageRotate = 0F;
            this.pictureImagemFinal.Location = new System.Drawing.Point(574, 189);
            this.pictureImagemFinal.Name = "pictureImagemFinal";
            this.pictureImagemFinal.Size = new System.Drawing.Size(334, 305);
            this.pictureImagemFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureImagemFinal.TabIndex = 5;
            this.pictureImagemFinal.TabStop = false;
            this.pictureImagemFinal.Click += new System.EventHandler(this.pictureImagemFinal_Click);
            // 
            // pictureImagemOriginal
            // 
            this.pictureImagemOriginal.BackColor = System.Drawing.Color.Transparent;
            this.pictureImagemOriginal.BorderRadius = 12;
            this.pictureImagemOriginal.FillColor = System.Drawing.Color.Black;
            this.pictureImagemOriginal.ImageRotate = 0F;
            this.pictureImagemOriginal.Location = new System.Drawing.Point(95, 47);
            this.pictureImagemOriginal.Name = "pictureImagemOriginal";
            this.pictureImagemOriginal.Size = new System.Drawing.Size(334, 305);
            this.pictureImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureImagemOriginal.TabIndex = 4;
            this.pictureImagemOriginal.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(884, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(24, 26);
            this.guna2ControlBox2.TabIndex = 3;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(914, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(24, 26);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 50;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Fuchsia;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 540);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagemFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnSalvarImagem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnSelecionarImagem;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ComboBox comboFiltros;
        private BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureImagemFinal;
        private Guna.UI2.WinForms.Guna2PictureBox pictureImagemOriginal;
    }
}