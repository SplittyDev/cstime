[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png)](http://creativecommons.org/publicdomain/zero/1.0/)  
To the extent possible under law, [SplittyDev](https://github.com/SplittyDev) has waived all copyright and related or neighboring rights to cstime.

# cstime
A small c# application for measuring execution time

## Using cstime
### Using cstime under *nix (mono)
```
# mono cstime <program> [arg1 arg2 ...]
```
Examples:
```
# mono cstime gedit
# mono cstime uname -a
```

Do you want to call cstime directly without prefixing mono?  
No problem! Just create a file called ```cstime``` in ```/usr/bin```:
```
#!/usr/bin/env bash
mono path/to/cstime $*
```

Save the file, give it execute permissions using ```chmod a+x /usr/bin/cstime``` and you're good to go!

### Using cstime under Windows
```
> cstime <program> [arg1 arg2 ...]
```
Examples:
```
> cstime cmd /k echo "Hello, World!"
> cstime notepad
```

You'll need to add cstime to your path variable if you want to use it globally.  
Copying it to ```C:\Windows\System32``` should also work, but that's not recommended.

## Building cstime
### Building cstime under *nix (mono)
```
# git clone https://github.com/SplittyDev/cstime.git cstime
# cd cstime
# xbuild /p:Configuration=Release
```

### Building cstime under Windows
```
> git clone https://github.com/SplittyDev/cstime.git
> cd cstime
> msbuild /p:Configuration=Release
```

### Building using Visual Studio / Xamarin Studio
Just open the solution file and build the project in Release mode
