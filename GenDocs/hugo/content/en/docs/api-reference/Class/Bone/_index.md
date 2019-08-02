---
title: API:Class/Bone
linkTitle: "Bone"
weight: 4
date: 2019-08-02
explorerImage: bone
namespace: Primrose.DataModel.Animation.Bone
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Bone"><img src="/icons/silk/bone.png"/>&nbsp;Bone</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Represents a bone node in a <a href="/docs/api-reference/Class/SkeletonInstance/" >SkeletonInstance</a>
</p>
### Notes
<p class="remarks">
world space: relative to the world (0, 0, 0)
local space: relative to the parent bone
instance space / component space: relative to the SkeletalMesh
</p> 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BindTransform">BindTransform</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The inverse absolute bind transform.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CFrame">CFrame</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The world space CFrame.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Index">Index</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="InstanceSpaceCFrame">InstanceSpaceCFrame</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="InstanceSpaceTransform">InstanceSpaceTransform</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The transform of the bone relative to the SkeletalMesh instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="InstanceSpaceTransform2">InstanceSpaceTransform2</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsRoot">IsRoot</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalBindTransform">LocalBindTransform</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalCFrame">LocalCFrame</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalPosition">LocalPosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalRotation">LocalRotation</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Mat4">Mat4</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalTransform">LocalTransform</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Scale">Scale</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/SkeletonInstance">SkeletonInstance</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Skeleton">Skeleton</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/BoneTranslationRetargetingMode">BoneTranslationRetargetingMode</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TranslationRetargeting">TranslationRetargeting</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
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
