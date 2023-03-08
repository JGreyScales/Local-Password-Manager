# Local Password Manager


A locally stored lightly encrypted (key is on machine) password manager


To configure the program to work you must create the directory: {path}\bin\Debug\net6.0-windows
This directory should be auto made once code is uploaded into visual studio as a project file.
from there create the file: 1ab2ba2.json
Open this file in your perferred text editor and type:
```json
{
    "PlaceholderText":{
        "username":"[laceholder",
        "comments":"thats okay",
        "creation-date":"bleh",
        "last-used-date":"bleh bleh",
        "password":"bleh!"
    }
}
