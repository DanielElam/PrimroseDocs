---
title: API:Class/Instance
linkTitle: "Instance"
weight: 4
date: 2019-08-02
explorerImage: default
namespace: Primrose.DataModel.Instance
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</span></small>
<p class="summary">

Base class for all entities.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/DataType/InstanceId">InstanceId</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="InstanceId">InstanceId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
A unique id for this instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/object">object</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Item">Item</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Layer">Layer</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The layer that this instance is set to.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Parent">Parent</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The hierarchical parent of the object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="ParentLocked">ParentLocked</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
If true, the parent property of this instance will be locked and unchangeable.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Prefab">Prefab</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Prefab">Prefab</a></span></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/IWorld">IWorld</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="World">World</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The world that this instance is a descendant of.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ClearChildren">ClearChildren</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Calls <a href="/docs/api-reference/Class/Instance/Destroy" >Destroy</a> on every child.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Clone">Clone</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a copy of the object and its descendants.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="Destroy">Destroy</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets the <a href="/docs/api-reference/Class/Instance/Parent" >Parent</a> property to null and locks it, disconnects all events and calls <a href="/docs/api-reference/Class/Instance/Destroy" >Destroy</a>
on all children.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstAncestor">FindFirstAncestor</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> name</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the first ancestor with the given name.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstAncestorWhere">FindFirstAncestorWhere</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Func">Func</a><<b class="page-type">Instance</b>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>> predicate</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstChild">FindFirstChild</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> name</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the first child with the given name.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstChildWhere">FindFirstChildWhere</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Func">Func</a><<b class="page-type">Instance</b>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>> predicate</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstDescendant">FindFirstDescendant</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> name</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the first descendant with the given name.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="FindFirstDescendantWhere">FindFirstDescendantWhere</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Func">Func</a><<b class="page-type">Instance</b>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>> predicate</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><b class="page-type">Instance</b>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetChildren">GetChildren</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a read-only table of this instance's children.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><b class="page-type">Instance</b>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetDescendants">GetDescendants</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns an array of all descendant instances.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><b class="page-type">Instance</b>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetDescendantsWhere">GetDescendantsWhere</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Func">Func</a><<b class="page-type">Instance</b>, <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a>> predicate</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetFullName">GetFullName</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Gets the path to the instance as a string.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/NetworkRole">NetworkRole</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetNetworkRemoteRole">GetNetworkRemoteRole</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/NetworkRole">NetworkRole</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetNetworkRole">GetNetworkRole</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPrefabDescendant">GetPrefabDescendant</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> index</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Signal">Signal</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPropertyChangedSignal">GetPropertyChangedSignal</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> property</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a signal that is fired when the specified property is changed on this object.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsA">IsA</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> type</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if this type of instance is, or inherits from the provided type.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsAncestorOf">IsAncestorOf</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> descendant</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if this instance is an ancestor of the given descendant.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsDescendantOf">IsDescendantOf</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> ancestor</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if this instance is a descendant of the given ancestor.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetNetworkRole">SetNetworkRole</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/NetworkRole">NetworkRole</a> networkRole</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ToString">ToString</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the name of the instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<b class="page-type">Instance</b><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="WaitForChild">WaitForChild</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> name, <a class="type" href="/docs/api-reference/System/Nullable">Nullable</a><<a class="type" href="/docs/api-reference/System/Primitives#double">f64</a>> timeout = <i>null</i></span> )</span></span></div></td>
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
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="AncestryChanged">AncestryChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> child, <b class="page-type">Instance</b> parent</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the Parent property of the instance or its ancestors changes.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ChildAdded">ChildAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> child</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a new child is added to this instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ChildRemoved">ChildRemoved</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> child</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a new child is removed from this instance.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="DescendantAdded">DescendantAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> child</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a descendant of this instance is added.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="DescendantRemoving">DescendantRemoving</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> descendant</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired before a descendant of this instance is removed.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Destroyed">Destroyed</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when this instance is destroyed.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="IdChanged">IdChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/DataType/InstanceId">InstanceId</a> newId, <a class="type" href="/docs/api-reference/DataType/InstanceId">InstanceId</a> oldId</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the <a href="/docs/api-reference/Class/Instance/InstanceId" >InstanceId</a> changes.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ParentChanged">ParentChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><b class="page-type">Instance</b> oldParent</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when <a href="/docs/api-reference/Class/Instance/Parent" >Parent</a> is set.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WorldChanged">WorldChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/IWorld">IWorld</a> newWorld, <a class="type" href="/docs/api-reference/Misc/IWorld">IWorld</a> oldWorld</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when the Parent property of the instance or its ancestors changes.
</p></td>
</tr>

</tbody>
</table>
<b>
Inherited by:</b>
<div class="inheritors">
<ul class="root">
<a class="" href="/docs/api-reference/Class/Processor"><img src="/icons/silk/default.png"/>&nbsp;Processor</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/GraphicsCard"><img src="/icons/silk/default.png"/>&nbsp;GraphicsCard</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Monitor"><img src="/icons/silk/default.png"/>&nbsp;Monitor</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SettingsBase"><img src="/icons/silk/cog.png"/>&nbsp;SettingsBase</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/ContentSettings"><img src="/icons/silk/cog.png"/>&nbsp;ContentSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DebugSettings"><img src="/icons/silk/cog.png"/>&nbsp;DebugSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NetworkSettings"><img src="/icons/silk/cog.png"/>&nbsp;NetworkSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PhysicsSettings"><img src="/icons/silk/cog.png"/>&nbsp;PhysicsSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RenderSettings"><img src="/icons/silk/cog.png"/>&nbsp;RenderSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScriptSettings"><img src="/icons/silk/cog.png"/>&nbsp;ScriptSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SoundSettings"><img src="/icons/silk/cog.png"/>&nbsp;SoundSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UserAnalyticsSettings"><img src="/icons/silk/cog.png"/>&nbsp;UserAnalyticsSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UserGameSettings"><img src="/icons/silk/cog.png"/>&nbsp;UserGameSettings</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/SettingsContainer"><img src="/icons/silk/folder_config.png"/>&nbsp;SettingsContainer</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/GlobalSettings"><img src="/icons/silk/folder_config.png"/>&nbsp;GlobalSettings</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UserSettings"><img src="/icons/silk/folder_config.png"/>&nbsp;UserSettings</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/AudioMixer"><img src="/icons/silk/default.png"/>&nbsp;AudioMixer</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SoundGroup"><img src="/icons/silk/default.png"/>&nbsp;SoundGroup</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Backpack"><img src="/icons/silk/folder_wrench.png"/>&nbsp;Backpack</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BackpackItem"><img src="/icons/silk/default.png"/>&nbsp;BackpackItem</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Tool"><img src="/icons/silk/tool.png"/>&nbsp;Tool</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/CoreEnvironment"><img src="/icons/silk/default.png"/>&nbsp;CoreEnvironment</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Explosion"><img src="/icons/silk/deathstar.png"/>&nbsp;Explosion</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Folder"><img src="/icons/silk/folder.png"/>&nbsp;Folder</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Forcefield"><img src="/icons/silk/arrow_out.png"/>&nbsp;Forcefield</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Game"><img src="/icons/silk/primrose.png"/>&nbsp;Game</a>
<ul class="nested">
</ul>
<a class="deprecated" href="/docs/api-reference/Class/Message"><img src="/icons/silk/hint.png"/>&nbsp;Message</a>
<ul class="nested">
<a class="deprecated" href="/docs/api-reference/Class/Hint"><img src="/icons/silk/hint.png"/>&nbsp;Hint</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Player"><img src="/icons/silk/user.png"/>&nbsp;Player</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PVInstance"><img src="/icons/silk/default.png"/>&nbsp;PVInstance</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Area"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;Area</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/PhysicsArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;PhysicsArea</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshBoundsArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;NavMeshBoundsArea</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Decal"><img src="/icons/silk/photo.png"/>&nbsp;Decal</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Model"><img src="/icons/silk/bricks.png"/>&nbsp;Model</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Spline"><img src="/icons/silk/curve.png"/>&nbsp;Spline</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshLink"><img src="/icons/silk/arrow_ew.png"/>&nbsp;NavMeshLink</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Part"><img src="/icons/silk/brick.png"/>&nbsp;Part</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Character"><img src="/icons/silk/humanoid.png"/>&nbsp;Character</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Seat"><img src="/icons/silk/seat.png"/>&nbsp;Seat</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vehicle"><img src="/icons/silk/car.png"/>&nbsp;Vehicle</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PartOperation"><img src="/icons/silk/brick.png"/>&nbsp;PartOperation</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/IntersectOperation"><img src="/icons/silk/brick.png"/>&nbsp;IntersectOperation</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NegateOperation"><img src="/icons/silk/negate.png"/>&nbsp;NegateOperation</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UnionOperation"><img src="/icons/silk/union.png"/>&nbsp;UnionOperation</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Terrain"><img src="/icons/silk/terrain.png"/>&nbsp;Terrain</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/TriggerArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;TriggerArea</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/SoundTriggerArea"><img src="/icons/silk/arrow_nw_ne_sw_se.png"/>&nbsp;SoundTriggerArea</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Wheel"><img src="/icons/silk/bullet_black.png"/>&nbsp;Wheel</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ParticleSpawner"><img src="/icons/silk/emitter.png"/>&nbsp;ParticleSpawner</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Fire"><img src="/icons/silk/fire.png"/>&nbsp;Fire</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/NavMeshLinkMarker"><img src="/icons/silk/arrow_ew.png"/>&nbsp;NavMeshLinkMarker</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Socket"><img src="/icons/silk/default.png"/>&nbsp;Socket</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Light"><img src="/icons/silk/lightbulb.png"/>&nbsp;Light</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/DiskLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;DiskLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RectangleLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;RectangleLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SphereLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;SphereLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TubeLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;TubeLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DirectionalLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;DirectionalLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PointLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;PointLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SpotLight"><img src="/icons/silk/lightbulb.png"/>&nbsp;SpotLight</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReflectionProbe"><img src="/icons/silk/probe.png"/>&nbsp;ReflectionProbe</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/LightProbe"><img src="/icons/silk/contrast.png"/>&nbsp;LightProbe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/WaterBase"><img src="/icons/silk/waves2.png"/>&nbsp;WaterBase</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Ocean"><img src="/icons/silk/waves2.png"/>&nbsp;Ocean</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/FogVolume"><img src="/icons/silk/default.png"/>&nbsp;FogVolume</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Bone"><img src="/icons/silk/bone.png"/>&nbsp;Bone</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/AchievementService"><img src="/icons/silk/award_star_gold_1.png"/>&nbsp;AchievementService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/AnalyticsService"><img src="/icons/silk/chart_curve.png"/>&nbsp;AnalyticsService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/CollectionService"><img src="/icons/silk/default.png"/>&nbsp;CollectionService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DataStoreService"><img src="/icons/silk/database_save.png"/>&nbsp;DataStoreService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Debris"><img src="/icons/silk/fragment.png"/>&nbsp;Debris</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/HistoryService"><img src="/icons/silk/clock.png"/>&nbsp;HistoryService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/HttpService"><img src="/icons/silk/page_code.png"/>&nbsp;HttpService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/InsertService"><img src="/icons/silk/package.png"/>&nbsp;InsertService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/KeyframeSequenceProvider"><img src="/icons/silk/default.png"/>&nbsp;KeyframeSequenceProvider</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Layers"><img src="/icons/silk/layers.png"/>&nbsp;Layers</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Lighting"><img src="/icons/silk/lightbulb.png"/>&nbsp;Lighting</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/LocalizationService"><img src="/icons/silk/default.png"/>&nbsp;LocalizationService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/LocalStorage"><img src="/icons/silk/database_refresh.png"/>&nbsp;LocalStorage</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/LogService"><img src="/icons/silk/log.png"/>&nbsp;LogService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PhysicsService"><img src="/icons/silk/default.png"/>&nbsp;PhysicsService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Players"><img src="/icons/silk/users.png"/>&nbsp;Players</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReplayService"><img src="/icons/silk/timeline_marker.png"/>&nbsp;ReplayService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReplicatedStorage"><img src="/icons/silk/database_refresh.png"/>&nbsp;ReplicatedStorage</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RunService"><img src="/icons/silk/method.png"/>&nbsp;RunService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Selection"><img src="/icons/silk/surface.png"/>&nbsp;Selection</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ServerScriptService"><img src="/icons/silk/server_script.png"/>&nbsp;ServerScriptService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ServerStorage"><img src="/icons/silk/server_database.png"/>&nbsp;ServerStorage</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SoundService"><img src="/icons/silk/soundscape.png"/>&nbsp;SoundService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/StarterPlayer"><img src="/icons/silk/folder_user.png"/>&nbsp;StarterPlayer</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Teams"><img src="/icons/silk/folder_football.png"/>&nbsp;Teams</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Workspace"><img src="/icons/silk/world.png"/>&nbsp;Workspace</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScriptService"><img src="/icons/silk/default.png"/>&nbsp;ScriptService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ClanService"><img src="/icons/silk/flag_green.png"/>&nbsp;ClanService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/LobbyService"><img src="/icons/silk/default.png"/>&nbsp;LobbyService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/OnlineService"><img src="/icons/silk/steam.png"/>&nbsp;OnlineService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NetworkPeer"><img src="/icons/silk/default.png"/>&nbsp;NetworkPeer</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/NetworkClient"><img src="/icons/silk/client_network.png"/>&nbsp;NetworkClient</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NetworkServer"><img src="/icons/silk/server_network.png"/>&nbsp;NetworkServer</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/InputBindingService"><img src="/icons/silk/default.png"/>&nbsp;InputBindingService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/InputService"><img src="/icons/silk/controller.png"/>&nbsp;InputService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DebuggerManager"><img src="/icons/silk/bug.png"/>&nbsp;DebuggerManager</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ContentProvider"><img src="/icons/silk/package.png"/>&nbsp;ContentProvider</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/AIService"><img src="/icons/silk/chart_curve.png"/>&nbsp;AIService</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PathfindingService"><img src="/icons/silk/arrow_out.png"/>&nbsp;PathfindingService</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/StarterPlayerScripts"><img src="/icons/silk/folder_page.png"/>&nbsp;StarterPlayerScripts</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PlayerScripts"><img src="/icons/silk/folder_page.png"/>&nbsp;PlayerScripts</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Team"><img src="/icons/silk/football.png"/>&nbsp;Team</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ValueBase"><img src="/icons/silk/value.png"/>&nbsp;ValueBase</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BoolValue"><img src="/icons/silk/value.png"/>&nbsp;BoolValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/CFrameValue"><img src="/icons/silk/value.png"/>&nbsp;CFrameValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ColourValue"><img src="/icons/silk/value.png"/>&nbsp;ColourValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DoubleConstrainedValue"><img src="/icons/silk/value.png"/>&nbsp;DoubleConstrainedValue</a>
<ul class="nested">
</ul>
<a class="deprecated" href="/docs/api-reference/Class/EnumValue"><img src="/icons/silk/value.png"/>&nbsp;EnumValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/IntConstrainedValue"><img src="/icons/silk/value.png"/>&nbsp;IntConstrainedValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/IntValue"><img src="/icons/silk/value.png"/>&nbsp;IntValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NumberValue"><img src="/icons/silk/value.png"/>&nbsp;NumberValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ObjectValue"><img src="/icons/silk/value.png"/>&nbsp;ObjectValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RayValue"><img src="/icons/silk/value.png"/>&nbsp;RayValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/StringValue"><img src="/icons/silk/value.png"/>&nbsp;StringValue</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vector3Value"><img src="/icons/silk/value.png"/>&nbsp;Vector3Value</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vector4Value"><img src="/icons/silk/value.png"/>&nbsp;Vector4Value</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Sky"><img src="/icons/silk/sky.png"/>&nbsp;Sky</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/PhysicalSky"><img src="/icons/silk/sky.png"/>&nbsp;PhysicalSky</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Skybox"><img src="/icons/silk/sky.png"/>&nbsp;Skybox</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/BindableEvent"><img src="/icons/silk/event.png"/>&nbsp;BindableEvent</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BindableFunction"><img src="/icons/silk/method.png"/>&nbsp;BindableFunction</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScriptDebugger"><img src="/icons/silk/script_module.png"/>&nbsp;ScriptDebugger</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DebuggerWatch"><img src="/icons/silk/magnify.png"/>&nbsp;DebuggerWatch</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DebuggerBreakpoint"><img src="/icons/silk/breakpoint.png"/>&nbsp;DebuggerBreakpoint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SourceCodeContainer"><img src="/icons/silk/default.png"/>&nbsp;SourceCodeContainer</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/ModuleScript"><img src="/icons/silk/script_module.png"/>&nbsp;ModuleScript</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Script"><img src="/icons/silk/script.png"/>&nbsp;Script</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/LocalScript"><img src="/icons/silk/script_local.png"/>&nbsp;LocalScript</a>
<ul class="nested">
</ul>
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/PostEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;PostEffect</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/AmbientOcclusionEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;AmbientOcclusionEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BloomEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;BloomEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ColourCorrectionEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;ColourCorrectionEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DepthOfFieldEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;DepthOfFieldEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/EyeAdaptationEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;EyeAdaptationEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/LensFlareEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;LensFlareEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/MotionBlurEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;MotionBlurEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScreenSpaceReflectionEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;ScreenSpaceReflectionEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SubsurfaceEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;SubsurfaceEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TemporalAAEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;TemporalAAEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TonemapEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;TonemapEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ToonEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;ToonEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/VignetteEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;VignetteEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/VolumetricFogEffect"><img src="/icons/silk/posteffect.png"/>&nbsp;VolumetricFogEffect</a>
<ul class="nested">
</ul>
</ul>
<a class="deprecated" href="/docs/api-reference/Class/JointInstance"><img src="/icons/silk/default.png"/>&nbsp;JointInstance</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Attachment"><img src="/icons/silk/socket.png"/>&nbsp;Attachment</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Constraint"><img src="/icons/silk/axle.png"/>&nbsp;Constraint</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/WeldConstraint"><img src="/icons/silk/link.png"/>&nbsp;WeldConstraint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BallSocketConstraint"><img src="/icons/silk/axle.png"/>&nbsp;BallSocketConstraint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/HingeConstraint"><img src="/icons/silk/axle.png"/>&nbsp;HingeConstraint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RodConstraint"><img src="/icons/silk/axle.png"/>&nbsp;RodConstraint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RopeConstraint"><img src="/icons/silk/axle.png"/>&nbsp;RopeConstraint</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SpringConstraint"><img src="/icons/silk/axle.png"/>&nbsp;SpringConstraint</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/BodyMover"><img src="/icons/silk/rocket.png"/>&nbsp;BodyMover</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BodyAngularVelocity"><img src="/icons/silk/rocket.png"/>&nbsp;BodyAngularVelocity</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BodyForce"><img src="/icons/silk/rocket.png"/>&nbsp;BodyForce</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BodyGyro"><img src="/icons/silk/rocket.png"/>&nbsp;BodyGyro</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BodyPosition"><img src="/icons/silk/rocket.png"/>&nbsp;BodyPosition</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BodyThrust"><img src="/icons/silk/rocket.png"/>&nbsp;BodyThrust</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BodyVelocity"><img src="/icons/silk/rocket.png"/>&nbsp;BodyVelocity</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RocketPropulsion"><img src="/icons/silk/rocket.png"/>&nbsp;RocketPropulsion</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Smoke"><img src="/icons/silk/smoke.png"/>&nbsp;Smoke</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Pages"><img src="/icons/silk/page_white.png"/>&nbsp;Pages</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/FriendPages"><img src="/icons/silk/page_white.png"/>&nbsp;FriendPages</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Lobby"><img src="/icons/silk/default.png"/>&nbsp;Lobby</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Intent"><img src="/icons/silk/remote_event.png"/>&nbsp;Intent</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/NetworkReplicator"><img src="/icons/silk/connect.png"/>&nbsp;NetworkReplicator</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/ClientReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ClientReplicator</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReplayReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ReplayReplicator</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ServerReplicator"><img src="/icons/silk/connect.png"/>&nbsp;ServerReplicator</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/RemoteEvent"><img src="/icons/silk/remote_event.png"/>&nbsp;RemoteEvent</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/RemoteFunction"><img src="/icons/silk/remote_method.png"/>&nbsp;RemoteFunction</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DataModelMesh"><img src="/icons/silk/mesh.png"/>&nbsp;DataModelMesh</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/FileMesh"><img src="/icons/silk/mesh.png"/>&nbsp;FileMesh</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/SkeletalMesh"><img src="/icons/silk/skeletmesh.png"/>&nbsp;SkeletalMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SpecialMesh"><img src="/icons/silk/mesh.png"/>&nbsp;SpecialMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/StaticMesh"><img src="/icons/silk/mesh.png"/>&nbsp;StaticMesh</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/PlaneMesh"><img src="/icons/silk/mesh.png"/>&nbsp;PlaneMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PrimitiveMesh"><img src="/icons/silk/mesh.png"/>&nbsp;PrimitiveMesh</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SplineMesh"><img src="/icons/silk/splinemesh.png"/>&nbsp;SplineMesh</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/TerrainRegion"><img src="/icons/silk/terrain.png"/>&nbsp;TerrainRegion</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/BasePlayerGui"><img src="/icons/silk/folder_gui.png"/>&nbsp;BasePlayerGui</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/StarterGui"><img src="/icons/silk/folder_gui.png"/>&nbsp;StarterGui</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/CoreGui"><img src="/icons/silk/folder_gui.png"/>&nbsp;CoreGui</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PlayerGui"><img src="/icons/silk/folder_gui.png"/>&nbsp;PlayerGui</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/GuiBase"><img src="/icons/silk/default.png"/>&nbsp;GuiBase</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/GuiBase2D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase2D</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/GuiContainer"><img src="/icons/silk/default.png"/>&nbsp;GuiContainer</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BillboardGui"><img src="/icons/silk/billboard.png"/>&nbsp;BillboardGui</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScreenGui"><img src="/icons/silk/application.png"/>&nbsp;ScreenGui</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/DebugGui"><img src="/icons/silk/application.png"/>&nbsp;DebugGui</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/SurfaceGui"><img src="/icons/silk/billboard.png"/>&nbsp;SurfaceGui</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/GuiElement"><img src="/icons/silk/default.png"/>&nbsp;GuiElement</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Button"><img src="/icons/silk/button.png"/>&nbsp;Button</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Frame"><img src="/icons/silk/frame.png"/>&nbsp;Frame</a>
<ul class="nested">
<a class="deprecated" href="/docs/api-reference/Class/Flex"><img src="/icons/silk/frame.png"/>&nbsp;Flex</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ScrollFrame"><img src="/icons/silk/frame.png"/>&nbsp;ScrollFrame</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/VideoElement"><img src="/icons/silk/frame.png"/>&nbsp;VideoElement</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/ImageLabel"><img src="/icons/silk/picture.png"/>&nbsp;ImageLabel</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SinglePixelLine"><img src="/icons/silk/frame.png"/>&nbsp;SinglePixelLine</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TextElement"><img src="/icons/silk/default.png"/>&nbsp;TextElement</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/TextBox"><img src="/icons/silk/textbox.png"/>&nbsp;TextBox</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TextLabel"><img src="/icons/silk/style.png"/>&nbsp;TextLabel</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/ViewportFrame"><img src="/icons/silk/frame.png"/>&nbsp;ViewportFrame</a>
<ul class="nested">
</ul>
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/GuiBase3D"><img src="/icons/silk/default.png"/>&nbsp;GuiBase3D</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/PartAdornment"><img src="/icons/silk/default.png"/>&nbsp;PartAdornment</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/PVAdornment"><img src="/icons/silk/default.png"/>&nbsp;PVAdornment</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BaseHandles"><img src="/icons/silk/default.png"/>&nbsp;BaseHandles</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/ArcHandles"><img src="/icons/silk/arc.png"/>&nbsp;ArcHandles</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/AxisHandles"><img src="/icons/silk/axis.png"/>&nbsp;AxisHandles</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/SelectionBox"><img src="/icons/silk/selectionbox.png"/>&nbsp;SelectionBox</a>
<ul class="nested">
</ul>
</ul>
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/UIComponent"><img src="/icons/silk/form.png"/>&nbsp;UIComponent</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/UILayout"><img src="/icons/silk/form.png"/>&nbsp;UILayout</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/UIGridStyleLayout"><img src="/icons/silk/form.png"/>&nbsp;UIGridStyleLayout</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/UIGridLayout"><img src="/icons/silk/form.png"/>&nbsp;UIGridLayout</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UIListLayout"><img src="/icons/silk/form.png"/>&nbsp;UIListLayout</a>
<ul class="nested">
</ul>
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/UIConstraint"><img src="/icons/silk/form.png"/>&nbsp;UIConstraint</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/UIAspectRatioConstraint"><img src="/icons/silk/form.png"/>&nbsp;UIAspectRatioConstraint</a>
<ul class="nested">
</ul>
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/StatsItem"><img src="/icons/silk/default.png"/>&nbsp;StatsItem</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/Stats"><img src="/icons/silk/default.png"/>&nbsp;Stats</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/GlobalDataStore"><img src="/icons/silk/database_world.png"/>&nbsp;GlobalDataStore</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/OrderedDataStore"><img src="/icons/silk/database_go.png"/>&nbsp;OrderedDataStore</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Camera"><img src="/icons/silk/camera.png"/>&nbsp;Camera</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/CineCamera"><img src="/icons/silk/camera.png"/>&nbsp;CineCamera</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Sound"><img src="/icons/silk/sound.png"/>&nbsp;Sound</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;SoundEffect</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/ChorusSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;ChorusSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/CompressorSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;CompressorSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DistortionSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;DistortionSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/EchoSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;EchoSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/EqualizerSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;EqualizerSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/FlangeSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;FlangeSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/ReverbSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;ReverbSoundEffect</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/VolumeSoundEffect"><img src="/icons/silk/soundwave.png"/>&nbsp;VolumeSoundEffect</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/AnimationTrack"><img src="/icons/silk/film.png"/>&nbsp;AnimationTrack</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/BlendSpaceAnimationTrack"><img src="/icons/silk/film.png"/>&nbsp;BlendSpaceAnimationTrack</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/Animator"><img src="/icons/silk/film.png"/>&nbsp;Animator</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Keyframe"><img src="/icons/silk/film.png"/>&nbsp;Keyframe</a>
<ul class="nested">
<a class="" href="/docs/api-reference/Class/CFrameKeyframe"><img src="/icons/silk/film.png"/>&nbsp;CFrameKeyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/DoubleKeyframe"><img src="/icons/silk/film.png"/>&nbsp;DoubleKeyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/FloatKeyframe"><img src="/icons/silk/film.png"/>&nbsp;FloatKeyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Matrix4Keyframe"><img src="/icons/silk/film.png"/>&nbsp;Matrix4Keyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/TransformKeyframe"><img src="/icons/silk/film.png"/>&nbsp;TransformKeyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/UDim2Keyframe"><img src="/icons/silk/film.png"/>&nbsp;UDim2Keyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vector3Keyframe"><img src="/icons/silk/film.png"/>&nbsp;Vector3Keyframe</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Vector4Keyframe"><img src="/icons/silk/film.png"/>&nbsp;Vector4Keyframe</a>
<ul class="nested">
</ul>
</ul>
<a class="" href="/docs/api-reference/Class/KeyframeSequence"><img src="/icons/silk/film.png"/>&nbsp;KeyframeSequence</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/SkeletonInstance"><img src="/icons/silk/bone.png"/>&nbsp;SkeletonInstance</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Agent"><img src="/icons/silk/default.png"/>&nbsp;Agent</a>
<ul class="nested">
</ul>
<a class="" href="/docs/api-reference/Class/Path"><img src="/icons/silk/default.png"/>&nbsp;Path</a>
<ul class="nested">
</ul>
</ul>
</div>
