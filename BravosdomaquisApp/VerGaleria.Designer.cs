﻿namespace BravosdomaquisApp
{
    partial class VerGaleria
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblInfoNotify = new System.Windows.Forms.Label();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.lblFecharInfoMembro = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(66, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 37);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "Galeria Bravos do Maquis";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.galery;
            this.pictureBox3.Location = new System.Drawing.Point(32, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // lblInfoNotify
            // 
            this.lblInfoNotify.AutoSize = true;
            this.lblInfoNotify.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblInfoNotify.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoNotify.Location = new System.Drawing.Point(29, 57);
            this.lblInfoNotify.Name = "lblInfoNotify";
            this.lblInfoNotify.Size = new System.Drawing.Size(271, 16);
            this.lblInfoNotify.TabIndex = 71;
            this.lblInfoNotify.Text = "Veja abaixo as imagens presentes na galeria!";
            // 
            // btnFechar
            // 
            this.btnFechar.AnimationHoverSpeed = 0.07F;
            this.btnFechar.AnimationSpeed = 0.03F;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFechar.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::BravosdomaquisApp.Properties.Resources.x;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(685, 26);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 76;
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFecharInfoMembro_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // lblFecharInfoMembro
            // 
            this.lblFecharInfoMembro.AutoSize = true;
            this.lblFecharInfoMembro.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lblFecharInfoMembro.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblFecharInfoMembro.Location = new System.Drawing.Point(674, 58);
            this.lblFecharInfoMembro.Name = "lblFecharInfoMembro";
            this.lblFecharInfoMembro.Size = new System.Drawing.Size(54, 15);
            this.lblFecharInfoMembro.TabIndex = 75;
            this.lblFecharInfoMembro.Text = "Cancelar";
            this.lblFecharInfoMembro.Visible = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(32, 85);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.flowLayoutPanel.Size = new System.Drawing.Size(695, 635);
            this.flowLayoutPanel.TabIndex = 77;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // VerGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 740);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblFecharInfoMembro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblInfoNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerGaleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerGaleria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblInfoNotify;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblFecharInfoMembro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}