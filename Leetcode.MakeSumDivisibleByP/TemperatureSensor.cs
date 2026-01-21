namespace Studying
{
    public class TemperatureSensor
    {
        private readonly object _lockObject = new();
        private double _currentTemperature;
        private double _threshold;

        public event EventHandler<TemperatureChangedEventArgs>? TemperatureExceeded;

        public TemperatureSensor(double threshold)
        {
            _threshold = threshold;
        }

        public void UpdateTemperature(double newTemperature)
        {
            double oldTempurature;
            lock (_lockObject)
            {
                oldTempurature = _currentTemperature;
                _currentTemperature = newTemperature;
            }

            if(newTemperature >= _threshold)
            {
                OnTemperatureExceeded(oldTempurature, newTemperature);
            }
        }

        protected virtual void OnTemperatureExceeded(double oldTemp, double newTemp) {
            var handler = TemperatureExceeded;
            if (handler != null) { 
                var args = new TemperatureChangedEventArgs(oldTemp, newTemp);
                handler(this, args);
            }
        }

        public void ChangeThreshold(double newThreshold)
        {
            lock (_lockObject)
            {
                _threshold = newThreshold;
            }
        }
    }
}
