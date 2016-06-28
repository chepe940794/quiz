using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quizz.Models
{
    public class ExpModel
    {
        [Key]
        public int Id { get; set; }
        public string Oficio { get; set; }
        public string Empresa { get; set; }
        public string Exp { get; set; }
        public string Trabajo { get; set; }
    }
}