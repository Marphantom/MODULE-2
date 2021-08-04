using System;

namespace stopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public StopWatch()
        {
            this.startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public TimeSpan GetElapsedTime()
        {
            TimeSpan interval = endTime - startTime;
            return interval;
        }
    }
}