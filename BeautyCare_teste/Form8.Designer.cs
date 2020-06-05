namespace BeautyCare_teste
{
    partial class consultacolaboradores
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versão100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.datatoolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.horatoolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.desenvolvidotoolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.consultacolaboradoresvScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.consultacolaboradoresdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpconsultacolaboradores = new System.Windows.Forms.GroupBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.datanascdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.cmbservico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcolaborador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pctboxlogo = new System.Windows.Forms.PictureBox();
            this.btnexportaparaxls = new System.Windows.Forms.Button();
            this.btnimprimirconsulta = new System.Windows.Forms.Button();
            this.btnabrirperfilcolaborador = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultacolaboradoresdataGridView1)).BeginInit();
            this.grpconsultacolaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 26);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendamentoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.colaboradorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colaboradorToolStripMenuItem.Text = "Colaborador";
            this.colaboradorToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendamentoToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.colaboradorToolStripMenuItem1});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.consultaToolStripMenuItem.Text = "Consultar";
            // 
            // agendamentoToolStripMenuItem1
            // 
            this.agendamentoToolStripMenuItem1.Name = "agendamentoToolStripMenuItem1";
            this.agendamentoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agendamentoToolStripMenuItem1.Text = "Agendamento";
            this.agendamentoToolStripMenuItem1.Click += new System.EventHandler(this.agendamentoToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // colaboradorToolStripMenuItem1
            // 
            this.colaboradorToolStripMenuItem1.Name = "colaboradorToolStripMenuItem1";
            this.colaboradorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.colaboradorToolStripMenuItem1.Text = "Colaborador";
            this.colaboradorToolStripMenuItem1.Click += new System.EventHandler(this.colaboradorToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versão100ToolStripMenuItem});
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            // 
            // versão100ToolStripMenuItem
            // 
            this.versão100ToolStripMenuItem.Name = "versão100ToolStripMenuItem";
            this.versão100ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versão100ToolStripMenuItem.Text = "Versão 1.0.0";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.sairToolStripMenuItem.Tag = "";
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datatoolStripStatusLabel1,
            this.horatoolStripStatusLabel2,
            this.desenvolvidotoolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 106;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // datatoolStripStatusLabel1
            // 
            this.datatoolStripStatusLabel1.AutoSize = false;
            this.datatoolStripStatusLabel1.Name = "datatoolStripStatusLabel1";
            this.datatoolStripStatusLabel1.Size = new System.Drawing.Size(451, 17);
            this.datatoolStripStatusLabel1.Spring = true;
            this.datatoolStripStatusLabel1.Text = "Data";
            // 
            // horatoolStripStatusLabel2
            // 
            this.horatoolStripStatusLabel2.AutoSize = false;
            this.horatoolStripStatusLabel2.Name = "horatoolStripStatusLabel2";
            this.horatoolStripStatusLabel2.Size = new System.Drawing.Size(451, 17);
            this.horatoolStripStatusLabel2.Spring = true;
            this.horatoolStripStatusLabel2.Text = "Hora";
            // 
            // desenvolvidotoolStripStatusLabel3
            // 
            this.desenvolvidotoolStripStatusLabel3.AutoSize = false;
            this.desenvolvidotoolStripStatusLabel3.Name = "desenvolvidotoolStripStatusLabel3";
            this.desenvolvidotoolStripStatusLabel3.Size = new System.Drawing.Size(451, 17);
            this.desenvolvidotoolStripStatusLabel3.Spring = true;
            this.desenvolvidotoolStripStatusLabel3.Text = "Desenvolvido por: Inside Code Company®";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // consultacolaboradoresvScrollBar1
            // 
            this.consultacolaboradoresvScrollBar1.Location = new System.Drawing.Point(1036, 249);
            this.consultacolaboradoresvScrollBar1.Name = "consultacolaboradoresvScrollBar1";
            this.consultacolaboradoresvScrollBar1.Size = new System.Drawing.Size(14, 398);
            this.consultacolaboradoresvScrollBar1.TabIndex = 116;
            // 
            // consultacolaboradoresdataGridView1
            // 
            this.consultacolaboradoresdataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultacolaboradoresdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultacolaboradoresdataGridView1.ColumnHeadersHeight = 30;
            this.consultacolaboradoresdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultacolaboradoresdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consultacolaboradoresdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.consultacolaboradoresdataGridView1.Location = new System.Drawing.Point(49, 248);
            this.consultacolaboradoresdataGridView1.Name = "consultacolaboradoresdataGridView1";
            this.consultacolaboradoresdataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultacolaboradoresdataGridView1.Size = new System.Drawing.Size(1002, 400);
            this.consultacolaboradoresdataGridView1.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Colaborador";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data Nasc.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sexo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefone";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Endereço";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "E-mail";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Serviços";
            this.Column7.Name = "Column7";
            // 
            // grpconsultacolaboradores
            // 
            this.grpconsultacolaboradores.Controls.Add(this.cmbsexo);
            this.grpconsultacolaboradores.Controls.Add(this.datanascdateTimePicker1);
            this.grpconsultacolaboradores.Controls.Add(this.label18);
            this.grpconsultacolaboradores.Controls.Add(this.btnpesquisar);
            this.grpconsultacolaboradores.Controls.Add(this.btnlimpar);
            this.grpconsultacolaboradores.Controls.Add(this.cmbservico);
            this.grpconsultacolaboradores.Controls.Add(this.label5);
            this.grpconsultacolaboradores.Controls.Add(this.label6);
            this.grpconsultacolaboradores.Controls.Add(this.cmbcolaborador);
            this.grpconsultacolaboradores.Controls.Add(this.label3);
            this.grpconsultacolaboradores.Controls.Add(this.label1);
            this.grpconsultacolaboradores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpconsultacolaboradores.Location = new System.Drawing.Point(49, 86);
            this.grpconsultacolaboradores.Name = "grpconsultacolaboradores";
            this.grpconsultacolaboradores.Size = new System.Drawing.Size(1002, 141);
            this.grpconsultacolaboradores.TabIndex = 0;
            this.grpconsultacolaboradores.TabStop = false;
            // 
            // cmbsexo
            // 
            this.cmbsexo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Location = new System.Drawing.Point(607, 61);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(379, 26);
            this.cmbsexo.TabIndex = 5;
            this.cmbsexo.Text = "<Selecione o Sexo...>";
            // 
            // datanascdateTimePicker1
            // 
            this.datanascdateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascdateTimePicker1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascdateTimePicker1.Location = new System.Drawing.Point(607, 19);
            this.datanascdateTimePicker1.Name = "datanascdateTimePicker1";
            this.datanascdateTimePicker1.Size = new System.Drawing.Size(150, 26);
            this.datanascdateTimePicker1.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(490, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 33);
            this.label18.TabIndex = 4;
            this.label18.Text = "+";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(807, 97);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(180, 32);
            this.btnpesquisar.TabIndex = 7;
            this.btnpesquisar.Text = "Pesqui&sar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Enabled = false;
            this.btnlimpar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(607, 97);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(180, 32);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // cmbservico
            // 
            this.cmbservico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbservico.FormattingEnabled = true;
            this.cmbservico.Location = new System.Drawing.Point(109, 61);
            this.cmbservico.Name = "cmbservico";
            this.cmbservico.Size = new System.Drawing.Size(380, 26);
            this.cmbservico.TabIndex = 3;
            this.cmbservico.Text = "<Selecione o Serviço...>";
            this.cmbservico.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 94;
            this.label5.Text = "Serviço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 92;
            this.label6.Text = "Sexo:";
            // 
            // cmbcolaborador
            // 
            this.cmbcolaborador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcolaborador.FormattingEnabled = true;
            this.cmbcolaborador.Location = new System.Drawing.Point(109, 22);
            this.cmbcolaborador.Name = "cmbcolaborador";
            this.cmbcolaborador.Size = new System.Drawing.Size(380, 26);
            this.cmbcolaborador.TabIndex = 1;
            this.cmbcolaborador.Text = "<Selecione o Colaborador...>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Colaborador: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Nasc.:";
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImage = global::BeautyCare_teste.Properties.Resources.home1;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Transparent;
            this.btnhome.Location = new System.Drawing.Point(1302, 38);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(39, 35);
            this.btnhome.TabIndex = 10;
            this.btnhome.Tag = "";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(1180, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 33);
            this.label17.TabIndex = 112;
            this.label17.Text = "hora";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctboxlogo
            // 
            this.pctboxlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctboxlogo.Image = global::BeautyCare_teste.Properties.Resources.sem_logo;
            this.pctboxlogo.Location = new System.Drawing.Point(1130, 86);
            this.pctboxlogo.Name = "pctboxlogo";
            this.pctboxlogo.Size = new System.Drawing.Size(210, 198);
            this.pctboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxlogo.TabIndex = 111;
            this.pctboxlogo.TabStop = false;
            // 
            // btnexportaparaxls
            // 
            this.btnexportaparaxls.Enabled = false;
            this.btnexportaparaxls.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportaparaxls.Location = new System.Drawing.Point(1110, 463);
            this.btnexportaparaxls.Name = "btnexportaparaxls";
            this.btnexportaparaxls.Size = new System.Drawing.Size(230, 50);
            this.btnexportaparaxls.TabIndex = 13;
            this.btnexportaparaxls.Text = "&Exportar para XLS";
            this.btnexportaparaxls.UseVisualStyleBackColor = true;
            // 
            // btnimprimirconsulta
            // 
            this.btnimprimirconsulta.Enabled = false;
            this.btnimprimirconsulta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirconsulta.Location = new System.Drawing.Point(1110, 398);
            this.btnimprimirconsulta.Name = "btnimprimirconsulta";
            this.btnimprimirconsulta.Size = new System.Drawing.Size(230, 50);
            this.btnimprimirconsulta.TabIndex = 12;
            this.btnimprimirconsulta.Text = "Im&primir Consulta";
            this.btnimprimirconsulta.UseVisualStyleBackColor = true;
            // 
            // btnabrirperfilcolaborador
            // 
            this.btnabrirperfilcolaborador.Enabled = false;
            this.btnabrirperfilcolaborador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrirperfilcolaborador.Location = new System.Drawing.Point(1110, 333);
            this.btnabrirperfilcolaborador.Name = "btnabrirperfilcolaborador";
            this.btnabrirperfilcolaborador.Size = new System.Drawing.Size(230, 50);
            this.btnabrirperfilcolaborador.TabIndex = 11;
            this.btnabrirperfilcolaborador.Text = "&Abrir Perfil Colaborador";
            this.btnabrirperfilcolaborador.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 36);
            this.label8.TabIndex = 107;
            this.label8.Text = "> Consulta Colaboradores";
            // 
            // consultacolaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.consultacolaboradoresvScrollBar1);
            this.Controls.Add(this.consultacolaboradoresdataGridView1);
            this.Controls.Add(this.grpconsultacolaboradores);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pctboxlogo);
            this.Controls.Add(this.btnexportaparaxls);
            this.Controls.Add(this.btnimprimirconsulta);
            this.Controls.Add(this.btnabrirperfilcolaborador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "consultacolaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty Care - Consulta Colaboradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultacolaboradoresdataGridView1)).EndInit();
            this.grpconsultacolaboradores.ResumeLayout(false);
            this.grpconsultacolaboradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versão100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel datatoolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel horatoolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel desenvolvidotoolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.VScrollBar consultacolaboradoresvScrollBar1;
        private System.Windows.Forms.DataGridView consultacolaboradoresdataGridView1;
        private System.Windows.Forms.GroupBox grpconsultacolaboradores;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.ComboBox cmbservico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcolaborador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pctboxlogo;
        private System.Windows.Forms.Button btnexportaparaxls;
        private System.Windows.Forms.Button btnimprimirconsulta;
        private System.Windows.Forms.Button btnabrirperfilcolaborador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.DateTimePicker datanascdateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}