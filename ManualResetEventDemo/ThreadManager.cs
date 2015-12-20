// <copyright file="ThreadManager.cs" company="DevThread">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Roshan Fonseka</author>
// <summary>The ThreadManager class implementation.</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManualResetEventDemo
{
    public class ThreadManager
    {
        
        //Manual Reset Event handle
        private ManualResetEvent waitHandle;
        private object waitHandleLock = new object();

        private bool threadWithSleepActivityFlag = false;
        private int threadSleepInterval = 500; //0.5 Seconds 
        private bool threadWithManualResetEventActivityFlag = false;
        private bool threadWithManualResetEventEndFlag = false;
        private Timer demoTimer;
        private int demoCounter;

        /// <summary>
        /// Starts the thread with sleep
        /// Initializes the demoCounter and timer function that increments the demoCounter
        /// </summary>
        public void startThreadWithSleep()
        {            
            if (demoTimer == null)
            {
                demoCounter = 0;
                demoTimer = new Timer(DemoTimerCallback, null, 0, 1500);
            }

            if (!threadWithSleepActivityFlag)
            {
                threadWithSleepActivityFlag = true;
                
                Thread threadWithSleep = new Thread(new ThreadStart(workerForThreadWithSleep));
                threadWithSleep.Name = "ThreadWithSleep";
                threadWithSleep.Start();
            }
        }

        /// <summary>
        /// Stops the thread with sleep by setting the activity flag to false
        /// </summary>
        public void stopThreadWithSleep()
        {
            threadWithSleepActivityFlag = false;
        }

        /// <summary>
        /// Worker method of the thread with sleep
        /// periodically prints the demoCounter value on the console
        /// </summary>
        public void workerForThreadWithSleep()
        {
            Console.WriteLine("Starting ThreadWithSleep...");
            
            while (threadWithSleepActivityFlag)
            {
                Console.WriteLine("ThreadWithSleep  demo counter value: " + demoCounter.ToString());
                Thread.Sleep(threadSleepInterval);
            }

            Console.WriteLine("Stopping ThreadWithSleep...");
        }

        /// <summary>
        /// Caller method for the wait handle set function
        /// </summary>
        public void waitHandleSetCaller()
        {
            lock (waitHandleLock)
            {
                waitHandle.Set();
            }
        }

        /// <summary>
        /// Starts the thread with ManualResetEvent
        /// Initializes the demoCounter and timer function that increments the demoCounter
        /// </summary>
        public void startThreadWithManualResetEvent()
        {            
            if (demoTimer == null)
            {
                demoCounter = 0;
                demoTimer = new Timer(DemoTimerCallback, null, 0, 1500);
            }

            if (!threadWithManualResetEventActivityFlag)
            {
                waitHandle = new ManualResetEvent(false);
                threadWithManualResetEventActivityFlag = true;
                
                Thread threadWithManualResetEvent = new Thread(new ThreadStart(workerForThreadWithManualResetEvent));
                threadWithManualResetEvent.Name = "ThreadWithManualResetEvent";
                threadWithManualResetEvent.Start();
            }
        }

        /// <summary>
        /// Stops the thread with ManualResetEvent by setting the activity flag to false
        /// Sets the thread with ManualResetEvent end flag to inidicate the thread should terminate in the next iteration
        /// </summary>
        public void stopThreadWithManualResetEvent()
        {
            threadWithManualResetEventActivityFlag = false;
            threadWithManualResetEventEndFlag = true;
        }

        /// <summary>
        /// Worker method of the thread with ManualResetEvent
        /// periodically prints the demoCounter value on the console
        /// </summary>
        public void workerForThreadWithManualResetEvent()
        {
            Console.WriteLine("Starting ThreadWithManualResetEvent...");
            
            while (threadWithManualResetEventActivityFlag)
            {
                waitHandle.WaitOne();
                
                lock (waitHandleLock)
                {
                    Console.WriteLine("ThreadWithManualResetEvent demo counter value: " + demoCounter.ToString());
                    waitHandle.Reset();
                }
            }

            Console.WriteLine("Stopping ThreadWithManualResetEvent...");
        }

        /// <summary>
        /// Timer callback of the demoTimer
        /// Increments the demoCounter periodically
        /// Invokes the waitHandle Set method 
        /// </summary>
        /// <param name="state"></param>
        private void DemoTimerCallback(object state)
        {
            demoCounter++;
            
            if (threadWithManualResetEventActivityFlag || threadWithManualResetEventEndFlag)
            {
                waitHandle.Set();
                threadWithManualResetEventEndFlag = false;
            }
        }
    }
}
