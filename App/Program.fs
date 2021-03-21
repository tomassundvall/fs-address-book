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
/// processCommand command
/// Maps a given command to it's corresponding usecase together with the input
/// 
let processCommand cmd =
  match cmd with
  | Some x -> 
    match x with
    | "add" -> ADD.exec {FirstName=Some("tomas"); LastName=Some("Sundvall"); EmailAddress=Some("tsunvall@someting.se"); PhoneNumber=None}
    | "list" -> LIST.exec ()
    | "delete" -> DELETE.exec {Id=Some("blahaa")}
    | _ -> Failure "Command not found"
  | None -> Failure "No command entered"

///
/// MAIN 
///
[<EntryPoint>]
let main argv =
  
  let result = argv |> parseCommand |> processCommand

  match result with
  | Success s ->
    printfn "Command executed successfuly"
    0
  | Failure f ->
    printfn "Execution failed "
    1