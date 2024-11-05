////Utilizando Arrays:
//Problema "comerciante"
//Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto,
//mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de
//venda das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
// lucro < 10 %
// 10 % ≤ lucro ≤ 20%
// lucro > 20%
//Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total. 

using System.Globalization;

namespace RelatorioComercianteArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, contAbaixoDez = 0, contEntreDezEVinte = 0, contAcimaVinte = 0;
            double totalCompra = 0, totalVenda = 0, percLucro, lucroTotal;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] produto = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto {i+1}:");
                Console.Write("Produto: ");
                produto[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++)
            {
                
                percLucro = (precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100;

                if (percLucro < 10)
                {
                    contAbaixoDez++;
                }
                else if (percLucro <= 20)
                {
                    contEntreDezEVinte++;
                }
                else
                {
                    contAcimaVinte++;
                }
            }

            for (int i = 0; i < n; i++)
            { 
                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            lucroTotal = totalVenda - totalCompra;

            Console.WriteLine();
            Console.WriteLine("RELATORIO:");
            Console.WriteLine($"Lucro abaixo de 10%: {contAbaixoDez}");
            Console.WriteLine($"Lucro entre 10% e 20%: {contEntreDezEVinte}");
            Console.WriteLine($"Lucro acima de 20%: {contAcimaVinte}");
            Console.WriteLine($"Valor total de compra: {totalCompra.ToString("F2", CI)}");
            Console.WriteLine($"Valor total de venda: {totalVenda.ToString("F2", CI)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CI)}");
        }
    }
}
