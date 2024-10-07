﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProductManagement.Model
{
    
        public class Catergory
        {
            [Key]
            public int ID { get; set; }

            [Required]
            [MaxLength(30)]
            [DisplayName("Catergory Name")]
            public string Name { get; set; }

            [Range(1, 100, ErrorMessage = "This not Valid Number")]
            [DisplayName("Display Order")]
            public int Display_Order { get; set; }
        }
    }

