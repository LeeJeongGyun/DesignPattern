namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature(27.4f);
            CoffeeMachine c = new CoffeeMachine();
            Light l = new Light();
            
            // Facade 클래스 하나로 내부 서브 시스템 클래스들을 조절
            // 클라이언트는 내부 서브 시스템이 어떻게 구현되어 있는 지 알 필요가 없음
            FacadeClass facade = new FacadeClass(t, c, l);

            // Facade 클래스의 인터페이스 하나로 내부 서브 시스템을 다룰 수 있음
            facade.SetEverything(22.4f, true, true);

            facade.TurnOffEverything();
        }
    }
}
