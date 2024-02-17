using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueTI
{
    public class FicharioSqlServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SqlClassServer db;

        public FicharioSqlServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SqlClassServer();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(int Id, string item,string categoria, string obs)
        {
            status = true;
            try
            {
                // INSERT INTO CLIENTE (ID, JSON) VALUES ('000001','{...}')

                var SQL = "INSERT INTO " + tabela + " (id, item,valor,fornecedor,observacao) VALUES ('" + Id + "', '" + item + "', '" +  "', '" + "', '" + obs + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public List<string> Buscar(int Id)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = '000010'

                var SQL = "SELECT id, item, valor, fornecedor, observacao FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //As rows só vem na primeira parte da chave, ou seja parte [0]
                    string conteudo = dt.Rows[0]["id"].ToString();
                    string conteudo1 = dt.Rows[0]["item"].ToString();
                    string conteudo2 = dt.Rows[0]["valor"].ToString();
                    string conteudo3 = dt.Rows[0]["fornecedor"].ToString();
                    string conteudo4 = dt.Rows[0]["observacao"].ToString();
                    List<string> ListaDb = new List<string>(); 
                    ListaDb.Add(conteudo);
                    ListaDb.Add(conteudo1);
                    ListaDb.Add(conteudo2);
                    ListaDb.Add(conteudo3);
                    ListaDb.Add(conteudo4);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                    return ListaDb;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return null;
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                // SELECT , item FROM CLIENTE'

                var SQL = "SELECT ID, ITEM FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["ITEM"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existem clientes na base de dados";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                var SQL = "SELECT id, item FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // DELETE FROM CLIENTE WHERE ID = '00010'

                    SQL = "DELETE FROM " + tabela + " WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
        }

        public void Alterar(string Id, string item)
        {
            status = true;
            try
            {

                var SQL = "SELECT Id, item FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // UPDATE CLIENTE SET JSON = '{...}' WHERE ID = '00010'

                    SQL = "UPDATE " + tabela + " SET item = '" + item + "' WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o identificador não existe: " + Id;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }

        }

    }

    
}
