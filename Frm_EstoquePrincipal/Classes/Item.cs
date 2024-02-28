using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTI.Classes
{
    public class Item
    {
        public class Unit
        {
            [Required(ErrorMessage = "Nome do item é obrigatório")]
            public string nomeItem { get; set; }

            [Required(ErrorMessage = "Categoria é obrigatória")]
            public string categoria { get; set; }

            [StringLength(100, ErrorMessage = "A observação não pode ter mais de 100 caracteres")]
            public string observacao { get; set; }

            public List<string> ListaCamposDB = new List<string>() { "item", "categoria", "observacao" };
            public string tabela = "dbo.item";

            // "CRUD DO FICHARIO DO DB SQL SERVER"
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

           

     

            //"CRUD DB RELACIONAL"

            #region "FUNÇÕES AUXILIARES"
            //Pegar o conteudo e transformar em insert
            public string ToInsert()
            {
                string SQL;

                SQL = $@"INSERT INTO {tabela}
            ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}) VALUES ('";
                SQL += nomeItem + "', '" + categoria + "', '" + observacao + "')";
                return SQL;
            }


            public string ToUpdate(int Id)
            {

                string SQL;
                SQL = $@"UPDATE {tabela} SET ";
                SQL += $"{ListaCamposDB[0]} = '" + nomeItem + "',";
                SQL += $"{ListaCamposDB[1]} = '" + categoria + "',";
                SQL += $"{ListaCamposDB[2]}  = '" + observacao + "'";
                SQL += " WHERE id = '" + Id + "';";

                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.nomeItem = dr[ListaCamposDB[0]].ToString();
                u.categoria = dr[ListaCamposDB[1]].ToString();
                u.observacao = dr[ListaCamposDB[2]].ToString();
                return u;
            }

            #endregion


            #region "Inserindo o Sql das funções auxiliares no Db"
            public void IncluirFicharioSQLREL()
            {
                try
                {
                    string SQL;
                    SQL = ToInsert();
                    var db = new SqlClassServer();
                    db.SQLCommand(SQL);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Identificador: erro: " + ex.Message);
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
                        Unit u = DataRowToUnit(Dt.Rows[0]);
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
                        SQL = ToUpdate(id);
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
                    //Usando o db.SQLQurey para validar se o cliente existe
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
                        ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString() });
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
