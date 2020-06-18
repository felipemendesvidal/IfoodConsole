using System;

namespace ifoodconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante boteco = new Restaurante("boteco arnaldo");
            cliente pessoa = new cliente("jose arnaldo");
            pedido torta = new pedido();

            Console.WriteLine(pessoa.mostrarDados());
            boteco.mostrarDados();
        }
    }
}
