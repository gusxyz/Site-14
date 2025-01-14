namespace Content.Shared._SCP.Research;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent]
public sealed partial class ScpAnalyzerComponent : Component
{
    public bool Active { get; set; } = false;

    [DataField]
    public List<EntityUid> ScpInArea = new();
}
