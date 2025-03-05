using System.Net.Mime;

namespace Exemplo2_Console_Forms
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Habilita estilos visuais e define a renderização de texto
            MediaTypeNames.Application.EnableVisualStyles();
            MediaTypeNames.Application.SetCompatibleTextRenderingDefault(false);

            // Cria e inicia o formulário principal
            MediaTypeNames.Application.Run(new Form1()); // Substitua "Form1" pelo nome do seu formulário
        }
    }
    
    public class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            this.Text = "Meu Formulário"; // Define o título do formulário
            this.Size = new Size(300, 300); // Define o tamanho do formulário

            Label label = new Label(); // Cria um novo label
            label.Text = "Olá Mundo!"; // Define o texto do label
            label.Location = new Point(100, 100); // Define a posição do label
            this.AutoSize = true; // Define o tamanho do formulário de acordo com o conteúdo

            this.Controls.Add(label); // Adiciona o label ao formulário
        }
    }
}