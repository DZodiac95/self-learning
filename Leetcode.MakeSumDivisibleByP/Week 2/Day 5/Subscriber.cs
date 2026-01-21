namespace Studying.Week_2.Day_5
{
    public class Subscriber : IDisposable
    {
        private readonly Publisher _publisher;

        public Subscriber(Publisher publisher)
        {
            _publisher = publisher;
            _publisher.ThresholdReached += OnSomeEvent;
        }

        public void Dispose()
        {
            _publisher.ThresholdReached -= OnSomeEvent;
        }
    }

}
