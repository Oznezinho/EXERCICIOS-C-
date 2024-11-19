using System;

class Program
{
    public static void Main(string[] args)
    {
        //SEMAFORO
        //Digite VERDE, AMARELO ou VERMELHO entre ""
        //Caso contrario o semaforo esta quebrado
        String SIGA = ""; 
        
        //Comparando o siga
        if (SIGA == "VERDE")
        {
            Console.WriteLine("AVANCE");
        }
        else if (SIGA == "AMARELO")
        {
            Console.WriteLine("ATENÇÃO");
        }
        else if (SIGA == "VERMELHO")
        {
            Console.WriteLine("PARE");
        } else {
            Console.WriteLine("SEMAFORO QUEBRADO !!!");
        }
    }
}