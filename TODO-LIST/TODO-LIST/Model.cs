using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_LIST
{
    internal class Model
    {
        private Controller _controller;

        private int _id;
        private string _name;
        private string _description;
        private string statuts;
        

        internal Controller Controller { get => _controller; set => _controller = value; }
    }
}
