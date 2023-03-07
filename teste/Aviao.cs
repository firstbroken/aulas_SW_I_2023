namespace teste;
class Aviao
{
    public string modelo="";
    public string marca="";
    public int velocidade;
    public int altitude;

    //MÉTODOS
    //sem retorno e sem parametros
    public void mostraTexto(){
        Console.WriteLine("Escrevendo na tela!");
    }

    //sem retorno e com parametros
    public void mostraTextoNome(string nome){
        Console.WriteLine("Escrevendo na tela! " + nome);
    }

    public string mostraMsg(){
        return "Oi 2C";
    }

    public int somar(int a, int b){
        int soma = a + b;
        return soma;
    }
    

}