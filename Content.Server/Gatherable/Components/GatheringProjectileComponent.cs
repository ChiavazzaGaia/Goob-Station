namespace Content.Server.Gatherable.Components;

/// <summary>
/// Destroys a gatherable entity when colliding with it.
/// </summary>
[RegisterComponent]
public sealed partial class GatheringProjectileComponent : Component
{
    /// <summary>
    /// How many more times we can gather.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("amount")]
    public int Amount = 1;

    /// <summary>
    /// Goobstation
    /// The probability that the given projectile will actually be gathering
    /// </summary>
    [DataField]
    public float Probability = 1f;
}
