namespace ControlWork2
{
    public class Movies : Images
    {
        private string _length;

        public override void Separator(string str)
        {
            string[] split = str.Split('(', ')', ';');
            base.Separator(str);
            _length = split[4];
        }

        public override string ToString()
        {
            return $"Movies:\n\t{_name}\n\t\tExtension:{_extension}\n\t\tSize:{_size}\n\t\tContent:{_resolution}\n\t\tLength:{_length}";
        }
    }
}
