using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Chefs_Dishes.Models{
    public class Chef{
        [Key]
        public int ChefId {get;set;}
        [Required]
        [MinLength(2)]
        public string Name {get;set;}
        [Required]
        public DateTime DateOfBirth {get;set;}
        public List<Dish> CreatedDishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    
    }
