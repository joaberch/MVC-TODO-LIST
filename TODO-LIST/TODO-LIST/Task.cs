using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_LIST
{
    internal class Task
    {
        private string name;
        private string description;
        private DateTime dateCreated;
        private DateTime dateEnded;
        private string status;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime DateEnded { get => dateEnded; set => dateEnded = value; }
        public string Status { get => status; set => status = value; }
    }
}
