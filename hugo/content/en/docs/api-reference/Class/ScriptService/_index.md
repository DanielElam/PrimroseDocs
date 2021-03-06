---
title: API:Class/ScriptService
linkTitle: "ScriptService"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Scripting.ScriptService
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ScriptService"><img src="/icons/silk/default.png"/>&nbsp;ScriptService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">
<a href="/docs/api-reference/Class/ScriptService/" >ScriptService</a> handles the execution of scripts at runtime.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#double">double</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Timeout">Timeout</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The maximum time in seconds a script can run for without yielding.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Export">Export</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/object">object</a> result</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetModuleResult">GetModuleResult</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> namespace</span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ScriptErrored">ScriptErrored</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0, <a class="type" href="/docs/api-reference/System/string">string</a> p1, <a class="type" href="/docs/api-reference/Class/Script">Script</a> p2</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when a script errors.
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
