namespace BravosdomaquisApp
{
    partial class PreVeiwImagem
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
            this.panelInfoMembro = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblDescrTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelInfoMembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfoMembro
            // 
            this.panelInfoMembro.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoMembro.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelInfoMembro.Controls.Add(this.guna2ControlBox1);
            this.panelInfoMembro.Controls.Add(this.lblDescrTitulo);
            this.panelInfoMembro.Controls.Add(this.pictureBox1);
            this.panelInfoMembro.Controls.Add(this.btnFechar);
            this.panelInfoMembro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoMembro.Location = new System.Drawing.Point(0, 0);
            this.panelInfoMembro.Name = "panelInfoMembro";
            this.panelInfoMembro.Radius = 10;
            this.panelInfoMembro.ShadowColor = System.Drawing.Color.Black;
            this.panelInfoMembro.Size = new System.Drawing.Size(884, 700);
            this.panelInfoMembro.TabIndex = 41;
            // 
            // lblDescrTitulo
            // 
            this.lblDescrTitulo.AutoSize = true;
            this.lblDescrTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDescrTitulo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrTitulo.Location = new System.Drawing.Point(24, 19);
            this.lblDescrTitulo.Name = "lblDescrTitulo";
            this.lblDescrTitulo.Size = new System.Drawing.Size(194, 18);
            this.lblDescrTitulo.TabIndex = 43;
            this.lblDescrTitulo.Text = "Pre-visualização de imagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(18, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AnimationHoverSpeed = 0.07F;
            this.btnFechar.AnimationSpeed = 0.03F;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFechar.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::BravosdomaquisApp.Properties.Resources.x;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(838, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 41;
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(788, 19);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 44;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelInfoMembro;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // PreVeiwImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 700);
            this.Controls.Add(this.panelInfoMembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreVeiwImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreVeiwImagem";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelInfoMembro.ResumeLayout(false);
            this.panelInfoMembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelInfoMembro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblDescrTitulo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}