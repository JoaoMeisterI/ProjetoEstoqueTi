using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstoqueTI.Classes.Item;

namespace EstoqueTI.FormulariosConsulta
{
    public partial class Frm_ConsultaItems : Form
    {
        public Frm_ConsultaItems()
        {
            InitializeComponent();
        }

        private async void Frm_ConsultaItems_Load(object sender, EventArgs e)
        {
            List<List<string>> ListaItens = new List<List<string>>();
            Unit unit = new Unit();
            try
            {
                // Adicionando as colunas ao DataGridView
                dv_itens.Columns.Add("item", "Item");
                dv_itens.Columns.Add("Observacao", "Observação");
                dv_itens.Columns.Add("categoria", "Categoria");

                ListaItens = unit.BuscarFicharioDBTodosSQLREL();

                // Iterar sobre cada lista interna em ListaItens
                for (int i = 0; i < ListaItens.Count; i++)
                {
                    List<string> listaInterna = ListaItens[i];

                    // Certifique-se de que a lista interna tem pelo menos 3 elementos
                    if (listaInterna.Count >= 3)
                    {
                        // Adicionando os itens na mesma linha, mas em colunas diferentes
                        dv_itens.Rows.Add(listaInterna[0], listaInterna[1], listaInterna[2]);
                    }
                    else
                    {
                        // Caso a lista interna não tenha elementos suficientes
                        // Adicione células vazias às colunas correspondentes
                        string item = listaInterna.Count > 0 ? listaInterna[0] : string.Empty;
                        string observacao = listaInterna.Count > 1 ? listaInterna[1] : string.Empty;
                        string categoria = listaInterna.Count > 2 ? listaInterna[2] : string.Empty;

                        dv_itens.Rows.Add(item, observacao, categoria);
                    }
                }

            }

            catch (Exception ex) 
            {
                throw (ex);
            }
            
            
        }
    }
}
