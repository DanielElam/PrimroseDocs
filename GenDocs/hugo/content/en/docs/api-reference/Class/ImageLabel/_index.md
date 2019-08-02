---
title: API:Class/ImageLabel
linkTitle: "ImageLabel"
weight: 4
date: 2019-08-02
explorerImage: picture
namespace: Primrose.DataModel.GUI.ImageLabel
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ImageLabel"><img src="/icons/silk/picture.png"/>&nbsp;ImageLabel</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A GUI element which can draw an image.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AtlasRectOffset">AtlasRectOffset</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the image offset in pixels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AtlasRectSize">AtlasRectSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the size of the image rectangle in pixels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ImageColour">ImageColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Influences the colour of the image.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ImageId">ImageId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The image file.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ImageTransparency">ImageTransparency</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The transparency of the image.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaskId">MaskId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaskValue">MaskValue</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/MovieImage">MovieImage</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MovieId">MovieId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The image extend mode to use when the size of the image is bigger than the source image.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaybackSpeed">PlaybackSpeed</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Controls the playback speed of animated image assets.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/ScalingMode">ScalingMode</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ScalingMode">ScalingMode</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The bitmap scaling mode to use.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/VectorImage">VectorImage</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="VectorImageId">VectorImageId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The vector graphics image file.
</p></td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
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
