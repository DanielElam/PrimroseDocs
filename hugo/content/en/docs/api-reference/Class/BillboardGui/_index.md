---
title: API:Class/BillboardGui
linkTitle: "BillboardGui"
weight: 4
date: 2019-08-02
explorerImage: billboard
namespace: Primrose.DataModel.GUI.BillboardGui
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/BillboardGui"><img src="/icons/silk/billboard.png"/>&nbsp;BillboardGui</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiContainer"><img src="/icons/silk/default.png"/>&nbsp;GuiContainer</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A gui which renders to a billboard - a plane that always faces the camera.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsolutePosition">AbsolutePosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsoluteSize">AbsoluteSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Adornee">Adornee</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The object this billboard is adorned to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AlwaysOnTop">AlwaysOnTop</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the billboard is rendered ontop of other objects.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaxDistance">MaxDistance</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Offset">Offset</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The offset from the adornee Position.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/IRenderCollection">IRenderCollection</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RenderCollection">RenderCollection</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RenderCollectionIndex">RenderCollectionIndex</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/UDim2">UDim2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the billboard.
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
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="DistanceCheck">DistanceCheck</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> cameraPos</span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="SizeChanged">SizeChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>Fires when the size changes.</p></td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
