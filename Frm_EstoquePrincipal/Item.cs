using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTI
{
    //Agora já consegue jogar no código
    public class Item
    {
        public int id { get; set; }
        public string nomeItem { get; set; }
        public string valorItem { get; set; }
        public string fornecedor { get;set; }
        public string observacao { get; set; }

        // "CRUD DO FICHARIO DO DB SQL SERVER"

        public void incluirFicharioSql(string tabela)
        {
            FicharioSqlServer fc = new FicharioSqlServer(tabela);
            if (fc.status)
            {
                fc.Incluir(this.id, this.nomeItem,this.valorItem,this.fornecedor,this.observacao);
                if (!(fc.status))
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

            SQL = @"INSERT INTO dbo.item
            (id, item, valor, fornecedor, observacao) VALUES ('";
            SQL += this.id + "', '" + this.nomeItem + "', '" + this.valorItem + "', '" + this.fornecedor + "', '" + this.observacao + "')";
            return SQL;
        }


            public string ToUpdate(int Id)
            {
                
                string SQL;
                SQL = @"UPDATE dbo.item SET ";
                SQL += "item = '" + this.nomeItem + "'";
                SQL += ", valor = '" + this.valorItem + "'";
                SQL += ", fornecedor = '" + this.fornecedor + "'";
                SQL += ", observacao = '" + this.observacao + "'";
                SQL += " WHERE id = '" + this.id + "'";


            return SQL;
        }

            public Item DataRowToUnit(DataRow dr)
            {
                Item u = new Item();
                u.id = Convert.ToInt32(dr["id"]);
                u.nomeItem = dr["item"].ToString();
                u.valorItem = dr["valor"].ToString();
                u.fornecedor = dr["fornecedor"].ToString();
                u.observacao = dr["observacao"].ToString();
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

        public Item BuscarFicharioSQLREL(int Id)
        {
            try
            {
                string SQL = "SELECT * FROM dbo.Item WHERE Id = '" + Id + "'";
                var db = new SqlClassServer();
                var Dt = db.SQLQuery(SQL);
                if (Dt.Rows.Count == 0)
                {
                    db.Close();
                    throw new Exception("Indentificador não existente: " + Id);
                }
                else
                {
                    Item u = this.DataRowToUnit(Dt.Rows[0]);
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
                string SQL = "SELECT * FROM dbo.Item WHERE Id = '" + this.id + "'";
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
                string SQL = "SELECT * FROM dbo.Item WHERE Id = '" + this.id + "'";
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
                    SQL = "DELETE FROM dbo.Item WHERE Id = '" + this.id + "'";
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
                var SQL = "SELECT * FROM TB_Cliente";
                var db = new SqlClassServer();
                var Dt = db.SQLQuery(SQL);
                for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                {
                    ListaBusca.Add(new List<string> { Dt.Rows[i]["id"].ToString(), Dt.Rows[i]["item"].ToString(), Dt.Rows[i]["valor"].ToString(), Dt.Rows[i]["fornecedor"].ToString(), Dt.Rows[i]["observacao"].ToString() });
                }
                return ListaBusca;

            }
            catch (Exception ex)
            {
                throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
            }
        }

        #endregion






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
        //                ListaBusca.Add(new List<string> { C.Id, C.Nome });
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

    }
}
