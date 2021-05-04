using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Certi.Practice4.Logic.Models;
using Certi.Practice4.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Certi.Practice4.Logic.Managers;

namespace Practice4.Controllers
{
    [ApiController]
    [Route("/api/info")]
    public class GroupController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IGroupManager _groupManager;
        public GroupController(IConfiguration config, IGroupManager infoManager)
        {
            _config = config;
            _groupManager = infoManager;
        }

        [HttpGet]
        public List<Group> GetInfo()
        {
            return _groupManager.GetAllInfo();
        }

        [HttpPost]
        public Group CreateStudents([FromBody] string groupID, string groupName, int groupSlots)
        {

            return _groupManager.CreateGroup(groupID,groupName, groupSlots);
        }

        [HttpPut]

        public Group UpdateStudent([FromBody] Group student)
        {
            return _groupManager.UpdateGroup(student);
        }

        [HttpDelete]
        public Group DeleteStudents([FromBody] Group student)
        {
            return _groupManager.DeleteGroup(student);
        }
    }
}
