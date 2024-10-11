# Wpf Blazor Hybrid App Template
A Basic setup for a Wpf Blazor hybrid app
- Aim of this template is to allow the directory where the Exe is located to be clean.
- All resources are moved to are now contained as an embedded resource
- Including `WebView2Loader.dll`

# Dependencies
MudBlazor
Microsoft.AspNetCore.Components.WebView.Wpf
Microsoft.Extensions.FileProviders.Embedded

# To Use
- `dotnet new install CWXDEV.Templates::3.0.0`

# TODO:
- change the CDN for a font to be local, if this is a concern