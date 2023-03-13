namespace ProgDemos.DesignPattern.Proxy;

// This is the real service.
public class HttpService : IHttpService
{
	// Implementation of the IHttpService interface, this interface is implemented explicitly to prevent the user from using the real service directly.
	string IHttpService.SendGetRequest(string url)
	{
		Console.WriteLine("Real Http Service: Sending a GET request to " + url);
		// Send an HTTP request
		using HttpClient client = new HttpClient();
		HttpResponseMessage response = client.GetAsync(url).Result;
		return response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync().Result : "Error occurred while sending the request";
	}

	// The other methods would be implemented in a similar way

	// Implement methods for the other HTTP methods
}