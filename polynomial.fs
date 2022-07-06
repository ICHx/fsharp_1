module polynomial

let f (x) = x ** 2. + x
let g (x: float) = x * sin (x)

let add_two x y = x + y

type polynomial =
    { X_4: int
      X_3: int
      X_2: int
      X_1: int
      X_0: int }

let print_polynomial (p: polynomial) =
    printfn "polynomial %Ax4 + %Ax3 + %Ax2 + %Ax1 + %A"
    <| p.X_4
    <| p.X_3
    <| p.X_2
    <| p.X_1
    <| p.X_0

let dydx (p: polynomial) =
    { polynomial.X_4 = 0
      polynomial.X_3 = 0
      X_2 = 3 * p.X_3
      X_1 = 2 * p.X_2
      X_0 = 1 * p.X_1 }

let Fx (p: polynomial) =
    { polynomial.X_4 = p.X_3 / 4
      polynomial.X_3 = p.X_2 / 3
      X_2 = p.X_1 / 2
      X_1 = p.X_0 / 1
      X_0 = 0 }



let main =
    let p: polynomial =
        { X_4 = 0
          X_3 = 42
          X_2 = 33
          X_1 = 24
          X_0 = 15 }

    printfn "p = \n%A\n" p
    let p_prime1 = dydx p
    printfn "dydx(p) = \n%A\n" p_prime1

    let p_int1 = Fx p
    printfn "Fx(p) = \n%A\n" p_int1

    0
