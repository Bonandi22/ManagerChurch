using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcmOdivelas.WebAPI.Models
{
    public class Member
    {      
        public Member(int id, 
                          string surname, string name, string telephone,
                           DateTime birthDate, bool active) 
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Telephone = telephone;
            this.BirthDate = birthDate;
            this.Active = active;
   
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; } 
        public DateTime BirthDate { get; set; }   
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
        
    }
}