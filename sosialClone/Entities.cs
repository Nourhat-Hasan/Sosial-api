﻿using System.ComponentModel.DataAnnotations;

namespace sosialClone
{
    public class Entities
    {
        public Guid Id { get; set; }

        //[Required] I will use fluentValdation (automatic validation)
        public string Title { get; set; }

       // [Required]
        public DateTime Date { get; set; }

      //  [Required]
        public string Description { get; set; }

       // [Required]
        public string Catagory { get; set; }

      //  [Required]
        public string City { get; set; }

      //  [Required]
        public string Venue { get; set; }


    }
}