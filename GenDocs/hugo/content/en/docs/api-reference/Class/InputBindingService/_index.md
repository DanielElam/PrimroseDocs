---
title: API:Class/InputBindingService
linkTitle: "InputBindingService"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Input.InputBindingService
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/InputBindingService"><img src="/icons/silk/default.png"/>&nbsp;InputBindingService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for managing key bindings.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Bind">Bind</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> id, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> primary = <i>None</i>, <a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> mouseButton = <i>None</i>, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> gamepad = <i>None</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Registers a new key binding.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ClearBindings">ClearBindings</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/InputBinding">InputBinding</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetBinding">GetBinding</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> id</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the <a href="T:Primrose.DataModel.Input.InputBinding" >T:Primrose.DataModel.Input.InputBinding</a> for the given ID.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsBound">IsBound</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> id</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the given ID has already been bound.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="RestoreDefaults">RestoreDefaults</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Restore default keybindings.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="TryBind">TryBind</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> id, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> primary = <i>None</i>, <a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> mouseButton = <i>None</i>, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> gamepad = <i>None</i></span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="BindingUpdated">BindingUpdated</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0, <a class="type" href="/docs/api-reference/System/string">string</a> p1</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
