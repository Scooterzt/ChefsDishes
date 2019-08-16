using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
 
namespace Chefs_Dishes.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> chefs {get;set;}
        public DbSet<Dish> dishs {get;set;}
    }
    // public abstract class ValidationAttribute : Attribute{
    //     public virtual bool IsValid(object value);
    //     protected virtual ValidationResult IsValid(object value, ValidationContext validationContext);
    // }
    // public class NoFutureDateAttribute : ValidationAttribute{
    //     protected override ValidationResult IsValid(Object value, ValidationContext validationContext ){
    //         value.ToString();
    //         int date =(DateTime.Now).Subtract(value);
    //         if(date < 18)
    //             return new ValidationResult("You need to be 18 to register");
    //         return ValidationResult.Success;
    //     }
    // }
}