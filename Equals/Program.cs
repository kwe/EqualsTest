using System.Runtime.InteropServices;
using System.Security.Cryptography;
Console.WriteLine("Compare without timing attack");

// fake keys for demo
var apiKey = "878dy8gfgyfdg7y8yw8y87gfgf";
var requestString = "878dy8gfgyfdg7y8yw8y8yd8yd7gfgf";

var apiKeySpan = MemoryMarshal.Cast<char, byte>(apiKey.AsSpan());

var submittedApiKeySpan = MemoryMarshal.Cast<char, byte>(requestString.AsSpan());

Console.WriteLine(CryptographicOperations.FixedTimeEquals(submittedApiKeySpan, apiKeySpan) ? "Success" : "Fail");