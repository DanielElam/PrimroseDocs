---
title: API:Asset/BlendSpaceBase
linkTitle: "BlendSpaceBase"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.Assets.BlendSpace.BlendSpaceBase
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/BlendSpaceBase"><img src="/icons/silk/default.png"/>&nbsp;BlendSpaceBase</span></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AnimLength">AnimLength</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/NotifyTriggerMode">NotifyTriggerMode</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="NotifyTriggerMode">NotifyTriggerMode</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/List">List</a><<a class="type" href="/docs/api-reference/Misc/PerBoneInterpolation">PerBoneInterpolation</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PerBoneBlend">PerBoneBlend</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/Animation">Animation</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PreviewBasePose">PreviewBasePose</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RotationBlendInMeshSpace">RotationBlendInMeshSpace</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/List">List</a><<a class="type" href="/docs/api-reference/Misc/BlendSample">BlendSample</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="SampleData">SampleData</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TargetWeightInterpolationSpeedPerSec">TargetWeightInterpolationSpeedPerSec</a></span></td>
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
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="AddSample">AddSample</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Asset/Animation">Animation</a> animation, <a class="type" href="/docs/api-reference/DataType/Vec4">Vec4</a> sampleValue</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/BlendParameter">BlendParameter</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetBlendParameter">GetBlendParameter</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> index</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetBlendSamplesCount">GetBlendSamplesCount</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InitializeSamples">InitializeSamples</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Step">Step</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Animator">Animator</a> context, <a class="type" href="/docs/api-reference/Class/AnimationTrack">AnimationTrack</a> instance, <a class="type" href="/docs/api-reference/Misc/AnimNotifyQueue">AnimNotifyQueue</a> notifyQueue, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> deltaTime</span> )</span></span></div></td>
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
