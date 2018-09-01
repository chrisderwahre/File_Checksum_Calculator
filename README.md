# File Checksum Calculator

Small tool i coded a while ago to read the checksum's of files.

# Usage

This is a Command line tool so you have to select the file via a Command Promt,

The Usage looks like this: `file_checksum_calculator.exe C:/Users/Chris/Desktop/Testfile.txt`

If you're using a path with spaces, use it like this: `file_checksum_calculator.exe "C:/Users/Chris/Desktop/Test file.txt"`

Sample response: 
```
===File checksum calculator===
Calculating Checksum...
-MD5: eef7aadb869921a19df83ded567f951f
-SHA1: 285C9653E154E06675EA207FD997334B07378F26
-SHA256: F220D15AE9374C335DF1CDC4CD522C9D811F6B1CC6BF98927CFA19028FCA9160
-SHA386: 4A58515C049F17FA64844DF91EA5E0A131855831B67938A18C333731A42646AD4782259EFAE28187A6D46D8B8458892A
-SHA512: 8455B33FC08D520E3587B51F32491D28B827299813F093223A7578FC010EDA249EFEF96EBE376899EC1AC22D5314592C6525DADF0D708E2A6DD6B08B269EDA17
===File checksum calculator===
```

# Compiling

Use either the .csproj file to compile it, or use this command to compile for Windows 10 64 bit:
`dotnet build -r win10-x64`

# License
MIT License