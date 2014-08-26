### The Challenge
Sometimes, we have to interface with an existing legacy system.  This system was poorly documented, and the original developer is no longer around.  The original developer also never believed in source control, and the only source code was on a computer that was destroyed by fire. 
 
It has been mandated by the client that the original Bombed.dll assembly be used in your solution.  There is some process in the DLL that is critical to their operations.  The only problem is that no one knows what it does, or how to use it.  Given the attached assembly, you have one goal: __Make it work!__
 
### Caveats:
* Your solution must be written in C#.
* Your solution must use the attached DLL in an unaltered form.
* Your solution must call the method SomeProcess within the attached DLL, and output the result of the process.
* Your solution is only complete when the result of the process tells you that it is correct.
