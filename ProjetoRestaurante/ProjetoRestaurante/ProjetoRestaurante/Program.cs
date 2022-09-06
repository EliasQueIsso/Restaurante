using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Comanda controleMesa = new Comanda();
            Caixa caixa = new Caixa();
            int opcao = 0;
            do
            {


                Console.WriteLine("1 - Lançar gastos" +
                    "\n2 - Verificar promoção" +
                    "\n3 - Fechar mesa" +
                    "\n4 - Listar comanda" +
                    "\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Bora para os gastos" +
                            "\nConsumo?");
                        controleMesa.setValorConsumo(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Estacionamento?");
                        controleMesa.setValorEstacionamento(double.Parse(Console.ReadLine()));
                        Console.WriteLine("E no Couver?");
                        controleMesa.setValorCouvert(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine(controleMesa.verificarPromocao());
                        break;
                    case 3:
                        Console.WriteLine(caixa.totalizarComanda(controleMesa));
                        break;
                    case 4:
                        Console.WriteLine(controleMesa.listarComanda());
                        break;
                }
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
