using IcmOdivelas.WebAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace IcmOdivelas.WebAPI.Data
{
    public class Repository: IRepository
    {
        private readonly DataContext _context;      

        public Repository(DataContext context)
        {
            _context = context;            
        }        
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >0);
        }

       public async Task<List<Member>> GetAllMembersAsync()
        {
            IQueryable<Member> query = _context.Members;
            
            query = query.AsNoTracking().OrderBy(m => m.Id);
            
            return await query.ToListAsync();
       }
       public async Task<Member> GetMembersByIdAsync(int memberId)
        {
            IQueryable<Member> query = _context.Members;
        
            query = query.AsNoTracking()
                        .OrderBy(m => m.Id)
                        .Where(m => m.Id == memberId);
            
            var member = await query.FirstOrDefaultAsync();

            if (member == null)
            {
                throw new Exception("Member not found");
            }
            
            return member;
        }
    }
}