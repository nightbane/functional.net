module LifeGame




let Advance A =
    Array2D.init 
        (Array2D.length1 A) (Array2D.length2 A)
        (fun x y -> A.[x,y])