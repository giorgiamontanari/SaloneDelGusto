using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class Stand{
        [Key]
        public int IdStand {get; set;}
        public string Nome {get; set;}
        public double Superficie {get; set;}
        public int NStand {get; set;}
        public char Posizione {get;set;}
       
        [ForeignKey("Visitatore")]
        public int IdVisitatore {get; set;}
        public Visitatore Visitatore {get; set;}
        
        [ForeignKey("Azienda")]
        public int IdAzienda {get; set;}
        public Azienda Azienda{get;set;}
    }
}