---
title: API:Asset/FontAtlas
linkTitle: "FontAtlas"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.Assets.FontAtlas
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/FontAtlas"><img src="/icons/silk/default.png"/>&nbsp;FontAtlas</span></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Texture">Texture</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AtlasTexture">AtlasTexture</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The atlas texture.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/FontAssetType">FontAssetType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AtlasType">AtlasType</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The type of atlas used.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/Primitives#char">char</a>, <a class="type" href="/docs/api-reference/Misc/BmpFontGlyph">BmpFontGlyph</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BitmapData">BitmapData</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Font">Font</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Font">Font</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The font asset that was used to generate this atlas.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="FontSizePt">FontSizePt</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the font in pixels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/RenderFormat">RenderFormat</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Format">Format</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The format of the texture atlas.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Height">Height</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The height of the atlas texture.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/Material">Material</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Material">Material</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Width">Width</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The width of the atlas texture.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetData">SetData</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> atlasWidth, <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> atlasHeight, <span><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a>[]</span> imgBuffer</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="TryGetGlyphLocation">TryGetGlyphLocation</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint16">uint16</a> glyphIndex, <a class="type" href="/docs/api-reference/Misc/GlyphData&">GlyphData&</a> glyphData</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
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
