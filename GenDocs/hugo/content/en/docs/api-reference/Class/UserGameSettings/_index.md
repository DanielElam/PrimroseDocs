---
title: API:Class/UserGameSettings
linkTitle: "UserGameSettings"
weight: 4
date: 2019-08-02
explorerImage: cog
namespace: Primrose.Settings.UserGameSettings
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/UserGameSettings"><img src="/icons/silk/cog.png"/>&nbsp;UserGameSettings</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/SettingsBase"><img src="/icons/silk/cog.png"/>&nbsp;SettingsBase</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Game settings.

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
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetCustomSetting">GetCustomSetting</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the value of a custom setting.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/IReadOnlyDictionary">IReadOnlyDictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/string">string</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetCustomSettings">GetCustomSettings</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a table of custom settings.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InBorderless">InBorderless</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the game is in borderless window mode.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InFullScreen">InFullScreen</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the game is in fullscreen.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetCustomSetting">SetCustomSetting</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key, <a class="type" href="/docs/api-reference/System/string">string</a> value</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the value of a custom setting.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="BorderlessChanged">BorderlessChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the game enters or comes out of borderless window mode.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="CustomSettingChanged">CustomSettingChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0, <a class="type" href="/docs/api-reference/System/string">string</a> p1</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a custom setting is changed.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="FullscreenChanged">FullscreenChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the game enters or comes out of fullscreen.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="FullscreenDisplayModeChanged">FullscreenDisplayModeChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/DisplayMode">DisplayMode</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
