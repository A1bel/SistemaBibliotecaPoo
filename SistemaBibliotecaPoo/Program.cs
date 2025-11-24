using SistemaBibliotecaPoo.Common;
using SistemaBibliotecaPoo.Models.Usuarios;
using SistemaBibliotecaPoo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaPoo
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsuarioRepositorio repo = UsuarioRepositorio.Instancia;

            if (!repo.ExisteAdmin())
            {
                Admin admin = new Admin(
                    "Administrador",
                    "99999999999",
                    "adm@adm.com",
                    "12345678"
                );

                repo.Adicionar(admin);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppContexto());
        }
    }
}
