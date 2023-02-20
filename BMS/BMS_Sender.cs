using System;
using System.Collections.Generic;

namespace BMS
{
    public class BMS_Sender
    {
        public struct BatteryData
        {
            public int BatteryLevel;
            public int BatteryChargingCurrent;
        }

        public static void Main()
        {
            int batteryLevelLimit = 100;
            int batteryChargingCurrentLimit = 50;
            int sensorDataCount = 50;

            List<BatteryData> sensorData = GenerateSimulatedSensorData(batteryLevelLimit, batteryChargingCurrentLimit, sensorDataCount);

            SendSimulatedSensorData(sensorData);
        }
        

        public static List<BatteryData> GenerateSimulatedSensorData(int batteryLevelLimit, int batteryChargingCurrentLimit, int sensorDataCount)
        {
            int batteryLevel = 0;
            int batteryChargingCurrent = 0;
            Random random = new Random();
            List<BatteryData> simulatedSensorData = new List<BatteryData>();

            for (int i = 0; i < sensorDataCount; i++)
            {
                batteryLevel = random.Next(0, batteryLevelLimit);
                batteryChargingCurrent = random.Next(0, batteryChargingCurrentLimit);
                simulatedSensorData.Add(new BatteryData
                {
                    BatteryLevel = batteryLevel,
                    BatteryChargingCurrent = batteryChargingCurrent
                });
            }

            return simulatedSensorData;
        }

        public static void SendSimulatedSensorData(List<BatteryData> sensorData)
        {
            foreach (var data in sensorData)
            {
                Console.WriteLine("({0,2},{1,2})", data.BatteryLevel, data.BatteryChargingCurrent);
            }
        }
    }
}
