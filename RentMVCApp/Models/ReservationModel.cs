using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentMVCApp.Models{

    public class Reservation{

            [Key]
            public int ID{get;set;}
            public Item? item{get;set;}
            public User? user{get;set;}

            public DateTime reservedFrom{get;set;}
            public DateTime reservedUntill{get;set;}
    }
}
