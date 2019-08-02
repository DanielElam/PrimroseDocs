---
title: API:Class/DataModelMesh
linkTitle: "DataModelMesh"
weight: 4
date: 2019-08-02
explorerImage: mesh
namespace: Primrose.DataModel.Meshes.DataModelMesh
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/DataModelMesh"><img src="/icons/silk/mesh.png"/>&nbsp;DataModelMesh</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A base class for meshes.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/CollisionFidelity">CollisionFidelity</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CollisionFidelity">CollisionFidelity</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines the quality of the collision mesh for this operation.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsMeshLoaded">IsMeshLoaded</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/MaterialCollection">MaterialCollection</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Materials">Materials</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The materials to use for this mesh.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Offset">Offset</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The offset of the mesh from its origin.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/MeshRenderContainer">MeshRenderContainer</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RenderContainer">RenderContainer</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Scale">Scale</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The scale of the mesh.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="StencilMask">StencilMask</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="UsePartSize">UsePartSize</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the mesh uses the parent's <a href="/docs/api-reference/Class/Part/Size" >Size</a> property.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="UpdateScale">UpdateScale</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
<a class="" href="/docs/api-reference/Class/FileMesh"><img src="/icons/silk/mesh.png"/>&nbsp;FileMesh</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/SkeletalMesh"><img src="/icons/silk/skeletmesh.png"/>&nbsp;SkeletalMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SpecialMesh"><img src="/icons/silk/mesh.png"/>&nbsp;SpecialMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/StaticMesh"><img src="/icons/silk/mesh.png"/>&nbsp;StaticMesh</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/PlaneMesh"><img src="/icons/silk/mesh.png"/>&nbsp;PlaneMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PrimitiveMesh"><img src="/icons/silk/mesh.png"/>&nbsp;PrimitiveMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SplineMesh"><img src="/icons/silk/splinemesh.png"/>&nbsp;SplineMesh</a>
<ul class="nested">
</ul>
</ul>
</div>
