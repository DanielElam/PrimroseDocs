---
title: API:Class/Players/GetProfilePicture
linkTitle: "GetProfilePicture"
weight: 71
date: 2019-08-02
namespace: Primrose.DataModel.Players.GetProfilePicture
deprecated: false
no_list: true
toc_hide: true
---
Method of <a href="/docs/api-reference/Class/Players"><img src="/icons/silk/users.png"/>&nbsp;Players</a>
<pre class="method-declaration">
GetProfilePicture (
    userId: <a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a>,
    size: <a class="type" href="/docs/api-reference/Enum/ThumbnailSize">ThumbnailSize</a> = <a class="default-param int-param">Size64x64</a>
): <a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>></pre>
<b>Return Type: </b>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>>
<br/>
<b>Description: </b>
Returns the given user's profile picture.

