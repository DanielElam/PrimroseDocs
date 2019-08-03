---
title: API:Class/Explosion
linkTitle: "Explosion"
weight: 4
date: 2019-08-02
explorerImage: deathstar
namespace: Primrose.DataModel.Explosion
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Explosion"><img src="/icons/silk/deathstar.png"/>&nbsp;Explosion</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

An explosion applies force to objects within the blast radius at the position of the parent <a href="/docs/api-reference/Class/Part/" >Part</a>.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BlastPressure">BlastPressure</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines the amount of force to apply to objects within the <a href="/docs/api-reference/Class/Explosion/BlastRadius" >BlastRadius</a></p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BlastRadius">BlastRadius</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The radius of the explosion.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="BlastRadiusInner">BlastRadiusInner</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Craters">Craters</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the explosion will make craters terrain.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Visible">Visible</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the explosion is visible.
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
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="OnHit">OnHit</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Part">Part</a> object, <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a> distance</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires for every physical object that is caught in the <a href="/docs/api-reference/Class/Explosion/BlastRadius" >BlastRadius</a>.
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
