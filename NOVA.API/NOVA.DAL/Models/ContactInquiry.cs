using System;
using System.Collections.Generic;
using System.Text;

namespace NOVA.DAL.Models
{
    public class ContactInquiry
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
