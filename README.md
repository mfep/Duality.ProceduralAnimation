# Duality.ProceduralAnimation
## Overview
The ProceduralAnimation plugin is a Core Plugin for the [Duality2D](http://duality.adamslair.net/) open source game engine.
It helps to create complex behaviours, mainly on the field of gameObject movement, however other usages are possible too.
The *procedural* word in the name refers to the functional nature of this toolkit:
behaviours (movement) is controlled by mathematical functions.

This means, that unlike most animation tools, there are no keyframes or similar traditional animation methods here.
Despite it may feel intimidating at first, it enables quick iteration over animation sequences,
which are difficult to achieve using the keyframe technique.

'Real-world' examples include (these examples are not added to the repo yet):
* Camera/Screenshake.
* Movement in a tile-based game.
* Weapon swinging / recoil
* ...

In addition, the plugin has a modular architecture, thus extending it does not require any change to the existing code.

## Parts of the system
The repo consists of two Visual Studio projects, thus two NuGet packages are available in Duality's package manager.

The **AnimationPlugin** project contains the basic structure of the plugin, and some 'extras', useful, but not essential `Components`.
The namespace of this project is `MFEP.Duality.Plugins.Animation`.

The **AnimationPlugin.Sample** project depends on the former one, and contains examples showcasing every feature of the plugin.
The namespace of this project is `MFEP.Duality.Plugins.Animation.Sample`. More information about the samples can be found in the wiki.

## Essential Classes
The following paragraph describes the basic building blocks, and the inner workings of the plugin.
However it does not describe any Duality concepts, so if you are not familiar with the engine, please take a look at [Duality's wiki](https://github.com/AdamsLair/duality/wiki).

Note, that this is just a quick overview to get familiar with the tool, and not every class member/method is mentioned here.
For that, visit the Class Reference section in the wiki.

### AnimationPlayer
The heart component of the plugin. Inheriting `Component` it have to be attached to a `GameObject`, providing the data flow
between the `GameObject` and the animating functions. Provides an interface to the world to control the animation,
using the self-explanatory `Play`, `Pause`, and `Stop` public methods, as well as additional controls.

Has a reference to an `AnimResource` which is the data holder for the actual animation sequence. More on that in the next paragraph.
