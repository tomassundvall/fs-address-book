module UseCases
open CommonLibrary
open AddressBook

///
/// ADD Usecase
///
module ADD =
  type Input = {
    FirstName: Option<string>
    LastName: Option<string>
    EmailAddress: Option<string>
    PhoneNumber: Option<string>
  }

  let exec (input: Input) =
    match input.FirstName with
    | Some x -> 
      let firstName = FirstName.create x
      match firstName with
      | Some a -> Success ""
      | None _ -> Failure ""
    | None _ -> Failure ""
    


///
/// DELETE Usecase
///
module DELETE =
  type Input = {
    Id: Option<string>
  }

  let exec (input: Input) =
    Failure "does not exist"


///
/// LIST Usecase
///
module LIST =
  let exec () =
    Failure "No items"