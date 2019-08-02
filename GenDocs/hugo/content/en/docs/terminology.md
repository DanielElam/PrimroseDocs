

---
title: "Terminology"
linkTitle: "Terminology"
weight: 2
date: 2019-07-16
description: >
  A guide to the terminology used in Primrose
---

**Instance**
A game object.

**Service**
A singleton game object.

**Part**
A physical `Instance` or "game entity", usually something you can see/touch.

**Model**
An `Instance` for grouping and organizing `Part` instances.

**Asset**
An asset is a piece of content which is stored in the game files. They can be textures, models, sounds, levels, et cetera.

**ContentId**
A URI which points to an asset in the game files e.g. `content://Sounds/Music/BossBattle/A_MyBossBattleTheme.passet`

**Material**
An `Asset` which holds data that determines how an object looks when it is rendered.

**Image**
An `Asset` which holds texture data.

**Audio**
An `Asset` which holds audio data.

**Sound**
An `Instance` which plays `Audio` assets.

**Mesh**
An `Asset` which holds the data for a 3D model.

**Meshlet**
A single section that makes up a `Mesh`. Each `Meshlet` in a model can have its own `Material`.

**StaticMesh**
An instance that renders a `Mesh` asset when parented to a `Part`

**SkeletalMesh**
An `Instance` that renders a skinned `Mesh` asset when parented to a `Part`

**Animator**
An `Instance` which serves as a state machine that loads and manages `AnimationTracks`.

**AnimationTrack**
An `Instance` which plays an `Animation` asset when loaded by an `Animator`.

**Game**
Any object not descendant of `Workspace` is considered part of `Game`, these objects are persistent across level loads.

**Workspace**
Represents the main playable world. Instances are usually loaded from a `Place` and are deleted when the level changes.

**Place**
A game level or map.

**Explorer**
A widget in PrimEd which displays the game object hierarchy tree.

**Properties**
A widget in PrimEd which displays and modifies properties of game objects.