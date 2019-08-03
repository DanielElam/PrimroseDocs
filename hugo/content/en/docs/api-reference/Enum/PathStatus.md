---
title: API:Enum/PathStatus
linkTitle: "PathStatus"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.PathStatus
no_list: true
toc_hide: true
---
<p class="summary">

Enum for the result of <a href="!:PathfindingService.ComputeRawPathAsync" >!:PathfindingService.ComputeRawPathAsync</a>.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Success</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Path was found successfully.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">ClosestNoPath</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Path doesn't exist, returns path to closest point.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">ClosestOutOfRange</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Goal is out of MaxDistance range, returns path to closest point within MaxDistance.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">FailStartNotEmpty</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">3</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Failed to compute path; the starting point is not empty.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">FailFinishNotEmpty</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">4</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Failed to compute path; the finish point is not empty.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">NoPath</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">5</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Path doesn't exist
</p></td>
</tr>
</tbody>
</table>
