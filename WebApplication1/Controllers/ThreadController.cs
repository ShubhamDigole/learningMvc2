using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ThreadController : Controller
    {
        public async Task<IActionResult> Index()
        {
            int startthread = Thread.CurrentThread.ManagedThreadId;
            Stopwatch w = new Stopwatch();
            w.Start();
            ThreadTestingModel data = new ThreadTestingModel();
            BussinesLayer logic = new BussinesLayer();

            Task<string> t1 = Task.Factory.StartNew<string>(logic.getData1);
            Task<string> t2 = Task.Factory.StartNew<string>(logic.getData2);
            Task<string> t3 = Task.Factory.StartNew<string>(logic.getData3);
            Task<string> t4 = Task.Factory.StartNew<string>(logic.getData4);

            await Task.WhenAll(t1, t2, t3, t4);

            data.Thread1 = t1.Result;
            data.Thread2 = t2.Result;
            data.Thread3 = t3.Result;
            data.Thread4 = t4.Result;

            w.Stop();
            int endThread = Thread.CurrentThread.ManagedThreadId;
            ViewBag.start = startthread;
            ViewBag.end = endThread;
            ViewBag.time = w.ElapsedMilliseconds;
            return View(data);
        }
    }
}