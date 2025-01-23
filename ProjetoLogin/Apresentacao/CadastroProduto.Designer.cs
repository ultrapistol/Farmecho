namespace ProjetoLogin.Apresentacao
{
    partial class CadastroProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.ProdutoDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoLoginDataSet = new ProjetoLogin.ProjetoLoginDataSet();
            this.ExcluirProdBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.AtualizarProdBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.CadastrarProdBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.projetoLoginProdutoDataSet = new ProjetoLogin.ProjetoLoginProdutoDataSet();
            this.projetoLoginProdutoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new ProjetoLogin.ProjetoLoginDataSetTableAdapters.ProdutosTableAdapter();
            this.NomeProdLbl = new System.Windows.Forms.Label();
            this.ValorProdLbl = new System.Windows.Forms.Label();
            this.CategProdLbl = new System.Windows.Forms.Label();
            this.NomeProdTextBox = new ReaLTaiizor.Controls.AloneTextBox();
            this.ValorProdTextBox = new ReaLTaiizor.Controls.AloneTextBox();
            this.projetoLoginDataSet1 = new ProjetoLogin.ProjetoLoginDataSet1();
            this.grupoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoProdutoTableAdapter = new ProjetoLogin.ProjetoLoginDataSet1TableAdapters.GrupoProdutoTableAdapter();
            this.ProdCateComboBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            this.IdProdTextBox = new ReaLTaiizor.Controls.AloneTextBox();
            this.IdProdLabel = new System.Windows.Forms.Label();
            this.PesquisarProdBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginProdutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginProdutoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoDataGridView
            // 
            this.ProdutoDataGridView.AllowUserToAddRows = false;
            this.ProdutoDataGridView.AllowUserToDeleteRows = false;
            this.ProdutoDataGridView.AllowUserToResizeRows = false;
            this.ProdutoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProdutoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdutoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProdutoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdutoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdutoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutoDataGridView.EnableHeadersVisualStyles = false;
            this.ProdutoDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProdutoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProdutoDataGridView.Location = new System.Drawing.Point(26, 250);
            this.ProdutoDataGridView.Name = "ProdutoDataGridView";
            this.ProdutoDataGridView.ReadOnly = true;
            this.ProdutoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdutoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProdutoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutoDataGridView.Size = new System.Drawing.Size(443, 123);
            this.ProdutoDataGridView.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.ProdutoDataGridView.TabIndex = 9;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.projetoLoginDataSet;
            // 
            // projetoLoginDataSet
            // 
            this.projetoLoginDataSet.DataSetName = "ProjetoLoginDataSet";
            this.projetoLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExcluirProdBttn
            // 
            this.ExcluirProdBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ExcluirProdBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.ExcluirProdBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcluirProdBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ExcluirProdBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExcluirProdBttn.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ExcluirProdBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.ExcluirProdBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.ExcluirProdBttn.Location = new System.Drawing.Point(258, 203);
            this.ExcluirProdBttn.Name = "ExcluirProdBttn";
            this.ExcluirProdBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.ExcluirProdBttn.Size = new System.Drawing.Size(100, 31);
            this.ExcluirProdBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.ExcluirProdBttn.TabIndex = 8;
            this.ExcluirProdBttn.Text = "Excluir";
            this.ExcluirProdBttn.TextColor = System.Drawing.Color.White;
            this.ExcluirProdBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.ExcluirProdBttn.Click += new System.EventHandler(this.ExcluirProdBttn_Click);
            // 
            // AtualizarProdBttn
            // 
            this.AtualizarProdBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.AtualizarProdBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.AtualizarProdBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtualizarProdBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.AtualizarProdBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AtualizarProdBttn.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.AtualizarProdBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.AtualizarProdBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.AtualizarProdBttn.Location = new System.Drawing.Point(149, 203);
            this.AtualizarProdBttn.Name = "AtualizarProdBttn";
            this.AtualizarProdBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.AtualizarProdBttn.Size = new System.Drawing.Size(103, 31);
            this.AtualizarProdBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.AtualizarProdBttn.TabIndex = 7;
            this.AtualizarProdBttn.Text = "Atualizar";
            this.AtualizarProdBttn.TextColor = System.Drawing.Color.White;
            this.AtualizarProdBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.AtualizarProdBttn.Click += new System.EventHandler(this.AtualizarProdBttn_Click);
            // 
            // CadastrarProdBttn
            // 
            this.CadastrarProdBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.CadastrarProdBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.CadastrarProdBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarProdBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.CadastrarProdBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CadastrarProdBttn.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarProdBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.CadastrarProdBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.CadastrarProdBttn.Location = new System.Drawing.Point(32, 203);
            this.CadastrarProdBttn.Name = "CadastrarProdBttn";
            this.CadastrarProdBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.CadastrarProdBttn.Size = new System.Drawing.Size(111, 31);
            this.CadastrarProdBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.CadastrarProdBttn.TabIndex = 5;
            this.CadastrarProdBttn.Text = "Cadastrar";
            this.CadastrarProdBttn.TextColor = System.Drawing.Color.White;
            this.CadastrarProdBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.CadastrarProdBttn.Click += new System.EventHandler(this.CadastrarProdBttn_Click);
            // 
            // projetoLoginProdutoDataSet
            // 
            this.projetoLoginProdutoDataSet.DataSetName = "ProjetoLoginProdutoDataSet";
            this.projetoLoginProdutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetoLoginProdutoDataSetBindingSource
            // 
            this.projetoLoginProdutoDataSetBindingSource.DataSource = this.projetoLoginProdutoDataSet;
            this.projetoLoginProdutoDataSetBindingSource.Position = 0;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // NomeProdLbl
            // 
            this.NomeProdLbl.AutoSize = true;
            this.NomeProdLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProdLbl.Location = new System.Drawing.Point(73, 89);
            this.NomeProdLbl.Name = "NomeProdLbl";
            this.NomeProdLbl.Size = new System.Drawing.Size(112, 17);
            this.NomeProdLbl.TabIndex = 10;
            this.NomeProdLbl.Text = "Nome do Produto:";
            // 
            // ValorProdLbl
            // 
            this.ValorProdLbl.AutoSize = true;
            this.ValorProdLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorProdLbl.Location = new System.Drawing.Point(73, 134);
            this.ValorProdLbl.Name = "ValorProdLbl";
            this.ValorProdLbl.Size = new System.Drawing.Size(58, 17);
            this.ValorProdLbl.TabIndex = 11;
            this.ValorProdLbl.Text = "Valor R$:";
            // 
            // CategProdLbl
            // 
            this.CategProdLbl.AutoSize = true;
            this.CategProdLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategProdLbl.Location = new System.Drawing.Point(248, 135);
            this.CategProdLbl.Name = "CategProdLbl";
            this.CategProdLbl.Size = new System.Drawing.Size(66, 17);
            this.CategProdLbl.TabIndex = 13;
            this.CategProdLbl.Text = "Categoria:";
            // 
            // NomeProdTextBox
            // 
            this.NomeProdTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NomeProdTextBox.EnabledCalc = true;
            this.NomeProdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NomeProdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.NomeProdTextBox.Location = new System.Drawing.Point(191, 86);
            this.NomeProdTextBox.MaxLength = 32767;
            this.NomeProdTextBox.MultiLine = false;
            this.NomeProdTextBox.Name = "NomeProdTextBox";
            this.NomeProdTextBox.ReadOnly = false;
            this.NomeProdTextBox.Size = new System.Drawing.Size(264, 29);
            this.NomeProdTextBox.TabIndex = 14;
            this.NomeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NomeProdTextBox.UseSystemPasswordChar = false;
            // 
            // ValorProdTextBox
            // 
            this.ValorProdTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ValorProdTextBox.EnabledCalc = true;
            this.ValorProdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ValorProdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ValorProdTextBox.Location = new System.Drawing.Point(137, 128);
            this.ValorProdTextBox.MaxLength = 32767;
            this.ValorProdTextBox.MultiLine = false;
            this.ValorProdTextBox.Name = "ValorProdTextBox";
            this.ValorProdTextBox.ReadOnly = false;
            this.ValorProdTextBox.Size = new System.Drawing.Size(97, 29);
            this.ValorProdTextBox.TabIndex = 15;
            this.ValorProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ValorProdTextBox.UseSystemPasswordChar = false;
            // 
            // projetoLoginDataSet1
            // 
            this.projetoLoginDataSet1.DataSetName = "ProjetoLoginDataSet1";
            this.projetoLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupoProdutoBindingSource
            // 
            this.grupoProdutoBindingSource.DataMember = "GrupoProduto";
            this.grupoProdutoBindingSource.DataSource = this.projetoLoginDataSet1;
            // 
            // grupoProdutoTableAdapter
            // 
            this.grupoProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // ProdCateComboBox
            // 
            this.ProdCateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ProdCateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdCateComboBox.DataSource = this.grupoProdutoBindingSource;
            this.ProdCateComboBox.DisplayMember = "GrupoProduto";
            this.ProdCateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProdCateComboBox.DropDownHeight = 100;
            this.ProdCateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdCateComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProdCateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ProdCateComboBox.FormattingEnabled = true;
            this.ProdCateComboBox.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ProdCateComboBox.IntegralHeight = false;
            this.ProdCateComboBox.ItemHeight = 20;
            this.ProdCateComboBox.Location = new System.Drawing.Point(320, 131);
            this.ProdCateComboBox.Name = "ProdCateComboBox";
            this.ProdCateComboBox.Size = new System.Drawing.Size(135, 26);
            this.ProdCateComboBox.StartIndex = 0;
            this.ProdCateComboBox.TabIndex = 17;
            this.ProdCateComboBox.ValueMember = "IdGrupoProduto";
            // 
            // IdProdTextBox
            // 
            this.IdProdTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IdProdTextBox.Enabled = false;
            this.IdProdTextBox.EnabledCalc = true;
            this.IdProdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdProdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.IdProdTextBox.Location = new System.Drawing.Point(103, 47);
            this.IdProdTextBox.MaxLength = 32767;
            this.IdProdTextBox.MultiLine = false;
            this.IdProdTextBox.Name = "IdProdTextBox";
            this.IdProdTextBox.ReadOnly = false;
            this.IdProdTextBox.Size = new System.Drawing.Size(44, 29);
            this.IdProdTextBox.TabIndex = 19;
            this.IdProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IdProdTextBox.UseSystemPasswordChar = false;
            this.IdProdTextBox.TextChanged += new System.EventHandler(this.aloneTextBox1_TextChanged);
            // 
            // IdProdLabel
            // 
            this.IdProdLabel.AutoSize = true;
            this.IdProdLabel.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProdLabel.Location = new System.Drawing.Point(75, 49);
            this.IdProdLabel.Name = "IdProdLabel";
            this.IdProdLabel.Size = new System.Drawing.Size(22, 17);
            this.IdProdLabel.TabIndex = 18;
            this.IdProdLabel.Text = "Id:";
            this.IdProdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PesquisarProdBttn
            // 
            this.PesquisarProdBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.PesquisarProdBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarProdBttn.BackgroundImage")));
            this.PesquisarProdBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PesquisarProdBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisarProdBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarProdBttn.Location = new System.Drawing.Point(158, 50);
            this.PesquisarProdBttn.Name = "PesquisarProdBttn";
            this.PesquisarProdBttn.Size = new System.Drawing.Size(22, 24);
            this.PesquisarProdBttn.TabIndex = 56;
            this.PesquisarProdBttn.UseVisualStyleBackColor = false;
            this.PesquisarProdBttn.Click += new System.EventHandler(this.PesquisarProdBttn_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PesquisarProdBttn);
            this.Controls.Add(this.IdProdTextBox);
            this.Controls.Add(this.IdProdLabel);
            this.Controls.Add(this.ProdCateComboBox);
            this.Controls.Add(this.ValorProdTextBox);
            this.Controls.Add(this.NomeProdTextBox);
            this.Controls.Add(this.CategProdLbl);
            this.Controls.Add(this.ValorProdLbl);
            this.Controls.Add(this.NomeProdLbl);
            this.Controls.Add(this.ProdutoDataGridView);
            this.Controls.Add(this.ExcluirProdBttn);
            this.Controls.Add(this.AtualizarProdBttn);
            this.Controls.Add(this.CadastrarProdBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProduto";
            this.Text = "CadastrodeProduto";
            this.Load += new System.EventHandler(this.FormSubMenu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginProdutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginProdutoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView ProdutoDataGridView;
        private ReaLTaiizor.Controls.HopeRoundButton ExcluirProdBttn;
        private ReaLTaiizor.Controls.HopeRoundButton AtualizarProdBttn;
        private ReaLTaiizor.Controls.HopeRoundButton CadastrarProdBttn;
        private System.Windows.Forms.BindingSource projetoLoginProdutoDataSetBindingSource;
        private ProjetoLoginProdutoDataSet projetoLoginProdutoDataSet;
        private ProjetoLoginDataSet projetoLoginDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private ProjetoLoginDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Label NomeProdLbl;
        private System.Windows.Forms.Label ValorProdLbl;
        private System.Windows.Forms.Label CategProdLbl;
        private ReaLTaiizor.Controls.AloneTextBox NomeProdTextBox;
        private ReaLTaiizor.Controls.AloneTextBox ValorProdTextBox;
        private ProjetoLoginDataSet1 projetoLoginDataSet1;
        private System.Windows.Forms.BindingSource grupoProdutoBindingSource;
        private ProjetoLoginDataSet1TableAdapters.GrupoProdutoTableAdapter grupoProdutoTableAdapter;
        private ReaLTaiizor.Controls.ComboBoxEdit ProdCateComboBox;
        private ReaLTaiizor.Controls.AloneTextBox IdProdTextBox;
        private System.Windows.Forms.Label IdProdLabel;
        private System.Windows.Forms.Button PesquisarProdBttn;
    }
}