---
title: API:Class/BallSocketConstraint
linkTitle: "BallSocketConstraint"
weight: 4
date: 2019-08-02
explorerImage: axle
namespace: Primrose.DataModel.Physics.Constraints.BallSocketConstraint
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/BallSocketConstraint"><img src="/icons/silk/axle.png"/>&nbsp;BallSocketConstraint</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Constraint"><img src="/icons/silk/axle.png"/>&nbsp;Constraint</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

The Ball socket joint limits the translation so that the local pivot points of two parts match in world-space.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LimitsEnabled">LimitsEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether a limit is set on the rotation based on <a href="/docs/api-reference/Class/BallSocketConstraint/UpperAngle" >UpperAngle</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Restitution">Restitution</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
How elastic the <a href="/docs/api-reference/Class/Attachment/" >Attachment</a>s will be when they reach the end of the range specified by
<a href="/docs/api-reference/Class/BallSocketConstraint/UpperAngle" >UpperAngle</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TwistLowerAngle">TwistLowerAngle</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TwistUpperAngle">TwistUpperAngle</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">f32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="UpperAngle">UpperAngle</a></span></td>
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
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
