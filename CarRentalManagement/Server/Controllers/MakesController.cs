﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Repository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MakesController(ApplicationDbContext context)
        public MakesController(IUnitOfWork unitOfWork)  
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
       // public async Task<ActionResult<IEnumerable<Make>>> GetMake_1()
       public async Task<IActionResult> GetMakes()
        {
          ////if (_context.Make_1 == null)
          //{
          //    return NotFound();
          //}
            //return await _context.Make_1.ToListAsync();
            var makes = await _unitOfWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetMake(int id)
        {
            var make = await _unitOfWork.Makes.Get(q=>q.Id == id);
          //if (_context.Make_1 == null)
          //{
          //    return NotFound();
          //}
          //  var make = await _context.Make_1.FindAsync(id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Makes.Update(make);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
          //if (_context.Make_1 == null)
          //{
          //    return Problem("Entity set 'ApplicationDbContext.Make_1'  is null.");
          //}
            //_context.Make_1.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save(HttpContext);
    
            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //if (_context.Make_1 == null)
            //{
            //    return NotFound();
            //}
            //var make = await _context.Make_1.FindAsync(id);
            var make = await _unitOfWork.Makes.Get(q=>q.Id==id); 
            if (make == null)
            {
                return NotFound();
            }

            //_context.Make_1.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> MakeExists(int id)
        {
            //return (_context.Make_1?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Makes.Get(q=>q.Id == id);
            return make!=null;  
        }
    }
}
