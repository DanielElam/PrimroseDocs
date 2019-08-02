---
title: API:Class/Player/LoadCharacter
linkTitle: "LoadCharacter"
weight: 76
date: 2019-08-02
namespace: Primrose.DataModel.Player.LoadCharacter
deprecated: false
no_list: true
---
Method of <a href="/docs/api-reference/Class/Player"><img src="/icons/silk/user.png"/>&nbsp;Player</a>
<pre class="method-declaration">
LoadCharacter(): <a class="type" href="/docs/api-reference/System/void">void</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/System/void">void</a>
<br/>
<b>Description: </b>
Spawns a new <a href="/docs/api-reference/Class/Player/Character" >Character</a> for the given player. If the player already has a character it will be destroyed.

<b>Notes: </b>
<p class="remarks">
When a player is in the frontend/main menu, they will probably load a character
but when they join a server they the server will have to override it with a new
server-authorative character
</p>