using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class Visitatore{

        [Key]
        public int IdVisitatore {get; set;}
        public string Nome {get; set;}
        public string Cognome {get; set;}
        public string CodCoupon  {get; set;}
        public string CodiceIngresso {get;set;}
       
        [ForeignKey("Stand")]
        public int IdStand {get; set;}
        public Stand Stand {get; set;}
        
        [ForeignKey("Prodotto")]
        public int IdProdotto {get; set;}
        public Prodotto Prodotto{get;set;}
    }
}