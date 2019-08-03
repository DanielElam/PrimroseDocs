---
title: API:Class/NetworkServer/GetConnectionByIP
linkTitle: "GetConnectionByIP"
weight: 71
date: 2019-08-02
namespace: Primrose.DataModel.Networking.NetworkServer.GetConnectionByIP
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/NetworkServer"><img src="/icons/silk/server_network.png"/>&nbsp;NetworkServer</a>
<pre class="method-declaration">
GetConnectionByIP (
    peerIP: <a class="type" href="/docs/api-reference/System/string">string</a>
): <a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a>
<br/>
<b>Description: </b>
Returns a <a href="/docs/api-reference/Class/ServerReplicator/" >ServerReplicator</a> with the matching IP address if one exists.

