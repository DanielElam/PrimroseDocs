---
title: API:Class/GraphicsCard
linkTitle: "GraphicsCard"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.Settings.GraphicsCard
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/GraphicsCard"><img src="/icons/silk/default.png"/>&nbsp;GraphicsCard</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A graphics device.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/GpuBusType">GpuBusType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BusType">BusType</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DeviceId">DeviceId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MonitorCount">MonitorCount</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/GpuVendor">GpuVendor</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Vendor">Vendor</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int64">long</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="VideoMemory">VideoMemory</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The amount of video memory on the card in bytes.
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
<a class="type" href="/docs/api-reference/Class/Monitor">Monitor</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetMonitor">GetMonitor</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> outputIndex</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Monitor">Monitor</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetMonitors">GetMonitors</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns an array of monitors that the graphics device is connected to.
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
