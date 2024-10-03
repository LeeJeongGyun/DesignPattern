namespace Singleton
{
    internal class Theme
    {
        public string Color { get; set; } = "white";
        
        private static Theme _instance;
        public static Theme Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Theme();
                }

                return _instance;
            }
        }

        private Theme() { }
    }

    internal class Button
    {
        public void ButtonColor()
        {
            Console.WriteLine($"Button Color:{Theme.Instance.Color}");
        }
    }

    internal class Label
    {
        public void LabelColor()
        {
            Console.WriteLine($"Label Color:{Theme.Instance.Color}");
        }
    }

    internal class Field
    {
        public void FieldColor()
        {
            Console.WriteLine($"Field Color:{Theme.Instance.Color}");
        }
    }
}
