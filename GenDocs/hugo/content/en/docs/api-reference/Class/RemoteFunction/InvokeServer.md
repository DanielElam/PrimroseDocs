---
title: API:Class/RemoteFunction/InvokeServer
linkTitle: "InvokeServer"
weight: 73
date: 2019-08-02
namespace: Primrose.DataModel.Networking.RemoteFunction.InvokeServer
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/RemoteFunction"><img src="/icons/silk/remote_method.png"/>&nbsp;RemoteFunction</a>
<pre class="method-declaration">
InvokeServer (
    args: <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>
): <a class="type" href="/docs/api-reference/System/object">object</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/object">object</a>
<br/>
<b>Description: </b>
Invokes the function that the server has bound to this instance.

<b>Notes: </b>
<p class="remarks">
The client will yield until any changes that require replication during the call are replicated.
</p>