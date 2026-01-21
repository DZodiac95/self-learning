namespace Studying.Week_2.Day_5
{
    public class Publisher
    {
        public event EventHandler<TestEvent> ThresholdReached;

        public void CheckThreshold(int current, int limit)
        {
            if (current >= limit)
            {
                // 2. Prepare data and raise the event
                var args = new TestEvent
                {
                    Threshold = limit,
                    TimeReached = DateTime.Now
                };
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(TestEvent e)
        {
            // Null-conditional operator (?.) ensures thread-safety if no subscribers exist
            ThresholdReached?.Invoke(this, e);
        }
    }

    public class TestEvent : EventArgs {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
