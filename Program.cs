using _004_ThreadsExample;

Console.SetWindowSize(80, 40);

var work1 = new ThreadWork(ConsoleColor.Red);
var work2 = new ThreadWork(ConsoleColor.Yellow);

work1.Priority = System.Threading.ThreadPriority.Highest;
work2.Priority = System.Threading.ThreadPriority.Lowest;

work1.BeginInvoke();
work2.BeginInvoke();

work1.EndInvoke();
work2.EndInvoke();

Console.WriteLine();
Console.WriteLine("Thread " + work1.RunThread.Name + "can count " + work1.Count);
Console.WriteLine("Thread " + work2.RunThread.Name + "can count " + work2.Count);


