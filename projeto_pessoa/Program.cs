namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {        
        //Pessoa p1 = new Pessoa();
        Pessoa p1 = new Pessoa("Anderson",48);
        //p1.insereNome("Anderson");
        //p1.insereSobreNome("Vanin");
        //p1.insereIdade(48);
        p1.mostraDados();
    }
}