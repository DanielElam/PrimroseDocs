---
title: API:Class/ViewportFrame/FindPartOnRayWithPredicate
linkTitle: "FindPartOnRayWithPredicate"
weight: 70
date: 2019-08-02
namespace: Primrose.DataModel.GUI.ViewportFrame.FindPartOnRayWithPredicate
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/ViewportFrame"><img src="/icons/silk/frame.png"/>&nbsp;ViewportFrame</a>
<pre class="method-declaration">
FindPartOnRayWithPredicate (
    ray: <a class="type" href="/docs/api-reference/DataType/Ray">Ray</a>,
    filterFunc: <a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/Class/Instance">Instance</a>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>>,
    maxLength: <a class="type" href="/docs/api-reference/System/Primitives#single">f32</a>
): <div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div></pre>
<b>Return Type: </b>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div>
<br/>
<b>Description: </b>