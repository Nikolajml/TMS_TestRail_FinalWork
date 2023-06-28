using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Models
{
    public class ProjectBuilder
    {
        private Project project;

        public ProjectBuilder()
        {
            project = new Project();
        }

        public ProjectBuilder SetProjectName(string name)
        {
            project.Name = name;
            return this;
        }

        public ProjectBuilder SetProjectAnnouncement(string announcement)
        {
            project.Announcement = announcement;
            return this;
        }

        public Project Build()
        {
            return project;
        }
    }
}
