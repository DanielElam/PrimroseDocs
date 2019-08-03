---
title: API:Class/PVInstance
linkTitle: "PVInstance"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.PVInstance
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A physical instance is an entity which occupies space in the 3D world.

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
The transform of the object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Signal">Signal</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Moved">Moved</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Quat">Quat</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Orientation">Orientation</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets or sets the rotation of the object as a quaternion.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Position">Position</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The position of <a href="/docs/api-reference/Class/PVInstance/CFrame" >CFrame</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Rotation">Rotation</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The rotation of <a href="/docs/api-reference/Class/PVInstance/CFrame" >CFrame</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the object.
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
<a class="" href="/docs/api-reference/Class/Area"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;Area</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/PhysicsArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;PhysicsArea</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshBoundsArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;NavMeshBoundsArea</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Decal"><img src="/icons/silk/photo.png"/>&nbsp;Decal</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Spline"><img src="/icons/silk/curve.png"/>&nbsp;Spline</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshLink"><img src="/icons/silk/arrow_ew.png"/>&nbsp;NavMeshLink</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Part"><img src="/icons/silk/brick.png"/>&nbsp;Part</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Character"><img src="/icons/silk/humanoid.png"/>&nbsp;Character</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Seat"><img src="/icons/silk/seat.png"/>&nbsp;Seat</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vehicle"><img src="/icons/silk/car.png"/>&nbsp;Vehicle</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PartOperation"><img src="/icons/silk/brick.png"/>&nbsp;PartOperation</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/IntersectOperation"><img src="/icons/silk/brick.png"/>&nbsp;IntersectOperation</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NegateOperation"><img src="/icons/silk/negate.png"/>&nbsp;NegateOperation</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UnionOperation"><img src="/icons/silk/union.png"/>&nbsp;UnionOperation</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Terrain"><img src="/icons/silk/terrain.png"/>&nbsp;Terrain</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/TriggerArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;TriggerArea</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/SoundTriggerArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;SoundTriggerArea</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Wheel"><img src="/icons/silk/bullet_black.png"/>&nbsp;Wheel</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ParticleSpawner"><img src="/icons/silk/emitter.png"/>&nbsp;ParticleSpawner</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Fire"><img src="/icons/silk/fire.png"/>&nbsp;Fire</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshLinkMarker"><img src="/icons/silk/arrow_ew.png"/>&nbsp;NavMeshLinkMarker</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Socket"><img src="/icons/silk/default.png"/>&nbsp;Socket</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Light"><img src="/icons/silk/lightbulb.png"/>&nbsp;Light</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/DiskLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;DiskLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RectangleLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;RectangleLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SphereLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;SphereLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TubeLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;TubeLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DirectionalLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;DirectionalLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PointLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;PointLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SpotLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;SpotLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReflectionProbe"><img src="/icons/silk/probe.png"/>&nbsp;ReflectionProbe</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/LightProbe"><img src="/icons/silk/contrast.png"/>&nbsp;LightProbe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/WaterBase"><img src="/icons/silk/waves2.png"/>&nbsp;WaterBase</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Ocean"><img src="/icons/silk/waves2.png"/>&nbsp;Ocean</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/FogVolume"><img src="/icons/silk/default.png"/>&nbsp;FogVolume</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Bone"><img src="/icons/silk/bone.png"/>&nbsp;Bone</a>
<ul class="nested">
</ul>
</ul>
</div>
