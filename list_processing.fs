module list_processing

let main =
    printfn "list_processing"
    
    let case1 =
        let input1 = [ 0..10 ]
        let sum4 = List.reduce (fun x y -> x + y * 2) input1
        printfn "\treduction:sum %A = %A" input1 sum4
        0
    
    let case2 =
        let input_list: obj list =
            [ "Aopp"
              "Balc"
              "Calin"
              1
              2
              3
              null
              "California" ]
    
        let concater = fun acc y -> acc + (string y) + ", "
    
        let string_sum = List.fold concater "" input_list
        printfn "\tfold: %A" string_sum
        0
    
    0

