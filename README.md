# StrongNameErrorBase32Package

Run project in visual studio.

Access `/api/values/fails` and you get:

> An exception of type 'System.IO.FileLoadException' occurred in OtpSharp.dll but was not handled in user code
> 
> Additional information: Could not load file or assembly 'Base32, Version=1.0.0.26, Culture=neutral, PublicKeyToken=3427d4dc8cee30c6' or one of its dependencies. A strongly-named assembly is required. (Exception from HRESULT: 0x80131044)

Access `/api/values/works` and all is well.

External projects used: 

    "OtpSharp": "1.3.0.2"

https://bitbucket.org/devinmartin/otp-sharp/wiki/TOTP

https://bitbucket.org/devinmartin/base32
