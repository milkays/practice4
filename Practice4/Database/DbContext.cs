using Certi.Practice4.Database.Models;
using Database;
using System;
using System.Collections.Generic;

namespace Certi.Practice4.Database
{
    public class DbContext : IDbContext
    {
        public List<Group> GroupTable { get; set; }

        public DbContext()
        {
            
            GroupTable = new List<Group>()
            {
                new Group() { ID= "Group-001", Name = $"Camila", AvailableSlots = 2},
                new Group() { ID= "Group-002", Name = "Natalia", AvailableSlots = 2},
                new Group() { ID= "Group-003", Name = "Mayra", AvailableSlots = 2}
        };



        }

        public Group AddGroup(Group group)
        {
            GroupTable.Add(group);
            return group;
        }

        public Group UpdateGroup(Group groupToUpdate)
        {
            Group foundStudent = GroupTable.Find(group => group.ID == groupToUpdate.ID);

            foundStudent.Name = groupToUpdate.Name;
            return foundStudent;
        }

        public Group DeleteGroup(Group groupToDelete)
        {

            GroupTable.Remove(groupToDelete);
            return groupToDelete;

        }

        public List<Group> GetAll()
        {

            return GroupTable;
        }



    }
}
