using System;
using System.Collections.Generic;
using System.Text;

namespace Certi.Practice4.Logic.Models
{
    class DTOMappers
    {
        public static List<Group> MapGroup(List<Database.Models.Group> groups)
        {
            List<Group> mappedGroups = new List<Group>();

            foreach (Database.Models.Group group in groups)
            {
                mappedGroups.Add(new Group()
                {
                    ID = group.ID,
                    Name = group.Name
                });

            }

            return mappedGroups;
        }
    }
}
