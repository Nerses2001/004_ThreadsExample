namespace _004_ThreadsExample
{
    public class ThreadWork
    {
        public Thread RunThread;
        public bool _stop;
        public readonly ConsoleColor _color;

        public int Count { get; set; }

        public ThreadWork( ConsoleColor color)
        {
            RunThread = new Thread(Run);
            this._color = color;
            Console.ForegroundColor = this._color;
            Console.WriteLine("Thread " + RunThread.Name + " started");
        }

        public void Run()
        {
            do
            {
                ++Count;
            }
            while (_stop == false && Count < 20000000);
        }

        public void BeginInvoke()
        {
            RunThread.Start();
        }

        public void EndInvoke()
        {
            RunThread.Join();
        }

        public ThreadPriority Priority
        {
            set { RunThread.Priority = value; }
        }
    }
}
