namespace Facade;

internal class FacadeClass
{
    private Temperature     _temperature;
    private CoffeeMachine   _coffeeMachine;
    private Light           _light;

    public FacadeClass(Temperature t, CoffeeMachine c, Light l)
    {
        _temperature = t;
        _coffeeMachine = c;
        _light = l;
    }

    public void SetEverything(float temperature, bool coffeeState, bool lightState)
    {
        _temperature.BasicTemperature = temperature;
        _coffeeMachine.CoffeeMachineState = coffeeState;
        _light.LightState = lightState;
    }

    public void TurnOffEverything()
    {
        _temperature.BasicTemperature = 36.5f;
        _coffeeMachine.CoffeeMachineState = false;
        _light.LightState = false;
    }
}
