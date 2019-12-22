// DnsServer.csx – Simple DNS Server
// Expose console methods like WriteLine at global level.
using static System.Console;

// Create the DNS server template.
var template = new DnsServerTemplate();

// Setup the response addresses
template.ResponseAddress = "127.0.0.1";
// template.ResponseAddress6 = "1010::1";
template.ReverseDns = "www.chauatwit.ac.th";

// Create DNS server instance and start.
var service = template.Create();
service.Start();
WriteLine("Created {0}", service);
WriteLine("Press Enter to exit...");
ReadLine();
service.Stop();