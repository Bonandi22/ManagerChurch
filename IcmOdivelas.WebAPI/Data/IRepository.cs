using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcmOdivelas.WebAPI.Models;

namespace IcmOdivelas.WebAPI.Data
{
    public interface IRepository
    {
        //All entity
        void Add <T> (T entity) where T: class;
        void Update <T> (T entity) where T: class;
        void Delete <T> (T entity) where T: class;
        bool SaveChanges();

        //MembersICM
        Task<List<Member>> GetAllMembersAsync();   
        Task <Member> GetMembersByIdAsync(int membersId);      

    }
}