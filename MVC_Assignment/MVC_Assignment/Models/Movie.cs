using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assignment.Models
{
   


    public class Movie
    {
        [Key]
        public int mid { get; set; }
        public string MovieName { get; set; }
        public DateTime DateOfRelease { get; set; }
        public object Movie { get; internal set; }
        public object Movie { get; internal set; }
        public object Movies { get; internal set; }
    }
}