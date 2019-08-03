---
title: API:Class/Intent/OnIntercept
linkTitle: "OnIntercept"
weight: 79
date: 2019-08-02
namespace: Primrose.DataModel.Networking.Intent.OnIntercept
deprecated: false
no_list: true
toc_hide: true
---
Property of <a href="/docs/api-reference/Class/Intent"><img src="/icons/silk/remote_event.png"/>&nbsp;Intent</a>
<pre class="method-declaration">
OnIntercept: <a class="type" href="/docs/api-reference/System/Func">Func</a><<span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/System/Func">Func</a><<span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>>
<br/>
<b>Description: </b>
Intercepts outgoing requests and will block them if the callback returns false.

