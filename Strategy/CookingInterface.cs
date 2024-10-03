namespace Strategy;

internal interface CookingInterface
{
    void Cook();
}

internal class FryingPan : CookingInterface
{
    public void Cook()
    {
        // 후라이팬에 맞는 원하는 기능 추가..
        Console.WriteLine("This is Frying Pan");
    }
}

internal class Pot : CookingInterface
{
    public void Cook()
    {
        // 냄비에 맞는 원하는 기능 추가...
        Console.WriteLine("This is Pot");
    }
}
