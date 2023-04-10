using ProjetoCarro.C.Models;
using ProjetoCarro.C.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Programa
    {
        public static void Main(String[] args)
        {

            CarroService carroService = new CarroService();

            List<Carro> carros = carroService.listaCarros();

            foreach (var carro in carros)
            {
                string setor = carro.GetSetor();

                Console.WriteLine($"O carro {carro.Modelo} de {carro.GetCategoria()} está no setor {setor}");
            }

            Console.ReadLine();
        }
    }
}



