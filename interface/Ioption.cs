namespace Pokemon.Interface;
internal interface Ioption
{
    public string Name { get; set; }
    public string? _pokemonUrl { get; set; }
    public void Function() { }
    virtual void ProtocolMain(Ipokemon x) { }
}