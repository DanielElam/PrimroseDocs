---
title: API:Class/Spline
linkTitle: "Spline"
weight: 4
date: 2019-08-02
explorerImage: curve
namespace: Primrose.DataModel.Spline
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Spline"><img src="/icons/silk/curve.png"/>&nbsp;Spline</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ClosedLoop">ClosedLoop</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Duration">Duration</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Length">Length</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LoopPosition">LoopPosition</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LoopPositionOverride">LoopPositionOverride</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ReparamStepsPerSegment">ReparamStepsPerSegment</a></span></td>
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
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="AddPoint">AddPoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> position, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> updateSpline = <i>True</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetDirectionAtDistance">GetDirectionAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPointCount">GetPointCount</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/LuaResult">LuaResult</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPositionAndTangentAtPoint">GetPositionAndTangentAtPoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> pointIndex, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPositionAtDistance">GetPositionAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRightVectorAtDistance">GetRightVectorAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRollAtDistance">GetRollAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Quat">Quat</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetRotationAtDistance">GetRotationAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetScaleAtDistance">GetScaleAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetTangentAtDistance">GetTangentAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetUpVectorAtDistance">GetUpVectorAtDistance</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#single">f32</a> distance, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetCurveInterpModeAtPoint">SetCurveInterpModeAtPoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> pointIndex, <a class="type" href="/docs/api-reference/Misc/CurveInterpolationMode">CurveInterpolationMode</a> mode</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetTangentAtPoint">SetTangentAtPoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> pointIndex, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> inTangent, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> outTangent, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> updateSpline = <i>True</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetTangentsAtPoint">SetTangentsAtPoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> pointIndex, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> inTangent, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a> outTangent, <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> coordinateSpace = <i>Local</i>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> updateSpline = <i>True</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="UpdateSpline">UpdateSpline</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
