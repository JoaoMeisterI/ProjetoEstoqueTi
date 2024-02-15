using System;
using System.Collections.Generic;
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
            public int id { get; set; }
            public string nomeItem { get; set; }
            public string categoria { get; set; }
            public string observacao { get; set; }

            public List<string> ListaCamposDB = new List<string>() { "id", "item", "categoria", "observacao" };
            public string tabela = "dbo.item";

            // "CRUD DO FICHARIO DO DB SQL SERVER"

            public void incluirFicharioSql(string tabela)
            {
                FicharioSqlServer fc = new FicharioSqlServer(tabela);
                if (fc.status)
                {
                    fc.Incluir(id, nomeItem, categoria, observacao);
                    if (!fc.status)
                    {
                        throw new Exception(fc.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fc.mensagem);
                }
            }

            public List<string> buscarFicharioSql(int id, string tabela)
            {
                FicharioSqlServer fc = new FicharioSqlServer(tabela);
                if (fc.status)
                {
                    List<string> ListaDb = fc.Buscar(id);
                    return ListaDb;
                }
                return null;
            }


            //"CRUD DB RELACIONAL"

            #region "FUNÇÕES AUXILIARES"
            //Pegar o conteudo e transformar em insert
            public string ToInsert()
            {
                string SQL;

                SQL = $@"INSERT INTO {tabela}
            ({ListaCamposDB[0]}, {ListaCamposDB[1]}, {ListaCamposDB[2]}, {ListaCamposDB[3]}) VALUES ('";
                SQL += id + "', '" + nomeItem + "', '" + "', '" + categoria + "', '" + observacao + "')";
                return SQL;
            }


            public string ToUpdate(int Id)
            {

                string SQL;
                SQL = $@"UPDATE {tabela} SET ";
                SQL += $"{ListaCamposDB[1]} = '" + nomeItem + "',";
                SQL += $"{ListaCamposDB[2]} = '" + categoria + "',";
                SQL += $"{ListaCamposDB[3]}  = '" + observacao + "'";
                SQL += " WHERE id = '" + id + "';";


                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.id = Convert.ToInt32(dr["id"]);
                u.nomeItem = dr[ListaCamposDB[1]].ToString();
                u.categoria = dr[ListaCamposDB[2]].ToString();
                u.observacao = dr[ListaCamposDB[3]].ToString();
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
                    throw new Exception("Inclusão não permitida. Identificador: " + id + ", erro: " + ex.Message);
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

            public void AlterarFicharioSQLREL()
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

            public void ApagarFicharioSQLREL()
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
                        ListaBusca.Add(new List<string> { Dt.Rows[i][ListaCamposDB[0]].ToString(), Dt.Rows[i][ListaCamposDB[1]].ToString(), Dt.Rows[i][ListaCamposDB[2]].ToString(), Dt.Rows[i][ListaCamposDB[3]].ToString(), Dt.Rows[i][ListaCamposDB[4]].ToString() });
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
//Agora já consegue jogar no código







//public void AlterarFicharioSQL(string conexao)
//{
//    string clienteJson = Cliente.SerializedClassUnit(this);
//    FicharioSQLServer F = new FicharioSQLServer(conexao);
//    if (F.status)
//    {
//        F.Alterar(this.Id, clienteJson);
//        if (!(F.status))
//        {
//            throw new Exception(F.mensagem);
//        }
//    }
//    else
//    {
//        throw new Exception(F.mensagem);
//    }
//}

//public void ApagarFicharioSQL(string conexao)
//{
//    FicharioSQLServer F = new FicharioSQLServer(conexao);
//    if (F.status)
//    {
//        F.Apagar(this.Id);
//        if (!(F.status))
//        {
//            throw new Exception(F.mensagem);
//        }
//    }
//    else
//    {
//        throw new Exception(F.mensagem);
//    }
//}

//public List<List<string>> BuscarFicharioDBTodosSQL(string conexao)
//{
//    FicharioSQLServer F = new FicharioSQLServer(conexao);
//    if (F.status)
//    {
//        List<string> List = new List<string>();
//        List = F.BuscarTodos();
//        if (F.status)
//        {
//            List<List<string>> ListaBusca = new List<List<string>>();
//            for (int i = 0; i <= List.Count - 1; i++)
//            {
//                Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
//                ListaBusca.Add(new List<string> { C.Id, C.nomeItem });
//            }
//            return ListaBusca;
//        }
//        else
//        {
//            throw new Exception(F.mensagem);
//        }
//    }
//    else
//    {
//        throw new Exception(F.mensagem);
//    }
//}
