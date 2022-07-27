using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
namespace ProjectManagement
{
    public class Project
    {
        private string id;
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private List<Person> team;

        public Project()
        {
            this.id = Guid.NewGuid().ToString();
            this.title = "Smart Drone Automation";
            this.description = "Smart helper for Agriculture";
            this.startDate = new DateTime(2022,7,26);
            this.endDate = new DateTime(2022,8,14);
            team = new List<Person>();
            team.Add(new Person());
        }

        public Project(string title, string description, DateTime startDate, DateTime endDate)
        {
            this.id = Guid.NewGuid().ToString();
            this.title = title;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            team = new List<Person>();
            team.Add(new Person());
        }

        public override string ToString()
        {
            return this.id+" , "+this.title+" , "+this.description;
        }

    }
}
