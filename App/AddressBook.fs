module AddressBook 
open CommonLibrary

type FirstName = FirstName of string
type LastName = LastName of string
type EmailAddress = EmailAddress of string
type PhoneNumber = PhoneNumber of string

let CreateEmailAddress (s:string) =
  if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$")
    then Some (EmailAddress s)
    else None

type Contact =
  {
    FirstName: FirstName
    LastName: LastName
    EmailAddress: EmailAddress
    PhoneNumber: PhoneNumber
  }

let validateFirstName input =
  match input with
  | None -> Failure "Name is required"
  | Some x when x = "" -> Failure "Name must not be blank"
  | Some x -> Success x
