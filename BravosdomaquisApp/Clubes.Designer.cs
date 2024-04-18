namespace BravosdomaquisApp
{
    partial class Clubes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelViewAll = new Guna.UI.WinForms.GunaShadowPanel();
            this.DataGridViewListaClubes = new Guna.UI.WinForms.GunaDataGridView();
            this.lblVerListaDescrip = new System.Windows.Forms.Label();
            this.lblVerListaClube = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelSuperior = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAddClubes = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumAdicionados = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescrCampeo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clubesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtualizar = new Guna.UI.WinForms.GunaButton();
            this.lblAtualizar = new System.Windows.Forms.Label();
            this.emblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelViewAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaClubes)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewAll
            // 
            this.panelViewAll.BackColor = System.Drawing.Color.Transparent;
            this.panelViewAll.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelViewAll.Controls.Add(this.DataGridViewListaClubes);
            this.panelViewAll.Controls.Add(this.lblVerListaDescrip);
            this.panelViewAll.Controls.Add(this.lblVerListaClube);
            this.panelViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAll.Location = new System.Drawing.Point(10, 167);
            this.panelViewAll.Name = "panelViewAll";
            this.panelViewAll.Radius = 10;
            this.panelViewAll.ShadowColor = System.Drawing.Color.Black;
            this.panelViewAll.ShadowShift = 3;
            this.panelViewAll.Size = new System.Drawing.Size(962, 452);
            this.panelViewAll.TabIndex = 30;
            // 
            // DataGridViewListaClubes
            // 
            this.DataGridViewListaClubes.AllowUserToAddRows = false;
            this.DataGridViewListaClubes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaClubes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewListaClubes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewListaClubes.AutoGenerateColumns = false;
            this.DataGridViewListaClubes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewListaClubes.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaClubes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewListaClubes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaClubes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewListaClubes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewListaClubes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emblemaDataGridViewTextBoxColumn,
            this.nomeClubeDataGridViewTextBoxColumn,
            this.siglaDataGridViewTextBoxColumn,
            this.Detalhes});
            this.DataGridViewListaClubes.DataSource = this.clubesBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewListaClubes.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewListaClubes.EnableHeadersVisualStyles = false;
            this.DataGridViewListaClubes.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaClubes.Location = new System.Drawing.Point(27, 89);
            this.DataGridViewListaClubes.Name = "DataGridViewListaClubes";
            this.DataGridViewListaClubes.ReadOnly = true;
            this.DataGridViewListaClubes.RowHeadersVisible = false;
            this.DataGridViewListaClubes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewListaClubes.Size = new System.Drawing.Size(911, 339);
            this.DataGridViewListaClubes.TabIndex = 5;
            this.DataGridViewListaClubes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewListaClubes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaClubes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewListaClubes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaClubes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewListaClubes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaClubes.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaClubes.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewListaClubes.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewListaClubes.ThemeStyle.ReadOnly = true;
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewListaClubes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaClubes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaClubes_CellContentClick);
            this.DataGridViewListaClubes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewListaClubes_CellFormatting);
            // 
            // lblVerListaDescrip
            // 
            this.lblVerListaDescrip.AutoSize = true;
            this.lblVerListaDescrip.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblVerListaDescrip.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVerListaDescrip.Location = new System.Drawing.Point(27, 57);
            this.lblVerListaDescrip.Name = "lblVerListaDescrip";
            this.lblVerListaDescrip.Size = new System.Drawing.Size(301, 16);
            this.lblVerListaDescrip.TabIndex = 4;
            this.lblVerListaDescrip.Text = "Veja abaixo a lista de todos os clubes adicionados";
            // 
            // lblVerListaClube
            // 
            this.lblVerListaClube.AutoSize = true;
            this.lblVerListaClube.BackColor = System.Drawing.Color.Transparent;
            this.lblVerListaClube.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblVerListaClube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblVerListaClube.Location = new System.Drawing.Point(24, 21);
            this.lblVerListaClube.Name = "lblVerListaClube";
            this.lblVerListaClube.Size = new System.Drawing.Size(203, 33);
            this.lblVerListaClube.TabIndex = 3;
            this.lblVerListaClube.Text = "Lista de clubes";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 5);
            this.panel5.TabIndex = 31;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelSuperior.Controls.Add(this.lblAtualizar);
            this.panelSuperior.Controls.Add(this.btnAtualizar);
            this.panelSuperior.Controls.Add(this.btnAddClubes);
            this.panelSuperior.Controls.Add(this.panelCard1);
            this.panelSuperior.Controls.Add(this.lblDescrCampeo);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(10, 10);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Radius = 10;
            this.panelSuperior.ShadowColor = System.Drawing.Color.Black;
            this.panelSuperior.ShadowShift = 3;
            this.panelSuperior.Size = new System.Drawing.Size(962, 152);
            this.panelSuperior.TabIndex = 29;
            // 
            // btnAddClubes
            // 
            this.btnAddClubes.AnimationHoverSpeed = 0.07F;
            this.btnAddClubes.AnimationSpeed = 0.03F;
            this.btnAddClubes.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClubes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnAddClubes.BorderColor = System.Drawing.Color.Black;
            this.btnAddClubes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddClubes.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddClubes.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClubes.ForeColor = System.Drawing.Color.White;
            this.btnAddClubes.Image = null;
            this.btnAddClubes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddClubes.Location = new System.Drawing.Point(36, 98);
            this.btnAddClubes.Name = "btnAddClubes";
            this.btnAddClubes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnAddClubes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddClubes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddClubes.OnHoverImage = null;
            this.btnAddClubes.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddClubes.Radius = 8;
            this.btnAddClubes.Size = new System.Drawing.Size(202, 34);
            this.btnAddClubes.TabIndex = 15;
            this.btnAddClubes.Text = "Adicionar clube";
            this.btnAddClubes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddClubes.Click += new System.EventHandler(this.btnAddClubes_Click);
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.lblNumAdicionados);
            this.panelCard1.Controls.Add(this.gunaShadowPanel1);
            this.panelCard1.Location = new System.Drawing.Point(666, 28);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 0;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(272, 89);
            this.panelCard1.TabIndex = 10;
            // 
            // lblNumAdicionados
            // 
            this.lblNumAdicionados.AutoSize = true;
            this.lblNumAdicionados.BackColor = System.Drawing.Color.Transparent;
            this.lblNumAdicionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumAdicionados.Font = new System.Drawing.Font("Montserrat", 42F, System.Drawing.FontStyle.Bold);
            this.lblNumAdicionados.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumAdicionados.Location = new System.Drawing.Point(179, 0);
            this.lblNumAdicionados.Name = "lblNumAdicionados";
            this.lblNumAdicionados.Size = new System.Drawing.Size(93, 77);
            this.lblNumAdicionados.TabIndex = 9;
            this.lblNumAdicionados.Text = "01";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaShadowPanel1.Controls.Add(this.label4);
            this.gunaShadowPanel1.Controls.Add(this.label11);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 0;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(168, 89);
            this.gunaShadowPanel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de clubes adicionados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(5, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Adicionados";
            // 
            // lblDescrCampeo
            // 
            this.lblDescrCampeo.AutoSize = true;
            this.lblDescrCampeo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrCampeo.Location = new System.Drawing.Point(33, 65);
            this.lblDescrCampeo.Name = "lblDescrCampeo";
            this.lblDescrCampeo.Size = new System.Drawing.Size(276, 16);
            this.lblDescrCampeo.TabIndex = 2;
            this.lblDescrCampeo.Text = "Adiciona, edita e visualiza as infor. dos clubes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Clubes";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(972, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 609);
            this.panel4.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 10);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 10);
            this.panel3.TabIndex = 27;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // clubesBindingSource
            // 
            this.clubesBindingSource.DataSource = typeof(Maquis.Models.Domain.Clubes);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AnimationHoverSpeed = 0.07F;
            this.btnAtualizar.AnimationSpeed = 0.03F;
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BaseColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BorderColor = System.Drawing.Color.Black;
            this.btnAtualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtualizar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = global::BravosdomaquisApp.Properties.Resources.troca;
            this.btnAtualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAtualizar.Location = new System.Drawing.Point(244, 98);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.OnHoverBaseColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtualizar.OnHoverImage = null;
            this.btnAtualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtualizar.Radius = 8;
            this.btnAtualizar.Size = new System.Drawing.Size(42, 34);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Tag = "";
            this.btnAtualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            this.btnAtualizar.MouseLeave += new System.EventHandler(this.btnAtualizar_MouseLeave);
            this.btnAtualizar.MouseHover += new System.EventHandler(this.btnAtualizar_MouseHover);
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.AutoSize = true;
            this.lblAtualizar.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblAtualizar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblAtualizar.Location = new System.Drawing.Point(290, 107);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(105, 16);
            this.lblAtualizar.TabIndex = 17;
            this.lblAtualizar.Text = "Actualizar janela";
            this.lblAtualizar.Visible = false;
            // 
            // emblemaDataGridViewTextBoxColumn
            // 
            this.emblemaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emblemaDataGridViewTextBoxColumn.DataPropertyName = "Emblema";
            this.emblemaDataGridViewTextBoxColumn.HeaderText = "Emblema";
            this.emblemaDataGridViewTextBoxColumn.Name = "emblemaDataGridViewTextBoxColumn";
            this.emblemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.emblemaDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomeClubeDataGridViewTextBoxColumn
            // 
            this.nomeClubeDataGridViewTextBoxColumn.DataPropertyName = "NomeClube";
            this.nomeClubeDataGridViewTextBoxColumn.HeaderText = "NomeClube";
            this.nomeClubeDataGridViewTextBoxColumn.Name = "nomeClubeDataGridViewTextBoxColumn";
            this.nomeClubeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siglaDataGridViewTextBoxColumn
            // 
            this.siglaDataGridViewTextBoxColumn.DataPropertyName = "Sigla";
            this.siglaDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.siglaDataGridViewTextBoxColumn.Name = "siglaDataGridViewTextBoxColumn";
            this.siglaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Detalhes
            // 
            this.Detalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalhes.HeaderText = "";
            this.Detalhes.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Width = 50;
            // 
            // Clubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panelViewAll);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Clubes";
            this.Size = new System.Drawing.Size(982, 629);
            this.Load += new System.EventHandler(this.Clubes_Load);
            this.panelViewAll.ResumeLayout(false);
            this.panelViewAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaClubes)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelViewAll;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewListaClubes;
        private System.Windows.Forms.Label lblVerListaDescrip;
        private System.Windows.Forms.Label lblVerListaClube;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaShadowPanel panelSuperior;
        private Guna.UI.WinForms.GunaButton btnAddClubes;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label lblNumAdicionados;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescrCampeo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource clubesBindingSource;
        private Guna.UI.WinForms.GunaButton btnAtualizar;
        private System.Windows.Forms.Label lblAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn emblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
    }
}
