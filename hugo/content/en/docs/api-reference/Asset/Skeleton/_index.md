---
title: API:Asset/Skeleton
linkTitle: "Skeleton"
weight: 4
date: 2019-08-02
explorerImage: skeleton
namespace: Primrose.Assets.Skeleton
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Skeleton"><img src="/icons/silk/skeleton.png"/>&nbsp;Skeleton</span></small>
<p class="summary">

A skeleton.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BoneCount">BoneCount</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/Pose">Pose</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ImportPose">ImportPose</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The pose that the skeleton was originally imported with.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsSkeletonLoaded">IsSkeletonLoaded</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/Pose">Pose</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Pose">Pose</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The pose that the skeleton was last saved with.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ReferenceInstance">ReferenceInstance</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The root bone of this skeleton.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Rig">Rig</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Rig">Rig</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The rig that his skeleton is targeted to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/Class/Bone">Bone</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RigMapping">RigMapping</a></span></td>
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
<a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="CreateInstance">CreateInstance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SavePose">SavePose</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a> instance</span> )</span></span></div></td>
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
