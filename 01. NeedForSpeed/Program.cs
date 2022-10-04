using System;

namespace NeedForSpeed
{
    public class Program
    {
        static void Main(string[] args)
        {
            int speed = 5;
            int batteryDrain = 2;
            RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);

            int distance = 800;
            RaceTrack raceTrack = new RaceTrack(distance);

            car.Drive();
            bool isBatteryDrained = car.BatteryDrained();
            Console.WriteLine(isBatteryDrained);

            car = RemoteControlCar.Nitro();
            car.Drive();
            int distanceDriven = car.DistanceDriven();
            Console.WriteLine(distanceDriven);

            bool isTrackFinished = raceTrack.TryFinishTrack(car);
            Console.WriteLine(isTrackFinished);
        }
    }
    public class RemoteControlCar
    {
        // TODO: define the constructor for the 'RemoteControlCar' class

        private int speed;
        private int batteryDrain;

        private int distanceDrived;
        private int remainingBatteryPercent;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;

            this.distanceDrived = 0;
            this.remainingBatteryPercent = 100;
        }
        public bool BatteryDrained()
        {

            bool batteryDrain = false;
            if (this.remainingBatteryPercent <= 0)
            {
                batteryDrain = true;
            }
            return batteryDrain;


            throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
        }

        public int DistanceDriven()
        {
            return this.distanceDrived;
            throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");

        }

        public void Drive()
        {
            try
            {
                int batteryLeft = this.remainingBatteryPercent - this.batteryDrain;
                if (batteryLeft > 0)
                {
                    this.distanceDrived += this.speed;
                    this.remainingBatteryPercent = batteryLeft;
                }
                else
                {
                    Console.WriteLine("battery is drained");
                }
            }
            catch
            {
                throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");

            }
        }

        public static RemoteControlCar Nitro()
        {
            int nitroSpeed = 50;
            int nitroBatteryDrain = 4;
            return new RemoteControlCar(nitroSpeed, nitroBatteryDrain);
            throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public int getBatteryDrain()
        {
            return this.batteryDrain;
        }

        public int getDistanceDrived()
        {
            return this.distanceDrived;
        }

        public int getRemainingBatteryPercent()
        {
            return this.remainingBatteryPercent;
        }
    }

    public class RaceTrack
    {
        // TODO: define the constructor for the 'RaceTrack' class

        private int distance;

        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            int remainingBatteryPercent = car.getRemainingBatteryPercent();
            int batteryDrain = car.getBatteryDrain();
            int distanceDrived = car.getDistanceDrived();
            int speed = car.getSpeed();

            bool finishedTrack = false;
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

            return finishedTrack;

            throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
        }
    }
}
