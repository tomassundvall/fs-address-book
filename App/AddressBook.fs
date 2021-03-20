module AddressBook 
open CommonLibrary

///
/// EmailAddress
///
module EmailAddress =

  type T = EmailAddress of string

  // create with continuation
  let createWithCont success failure (s: string) =
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$")
    then success (EmailAddress s)
    else failure "Email address must contain a @ sign"

  // create directly
  let create (s: string) =
    let success e = Some e
    let failure _ = None
    createWithCont success failure s

  // unwrap with continuation
  let apply f (EmailAddress e) = f e

  // unwrap directly
  let value e = apply id e


///
/// FirstName 
///
module FirstName =

  type T = FirstName of string

  // create with continuation
  let createWithCont success failure (s: string) =
    if (String.length s > 0)
    then success s
    else failure "A first name must contain at least one character"

  // create directly
  let create (s: string) =
    let success e = Some e
    let failure _ = None
    createWithCont success failure s

  // unwrap with continuation
  let apply f (FirstName e) = f e

  // unwrap directly
  let value e = apply id e


///
/// FirstName 
///
module LastName =

  type T = LastName of string

  // create with continuation
  let createWithCont success failure (s: string) =
    if (String.length s > 0)
    then success s
    else failure "A last name must contain at least one characted"

  // unwrap with continuation
  let apply f (LastName e) = f e

  // unwrap directly
  let value e = apply id e


///
/// PhoneNumber
///
module PhoneNumber =

  type T = PhoneNumber of string

  // create with continuation
  let createWithCont success failure (s: string) =
    if (String.length s >= 5)
    then success s
    else failure "A Phone number must be at least 5 characters long"

 // unwrap with continuation
  let apply f (PhoneNumber e) = f e

  // unwrap directly
  let value e = apply id e


///
/// Contact
///
type Contact =
  {
    FirstName: FirstName.T
    LastName: LastName.T
    EmailAddress: EmailAddress.T
    PhoneNumber: PhoneNumber.T
  }