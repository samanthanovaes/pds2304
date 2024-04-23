using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SisteminhaEscolar.Windows
{
    /// <summary>
    /// Lógica interna para ConsultarEscola.xaml
    /// </summary>
    public partial class ConsultarEscola : Window
    {
        public ConsultarEscola()
        {
            InitializeComponent();
        }

        private void AcessoCurso_Click(object sender, MouseButtonEventArgs a)
        {
            CadastrarCurso cadastrarCurso = new CadastrarCurso();
            cadastrarCurso.Show();
            this.Close();
        }

        private void AcessoTurma_Click(object sender, MouseButtonEventArgs i)
        {
            CadastrarTurma cadastrarTurma = new CadastrarTurma();
            cadastrarTurma.Show();
            this.Close();
        }

        private void AcessoAluno_Click(object sender, MouseButtonEventArgs u)
        {
            CadastrarAluno cadastrarAluno = new CadastrarAluno();
            cadastrarAluno.Show();
            this.Close();
        }

        private void AcessoEscola_Click(object sender, MouseButtonEventArgs e)
        {
            CadastrarEscola cadastrarEscola = new CadastrarEscola();
            cadastrarEscola.Show();
            this.Close();
        }

        private void ConsultaCurso_Click(object sender, MouseButtonEventArgs a)
        {
            ConsultarCurso consultarCurso = new ConsultarCurso();
            consultarCurso.Show();
            this.Close();
        }

        private void ConsultarTurma_Click(object sender, MouseButtonEventArgs i)
        {
            ConsultarTurma consultarTurma = new ConsultarTurma();
            consultarTurma.Show();
            this.Close();
        }

        private void ConsultarAluno_Click(object sender, MouseButtonEventArgs o)
        {
            ConsultarAluno consultarAluno = new ConsultarAluno();
            consultarAluno.Show();
            this.Close();
        }
    }
}
