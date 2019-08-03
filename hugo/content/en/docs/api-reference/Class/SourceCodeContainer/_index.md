---
title: API:Class/SourceCodeContainer
linkTitle: "SourceCodeContainer"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Scripting.SourceCodeContainer
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/SourceCodeContainer"><img src="/icons/silk/default.png"/>&nbsp;SourceCodeContainer</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for an object containing script source code.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="EditorVersion">EditorVersion</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="HasErrors">HasErrors</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the script compilation had errors.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsCompiled">IsCompiled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the script has been compiled.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLinked">IsLinked</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true, this script's source code is downloaded from LinkedSource and cannot be modified.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsRunning">IsRunning</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets whether or not the script is currently running code.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/ScriptingLanguage">ScriptingLanguage</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Language">Language</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The scripting language to use.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Text">Text</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LinkedSource">LinkedSource</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
When set, will download and overwrite source code.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Logger">Logger</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Logger">Logger</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ScriptId">ScriptId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Source">Source</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The source code.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="SourceHash">SourceHash</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Coroutine">Coroutine</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Thread">Thread</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetLineNumberFromIndex">GetLineNumberFromIndex</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> charIndex</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/System/string">string</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetSourceLines">GetSourceLines</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Downloaded">Downloaded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> contentId</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the source code is downloaded from <a href="/docs/api-reference/Class/SourceCodeContainer/LinkedSource" >LinkedSource</a>.
</p></td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/ModuleScript"><img src="/icons/silk/script_module.png"/>&nbsp;ModuleScript</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Script"><img src="/icons/silk/script.png"/>&nbsp;Script</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/LocalScript"><img src="/icons/silk/script_local.png"/>&nbsp;LocalScript</a>
<ul class="nested">
</ul>
</ul>
</ul>
</div>
