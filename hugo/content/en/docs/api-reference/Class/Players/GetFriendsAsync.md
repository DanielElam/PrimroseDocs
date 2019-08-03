---
title: API:Class/Players/GetFriendsAsync
linkTitle: "GetFriendsAsync"
weight: 71
date: 2019-08-02
namespace: Primrose.DataModel.Players.GetFriendsAsync
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Players"><img src="/icons/silk/users.png"/>&nbsp;Players</a>
<pre class="method-declaration">
GetFriendsAsync (
    userId: <a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a>
): <a class="type" href="/docs/api-reference/Class/FriendPages">FriendPages</a></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/Class/FriendPages">FriendPages</a>
<br/>
<b>Description: </b>
Returns a <a href="/docs/api-reference/Class/FriendPages/" >FriendPages</a> object which contains information for the given player's friends.

<b>Notes: </b>
<p class="remarks">
The content of the array are the following:
<list type="table"><listheader><term>Name</term><term>Type</term><term>Description</term></listheader><item><term>UserId</term><term>number</term><term>The UserId of the friend.</term></item><item><term>Username</term><term>string</term><term>The username of the friend.</term></item><item><term>IsOnline</term><term>Determines If the friend is currently online.</term><term>bool</term></item></list></p>