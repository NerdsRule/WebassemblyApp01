using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp01.Server
{
    
    public static class StaticTask
    {
        public static DateTime? StaticDate { get; set; }
        public static bool RunThread { get; set; } = true;
        public static void UpdateTime()
        {
            Task.Run(() =>
            {
                while (RunThread)
                {
                    StaticDate = DateTime.Now;
                    Thread.Sleep(10000);
                }                   
            });
            
        }
    }
}
