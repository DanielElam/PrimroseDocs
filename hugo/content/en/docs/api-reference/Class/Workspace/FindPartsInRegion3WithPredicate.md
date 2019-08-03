---
title: API:Class/Workspace/FindPartsInRegion3WithPredicate
linkTitle: "FindPartsInRegion3WithPredicate"
weight: 70
date: 2019-08-02
namespace: Primrose.DataModel.Workspace.FindPartsInRegion3WithPredicate
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Workspace"><img src="/icons/silk/world.png"/>&nbsp;Workspace</a>
<pre class="method-declaration">
FindPartsInRegion3WithPredicate (
    region: <a class="type" href="/docs/api-reference/DataType/Region3">Region3</a>,
    predicate: <a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/Class/Part">Part</a>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>>,
    maxParts: <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> = <a class="default-param int-param">20</a>
): <span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span></pre>
<b>Return Type: </b>
<span><a class="type" href="/docs/api-reference/Class/Part">Part</a>[]</span>
<br/>
<b>Description: </b>