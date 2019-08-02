---
title: API:Enum/WordWrapping
linkTitle: "WordWrapping"
weight: 4
date: 2019-08-02
namespace: Primrose.Enum.WordWrapping
no_list: true
---
<p class="summary">

Word wrapping modes.

</p>
 
## Values
 
<table class="studiohide">
<tbody>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Wrap</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">0</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Indicates that words are broken across lines to avoid text overflowing the layout box.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">NoWrap</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">1</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Indicates that words are kept within the same line even when it overflows the layout box. This option is often used
with scrolling to reveal overflow text.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">EmergencyBreak</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">2</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Words are broken across lines to avoid text overflowing the layout box. Emergency wrapping occurs if the word is larger
than the maximum width.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">WholeWord</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">3</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
When emergency wrapping, only wrap whole words, never breaking words when the layout width is too small for even a
single word.
</p></td>
</tr>
<tr class="enum-row">
<td style="vertical-align:top;white-space:normal;">
<span class="name"">Character</span></td>
<td style="vertical-align:top;white-space:normal;">
<b class="value"">4</b></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Wrap between any valid character clusters.
</p></td>
</tr>
</tbody>
</table>
