using Robust.Shared.Serialization;
using Robust.Shared.Utility;


namespace Content.Shared._SCP.Research;

[Serializable, NetSerializable]
public enum ScpArtifactAnalzyerUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsoleServerSelectionMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsoleScanButtonPressedMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsolePrintButtonPressedMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsoleExtractButtonPressedMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsoleBiasButtonPressedMessage(bool isDown) : BoundUserInterfaceMessage
{
    public bool IsDown = isDown;
}

[Serializable, NetSerializable]
public sealed class ScpAnalysisConsoleUpdateState(
    NetEntity? artifact,
    bool analyzerConnected,
    bool serverConnected,
    bool canScan,
    bool canPrint,
    FormattedMessage? scanReport,
    bool scanning,
    bool paused,
    TimeSpan? startTime,
    TimeSpan? accumulatedRunTime,
    TimeSpan? totalTime,
    int pointAmount,
    bool isTraversalDown
)
    : BoundUserInterfaceState
{
    public NetEntity? Artifact = artifact;
    public bool AnalyzerConnected = analyzerConnected;
    public bool ServerConnected = serverConnected;
    public bool CanScan = canScan;
    public bool CanPrint = canPrint;
    public FormattedMessage? ScanReport = scanReport;
    public bool Scanning = scanning;
    public bool Paused = paused;
    public TimeSpan? StartTime = startTime;
    public TimeSpan? AccumulatedRunTime = accumulatedRunTime;
    public TimeSpan? TotalTime = totalTime;
    public int PointAmount = pointAmount;
    public bool IsTraversalDown = isTraversalDown;
}
