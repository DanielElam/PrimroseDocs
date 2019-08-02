---
title: API:Asset/Animation
linkTitle: "Animation"
weight: 4
date: 2019-08-02
explorerImage: film
namespace: Primrose.Assets.Animation
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Animation"><img src="/icons/silk/film.png"/>&nbsp;Animation</span></small>
<p class="summary">

Asset which holds animation data.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Animation</b><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AdditiveBasePose">AdditiveBasePose</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AdditiveBasePoseFrameIndex">AdditiveBasePoseFrameIndex</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AdditiveBasePoseType">AdditiveBasePoseType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AdditiveBasePoseType">AdditiveBasePoseType</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AdditiveAnimationType">AdditiveAnimationType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AdditiveType">AdditiveType</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="EnableRootMotion">EnableRootMotion</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Framerate">Framerate</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLooped">IsLooped</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Keyframe">Keyframe</a>[]</span><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Keyframes">Keyframes</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Time">Time</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Length">Length</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RateScale">RateScale</a></span></td>
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
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ExtractRootMotion">ExtractRootMotion</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> startTime, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> deltaTime, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> allowLooping</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetAnimNotifies">GetAnimNotifies</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> prevSampleDataTime, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> deltaTimePosition, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> instanceIsLooped, <a class="type" href="/docs/api-reference/System/List">List</a><<a class="type" href="/docs/api-reference/Misc/AnimNotifyEvent">AnimNotifyEvent</a>> notifies</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/List">List</a><<a class="type" href="/docs/api-reference/System/string">string</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetUniqueMarkerNames">GetUniqueMarkerNames</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsValidAdditive">IsValidAdditive</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
