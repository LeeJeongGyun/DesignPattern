namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            Field field = new Field();
            Label label = new Label();

            button.ButtonColor();
            field.FieldColor();
            label.LabelColor();

            Theme.Instance.Color = "Dark";


            button.ButtonColor();
            field.FieldColor();
            label.LabelColor();
        }
    }
}
