<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [AnimationPlayer](#T-MFEP-Duality-Plugins-Animation-AnimationPlayer 'MFEP.Duality.Plugins.Animation.AnimationPlayer')
  - [Animation](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Animation 'MFEP.Duality.Plugins.Animation.AnimationPlayer.Animation')
  - [AutoPlay](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-AutoPlay 'MFEP.Duality.Plugins.Animation.AnimationPlayer.AutoPlay')
  - [IsPlaying](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-IsPlaying 'MFEP.Duality.Plugins.Animation.AnimationPlayer.IsPlaying')
  - [Looping](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Looping 'MFEP.Duality.Plugins.Animation.AnimationPlayer.Looping')
  - [Percent](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Percent 'MFEP.Duality.Plugins.Animation.AnimationPlayer.Percent')
  - [PlaybackLength](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackLength 'MFEP.Duality.Plugins.Animation.AnimationPlayer.PlaybackLength')
  - [PlaybackRate](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackRate 'MFEP.Duality.Plugins.Animation.AnimationPlayer.PlaybackRate')
- [AnimBuilder](#T-MFEP-Duality-Plugins-Animation-AnimBuilder 'MFEP.Duality.Plugins.Animation.AnimBuilder')
  - [AddParallel(pieces,time)](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddParallel-MFEP-Duality-Plugins-Animation-IAnimPiece[],System-Single- 'MFEP.Duality.Plugins.Animation.AnimBuilder.AddParallel(MFEP.Duality.Plugins.Animation.IAnimPiece[],System.Single)')
  - [AddSingle(piece,time)](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddSingle-MFEP-Duality-Plugins-Animation-IAnimPiece,System-Single- 'MFEP.Duality.Plugins.Animation.AnimBuilder.AddSingle(MFEP.Duality.Plugins.Animation.IAnimPiece,System.Single)')
  - [Start()](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-Start 'MFEP.Duality.Plugins.Animation.AnimBuilder.Start')
- [AnimControllerComp](#T-MFEP-Duality-Plugins-Animation-Extras-AnimControllerComp 'MFEP.Duality.Plugins.Animation.Extras.AnimControllerComp')
- [AnimResource](#T-MFEP-Duality-Plugins-Animation-AnimResource 'MFEP.Duality.Plugins.Animation.AnimResource')
- [CallbackProvider](#T-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider 'MFEP.Duality.Plugins.Animation.AnimPieces.CallbackProvider')
  - [Callback](#P-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider-Callback 'MFEP.Duality.Plugins.Animation.AnimPieces.CallbackProvider.Callback')
- [CustomComponentUpdate](#T-MFEP-Duality-Plugins-Animation-AnimPieces-CustomComponentUpdate 'MFEP.Duality.Plugins.Animation.AnimPieces.CustomComponentUpdate')
- [IAnimPiece](#T-MFEP-Duality-Plugins-Animation-IAnimPiece 'MFEP.Duality.Plugins.Animation.IAnimPiece')
- [LerpNoiseMovement](#T-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement')
  - [Amplitude](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Amplitude 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.Amplitude')
  - [AmplitudeGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-AmplitudeGen 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.AmplitudeGen')
  - [Direction](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Direction 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.Direction')
  - [Frequency](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Frequency 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.Frequency')
  - [FrequencyGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-FrequencyGen 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.FrequencyGen')
  - [Relative](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Relative 'MFEP.Duality.Plugins.Animation.AnimPieces.LerpNoiseMovement.Relative')
- [PathFollowMovement](#T-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement')
  - [Closed](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Closed 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.Closed')
  - [ConstantVelocity](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-ConstantVelocity 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.ConstantVelocity')
  - [OverSpeedGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-OverSpeedGen 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.OverSpeedGen')
  - [PathVertices](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-PathVertices 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.PathVertices')
  - [Relative](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Relative 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.Relative')
  - [SegmentSpeedGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-SegmentSpeedGen 'MFEP.Duality.Plugins.Animation.AnimPieces.PathFollowMovement.SegmentSpeedGen')
- [PathVisualizer](#T-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer 'MFEP.Duality.Plugins.Animation.Extras.PathVisualizer')
  - [Color](#P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-Color 'MFEP.Duality.Plugins.Animation.Extras.PathVisualizer.Color')
  - [FollowedFrames](#P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-FollowedFrames 'MFEP.Duality.Plugins.Animation.Extras.PathVisualizer.FollowedFrames')
- [ProceduralAnimationCorePlugin](#T-MFEP-Duality-Plugins-Animation-ProceduralAnimationCorePlugin 'MFEP.Duality.Plugins.Animation.ProceduralAnimationCorePlugin')
- [Rotate](#T-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate 'MFEP.Duality.Plugins.Animation.AnimPieces.Rotate')
  - [Frequency](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Frequency 'MFEP.Duality.Plugins.Animation.AnimPieces.Rotate.Frequency')
  - [FrequencyGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-FrequencyGen 'MFEP.Duality.Plugins.Animation.AnimPieces.Rotate.FrequencyGen')
  - [Relative](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Relative 'MFEP.Duality.Plugins.Animation.AnimPieces.Rotate.Relative')
- [SimpleColor](#T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleColor')
  - [ColorGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-ColorGen 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleColor.ColorGen')
  - [EndColor](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-EndColor 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleColor.EndColor')
  - [StartColor](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-StartColor 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleColor.StartColor')
- [SimpleMovement](#T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleMovement')
  - [EndPos](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-EndPos 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleMovement.EndPos')
  - [PosGen](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-PosGen 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleMovement.PosGen')
  - [Relative](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-Relative 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleMovement.Relative')
  - [StartPos](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-StartPos 'MFEP.Duality.Plugins.Animation.AnimPieces.SimpleMovement.StartPos')
- [Wait](#T-MFEP-Duality-Plugins-Animation-AnimPieces-Wait 'MFEP.Duality.Plugins.Animation.AnimPieces.Wait')

<a name='assembly'></a>
# AnimationPlugin.core [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-MFEP-Duality-Plugins-Animation-AnimationPlayer'></a>
## AnimationPlayer [#](#T-MFEP-Duality-Plugins-Animation-AnimationPlayer 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation

##### Summary

Loads and plays AnimResources on the GameObject. Manages the animation's state, and provides interface to control it (Play, Pause, Stop).

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Animation'></a>
### Animation `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Animation 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The AnimResource that is played. Default is null

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-AutoPlay'></a>
### AutoPlay `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-AutoPlay 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the animation starts at staring the game/sandbox. Default is false

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-IsPlaying'></a>
### IsPlaying `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-IsPlaying 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the animation is currently playing or is stopped. Settable.

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Looping'></a>
### Looping `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Looping 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the animation starts from the beginning when reached its end. Default is false

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Percent'></a>
### Percent `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-Percent 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The current animation progress. Between 0 and 1. Readonly for now.

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackLength'></a>
### PlaybackLength `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackLength 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The original length of the AnimResource multiplied by PlaybackRate

<a name='P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackRate'></a>
### PlaybackRate `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimationPlayer-PlaybackRate 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The relative speed the animation is playing back. Default is 1f

<a name='T-MFEP-Duality-Plugins-Animation-AnimBuilder'></a>
## AnimBuilder [#](#T-MFEP-Duality-Plugins-Animation-AnimBuilder 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation

##### Summary

Use this class to build the animation in your AnimResources. Supports fluent syntax.

<a name='M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddParallel-MFEP-Duality-Plugins-Animation-IAnimPiece[],System-Single-'></a>
### AddParallel(pieces,time) `method` [#](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddParallel-MFEP-Duality-Plugins-Animation-IAnimPiece[],System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds an array of AnimPieces that will play simultaneously.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pieces | [MFEP.Duality.Plugins.Animation.IAnimPiece[]](#T-MFEP-Duality-Plugins-Animation-IAnimPiece[] 'MFEP.Duality.Plugins.Animation.IAnimPiece[]') |  |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Time (seconds) these pieces will take to finish. |

<a name='M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddSingle-MFEP-Duality-Plugins-Animation-IAnimPiece,System-Single-'></a>
### AddSingle(piece,time) `method` [#](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-AddSingle-MFEP-Duality-Plugins-Animation-IAnimPiece,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a single AnimPiece to the animation chain.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| piece | [MFEP.Duality.Plugins.Animation.IAnimPiece](#T-MFEP-Duality-Plugins-Animation-IAnimPiece 'MFEP.Duality.Plugins.Animation.IAnimPiece') | The IAnimPiece to add. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The time (seconds) this AnimPiece takes to finish. |

<a name='M-MFEP-Duality-Plugins-Animation-AnimBuilder-Start'></a>
### Start() `method` [#](#M-MFEP-Duality-Plugins-Animation-AnimBuilder-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Starting point of the animation chain.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-MFEP-Duality-Plugins-Animation-Extras-AnimControllerComp'></a>
## AnimControllerComp [#](#T-MFEP-Duality-Plugins-Animation-Extras-AnimControllerComp 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.Extras

##### Summary

Can control the animation state of the attached GameObject's AnimationPlayer.

<a name='T-MFEP-Duality-Plugins-Animation-AnimResource'></a>
## AnimResource [#](#T-MFEP-Duality-Plugins-Animation-AnimResource 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation

##### Summary

Inherit from this class when creating custom AnimResources. Have to implement the InitializePieces method.

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider'></a>
## CallbackProvider [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Use this AnimPiece to implement custom behaviour in the AnimResource.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider-Callback'></a>
### Callback `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-CallbackProvider-Callback 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

This function is going to be called at every update, getting the current AnimPercent and the AnimationPlayer GameObject as argument. Default does nothing.

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-CustomComponentUpdate'></a>
## CustomComponentUpdate [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-CustomComponentUpdate 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

This AnimPiece invokes the AnimTickCallback function on every Component which implements ICmpAnimUpdatable on the AnimationPlayer's GameObject.

<a name='T-MFEP-Duality-Plugins-Animation-IAnimPiece'></a>
## IAnimPiece [#](#T-MFEP-Duality-Plugins-Animation-IAnimPiece 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation

##### Summary

Building block of the animations. Initialize runs at the start of the animation. Tick runs at every update.

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement'></a>
## LerpNoiseMovement [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Implements random movement based on a simple noise algorithm. The Direction attribute controls the direction of the movement.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Amplitude'></a>
### Amplitude `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Amplitude 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The noise amplitude, the strength of this effect. Default is 100f

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-AmplitudeGen'></a>
### AmplitudeGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-AmplitudeGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

real_Amplitude := Amplitude * AmplitudeGen (currentAnimPercent) Default is ExponentialDecr

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Direction'></a>
### Direction `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Direction 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Controls the direction of the random movement. Its length is indifferent, will be normalized. Default is Vector2.UnitX

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Frequency'></a>
### Frequency `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Frequency 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The frequency of the direction changes. Default is 10f

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-FrequencyGen'></a>
### FrequencyGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-FrequencyGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

real_frequency := Frequency * FreqencyGen (currentAnimPercent) Default is Const1

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Relative'></a>
### Relative `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-LerpNoiseMovement-Relative 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space. Default is true

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement'></a>
## PathFollowMovement [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Moves the animated GameObject along a preinitialized path. The path consists of the segments between the PathVertices.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Closed'></a>
### Closed `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Closed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

If set to true, the algorithm automaticallt generates one more segment between the first and last vertex. Default is false

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-ConstantVelocity'></a>
### ConstantVelocity `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-ConstantVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

If set to false, running every segment takes the same time, the segments' length does not count. Otherwise, the speeed will be constant. Default is true

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-OverSpeedGen'></a>
### OverSpeedGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-OverSpeedGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

TODO

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-PathVertices'></a>
### PathVertices `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-PathVertices 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

MUST BE DECLARED. The local coordinates of the path the animation will follow. Default is null

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Relative'></a>
### Relative `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-Relative 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space. Default is true

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-SegmentSpeedGen'></a>
### SegmentSpeedGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-PathFollowMovement-SegmentSpeedGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

TODO

<a name='T-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer'></a>
## PathVisualizer [#](#T-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.Extras

##### Summary

Draws a line that connects the GameObject's positions in the last n frame. Beware! Not very effective.

<a name='P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-Color'></a>
### Color `property` [#](#P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-Color 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Color of the line drawn.

<a name='P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-FollowedFrames'></a>
### FollowedFrames `property` [#](#P-MFEP-Duality-Plugins-Animation-Extras-PathVisualizer-FollowedFrames 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

How many frames' positions should connect. Don't set this too high.

<a name='T-MFEP-Duality-Plugins-Animation-ProceduralAnimationCorePlugin'></a>
## ProceduralAnimationCorePlugin [#](#T-MFEP-Duality-Plugins-Animation-ProceduralAnimationCorePlugin 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation

##### Summary

Defines a Duality core plugin.

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate'></a>
## Rotate [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Simple rotating AnimPiece.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Frequency'></a>
### Frequency `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Frequency 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The rotation frequency. 1f means one rotation over the animation. Default is 1f

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-FrequencyGen'></a>
### FrequencyGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-FrequencyGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The mapping of the angular movement. Default value is Unity

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Relative'></a>
### Relative `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-Rotate-Relative 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter this Piece's effect overrides all other rotation. Default is true

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor'></a>
## SimpleColor [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Simple color interpolating AnimPiece.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-ColorGen'></a>
### ColorGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-ColorGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Color interpolating function. Default is Unity

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-EndColor'></a>
### EndColor `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-EndColor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Color at animation end. Default is ColorRgba.White

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-StartColor'></a>
### StartColor `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleColor-StartColor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Color at animation start. Default is ColorRgba.Black

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement'></a>
## SimpleMovement [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Move the GameObject on the line between StartPos and EndPos.

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-EndPos'></a>
### EndPos `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-EndPos 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Final position of the animation. Local space. Default is Vector2.Zero

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-PosGen'></a>
### PosGen `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-PosGen 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Position interpolation function. Default is Unity

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-Relative'></a>
### Relative `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-Relative 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Wheter the movement is combineable with other movement. Even if false, the movement takes place in local space. Default is true

<a name='P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-StartPos'></a>
### StartPos `property` [#](#P-MFEP-Duality-Plugins-Animation-AnimPieces-SimpleMovement-StartPos 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Starting position of the animation. Local space. Default is Vector2.Zero

<a name='T-MFEP-Duality-Plugins-Animation-AnimPieces-Wait'></a>
## Wait [#](#T-MFEP-Duality-Plugins-Animation-AnimPieces-Wait 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

MFEP.Duality.Plugins.Animation.AnimPieces

##### Summary

Does not do anything during the animation. Useful to introduce waiting times between two animation blocks.