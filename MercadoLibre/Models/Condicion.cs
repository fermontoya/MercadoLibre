using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MercadoLibre.Models
{
    public  class Condicion
    {
        public int Id { get; set; }
        public string Adn { get; set; }
        public bool Mutante { get; set; }
    }
}
