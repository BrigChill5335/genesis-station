using Content.Shared.Actions;
using Robust.Shared.Serialization;
using Content.Shared.DoAfter;
using Robust.Shared.GameStates;

namespace Content.Shared._Genesis.Events;

[Serializable, NetSerializable]
public sealed partial class PsionicRegenerationDoAfterEvent : DoAfterEvent
{
    [DataField("startedAt", required: true)]
    public TimeSpan StartedAt;

    private PsionicRegenerationDoAfterEvent()
    {
    }

    public PsionicRegenerationDoAfterEvent(TimeSpan startedAt)
    {
        StartedAt = startedAt;
    }

    public override DoAfterEvent Clone() => this;
}

[Serializable, NetSerializable]
public sealed partial class GlimmerWispDrainDoAfterEvent : SimpleDoAfterEvent
{
}

public sealed partial class HairballActionEvent : InstantActionEvent {}
public sealed partial class EatMouseActionEvent : InstantActionEvent {}
{

}
