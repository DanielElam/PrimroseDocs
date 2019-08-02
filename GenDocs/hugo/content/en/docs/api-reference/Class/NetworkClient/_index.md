---
title: API:Class/NetworkClient
linkTitle: "NetworkClient"
weight: 4
date: 2019-08-02
explorerImage: client_network
namespace: Primrose.DataModel.Networking.NetworkClient
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/NetworkClient"><img src="/icons/silk/client_network.png"/>&nbsp;NetworkClient</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/NetworkPeer"><img src="/icons/silk/default.png"/>&nbsp;NetworkPeer</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Service for handling networking and replication on the client.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/ReplayReplicator">ReplayReplicator</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ReplayReplicator">ReplayReplicator</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The current active replay replicator.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/ClientReplicator">ClientReplicator</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Replicator">Replicator</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
This local client's replicator to the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Ticket">Ticket</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The client’s authorization ticket
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Connect">Connect</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> serverIP, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> serverPort</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Creates a <a href="/docs/api-reference/Class/Player/" >Player</a> object and attempts to connect to the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Disconnect">Disconnect</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> message = <i>Client was manually disconnected by client.</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Disconnect this client from the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="PlayerConnect">PlayerConnect</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">u32</a> userId, <a class="type" href="/docs/api-reference/System/string">string</a> serverIP, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> serverPort, <a class="type" href="/docs/api-reference/System/string">string</a> username = <i></i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ConnectionAccepted">ConnectionAccepted</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/ClientReplicator">ClientReplicator</a> replicator</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when <a href="/docs/api-reference/Class/NetworkClient/Connect" >Connect</a>successfully connects to a server. Returns the ClientReplicator.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ConnectionFailed">ConnectionFailed</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> reason</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired if <a href="/docs/api-reference/Class/NetworkClient/Connect" >Connect</a> fails to connect to a server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ConnectionRejected">ConnectionRejected</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> reason</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired if <a href="/docs/api-reference/Class/NetworkClient/Connect" >Connect</a> connects to a server, but the request to join is rejected.
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
