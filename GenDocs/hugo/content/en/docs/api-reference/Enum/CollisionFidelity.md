---
title: API:Enum/CollisionFidelity
linkTitle: "CollisionFidelity"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.CollisionFidelity
no_list: true
---
<p class="summary">

Determines how the collision models of a <a href="/docs/api-reference/Class/PartOperation/" >PartOperation</a> behave.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Default</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">ConvexHull</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Uses a convex hull for collision.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">BoundingBox</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Uses a bounding box for collision.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Triangle</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">3</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Uses a provided mesh for collision.
</p></td>
</tr>
</tbody>
</table>
