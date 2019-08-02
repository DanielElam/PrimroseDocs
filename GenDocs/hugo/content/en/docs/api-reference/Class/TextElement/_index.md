---
title: API:Class/TextElement
linkTitle: "TextElement"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.GUI.TextElement
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/TextElement"><img src="/icons/silk/default.png"/>&nbsp;TextElement</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for text elements.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Font">Font</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Font">Font</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The font to use.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="FontSize">FontSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the text in pixels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/FontStretch">FontStretch</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="FontStretch">FontStretch</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The weight of the text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/FontWeight">FontWeight</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="FontWeight">FontWeight</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Italicize">Italicize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Italicize the text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Localize">Localize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if this label will localize text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalizedString">LocalizedString</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Text">Text</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The text to draw.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AlignmentX">AlignmentX</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextAlignmentX">TextAlignmentX</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The horizontal alignment of the text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AlignmentY">AlignmentY</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextAlignmentY">TextAlignmentY</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The vertical alignment of the text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec2">Vec2</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextBounds">TextBounds</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the space the text takes up.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextColour">TextColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The colour of the text.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec4">Vec4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextPadding">TextPadding</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextScaled">TextScaled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the font size is based on the size of the element.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextStrokeColour">TextStrokeColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The colour of the text stroke.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/TextTrimming">TextTrimming</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TextTrimming">TextTrimming</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/WordWrapping">WordWrapping</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="WordWrapping">WordWrapping</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines the method of word wrapping to use.
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
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="TextChanged">TextChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/TextBox"><img src="/icons/silk/textbox.png"/>&nbsp;TextBox</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TextLabel"><img src="/icons/silk/style.png"/>&nbsp;TextLabel</a>
<ul class="nested">
</ul>
</ul>
</div>
