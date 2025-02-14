namespace StardewMods.Common.Integrations.BetterChests;

/// <inheritdoc />
internal sealed class BetterChestsIntegration : ModIntegration<IBetterChestsApi>
{
    private const string ModUniqueId = "furyx639.BetterChests";

    /// <summary>
    ///     Initializes a new instance of the <see cref="BetterChestsIntegration" /> class.
    /// </summary>
    /// <param name="modRegistry">SMAPI's mod registry.</param>
    public BetterChestsIntegration(IModRegistry modRegistry)
        : base(modRegistry, BetterChestsIntegration.ModUniqueId)
    {
        // Nothing
    }
}