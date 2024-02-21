﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTI.Classes
{
    public class User
    {
        public class Unit
        {
            public int id { get; set; }
            [Required(ErrorMessage = "Nome é Obrigatório")]
            public string nome { get; set; }
            [Required(ErrorMessage = "Usuário é Obrigatório")]
            public string usuario { get; set; }
            
            [Required(ErrorMessage = "Senha é Obrigatório")]
            [StringLength(30, MinimumLength = 8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres e no máximo 30.")]
            public string senha { get; set; }
            [Required(ErrorMessage = "Liberação é Obrigatório")]
            public string liberacao { get; set; }

            public bool logado = false;


            public List<string> ListaCamposDB = new List<string>() { "id", "nome", "usuario", "senha", "liberacao" };
            public string tabela = "dbo.usuario";

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


            #region "FUNÇÕES AUXILIARES"
            //Pegar o conteudo e transformar em insert
            public string ToInsert()
            {
                string SQL;

                SQL = $@"INSERT INTO {tabela}
            ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}, {ListaCamposDB[3]}, {ListaCamposDB[4]}) VALUES ('";
                SQL += this.id + "', '" + this.nome + "', '" + this.usuario + "', '" + this.senha + "', '" + this.liberacao + "')";
                return SQL;
            }


            public string ToUpdate(int Id)
            {

                string SQL;
                SQL = $@"UPDATE {tabela} SET ";
                SQL += $"{ListaCamposDB[1]} = '" + this.nome + "',";
                SQL += $"{ListaCamposDB[2]} = '" + this.usuario + "',";
                SQL += $"{ListaCamposDB[3]} = '" + this.senha + "',";
                SQL += $"{ListaCamposDB[4]}  = '" + this.liberacao + "'";
                SQL += " WHERE id = '" + this.id + "';";


                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.id = Convert.ToInt32(dr["id"]);
                u.nome = dr[ListaCamposDB[1]].ToString();
                u.usuario = dr[ListaCamposDB[2]].ToString();
                u.senha = dr[ListaCamposDB[3]].ToString();
                u.liberacao = dr[ListaCamposDB[4]].ToString();
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

            public Unit BuscarUserSQLREL(string user, string senha)
            {
                try
                {
                    string SQL = $"SELECT * FROM {tabela} WHERE usuario = '{user}' AND senha = '{senha}'";
                    var db = new SqlClassServer();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Usuário Não Existe: " + user);
                        
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
                        ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString(), Dt.Rows[i][ListaCamposDB[3]].ToString(), Dt.Rows[i][ListaCamposDB[4]].ToString() });
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

