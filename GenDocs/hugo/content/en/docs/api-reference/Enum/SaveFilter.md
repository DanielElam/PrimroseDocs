---
title: API:Enum/SaveFilter
linkTitle: "SaveFilter"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.SaveFilter
no_list: true
---
<p class="summary">

Enum for filtering the save of <a href="/docs/api-reference/Class/Game/" >Game</a> and <a href="/docs/api-reference/Class/Workspace/" >Workspace</a>
</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">SaveWorld</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Only save the Workspace.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">SaveGame</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Only save the DataModel.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">SaveTogether</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Save DataModel with Workspace to the same stream. (No callbacks invoked.)
</p></td>
</tr>
</tbody>
</table>
