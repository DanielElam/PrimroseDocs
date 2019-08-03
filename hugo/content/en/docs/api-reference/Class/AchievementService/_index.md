---
title: API:Class/AchievementService
linkTitle: "AchievementService"
weight: 4
date: 2019-08-02
explorerImage: award_star_gold_1
namespace: Primrose.DataModel.AchievementService
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/AchievementService"><img src="/icons/silk/award_star_gold_1.png"/>&nbsp;AchievementService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for awarding achievements.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsValidAchievement">IsValidAchievement</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId, <a class="type" href="/docs/api-reference/System/string">string</a> achievement</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the given achievement name is valid.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="RevokeAchievement">RevokeAchievement</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId, <a class="type" href="/docs/api-reference/System/string">string</a> achievement</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Re-locks the achievement for the user.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="UnlockAchievement">UnlockAchievement</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId, <a class="type" href="/docs/api-reference/System/string">string</a> achievement</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Unlocks the achievement for the given user.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="UserHasAchievement">UserHasAchievement</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#uint32">uint</a> userId, <a class="type" href="/docs/api-reference/System/string">string</a> achievement</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the user has unlocked the given achievement.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
