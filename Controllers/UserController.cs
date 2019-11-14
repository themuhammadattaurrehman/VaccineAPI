﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VaccineAPI.Models;

namespace VaccineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Context _db;

        public UserController(Context context)
        {
            _db = context;
        }

        [HttpGet]
        public async Task<Response<List<User>>> GetAll()
        {
           var list = await _db.Users.ToListAsync();
           return new Response<List<User>>(true, null, list);
        }

        [HttpGet("{id}")]
        public async Task<Response<User>> GetSingle(long id)
        {
            var single = await _db.Users.FindAsync(id);
            if (single == null)
                return new Response<User>(false, "Not Found", null);
           
                return new Response<User>(true, null, single);   
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(User User)
        {
            _db.Users.Update(User);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSingle), new { id = User.Id }, User);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, User User)
        {
            if (id != User.Id)
                return BadRequest();

            _db.Entry(User).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var obj = await _db.Users.FindAsync(id);

            if (obj == null)
                return NotFound();

            _db.Users.Remove(obj);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
