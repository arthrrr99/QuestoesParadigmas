namespace AtvParadigmasProgramacao
{
    public class Funcionario : Pessoa
    {
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (((SalarioBruto * porcentagem) / 100));
        }
    }
}