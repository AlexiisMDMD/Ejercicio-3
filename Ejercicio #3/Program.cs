


internal class Program {

    private static void Main(string[] args){



        Random random = new Random();
        int numeroAleatorio;
        

        bool numeroCorrecto = false;
        int num;

        Console.WriteLine("Introduce un numero de 1 al 10 ");



        while (!numeroCorrecto) {

            num = Convert.ToInt32(Console.ReadLine());
            numeroAleatorio = random.Next(1, 3);

            if (num == numeroAleatorio)
            {

                Console.WriteLine("El numero que introdujo es el correcto");
                numeroCorrecto = true;
                Console.WriteLine(numeroAleatorio);

            }

            else
            {

                Console.WriteLine("El numero que introdujo no es correcto (CIngresa otro numero)");
                Console.WriteLine(numeroAleatorio);

            }


        }
        
    }
}