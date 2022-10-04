using RemoteControlledCar.Classes;

internal class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public void TryFinishTrack(RemoteControlCar car)
    {
        int remainingBatteryPercent = car.getRemainingBatteryPercent();
        int batteryDrain = car.getBatteryDrain();
        int distanceDrived = car.getDistanceDrived();
        int speed = car.getSpeed();


        Boolean finishedTrack = false;
        while (!finishedTrack)
        {
            if (remainingBatteryPercent > 0)
            {

                remainingBatteryPercent -= batteryDrain;
                distanceDrived += speed;

                if (distanceDrived >= this.distance)
                {
                    finishedTrack = true;
                    break;
                }
            }
            else
            {
                break;
            }
        }

        if (finishedTrack)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}