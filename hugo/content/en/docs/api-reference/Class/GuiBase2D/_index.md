---
title: API:Class/GuiBase2D
linkTitle: "GuiBase2D"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.GUI.GuiBase2D
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

The base class of all gui screens and elements.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsolutePosition">AbsolutePosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the absolute Position of the gui object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsoluteSize">AbsoluteSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the absolute size of the gui object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DesiredPosition">DesiredPosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the desired position of the gui object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DesiredSize">DesiredSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the desired size of the gui object.
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
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="BoundsCheck">BoundsCheck</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a> pos</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if the given point is within the bounds of this element,
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
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/GuiContainer"><img src="/icons/silk/default.png"/>&nbsp;GuiContainer</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BillboardGui"><img src="/icons/silk/billboard.png"/>&nbsp;BillboardGui</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScreenGui"><img src="/icons/silk/application.png"/>&nbsp;ScreenGui</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/DebugGui"><img src="/icons/silk/application.png"/>&nbsp;DebugGui</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/SurfaceGui"><img src="/icons/silk/billboard.png"/>&nbsp;SurfaceGui</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Button"><img src="/icons/silk/button.png"/>&nbsp;Button</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Frame"><img src="/icons/silk/frame.png"/>&nbsp;Frame</a>
<ul class="nested">
<a class="deprecated" href="/docs/api-reference/Class/Flex"><img src="/icons/silk/frame.png"/>&nbsp;Flex</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScrollFrame"><img src="/icons/silk/frame.png"/>&nbsp;ScrollFrame</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/VideoElement"><img src="/icons/silk/frame.png"/>&nbsp;VideoElement</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/ImageLabel"><img src="/icons/silk/picture.png"/>&nbsp;ImageLabel</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SinglePixelLine"><img src="/icons/silk/frame.png"/>&nbsp;SinglePixelLine</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TextElement"><img src="/icons/silk/default.png"/>&nbsp;TextElement</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/TextBox"><img src="/icons/silk/textbox.png"/>&nbsp;TextBox</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TextLabel"><img src="/icons/silk/style.png"/>&nbsp;TextLabel</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/ViewportFrame"><img src="/icons/silk/frame.png"/>&nbsp;ViewportFrame</a>
<ul class="nested">
</ul>
</ul>
</ul>
</div>
