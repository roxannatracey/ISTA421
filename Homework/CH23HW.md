#### Roxanna Barahona
#### April 20, 2020
#### Homework: C#
#### C# Ch 23

1 List two reasons for multitasking, and explain the rationale for them.
- A multitasking operating system divides the available processor time among the processes or threads that need it. The system is designed for preemptive multitasking; it allocates a processor time slice to each thread it executes.
- improve scalability and responsiveness
2 Explain Moore's law. What does Moore's law have to do with multitasking?
- Moore’s Law states that every 18 months a CPU’s transistors will shrink in size by a factor of two. This means every 18 months you can stuff twice as many transistors onto a CPU, making it twice as fast.

3 In UWP, what namespace is used as the container for the multitasking methods?
- System.Threading.Thread

4 What is the difference between tasks and threads? Explain.
- A task is something you want done. A thread is one of the many possible workers which performs that task.

5 What is the ThreadPool?
- threadpool is a cross-platform C++ thread pool library. In general terms thread pools are an efficient mechanism for asynchronous task processing within the same process.

6 What parameters does the Task() constructor take?
- Task Constructor (Action, Object)

7 How do you start a thread?
- Thread t = new Thread(new ParameterizedThreadStart(StartupA)); t.Start(new MyThreadParams(path, port));

8 What is the difference between the Start() and Run() methods?
- start() enable the Thread to be controlled in states. Explicity invoking run() , violates the flow and state of a Thread execution. start() is not invoked for the main method thread or "system" or group threads created/set up by the VM. Any new functionality added to this method in the future may have to also be added to the VM.

9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel?
Explain.
- Calling Parallel.Invoke (F1,F2,F3) will almost always be faster than calling F1(); F2(); F3();. The Parallel class never absolutely guarantees that the calls are parallelized, but there is seldom a reason (especially on modern systems) that it might opt to run them in sequence. Invoke also handles a large input array well, since it will spawn a number of threads and reuse them, and not create a new thread for each delegate, which would result in very high overhead costs for thread creation and deletion. You can supply an array with thousands of delegates, and Invoke will execute them all, parallelizing as best as it can. Invoke itself is a synchronous method, it will only return when it has executed all delegates. When one of the delegates throws an exception, Invoke will still execute all other delegates in its array. All the exceptions thrown by the delegates are bundled in an AggregateException, which Invoke will throw when it finishes. Invoke also lets you pass an optional ParallelOptions instance as the first argument. ParallelOptions allows you to do three things:
a. You can set its MaxDegreeOfParallelism property to set the maximum number of threads that Invoke will use
b. You can set its TaskScheduler property, if you have written your own scheduler, which will then be used to decide which delegate to run when and on which thread
c. You can set a CancellationToken Setting a cancellation token allows you to abort Invoke (remember that when a delegate throws an exception, the exception is swallowed and only rethrown by Invoke after all other delegates have been executed).

10 Explain how manual cancellation works using a cancellation token.
- A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects. You create a cancellation token by instantiating a CancellationTokenSource object, which manages cancellation tokens retrieved from its CancellationTokenSource.Token property. You then pass the cancellation token to any number of threads, tasks, or operations that should receive notice of cancellation.
