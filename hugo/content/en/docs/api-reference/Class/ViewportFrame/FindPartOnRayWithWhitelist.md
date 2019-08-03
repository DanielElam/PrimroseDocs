---
title: API:Class/ViewportFrame/FindPartOnRayWithWhitelist
linkTitle: "FindPartOnRayWithWhitelist"
weight: 70
date: 2019-08-02
namespace: Primrose.DataModel.GUI.ViewportFrame.FindPartOnRayWithWhitelist
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/ViewportFrame"><img src="/icons/silk/frame.png"/>&nbsp;ViewportFrame</a>
<pre class="method-declaration">
FindPartOnRayWithWhitelist (
    ray: <a class="type" href="/docs/api-reference/DataType/Ray">Ray</a>,
    ignoreList: <a class="type" href="/docs/api-reference/System/IList">IList</a><<a class="type" href="/docs/api-reference/Class/Instance">Instance</a>>,
    maxLength: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a> = <a class="default-param int-param">1000</a>
): <div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div></pre>
<b>Return Type: </b>
<div class="tuple"><a class="type" href="/docs/api-reference/System/ValueTuple"></a>(<a class="type" href="/docs/api-reference/Class/PVInstance">PVInstance</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>, <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>)</div>
<br/>
<b>Description: </b>