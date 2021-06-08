using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class Espositore{
        [Key]
        public int Id_Espositore {get; set;}
        public string Nome {get; set;}
        public string Cognome {get; set;}
       
        public string email  {get; set;}
        public string PSW  {get; set;}

    }
}