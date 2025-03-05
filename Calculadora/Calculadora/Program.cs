namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculadora()); // Alterado para a Calculadora
        }
    }

    public class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            this.Text = "Meu Formulário";
            this.Size = new Size(300, 300);
            
            Label label = new Label();
            label.Text = "Olá mundo";
            label.Location = new Point(100, 100);
            this.AutoSize = true;
            
            this.Controls.Add(label);
        }
    }
    
    public class Calculadora : Form
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultadoLabel;

        public Calculadora()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Color.RoyalBlue;
            this.Text = "Calculadora";
            
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            
            // Label para instruções
            this.label1.AutoSize = true;
            this.label1.Location = new Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Text = "Digite os números";

            // Caixa de texto para o primeiro número
            this.textBox1.Location = new Point(100, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(200, 20);
            
            // Caixa de texto para o segundo número
            this.textBox2.Location = new Point(100, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(200, 20);
            
            // Botão para somar
            this.button1.Location = new Point(100, 200);
            this.button1.Name = "button1";
            this.button1.Size = new Size(100, 30);
            this.button1.Text = "Somar";
            this.button1.Click += new System.EventHandler(this.button1_Click);


            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new Point(100, 250);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new Size(100, 20);
            this.resultadoLabel.Text = "Resultado: ";

          
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultadoLabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double num1 = Convert.ToDouble(this.textBox1.Text);
                double num2 = Convert.ToDouble(this.textBox2.Text);
                double resultado = num1 + num2;
                this.resultadoLabel.Text = $"Resultado: {resultado}";
            }
            catch (Exception)
            {
                this.resultadoLabel.Text = "Por favor, insira números válidos!";
            }
        }
    }
}
