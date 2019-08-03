---
title: API:Class/ReflectionProbe/Importance
linkTitle: "Importance"
weight: 73
date: 2019-08-02
namespace: Primrose.DataModel.Lights.ReflectionProbe.Importance
deprecated: false
no_list: true
toc_hide: true
---
Property of <a href="/docs/api-reference/Class/ReflectionProbe"><img src="/icons/silk/probe.png"/>&nbsp;ReflectionProbe</a>
<pre class="method-declaration">
Importance: <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a>
<br/>
<b>Description: </b>
Used to break ties when an object is within the range of multiple probes.

<b>Notes: </b>
<p class="remarks">
If two probes overlap an object and they both have the same importance level, blending will be used.
</p>
