---
title: API:Enum/GraphicsMode
linkTitle: "GraphicsMode"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.GraphicsMode
no_list: true
toc_hide: true
---
<p class="summary">

Enumeration for graphics modes.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Automatic</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Will automatically choose a supported library for the current platform.
Windows 10 defaults to Direct3D12.
Windows 7 defaults to Direct3D11.
macOS and iOS default to Metal.
Linux defaults to Vulkan.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">NoGraphics</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Disables the rendering engine. This will also prevent content like audio and textures from being downloaded.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Direct3D11</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Direct3D Version 11 (Microsoft)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Direct3D12</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">3</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Direct3D Version 12 (Microsoft)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Vulkan</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">4</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Vulkan (Khronos Group)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Metal</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">5</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Metal (Apple)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Playstation4</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">6</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Playstation 4 (Sony)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">XboxOne</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">7</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Xbox One (Microsoft)
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Switch</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">8</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Switch (Nintendo)
</p></td>
</tr>
</tbody>
</table>
