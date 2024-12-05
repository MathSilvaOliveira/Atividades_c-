using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Globalization;

class Desafio_produtos
{
    public static void Main()
    {
        using (TextReader reader = new StreamReader("produtos.txt"))
        {

            List<double> estoque = new List<double>();
            List<double> v_produtos = new List<double>();
            String linha;

            while ((linha = reader.ReadLine()) != null)
            {
                string[] partes = linha.Split(',');

                Console.WriteLine(linha);

                double.TryParse(partes[1], out double valor_estoque);
                estoque.Add(valor_estoque);

                double.TryParse(partes[2], out double valor_produto);
                v_produtos.Add(valor_produto);

            }
            double soma_estoque = 0;
            foreach (double v in estoque)
            {
                soma_estoque += v;

            }
            Console.WriteLine("\nTotal do estoque: " + soma_estoque);

            double soma_produto = 0;
            foreach (double v in v_produtos)
            {
                soma_produto += v;
            }
  
            Console.WriteLine("Valor Total de produto: " + soma_produto.ToString("C"));
        }
    }
}