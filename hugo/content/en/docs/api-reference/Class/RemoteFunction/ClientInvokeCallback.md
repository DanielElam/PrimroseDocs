---
title: API:Class/RemoteFunction/ClientInvokeCallback
linkTitle: "ClientInvokeCallback"
weight: 67
date: 2019-08-02
namespace: Primrose.DataModel.Networking.RemoteFunction.ClientInvokeCallback
deprecated: false
no_list: true
toc_hide: true
---
Property of <a href="/docs/api-reference/Class/RemoteFunction"><img src="/icons/silk/remote_method.png"/>&nbsp;RemoteFunction</a>
<pre class="method-declaration">
ClientInvokeCallback: <a class="type" href="/docs/api-reference/System/Delegate">Delegate</a></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/System/Delegate">Delegate</a>
<br/>
<b>Description: </b>
The callback for when the server invokes this function.

<b>Notes: </b>
<p class="remarks">
This function will execute on the client when the server invokes it with InvokeClient()
</p>
