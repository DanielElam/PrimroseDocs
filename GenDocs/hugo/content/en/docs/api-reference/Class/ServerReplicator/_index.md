---
title: API:Class/ServerReplicator
linkTitle: "ServerReplicator"
weight: 4
date: 2019-08-02
explorerImage: connect
namespace: Primrose.DataModel.Networking.ServerReplicator
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ServerReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ServerReplicator</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/NetworkReplicator"><img src="/icons/silk/connect.png"/>&nbsp;NetworkReplicator</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Represents the server's connection to a client.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsAuthenticated">IsAuthenticated</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/Class/Instance">Instance</a>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="NewFilter">NewFilter</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="CloseConnection">CloseConnection</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> goodbye = <i></i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Handle">Handle</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#intptr">IntPtr</a> packetData, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> packetLength</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
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
