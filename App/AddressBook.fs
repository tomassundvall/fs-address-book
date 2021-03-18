module AddressBook 
open CommonLibrary

module EmailAddress =

  type T = EmailAddress of string

  let create (s: string) =
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$")
    then Some (EmailAddress s)
    else None

  let value (EmailAddress e) = e

type FirstName = FirstName of string
type LastName = LastName of string
type PhoneNumber = PhoneNumber of string

type Contact =
  {
    FirstName: FirstName
    LastName: LastName
    EmailAddress: EmailAddress.T
    PhoneNumber: PhoneNumber
  }

let validateFirstName input =
  match input with
  | None -> Failure "Name is required"
  | Some x when x = "" -> Failure "Name must not be blank"
  | Some x -> Success x
