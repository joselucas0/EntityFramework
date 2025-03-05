namespace WinFormsApp1;

public partial class Form1 : Form
{
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;

    public Form1()
    {
        InitializeComponent(); 
        ConfigurarComponentes();
    }

    private void ConfigurarComponentes()
    {
        this.Text = "Somador de Números";
        this.Width = 400;
        this.Height = 200;

        Label label1 = new Label();
        label1.Text = "Número 1:";
        label1.AutoSize = true;
        label1.Location = new Point(10, 10);
        
        textBox1 = new TextBox();
        textBox1.Location = new Point(80, 10);
        textBox1.Width = 100;
        
        Label label2 = new Label();
        label2.Text = "Número 2:";
        label2.AutoSize = true;
        label2.Location = new Point(10, 40);
        
        textBox2 = new TextBox();
        textBox2.Location = new Point(80, 40);
        textBox2.Width = 100;
        
        button1 = new Button();
        button1.Text = "Somar";
        button1.Location = new Point(10, 80);
        button1.Click += Button1_Click;
        
        this.Controls.Add(label1);
        this.Controls.Add(textBox1);
        this.Controls.Add(label2);
        this.Controls.Add(textBox2);
        this.Controls.Add(button1);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
        {
            int resultado = num1 + num2;
            MessageBox.Show("A soma dos números é: " + resultado);
        }
        else
        {
            MessageBox.Show("Digite apenas números inteiros.");
        }
    }
}