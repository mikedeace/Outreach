## Setting up on Windows
To install Ruby on windows, there is a great library at www.rubyinstaller.org. 
The library gives you everything you need to get started on windows including: 
* important documentation to get started
 * the execution environment
 * the Ruby language
 

 Choose the version and them Download the installer. If you don't know which version to use, you can start with Ruby 2.2.X. Once the download is complete, click on the .exe file accept the terms and follow the prompts. When presented with the option to make all .rb files associated with this installation as well as whether to include this installation on the path, choose all.
To check that you have the right version installed on your machine:

```sh
C:\Users\YourUsername>ruby -v
```

## Setting up on Linux(Ubuntu)
We assume that you are on an Ubuntu/Debian system as this is the most downloaded linux flavor. A quick guide on how to install Ruby on linux distros is available on the official Ruby language website: https://www.ruby-lang.org/en/documentation/installation/.
You can follow the steps below for Ubuntu.

```sh
$ sudo apt-get update
$ sudo apt-get install ruby-full
```
To check that you have th right Ruby version installed:
```sh
$ruby -v
```