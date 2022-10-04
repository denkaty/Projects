using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlledCar.Classes
{
    internal class RemoteControlCar
    {
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


        public void Drive()
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


        public void DistanceDriven()
        {
            Console.WriteLine(this.distanceDrived);
        }

        public void BatteryDrained()
        {
            if (this.remainingBatteryPercent > 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }

        public static RemoteControlCar Nitro()
        {
            int nitroSpeed = 50;
            int nitroBatteryDrain = 4;
            return new RemoteControlCar(nitroSpeed, nitroBatteryDrain);
        }
    }
}
