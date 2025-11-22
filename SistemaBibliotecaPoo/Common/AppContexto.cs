using SistemaBibliotecaPoo.Models.Usuarios;
using SistemaBibliotecaPoo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaPoo.Common
{
    public class AppContexto : ApplicationContext
    {
        public AppContexto()
        {
            MostrarLogin();
        }

        private void VerificarEncerramento(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                ExitThread();
        }

        public void MostrarLogin()
        {
            var login = new Login();
            login.OnLoginSucesso += MostrarHome;

            login.FormClosed += VerificarEncerramento;
            login.Show();
        }

        public void MostrarHome(Usuario usuario)
        {
            foreach (Form f in Application.OpenForms)
                f.Hide();

            var home = new HomeForm(usuario);
            home.OnLogout += MostrarLogin;

            home.FormClosed += VerificarEncerramento;

            home.Show();
        }
    }
}
