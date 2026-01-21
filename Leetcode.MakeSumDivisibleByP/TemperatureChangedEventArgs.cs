namespace Studying
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double OldTemperature { get; set; }
        public double NewTemperature { get; set; }

        public TemperatureChangedEventArgs(double oldTemperature, double newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
        }
    }
}
