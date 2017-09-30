using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventStore.TestClient.Models;

namespace EventStore.TestClient.Controllers
{
    public class EventStore : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(string environment, string eventName, string eventData, string eventMetaData)
        {
                        
            // var connection = EventStoreConnection.Create(new IPEndPoint(IPAddress.Loopback, 1113));

            // // Don’t forget to tell the connection to connect!
            // connection.ConnectAsync().Wait();

            // var myEvent = new EventData(Guid.NewGuid(), "testEvent", false,
            //                             Encoding.UTF8.GetBytes("some data"),
            //                             Encoding.UTF8.GetBytes("some metadata"));

            // connection.AppendToStreamAsync("test-stream",
            //                             ExpectedVersion.Any, myEvent).Wait();

            // var streamEvents =
            //     connection.ReadStreamEventsForwardAsync("test-stream", 0, 1, false).Result;

            // var returnedEvent = streamEvents.Events[0].Event;

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
