---
title: API:Class/Animator
linkTitle: "Animator"
weight: 4
date: 2019-08-02
explorerImage: film
namespace: Primrose.DataModel.Animation.Animator
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Animator"><img src="/icons/silk/film.png"/>&nbsp;Animator</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CanUseMarkerSync">CanUseMarkerSync</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLeader">IsLeader</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/RootMotionMode">RootMotionMode</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RootMotionMode">RootMotionMode</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="UseTimeScale">UseTimeScale</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the animator is affected by <a href="/docs/api-reference/Class/RunService/TimeScale" >TimeScale</a>.
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
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetLeaderDelta">GetLeaderDelta</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/AnimationTrack">AnimationTrack</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlayingAnimationTracks">GetPlayingAnimationTracks</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsSingleAnimationContext">IsSingleAnimationContext</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/AnimationTrack">AnimationTrack</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LoadAnimation">LoadAnimation</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> animationId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Loads an animation into a track.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/BlendSpaceAnimationTrack">BlendSpaceAnimationTrack</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LoadBlendSpace">LoadBlendSpace</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Asset/BlendSpace">BlendSpace</a> blendSpace</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ShouldGenerateNotifies">ShouldGenerateNotifies</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
