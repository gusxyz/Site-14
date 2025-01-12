namespace Content.Shared._SCP.Research;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent]
public sealed partial class ScpAnalyzerComponent : Component
{
    public bool Active { get; set; } = false;
    public List<EntityUid> ScpInArea = new();
}
