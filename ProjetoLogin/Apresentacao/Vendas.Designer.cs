namespace ProjetoLogin.Apresentacao
{
    partial class FaturaIdTxtBox
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FaturaDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            this.DatadeFaturamentoLbl = new System.Windows.Forms.Label();
            this.QuantidadeNumeric = new ReaLTaiizor.Controls.DungeonNumeric();
            this.QuantidadeVendalbl = new System.Windows.Forms.Label();
            this.EstoqueIdTxtbox = new ReaLTaiizor.Controls.AloneTextBox();
            this.FaturaIdLbl = new System.Windows.Forms.Label();
            this.ExcluirClienteBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.SalvarClienteBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.CadastrarClienteBttn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.ProdutoCartpanel = new System.Windows.Forms.Panel();
            this.ValorUnitTxtBox = new ReaLTaiizor.Controls.AloneTextBox();
            this.ValorUnitLbl = new System.Windows.Forms.Label();
            this.IncluirCarrinhoButton = new ReaLTaiizor.Controls.AirButton();
            this.ProdVendaComboBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            this.VendaProdLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarrinhoDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projetoLoginDataSet = new ProjetoLogin.ProjetoLoginDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new ProjetoLogin.ProjetoLoginDataSetTableAdapters.ProdutosTableAdapter();
            this.ProdutoCartpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarrinhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FaturaDateTime
            // 
            this.FaturaDateTime.Location = new System.Drawing.Point(174, 62);
            this.FaturaDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.FaturaDateTime.Name = "FaturaDateTime";
            this.FaturaDateTime.Size = new System.Drawing.Size(147, 29);
            this.FaturaDateTime.TabIndex = 78;
            // 
            // DatadeFaturamentoLbl
            // 
            this.DatadeFaturamentoLbl.AutoSize = true;
            this.DatadeFaturamentoLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatadeFaturamentoLbl.Location = new System.Drawing.Point(38, 70);
            this.DatadeFaturamentoLbl.Name = "DatadeFaturamentoLbl";
            this.DatadeFaturamentoLbl.Size = new System.Drawing.Size(130, 17);
            this.DatadeFaturamentoLbl.TabIndex = 77;
            this.DatadeFaturamentoLbl.Text = "Data de Faturamento:";
            // 
            // QuantidadeNumeric
            // 
            this.QuantidadeNumeric.BackColor = System.Drawing.Color.Transparent;
            this.QuantidadeNumeric.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.QuantidadeNumeric.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.QuantidadeNumeric.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.QuantidadeNumeric.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.QuantidadeNumeric.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.QuantidadeNumeric.Font = new System.Drawing.Font("Tahoma", 11F);
            this.QuantidadeNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.QuantidadeNumeric.Location = new System.Drawing.Point(142, 49);
            this.QuantidadeNumeric.Maximum = ((long)(2000));
            this.QuantidadeNumeric.Minimum = ((long)(0));
            this.QuantidadeNumeric.MinimumSize = new System.Drawing.Size(93, 28);
            this.QuantidadeNumeric.Name = "QuantidadeNumeric";
            this.QuantidadeNumeric.Size = new System.Drawing.Size(93, 28);
            this.QuantidadeNumeric.TabIndex = 76;
            this.QuantidadeNumeric.Text = "dungeonNumeric1";
            this.QuantidadeNumeric.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.QuantidadeNumeric.Value = ((long)(0));
            // 
            // QuantidadeVendalbl
            // 
            this.QuantidadeVendalbl.AutoSize = true;
            this.QuantidadeVendalbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeVendalbl.Location = new System.Drawing.Point(8, 54);
            this.QuantidadeVendalbl.Name = "QuantidadeVendalbl";
            this.QuantidadeVendalbl.Size = new System.Drawing.Size(128, 17);
            this.QuantidadeVendalbl.TabIndex = 75;
            this.QuantidadeVendalbl.Text = "Quantidade Vendida:";
            // 
            // EstoqueIdTxtbox
            // 
            this.EstoqueIdTxtbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EstoqueIdTxtbox.EnabledCalc = true;
            this.EstoqueIdTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EstoqueIdTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.EstoqueIdTxtbox.Location = new System.Drawing.Point(105, 22);
            this.EstoqueIdTxtbox.MaxLength = 32767;
            this.EstoqueIdTxtbox.MultiLine = false;
            this.EstoqueIdTxtbox.Name = "EstoqueIdTxtbox";
            this.EstoqueIdTxtbox.ReadOnly = false;
            this.EstoqueIdTxtbox.Size = new System.Drawing.Size(67, 29);
            this.EstoqueIdTxtbox.TabIndex = 74;
            this.EstoqueIdTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EstoqueIdTxtbox.UseSystemPasswordChar = false;
            // 
            // FaturaIdLbl
            // 
            this.FaturaIdLbl.AutoSize = true;
            this.FaturaIdLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaturaIdLbl.Location = new System.Drawing.Point(38, 27);
            this.FaturaIdLbl.Name = "FaturaIdLbl";
            this.FaturaIdLbl.Size = new System.Drawing.Size(61, 17);
            this.FaturaIdLbl.TabIndex = 73;
            this.FaturaIdLbl.Text = "Fatura ID:";
            // 
            // ExcluirClienteBttn
            // 
            this.ExcluirClienteBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ExcluirClienteBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.ExcluirClienteBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcluirClienteBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ExcluirClienteBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExcluirClienteBttn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold);
            this.ExcluirClienteBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.ExcluirClienteBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.ExcluirClienteBttn.Location = new System.Drawing.Point(222, 103);
            this.ExcluirClienteBttn.Name = "ExcluirClienteBttn";
            this.ExcluirClienteBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.ExcluirClienteBttn.Size = new System.Drawing.Size(87, 19);
            this.ExcluirClienteBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.ExcluirClienteBttn.TabIndex = 70;
            this.ExcluirClienteBttn.Text = "Excluir";
            this.ExcluirClienteBttn.TextColor = System.Drawing.Color.White;
            this.ExcluirClienteBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.ExcluirClienteBttn.Click += new System.EventHandler(this.ExcluirClienteBttn_Click);
            // 
            // SalvarClienteBttn
            // 
            this.SalvarClienteBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.SalvarClienteBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.SalvarClienteBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarClienteBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SalvarClienteBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalvarClienteBttn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold);
            this.SalvarClienteBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.SalvarClienteBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.SalvarClienteBttn.Location = new System.Drawing.Point(134, 103);
            this.SalvarClienteBttn.Name = "SalvarClienteBttn";
            this.SalvarClienteBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.SalvarClienteBttn.Size = new System.Drawing.Size(85, 19);
            this.SalvarClienteBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.SalvarClienteBttn.TabIndex = 69;
            this.SalvarClienteBttn.Text = "Atualizar";
            this.SalvarClienteBttn.TextColor = System.Drawing.Color.White;
            this.SalvarClienteBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // CadastrarClienteBttn
            // 
            this.CadastrarClienteBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.CadastrarClienteBttn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.CadastrarClienteBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarClienteBttn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.CadastrarClienteBttn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CadastrarClienteBttn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarClienteBttn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.CadastrarClienteBttn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.CadastrarClienteBttn.Location = new System.Drawing.Point(41, 103);
            this.CadastrarClienteBttn.Name = "CadastrarClienteBttn";
            this.CadastrarClienteBttn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.CadastrarClienteBttn.Size = new System.Drawing.Size(87, 19);
            this.CadastrarClienteBttn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.CadastrarClienteBttn.TabIndex = 68;
            this.CadastrarClienteBttn.Text = "Cadastrar";
            this.CadastrarClienteBttn.TextColor = System.Drawing.Color.White;
            this.CadastrarClienteBttn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // ProdutoCartpanel
            // 
            this.ProdutoCartpanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProdutoCartpanel.Controls.Add(this.ValorUnitTxtBox);
            this.ProdutoCartpanel.Controls.Add(this.ValorUnitLbl);
            this.ProdutoCartpanel.Controls.Add(this.IncluirCarrinhoButton);
            this.ProdutoCartpanel.Controls.Add(this.ProdVendaComboBox);
            this.ProdutoCartpanel.Controls.Add(this.VendaProdLbl);
            this.ProdutoCartpanel.Controls.Add(this.QuantidadeNumeric);
            this.ProdutoCartpanel.Controls.Add(this.QuantidadeVendalbl);
            this.ProdutoCartpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProdutoCartpanel.Location = new System.Drawing.Point(28, 147);
            this.ProdutoCartpanel.Name = "ProdutoCartpanel";
            this.ProdutoCartpanel.Size = new System.Drawing.Size(370, 142);
            this.ProdutoCartpanel.TabIndex = 79;
            // 
            // ValorUnitTxtBox
            // 
            this.ValorUnitTxtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ValorUnitTxtBox.EnabledCalc = true;
            this.ValorUnitTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ValorUnitTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ValorUnitTxtBox.Location = new System.Drawing.Point(103, 83);
            this.ValorUnitTxtBox.MaxLength = 32767;
            this.ValorUnitTxtBox.MultiLine = false;
            this.ValorUnitTxtBox.Name = "ValorUnitTxtBox";
            this.ValorUnitTxtBox.ReadOnly = false;
            this.ValorUnitTxtBox.Size = new System.Drawing.Size(109, 29);
            this.ValorUnitTxtBox.TabIndex = 81;
            this.ValorUnitTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ValorUnitTxtBox.UseSystemPasswordChar = false;
            // 
            // ValorUnitLbl
            // 
            this.ValorUnitLbl.AutoSize = true;
            this.ValorUnitLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorUnitLbl.Location = new System.Drawing.Point(9, 90);
            this.ValorUnitLbl.Name = "ValorUnitLbl";
            this.ValorUnitLbl.Size = new System.Drawing.Size(88, 17);
            this.ValorUnitLbl.TabIndex = 80;
            this.ValorUnitLbl.Text = "Valor Unitário:";
            // 
            // IncluirCarrinhoButton
            // 
            this.IncluirCarrinhoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.IncluirCarrinhoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncluirCarrinhoButton.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.IncluirCarrinhoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IncluirCarrinhoButton.Image = null;
            this.IncluirCarrinhoButton.Location = new System.Drawing.Point(255, 112);
            this.IncluirCarrinhoButton.Name = "IncluirCarrinhoButton";
            this.IncluirCarrinhoButton.NoRounding = false;
            this.IncluirCarrinhoButton.Size = new System.Drawing.Size(100, 27);
            this.IncluirCarrinhoButton.TabIndex = 80;
            this.IncluirCarrinhoButton.Text = "Incluir";
            this.IncluirCarrinhoButton.Transparent = false;
            // 
            // ProdVendaComboBox
            // 
            this.ProdVendaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ProdVendaComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdVendaComboBox.DataSource = this.produtosBindingSource;
            this.ProdVendaComboBox.DisplayMember = "NomeProduto";
            this.ProdVendaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProdVendaComboBox.DropDownHeight = 100;
            this.ProdVendaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdVendaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProdVendaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ProdVendaComboBox.FormattingEnabled = true;
            this.ProdVendaComboBox.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ProdVendaComboBox.IntegralHeight = false;
            this.ProdVendaComboBox.ItemHeight = 20;
            this.ProdVendaComboBox.Location = new System.Drawing.Point(73, 17);
            this.ProdVendaComboBox.Name = "ProdVendaComboBox";
            this.ProdVendaComboBox.Size = new System.Drawing.Size(282, 26);
            this.ProdVendaComboBox.StartIndex = 0;
            this.ProdVendaComboBox.TabIndex = 81;
            this.ProdVendaComboBox.ValueMember = "IdGrupoProduto";
            // 
            // VendaProdLbl
            // 
            this.VendaProdLbl.AutoSize = true;
            this.VendaProdLbl.Font = new System.Drawing.Font("Sora", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendaProdLbl.Location = new System.Drawing.Point(10, 17);
            this.VendaProdLbl.Name = "VendaProdLbl";
            this.VendaProdLbl.Size = new System.Drawing.Size(57, 17);
            this.VendaProdLbl.TabIndex = 80;
            this.VendaProdLbl.Text = "Produto:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CarrinhoDataGridView);
            this.panel1.Location = new System.Drawing.Point(425, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 277);
            this.panel1.TabIndex = 80;
            // 
            // CarrinhoDataGridView
            // 
            this.CarrinhoDataGridView.AllowUserToResizeRows = false;
            this.CarrinhoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CarrinhoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarrinhoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CarrinhoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarrinhoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CarrinhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarrinhoDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CarrinhoDataGridView.EnableHeadersVisualStyles = false;
            this.CarrinhoDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CarrinhoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CarrinhoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.CarrinhoDataGridView.Name = "CarrinhoDataGridView";
            this.CarrinhoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarrinhoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CarrinhoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CarrinhoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarrinhoDataGridView.Size = new System.Drawing.Size(267, 271);
            this.CarrinhoDataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(27, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 121);
            this.panel2.TabIndex = 81;
            // 
            // projetoLoginDataSet
            // 
            this.projetoLoginDataSet.DataSetName = "ProjetoLoginDataSet";
            this.projetoLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.projetoLoginDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FaturaIdTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FaturaDateTime);
            this.Controls.Add(this.DatadeFaturamentoLbl);
            this.Controls.Add(this.EstoqueIdTxtbox);
            this.Controls.Add(this.FaturaIdLbl);
            this.Controls.Add(this.ExcluirClienteBttn);
            this.Controls.Add(this.SalvarClienteBttn);
            this.Controls.Add(this.CadastrarClienteBttn);
            this.Controls.Add(this.ProdutoCartpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FaturaIdTxtBox";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FaturaIdTxtBox_Load);
            this.ProdutoCartpanel.ResumeLayout(false);
            this.ProdutoCartpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarrinhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDateTime FaturaDateTime;
        private System.Windows.Forms.Label DatadeFaturamentoLbl;
        private ReaLTaiizor.Controls.DungeonNumeric QuantidadeNumeric;
        private System.Windows.Forms.Label QuantidadeVendalbl;
        private ReaLTaiizor.Controls.AloneTextBox EstoqueIdTxtbox;
        private System.Windows.Forms.Label FaturaIdLbl;
        private ReaLTaiizor.Controls.HopeRoundButton ExcluirClienteBttn;
        private ReaLTaiizor.Controls.HopeRoundButton SalvarClienteBttn;
        private ReaLTaiizor.Controls.HopeRoundButton CadastrarClienteBttn;
        private System.Windows.Forms.Panel ProdutoCartpanel;
        private ReaLTaiizor.Controls.ComboBoxEdit ProdVendaComboBox;
        private System.Windows.Forms.Label VendaProdLbl;
        private ReaLTaiizor.Controls.AloneTextBox ValorUnitTxtBox;
        private System.Windows.Forms.Label ValorUnitLbl;
        private ReaLTaiizor.Controls.AirButton IncluirCarrinhoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.PoisonDataGridView CarrinhoDataGridView;
        private ProjetoLoginDataSet projetoLoginDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private ProjetoLoginDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
    }
}