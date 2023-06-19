using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcmOdivelas.WebAPI.Models
{  
    public class MemberFunction
    {
        public MemberFunction(int memberId, int functionId, int id, string name)
    {
        this.MemberId = memberId;
        this.FunctionId = functionId;
        this.Name = name;
        this.Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int MemberId { get; set; }
    public Member? members { get; set; }
    public int FunctionId { get; set; }
    public Function? function { get; set; }
    }
}