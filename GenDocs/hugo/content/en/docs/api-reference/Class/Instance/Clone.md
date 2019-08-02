---
title: API:Class/Instance/Clone
linkTitle: "Clone"
weight: 67
date: 2019-08-02
namespace: Primrose.DataModel.Instance.Clone
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a>
<pre class="method-declaration">
Clone(): <b class="page-type">Instance</b></pre>
<b>Return Type: </b>
<b class="page-type">Instance</b>
<br/>
<b>Description: </b>
Returns a copy of the object and its descendants.

<b>Notes: </b>
<p class="remarks">
The copy's parent is initially nil.
If the object cannot be serialized, returns nil.
</p>