// For more information see https://aka.ms/fsharp-console-apps


open System
open polynomial

[<EntryPoint>]
let main1 (args: string []) =
    if args.Length < 1 then
        printfn "Error, expected args"
    else
        printfn "%A" (String.concat ", " args)

    ignore (new1.main "this is a string")
    ignore sums.sums
    ignore list_processing.main
    ignore polynomial.main

    printfn "press any key to continue..."
    ignore (Console.ReadKey(true))

    0
