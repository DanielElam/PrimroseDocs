
---
title: "Getting Started"
linkTitle: "Getting Started"
weight: 1
date: 2019-07-16
description: >
  This page tells you how to get started with Primrose, including building and basic configuration.
---
## Prerequisites

### Install .NET Core 3.0
Primrose is kept up to data with the latest developer previews for .NET Core. You can download the latest preview [here.](https://dotnet.microsoft.com/download/dotnet-core/3.0)
{{< alert color="warning" title="Note" >}}.NET Core 3.0 should be used with the latest previews of Visual Studio.
Use the latest preview of Visual Studio 2019 installed from the [Visual Studio preview channel](https://visualstudio.microsoft.com/vs/preview/). Other versions of Visual Studio 2019 are not recommended, but you can enable [.NET Core SDK previews](https://devblogs.microsoft.com/dotnet/net-core-tooling-update-for-visual-studio-2017-version-15-9/) in Visual Studio.
{{< /alert >}}

## Setting up Primrose
1. Clone the the repository: <br/> `git clone https://github.com/DanielElam/Primrose.git`
2. Open Primrose.sln in Visual Studio
3. Click `Build > Build Solution` or press F6.
4. Select Editor in the startup projects toolbar
5. Run the program


## Projects

- **Editor**
This is the PrimEd level editor. It is the equivalent of ROBLOX Studio. It is written in C# using WPF.
- **Engine**
This is the main engine library. It is written in C#.
- **Engine.Interop**
This project serves as an interface for the **Engine.Native** library. It is written in C#.
- **Engine.Native**
This is a native helper library, primarily used for interfacing with other native libraries. It is written in C++.
- **GameTest**
This is a sandbox for quickly testing engine features. It is written in C#.
- **Pipeline**
This is the content pipeline processing tool. It is written in C#.
- **GenDocs**
Dumps the API in a JSON format and generates the API reference documentation pages. Written in F#.
- **Tinkerbell**
A debug program that monitors the launched application for crash reporting. Written in C#.


## See Also

<div class="section-index">
   <hr class="panel-line">
   <div class="entry">
      <h5>
         <a href="/docs/editor/">Editor</a>
      </h5>
      <p>A guide for the level editor <i>PrimEd</i>.</p>
   </div>
</div>
