![RomSort ScreenShot](./.github/screenshot.png)

# RomSort #

RomSort is a small utility to sort a directory of files into alphabetical sub-directories.

It was designed to assist the organization of ROM collections, particularly for use on flashcarts. Retro consoles typically have lower resolutions, so browsing ROMs on flashcarts can be painful as you can only view so many items on screen at once.

With RomSort, not only can you group your ROMs into convenient alphabetical sub-directories, but you can also set a maximum number of sub-directories, and the app will intelligently coalesce them together.

RomSort is developed in C# for .NET 2.0 and shoud work on Windows XP SP3 and later.

## Installation ##

### From the Microsoft Store (Windows 10 Recommended) ###

RomSort is now available on the Microsoft Store.

1. Get the latest version from https://www.microsoft.com/en-us/p/romsort/9p46qg0l6dv7
2. Run RomSort from your Start Menu

### Regular Installation (Windows XP SP3 / Vista / 7 / 8.1 / 10) ###

1. Download the latest zip file from https://github.com/jonthysell/RomSort/releases/latest
2. Extract the zip file
3. Double-click RomSort.exe

You should now see the RomSort window running.

## Usage ##

1. Use File > Open... or click the "Open" button and select the root directory you want to sort
2. The file hierarchy should appear under "Original" on the left side of the app
2. Set "Max Directories" at the bottom of the app to the number of alphabetical sub-directories you want
3. Verify file hierarchy that appears under "Sort Preview" on the right side of the app
4. Click the "Sort" button to perform the sort

**Note:** RomSort will create a completely new directory hierarchy under the root directory, *exactly* as shown in the preview. It will remove (delete) all other existing directories. There is no way to "undo" a sort, so make sure the preview is exactly what you want before you click the "Sort" button.

### Name Conflicts ###

Since RomSort moves files into alphabetical sub-directories, it requires that each file (across all sub-directories) has a unique name. Otherwise files with the same name would get overwritten in a non-deterministic way.

Name conflicts are flagged red in the "Original" view. You will need to manually remove the files that you don't want to end up in the final sort. After you've fixed up the folder, go to File > Refresh.

## Errata ##

RomSort is open-source under the MIT license.

RomSort Copyright (c) 2018-2019 Jon Thysell
