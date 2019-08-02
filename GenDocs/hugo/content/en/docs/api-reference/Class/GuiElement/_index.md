---
title: API:Class/GuiElement
linkTitle: "GuiElement"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.GUI.GuiElement
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for all 2D GUI elements.

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
Gets the absolute size of the element, with scale taken into account.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AbsoluteSize">AbsoluteSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the absolute size of the element, with scale taken into account.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AlignmentX">AlignmentX</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AlignmentX">AlignmentX</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The horizontal alignment of the element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AlignmentY">AlignmentY</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AlignmentY">AlignmentY</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The vertical alignment of the element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AnchorPoint">AnchorPoint</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BackgroundColour">BackgroundColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The colour of the background.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BackgroundTransparency">BackgroundTransparency</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BorderColour">BorderColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The colour of the border.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BorderThickness">BorderThickness</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The thickness of the border.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ClipDescendants">ClipDescendants</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if overflowing descendants are clipped.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CornerRadius">CornerRadius</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The radius of each corner.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Focusable">Focusable</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if this element can be focused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Focused">Focused</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="HasComponents">HasComponents</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="InverseClip">InverseClip</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsHitTestVisible">IsHitTestVisible</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether this element is ignored by hit tests.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsMouseDirectlyOver">IsMouseDirectlyOver</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the mouse is currently hovering over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsMouseOver">IsMouseOver</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the mouse is currently hovering over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LayoutOrder">LayoutOrder</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The layout order for the parent frame.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PixelSnapping">PixelSnapping</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/UDim2">UDim2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Position">Position</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The Position of the element relative to its parent.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Rotation">Rotation</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The clockwise rotation of the gui in degrees.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/UDim2">UDim2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Visible">Visible</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if this element can be rendered.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ZIndex">ZIndex</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The layer that this element is drawn at.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Focus">Focus</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Rect">Rect</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRenderRect">GetRenderRect</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="GotFocus">GotFocus</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when this element gains focus.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="LostFocus">LostFocus</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> enterPressed</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when this element loses focus.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Measured">Measured</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the element is resized or repositioned.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton1Click">MouseButton1Click</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the mouse has fully left clicked the button.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton1Down">MouseButton1Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the left mouse button has been pressed over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton1Up">MouseButton1Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the left mouse button has been released over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton2Click">MouseButton2Click</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the mouse has fully right clicked the button.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton2Down">MouseButton2Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the right mouse button has been pressed over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton2Up">MouseButton2Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the right mouse button has been released over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton3Click">MouseButton3Click</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the middle has fully right clicked the button.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton3Down">MouseButton3Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the middle mouse button has been pressed over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseButton3Up">MouseButton3Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the middle mouse button has been released over this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseEnter">MouseEnter</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse enters this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseLeave">MouseLeave</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse leaves this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseMove">MouseMove</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse moves inside this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="MouseWheel">MouseWheel</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> wheel</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse scrolls inside this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton1Down">PreviewMouseButton1Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton1Up">PreviewMouseButton1Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton2Down">PreviewMouseButton2Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton2Up">PreviewMouseButton2Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton3Down">PreviewMouseButton3Down</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseButton3Up">PreviewMouseButton3Up</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseEnter">PreviewMouseEnter</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse enters this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseLeave">PreviewMouseLeave</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse leaves this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseMove">PreviewMouseMove</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse moves inside this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PreviewMouseWheel">PreviewMouseWheel</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> x, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> y, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> wheel</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the mouse scrolls inside this element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="VisibilityChanged">VisibilityChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
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
</div>
