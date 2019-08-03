---
title: "Client-Server Model"
linkTitle: "Client-Server Model"
weight: 2
date: 2019-07-19
---
<p style="margin-top: 1.0rem;"/>

Multiplayer in Primrose uses the client-server networking model. A single server will have authority over the true game state, while the clients connected to it will simulate an aproximation. A client can host a dedicated server concurrently, this is called a **Listen server**.

## Game Client
When a user starts their game client, they will not be connected to a server. They will have full authority over their local simulation and can load places and characters freely.  By default the `frontend` place is loaded on startup, which serves as a main menu. The client could choose to load a singleplayer place, or request to join a multiplayer server.

When the client connects to a server, the server will be put in charge of what place the client has to load and when to load their character.

## Starting a server
A server can be hosted and configured using the [NetworkServer](/docs/api-reference/Class/NetworkServer) service:
```fsharp
let server = game.GetService<NetworkServer>()
let port = 1297
server.Start(port) // start listening on port 1297
```
Clients can then connect to the server using the [NetworkClient](/docs/api-reference/Class/NetworkClient):
```fsharp
let client = game.GetService<NetworkClient>()
let ipAddress = "198.51.100.0"
let port = 1297
client.Start(ipAddress, port)
```

## Connection process
The connection process goes as follows:

1. Clients sends a connection request
2. A [ServerReplicator](/docs/api-reference/Class/ServerReplicator) object is created on the server to represent the connection with the client. The [NetworkServer.IncomingConnection](/docs/api-reference/Class/NetworkServer/IncomingConnection) event is fired.
3. If the server accepts, it creates a [Player](docs/api-reference/Class/Player) object and instructs the client to load the [current place](/docs/api-reference/Class/Workspace/PlaceId).
4. The server will load a new replicated [Character](docs/api-reference/Class/Player/Character) for the player to replace its current local character.

## Client Code
Client code runs inside a  [LocalScript](/docs/api-reference/Class/LocalScript). This code will only start running if the  [LocalScript](/docs/api-reference/Class/LocalScript)  is a descendant of these instances:

-   A player’s  [Character](/docs/api-reference/Class/Player/Character)  model
-   A player’s  [PlayerGui](/docs/api-reference/Class/PlayerGui) 
-   A player’s  [Backpack](/docs/api-reference/Class/Backpack) 
-   A player’s  [PlayerScripts](/docs/api-reference/Class/PlayerScripts)  folder

## Server Code
Server code runs inside a  [Script](/docs/api-reference/Class/Script). This code will only start running if the  [Script](/docs/api-reference/Class/Script)  is a descendant of these instances:

-   [Workspace](/docs/api-reference/Class/Player/Workspace) 
-   [ServerScriptService](/docs/api-reference/Class/ServerScriptService) 

## Remote functions/events
Remote functions and events can be used to communicate custom game data over the network. A [RemoteFunction](/docs/api-reference/Class/RemoteFunction) will make the script that calls it yield until it gets a response, while [RemoteEvent](/docs/api-reference/Class/RemoteEvent) does not take a response.
```fsharp
// on server
let remoteEvent = Instance.New<RemoteEvent>()
let callback = fun((x: int, y: int, z: int)) -> begin
    print(x, y, z)
end
remoteEvent.ServerEvent.connect(callback)
remoteEvent.Parent = game.Workspace
```

```fsharp
// on client
let remoteEvent = game.Workspace.WaitForChild("RemoteEvent") :?> RemoteEvent
let tuple = (1, 2, 3)
remoteEvent.FireServer(tuple)
```
