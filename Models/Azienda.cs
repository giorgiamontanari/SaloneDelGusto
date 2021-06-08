using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class Azienda{
        
        [Key]
        public int Id_Azienda {get; set;}
        public string ragionesociale {get; set;}
        public string NomeAzienda {get; set;}
        
        [ForeignKey("Stand")]
        public int IdStand {get; set;}
        public Stand Stand {get; set;}
    } 
}