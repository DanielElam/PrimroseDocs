---
title: API:Class/Part/SetNetworkOwner
linkTitle: "SetNetworkOwner"
weight: 83
date: 2019-08-02
namespace: Primrose.DataModel.Part.SetNetworkOwner
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Part"><img src="/icons/silk/brick.png"/>&nbsp;Part</a>
<pre class="method-declaration">
SetNetworkOwner (
    player: <a class="type" href="/docs/api-reference/Class/Player">Player</a> = <a class="default-param int-param">null</a>
): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Sets the player who should own this part.

<b>Notes: </b>
<p class="remarks">
If `player` is set to null, the server will take ownership.
</p>