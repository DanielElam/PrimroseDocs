---
title: API:Class/NetworkServer
linkTitle: "NetworkServer"
weight: 4
date: 2019-08-02
explorerImage: server_network
namespace: Primrose.DataModel.Networking.NetworkServer
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/NetworkServer"><img src="/icons/silk/server_network.png"/>&nbsp;NetworkServer</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/NetworkPeer"><img src="/icons/silk/default.png"/>&nbsp;NetworkPeer</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Service for handling networking and replication on the server.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Address">Address</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The local address the server is hosted on.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/FastList">FastList</a><<a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AuthenticReplicators">AuthenticReplicators</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ClientCount">ClientCount</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The number of clients connected to the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ExternalAddress">ExternalAddress</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The external address the server is hosted on.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/Class/Player">Player</a>, <a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ReplicatorDictionary">ReplicatorDictionary</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
A dictionary of replicators indexed by player.
</p></td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetConnectionByIP">GetConnectionByIP</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> peerIP</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a <a href="/docs/api-reference/Class/ServerReplicator/" >ServerReplicator</a> with the matching IP address if one exists.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlayerAuthenticationRequired">GetPlayerAuthenticationRequired</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetPlayerAuthenticationRequired">SetPlayerAuthenticationRequired</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> value</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets whether or not clients are required to be authenticated.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Start">Start</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> serverPort = <i>0</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Starts the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Stop">Stop</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Stops the server.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ConnectionAccepted">ConnectionAccepted</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/ClientReplicator">ClientReplicator</a> peer, <a class="type" href="/docs/api-reference/Class/Player">Player</a> player</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a client is successfully authenticated.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ConnectionRejected">ConnectionRejected</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> </span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a client is rejected from joining a server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="IncomingConnection">IncomingConnection</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> peer, <a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a> replicator</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a client is in the process of connecting.
</p></td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
