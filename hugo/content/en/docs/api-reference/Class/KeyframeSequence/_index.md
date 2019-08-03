---
title: API:Class/KeyframeSequence
linkTitle: "KeyframeSequence"
weight: 4
date: 2019-08-02
explorerImage: film
namespace: Primrose.DataModel.Animation.KeyframeSequence
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/KeyframeSequence"><img src="/icons/silk/film.png"/>&nbsp;KeyframeSequence</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLooped">IsLooped</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the animation will be looped by default.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/Time">Time</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Length">Length</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The length of the sequence in seconds.
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
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Animation">Animation</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetAnimationId">GetAnimationId</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a hash which can be used in <a href="/docs/api-reference/Class/Animator/LoadAnimation" >LoadAnimation</a> for this sequence.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Class/Keyframe">Keyframe</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetKeyframes">GetKeyframes</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
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
