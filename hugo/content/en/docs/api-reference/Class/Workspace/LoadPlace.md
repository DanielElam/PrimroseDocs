---
title: API:Class/Workspace/LoadPlace
linkTitle: "LoadPlace"
weight: 76
date: 2019-08-02
namespace: Primrose.DataModel.Workspace.LoadPlace
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Workspace"><img src="/icons/silk/world.png"/>&nbsp;Workspace</a>
<pre class="method-declaration">
LoadPlace (
    placeId: <a class="type" href="/docs/api-reference/System/string">string</a>
): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Loads the given level file. If called by the server, instructs connected clients to load map.

<b>Notes: </b>
<p class="remarks">
IDs without a slash are assumed to be shorthand for content://Levels/levelName/levelName.passet
</p>