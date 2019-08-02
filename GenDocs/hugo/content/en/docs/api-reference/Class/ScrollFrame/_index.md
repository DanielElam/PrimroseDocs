---
title: API:Class/ScrollFrame
linkTitle: "ScrollFrame"
weight: 4
date: 2019-08-02
explorerImage: frame
namespace: Primrose.DataModel.GUI.ScrollFrame
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ScrollFrame"><img src="/icons/silk/frame.png"/>&nbsp;ScrollFrame</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Frame"><img src="/icons/silk/frame.png"/>&nbsp;Frame</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A frame with a scrollbar.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsoluteWindowSize">AbsoluteWindowSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BottomImage">BottomImage</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The texture for the bottom of the scrollbar.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CanvasPosition">CanvasPosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The scroll offset of the canvas.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/UDim2">UDim2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CanvasSize">CanvasSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the scrollable area.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MiddleImage">MiddleImage</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The image for the middle of the scrollbar.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ScrollBarThickness">ScrollBarThickness</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The thickness of the scrollbars.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/ScrollBarVisibility">ScrollBarVisibility</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ScrollBarVisibilityX">ScrollBarVisibilityX</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The visiblity of the horizontal scrollbar.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/ScrollBarVisibility">ScrollBarVisibility</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ScrollBarVisibilityY">ScrollBarVisibilityY</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The visiblity of the vertical scrollbar.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TopImage">TopImage</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The image for the top of the scrollbar.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ScrollBy">ScrollBy</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Scrolls the canvas by the given coordinates.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ScrollTo">ScrollTo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Scrolls the canvas to the given coordinates.
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
