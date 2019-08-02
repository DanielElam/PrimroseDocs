---
title: API:Class/RemoteFunction/ServerInvokeCallback
linkTitle: "ServerInvokeCallback"
weight: 83
date: 2019-08-02
namespace: Primrose.DataModel.Networking.RemoteFunction.ServerInvokeCallback
deprecated: false
no_list: true
---
Property of <a href="/docs/api-reference/Class/RemoteFunction"><img src="/icons/silk/remote_method.png"/>&nbsp;RemoteFunction</a>
<pre class="method-declaration">
ServerInvokeCallback: <a class="type" href="/docs/api-reference/System/Delegate">Delegate</a></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/System/Delegate">Delegate</a>
<br/>
<b>Description: </b>
The callback for when the client invokes this function.

<b>Notes: </b>
<p class="remarks">
This function will execute on the server when the client invokes it with InvokeServer()
</p>
