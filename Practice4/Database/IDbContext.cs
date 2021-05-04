using System;
using System.Collections.Generic;
using System.Text;
using Certi.Practice4.Database;
using Certi.Practice4.Database.Models;

namespace Certi.Practice4.Database
{
    public interface IDbContext
    {
        Group AddGroup(Group group);
        Group UpdateGroup(Group groupToUpdate);

        Group DeleteGroup(Group groupToDelete);

        List<Group> GetAll();
    }
}
