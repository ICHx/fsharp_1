module sums

let sums: unit =
    printfn "sums"
    let sum x y = x + y
    printfn "\tsum1 %d" (sum 9 91)

    let nums = [ 1..99 ]
    let sum2 = List.sum <| nums
    printfn "\tsum2 [1..99]= %d" sum2

    let add3 x y z = x * 10000 + y * 100 + z * 1
    let sum3 = add3 12 11 13
    printfn "\tsum3 [1..99]= %A" sum3


    printfn "\tlambda result5 add= %A" ((fun x y -> x + y) 3 2)
