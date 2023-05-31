using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentMVCApp.Models{

    public class Company{

            [Key]
            public int ID{get;set;}
            public int addres{get;set;}
            public DateTime? openfrom{get;set;}
            public DateTime? openUntil{get;set;}

    }
}
