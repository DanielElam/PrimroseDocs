---
title: API:Class/Model/SetPrimaryPartCFrame
linkTitle: "SetPrimaryPartCFrame"
weight: 83
date: 2019-08-02
namespace: Primrose.DataModel.Model.SetPrimaryPartCFrame
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</a>
<pre class="method-declaration">
SetPrimaryPartCFrame (
    cframe: <a class="type" href="/docs/api-reference/DataType/CFrame">CFrame</a>
): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Sets the CFrame of the <a href="/docs/api-reference/Class/Model/PrimaryPart" >PrimaryPart</a>, respecting all relative distances between parts.

<b>Notes: </b>
<p class="remarks">
If <a href="/docs/api-reference/Class/Model/PrimaryPart" >PrimaryPart</a> is not set, this method will error.
</p>