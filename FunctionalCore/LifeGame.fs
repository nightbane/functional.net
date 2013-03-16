module LifeGame

let IsTopRow A x = x = 0
let IsBottomRow A x = (Array2D.length1 A) - 1 = x
let IsMiddleColumn A y = y > 0 && (Array2D.length2 A) - 1 > y
let IsFirstColumn A y = y = 0

let GetRowCount (A: int[,]) x y = 
    A.[x,y] + 
    if IsMiddleColumn A y 
        then A.[x,y-1] + A.[x,y+1]
    else if IsFirstColumn A y
        then A.[x,y+1]
    else A.[x,y-1]

let CountFirstRow A x y =
    if IsTopRow A x then 0 else GetRowCount A (x-1) y

let CountMiddleRow A x y =
    GetRowCount A x y - A.[x,y]

let CountBottomRow A x y =
    if IsBottomRow A x then 0 else GetRowCount A (x+1) y

let CountNeighbors A x y =
    CountFirstRow A x y +
    CountMiddleRow A x y +
    CountBottomRow A x y

let Advance A =
    Array2D.init 
        (Array2D.length1 A) (Array2D.length2 A)
        (fun x y -> 
            match A.[x,y], CountNeighbors A x y with 
            1,2 -> 1
            | _,3 -> 1
            | _,_ -> 0
        ) 