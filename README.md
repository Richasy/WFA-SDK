# Warframe Alerting Prime - C# SDK

## Introduce about Warframe Alerting Prime

Warframe Alerting Prime（以下简称WFA）是由云之幻开发的一款展示Warframe游戏信息的应用，现已集成了Warframe Market和WFA Riven Market等诸多服务。

UWP应用下载地址：[微软应用商店](https://www.microsoft.com/store/productId/9MV8KGSLRVTF)

## Install SDK

|||
|-|-|
|SDK name|Richasy.Wfa.Sdk|
|Target Platform| .Net Standard 2.0|
|Build tools|Visual Studio 2019|

Nuget: [下载地址](https://www.baidu.com)

目前也已经开放源代码，您可以根据自己平台的需要自行适配。

## How to use

### Authorization

使用本SDK，您需要申请资格认证，具体申请方式请参考这篇文档。

### Start

在安装完SDK并申请了CliendId和ClientSecret之后，您可以按照如下方式使用SDK:

#### - Create `Client`

`Client`中包含了你能使用的所有方法，在使用之前，你需要先创建它。

有两种创建方式：

1. 传入你的`ClientId`，`ClientSecret`，请求的[权限](#Permission)，和目标游戏平台

```csharp
Client client = new Client(clientId, clientSecret, permissions, PlatformType.PC);
```

这种创建方式适合首次使用SDK时进行，创建完成后，调用`client.InitAsync()`方法，将会向WFA服务器申请Token，执行完毕后，你需要保存`client.Token`的值，并使用第二种创建方式（这会提高你的加载速度）

2. 传入之前获得过的Token和目标游戏平台

```csharp
Client client = new Client(token, PlatformType.PC);
```

Token的有效期是两周，这两周内，你都可以调用这个方法创建Client类。

#### - Initializing client

```csharp
await client.InitAsync();
```

上一步你创建了`client`，但是还不能立刻使用，你需要进行初始化，这种初始化体现在两方面：

- 通过ClientId创建的`Client`，需要向服务器发送请求，得到授权令牌
- 通过`Token`创建的`Client`，需要发送一个简单请求用于验证Token的有效性（如果你确认`Token`有效，可以跳过这一步）

#### - Add exception handler

```csharp
client.OnException += Client_OnException;
```

这个错误处理是一个全局的错误处理，即无论你在哪个模块出现了**网络请求错误**，都会触发该事件。但如果是内部的数据处理错误则会抛出异常。

### Get Game Information

> 关于所有游戏信息模块的说明，请参见这篇文档

#### - Get total information

```csharp
string total = await client.GetAllGameInfoAsync();
```

获取到的信息包含游戏数据的所有模块，将以json字符串的形式传出。

#### Get part information

以希图斯昼夜信息举例，分部信息通常有两种获取方式：

1. 请求服务器获取数据

```csharp
CetusStatus cetus = await client.GetCetusStatusAsync();
```

2. 根据之前获取到的全部游戏信息字符串解析

```csharp
CetusStatus cetus = cleint.GetCetusStatus(total);
```

