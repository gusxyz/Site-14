using Content.Shared.Tag;
using Robust.Shared.Physics.Events;

namespace Content.Shared._SCP.Research;

/// <summary>
/// This handles...
/// </summary>
public sealed class ScpAnalyzerSystem : EntitySystem
{

    [Dependency] private readonly TagSystem _tagSystem = default!;
    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<ScpAnalyzerComponent,StartCollideEvent>(OnCollide);
    }

    private void OnCollide(EntityUid uid, ScpAnalyzerComponent component, ref StartCollideEvent args)
    {
        if(!_tagSystem.HasTag(args.OtherEntity, "SCP"))
            return;
    }
}
