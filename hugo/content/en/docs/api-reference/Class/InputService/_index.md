---
title: API:Class/InputService
linkTitle: "InputService"
weight: 4
date: 2019-08-02
explorerImage: controller
namespace: Primrose.DataModel.Input.InputService
deprecated: false
no_list: true
toc_hide: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/InputService"><img src="/icons/silk/controller.png"/>&nbsp;InputService</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Service"><img src="/icons/silk/default.png"/>&nbsp;Service</a>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A service for handling input.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="AccelerometerEnabled">AccelerometerEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if an accelerometer is available on the current device.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Misc/Content">Content</a><<a class="type" href="/docs/api-reference/Asset/Image">Image</a>><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CursorId">CursorId</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The icon to use for the custom cursor.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="GamepadEnabled">GamepadEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a gamepad is available on the current device.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="GyroscopeEnabled">GyroscopeEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a gyroscope is available on the current device.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="KeyboardEnabled">KeyboardEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a keyboard is available on the current device.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/MouseBehaviour">MouseBehaviour</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MouseBehaviour">MouseBehaviour</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The mouse behaviour.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MouseEnabled">MouseEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a mouse is available on the current device.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="MouseIconEnabled">MouseIconEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Comment
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="TouchEnabled">TouchEnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the current device has touch support.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="VREnabled">VREnabled</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if a virtual reality headset is available on the current device.
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
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="ClearFocus">ClearFocus</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="DoesGamepadSupport">DoesGamepadSupport</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> gamepadNum, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> keyCode</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines whether the given gamepad supports the given key.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Enum/InputType">InputType</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetConnectedGamepads">GetConnectedGamepads</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> gamepadNum, <a class="type" href="/docs/api-reference/Enum/Key">Key</a> keyCode</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of connected gamepads.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Enum/InputState">InputState</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetGamepadState">GetGamepadState</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> gamepad</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns the <a href="T:Primrose.Enum.InputState" >T:Primrose.Enum.InputState</a> of the given gamepad.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<span><a class="type" href="/docs/api-reference/Enum/Key">Key</a>[]</span><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetPressedKeys">GetPressedKeys</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns an array of currently pressed keys.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsGamepadConnected">IsGamepadConnected</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/InputType">InputType</a> gamepadNum</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the given gamepad is currently connected.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsKeyDown">IsKeyDown</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Enum/Key">Key</a> key</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if the given key is held down.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="IsMouseButtonDown">IsMouseButtonDown</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">int</a> i</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns true if the mouse button for the given number is held down.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="InputBegan">InputBegan</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/InputObject">InputObject</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when an input begins. (Mouse button pressed, key pressed, etc.)
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="InputChanged">InputChanged</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/InputObject">InputObject</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when an input changes. (Mouse move, scroll wheel, etc.)
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="InputEnded">InputEnded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Misc/InputObject">InputObject</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when an input ends. (Mouse button released, key released etc)
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ViewportFocused">ViewportFocused</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the viewport is focused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="ViewportFocusReleased">ViewportFocusReleased</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the viewport is unfocused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WindowFocused">WindowFocused</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the game window is focused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WindowFocusReleased">WindowFocusReleased</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"></span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fires when the game window is unfocused.
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
