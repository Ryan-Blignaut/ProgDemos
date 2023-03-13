using ProgDemos.DesignPattern.Proxy;

namespace ProgDemos;

public static class Program
{
	// Demo of the proxy class
	public static void Main(string[] args)
	{
		// Create an instance of the proxy class
		AuthenticatedHttpServiceProxy proxy = new AuthenticatedHttpServiceProxy("Admin", "password");
		Console.WriteLine("Sending a request with valid credentials");
		Console.WriteLine("Public Ip gotten from Api: " + proxy.SendGetRequest("http://checkip.amazonaws.com/"));

		// Invalid credentials
		proxy = new AuthenticatedHttpServiceProxy("Admin", "wrongPassword");
		Console.WriteLine("Sending a request with invalid credentials");
		Console.WriteLine("Public Ip gotten from Api: " + proxy.SendGetRequest("http://checkip.amazonaws.com/"));

		// Example of protection of the real service
		HttpService httpService = new HttpService();
		// This give an error ->
		// httpService.SendGetRequest("");
	}
}