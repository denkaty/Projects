using System;
using RemoteControlledCar.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        int speed = 5;
        int batteryDrain = 100;
        RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);

        int distance = 800;
        RaceTrack raceTrack = new RaceTrack(distance);

        car.Drive();
        car.BatteryDrained();

        car = RemoteControlCar.Nitro();
        car.Drive();
        car.DistanceDriven();

        raceTrack.TryFinishTrack(car);
    }
}