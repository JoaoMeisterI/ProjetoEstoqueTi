using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Adicionado para MessageBox

namespace EstoqueTI.Classes
{
    public class Transfere
    {
        public class Unit
        {
            // Removido: public int id { get; set; }

            [Required(ErrorMessage = "Data é Obrigatória")]
            public string data { get; set; }
            [Required(ErrorMessage = "Valor é Obrigatório")]
            public float valor { get; set; }
            [Required(ErrorMessage = "Motivo é Obrigatório")]
            public string motivo { get; set; }
            [Required(ErrorMessage = "Item é Obrigatório")]
            public int item { get; set; }
            [Required(ErrorMessage = "Fornecedor é Obrigatório")]
            public int fornecedor { get; set; }
            [Required(ErrorMessage = "Quantidade é Obrigatória")]
            public int quantidade { get; set; }
            [Required(ErrorMessage = "Conta Contábil é Obrigatória")] // Novo campo
            public int contacontabil { get; set; }
            [Required(ErrorMessage = "Local é Obrigatório")] // Novo campo
            public string local { get; set; }

            public List<string> ListaCamposDB = new List<string>() { "data1", "valor", "motivo", "fkitem", "fkfornecedor", "quantidade", "fkcontacontabil", "local" }; // Atualizado
            public string tabela = "dbo.transfere"; // Atualizado

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (!isValid)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public static void PreencherComboBoxItens(ComboBox cb)
            {
                string SQL = "SELECT item FROM dbo.item";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb.Items.Add(reader["item"].ToString());
                    }

                    reader.Close();
                }
            }

            public static void PreencherComboBoxFornecedores(ComboBox cb)
            {
                string SQL = "SELECT nome FROM dbo.fornecedor";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb.Items.Add(reader["nome"].ToString());
                    }

                    reader.Close();
                }
            }

            public static void PreencherComboBoxCentroCusto(ComboBox cb)
            {
                string SQL = "SELECT codigo FROM dbo.centrocusto";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb.Items.Add(reader["codigo"].ToString());
                    }

                    reader.Close();
                }
            }

            public static int BuscaIdItem(string item)
            {
                string SQL = $"SELECT id FROM dbo.item WHERE item = '{item}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            return id = int.Parse(reader["id"].ToString());
                        }
                        catch (ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Item não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    reader.Close();
                    return 0;
                }
            }

            public static int BuscaIdFornecedor(string fornecedor)
            {
                string SQL = $"SELECT id FROM dbo.fornecedor WHERE nome = '{fornecedor}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            return id = int.Parse(reader["id"].ToString());
                        }
                        catch (ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Fornecedor não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    reader.Close();
                    return 0;
                }
            }

            public static int BuscaIdCentroCusto(string cc)
            {
                string SQL = $"SELECT id FROM dbo.centrocusto WHERE codigo = '{cc}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            return id = int.Parse(reader["id"].ToString());
                        }
                        catch (ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Fornecedor não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    reader.Close();
                    return 0;
                }
            }

            public static void AlteraQuantidade(int id, int quantidadeRecebe)
            {
                string SQL = $"UPDATE dbo.item SET quantidade = quantidade + {quantidadeRecebe} WHERE id = {id}";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;

                try
                {
                    using (SqlConnection connection = new SqlConnection(chave))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(SQL, connection);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Nenhuma linha foi afetada pela operação de atualização.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao executar a instrução SQL.", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro para realizar a alteração de quantidade", ex);
                }
            }

            #region "FUNÇÕES AUXILIARES"
            public string ToInsert()
            {
                string SQL = $@"INSERT INTO {tabela} 
                ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}, {ListaCamposDB[3]}, {ListaCamposDB[4]}, {ListaCamposDB[5]}, {ListaCamposDB[6]}, {ListaCamposDB[7]}) 
                VALUES (
                '{this.data}', '{this.valor}', '{this.motivo}', '{this.item}', '{this.fornecedor}', '{this.quantidade}', '{this.contacontabil}', '{this.local}')";

                return SQL;

            }


            public string ToUpdate(int id)
            {
                string SQL;
                SQL = $@"UPDATE {tabela} SET ";
                SQL += $"{ListaCamposDB[0]} = '" + this.data + "',";
                SQL += $"{ListaCamposDB[1]} = '" + this.valor + "',";
                SQL += $"{ListaCamposDB[2]} = '" + this.motivo + "',";
                SQL += $"{ListaCamposDB[3]} = '" + this.item + "',";
                SQL += $"{ListaCamposDB[4]} = '" + this.fornecedor + "',";
                SQL += $"{ListaCamposDB[5]} = '" + this.quantidade + "',";
                SQL += $"{ListaCamposDB[6]} = '" + this.contacontabil + "',";
                SQL += $"{ListaCamposDB[7]} = '" + this.local + "'";
                SQL += " WHERE id = '" + id + "';";

                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                u.data = dr[ListaCamposDB[0]].ToString();
                u.valor = float.Parse(dr[ListaCamposDB[1]].ToString());
                u.motivo = dr[ListaCamposDB[2]].ToString();
                u.item = int.Parse(dr[ListaCamposDB[3]].ToString());
                u.fornecedor = int.Parse(dr[ListaCamposDB[4]].ToString());
                u.quantidade = int.Parse(dr[ListaCamposDB[5]].ToString());
                u.contacontabil = int.Parse(dr[ListaCamposDB[6]].ToString());
                u.local = dr[ListaCamposDB[7]].ToString();

                return u;
            }

            #endregion

            #region "Inserindo o Sql das funções auxiliares no Db"
            public void IncluirFicharioSQLREL()
            {
                try
                {
                    string SQL;
                    SQL = this.ToInsert();
                    var db = new SqlClassServer();
                    db.SQLCommand(SQL);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Identificador: {id}, erro: " + ex.Message);
                }
            }

            public Unit BuscarFicharioSQLREL(int id)
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + id + "'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + id);
                    }
                    else
                    {
                        Unit u = this.DataRowToUnit(Dt.Rows[0]);
                        return u;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o conteúdo do identificador: " + ex.Message);
                }
            }

            public void AlterarFicharioSQLREL(int id)
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + id + "'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + id);
                    }
                    else
                    {
                        SQL = this.ToUpdate(id);
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteúdo do identificador: " + ex.Message);
                }
            }

            public void ApagarFicharioSQLREL(int id)
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + id + "'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + id);
                    }
                    else
                    {
                        SQL = $"DELETE FROM {tabela} WHERE Id = '" + id + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o conteúdo do identificador: " + ex.Message);
                }
            }

            public List<List<string>> BuscarFicharioDBTodosSQLREL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();
                try
                {
                    var SQL = $"SELECT * FROM {tabela}";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString(), Dt.Rows[i][ListaCamposDB[3]].ToString(), Dt.Rows[i][ListaCamposDB[4]].ToString(), Dt.Rows[i][ListaCamposDB[5]].ToString(), Dt.Rows[i][ListaCamposDB[6]].ToString(), Dt.Rows[i][ListaCamposDB[7]].ToString() });
                    }
                    return ListaBusca;
                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
                }
            }
            #endregion
        }
    }
}
