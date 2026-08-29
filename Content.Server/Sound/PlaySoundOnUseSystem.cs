using Content.Shared.Interaction.Events;
using Robust.Shared.Audio.Systems;

namespace Content.Server.Sound;


public sealed partial class PlaySoundOnUseSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<PlaySoundOnUseComponent, UseInHandEvent>(OnUseInHand);
    }

    private void OnUseInHand(Entity<PlaySoundOnUseComponent> ent, ref UseInHandEvent args)
    {
        _audio.PlayPvs(ent.Comp.Sound, ent.Owner);
    }


}
