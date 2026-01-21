namespace Studying.Week_2.Day_5
{
    public class EventBasedMemoryLeak : IDisposable
    {
        private readonly Publisher _publisher;
        public EventBasedMemoryLeak(Publisher publisher)
        {
            //Bad approach.
            //Publisher((static, singleton, app-wide service)) lives long, subscriber(view, view model, controller) is temporary.
            //subscriber will leak unless it unsubscribes.
            publisher.ThresholdReached += OnSomeEvent;

            //Correct approach.
            _publisher = publisher;
            _publisher.ThresholdReached += OnSomeEvent;
        }

        //Correct approach.
        //Unsubscribe manually.
        public void Dispose()
        {
            _publisher.ThresholdReached -= OnSomeEvent;
        }

        private void OnSomeEvent(object sender, EventArgs e) { }
    }
}
