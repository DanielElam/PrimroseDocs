---
title: API:Class/ContentProvider
linkTitle: "ContentProvider"
weight: 4
date: 2019-08-02
explorerImage: package
namespace: Primrose.DataModel.Content.ContentProvider
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ContentProvider"><img src="/icons/silk/package.png"/>&nbsp;ContentProvider</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A resource manager for asset types.

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
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetReferenceCount">GetReferenceCount</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> id</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Preload">Preload</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> contentId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Preloads content from the given url.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="PreloadAsync">PreloadAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/LuaTable">LuaTable</a> contentUrls</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Yields untill all the given content urls have been downloaded.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ReloadAsset">ReloadAsset</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Asset/Asset">Asset</a> asset</span> )</span></span></div></td>
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
