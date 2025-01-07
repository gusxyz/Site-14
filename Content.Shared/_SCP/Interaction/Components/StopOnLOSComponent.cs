using Robust.Shared.GameStates;

namespace Content.Shared._SCP.Interaction.Components;


[RegisterComponent,NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class StopOnLOSComponent : Component
{
    [DataField]
    [AutoNetworkedField]
    public bool canMove = false;
}
