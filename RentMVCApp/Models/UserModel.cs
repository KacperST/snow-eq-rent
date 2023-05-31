using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentMVCApp.Models{

    public class User{

            [Key]
            public int ID{get;set;}
            public string? name{get;set;}
            public string? lastName{get;set;}

            public string? addres{get;set;}
    }
}
