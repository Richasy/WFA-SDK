# Warframe Alerting Prime - C# SDK

## Introduce about Warframe Alerting Prime

Warframe Alerting Prime (hereinafter referred to as **WFA**) is an application developed by 云之幻(Richasy) to display Warframe game information. It has now integrated many services such as Warframe Market and WFA Riven Market.

UWP application download: [Microsoft Store](https://www.microsoft.com/store/productId/9MV8KGSLRVTF)

## Install SDK

|||
|-|-|
|SDK name|Richasy.Wfa.Sdk|
|Target Platform| .Net Standard 2.0|
|Build tools|Visual Studio 2019|

Nuget: [Download](https://www.nuget.org/packages/Richasy.WFA.Sdk/1.0.0)

The source code is also open now, and you can adapt it according to the needs of your platform.

## How to use

### Authorization

To use this SDK, you need to apply for qualification certification, please refer to [this document](https://www.richasy.cn/document/wfa/data/authorize) for specific application methods.

### Start

After installing the SDK and applying for `CliendId` and `ClientSecret`, you can use the SDK as follows:

#### - Create `Client`

`Client` contains all the methods you can use, you need to create it before using it.

There are two ways to create:

1. Pass in your `ClientId`, `ClientSecret`, requested [Permission](#Permission), and target game platform.

```csharp
Client client = new Client(clientId, clientSecret, permissions, PlatformType.PC);
```

This creation method is suitable for the first use of the SDK. After the creation is completed, the `client.InitAsync()` method is called, and a token will be applied to the WFA server. After execution, you need to save the value of `client.Token` and use The second way to create (this will increase your loading speed)

2. Pass in the tokens and target game platforms that have been obtained before

```csharp
Client client = new Client(token, PlatformType.PC);
```

The validity period of the token is two weeks. Within these two weeks, you can call this method to create the Client class.

#### - Initializing client

```csharp
await client.InitAsync();
```

In the previous step, you created the `client`, but it cannot be used immediately. You need to initialize. This initialization is reflected in two aspects:

- The `Client` created by `ClientId` needs to send a request to the server to get the authorization token.
- A `Client` created by `Token` needs to send a simple request to verify the validity of the token (if you confirm that `Token` is valid, you can skip this step).

#### - Add exception handler

```csharp
client.OnException += Client_OnException;
```

This error handling is a global error handling, that is, this event will be triggered no matter which module you have **network request error**. But if it is an internal data processing error, an exception will be thrown.

### Get information

> For a description of all information modules, see [this document](https://www.richasy.cn/document/wfa/data/).

**Just call the method**

Examples:

#### - Get total information

```csharp
string total = await client.GetAllGameInfoAsync();
```

The obtained information contains all the modules of the game data and will be transmitted as a json string.

#### - Get part information

Taking Cetus day and night information as an example, there are usually two ways to obtain segment information:

1. Request the server to obtain data

```csharp
CetusStatus cetus = await client.GetCetusStatusAsync();
```

2. Parse all the game information strings obtained before

```csharp
CetusStatus cetus = cleint.GetCetusStatus(total);
```

## Permission

For accounts that apply for WFA access, the following permissions are available:

- `wfa.basic` : Involving game information and WM information
- `wfa.riven.query` : Involving in WFA Riven Market
- `wfa.user.read` : Involving WFA user information reading
- `wfa.lib.query` : Involves reading database entries

---

Welcome to my developer blog: [Richasy's Blog](https://blog.richasy.cn).

You can find all WFA APIs information here: [WFA API Introduce](https://www.richasy.cn/document/wfa/api/).

You can find all dicts here: [WFA Dictionary](https://github.com/Richasy/WFA_Lexicon/tree/WFA5).
