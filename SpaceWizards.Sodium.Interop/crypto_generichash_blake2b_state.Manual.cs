namespace SpaceWizards.Sodium.Interop;

/// <summary>
/// WARNING: This type MUST be aligned to a 64-byte boundary.
/// .NET does not currently have a method of specifying this at the type level,
/// so you need to manage this yourself when allocating space or such.
/// </summary>
public unsafe partial struct crypto_generichash_blake2b_state
{
}