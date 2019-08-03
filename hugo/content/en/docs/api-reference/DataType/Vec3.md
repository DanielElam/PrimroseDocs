---
title: API:DataType/Vec3
linkTitle: "Vec3"
weight: 3
date: 2019-07-14
namespace: Primrose.Vec3
no_list: true
toc_hide: true
---
Represents a point in 3D space with 32-bit floating-point precision

## Quick Reference

<table>
    <b style="
    padding: 14px 11px;
    display: block;
    font-weight: 300;
    font-size: 17pt;">Constructors</b>
    <thead>
        <tr>
        <th>Syntax</th>
        <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
        <td class="data-type-name">Vec3()</td>
        <td>Creates a new Vec3 with X, Y, and Z values of 0.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3(x: <a href="/docs/api-reference/System/Primitives#single">float32</a>, y: <a href="/docs/api-reference/System/Primitives#single">float32</a>, z: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a new Vec3 with the X, Y, and Z values specified.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.FromNormalId(norm: <a href="/docs/api-reference/Enum/NormalId">NormalId</a>)</td>
        <td>Creates a unit Vec3 in a particular facing direction.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.FromAxis(axis: <a href="/docs/api-reference/Enum/Axis">Axis</a>)</td>
        <td>Creates a unit Vec3 for a particular Axis.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Up</td>
        <td>Shorthand for <code>Vec3(0, 1, 0)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Down</td>
        <td>Shorthand for <code>Vec3(0, -1, 0)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Left</td>
        <td>Shorthand for <code>Vec3(-1, 0, 0)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Right</td>
        <td>Shorthand for <code>Vec3(1, 0, 0)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Forward</td>
        <td>Shorthand for <code>Vec3(0, 0, -1)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.Backward</td>
        <td>Shorthand for <code>Vec3(0, 0, 1)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3.One</td>
        <td>Shorthand for <code>Vec3(1, 1, 1)</code></td>
    </tr>
    </tbody>
</table>

<table>
    <b style="
    padding: 14px 11px;
    display: block;
    font-weight: 300;
    font-size: 17pt;">Properties</b>
    <thead>
        <tr>
        <th>Syntax</th>
        <th>Description</th>
        </tr>
    </thead>
    <tbody>
    <tr>
        <td class="data-type-name">x: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The x-coordinate.</td>
    </tr>
    <tr>
        <td class="data-type-name">y: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The y-coordinate.</td>
    </tr>
    <tr>
        <td class="data-type-name">z: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The z-coordinate.</td>
    </tr>
    <tr>
        <td class="data-type-name">unit: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>A normalized copy of the vector with the same direction as the original, but a magnitude of 1.</td>
    </tr>
    <tr>
        <td class="data-type-name">magnitude: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The length of the vector.</td>
    </tr>
    <tr>
        <td class="data-type-name">squaredMagnitude: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The length of the vector squared.</td>
    </tr>
    <tr>
        <td class="data-type-name">isZero: <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a></td>
        <td>Determines if the vector is zero.</td>
    </tr>
    </tbody>
</table>

<table>
    <b style="
    padding: 14px 11px;
    display: block;
    font-weight: 300;
    font-size: 17pt;">Functions</b>
    <thead>
        <tr>
        <th>Syntax</th>
        <th>Description</th>
        </tr>
    </thead>
    <tbody>
    <tr>
        <td class="data-type-name">Vec3:lerp(goal: <span class="param">Vec3</span>, alpha: <a href="/docs/api-reference/System/Primitives#single">float32</a>) -> <b>Vec3</b></td>
        <td>Returns a Vec3 linearly interpolated between the original value and <code>goal</code>.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:dot(other: <span class="param">Vec3</span>) -> <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>Returns the scalar dot product of the two vectors.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:cross(other: <span class="param">Vec3</span>) -> <b>Vec3</b></td>
        <td>Returns the vector cross product of the two vectors.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:isClose(other: <span class="param">Vec3</span>, epsilon: <a href="/docs/api-reference/System/Primitives#single">float32</a>) <span style="display: inline-block">-></span> <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a></td>
        <td>Returns true if all three axis values of the given Vec3 are within the given epsilon.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:min() <span style="display: inline-block">-></span> <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>Returns the smallest component of the vector.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:max() <span style="display: inline-block">-></span> <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>Returns the largest component of the vector.</td>
    </tr>
    <tr>
        <td class="data-type-name">Vec3:abs() <span style="display: inline-block">-></span> <b>Vec3</b></td>
        <td>Returns the vector with positive components.</td>
    </tr>
    </tbody>
</table>


<table>
    <b style="
    padding: 14px 11px;
    display: block;
    font-weight: 300;
    font-size: 17pt;">Operators</b>
    <thead>
        <tr>
        <th>Syntax</th>
        <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td class="data-type-name"><b>Vec3</b> + <b>Vec3</b></td>
            <td>Returns a new Vec3 with each component of the second added to the corresponding component of the first.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>Vec3</b> - <b>Vec3</b></td>
            <td>Returns a new Vec3 with each component of the second subtracted from the corresponding component of the first.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>Vec3</b> * <b>Vec3</b></td>
            <td>Returns a new Vec3 with each component of the second multiplied the corresponding component of the first.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>Vec3</b> / <b>Vec3</b></td>
            <td>Returns a new Vec3 with each component of the first divided by the corresponding component of the second.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>Vec3</b> * <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></b></td>
            <td>Returns a new Vec3 with each component multiplied by the number.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>Vec3</b> / <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></b></td>
            <td>Returns a new Vec3 with each component divided by the number.</td>
        </tr>
        <tr>
            <td class="data-type-name"><a class="type" href="/docs/api-reference/System/Primitives#single">float32</a> * <b>Vec3</b></b></td>
            <td>Returns a new Vec3 with each component multiplied by the number.</td>
        </tr>
        <tr>
            <td class="data-type-name"><a class="type" href="/docs/api-reference/System/Primitives#single">float32</a> / <b>Vec3</b></b></td>
            <td>Returns a new Vec3 with each component divided by the number.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>-Vec3</b></td>
            <td>Returns an inverse of the vector.</td>
        </tr>
    </tbody>
</table>

## See also
- [CFrame](/docs/api-reference/DataType/CFrame)
- [Part](/docs/api-reference/Class/Part)
- [Properties](/docs/editor/Widgets/Properties)
- [Vec2](/docs/api-reference/DataType/Vec2)
