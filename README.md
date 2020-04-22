# Custom Windows Properties

A stand-alone application for creating, installing and uninstalling custom Windows properties.

Versions:   
0.1 - First working version, for testing functionality and usability

## Work list
- Write the readme!
- Go through properties and see which can be sourced from the system, but are not at the moment, and those which could not be but are not marked as unavailable.
- See if the registry will point out system property descriptions that we can parse for some of the missing information
- Add the help text for the properties, from a localised resource
- Source all messages from localised resources
- Look to see if any more display properties should be added
- Document this subtlety for canonical name: if A.B.C exists, then A.B is not an acceptable name for a new terminal
- Document how names work independently, no such thing as folder renaming
- If two properties are added, with names differing only in the last part, then they should have the same format ID, but different property IDs
- Detect when the edited property is dirty, so that we can warn about changes being lost as appropriate
- React to changes in canonical name without having to move away from the field
- Consider remembering tree selections and restoring them or bringing them into view after the tree is updated, where required
- Document the separate permanent universally available location for the propdesc files that we install. The system loads from them lazily, possibly using the identity of whoever is signed on, or the system, in the case of the index server.

Example markup:
**Latest:** Version 1.6 is now the recommended [release](../../releases/tag/v1.6).  [documentation](../../wiki) has been updated 
