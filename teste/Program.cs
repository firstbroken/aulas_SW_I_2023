namespace teste;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadLine();
        //INSTANCIA DE UM OBJETO A PARTIR DE UMA CLASSE
        Aviao tecoteco = new Aviao();

        tecoteco.mostraTexto();
        tecoteco.mostraTextoNome("Anderson");
        Console.WriteLine(tecoteco.mostraMsg());
        Console.WriteLine(tecoteco.somar(10,20));
        


    }
}
