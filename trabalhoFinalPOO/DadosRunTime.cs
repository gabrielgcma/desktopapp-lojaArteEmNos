using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoFinalPOO
{
    public class DadosRunTime
    {
        private bool logado;
        private string usernameLogado;
        private int idclientelogado;
        private bool adminLogado;

        public bool Logado { get => logado; set => logado = value; }
        public string UsernameLogado { get => usernameLogado; set => usernameLogado = value; }
        public int Idclientelogado { get => idclientelogado; set => idclientelogado = value; }
        public bool AdminLogado { get => adminLogado; set => adminLogado = value; }
    }
}
