# LibFileNameSanitizer

[nuget](https://preview.nuget.org/packages/LibFileNameSanitizer)

Sample.cs:
```cs
String.Format("{0}.xps", FileNameSanitizer.forFileName("Quote for *you*"))
```
Will be `Quote for _you_.xps`

Usage.cs:
```cs
FileNameSanitizer.forFileName("Quote for *you*");
FileNameSanitizer.forFileName("Quote for *you*", "_");
```
