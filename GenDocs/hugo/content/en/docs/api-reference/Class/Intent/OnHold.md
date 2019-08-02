---
title: API:Class/Intent/OnHold
linkTitle: "OnHold"
weight: 79
date: 2019-08-02
namespace: Primrose.DataModel.Networking.Intent.OnHold
deprecated: false
no_list: true
---
Property of <a href="/docs/api-reference/Class/Intent"><img src="/icons/silk/remote_event.png"/>&nbsp;Intent</a>
<pre class="method-declaration">
OnHold: <a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/System/Func">Func</a><<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>, <span><a class="type" href="/docs/api-reference/System/object">object</a>[]</span>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>>
<br/>
<b>Description: </b>
Intercepts incoming requests and will block them if the callback returns false.

