using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<ContactEntity>>>  GetContats()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return contacts;
        }

        [HttpPost("Insert")]
        public async Task<ContactEntity>  InsertContact(ContactEntity contact)
        {
            ContactEntity newContact = new ContactEntity()
            {
                Name = contact.Name,
                LastName = contact.LastName,
                Email = contact.Email,
                Address = contact.Address,
                PhoneNumber = contact.PhoneNumber,
            };
            _context.Add(newContact);
             _context.SaveChanges();
            return  newContact;
        }

        [HttpPut("Update")]
        public async Task<ContactEntity> UpdateContact(ContactEntity contact)
        {
            try
            {
                ContactEntity contactToBeUpdated = _context.Contacts.FirstOrDefault(c => c.Id == contact.Id);

                contactToBeUpdated.Name = contact.Name;
                // _context.Entry(contactToBeUpdated).Property(c => c.Name).IsModified = true;
                //contactToBeUpdated.Name != contact.Name ? contact.Name : contactToBeUpdated.Name;
                contactToBeUpdated.LastName = contact.LastName;
                contactToBeUpdated.Email = contact.Email;
                contactToBeUpdated.Address = contact.Address;
                contactToBeUpdated.PhoneNumber = contact.PhoneNumber;

                _context.SaveChanges();

                return contactToBeUpdated;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete("Delete")]
        public async void DeleteContact(int Id)
        {
            ContactEntity contactToBeDeleted = _context.Contacts.FirstOrDefault(c => c.Id == Id);

            _context.Contacts.Remove(contactToBeDeleted);

            _context.SaveChanges();
        }
    }
}