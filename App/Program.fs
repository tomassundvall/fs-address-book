open CommonLibrary
open AddressBook
open UseCases

let parseCommand args =
  let length = Array.length args
  match length with
   | 0 -> None
   | _ -> Some(args.[0])

[<EntryPoint>]
let main argv =

  // Step 1. Parse the command type. add/list/delete
  // Step 2. Extract input parameters and apply to the given usecase
  
  let command = parseCommand argv

  let result = 
    match command with
    | Some x -> 
      match x with
      | "add" -> add {FirstName=Some("tomas"); LastName=Some("Sundvall"); EmailAddress=Some("tsunvall@someting.se"); PhoneNumber=None}
      | "list" -> list ()
      | "delete" -> delete {Id=Some("blahaa")}
      | _ -> Failure "Command not found"
    | None -> Failure "No command entered"

  printfn "Is this a valid command? %A" result

  let email = "tsundvall" |> EmailAddress
  let (EmailAddress email') = email
  printfn "The email: %s" email'

  0 // return an integer exit code