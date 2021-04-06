using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




namespace UtilitiesMain.CoroutinesAndYield
{



    public class CoroutinesExample
    {



        //public async void Show()
        //{
        //    await RunCoroutinesAsync(new CancellationToken());
        //}
        public void Show()
        {
            //RunCoroutinesAsync(new CancellationToken());
            RunCoroutines();
        }



        private static IEnumerable<int> CoroutineA()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write($"{nameof(CoroutineA)}: {new String('A', i)}");
                yield return i;
            }
        }



        private static IEnumerable<int> CoroutineB()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write($"{nameof(CoroutineB)}: {new String('B', i)}");
                yield return i;
            }
        }



        //private static async ValueTask RunCoroutinesAsync(CancellationToken token)
        //{

        //    // Combine two IEnumerable sequences into one and get an IEnumerator for it.
        //    using (var combined = CoroutineCombinator<int>.Combine(CoroutineA, CoroutineB).GetEnumerator())
        //    {
        //        var tcs = new TaskCompletionSource<bool>();

        //        using (var rego = token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: true))
        //        {
        //            using (var timer = new System.Windows.Forms.Timer { Interval = 50 })
        //            {
        //                timer.Tick += (s, e) =>
        //                {
        //                    try
        //                    {
        //                        // Upon each timer tick,
        //                        // pull/execute the next slice
        //                        // of the combined coroutine code flow.
        //                        if ( ! combined.MoveNext() )
        //                        {
        //                            tcs.TrySetResult(true);
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        tcs.TrySetException(ex);
        //                    }
        //                };
        //                timer.Start();
        //            }
        //        }

        //        await tcs.Task;
        //    }

        //}




        private static bool isTaskFinished = false;


        private static void RunCoroutines()
        {
            //bool isFinished = false;
            isTaskFinished = false;
            // Combine two IEnumerable sequences into one and get an IEnumerator for it.
            using (var combined = CoroutineCombinator<int>.Combine(CoroutineA, CoroutineB).GetEnumerator())
            {
                //using (var timer = new System.Windows.Forms.Timer { Interval = 50 })
                //using (var timer = new System.Threading.Timer(TimerCallbackMethod, combined, 0, 50))
                using (var timer = new System.Threading.Timer(TimerCallbackMethod, combined, 0, 200))
                {
                    while ( ! isTaskFinished )
                    {
                        //Thread.Sleep(100);
                        Thread.Sleep(1000);
                    }
                }
            }

        }



        private static void TimerCallbackMethod(Object o)
        {
            IEnumerator<int> enumerator = (IEnumerator<int>) o;
            if ( ! enumerator.MoveNext() )
            {
                isTaskFinished = true;
            }
        }



    }



}
