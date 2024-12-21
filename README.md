# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing an uninitialized property.  The `bug.cs` file shows the erroneous code, while `bugSolution.cs` provides a corrected version.

The problem occurs when a property is used before it has been assigned a value. This leads to the default value being used which is often not the intended behavior.

The solution involves explicitly initializing the property in the constructor or before its first use.
