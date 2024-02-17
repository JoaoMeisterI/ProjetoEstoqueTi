﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstoqueTI.Classes
{
        public class CentroCusto
        {
            public class Unit
            {
                public int id { get; set; }
                [Required(ErrorMessage = "Código é Obrigatório")]
                public string codigo { get; set; }
                [Required(ErrorMessage = "Descrição é Obrigatória")]
                public string descricao { get; set; }
                [Required(ErrorMessage = "Orçamento é Obrigatório")]
                public float orcamento { get; set; }

                public List<string> ListaCamposDB = new List<string>() { "id", "codigo", "descricao", "orcamento" };
                public string tabela = "dbo.centrocusto";

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
            ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}, {ListaCamposDB[3]}) VALUES ('";
                    SQL += this.id + "', '" + this.codigo + "', '" + this.descricao + "', '" + this.orcamento + "')";
                    return SQL;
                }


                public string ToUpdate(int Id)
                {

                    string SQL;
                    SQL = $@"UPDATE {tabela} SET ";
                    SQL += $"{ListaCamposDB[1]} = '" + this.codigo + "',";
                    SQL += $"{ListaCamposDB[2]} = '" + this.descricao + "',";
                    SQL += $"{ListaCamposDB[3]} = '" + this.orcamento + "'";
                    SQL += " WHERE id = '" + this.id + "';";


                    return SQL;
                }

                public Unit DataRowToUnit(DataRow dr)
                {
                    Unit u = new Unit();
                    u.id = Convert.ToInt32(dr["id"]);
                    u.codigo = dr[ListaCamposDB[1]].ToString();
                    u.descricao = dr[ListaCamposDB[2]].ToString();
                    u.orcamento = float.Parse((string)dr[ListaCamposDB[3]]);

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
                            ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString(), Dt.Rows[i][ListaCamposDB[3]].ToString() });
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


