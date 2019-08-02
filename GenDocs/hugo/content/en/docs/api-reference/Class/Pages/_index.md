---
title: API:Class/Pages
linkTitle: "Pages"
weight: 4
date: 2019-08-02
explorerImage: page_white
namespace: Primrose.DataModel.Pages.Pages
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Pages"><img src="/icons/silk/page_white.png"/>&nbsp;Pages</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A table of pages, where a page is a sorted list of key/value pairs.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsFinished">IsFinished</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if there are any more pages.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="AdvanceToNextPage">AdvanceToNextPage</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Requests the next page.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/IReadOnlyDictionary">IReadOnlyDictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetCurrentPage">GetCurrentPage</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the current page.
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
<a class="" href="/docs/api-reference/Class/FriendPages"><img src="/icons/silk/page_white.png"/>&nbsp;FriendPages</a>
<ul class="nested">
</ul>
</ul>
</div>
