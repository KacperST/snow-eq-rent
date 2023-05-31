using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentMVCApp.Models{
    public enum ItemType{
        Goggles,
        SnowboardBoots,
        SkiBoots,
        Skis,
        Snowboards,
        Helmets
    }

    public class Item{
        [Key]
        public int ID {get;set;}
        public int price{get;set;}

        public virtual ItemType type{get;set;}
        public bool availability{get;set;}
        public string? description{get;set;}

    }
}