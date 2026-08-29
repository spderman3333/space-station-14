namespace Content.Server.Sound;

[RegisterComponent]
public sealed partial class PlaySoundOnUseComponent : Component
{
    [DataField]
    public string Sound = string.Empty;
}
