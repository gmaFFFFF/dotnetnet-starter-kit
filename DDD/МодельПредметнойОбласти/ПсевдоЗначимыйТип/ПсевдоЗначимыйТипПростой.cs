namespace gmafffff.СтартовыйНабор.DDD.МодельПредметнойОбласти;

/// <summary>
///     Простейший <see cref="ПсевдоЗначимыйТип" />, являющийся смысловой обёрткой над существующим типом
/// </summary>
/// <typeparam name="Т">Обёртываемый тип</typeparam>
public abstract class ПсевдоЗначимыйТипПростой<Т> : ПсевдоЗначимыйТип {
    protected ПсевдоЗначимыйТипПростой(Т? значение) {
        Значение = значение;
    }

    public Т? Значение { get; init; }

    public static implicit operator Т?(ПсевдоЗначимыйТипПростой<Т> псевдоЗначимыйТип) {
        return псевдоЗначимыйТип.Значение;
    }
}