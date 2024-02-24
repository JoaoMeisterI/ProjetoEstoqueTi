using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstoqueTI.Classes.User;

namespace EstoqueTI.FuncoesUteis;

public class Funcoes()
{
    public int BuscarFicharioId(string tabela)
    {
        try
        {
            string SQL = "SELECT TOP (1) [id] " +
             $"FROM [EstoqueTi].[dbo].[{tabela}] " +
             "ORDER BY id DESC";
            var db = new SqlClassServer();
            var Dt = db.SQLQuery(SQL);
            if (Dt.Rows.Count == 0)
            {
                db.Close();
                throw new Exception("Indentificador não existente");
            }
            else
            {
                Unit u = this.DataRowToUnit(Dt.Rows[0]);
                return 1;


            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao buscar o conteúdo do identificador: " + ex.Message);
        }

    }



    public Unit DataRowToUnit(DataRow dr)
    {
        Unit u = new Unit();
      
       
        return u;


    }
}

