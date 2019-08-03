---
title: API:Enum/CascadePartitionMode
linkTitle: "CascadePartitionMode"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.CascadePartitionMode
no_list: true
toc_hide: true
---
<p class="summary">

The cascade partitioning method.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Manual</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Use manually defined splits.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Logarithmic</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Use a logarithmic algorithm to determine splits.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">ParallelSplit</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Use the PSSM algorithm to determine splits.
</p></td>
</tr>
</tbody>
</table>
