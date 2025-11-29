using SistemaBibliotecaPoo.Controllers;
using SistemaBibliotecaPoo.Models;
using SistemaBibliotecaPoo.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaPoo.Views
{
    public partial class EdicaoLivros : Form
    {
        private readonly LivroController _livroController;
        private Dictionary<string, Label> _errosLabels;
        private int _livroId;
        public EdicaoLivros(int id)
        {
            InitializeComponent();
            _livroController = new LivroController();
            _livroId = id;

            // Dicionário que liga o nome do campo à label correspondente de erro no formulário
            // Isso evita vários IFs e facilita iterar erros retornados pelo controller
            _errosLabels = new Dictionary<string, Label>
            {
                {"titulo", erroTituloLbl },
                {"autor", erroAutorLbl },
                {"categoria", erroCategoriaLbl },
                {"preco", erroPrecoLbl },
                {"quantidade", erroQuantidadeLbl }
            };
        }

        private void EdicaoLivros_Load(object sender, EventArgs e)
        {
            //Busca o livro e verifica se ele existe
            Livro livro = _livroController.BuscarLivro(_livroId);
            if(livro == null)
            {
                MessageBox.Show("Livro não encontrado");
                this.Close();
                return;
            }

            // Preenche os campos com os dados do livro a ser editado
            tituloTxt.Text = livro.Titulo;
            autorTxt.Text = livro.Autor;
            categoriaTxt.Text = livro.Categoria;
            precoTxt.Text = livro.Preco.ToString("F2");
            quantidadeTxt.Text = livro.Quantidade.ToString();
            disponivelBox.SelectedItem = livro.Disponivel ? "Disponível" : "Indisponível";
        }

        private void cancelarEditarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarEditarBtn_Click(object sender, EventArgs e)
        {
            // Limpa mensagens de erro antes de tentar atualizar
            foreach (var lbl in _errosLabels.Values)
                lbl.Text = "";

            // Captura dados preenchidos no formulário
            LivroDto livro = new LivroDto
            {
                Id = _livroId,
                Titulo = tituloTxt.Text,
                Autor = autorTxt.Text,
                Categoria = categoriaTxt.Text,
                Preco = precoTxt.Text,
                Quantidade = quantidadeTxt.Text,
                Disponivel = disponivelBox.Text == "Disponível"
            };

            // Envia ao controller para validação e atualização
            ResultadoOperacao result = _livroController.AtualizarLivro(livro);

            // Caso existam erros, exibe cada um na label correspondente
            if (!result.Success)
            {
                foreach (var erro in result.Erros)
                {
                    if (_errosLabels.ContainsKey(erro.Key))
                    {
                        _errosLabels[erro.Key].Text = erro.Value;
                    }
                }
                return;
            }

            MessageBox.Show(
                "Livro atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
