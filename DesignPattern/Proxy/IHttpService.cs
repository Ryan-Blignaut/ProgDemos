namespace ProgDemos.DesignPattern.Proxy;

public interface IHttpService
{
	// No public methods are exposed in this interface, this is to prevent the user from using the real service directly.
	// In this example, we are only interested in the GET method
	string SendGetRequest(string url);


	// The following methods are not used in this example but would be used in a real-world scenario

	// string SendPutRequest(string url, string requestData);
	// string SendDeleteRequest(string url, string requestData);
	// string SendPatchRequest(string url, string requestData);
	// string SendPostRequest(string url, string requestData);
}