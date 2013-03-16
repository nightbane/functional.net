module FizzBuzzer

let HundredList = [1 .. 100]

let Translate x = string x



let TranslateList (x: int list) =
    List.map Translate x
