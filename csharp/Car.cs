using System;
namespace csharp
{
    public class Car
    {
        private Human m_driver;
        private string m_carBuilder;
        private double m_horsepower;
        private double m_maxSpeed;
        private double m_speed;
        private sbyte m_engagedGear;

        public Human Driver { get => m_driver; set => m_driver = value; }
        public double Horsepower{ get => m_horsepower; set => m_horsepower = IsPositive(value); }
        public double MaxSpeed { get => m_maxSpeed; set => m_maxSpeed = IsPositive(value); }
        public double Speed { get => m_speed; set => m_speed = IsPositive(value); }
        public sbyte EngagedGear { get => m_engagedGear; set => m_engagedGear = value; }
        public string CarBuilder { get => m_carBuilder;
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                m_carBuilder = value;
            }
        }

        public Car(Human p_driver, string p_carBuilder, float p_horsepower, float p_maxSpeed)
        {
            Driver = p_driver;
            CarBuilder = p_carBuilder;
            Horsepower = p_horsepower;
            MaxSpeed = p_maxSpeed;
        }

        public void Accelerate(double p_speed)
        {
            if (validSpeed(p_speed) && p_speed > Speed)
            {
                EngagedGear = ChangeGear(p_speed);
                Speed = p_speed;
            }
            else
                throw new ArgumentException("Speed neeed to be upper !");
        }

        public void SlowDown(double p_speed)
        {
            if (validSpeed(p_speed) && p_speed < Speed)
            {
                EngagedGear = ChangeGear(p_speed);
                Speed = p_speed;
            }
            else
                throw new ArgumentException("Speed neeed to be lower !");
        }

        public sbyte ChangeGear(double p_speed)
        {
            sbyte tmpGear = 0;
            switch (p_speed)
            {
                case double v_value when (v_value >= 0 && v_value <= 20):
                    tmpGear = 1;
                    break;
                case double v_value when (v_value >= 21 && v_value <= 40):
                    tmpGear = 2;
                    break;
                case double v_value when (v_value >= 41 && v_value <= 60):
                    tmpGear = 3;
                    break;
                case double v_value when (v_value >= 61 && v_value <= 80):
                    tmpGear = 4;
                    break;
                case double v_value when (v_value >= 81 && v_value <= MaxSpeed):
                    tmpGear = 5;
                    break;
            }
            return tmpGear;
        }

        private double IsPositive(double p_value)
        {
            if (p_value < 0.00)
                throw new ArgumentNullException();
            return p_value;
        }

        private bool validSpeed(double p_speed)
        {
            bool valid = true;
            if (p_speed < 0.00 || p_speed > MaxSpeed)
                throw new ArgumentOutOfRangeException("Speed out of range !");
            return valid;
        }

        public string ShowVehiculePapers()
        {
            return $"Constructeur voiture {CarBuilder} , " +
                $"Cheveaux fiscaux : {Horsepower}, " +
                $"{Driver.First_name} {Driver.Last_name} {Driver.Age} ans";
        }
    }
}
