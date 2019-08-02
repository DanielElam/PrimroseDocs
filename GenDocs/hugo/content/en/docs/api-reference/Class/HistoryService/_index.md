---
title: API:Class/HistoryService
linkTitle: "HistoryService"
weight: 4
date: 2019-08-02
explorerImage: clock
namespace: Primrose.DataModel.HistoryService
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/HistoryService"><img src="/icons/silk/clock.png"/>&nbsp;HistoryService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for undo/redo.

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
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <a class="type" href="/docs/api-reference/System/string">string</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="CanRedo">CanRedo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if <a href="/docs/api-reference/Class/HistoryService/Redo" >Redo</a> can be successfully called.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <a class="type" href="/docs/api-reference/System/string">string</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="CanUndo">CanUndo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if <a href="/docs/api-reference/Class/HistoryService/Undo" >Undo</a> can be successfully called.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Redo">Redo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Executes the last undone action.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetEnabled">SetEnabled</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> enabled</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets whether or not the service is enabled.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetWaypoint">SetWaypoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> waypoint</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Saves a waypoint in history.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Undo">Undo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Undoes the last action.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Redone">Redone</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a waypoint is redone.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Undone">Undone</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a waypoint is undone.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WaypointSet">WaypointSet</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a waypoint is set.
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
