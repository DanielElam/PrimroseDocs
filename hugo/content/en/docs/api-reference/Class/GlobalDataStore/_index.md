---
title: API:Class/GlobalDataStore
linkTitle: "GlobalDataStore"
weight: 4
date: 2019-08-02
explorerImage: database_world
namespace: Primrose.DataModel.DataStores.GlobalDataStore
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/GlobalDataStore"><img src="/icons/silk/database_world.png"/>&nbsp;GlobalDataStore</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A GlobalDataStore allows manipulation of a data base.

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
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetAsync">GetAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IncrementAsync">IncrementAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key, <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> delta = <i>1</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetAsync">SetAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key, <a class="type" href="/docs/api-reference/System/object">object</a> value</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="UpdateAsync">UpdateAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key, <a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/System/object">object</a>, <a class="type" href="/docs/api-reference/System/object">object</a>> transformer</span> )</span></span></div></td>
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
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/OrderedDataStore"><img src="/icons/silk/database_go.png"/>&nbsp;OrderedDataStore</a>
<ul class="nested">
</ul>
</ul>
</div>
