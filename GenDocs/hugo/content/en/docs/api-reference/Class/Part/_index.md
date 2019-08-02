---
title: API:Class/Part
linkTitle: "Part"
weight: 4
date: 2019-08-02
explorerImage: brick
namespace: Primrose.DataModel.Part
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Part"><img src="/icons/silk/brick.png"/>&nbsp;Part</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

An instance which can usually be seen and/or touched.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Anchored">Anchored</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true, the part will be physically immovable and static.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Colour">Colour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BrickColour">BrickColour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The colour of the block.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CanCollide">CanCollide</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if this block can collide with other objects.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CFrame">CFrame</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The 3D position/rotation.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalTransparencyModifier">LocalTransparencyModifier</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Locked">Locked</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If false, this part should not be selectable by 3D pickers.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Material">Material</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Material">Material</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The material to render this part with.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/PhysicalProperties">PhysicalProperties</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PhysicalProperties">PhysicalProperties</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The properties of the physics engine.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/PhysicsUpdateMode">PhysicsUpdateMode</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PhysicsUpdateMode">PhysicsUpdateMode</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines the physics update mode.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="RotVelocity">RotVelocity</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The angular velocity of this object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/Shape">Shape</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Shape">Shape</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The shape of the part.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Simulate">Simulate</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if physics are simulated for this part.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Size">Size</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The size of the instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Static">Static</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether this part is static. Static objects should not be moved at runtime.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Transparency">Transparency</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The transparency of the part.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Velocity">Velocity</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The linear velocity of this object.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="BreakJoints">BreakJoints</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Breaks any joint or constraint this object is a part of.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><b class="page-type">Part</b>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetConnectedParts">GetConnectedParts</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> recursive = <i>False</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of parts that this part is connected to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Constraint">Constraint</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetConstraints">GetConstraints</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of constraints this object is an attachment of.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetMass">GetMass</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Calculates the mass of this part.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/Material">Material</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetMaterial">GetMaterial</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Player">Player</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetNetworkOwner">GetNetworkOwner</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the player that owns this part, or null if the server owns it.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetNetworkOwnerAuto">GetNetworkOwnerAuto</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if the owner of this part is decided by the engine.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Part</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRootPart">GetRootPart</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the root part of the physics assembly.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsGrounded">IsGrounded</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if the part is connected to an anchored object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsSimulatingPhysics">IsSimulatingPhysics</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetMaterial">SetMaterial</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Asset/Material">Material</a> material</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetNetworkOwner">SetNetworkOwner</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> player = <i>null</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the player who should own this part.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetNetworkOwnerAuto">SetNetworkOwnerAuto</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Lets the engine decide the owner of this part.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Touched">Touched</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Part</b> part</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when another object comes into contact with this object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="TouchEnded">TouchEnded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Part</b> part</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when another object stops touching this object.
</p></td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
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
</div>
