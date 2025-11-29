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
    //Classe responsável pelo ciclo de execução do sistema(Windows Forms).
    // Atua como o ponto de controle principal da aplicação,
    // gerenciando qual tela está visível e garantindo que o programa
    // encerre corretamente quando todas as janelas forem fechadas.
    public class AppContexto : ApplicationContext
    {
        public AppContexto()
        {
            MostrarLogin();
        }

        // Evento que verifica se ainda existe alguma janela aberta.
        // Caso todas sejam fechadas, a aplicação encerra completamente.
        private void VerificarEncerramento(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                ExitThread();
        }

        // Exibe a tela de Login e registra os eventos necessários.
        public void MostrarLogin()
        {
            var login = new Login();
            login.OnLoginSucesso += MostrarHome;

            login.FormClosed += VerificarEncerramento;
            login.Show();
        }

        // Exibe o formulário principal da aplicação (HomeForm) após o login.
        // Recebe o usuário logado para controle de permissões.
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
