---
title: API:Enum/WindowMode
linkTitle: "WindowMode"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.WindowMode
no_list: true
toc_hide: true
---
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Windowed</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The game will be rendered in a resizeable window.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Fullscreen</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The window will take up the entire screen, and the GPU driver will be given full control of the screen.
This can make switching windows difficult.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Borderless</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The window will take up the entire screen, but will be rendered by the desktop manager.
This make switching between windows easy, but may degrade performance.
</p></td>
</tr>
</tbody>
</table>
