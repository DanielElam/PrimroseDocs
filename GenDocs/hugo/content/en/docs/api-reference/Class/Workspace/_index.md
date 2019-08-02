---
title: API:Class/Workspace
linkTitle: "Workspace"
weight: 4
date: 2019-08-02
explorerImage: world
namespace: Primrose.DataModel.Workspace
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Workspace"><img src="/icons/silk/world.png"/>&nbsp;Workspace</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

The Workspace is a top-level object representing the game level.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Camera">Camera</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CurrentCamera">CurrentCamera</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Signal">Signal</a><<a class="type" href="/docs/api-reference/Class/Camera">Camera</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CurrentCameraChanged">CurrentCameraChanged</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Description">Description</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
A description of the place.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#double">f64</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="DistributedGameTime">DistributedGameTime</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The amount of time in seconds that the simulation
has been running.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Gravity">Gravity</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The gravity of the scene.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLoaded">IsLoaded</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true, the place has been loaded.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Asset/NavMesh">NavMesh</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="NavMesh">NavMesh</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaceId">PlaceId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The content ID of the currently loaded place.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlaceName">PlaceName</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Terrain">Terrain</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Terrain">Terrain</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The terrain object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#double">f64</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TimeSinceLevelLoad">TimeSinceLevelLoad</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="VoidHeight">VoidHeight</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The height at which parts are destroyed when they fall beneath.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ClearTerrain">ClearTerrain</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartOnRay">FindPartOnRay</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Ray">Ray</a> ray, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> maxLength = <i>1000</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartOnRayWithIgnoreList">FindPartOnRayWithIgnoreList</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Ray">Ray</a> ray, <span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span> ignoreList, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> maxLength = <i>1000</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartOnRayWithPredicate">FindPartOnRayWithPredicate</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Ray">Ray</a> ray, <a class="type" href="/docs/api-reference/Misc/LuaAction">LuaAction</a><<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a>> predicate, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> maxLength = <i>1000</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartOnRayWithWhitelist">FindPartOnRayWithWhitelist</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Ray">Ray</a> ray, <span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span> whiteList, <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> maxLength = <i>1000</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartsInRegion3">FindPartsInRegion3</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Region3">Region3</a> region, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> maxParts = <i>20</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindPartsInRegion3WithPredicate">FindPartsInRegion3WithPredicate</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Region3">Region3</a> region, <a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>> predicate, <a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> maxParts = <i>20</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LoadPlace">LoadPlace</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> placeId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Loads the given level file. If called by the server, instructs connected clients to load map.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LoadRbxl">LoadRbxl</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> contentId</span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="CameraChanged">CameraChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Camera">Camera</a> camera</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when <a href="/docs/api-reference/Class/Workspace/CurrentCamera" >CurrentCamera</a> changes.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="NavMeshChanged">NavMeshChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Asset/NavMesh">NavMesh</a> navMesh</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PlaceLoaded">PlaceLoaded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> placeId</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a place is loaded.
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
