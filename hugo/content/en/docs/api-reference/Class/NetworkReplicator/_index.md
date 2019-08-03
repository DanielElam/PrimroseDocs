---
title: API:Class/NetworkReplicator
linkTitle: "NetworkReplicator"
weight: 4
date: 2019-08-02
explorerImage: connect
namespace: Primrose.DataModel.Networking.NetworkReplicator
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/NetworkReplicator"><img src="/icons/silk/connect.png"/>&nbsp;NetworkReplicator</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for network replicators.

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
The address of this connection.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsConnected">IsConnected</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets whether or not the connection is connected.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Player">Player</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Player">Player</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The player that this replicator is connected to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Port">Port</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The port this connection is running on.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ReplicationEnabled">ReplicationEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if replication messages should be sent/received.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="CloseConnection">CloseConnection</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> goodbye = <i>""</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Disconnects the replicator, ending the connection.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Player">Player</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlayer">GetPlayer</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the player which is associated with this replicator.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Disconnection">Disconnection</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> peer, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> lostConnection, <a class="type" href="/docs/api-reference/System/string">string</a> reason</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when a replicator is disconnected.
</p></td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/ClientReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ClientReplicator</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReplayReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ReplayReplicator</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ServerReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ServerReplicator</a>
<ul class="nested">
</ul>
</ul>
</div>
