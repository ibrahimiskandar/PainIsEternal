using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class ProgrammingLanguage
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DateTime _dateTime;
        public DateTime DateTime { get { return _dateTime; } set { _dateTime = value; } }
    }
}
