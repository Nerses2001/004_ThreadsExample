# 004_ThreadsExample
## Description

This code is a simple example of using threads in the C# programming language. It creates two threads using the `ThreadWork` class, each of which counts up to 20,000,000. One thread has high priority, and the other has low priority. The count results for each thread are displayed in the console.

## How the Code Works

1. A namespace `namespace _004_ThreadsExample` is created.
2. A class `ThreadWork` is defined, which represents a thread description.
3. For each thread, an object of the `ThreadWork` class is initialized with a different console color: red and yellow.
4. The thread priorities are set: high for one and low for the other.
5. The threads are started using the `BeginInvoke` method.
6. After the threads complete, the count of calculations performed by each thread is displayed.

The code provides a clear demonstration of using multithreading in C# with different thread priorities and asynchronous task execution.