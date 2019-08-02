---
title: API:Class/Selection
linkTitle: "Selection"
weight: 4
date: 2019-08-02
explorerImage: surface
namespace: Primrose.DataModel.Selection
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Selection"><img src="/icons/silk/surface.png"/>&nbsp;Selection</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for managing selection in level editors.

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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Clear">Clear</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Deselects all items.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Contains">Contains</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Instance">Instance</a> instance</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/LuaTable">LuaTable</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Get">Get</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Set">Set</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/LuaTable">LuaTable</a> instances</span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Deselected">Deselected</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Instance">Instance</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when an Instance is deselected.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Selected">Selected</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Instance">Instance</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when an Instance is selected.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="SelectionChanged">SelectionChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the selection is changed.
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
