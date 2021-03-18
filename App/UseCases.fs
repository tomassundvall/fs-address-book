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
    validateFirstName input.FirstName


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