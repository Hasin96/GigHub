using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GigHub.Controllers
{
    public class AttendancesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Attend([FromBody] AttendanceDTO dto)
        {
            var user = User.Identity.GetUserId();

            if (_context.Attendances.Any(g => g.GigId == dto.GigId && g.AttendeeId == user))
                return BadRequest("The attendance already exists");

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = user
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
