---
title: API:DataType/CFrame
linkTitle: "CFrame"
weight: 5
date: 2019-07-14
namespace: Primrose.CFrame
no_list: true
---
A rigid body RT (rotation-translation) transformation.
 
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
        <td class="data-type-name">CFrame()</td>
        <td>Creates a new CFrame with zero for all values. This is not a valid value, see <b>CFrame.Identity</b>.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(pos: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>)</td>
        <td>Creates a CFrame with a Vec3 position.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(pos: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>, lookAt: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>)</td>
        <td>Creates a CFrame positioned at <code>pos</code> looking towards <code>lookAt</code>.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(pos: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>, rotation: <a href="/docs/api-reference/DataType/Quat">Quat</a>)</td>
        <td>Creates a CFrame from a vector position and quaternion rotation.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(pos: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>, rotation: <a href="/docs/api-reference/DataType/Mat3">Mat3</a>)</td>
        <td>Creates a CFrame from a vector position and matrix rotation.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(x: <a href="/docs/api-reference/System/Primitives#single">float32</a>, y: <a href="/docs/api-reference/System/Primitives#single">float32</a>, z: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a CFrame from position <code>(x, y, z)</code>.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(x: <a href="/docs/api-reference/System/Primitives#single">float32</a>, y: <a href="/docs/api-reference/System/Primitives#single">float32</a>, z: <a href="/docs/api-reference/System/Primitives#single">float32</a>, qX: <a href="/docs/api-reference/System/Primitives#single">float32</a>, qY: <a href="/docs/api-reference/System/Primitives#single">float32</a>, qZ: <a href="/docs/api-reference/System/Primitives#single">float32</a>, qW: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a CFrame from position <code>(x, y, z)</code> and quaternion <code>(qX, qY, qZ, qW)</code></td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame(x: <a href="/docs/api-reference/System/Primitives#single">float32</a>, y: <a href="/docs/api-reference/System/Primitives#single">float32</a>, z: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r11: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r12: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r13: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r21: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r22: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r23: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r31: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r32: <a href="/docs/api-reference/System/Primitives#single">float32</a>, r33: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>
            Creates a CFrame from position (x, y, z) and rotation matrix
            <div style="vertical-align:middle; display: inline-block; margin: 6px; position: relative">
<div style="position: absolute; top: -4px; left: -5px; bottom: -4px; border: 1px solid black; border-right: none; width:10px"></div>
<div style="position: absolute; top: -4px; right: -5px; bottom: -4px; border: 1px solid black; border-left: none; width:10px"></div>
<table style="text-align: center; font-size: 10px; line-height:10px" cellspacing="5" cellpadding="0">

<tbody><tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>11</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>12</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>13</sub>
</td></tr>
<tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>21</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>22</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>23</sub>
</td></tr>
<tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>31</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>32</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>33</sub>
</td></tr></tbody></table>
</div>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame.fromAxisAngle(axis: <a href="/docs/api-reference/DataType/Vec3">Vec3</a>, angle: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a rotated CFrame from a unit Vec3 and a rotation in radians.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame.Angles(pitch: <a href="/docs/api-reference/System/Primitives#single">float32</a>, yaw: <a href="/docs/api-reference/System/Primitives#single">float32</a>, roll: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Same as <b>AnglesYXZ</b>.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame.AnglesXYZ(pitch: <a href="/docs/api-reference/System/Primitives#single">float32</a>, yaw: <a href="/docs/api-reference/System/Primitives#single">float32</a>, roll: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a rotated CFrame using euler angles (pitch, yaw, roll) in radians. Rotations are applied in X, Y, Z order.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame.AnglesYXZ(pitch: <a href="/docs/api-reference/System/Primitives#single">float32</a>, yaw: <a href="/docs/api-reference/System/Primitives#single">float32</a>, roll: <a href="/docs/api-reference/System/Primitives#single">float32</a>)</td>
        <td>Creates a rotated CFrame using euler angles (pitch, yaw, roll) in radians. Rotations are applied in Y, X, Z order.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame.Identity</td>
        <td>Gets a CFrame that is equal to the identity matrix.</td>
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
        <td class="data-type-name">p: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The 3D position of the CFrame.</td>
    </tr>
    <tr>
        <td class="data-type-name">rotation: <a class="type" href="/docs/api-reference/DataType/Mat3">Mat3</a></td>
        <td>The orientation matrix of the CFrame.</td> 
    </tr>
    <tr>
        <td class="data-type-name">x: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The x-component of the Vec3 position.</td>
    </tr>
    <tr>
        <td class="data-type-name">y: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The y-component of the Vec3 position.</td>
    </tr>
    <tr>
        <td class="data-type-name">z: <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
        <td>The z-component of the Vec3 position.</td>
    </tr>
    <tr>
        <td class="data-type-name">lookVector: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>Same as <b>forward</b></td>
    </tr>
    <tr>
        <td class="data-type-name">forward: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The forward-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">backward: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The backward-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">left: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The left-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">right: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The right-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">up: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The up-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">down: <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
        <td>The down-direction component of the CFrame's orientation.</td>
    </tr>
    <tr>
        <td class="data-type-name">isZero: <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a></td>
        <td>Determines if the vector is zero.</td>
    </tr>
    <tr>
        <td class="data-type-name">isIdentity: <a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a></td>
        <td>Determines if the CFrame is equal to the identity matrix.</td>
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
        <td class="data-type-name">CFrame:inverse() -> <b>CFrame</b></td>
        <td>Returns the inverse of the CFrame.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:lerp(goal: <span class="param">CFrame</span>, alpha: <a href="/docs/api-reference/System/Primitives#single">float32</a>) -> <b>CFrame</a></td>
        <td>Returns a CFrame interpolated between this CFrame, and the goal CFrame, by the fraction alpha.</td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:toWorldSpace(cf: <span class="param">CFrame</span>) -> <b>CFrame</a></td>
        <td>Returns <code>cf</code> transformed from Object to World coordinates. Equivalent to <code>CFrame * cf</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:toObjectSpace(cf: <span class="param">CFrame</span>) -> <b>CFrame</a></td>
        <td>Returns <code>cf</code> transformed from World to Object coordinates. Equivalent to <code>CFrame.inverse() * cf</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:pointToWorldSpace(v3: <a class="param" href="/docs/api-reference/DataType/Vec3">Vec3</a>) -> <b>CFrame</b></td>
        <td>
        Returns a Vec3 transformed from Object to World coordinates. Equivalent to <code>CFrame * v3</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:pointToObjectSpace(v3: <a class="param" href="/docs/api-reference/DataType/Vec3">Vec3</a>) -> <b>CFrame</b></td>
        <td>
        Returns a Vec3 transformed from World to Object coordinates. Equivalent to <code>CFrame.inverse() * v3</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:vectorToWorldSpace(v3: <a class="param" href="/docs/api-reference/DataType/Vec3">Vec3</a>) -> <b>CFrame</b></td>
        <td>
        Returns a Vector3 rotated from Object to World coordinates. Equivalent to <code>(CFrame-CFrame.p) * v3</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:vectorToObjectSpace(v3: <a class="param" href="/docs/api-reference/DataType/Vec3">Vec3</a>) -> <b>CFrame</b></td>
        <td>
        Returns a Vector3 rotated from World to Object coordinates. Equivalent to <code>(CFrame-CFrame.p).inverse() * v3</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:components() -> <a class="type" href="/docs/api-reference/System/Tuple">Tuple</a>&lt;<a class="type" href="/docs/api-reference/System/Primitives#single">float32</a>&gt;</td>
        <td>
        Returns the values: x, y, z, R11, R12, R13, R21, R22, R23, R31, R32, R33 where
        <div style="display: inline-block"><div style="vertical-align:middle; display: inline-block; height:30px; border: 1px solid black; border-right: none; width:2px; margin-right:-2px;"></div><div style="vertical-align:middle; display: inline-block; height:30px; min-width:10px; font-size: 8px; line-height:10px; text-align: center"><div style="height: 10px;">x</div><div style="height: 10px;">y</div><div style="height: 10px;">z</div></div><div style="vertical-align: middle; display: inline-block; height:30px; border: 1px solid black; border-left: none; width:2px; margin-left:-2px;"></div></div> 
        is the position and
<div style="vertical-align:middle; display: inline-block; margin: 6px; position: relative">
<div style="position: absolute; top: -4px; left: -5px; bottom: -4px; border: 1px solid black; border-right: none; width:10px"></div>
<div style="position: absolute; top: -4px; right: -5px; bottom: -4px; border: 1px solid black; border-left: none; width:10px"></div>
<table style="text-align: center; font-size: 10px; line-height:10px" cellspacing="5" cellpadding="0">

<tbody><tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>11</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>12</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none; min-width: 15px"> R<sub>13</sub>
</td></tr>
<tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>21</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>22</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>23</sub>
</td></tr>
<tr style="height: 15px">
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>31</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>32</sub>
</td>
<td style="vertical-align:middle; padding: 0; border: none"> R<sub>33</sub>
</td></tr></tbody></table>
</div>
is the rotation.
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:toQuaterion() -> <a class="type" href="/docs/api-reference/DataType/Quat">Quat</a></td>
        <td>
        Returns the rotation of the CFrame as a quaternion.</code>
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:toEulerAnglesXYZ() -> <b>CFrame</b></td>
        <td>
        Returns the best guess angles that could be used to generate a CFrame using <b>CFrame.AnglesXYZ</b>.
        </td>
    </tr>
    <tr>
        <td class="data-type-name">CFrame:toEulerAnglesYXZ() -> <b>CFrame</b></td>
        <td>
        Returns the best guess angles that could be used to generate a CFrame using <b>CFrame.AnglesYXZ</b>.
        </td>
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
            <td class="data-type-name"><span><b>CFrame</b> * <b>CFrame</b></span></td>
            <td>Returns the composition of two CFrames. Proceeding CFrames are offsetted in relative object space by preceding CFrames when multiplied together.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>CFrame</b> * <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
            <td>Returns Vector3 transformed from Object to World coordinates.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>CFrame</b> * <a class="type" href="/docs/api-reference/System/Primitives#single">float32</a></td>
            <td>Returns CFrame with components scaled by float32.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>CFrame</b> + <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
            <td>Returns CFrame translated in world space by Vec3.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>CFrame</b> - <a class="type" href="/docs/api-reference/DataType/Vec3">Vec3</a></td>
            <td>Returns CFrame translated in world space by -Vec3.</td>
        </tr>
        <tr>
            <td class="data-type-name"><b>-CFrame</b></td>
            <td>Returns an inverse of the CFrame.</td>
        </tr>
    </tbody>
</table>

## See also
- [Vec3](/docs/api-reference/DataType/Vec3)
- [Part](/docs/api-reference/Class/Part)
- [Properties](/docs/editor/Widgets/Properties)
- [Vec2](/docs/api-reference/DataType/Vec2)
