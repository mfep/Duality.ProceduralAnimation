# Duality.ProceduralAnimation
[![Build status](https://ci.appveyor.com/api/projects/status/vml8qiiaen1wsagf?svg=true)](https://ci.appveyor.com/project/mfep/duality-proceduralanimation)
## Overview
The ProceduralAnimation plugin is a Core Plugin for the [Duality2D](http://duality.adamslair.net/) open source game engine.
It helps to create complex behaviours, mainly on the field of gameObject movement, however other usages are possible too.
The *procedural* word in the name refers to the functional nature of this toolkit:
behaviours (movement) is controlled by mathematical functions.

This means, that unlike most animation tools, there are no keyframes or similar traditional animation methods here.
Despite it may feel intimidating at first, it enables quick iteration over animation sequences,
which are difficult to achieve using the keyframe technique.

'Real-world' examples include:
* Camera/Screenshake - **included in the Samples package**.
* Movement in a tile-based game - **included in the Samples package**.
* Weapon swinging / recoil
* ...

In addition, the plugin has a modular architecture, thus extending it does not require any change to the existing code.

**Please note, that the plugin is in beta state, which means bugs are most likely present, and breaking changes will occur.**

## Features
* Animate `GameObject`s in the scene using functional patterns
* Combine multiple animation methods into animation chains using simple fluent syntax API
* Animation chains can run animations in series, or in a parallel manner, or both combined in one chain
* Define the animation in C# code - no need to learn a different syntax/markup language
* Core only plugin - seriously, who needs a graphical editor?

## [GIFs and code samples](https://github.com/mfep/Duality.ProceduralAnimation/blob/master/samples.md)

## Installation
1. Download the plugin via Duality's package manager.
   It's located in the File menu, select the plugin in from the 'Online Repository' list and click 'Install' then 'Apply'.
2. In your Visual Studio solution add the newly downloaded Plugins\AnimationPlugin.core.dll as a reference.

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
For that, visit the [Class Reference](https://github.com/mfep/Duality.ProceduralAnimation/wiki/Class-Reference) section in the wiki.

### AnimationPlayer
The 'heart' component of the plugin. Inheriting `Component` it have to be attached to a `GameObject`, providing the data flow
between the `GameObject` and the animating functions. Provides an interface to the world to control the animation,
using the self-explanatory `Play`, `Pause`, and `Stop` public methods, as well as additional controls.

Has a reference to an `AnimResource` which is the data holder for the actual animation sequence. More on that in the next paragraph.

### AnimResource
The 'brain' part of the plugin. An abstract class inheriting `Resource`, waiting for you to implement it and fill with your animation.
The single method that needs to be implemented is `InitializePieces`. In this, you need to use the `AnimBuilder` class
to construct the animation chain. More explanation and example below.

### AnimBuider
This class is used to create animation chains. It uses *fluent* syntax for the sake of less typing.
The chain must start with the `Start` method, followed by one or several `Add` methods,
which take an `IAnimPiece` , or an array of them, and the time it will take to complete them.
Don't worry, it's easier when explained with a example:

```csharp
public class MyAnimResource : AnimResource
{
  protected override AnimBuilder InitializePieces ()
  {
    // the chain must be started like this
    return AnimBuilder.Start ()
    // first go from the origin to 500,500 in 3 seconds
    .Add (new SimpleMovement { EndPos = new Vector2 (500, 500) }, 3.0f)
    // after that, go to 1000,0 in 5 seconds, while changing color to blue
    .Add (new IAnimPiece[]
    {
      new SimpleColor { StartColor = ColorRgba.White, EndColor = ColorRgba.Blue },
      new SimpleMovement { StartPos = new Vector2 (500, 500), EndPos = new Vector2 (1000, 0) }
    }, 5.0f);
  }
}
```

### AnimPieces
The building blocks of an animation. There are plenty of 'pieces
ready to use, including the former presented `SimpleMovement` and `SimpleColor` which are - as the name suggests - the
lighter ones, but more convoluted pieces exist, like `PathFollowMovement`, `CustomComponentUpdate`, or `TrigonometricMovement2D`
just to name a few. They all have their parameters and properties documented in the [Class Reference](https://github.com/mfep/Duality.ProceduralAnimation/wiki/Class-Reference), feel free to experiment with them.

Which gives you even more freedom designing your animations is to implement your own AnimPieces. For that, a class is needed
implementing the `IAnimPiece` interface. Here are the two functions of the interface:
* `void Initialize ();` is called every time the animation is started (even when started from a paused state). If you don't have
  anything to do here, just leave the function block empty.
* `void Tick (float pc, GameObject gameObject);` is called in every `OnUpdate ()` of the respecting `AnimationPlayer`.
  The parameter `pc` provides the current 'percent' of the animation, a number between 0 and 1. Thus the AnimPieces don't know
  about the actual time the animation takes, nor about the other animations in the chain.
  
*If you created some new 'pieces, please consider contributing it to this repository.
Ideas for new 'pieces are also very welcome.*
  
### SignalGen
Many AnimPieces have attributes with the type of `SignalGen`. It's a delegate type, which defines a `float` returning
function with a single `float` argument. These enable an advanced feature of the toolkit: to modulate the AnimPiece's
parameters over time using an arbitrary mathemathical function. These functions always get `pc`, the animation percent as 
input, and usually multiply their respecting parameter with their return value.
An example: One would like to create a spinning animation, but with increasing angular velocity over time. For that
the `Rotate` AnimPiece.

```csharp
public class SpeedupRotation : AnimResource
{
  protected override AnimBuilder InitializePieces ()
  {
    return AnimBuilder.Start ()
    // default frequency is 1, which means 1 rotation over the animation
    // the frequency is multiplied by FrequencyGen (pc)
    // in this example, the frequency starts at 1, and to the end of the animation (which takes 3 seconds)
    // it linearly grows to 2
    .Add (new Rotate { FrequencyGen = x => x + 1, 3.0f)
  }
}
```

### Utils
is a static class providing helper functions to create `SignalGen` functions. A trivial example would be to use the `Utils.Linear` function in the former code sample:

```csharp
    .Add (new Rotate { FrequencyGen = Utils.Linear (/*multiplier=*/ 1, /*offset=*/ 1), 3.0f)
```
Of course, there are more complicated functions in `Utils`, such as trigonometric and exponential ones.
