namespace FarmaciaPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mtxtCPF2 = new System.Windows.Forms.MaskedTextBox();
            this.txtRemedio2 = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn3Deletar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.mtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btn2Deletar = new System.Windows.Forms.Button();
            this.btn2Atualizar = new System.Windows.Forms.Button();
            this.btn2Ler = new System.Windows.Forms.Button();
            this.btn2Criar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscarRemedio = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuscarRemedio = new System.Windows.Forms.TextBox();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.imagem1 = new System.Windows.Forms.PictureBox();
            this.txtRemedio = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.richtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn1Deletar = new System.Windows.Forms.Button();
            this.btn1Atualizar = new System.Windows.Forms.Button();
            this.btn1Ler = new System.Windows.Forms.Button();
            this.btn1Criar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCarregar);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Controls.Add(this.mtxtCPF2);
            this.tabPage3.Controls.Add(this.txtRemedio2);
            this.tabPage3.Controls.Add(this.hora);
            this.tabPage3.Controls.Add(this.data);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btn3Deletar);
            this.tabPage3.Controls.Add(this.btnReservar);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1342, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reserva";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(92, 131);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(119, 35);
            this.btnCarregar.TabIndex = 25;
            this.btnCarregar.Text = "CARREGAR";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(821, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(515, 463);
            this.dataGridView4.TabIndex = 24;
            // 
            // mtxtCPF2
            // 
            this.mtxtCPF2.Location = new System.Drawing.Point(83, 196);
            this.mtxtCPF2.Name = "mtxtCPF2";
            this.mtxtCPF2.Size = new System.Drawing.Size(184, 22);
            this.mtxtCPF2.TabIndex = 23;
            // 
            // txtRemedio2
            // 
            this.txtRemedio2.Location = new System.Drawing.Point(83, 235);
            this.txtRemedio2.Name = "txtRemedio2";
            this.txtRemedio2.Size = new System.Drawing.Size(184, 22);
            this.txtRemedio2.TabIndex = 22;
            // 
            // hora
            // 
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora.Location = new System.Drawing.Point(83, 322);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(184, 22);
            this.hora.TabIndex = 21;
            this.hora.Value = new System.DateTime(2024, 10, 25, 0, 24, 16, 0);
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(83, 277);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(184, 22);
            this.data.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Remédio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "CPF";
            // 
            // btn3Deletar
            // 
            this.btn3Deletar.Location = new System.Drawing.Point(161, 434);
            this.btn3Deletar.Name = "btn3Deletar";
            this.btn3Deletar.Size = new System.Drawing.Size(119, 35);
            this.btn3Deletar.TabIndex = 14;
            this.btn3Deletar.Text = "DELETAR";
            this.btn3Deletar.UseVisualStyleBackColor = true;
            this.btn3Deletar.Click += new System.EventHandler(this.btn3Deletar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(21, 434);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(119, 35);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(300, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(515, 463);
            this.dataGridView3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FarmaciaPOO.Properties.Resources.im_reservas;
            this.pictureBox3.Location = new System.Drawing.Point(21, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(259, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarCliente);
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.txtBuscarCliente);
            this.tabPage2.Controls.Add(this.mtxtEmail);
            this.tabPage2.Controls.Add(this.mtxtTelefone);
            this.tabPage2.Controls.Add(this.mtxtCPF);
            this.tabPage2.Controls.Add(this.txtCliente);
            this.tabPage2.Controls.Add(this.btn2Deletar);
            this.tabPage2.Controls.Add(this.btn2Atualizar);
            this.tabPage2.Controls.Add(this.btn2Ler);
            this.tabPage2.Controls.Add(this.btn2Criar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridViewClientes);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(1116, 48);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 23;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(644, 51);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(68, 16);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Pesquisar";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(718, 48);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(392, 22);
            this.txtBuscarCliente.TabIndex = 22;
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Location = new System.Drawing.Point(88, 374);
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.Size = new System.Drawing.Size(392, 22);
            this.mtxtEmail.TabIndex = 21;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(88, 315);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(392, 22);
            this.mtxtTelefone.TabIndex = 20;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(88, 256);
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(392, 22);
            this.mtxtCPF.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(88, 197);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(392, 22);
            this.txtCliente.TabIndex = 14;
            // 
            // btn2Deletar
            // 
            this.btn2Deletar.Location = new System.Drawing.Point(391, 434);
            this.btn2Deletar.Name = "btn2Deletar";
            this.btn2Deletar.Size = new System.Drawing.Size(119, 35);
            this.btn2Deletar.TabIndex = 13;
            this.btn2Deletar.Text = "DELETAR";
            this.btn2Deletar.UseVisualStyleBackColor = true;
            this.btn2Deletar.Click += new System.EventHandler(this.btn2Deletar_Click);
            // 
            // btn2Atualizar
            // 
            this.btn2Atualizar.Location = new System.Drawing.Point(266, 434);
            this.btn2Atualizar.Name = "btn2Atualizar";
            this.btn2Atualizar.Size = new System.Drawing.Size(119, 35);
            this.btn2Atualizar.TabIndex = 12;
            this.btn2Atualizar.Text = "ATUALIZAR";
            this.btn2Atualizar.UseVisualStyleBackColor = true;
            this.btn2Atualizar.Click += new System.EventHandler(this.btn2Atualizar_Click);
            // 
            // btn2Ler
            // 
            this.btn2Ler.Location = new System.Drawing.Point(141, 434);
            this.btn2Ler.Name = "btn2Ler";
            this.btn2Ler.Size = new System.Drawing.Size(119, 35);
            this.btn2Ler.TabIndex = 11;
            this.btn2Ler.Text = "LER";
            this.btn2Ler.UseVisualStyleBackColor = true;
            this.btn2Ler.Click += new System.EventHandler(this.btn2Ler_Click);
            // 
            // btn2Criar
            // 
            this.btn2Criar.Location = new System.Drawing.Point(16, 434);
            this.btn2Criar.Name = "btn2Criar";
            this.btn2Criar.Size = new System.Drawing.Size(119, 35);
            this.btn2Criar.TabIndex = 10;
            this.btn2Criar.Text = "CRIAR";
            this.btn2Criar.UseVisualStyleBackColor = true;
            this.btn2Criar.Click += new System.EventHandler(this.btn2Criar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(516, 98);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(820, 371);
            this.dataGridViewClientes.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FarmaciaPOO.Properties.Resources.im_cliente;
            this.pictureBox2.Location = new System.Drawing.Point(24, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarRemedio);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtBuscarRemedio);
            this.tabPage1.Controls.Add(this.mtxtCodigo);
            this.tabPage1.Controls.Add(this.imagem1);
            this.tabPage1.Controls.Add(this.txtRemedio);
            this.tabPage1.Controls.Add(this.txtQuantidade);
            this.tabPage1.Controls.Add(this.richtxtDescricao);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn1Deletar);
            this.tabPage1.Controls.Add(this.btn1Atualizar);
            this.tabPage1.Controls.Add(this.btn1Ler);
            this.tabPage1.Controls.Add(this.btn1Criar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remédio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarRemedio
            // 
            this.btnBuscarRemedio.Location = new System.Drawing.Point(1105, 49);
            this.btnBuscarRemedio.Name = "btnBuscarRemedio";
            this.btnBuscarRemedio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRemedio.TabIndex = 26;
            this.btnBuscarRemedio.Text = "BUSCAR";
            this.btnBuscarRemedio.UseVisualStyleBackColor = true;
            this.btnBuscarRemedio.Click += new System.EventHandler(this.btnBuscarRemedio_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(633, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Pesquisar";
            // 
            // txtBuscarRemedio
            // 
            this.txtBuscarRemedio.Location = new System.Drawing.Point(707, 49);
            this.txtBuscarRemedio.Name = "txtBuscarRemedio";
            this.txtBuscarRemedio.Size = new System.Drawing.Size(392, 22);
            this.txtBuscarRemedio.TabIndex = 25;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Location = new System.Drawing.Point(102, 213);
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(395, 22);
            this.mtxtCodigo.TabIndex = 13;
            // 
            // imagem1
            // 
            this.imagem1.Image = global::FarmaciaPOO.Properties.Resources.im_remedio;
            this.imagem1.Location = new System.Drawing.Point(22, 22);
            this.imagem1.Name = "imagem1";
            this.imagem1.Size = new System.Drawing.Size(475, 114);
            this.imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem1.TabIndex = 1;
            this.imagem1.TabStop = false;
            // 
            // txtRemedio
            // 
            this.txtRemedio.Location = new System.Drawing.Point(102, 161);
            this.txtRemedio.Name = "txtRemedio";
            this.txtRemedio.Size = new System.Drawing.Size(395, 22);
            this.txtRemedio.TabIndex = 12;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(102, 268);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(395, 22);
            this.txtQuantidade.TabIndex = 10;
            // 
            // richtxtDescricao
            // 
            this.richtxtDescricao.Location = new System.Drawing.Point(102, 329);
            this.richtxtDescricao.Name = "richtxtDescricao";
            this.richtxtDescricao.Size = new System.Drawing.Size(395, 54);
            this.richtxtDescricao.TabIndex = 9;
            this.richtxtDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remédio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(516, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 371);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn1Deletar
            // 
            this.btn1Deletar.Location = new System.Drawing.Point(391, 434);
            this.btn1Deletar.Name = "btn1Deletar";
            this.btn1Deletar.Size = new System.Drawing.Size(119, 35);
            this.btn1Deletar.TabIndex = 3;
            this.btn1Deletar.Text = "DELETAR";
            this.btn1Deletar.UseVisualStyleBackColor = true;
            this.btn1Deletar.Click += new System.EventHandler(this.btn1Deletar_Click);
            // 
            // btn1Atualizar
            // 
            this.btn1Atualizar.Location = new System.Drawing.Point(266, 434);
            this.btn1Atualizar.Name = "btn1Atualizar";
            this.btn1Atualizar.Size = new System.Drawing.Size(119, 35);
            this.btn1Atualizar.TabIndex = 2;
            this.btn1Atualizar.Text = "ATUALIZAR";
            this.btn1Atualizar.UseVisualStyleBackColor = true;
            this.btn1Atualizar.Click += new System.EventHandler(this.btn1Atualizar_Click);
            // 
            // btn1Ler
            // 
            this.btn1Ler.Location = new System.Drawing.Point(141, 434);
            this.btn1Ler.Name = "btn1Ler";
            this.btn1Ler.Size = new System.Drawing.Size(119, 35);
            this.btn1Ler.TabIndex = 1;
            this.btn1Ler.Text = "LER";
            this.btn1Ler.UseVisualStyleBackColor = true;
            this.btn1Ler.Click += new System.EventHandler(this.btn1Ler_Click);
            // 
            // btn1Criar
            // 
            this.btn1Criar.Location = new System.Drawing.Point(16, 434);
            this.btn1Criar.Name = "btn1Criar";
            this.btn1Criar.Size = new System.Drawing.Size(119, 35);
            this.btn1Criar.TabIndex = 0;
            this.btn1Criar.Text = "CRIAR";
            this.btn1Criar.UseVisualStyleBackColor = true;
            this.btn1Criar.Click += new System.EventHandler(this.btn1Criar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 514);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "POO FARMA";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRemedio;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.RichTextBox richtxtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn1Deletar;
        private System.Windows.Forms.Button btn1Atualizar;
        private System.Windows.Forms.Button btn1Ler;
        private System.Windows.Forms.Button btn1Criar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn2Deletar;
        private System.Windows.Forms.Button btn2Atualizar;
        private System.Windows.Forms.Button btn2Ler;
        private System.Windows.Forms.Button btn2Criar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imagem1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn3Deletar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.MaskedTextBox mtxtCPF2;
        private System.Windows.Forms.TextBox txtRemedio2;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.MaskedTextBox mtxtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DateTimePicker hora;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarRemedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBuscarRemedio;
    }
}

