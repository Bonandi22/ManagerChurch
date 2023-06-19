using System;
using System.Collections.Generic;

namespace IcmOdivelas.WebAPI.Models
{
    public class Group
    {
        public Group(int id, string name, int? memberId)
        {
            Id = id;
            Name = name;
            MemberId = memberId;
            Members = new List<Member>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MemberId { get; set; }
        public List<Member> Members { get; set; }
    }
}
