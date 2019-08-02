---
title: API:Class/Model/MoveTo
linkTitle: "MoveTo"
weight: 77
date: 2019-08-02
namespace: Primrose.DataModel.Model.MoveTo
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</a>
<pre class="method-declaration">
MoveTo (
    position: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>
): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Moves the centroid of the <a href="/docs/api-reference/Class/Model/" >Model</a> to the specified location, respecting all relative distances between
parts in the model.

<b>Notes: </b>
<p class="remarks">
If <a href="/docs/api-reference/Class/Model/PrimaryPart" >PrimaryPart</a> is will use the part's CFrame, otherwise the center of the model will be used.
</p>