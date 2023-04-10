using ProjetoCarro.C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarro.C.Service
{
    public class CarroService
    {
        public CarroService() { }

        public List<Carro> listaCarros()
        {
            List<Carro> carros = new List<Carro>()
            {
                   new Carro("500e" ,"Hatch", 2022, "Fiat","Europa", true),
                   new Carro("Amarok", "Utilitario", 2019, "Volkswagem","Europa", true),
                   new Carro("Creta", "SUV", 1999, "Hyundai","Asia",true),
                   new Carro("Fit", "Hatch", 2008, "Honda","Asia", true),
                   new Carro("Gol", "Hatch", 2012, "Volkswagen", "Europa", true),
                   new Carro("HR-V", "SUV", 2015, "Honda","Asia", true),
                   new Carro("Jetta", "Sedan", 2022, "Volkswagen","Europa", true),
                   new Carro("Montana", "Utilitario", 2000, "Chevrolet","America", true),
                   new Carro("Onix" ,"Hatch", 2019, "Chevrolet","America", true),
                   new Carro("Picape 147", "Utilitario", 1975, "Fiat","Europa", true),
                   new Carro("Ranger", "Utilitario", 2010, "Ford","America", true),
                   new Carro("Tracker", "SUV", 2021, "Chevrolet","America", true),
                   new Carro("Accord", "Sedan", 2004, "Honda","Asia", false),
                   new Carro("Civic", "Sedan", 1970, "Honda","Asia", false),
                   new Carro("Fiesta", "Sedan", 2007, "Ford","America", false),
                   new Carro("Fox", "Hatch", 2005, "Volkswagen","Europa", false),
                   new Carro("HB20", "Sedan", 2017, "Hyundai","Asia", false),
                   new Carro("I30", "Hatch", 2006, "Hyundai","Asia", false),
                   new Carro("Ka", "Sedan", 2020, "Ford","America", false),
                   new Carro("Monza Classic", "Sedan", 1994, "Chevrolet","America", false),
                   new Carro("Palio", "Hatch", 1996, "Fiat","Europa", false),
                   new Carro("Pulse","SUV", 2022, "Fiat","Europa", false),
                   new Carro("Territory", "SUV", 2022, "Ford","America", false),
                   new Carro("Tucson", "SUV", 2022, "Hyundai","Asia", false)
            };

            return carros;
        }
    }
}
