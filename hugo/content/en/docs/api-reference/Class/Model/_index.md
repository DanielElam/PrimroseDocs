---
title: API:Class/Model
linkTitle: "Model"
weight: 4
date: 2019-08-02
explorerImage: bricks
namespace: Primrose.DataModel.Model
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A container object for organizing 3D objects.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CFrame">CFrame</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The transform of the model.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ModelInPrimary">ModelInPrimary</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
A rotation matrix for the model's OBB.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Part">Part</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PrimaryPart">PrimaryPart</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The child part which represents the 'primary' part of this model.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the model.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Velocity">Velocity</a></span></td>
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
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetModelCFrame">GetModelCFrame</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the CFrame of the Bounding Box.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetModelSize">GetModelSize</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the size of the Bounding Box.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="MoveTo">MoveTo</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> position</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Moves the centroid of the <a href="/docs/api-reference/Class/Model/" >Model</a> to the specified location, respecting all relative distances between
parts in the model.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetPrimaryPartCFrame">SetPrimaryPartCFrame</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a> cframe</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the CFrame of the <a href="/docs/api-reference/Class/Model/PrimaryPart" >PrimaryPart</a>, respecting all relative distances between parts.
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
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/Spline"><img src="/icons/silk/curve.png"/>&nbsp;Spline</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshLink"><img src="/icons/silk/arrow_ew.png"/>&nbsp;NavMeshLink</a>
<ul class="nested">
</ul>
</ul>
</div>
