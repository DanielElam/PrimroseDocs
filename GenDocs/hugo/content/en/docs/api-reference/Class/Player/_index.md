---
title: API:Class/Player
linkTitle: "Player"
weight: 4
date: 2019-08-02
explorerImage: user
namespace: Primrose.DataModel.Player
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Player"><img src="/icons/silk/user.png"/>&nbsp;Player</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

Represents a user in-game.

</p>
### Notes
<p class="remarks">
A player object is added to the <a href="/docs/api-reference/Class/Players/" >Players</a> service when a player joins the server.
</p> 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Backpack">Backpack</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Backpack">Backpack</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
This player's <a href="/docs/api-reference/Class/Backpack/" >Backpack</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Character">Character</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Character">Character</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The player's <a href="/docs/api-reference/Class/Character/" >Character</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsLobbyLeader">IsLobbyLeader</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/PlayerGui">PlayerGui</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlayerGui">PlayerGui</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
This player's <a href="/docs/api-reference/Class/PlayerGui/" >PlayerGui</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/PlayerScripts">PlayerScripts</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="PlayerScripts">PlayerScripts</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
A folder for player scripts.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/ServerReplicator">ServerReplicator</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Replicator">Replicator</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The replicator that represents this player's connection.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Team">Team</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Team">Team</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The team that this player is on.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#uint32">u32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="UserId">UserId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The player's user ID.
</p></td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/System/Primitives#uint32">u32</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetOnlineFriends">GetOnlineFriends</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> maxFriends = <i>250</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns an array of friends who are online.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Player</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlayerFromCharacter">GetPlayerFromCharacter</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Character">Character</a> character</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the player that owns the given character.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GiveTool">GiveTool</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Tool">Tool</a> tool</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsFriend">IsFriend</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if this player is a friend of the <a href="/docs/api-reference/Class/Players/LocalPlayer" >LocalPlayer</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsTeamMate">IsTeamMate</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if this player is on the same team as the <a href="/docs/api-reference/Class/Players/LocalPlayer" >LocalPlayer</a>.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Kick">Kick</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> reason</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Disconnects player from the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LoadCharacter">LoadCharacter</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Spawns a new <a href="/docs/api-reference/Class/Player/Character" >Character</a> for the given player. If the player already has a character it will be destroyed.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="CharacterAdded">CharacterAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Character">Character</a> character</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the player's character has spawned.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="CharacterRemoving">CharacterRemoving</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Character">Character</a> character</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the player's character is about to be removed.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Disconnected">Disconnected</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> reason</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the player has been disconnected or kicked from the server.
</p></td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
