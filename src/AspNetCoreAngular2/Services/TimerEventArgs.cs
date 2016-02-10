using System;

namespace AspNetCoreAngular2.Services
{
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}