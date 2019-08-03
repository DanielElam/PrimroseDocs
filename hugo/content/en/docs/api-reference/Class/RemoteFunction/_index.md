---
title: API:Class/RemoteFunction
linkTitle: "RemoteFunction"
weight: 4
date: 2019-08-02
explorerImage: remote_method
namespace: Primrose.DataModel.Networking.RemoteFunction
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/RemoteFunction"><img src="/icons/silk/remote_method.png"/>&nbsp;RemoteFunction</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A networked method.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Delegate">Delegate</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ClientInvokeCallback">ClientInvokeCallback</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The callback for when the server invokes this function.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/DeliveryMethod">DeliveryMethod</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DeliveryMethod">DeliveryMethod</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines how reliable the message delivery is.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Delegate">Delegate</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ServerInvokeCallback">ServerInvokeCallback</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The callback for when the client invokes this function.
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
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InvokeClient">InvokeClient</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> player, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes the function that the provided player has bound to this instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InvokeServer">InvokeServer</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes the function that the server has bound to this instance.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
