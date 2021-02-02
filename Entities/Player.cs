using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
    }
}
