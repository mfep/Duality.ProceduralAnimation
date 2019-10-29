# Samples
Here are some gifs with source code to showcase the plugin's capabilities.

## Complex sample
<p align="center">
  <img src="http://i.imgur.com/NwtAQ2n.gif" alt="Imgur" />
</p>

```csharp
public class ComplexSample : AnimResource
{
  protected override AnimBuilder InitializePieces ()
  {
    return AnimBuilder.Start ()
      .Add (new IAnimPiece[]
        {
          new PathFollowMovement
          {
            Closed = true,
            SegmentSpeedGen = ExponentialGrow (3.0f),
            PathVertices =
              new[] { new Vector2 (-2500, 0), new Vector2 (0, -1500), new Vector2 (2500, 0), new Vector2 (0, 1500) }
          },
          new TrigonometricMovement2D { Amplitude = new Vector2 (10, 20), Frequency = new Vector2 (10, 20) },
          new Rotate { Frequency = 10.0f }
        },
        10.0f
      );
  }
}
```

## Trigonometric Sample
<p align="center">
  <img src="http://i.imgur.com/DhCXJI0.gif" alt="Imgur" />
</p>

```csharp
public class TrigonometricMovement2DSample : AnimResource
{
  protected override AnimBuilder InitializePieces ()
  {
    return AnimBuilder.Start ()
      .Add (
        new TrigonometricMovement2D
        {
          Amplitude = new Vector2 (1000),
          FreqGenX = Linear (5),
          FreqGenY = Linear (5),
          AmpGenX = AbsSin,
          AmpGenY = AbsSin,
          PhaseGenX = SimpleCos,
          PhaseGenY = SimpleCos
        }, 5.0f);
  }
}
```

## Path and Color sample
<p align="center">
  <img src="http://i.imgur.com/wAK5ute.gif" alt="Imgur" />
</p>

```csharp
public class PathAndColorSample : AnimResource
{
  protected override AnimBuilder InitializePieces ()
  {
    return AnimBuilder.Start ()
      .Add (new IAnimPiece[]
      {
        new PathFollowMovement
        {
          PathVertices = new[] { new Vector2 (0, 0), new Vector2 (250, 316), new Vector2 (316, 512) },
          Closed = true
        },
        new SimpleColor { StartColor = ColorRgba.White, EndColor = ColorRgba.Blue }
      }, 1.0f)
      .Add (new IAnimPiece[]
      {
        new SimpleColor { StartColor = ColorRgba.Blue, EndColor = ColorRgba.White },
        new SimpleMovement { StartPos = new Vector2 (0, 0), EndPos = new Vector2 (1000, 0) }
      }, 2.0f);
  }
}
```
