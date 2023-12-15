using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_LIST
{
    internal class Controller
    {
        private Model _model;
        private Form3 _view;

        public Form3 Form3 { get => _view; set => _view = value; }
        internal Model Model { get => _model; set => _model = value; }
    }
}
