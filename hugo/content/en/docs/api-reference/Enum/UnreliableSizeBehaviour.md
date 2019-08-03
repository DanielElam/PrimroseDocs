---
title: API:Enum/UnreliableSizeBehaviour
linkTitle: "UnreliableSizeBehaviour"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.UnreliableSizeBehaviour
no_list: true
toc_hide: true
---
<p class="summary">

Enum of behaviours for large, unreliable messages.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">IgnoreMTU</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sending an unreliable message will ignore MTU and send everything in a single packet.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">NormalFragmentation</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Use normal fragmentation for unreliable messages - if a fragment is dropped, memory for received fragments are never
reclaimed.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">DropAboveMTU</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Alternate behaviour; just drops unreliable messages above MTU.
</p></td>
</tr>
</tbody>
</table>
