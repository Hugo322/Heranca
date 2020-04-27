using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Informacoes que vao para a classe FORNECEDOR */
            Fornecedor f = new Fornecedor("Marlon", "Eloi Mendes", "(35)3264-1111");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 316.12;
            Console.WriteLine("Fornecedor, saldo de: " + f.obterSaldo());

            /*Informacoes que vao para a classe COLABORADOR */
            Colaborador c = new Colaborador("Jhony", "Belem do para", "(91)3205-9800");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Imposto = 2;
            Console.WriteLine("Colaborador, salario: " + c.calcularSalario());

            /*Informacoes que vao para a classe ADMINISTRADOR */
            Administrador a = new Administrador("Hugo", "Varginha", "(35)3212-2019");
            a.CodSetor = 30;
            a.SalarioBase = 818.13;
            a.Imposto = 2;
            a.AjudaDeCusto = 314.07;
            Console.WriteLine("Administrador, salario: " + a.calcularSalario());

            /*Informacoes que vao para a classe ADMINISTRADOR */
            Operario o = new Operario("Marcio", "Varginha", "(35)3212-2019");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Imposto = 2;
            o.ValorProducao = 117.09;
            o.Comissao = 3;
            Console.WriteLine("Operario, salario: " + o.calcularSalario());

            /*Informacoes que vao para a classe VENDEDOR */
            Vendedor v = new Vendedor("Rodrigo", "Eloi Mendes", "(35)3264-2119");
            v.CodSetor = 30;
            v.SalarioBase = 818.13;
            v.Imposto = 2;
            v.ValorVendas = 518.22;
            v.Comissao = 5;
            Console.WriteLine("Vendedor,  salario: " + v.calcularSalario());

            Console.ReadKey();

        }


    }
}
