using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstoqueTI.Classes
{
    public class Recebe
    {
        public class Unit
        {
            public int id { get; set; }
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
            public string quantidade { get; set; }

            public List<string> ListaCamposDB = new List<string>() { "id", "data1", "valor", "motivo", "fkitem", "fkfornecedor", "quantidade" };
            public string tabela = "dbo.recebe";

           

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
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

                // Usando um bloco using para garantir que a conexão seja fechada corretamente
                //Usamos essa questão para fechar corretamente o banco
                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona cada item ao ComboBox
                        cb.Items.Add(reader["item"].ToString());
                    }

                    // Fecha o leitor de dados antes de sair do bloco using
                    reader.Close();

                }

            }


            public static void PreencherComboBoxFornecedores(ComboBox cb)
            {
                string SQL = "SELECT nome FROM dbo.fornecedor";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;

                // Usando um bloco using para garantir que a conexão seja fechada corretamente
                //Usamos essa questão para fechar corretamente o banco
                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona cada item ao ComboBox
                        cb.Items.Add(reader["nome"].ToString());
                    }

                    // Fecha o leitor de dados antes de sair do bloco using
                    reader.Close();

                }

            }

            public static int BuscaIdItem(string item)
            {
                string SQL = $"SELECT id FROM dbo.item WHERE item = '{item}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                // Usando um bloco using para garantir que a conexão seja fechada corretamente
                //Usamos essa questão para fechar corretamente o banco
                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona cada item ao ComboBox
                        try 
                        {
                            return id = int.Parse(reader["id"].ToString());
                        }
                        catch(ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Item não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        
                        
                    }
                    

                    // Fecha o leitor de dados antes de sair do bloco using
                    reader.Close();
                    return 0;


                }

            }

            public static int BuscaIdFornecedor(string fornecedor)
            {
                string SQL = $"SELECT id FROM dbo.fornecedor WHERE nome = '{fornecedor}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                // Usando um bloco using para garantir que a conexão seja fechada corretamente
                //Usamos essa questão para fechar corretamente o banco
                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona cada item ao ComboBox
                        try
                        {
                            return id = int.Parse(reader["id"].ToString());
                        }
                        catch (ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Fornecedor não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }


                    // Fecha o leitor de dados antes de sair do bloco using
                    reader.Close();
                    return 0;


                }

            }


            public static void AlteraQuantidade(string fornecedor)
            {
                string SQL = $"SELECT id FROM dbo.fornecedor WHERE nome = '{fornecedor}';";
                string chave = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                int id;

                // Usando um bloco using para garantir que a conexão seja fechada corretamente
                //Usamos essa questão para fechar corretamente o banco
                using (SqlConnection connection = new SqlConnection(chave))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Adiciona cada item ao ComboBox
                        try
                        {
                           id = int.Parse(reader["id"].ToString());
                        }
                        catch (ValidationException Ex)
                        {
                            MessageBox.Show(Ex.Message, "Fornecedor não encontrado, digite um ítem válido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }


                    // Fecha o leitor de dados antes de sair do bloco using
                    reader.Close();
                   


                }

            }

            #region "FUNÇÕES AUXILIARES"
            //Pegar o conteudo e transformar em insert
            public string ToInsert()
            {
                string SQL;

                SQL = $@"INSERT INTO {tabela}
                ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}, {ListaCamposDB[3]}, {ListaCamposDB[4]}, {ListaCamposDB[5]}, {ListaCamposDB[6]}) VALUES ('";
                SQL += this.id + "', '" + this.data + "', '" + this.valor + "', '" + this.motivo + "', '" + this.item + "', '" + this.fornecedor + "', '" + this.quantidade + "')";
                return SQL;
            }


            public string ToUpdate(int Id)
            {

                string SQL;
                SQL = $@"UPDATE {tabela} SET ";
                SQL += $"{ListaCamposDB[1]} = '" + this.data + "',";
                SQL += $"{ListaCamposDB[2]} = '" + this.valor + "',";
                SQL += $"{ListaCamposDB[3]} = '" + this.motivo + "',";
                SQL += $"{ListaCamposDB[4]} = '" + this.item + "',";
                SQL += $"{ListaCamposDB[5]} = '" + this.fornecedor + "',";
                SQL += $"{ListaCamposDB[6]} = '" + this.quantidade + "'";
                SQL += " WHERE id = '" + this.id + "';";


                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.id = Convert.ToInt32(dr["id"]);
                u.data = dr[ListaCamposDB[1]].ToString();
                u.valor = float.Parse(dr[ListaCamposDB[2]].ToString());
                u.motivo = dr[ListaCamposDB[3]].ToString();
                u.item = int.Parse(dr[ListaCamposDB[4]].ToString());
                u.fornecedor = int.Parse(dr[ListaCamposDB[5]].ToString());
                u.quantidade = dr[ListaCamposDB[6]].ToString();

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
                    throw new Exception("Inclusão não permitida. Identificador: " + this.id + ", erro: " + ex.Message);
                }

            }

            public Unit BuscarFicharioSQLREL(int Id)
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + Id + "'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + Id);
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

            public void AlterarFicharioSQLREL()
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + this.id + "'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + this.id);
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.id);
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteúdo do identificador: " + ex.Message);
                }
            }

            public void ApagarFicharioSQLREL()
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE Id = '" + this.id + "'";
                    var db = new SqlClassServer();
                    //Usando o db.SQLQurey para validar se o cliente existe
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + this.id);
                    }
                    else
                    {
                        SQL = $"DELETE FROM {tabela} WHERE Id = '" + this.id + "'";
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
                        ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString(), Dt.Rows[i][ListaCamposDB[3]].ToString(), Dt.Rows[i][ListaCamposDB[4]].ToString(), Dt.Rows[i][ListaCamposDB[5]].ToString(), Dt.Rows[i][ListaCamposDB[6]].ToString() });
                    }
                    return ListaBusca;


                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);


                }

                #endregion
            }
        }


    }
}
