using System;
using System.Collections.Generic;
using System.Text;

namespace NOVA.DAL.Models
{
    public  class FurnitureModel
    {
        public int Id { get; set; }

        public string ?Name { get; set; }

        public string ?Category { get; set; }

        public string ?ImageUrl { get; set; }
    }
}
