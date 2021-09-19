namespace AtvParadigmasProgramacao
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public short Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, short idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
