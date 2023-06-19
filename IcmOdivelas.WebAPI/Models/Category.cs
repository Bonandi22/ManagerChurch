using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcmOdivelas.WebAPI.Models
{
    public class Category
    {
        public Category(int id, string name, int memberId)
        {
            Id = id;
            Name = name;
            MemberId = memberId;
        }

    public int Id { get; set; }
    public string Name { get; set; }
    public int MemberId { get; set; }
    public Member? members { get; set; }
    }
}