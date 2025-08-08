// Trabalho Final de POO - CRUD; 
// Matheus da Silva Fernandes - 12121ECP002;

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;


namespace FarmaciaPOO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView4.DataSource = listaReservas;
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            dataGridView3.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView3_CellFormatting);
        }

        Database db = new Database();

        private BindingList<Reserva> listaReservas = new BindingList<Reserva>();

        private bool ValidarCamposCliente()
        {
            return !string.IsNullOrWhiteSpace(txtCliente.Text) &&
                   !string.IsNullOrWhiteSpace(mtxtCPF.Text) &&
                   !string.IsNullOrWhiteSpace(mtxtTelefone.Text) &&
                   !string.IsNullOrWhiteSpace(mtxtEmail.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida e na coluna "descricao"
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "descricao")
            {
                // Obtém a descrição da célula clicada
                string descricaoCompleta = dataGridView1.Rows[e.RowIndex].Cells["descricao"].Value.ToString();

                // Exibe a descrição em uma MessageBox
                MessageBox.Show(descricaoCompleta, "Descrição Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarRemedios()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT nome, quantidade, codigo FROM remedio";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView3.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar remédios: " + ex.Message);
            }
        }

        private void CarregarReservas()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT cliente.nome AS Cliente, remedio.nome AS Remédio, reserva.data, reserva.hora " +
                                   "FROM reserva " +
                                   "INNER JOIN cliente ON reserva.cpf_cliente = cliente.cpf " +
                                   "INNER JOIN remedio ON reserva.codigo_remedio = remedio.codigo";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView4.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar reservas: " + ex.Message);
            }
        }

        private void LerRemedios()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM remedio";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Oculta a coluna de ID
                        if (dataGridView1.Columns["id"] != null)
                        {
                            dataGridView1.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LerClientes()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM cliente";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewClientes.DataSource = dt;

                        // Configurações do DataGridView
                        dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Preenche toda a área
                        dataGridViewClientes.AllowUserToResizeColumns = false; // Impede o redimensionamento manual

                        // Oculta a coluna de ID, se existir
                        if (dataGridViewClientes.Columns["id"] != null)
                        {
                            dataGridViewClientes.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler clientes: " + ex.Message);
            }
        }

            private void btn1Criar_Click(object sender, EventArgs e)
            {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    // Verifica se o código já existe
                    string checkQuery = "SELECT COUNT(*) FROM remedio WHERE codigo = @codigo";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("codigo", mtxtCodigo.Text);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Erro: O código do produto já existe!");
                            return;
                        }
                    }

                    // Se não existe, faz a inserção
                    string insertQuery = "INSERT INTO remedio(nome, codigo, quantidade, descricao) VALUES (@nome, @codigo, @quantidade, @descricao)";
                    using (var cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtRemedio.Text);
                        cmd.Parameters.AddWithValue("codigo", mtxtCodigo.Text);
                        cmd.Parameters.AddWithValue("quantidade", int.Parse(txtQuantidade.Text));
                        cmd.Parameters.AddWithValue("descricao", richtxtDescricao.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Remédio cadastrado com sucesso!");
                LerRemedios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn1Ler_Click(object sender, EventArgs e)
        {
            LerRemedios();
        }

            private void btn1Atualizar_Click(object sender, EventArgs e)
            {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE remedio SET nome = @nome, quantidade = @quantidade, descricao = @descricao WHERE codigo = @codigo";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtRemedio.Text);
                        cmd.Parameters.AddWithValue("codigo", mtxtCodigo.Text);
                        cmd.Parameters.AddWithValue("quantidade", int.Parse(txtQuantidade.Text));
                        cmd.Parameters.AddWithValue("descricao", richtxtDescricao.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Remédio atualizado com sucesso!");
                LerRemedios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

            private void btn1Deletar_Click(object sender, EventArgs e)
            {
                try
                {
                    using (var conn = db.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM remedio WHERE codigo = @codigo";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("codigo", mtxtCodigo.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Remédio deletado com sucesso!");
                    LerRemedios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }

            private void btn2Criar_Click(object sender, EventArgs e)
            {

            if (!ValidarCamposCliente())
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o cliente.");
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    // Verificar se o CPF já existe
                    string checkQuery = "SELECT COUNT(*) FROM cliente WHERE cpf = @cpf";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("cpf", mtxtCPF.Text);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Erro: CPF já cadastrado.");
                            return;
                        }
                    }

                    // Inserir o cliente
                    string query = "INSERT INTO cliente(nome, cpf, telefone, email) VALUES (@nome, @cpf, @telefone, @email)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtCliente.Text);
                        cmd.Parameters.AddWithValue("cpf", mtxtCPF.Text);
                        cmd.Parameters.AddWithValue("telefone", mtxtTelefone.Text);
                        cmd.Parameters.AddWithValue("email", mtxtEmail.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LerClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
        }

            private void btn2Ler_Click(object sender, EventArgs e)
            {
                LerClientes();
            }

            private void btn2Atualizar_Click(object sender, EventArgs e)
            {

            if (!ValidarCamposCliente())
            {
                MessageBox.Show("Não foi possivel atualizar o cliente, pois ele não está cadastrado.");
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE cliente SET nome = @nome, telefone = @telefone, email = @email WHERE cpf = @cpf";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", txtCliente.Text);
                        cmd.Parameters.AddWithValue("cpf", mtxtCPF.Text);
                        cmd.Parameters.AddWithValue("telefone", mtxtTelefone.Text);
                        cmd.Parameters.AddWithValue("email", mtxtEmail.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente atualizado com sucesso!");
                LerClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }

        }

        private void btn2Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtCPF.Text))
            {
                MessageBox.Show("Por favor, selecione ou digite o CPF do cliente que deseja deletar.");
                return;
            }

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM cliente WHERE cpf = @cpf";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cpf", mtxtCPF.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente deletado com sucesso!");
                LerClientes(); // Atualize o DataGridView para refletir as mudanças
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar cliente: " + ex.Message);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    // Verificar se o CPF está cadastrado e obter o nome do cliente
                    string queryCliente = "SELECT nome FROM cliente WHERE cpf = @cpf";
                    string nomeCliente;
                    using (var cmd = new NpgsqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("cpf", mtxtCPF2.Text);
                        nomeCliente = cmd.ExecuteScalar()?.ToString();
                        if (string.IsNullOrEmpty(nomeCliente))
                        {
                            MessageBox.Show("CPF não cadastrado.");
                            return;
                        }
                    }

                    // Verificar se o remédio está cadastrado e obter o nome e quantidade do remédio
                    string queryRemedio = "SELECT nome, quantidade FROM remedio WHERE codigo = @codigo";
                    string nomeRemedio;
                    int quantidadeRemedio;
                    using (var cmd = new NpgsqlCommand(queryRemedio, conn))
                    {
                        cmd.Parameters.AddWithValue("codigo", txtRemedio2.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nomeRemedio = reader.GetString(0);
                                quantidadeRemedio = reader.GetInt32(1);
                            }
                            else
                            {
                                MessageBox.Show("Código do remédio não cadastrado.");
                                return;
                            }
                        }
                    }

                    // Verificar a quantidade disponível
                    if (quantidadeRemedio <= 0)
                    {
                        MessageBox.Show("Estoque insuficiente para o remédio selecionado.");
                        return;
                    }

                    // Atualizar a quantidade do remédio no estoque
                    string queryAtualizarEstoque = "UPDATE remedio SET quantidade = quantidade - 1 WHERE codigo = @codigo";
                    using (var cmd = new NpgsqlCommand(queryAtualizarEstoque, conn))
                    {
                        cmd.Parameters.AddWithValue("codigo", txtRemedio2.Text);
                        cmd.ExecuteNonQuery();
                    }

                    // Inserir a reserva no banco de dados
                    string queryInserir = "INSERT INTO reserva(cpf_cliente, codigo_remedio, data, hora) " +
                                          "VALUES (@cpf, @codigo, @data::date, @hora::time)";
                    using (var cmd = new NpgsqlCommand(queryInserir, conn))
                    {
                        cmd.Parameters.AddWithValue("cpf", mtxtCPF2.Text);
                        cmd.Parameters.AddWithValue("codigo", txtRemedio2.Text);
                        cmd.Parameters.AddWithValue("data", data.Value.Date);  // Passa apenas a data
                        cmd.Parameters.AddWithValue("hora", hora.Value.TimeOfDay);  // Passa apenas a hora

                        cmd.ExecuteNonQuery();
                    }

                    // Adicionar a reserva à lista de reservas para exibição
                    listaReservas.Add(new Reserva
                    {
                        NomeCliente = nomeCliente,
                        NomeRemedio = nomeRemedio,
                        DataReserva = data.Value.ToString("dd/MM/yyyy"),
                        HoraReserva = hora.Value.ToString("HH:mm")
                    });

                    MessageBox.Show("Reserva efetuada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer reserva: " + ex.Message);
            }

            CarregarReservas(); // Atualiza o DataGridView com a nova reserva
            CarregarRemedios();
        }


        private void btn3Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.SelectedRows.Count > 0)
                {
                    // Obtém o nome do cliente e do remédio da linha selecionada
                    string nomeCliente = dataGridView4.SelectedRows[0].Cells["Cliente"].Value.ToString();
                    string nomeRemedio = dataGridView4.SelectedRows[0].Cells["Remédio"].Value.ToString();

                    using (var conn = db.GetConnection())
                    {
                        conn.Open();
                        // Modifique a consulta SQL para excluir com base nos nomes de cliente e remédio
                        string query = @"DELETE FROM reserva 
                                 WHERE cpf_cliente = (SELECT cpf FROM cliente WHERE nome = @nomeCliente)
                                 AND codigo_remedio = (SELECT codigo FROM remedio WHERE nome = @nomeRemedio)";

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("nomeCliente", nomeCliente);
                            cmd.Parameters.AddWithValue("nomeRemedio", nomeRemedio);

                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Reserva deletada com sucesso!");
                                CarregarReservas(); // Recarrega as reservas no dataGridView4
                            }
                            else
                            {
                                MessageBox.Show("Erro: A reserva selecionada não foi encontrada.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma reserva para deletar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar reserva: " + ex.Message);
            }
        }


        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Carregar remédios no dataGridView3
            CarregarRemedios();

            // Carregar reservas no dataGridView4
            CarregarReservas();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtBuscarCliente.Text;

            using (NpgsqlConnection conn = new Database().GetConnection())
            {
                string query = "SELECT * FROM cliente WHERE nome LIKE @nome";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nomeCliente}%");

                    conn.Open();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewClientes.DataSource = dt;
                    }
                }
            }
        }

        private void btnBuscarRemedio_Click(object sender, EventArgs e)
        {
            string nomeRemedio = txtBuscarRemedio.Text;

            using (NpgsqlConnection conn = new Database().GetConnection())
            {
                string query = "SELECT * FROM remedio WHERE nome LIKE @nome";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nomeRemedio}%");

                    conn.Open();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna atual é a de Quantidade
            if (dataGridView1.Columns[e.ColumnIndex].Name == "quantidade")
            {
                // Verifica se o valor não é nulo ou DBNull antes de converter
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int quantidade = Convert.ToInt32(e.Value);  // Valor da célula atual

                    // Define a cor da linha com base na quantidade
                    if (quantidade < 10)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {
                    // Defina uma cor padrão ou ignore a formatação se a célula estiver vazia
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna atual é a de Quantidade
            if (dataGridView3.Columns[e.ColumnIndex].Name == "quantidade")
            {
                // Verifica se o valor não é nulo ou DBNull antes de converter
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int quantidade = Convert.ToInt32(e.Value);  // Valor da célula atual

                    // Define a cor da linha com base na quantidade
                    if (quantidade < 10)
                    {
                        dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dataGridView3.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridView3.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {
                    // Defina uma cor padrão ou ignore a formatação se a célula estiver vazia
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridView3.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
