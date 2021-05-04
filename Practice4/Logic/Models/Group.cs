using System;
using System.ComponentModel.DataAnnotations;


namespace Certi.Practice4.Logic.Models
{
    public class Group
    {
        public String ID { get; set; }

        public String Name { get; set; }


        public int AvailableSlots { get; set; }

    }
}
