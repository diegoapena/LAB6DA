public interface IAtacable
{
    void Atacar(Enemigo enemigo);
}

public interface IDropeable
{
    void DropearItem();
}

public interface IConsumible
{
    void Consumir(Enemigo enemigo);
}

public interface IAplicarBuff
{
    void AplicarBuff(Enemigo enemigo);
}

