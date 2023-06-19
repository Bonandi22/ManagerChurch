using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcmOdivelas.WebAPI.Models
{
 public class Function
{
    public Function(int id, string name)
    {
        Id = id;
        Name = name;
        MemberFunctions = new List<MemberFunction>(); // Inicialize a propriedade aqui
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<MemberFunction> MemberFunctions { get; set; }
}

}