namespace ClassLibrary2

module Say =
    let a = "‘".Length.ToString()
    let b = sprintf "%A" ("‘".ToCharArray() |> Array.map int)
    let c = "‘"
