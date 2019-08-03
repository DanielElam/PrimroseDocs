---
title: API:Class/Intent
linkTitle: "Intent"
weight: 4
date: 2019-08-02
explorerImage: remote_event
namespace: Primrose.DataModel.Networking.Intent
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Intent"><img src="/icons/silk/remote_event.png"/>&nbsp;Intent</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A local/remote event.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="OnHold">OnHold</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Intercepts incoming requests and will block them if the callback returns false.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Func">Func</a><<span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="OnIntercept">OnIntercept</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Intercepts outgoing requests and will block them if the callback returns false.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Fire">Fire</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes both local and remote callbacks.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Connection">Connection</a><<a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Subscribe">Subscribe</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Action">Action</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>> callback</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Connection">Connection</a><<a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SubscribeLocal">SubscribeLocal</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Action">Action</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>> callback</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Connection">Connection</a><<a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SubscribeRemote">SubscribeRemote</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Action">Action</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>> callback</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="TellClient">TellClient</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> client, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes remote callbacks only.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="TellServer">TellServer</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes remote callbacks only.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Whisper">Whisper</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span> args</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invokes local callbacks only.
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
