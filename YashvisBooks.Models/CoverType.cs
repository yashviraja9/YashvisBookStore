﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YashvisBooks.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cover Type Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
