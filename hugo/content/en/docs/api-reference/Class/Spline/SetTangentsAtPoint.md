---
title: API:Class/Spline/SetTangentsAtPoint
linkTitle: "SetTangentsAtPoint"
weight: 83
date: 2019-08-02
namespace: Primrose.DataModel.Spline.SetTangentsAtPoint
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Spline"><img src="/icons/silk/curve.png"/>&nbsp;Spline</a>
<pre class="method-declaration">
SetTangentsAtPoint (
    pointIndex: <a class="type" href="/docs/api-reference/System/Primitives#int32">int</a>,
    inTangent: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>,
    outTangent: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a>,
    coordinateSpace: <a class="type" href="/docs/api-reference/Enum/SplineCoordinateSpace">SplineCoordinateSpace</a> = <a class="default-param int-param">Local</a>,
    updateSpline: <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a> = <a class="default-param int-param">True</a>
): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>