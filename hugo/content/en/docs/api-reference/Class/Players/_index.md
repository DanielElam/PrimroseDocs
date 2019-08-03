---
title: API:Class/Players
linkTitle: "Players"
weight: 4
date: 2019-08-02
explorerImage: users
namespace: Primrose.DataModel.Players
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Players"><img src="/icons/silk/users.png"/>&nbsp;Players</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for handling players. When a client joints the game, a <a href="/docs/api-reference/Class/Player/" >Player</a> is parented to this service.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CharacterAutoLoads">CharacterAutoLoads</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a <a href="/docs/api-reference/Class/Character/" >Character</a> is spawned when the player joins/dies.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Player">Player</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="LocalPlayer">LocalPlayer</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The player object for the current client.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MaxPlayers">MaxPlayers</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The maximum amount of players.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">int</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="NumPlayers">NumPlayers</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The number of players in the game.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Chat">Chat</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> message, <a class="type" href="/docs/api-reference/System/Primitives#byte">byte</a> channel</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sends a chat message to the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/FriendPages">FriendPages</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetFriendsAsync">GetFriendsAsync</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a <a href="/docs/api-reference/Class/FriendPages/" >FriendPages</a> object which contains information for the given player's friends.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Player">Player</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPlayerByUserId">GetPlayerByUserId</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a player with the provided steam ID.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetProfilePicture">GetProfilePicture</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId, <a class="type" href="/docs/api-reference/Enum/ThumbnailSize">ThumbnailSize</a> size = <i>Size64x64</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the given user's profile picture.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetUsernameFromId">GetUsernameFromId</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="InviteUserToGame">InviteUserToGame</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Invites a user to the hosted game.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Chatted">Chatted</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> message, <a class="type" href="/docs/api-reference/System/Primitives#byte">byte</a> channel</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a client sends a chat message to the server.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="JoinRequested">JoinRequested</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a friend accepts a game invite or attempts to join.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PlayerAdded">PlayerAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> player</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a player joins the game.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="PlayerRemoving">PlayerRemoving</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Player">Player</a> player</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a player is leaving the game.
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
