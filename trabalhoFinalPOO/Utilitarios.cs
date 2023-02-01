using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoFinalPOO
{
    public class Utilitarios
    {
        public static void mbShowErro(string msg, string capt)
        {
            MessageBox.Show(msg, capt, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mbShowSucesso(string msg)
        {
            MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static NpgsqlConnection ConexaoBd()
        {
            var conexaoString = "Host=localhost;Username=postgres;Password=271828;Database=lojaArteEmNos";
            var conex = new NpgsqlConnection(conexaoString);
            return conex;
        }
    }
}
