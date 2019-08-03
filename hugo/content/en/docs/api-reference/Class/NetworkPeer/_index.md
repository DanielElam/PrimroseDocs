---
title: API:Class/NetworkPeer
linkTitle: "NetworkPeer"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Networking.NetworkPeer
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/NetworkPeer"><img src="/icons/silk/default.png"/>&nbsp;NetworkPeer</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for <a href="/docs/api-reference/Class/NetworkClient/" >NetworkClient</a> and <a href="/docs/api-reference/Class/NetworkServer/" >NetworkServer</a>
</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsConnected">IsConnected</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the peer is connected to a server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsRunning">IsRunning</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true, the peer has been started.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Port">Port</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The port the server is hosted on.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Update">Update</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#double">double</a> step</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Performs a network update.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Tick">Tick</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#double">double</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/NetworkClient"><img src="/icons/silk/client_network.png"/>&nbsp;NetworkClient</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NetworkServer"><img src="/icons/silk/server_network.png"/>&nbsp;NetworkServer</a>
<ul class="nested">
</ul>
</ul>
</div>
