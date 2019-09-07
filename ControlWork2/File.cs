using System;
using DataStruct;

namespace ControlWork2
{
    public abstract class File
    {
        protected string _name;
        protected string _size;
        protected string _extension;

        public virtual void Separator(string str)
        {
            string[] split = str.Split('(', ')', ';');
            string [] temp = split[0].Split('.');
            _name = split[0];
            _extension = temp[temp.Length - 1];
            _size = split[1];
        }
    }
}
