using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class Prodotto{
        [Key]
        public int IdProdotto {get; set;}
        public string Nome {get; set;}
        public string Categoria {get; set;}
        
        [ForeignKey("Visitatore")]
        public int IdVisitatore {get; set;}
        public Visitatore Visitatore{get;set;}
    }
}