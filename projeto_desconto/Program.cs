namespace projeto_desconto;
class Program
{
    static void Main(string[] args)
    {
        // SITUAÇÃO 1
        //Produto p1 = new Produto();
        // SITUAÇÃO 2
        //Produto p1 = new Produto("Caneta");
        // SITUAÇÃO 3
        Produto p1 = new Produto("Caneta",50);
        p1.mostraDados();        
    }
}