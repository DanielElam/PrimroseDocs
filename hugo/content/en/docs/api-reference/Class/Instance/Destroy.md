---
title: API:Class/Instance/Destroy
linkTitle: "Destroy"
weight: 68
date: 2019-08-02
namespace: Primrose.DataModel.Instance.Destroy
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a>
<pre class="method-declaration">
Destroy(): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Sets the <a href="/docs/api-reference/Class/Instance/Parent" >Parent</a> property to null and locks it, disconnects all events and calls <a href="/docs/api-reference/Class/Instance/Destroy" >Destroy</a>
on all children.

