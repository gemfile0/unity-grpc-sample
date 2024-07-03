# unity-grpc-sample
This is a sample project for gRPC communication using [YetAnotherHttpHandler](https://github.com/Cysharp/YetAnotherHttpHandler) and [protobuf-unity](https://github.com/5argon/protobuf-unity).

## Unity Version
The Unity version used is 2022.3.21f1.

## protobuf-unity Configuration Required
Fill in the full paths of the following two files included in the project in Edit -> Preferences -> Protobuf -> Path to protoc, Path to grpc:
- unity-grpc-sample\grpc.tools.2.64.0\tools\windows_x64\protoc.exe
- unity-grpc-sample\grpc.tools.2.64.0\tools\windows_x64\grpc_csharp_plugin.exe<br><br>
![Reference Screenshot](screenshots/Unity_GwxW5Glsdd.png)

## Sample Scene Path
- Assets/UnityGrpcSample/Scenes/SampleScene.unity<br>
    Press the Play button while a gRPC server, which has registered the same proto file as `Assets/UnityGrpcSample/protos/greet.proto`, is running. The server response will be displayed on ResponseText(TextMeshProUGUI).



## Package Dependencies
- [YetAnotherHttpHandler](https://github.com/Cysharp/YetAnotherHttpHandler)
    - [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)
        - System.IO.Pipelines
        - System.Runtime.CompilerServices.Unsafe
        - Grpc.Net.Client

- [protobuf-unity](https://github.com/5argon/protobuf-unity)
    - NuGetForUnity
        - Google.Protobuf 
    - [Grpc.Tools](https://www.nuget.org/packages/Grpc.Tools/)