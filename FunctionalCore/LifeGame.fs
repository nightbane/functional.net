module LifeGame

let IsTopRow A x = x = 0
let IsBottomRow (A: int[,]) x = (Array2D.length1 A - 1) = x
let IsMiddleColumn (A: int[,]) y = y > 0 && (Array2D.length2 A) - 1 > y
let IsFirstColumn A y = y = 0

let GetRowCount (A: int[,]) x y = 
    if IsMiddleColumn A y 
        then A.[x,y-1] + A.[x,y] + A.[x,y+1]
    else if IsFirstColumn A y
        then A.[x,y] + A.[x,y+1]
    else A.[x,y-1] + A.[x,y]

let CountNeighbors (A: int[,]) x y =
    (if IsTopRow A x then 0 else GetRowCount A (x-1) y) +
    ((GetRowCount A x y) - A.[x,y]) +
    (if IsBottomRow A x then 0 else GetRowCount A (x+1) y)



let Advance A =
    Array2D.init 
        (Array2D.length1 A) (Array2D.length2 A)
        (fun x y -> 0 ) 