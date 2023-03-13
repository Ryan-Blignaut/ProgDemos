namespace ProgDemos.DesignPattern.Proxy;

public class AuthenticatedHttpServiceProxy : IHttpService
{
	// The real password and username, this would be stored in a secure location in a real-world scenario.
	private const string RealPassword = "password";
	private const string RealUsername = "Admin";

	// The real service that we are proxying
	private readonly IHttpService _httpService;

	// The username and password that we are login in with.
	private readonly string _username;
	private readonly string _password;


	//Create the proxy class with the username and password. 
	public AuthenticatedHttpServiceProxy(string username, string password)
	{
		_httpService = new HttpService();
		_username = username;
		_password = password;
	}

	// Implementation of the IHttpService interface, this is used to send the HTTP request
	public string SendGetRequest(string url)
	{
		// Debug to tell us that the proxy is checking the credentials before sending the request.
		Console.WriteLine("Proxy: Checking access prior to firing a real request.");

		// Make sure that the username and password are correct before sending the request.
		if (_username.Equals(RealUsername, StringComparison.OrdinalIgnoreCase) && _password.Equals(RealPassword))
		{
			LogAccess();
			return _httpService.SendGetRequest(url);
		}

		return "Invalid username or password";
	}

	private void LogAccess()
	{
		Console.WriteLine($"Proxy: {_username} has accessed the service.");
	}
}