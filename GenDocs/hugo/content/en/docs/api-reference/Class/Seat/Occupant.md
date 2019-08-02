---
title: API:Class/Seat/Occupant
linkTitle: "Occupant"
weight: 79
date: 2019-08-02
namespace: Primrose.DataModel.Seat.Occupant
deprecated: false
no_list: true
---
Property of <a href="/docs/api-reference/Class/Seat"><img src="/icons/silk/seat.png"/>&nbsp;Seat</a>
<pre class="method-declaration">
Occupant: <a class="type" href="/docs/api-reference/Class/Character">Character</a></pre>
<b>Value Type: </b>
<a class="type" href="/docs/api-reference/Class/Character">Character</a>
<br/>
<b>Description: </b>
The character that currently occupies this seat.

<b>Notes: </b>
<p class="remarks">
This property can be manually set, which will eject the current occupant if there is one,
and force the new character to sit on it.
</p>
