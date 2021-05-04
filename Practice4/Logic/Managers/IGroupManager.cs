using Certi.Practice4.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Certi.Practice4.Logic.Managers
{
    public interface IGroupManager
    {
        List<Group> GetAllInfo();

        Group CreateGroup(string groupID, string groupName, int groupSlots);

        Group UpdateGroup(Group group);

        Group DeleteGroup(Group group);
    }
}
