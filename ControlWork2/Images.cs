namespace ControlWork2
{
    public class Images : File
    {
        protected string _resolution;

        public override void Separator(string str)
        {
            base.Separator(str);
            _resolution = str.Split('(', ')', ';')[3];
        }

        public override string ToString()
        {
            return $"Images:\n\t{_name}\n\t\tExtension:{_extension}\n\t\tSize:{_size}\n\t\tContent:{_resolution}";
        }
    }
}
