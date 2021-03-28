open CommonLibrary
open UseCases

///
/// parseCommand command
/// 
let parseCommand args =
  let length = Array.length args
  match length with
   | 0 -> None
   | _ -> Some(args.[0])

///
/// parseParameter args key
///
/// Expects the value corresponding to the key
/// to follow the key in the args array. 
///
let parseParameter (args: string[]) key =
  try
    let keyIndex = Array.findIndex (fun x -> x = key) args
    let v = args.[keyIndex + 1]
    Some(v)
  with
  | _ -> None


///
/// processCommand command
/// Maps a given command to it's corresponding usecase together with the input
/// 
let processCommand args =
  let cmd = parseCommand args
  let fromParam = parseParameter args

  match cmd with
  | Some x -> 
    match x with
    | "add" -> ADD.exec {
        FirstName = fromParam "--firstName" ; 
        LastName = fromParam "--lastName"; 
        EmailAddress = fromParam "--email"; 
        PhoneNumber = fromParam "--phone"
      }
    | "list" -> LIST.exec ()
    | "delete" -> DELETE.exec {Id = fromParam "--id"}
    | _ -> Failure "Command not found"
  | None -> Failure "No command entered"

///
/// MAIN 
///
[<EntryPoint>]
let main argv =
  
  let result = argv |> processCommand

  match result with
  | Success s ->
    printfn "Command executed successfuly"
    0
  | Failure f ->
    printfn "%s" f
    1