using Cysharp.Net.Http;
using Grpc.Net.Client;
using GrpcService1;
using TMPro;
using UnityEngine;
using static GrpcService1.Greeter;

public class SampleScene : MonoBehaviour
{
    [SerializeField] private string _uri = "http://localhost:5288";
    [SerializeField] private string _name;
    [SerializeField] private TextMeshProUGUI _responseText;

    private async void Start()
    {
        using var handler = new YetAnotherHttpHandler() { Http2Only = true };
        using var channel = GrpcChannel.ForAddress(_uri, new GrpcChannelOptions() { HttpHandler = handler });
        var greeter = new GreeterClient(channel);

        var result = await greeter.SayHelloAsync(new HelloRequest { Name = _name });
        _responseText.text = result.Message;
    }
}
