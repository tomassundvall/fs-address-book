module CommonLibrary

// the two-track type
type Result<'TSuccess, 'TFailure> =
  | Success of 'TSuccess
  | Failure of 'TFailure

let succeed x =
  Success x

let fail x =
  Failure x