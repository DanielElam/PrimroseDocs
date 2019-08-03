---
title: API:Class/SoundService
linkTitle: "SoundService"
weight: 4
date: 2019-08-02
explorerImage: soundscape
namespace: Primrose.DataModel.SoundService
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/SoundService"><img src="/icons/silk/soundscape.png"/>&nbsp;SoundService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

SoundService manages global sound properties.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/ReverbType">ReverbType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AmbientReverb">AmbientReverb</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The global environment reverb type.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DistanceFactor">DistanceFactor</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Modifies the distance for every sound.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DopplerScale">DopplerScale</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Scales the doppler effect.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaxAudibleSoundCount">MaxAudibleSoundCount</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RolloffScale">RolloffScale</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines how fast sounds will drop off.
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
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlaybackDevices">GetPlaybackDevices</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of active playback devices.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRecordingDevices">GetRecordingDevices</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of active recording devices.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetEffectsChain">SetEffectsChain</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/List">List</a><<a class="type" href="/docs/api-reference/Class/SoundEffect">SoundEffect</a>> activeEffects</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetPlaybackDevice">SetPlaybackDevice</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> deviceIndex</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the device to output sound to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetRecordingDevice">SetRecordingDevice</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> deviceIndex</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the device to record sound with.
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
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
