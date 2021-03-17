module UseCases
open CommonLibrary
open AddressBook

type AddInput = {
  FirstName: Option<string>
  LastName: Option<string>
  EmailAddress: Option<string>
  PhoneNumber: Option<string>
};

type DeleteInput = {
  Id: Option<string>
}

let add (input: AddInput) =
  validateFirstName input.FirstName

let delete (input: DeleteInput) =
  Failure "does not exist"

let list () =
  Failure "No items"