using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarro.C.Models
{
    public class Carro
    {
        public string Modelo;
        public string Nome;
        public int Ano;
        public string Fabricante;
        public string Continente;
        public bool Valet;

        public Carro(string modelo, string nome, int ano, string fabricante, string continente, bool valet)
        {
            Modelo = modelo;
            Nome = nome;
            Ano = ano;
            Fabricante = fabricante;
            Continente = continente;
            Valet = valet;
        }

        public string GetCategoria()
        {
            int idade = DateTime.Now.Year - this.Ano;

            if (idade <= 3)
            {
                return "Novo";
            }
            else if (idade <= 6)
            {
                return "Seminovo";
            }
            else
            {
                return "Usado";
            }
        }

        public string GetSetor()
        {
            if (Continente.Equals("América"))
            {
                if (Modelo.Equals("Hatch") || Modelo.Equals("Sedan"))
                {
                    if (GetCategoria() == "Novo")
                    {
                        return "A1";
                    }
                }

                if (Modelo.Equals("SUV"))
                {
                    if (GetCategoria() == "Novo" || GetCategoria() == "Seminovo")
                    {
                        return "A2";
                    }
                }

                if (Modelo.Equals("Utilitário"))
                {
                    return "A3";
                }
            }

            if (Continente.Equals("Europa"))
            {
                if (Modelo.Equals("SUV") || Modelo.Equals("Utilitário"))
                {
                    if (GetCategoria() == "Seminovo")
                    {
                        return "B1";
                    }
                }

                if (Modelo.Equals("Hatch"))
                {
                    if (GetCategoria() == "Usado")
                    {
                        return "B2";
                    }
                }

                if (Modelo.Equals("Sedan"))
                {
                    return "B3";
                }
            }

            if (Continente.Equals("Asia"))
            {
                if (Modelo.Equals("Hatch"))
                {
                    return "C1";
                }

                if (Modelo.Equals("Sedan"))
                {
                    return "C2";
                }

                if (Modelo.Equals("SUV"))
                {
                    return "C3";
                }
            }

            if (Valet)
            {
                return "D1";
            }

            return "D2";
        }
    }
}
 

