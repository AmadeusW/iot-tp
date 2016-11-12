using System.IO;
using System.Net;
using ProtoBuf;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"iot-tp activated by {req.RequestUri}");

    return req.CreateResponse(HttpStatusCode.OK, "I love TP");
}
