using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManage.web.Data;
using AutoMapper;
using LeaveManage.web.Models;
using System.Drawing;
using LeaveManage.web.Repository;
using LeaveManage.web.Repositories;

namespace LeaveManage.web.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        //private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            //_context = context;
            _leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        // GET: LeaveTypes
        //public async Task<IActionResult> Index()
        //{
        //    _leaveTypeRepository.GetAllAsync();
        //      return _context.LeaveTypes != null ? 
        //                  View(mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync())):
        //                  Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");

        //}

        public async Task<IActionResult> Index()
        {
            var aa = await Task.WhenAll(_leaveTypeRepository.GetAllAsync());


            return await Task.WhenAll( _leaveTypeRepository.GetAllAsync() )!= null ?
                        View(mapper.Map<List<LeaveTypeVM>>(await _leaveTypeRepository.GetAllAsync())) :
                        Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");

        }

        // GET: LeaveTypes/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.LeaveTypes == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }
        //    var leavetypeVM = mapper.Map<LeaveTypeVM>(leaveType);
        //    return View(leavetypeVM);
        //}


        public async Task<IActionResult> Details(int? id)
        {


            var leaveType = await _leaveTypeRepository.GetAsync(id);
                
            if (leaveType == null)
            {
                return NotFound();
            }
            var leavetypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leavetypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Leave_Name,Default_Day,Id,DateCreated,DateModified")] LeaveTypeVM leaveTypeVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
        //        _context.Add(leaveType);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(leaveTypeVM);
        //}


        //  Comment for Repository pattern

        //public async Task<IActionResult> Create( LeaveTypeVM leaveTypeVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
        //        _context.Add(leaveType);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(leaveTypeVM);
        //}

        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                await _leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }


        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           var leavetypeVM =  await Details(id);

            //var leavetypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leavetypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        #region Comment by umair ullah
        //public async Task<IActionResult> Edit(int id, [Bind("Leave_Name,Default_Day,Id,DateCreated,DateModified")] LeaveType leaveType)
        //{
        //    if (id != leaveType.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(leaveType);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LeaveTypeExists(leaveType.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(leaveType);
        //}
        #endregion

        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                   
                    //_context.Update(leaveType);
                    //await _context.SaveChangesAsync();

                    await _leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!LeaveTypeExists(leaveTypeVM.Id))
                    if(true)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
       // public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.LeaveTypes == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.LeaveTypes == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
        //    }
        //    var leaveType = await _context.LeaveTypes.FindAsync(id);
        //    if (leaveType != null)
        //    {
        //        _context.LeaveTypes.Remove(leaveType);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool LeaveTypeExists(int id)
        //{
        //  return (_context.LeaveTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
