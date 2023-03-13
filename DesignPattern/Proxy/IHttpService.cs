namespace ProgDemos.DesignPattern.Proxy;

public interface IHttpService
{
	// In this example, we are only interested in the GET method
	public string SendGetRequest(string url);

	
	
	// The following methods are not used in this example but would be used in a real-world scenario
	
	// public string SendPutRequest(string url, string requestData);
	// public string SendDeleteRequest(string url, string requestData);
	// public string SendPatchRequest(string url, string requestData);
	// public string SendPostRequest(string url, string requestData);
}