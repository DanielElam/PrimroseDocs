---
title: API:Class/SkeletalMesh
linkTitle: "SkeletalMesh"
weight: 4
date: 2019-08-02
explorerImage: skeletmesh
namespace: Primrose.DataModel.Meshes.SkeletalMesh
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/SkeletalMesh"><img src="/icons/silk/skeletmesh.png"/>&nbsp;SkeletalMesh</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/FileMesh"><img src="/icons/silk/mesh.png"/>&nbsp;FileMesh</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/DataModelMesh"><img src="/icons/silk/mesh.png"/>&nbsp;DataModelMesh</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A mesh which can be animated with a skeleton.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DrawDebugBones">DrawDebugBones</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
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
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Skeleton">Skeleton</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="SkeletonId">SkeletonId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The content ID of the mesh data.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="SkeletonInstance">SkeletonInstance</a></span></td>
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ScaleToBounds">ScaleToBounds</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetSkeletonInstance">SetSkeletonInstance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a> instance</span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="SkeletonLoaded">SkeletonLoaded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> skeletonId</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when <a href="/docs/api-reference/Class/SkeletalMesh/SkeletonInstance" >SkeletonInstance</a> has loaded.
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
