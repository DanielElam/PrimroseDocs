---
title: API:Class/ReflectionProbe
linkTitle: "ReflectionProbe"
weight: 4
date: 2019-08-02
explorerImage: probe
namespace: Primrose.DataModel.Lights.ReflectionProbe
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ReflectionProbe"><img src="/icons/silk/probe.png"/>&nbsp;ReflectionProbe</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Light"><img src="/icons/silk/lightbulb.png"/>&nbsp;Light</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A reflection probe captures the scene around it as a cubemap, which can then by sampled by reflective objects within.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Texture">Texture</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Cubemap">Cubemap</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CullingMask">CullingMask</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Allows certain objects to be culled during capture.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="EnableHDR">EnableHDR</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the probe captures an HDR reflection map.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Importance">Importance</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Used to break ties when an object is within the range of multiple probes.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Intensity">Intensity</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The intensity multiplier of the reflection.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsPreviewVisible">IsPreviewVisible</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Resolution">Resolution</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The resolution of the captured cubemap.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/Shape">Shape</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Shape">Shape</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The shape of the probe. Can be either a cube or sphere.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Capture">Capture</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Asynchronously captures faces of the cubemap.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Captured">Captured</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
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
