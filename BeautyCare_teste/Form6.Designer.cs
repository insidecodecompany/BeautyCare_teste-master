namespace BeautyCare_teste
{
    partial class telaconsultaagendamentos
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
            this.label17 = new System.Windows.Forms.Label();
            this.btnexportaparaxls = new System.Windows.Forms.Button();
            this.btnimprimirconsulta = new System.Windows.Forms.Button();
            this.btnabriragendamento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpconsultaagendamentos = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.cmbformapgto = new System.Windows.Forms.ComboBox();
            this.cmbservico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcolaborador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.atedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.consultaagendamentosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnhome = new System.Windows.Forms.Button();
            this.pctboxlogo = new System.Windows.Forms.PictureBox();
            this.consultaagendamentosvScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpconsultaagendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaagendamentosdataGridView1)).BeginInit();
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
            this.menuStrip1.TabIndex = 30;
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
            this.statusStrip1.TabIndex = 54;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(1180, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 33);
            this.label17.TabIndex = 89;
            this.label17.Text = "hora";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnexportaparaxls
            // 
            this.btnexportaparaxls.Enabled = false;
            this.btnexportaparaxls.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportaparaxls.Location = new System.Drawing.Point(1110, 463);
            this.btnexportaparaxls.Name = "btnexportaparaxls";
            this.btnexportaparaxls.Size = new System.Drawing.Size(230, 50);
            this.btnexportaparaxls.TabIndex = 14;
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
            this.btnimprimirconsulta.TabIndex = 13;
            this.btnimprimirconsulta.Text = "Im&primir Consulta";
            this.btnimprimirconsulta.UseVisualStyleBackColor = true;
            // 
            // btnabriragendamento
            // 
            this.btnabriragendamento.Enabled = false;
            this.btnabriragendamento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabriragendamento.Location = new System.Drawing.Point(1110, 333);
            this.btnabriragendamento.Name = "btnabriragendamento";
            this.btnabriragendamento.Size = new System.Drawing.Size(230, 50);
            this.btnabriragendamento.TabIndex = 12;
            this.btnabriragendamento.Text = "&Abrir Agendamento";
            this.btnabriragendamento.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 36);
            this.label8.TabIndex = 84;
            this.label8.Text = "> Consulta Agendamentos";
            // 
            // grpconsultaagendamentos
            // 
            this.grpconsultaagendamentos.Controls.Add(this.label18);
            this.grpconsultaagendamentos.Controls.Add(this.btnpesquisar);
            this.grpconsultaagendamentos.Controls.Add(this.btnlimpar);
            this.grpconsultaagendamentos.Controls.Add(this.cmbformapgto);
            this.grpconsultaagendamentos.Controls.Add(this.cmbservico);
            this.grpconsultaagendamentos.Controls.Add(this.label5);
            this.grpconsultaagendamentos.Controls.Add(this.label4);
            this.grpconsultaagendamentos.Controls.Add(this.cmbcolaborador);
            this.grpconsultaagendamentos.Controls.Add(this.label6);
            this.grpconsultaagendamentos.Controls.Add(this.cmbcliente);
            this.grpconsultaagendamentos.Controls.Add(this.label3);
            this.grpconsultaagendamentos.Controls.Add(this.atedateTimePicker2);
            this.grpconsultaagendamentos.Controls.Add(this.label2);
            this.grpconsultaagendamentos.Controls.Add(this.dedateTimePicker1);
            this.grpconsultaagendamentos.Controls.Add(this.label1);
            this.grpconsultaagendamentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpconsultaagendamentos.Location = new System.Drawing.Point(49, 86);
            this.grpconsultaagendamentos.Name = "grpconsultaagendamentos";
            this.grpconsultaagendamentos.Size = new System.Drawing.Size(1002, 141);
            this.grpconsultaagendamentos.TabIndex = 0;
            this.grpconsultaagendamentos.TabStop = false;
            this.grpconsultaagendamentos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(465, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 33);
            this.label18.TabIndex = 6;
            this.label18.Text = "+";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(807, 97);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(180, 32);
            this.btnpesquisar.TabIndex = 8;
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
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // cmbformapgto
            // 
            this.cmbformapgto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbformapgto.FormattingEnabled = true;
            this.cmbformapgto.Location = new System.Drawing.Point(607, 61);
            this.cmbformapgto.Name = "cmbformapgto";
            this.cmbformapgto.Size = new System.Drawing.Size(380, 26);
            this.cmbformapgto.TabIndex = 4;
            this.cmbformapgto.Text = "<Selecione a Forma de Pgto...>";
            // 
            // cmbservico
            // 
            this.cmbservico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbservico.FormattingEnabled = true;
            this.cmbservico.Location = new System.Drawing.Point(84, 100);
            this.cmbservico.Name = "cmbservico";
            this.cmbservico.Size = new System.Drawing.Size(380, 26);
            this.cmbservico.TabIndex = 5;
            this.cmbservico.Text = "<Selecione o Serviço...>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 94;
            this.label5.Text = "Forma Pgto.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Serviço: ";
            // 
            // cmbcolaborador
            // 
            this.cmbcolaborador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcolaborador.FormattingEnabled = true;
            this.cmbcolaborador.Location = new System.Drawing.Point(607, 22);
            this.cmbcolaborador.Name = "cmbcolaborador";
            this.cmbcolaborador.Size = new System.Drawing.Size(380, 26);
            this.cmbcolaborador.TabIndex = 2;
            this.cmbcolaborador.Text = "<Selecione o Colaborador...>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 92;
            this.label6.Text = "Colaborador: ";
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(84, 61);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(380, 26);
            this.cmbcliente.TabIndex = 3;
            this.cmbcliente.Text = "<Selecione o Cliente...>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente: ";
            // 
            // atedateTimePicker2
            // 
            this.atedateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atedateTimePicker2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atedateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.atedateTimePicker2.Location = new System.Drawing.Point(314, 22);
            this.atedateTimePicker2.Name = "atedateTimePicker2";
            this.atedateTimePicker2.Size = new System.Drawing.Size(150, 26);
            this.atedateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "até";
            // 
            // dedateTimePicker1
            // 
            this.dedateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedateTimePicker1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dedateTimePicker1.Location = new System.Drawing.Point(84, 22);
            this.dedateTimePicker1.Name = "dedateTimePicker1";
            this.dedateTimePicker1.Size = new System.Drawing.Size(150, 26);
            this.dedateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "De";
            // 
            // consultaagendamentosdataGridView1
            // 
            this.consultaagendamentosdataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaagendamentosdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultaagendamentosdataGridView1.ColumnHeadersHeight = 30;
            this.consultaagendamentosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultaagendamentosdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consultaagendamentosdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.consultaagendamentosdataGridView1.Location = new System.Drawing.Point(49, 248);
            this.consultaagendamentosdataGridView1.Name = "consultaagendamentosdataGridView1";
            this.consultaagendamentosdataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultaagendamentosdataGridView1.Size = new System.Drawing.Size(1002, 400);
            this.consultaagendamentosdataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Serviços";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Colaborador";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Valor";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Forma Pgto.";
            this.Column7.Name = "Column7";
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
            this.btnhome.TabIndex = 11;
            this.btnhome.Tag = "";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctboxlogo
            // 
            this.pctboxlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctboxlogo.Image = global::BeautyCare_teste.Properties.Resources.sem_logo;
            this.pctboxlogo.Location = new System.Drawing.Point(1130, 86);
            this.pctboxlogo.Name = "pctboxlogo";
            this.pctboxlogo.Size = new System.Drawing.Size(210, 198);
            this.pctboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxlogo.TabIndex = 88;
            this.pctboxlogo.TabStop = false;
            // 
            // consultaagendamentosvScrollBar1
            // 
            this.consultaagendamentosvScrollBar1.Location = new System.Drawing.Point(1036, 249);
            this.consultaagendamentosvScrollBar1.Name = "consultaagendamentosvScrollBar1";
            this.consultaagendamentosvScrollBar1.Size = new System.Drawing.Size(14, 398);
            this.consultaagendamentosvScrollBar1.TabIndex = 93;
            // 
            // telaconsultaagendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.consultaagendamentosvScrollBar1);
            this.Controls.Add(this.consultaagendamentosdataGridView1);
            this.Controls.Add(this.grpconsultaagendamentos);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pctboxlogo);
            this.Controls.Add(this.btnexportaparaxls);
            this.Controls.Add(this.btnimprimirconsulta);
            this.Controls.Add(this.btnabriragendamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "telaconsultaagendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty Care - Consulta Agendamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpconsultaagendamentos.ResumeLayout(false);
            this.grpconsultaagendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaagendamentosdataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pctboxlogo;
        private System.Windows.Forms.Button btnexportaparaxls;
        private System.Windows.Forms.Button btnimprimirconsulta;
        private System.Windows.Forms.Button btnabriragendamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpconsultaagendamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker atedateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dedateTimePicker1;
        private System.Windows.Forms.ComboBox cmbformapgto;
        private System.Windows.Forms.ComboBox cmbservico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcolaborador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.DataGridView consultaagendamentosdataGridView1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.VScrollBar consultaagendamentosvScrollBar1;
        private System.Windows.Forms.Label label18;
    }
}