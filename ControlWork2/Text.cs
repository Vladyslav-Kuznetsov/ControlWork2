using System;
using DataStruct;

namespace ControlWork2
{
    public class Text : File
    {
        private string _content;

        public override void Separator(string str)
        {
            base.Separator(str);
            _content = str.Split('(', ')', ';')[3];
        }

        public override string ToString()
        {
            return $"Text:\n\t{_name}\n\t\tExtension:{_extension}\n\t\tSize:{_size}\n\t\tContent:{_content}";
        }
    }
}
