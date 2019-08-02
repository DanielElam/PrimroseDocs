---
title: API:Class/LobbyService
linkTitle: "LobbyService"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Online.LobbyService
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/LobbyService"><img src="/icons/silk/default.png"/>&nbsp;LobbyService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Lobby">Lobby</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CurrentLobby">CurrentLobby</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Lobby">Lobby</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetLobbyFromId">GetLobbyFromId</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint64">u64</a> lobbyId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/Lobby">Lobby</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="HostLobby">HostLobby</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Attempts to host a lobby. Yields until it is created or times out.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="JoinLobby">JoinLobby</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint64">u64</a> lobbyId</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Joins the given lobby.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="LeaveLobby">LeaveLobby</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="CurrentLobbyChanged">CurrentLobbyChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/Lobby">Lobby</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
