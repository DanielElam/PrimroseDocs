---
title: API:Class/SettingsContainer
linkTitle: "SettingsContainer"
weight: 4
date: 2019-08-02
explorerImage: folder_config
namespace: Primrose.Settings.SettingsContainer
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/SettingsContainer"><img src="/icons/silk/folder_config.png"/>&nbsp;SettingsContainer</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Base class for settings containers.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Logger">Logger</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Logger">Logger</a></span></td>
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Load">Load</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="RestoreDefaults">RestoreDefaults</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> save = <i>True</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Restores all settings to their default values.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Task">Task</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SaveAsync">SaveAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
<a class="" href="/docs/api-reference/Class/GlobalSettings"><img src="/icons/silk/folder_config.png"/>&nbsp;GlobalSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UserSettings"><img src="/icons/silk/folder_config.png"/>&nbsp;UserSettings</a>
<ul class="nested">
</ul>
</ul>
</div>
