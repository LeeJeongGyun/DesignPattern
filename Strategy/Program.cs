namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CookingClass cookClass = new CookingClass();

            // 후라이팬 전략을 사용하겠어.
            cookClass.Cook(new FryingPan());

            // 이번에는 냄비 전략을 사용하겠어.
            cookClass.Cook(new Pot());
        }
    }
}
