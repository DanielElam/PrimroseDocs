---
title: API:Class/Sound
linkTitle: "Sound"
weight: 4
date: 2019-08-02
explorerImage: sound
namespace: Primrose.DataModel.Audio.Sound
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Sound"><img src="/icons/silk/sound.png"/>&nbsp;Sound</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

An instance which represents a single sound.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/AttenuationType">AttenuationType</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Attenuation">Attenuation</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The attenuation mode.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLoaded">IsLoaded</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets whether or not the sound has loaded.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLooped">IsLooped</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true the audio will loop.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsPaused">IsPaused</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets whether or not the sound is paused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsPlaying">IsPlaying</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets whether or not the sound is playing.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Loudness">Loudness</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The loudness of the sound in decibels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaxDistance">MaxDistance</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The maximum distance that the sound can be heard from.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MinDistance">MinDistance</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The distance at which the sound will begin to attenuate.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Time">Time</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaybackLength">PlaybackLength</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Time">Time</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaybackPosition">PlaybackPosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The playback position of the audio in seconds.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaybackSpeed">PlaybackSpeed</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The speed at which the sound is played.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Audio">Audio</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="SoundId">SoundId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The source of the media file.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#double">double</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Timeline">Timeline</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Volume">Volume</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The volume multiplier of the sound.
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
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPerceivedLoudness">GetPerceivedLoudness</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Camera">Camera</a> camera</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns how loud the sound is perceived to be by the listener in decibels.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Pause">Pause</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Pauses the sound.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Play">Play</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Plays the sound.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Resume">Resume</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Resumes the sound.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Stop">Stop</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Stops the sound.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Ended">Ended</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound ends.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Loaded">Loaded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound has loaded.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Looped">Looped</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired every time the sound loops.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Paused">Paused</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound is paused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Played">Played</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound is played.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Resumed">Resumed</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound is played after being paused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Stopped">Stopped</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the sound is stopped.
</p></td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
