(**LAMBDA EXPRESSIONS **)
fun () -> printfn "Hello world!"
fun x -> x + 1
fun x y -> x + y

(** DEFINING NAMED FUNCTIONS**)
let addOne x = x + 1 //let addOne = fun x -> x + 1

// type inference occurs

(** CALLING FUNCTIONS **)
addOne 3

(** TYPE ANNOTATIONS **)
// https://github.com/dotnet/fsharp
// protocol: http or https
// base url: github.com
// path: dotnet/fsharp

let buildurlNoAnnotations protocol baseUrl path = $"{protocol}://{baseUrl}//{path}"

buildurlNoAnnotations 1 "github.com" (1.0,4.0) // "1://github.com//(1, 4)"

let buildUrl (protocol: string) (baseUrl:string) (path:string) : string = 
    $"{protocol}://{baseUrl}//{path}"

buildUrl 1 "github.com" (1.0,4.0) // Error

buildUrl "http" "github.com" "dotnet/fsharp" // Works

(** OPTION TYPE **)