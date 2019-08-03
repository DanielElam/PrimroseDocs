---
title: API:Class/RemoteEvent
linkTitle: "RemoteEvent"
weight: 4
date: 2019-08-02
explorerImage: remote_event
namespace: Primrose.DataModel.Networking.RemoteEvent
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/RemoteEvent"><img src="/icons/silk/remote_event.png"/>&nbsp;RemoteEvent</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A networked event.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/DeliveryMethod">DeliveryMethod</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DeliveryMethod">DeliveryMethod</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines how reliable the message delivery is.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FireAllClients">FireAllClients</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires <a href="/docs/api-reference/Class/RemoteEvent/ClientFired" >ClientFired</a> for all players.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FireClient">FireClient</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> player, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires <a href="/docs/api-reference/Class/RemoteEvent/ClientFired" >ClientFired</a> for the provided player.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FireServer">FireServer</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires <a href="/docs/api-reference/Class/RemoteEvent/ServerFired" >ServerFired</a> for the server.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ClientFired">ClientFired</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/object">object</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired on the client when the server invokes this event.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ServerFired">ServerFired</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/object">object</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired on the server when the client invokes this event.
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
