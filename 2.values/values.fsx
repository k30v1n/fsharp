(*VALUE TYPES*)
// String
"New york  "
// Boolean
true
// Integer
10
// Tuple
(1.0, 3.0)
// List value
["Learn f#"; "BUild app"; "Profit"]
// Lambda expression ; ANonymous function value
fun input -> input / 3

//////// naming variables

let cityName = "New york"
let fsharpIsAwesome = true
let luckyNumber = 10
let coordinates = (1.0,3.0)
let toDoList = ["Learn F#"; "Build app"; "Profit"]
let divideByThree input = input / 3

////////
(* Explicit Type Annotations *)
let (luckNumberString:string) = "10"

// data in Fsharp is immutable by default
(*Updating values*)
cityName <- "Toronto" // Throws Error

let correctCityName = "Toronto"

(*MUTABLE VALUES*)
let mutable mutableCityName = "New york"

mutableCityName <- "Toronto"
mutableCityName <- 123 // Types are not mutable

// Immutability is good for compiler point of view, easy to test and maintain
