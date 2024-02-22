using EstoqueTI;
using EstoqueTI.FormulariosIniciais;

namespace Frm_EstoquePrincipal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_Recebe());


           
            

        }
    }
}

//redes sociais que fizeram dar origem aos bancos de dados NoSQL

//Modelo Não relacional
//formulario --- item - ficharioSql ----- sqlServer

//Modelo Relacional 
//formulario --- item ---- sqlServer