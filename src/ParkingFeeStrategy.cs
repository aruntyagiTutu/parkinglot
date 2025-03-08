namespace ParkingLotSystem
{

    public interface IParkingFeeStrategy
    {
        decimal CalculateFee(TimeSpan duration);
    }

    public class HourlyRateStrategy : IParkingFeeStrategy
    {
        private const decimal RatePerHour = 10m;

        public decimal CalculateFee(TimeSpan duration)
        {
            int hours = (int)Math.Ceiling(duration.TotalHours);
            return hours * RatePerHour;
        }
    }


    public class FlatRateStrategy : IParkingFeeStrategy
    {
        private const decimal FlatRate = 50m;

        public decimal CalculateFee(TimeSpan duration)
        {
            return FlatRate;
        }
    }


    public class WeekendDiscountStrategy : IParkingFeeStrategy
    {
        private const decimal WeekendRatePerHour = 8m;

        public decimal CalculateFee(TimeSpan duration)
        {
            int hours = (int)Math.Ceiling(duration.TotalHours);
            return hours * WeekendRatePerHour;
        }
    }


    public class ParkingFeeCalculator
    {
        private IParkingFeeStrategy _strategy;

        public ParkingFeeCalculator(IParkingFeeStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IParkingFeeStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateFee(TimeSpan duration)
        {
            return _strategy.CalculateFee(duration);
        }
    }

}