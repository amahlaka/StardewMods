namespace StardewMods.Common.Integrations.EvenBetterRng;

/// <inheritdoc />
internal sealed class EvenBetterRngIntegration : ModIntegration<IEvenBetterRngApi>
{
    private const string ModUniqueId = "pepoluan.EvenBetterRNG";

    /// <summary>
    ///     Initializes a new instance of the <see cref="EvenBetterRngIntegration" /> class.
    /// </summary>
    /// <param name="modRegistry">SMAPI's mod registry.</param>
    public EvenBetterRngIntegration(IModRegistry modRegistry)
        : base(modRegistry, EvenBetterRngIntegration.ModUniqueId)
    {
        // Nothing
    }
}