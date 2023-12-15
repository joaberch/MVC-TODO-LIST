using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TODO_LIST
{
    internal class Model
    {
        private Controller _controller;
        
        internal Controller Controller { get => _controller; set => _controller = value; }

        public void createTask(Task task)
        {
            File.WriteAllText("task.csv", JsonSerializer.Serialize(task));
        }
    }
}
