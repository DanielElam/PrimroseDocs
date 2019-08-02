---
title: API:Class/ScriptDebugger
linkTitle: "ScriptDebugger"
weight: 4
date: 2019-08-02
explorerImage: script_module
namespace: Primrose.DataModel.Scripting.ScriptDebugger
deprecated: false
no_list: true
---
<small class="inheritance">
<span class="" href="/docs/api-reference/Class/ScriptDebugger"><img src="/icons/silk/script_module.png"/>&nbsp;ScriptDebugger</span>&nbsp;:&nbsp;<a class="" href="/docs/api-reference/Class/Instance"><img src="/icons/silk/default.png"/>&nbsp;Instance</a></small>
<p class="summary">

A debug system for a script.

</p>
 
## Properties
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="CurrentLine">CurrentLine</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The current line that the script is on.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Primitives#boolean">bool</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="IsPaused">IsPaused</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Determines if the script is paused.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/SourceCodeContainer">SourceCodeContainer</a><span class="method-body" style="text-indent: -2em; padding-left: 0.5em"><a class="name" href="Script">Script</a></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
The script this debugger is attached to.
</p></td>
</tr>

</tbody>
</table>
 
## Functions
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/DebuggerWatch">DebuggerWatch</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="AddWatch">AddWatch</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> expression</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Adds a watch to the debugger.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/IEnumerable">IEnumerable</a><<a class="type" href="/docs/api-reference/Class/DebuggerBreakpoint">DebuggerBreakpoint</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetBreakpoints">GetBreakpoints</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of breakpoints.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetGlobals">GetGlobals</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns all global variables in the script.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/Dictionary">Dictionary</a><<a class="type" href="/docs/api-reference/System/string">string</a>, <a class="type" href="/docs/api-reference/System/object">object</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetLocals">GetLocals</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns all local variables in the script.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/string">string</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetStackTrace">GetStackTrace</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Exception">Exception</a> e = <i>null</i></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
</td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/IEnumerable">IEnumerable</a><<a class="type" href="/docs/api-reference/Class/DebuggerWatch">DebuggerWatch</a>><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="GetWatches">GetWatches</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"></span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Returns a list of watches.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/Class/DebuggerBreakpoint">DebuggerBreakpoint</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetBreakpoint">SetBreakpoint</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#int32">i32</a> line</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Adds a breakpoint to the debugger.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<div>
<a class="type" href="/docs/api-reference/System/void">void</a><span class="method-body" style="text-indent: -2em;"><a class="method-name  " href="SetGlobal">SetGlobal</a></span><span style="display: inline-block">( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/string">string</a> key, <a class="type" href="/docs/api-reference/System/object">object</a> value</span> )</span></span></div></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Sets a global variable.
</p></td>
</tr>

</tbody>
</table>
 
## Events
 
<table class="studiohide">
<tbody>
<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="BreakpointAdded">BreakpointAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/DebuggerBreakpoint">DebuggerBreakpoint</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a breakpoint is added to the script.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="BreakpointRemoved">BreakpointRemoved</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/DebuggerBreakpoint">DebuggerBreakpoint</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a breakpoint is removed from the script.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="EncounteredBreak">EncounteredBreak</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/DebuggerBreakpoint">DebuggerBreakpoint</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a breakpoint is hit.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="Resuming">Resuming</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/System/Primitives#double">f64</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a script resumes after a break.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WatchAdded">WatchAdded</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/DebuggerWatch">DebuggerWatch</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a watch is added.
</p></td>
</tr>

<tr class="function-row ">
<td style="vertical-align:top;white-space:normal;">
<span class="event-body" style="text-indent: -2em; padding-left: 0.5em"><a class="event-name " href="WatchRemoved">WatchRemoved</a></span><span style="display: inline-block">&nbsp;( <span class="param" style="white-space: nowrap"><a class="type" href="/docs/api-reference/Class/DebuggerWatch">DebuggerWatch</a> p0</span> )</span></span></td>
<td style="vertical-align:top;white-space:normal;">
<p>
Fired when a watch is removed.
</p></td>
</tr>

</tbody>
</table>
<b>
</b>
<div class="inheritors">
<ul class="root">
</ul>
</div>
