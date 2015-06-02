namespace FsharpNetInterop

module Option =

    open System

    let ReferenceToOption thing =
        match thing with
        | null -> None
        | t -> Some t

    let NullableToOption (thing: _ Nullable) =
        if thing.HasValue
            then Some thing.Value
            else None

    let OptionToReference thing =
        match thing with
        | Some t -> t
        | None -> null

    let OptionToNullable thing =
        match thing with
        | Some t -> Nullable t
        | None -> Nullable()