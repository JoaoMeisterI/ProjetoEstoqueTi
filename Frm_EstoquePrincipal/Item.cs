using System;
using System.Collections.Generic;
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
