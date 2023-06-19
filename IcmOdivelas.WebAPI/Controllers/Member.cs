using IcmOdivelas.WebAPI.Data;
using IcmOdivelas.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IcmOdivelas.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Member : ControllerBase
    {
        private readonly IRepository _repo;
  
        public Member ( IRepository repo){            
            _repo = repo;            
        }       
        
        [HttpGet]
        public async Task<IActionResult> Get(){
            
          var members = await _repo.GetAllMembersAsync(); 

            return Ok(members);
        }

        // api/members/byId
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){

            var members = await _repo.GetMembersByIdAsync(id);
            if (members == null)
                return BadRequest("Member not found");           
            return Ok(members);
        }       
        

         // api/members
        [HttpPost]
        public IActionResult Post(Member members)
        {           
            _repo.Add(members);
             if (_repo.SaveChanges())
            {
                return Ok(members);
            }
            return BadRequest("Member not created");                   
        }

        // api/student
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            var members = await _repo.GetMembersByIdAsync(id);
            if (members == null)
            {
                return BadRequest("Member not found");
            }            
            _repo.Update(members);
            if (_repo.SaveChanges())
            {
                return Created($"/api/Member/{members.Id}", members.Id);
            }         

            return BadRequest("Failed to update member");
        }

        // api/members
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id)
        {
            var members = await _repo.GetMembersByIdAsync(id);
            if (members == null)
            {
                return BadRequest("Member not found");
            }            
            _repo.Update(members);
            if (_repo.SaveChanges())
            {
                return Created($"/api/Member/{members.Id}", members.Id);
            }

            return BadRequest("Failed to update member");
        }

        // api/Member
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var members = await _repo.GetMembersByIdAsync(id);
            if(members==null) return BadRequest("Member not found");
            _repo.Delete(members);
            if(_repo.SaveChanges()){
                return Ok("Member Delet");
            }
            return BadRequest("Member not found");
        }
    }        
}
