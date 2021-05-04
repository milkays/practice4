using System;
using System.Collections.Generic;
using System.Text;
using Certi.Practice4;
using Certi.Practice4.Database;
using Certi.Practice4.Logic.Models;

namespace Certi.Practice4.Logic.Managers
{
    public class GroupManager : IGroupManager
    {
        private readonly IDbContext _dbContext;
        
        public GroupManager(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Group> GetAllInfo()
        {
            List<Database.Models.Group> group = _dbContext.GetAll();
            return DTOMappers.MapGroup(group);
        }

        public Group CreateGroup(string groupID, string groupName, int groupSlots)
        {
           Group g =  new Group()
            {
                ID = groupID,
                Name = groupName,
               
                AvailableSlots = groupSlots

            };
            //List<Database.Models.Group> group = _dbContext.GetAll();
            //group.Add(g);
            return g;
        }

        public Group UpdateGroup(Group group)
        {
            group.Name = "updated";

            return group;
        }

        public Group DeleteGroup(Group group)
        {
            group.Name = "deleted";
            return group;
        }
    }
}
