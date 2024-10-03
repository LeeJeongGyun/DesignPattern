namespace Facade;

internal class Temperature
{
    public Temperature(float temperature) 
    {
        BasicTemperature = temperature;
    }
    public float BasicTemperature { get; set; }
}

internal class CoffeeMachine
{
    public CoffeeMachine(bool turnOnOff = false)
    {
        CoffeeMachineState = turnOnOff;
    }

    public bool CoffeeMachineState { get; set; }
}

internal class Light
{
    public Light(bool turnOnOff = false)
    {
        LightState = turnOnOff;
    }

    public bool LightState { get; set; }
}
