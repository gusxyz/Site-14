using Content.Shared.Tag;
using Robust.Shared.Physics.Events;

namespace Content.Shared._SCP.Research;

/// <summary>
/// This handles...
/// </summary>
public sealed class ScpAnalyzerSystem : EntitySystem
{

    [Dependency] private readonly TagSystem _tagSystem = default!;
    [Dependency] private readonly EntityManager _entityManager = default!;
    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<ScpAnalyzerComponent,StartCollideEvent>(OnCollide);
        SubscribeLocalEvent<ScpAnalyzerComponent,EndCollideEvent>(EndCollide);

    }

    private void OnCollide(EntityUid uid, ScpAnalyzerComponent component, ref StartCollideEvent args)
    {
        Logger.Debug( _entityManager.GetNetEntity(uid).Id.ToString());

        var scp = args.OtherEntity;

        if(!_tagSystem.HasTag(scp, "SCP"))
            return;

        if (component.ScpInArea.Contains(scp))
            return;

        component.ScpInArea.Add(scp);
    }

    private void EndCollide(EntityUid uid, ScpAnalyzerComponent component, ref EndCollideEvent args)
    {
        var scp = args.OtherEntity;

        if (!component.ScpInArea.Contains(scp))
            return;

        component.ScpInArea.Remove(scp);
    }
}

