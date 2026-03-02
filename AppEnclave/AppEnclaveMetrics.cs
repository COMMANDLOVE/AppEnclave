using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace AppEnclave
{
    public static class AppEnclaveMetrics
    {
        public static readonly Meter Meter = new("AppEnclave.Metrics", "1.0");
        public static readonly Histogram<double> RequestDuration = Meter.CreateHistogram<double>(
            "http.server.request.duration", "s", "Duration of HTTP server requests");
        public static readonly UpDownCounter<long> ActiveRequestsCounter = Meter.CreateUpDownCounter<long>(
            "http.server.active_requests",
            unit: "1",
            description: "Current running requests.");
        public static readonly Counter<long> RequestCounter = Meter.CreateCounter<long>(
            "http.server.request.count",
            unit: "1",
            description: "Total requests."
        );
        public static readonly ActivitySource ActivitySource = new("AppEnclave.Activity", "1.0");
    }
}
