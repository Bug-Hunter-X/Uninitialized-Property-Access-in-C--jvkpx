# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties will have their default value (0 for integers, null for reference types, etc.), which might lead to unexpected behavior or logic errors in your program.  The example shows how this might manifest and how to fix it.