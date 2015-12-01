aspnet-windows-service
=======

### Note

This is modified version of original repository https://github.com/taskmatics/aspnet-windows-service. It should allow to use dynamic views (Razor) for self hosted ASP.NET 5/MVC 6 environment.

### ---

This repository provides a shell project that you can use to get a Windows service hosting ASP.NET 5 with static files and MVC 6.

For detailed information, please read the following post: [How to Host ASP.NET in a Windows Service](http://taskmatics.com/blog/host-asp-net-in-a-windows-service/)

### Installation

#### 0. Run a Command Prompt as Administrator
This is needed in order to run the `install` command.

#### 1. Clone the repository
Run `git clone https://github.com/gene9/aspnet-windows-service`

Run `cd aspnet-windows-service\src\AspNetWindowsService`

Run `npm install -g bower`

Run `bower update`

#### 2. Install the service
Run `install <optional-service-name>` (`AspNetWindowsService` is used by default for the name)

This command does a few things:
* Publishes the project to an output folder (`.\publish-output`)
* Installs the Windows service (using the service name provided) and points to the `run.cmd` in the published output folder
* Starts the service

#### Browsing the Website

To view MVC output (from `HomeController`), launch a browser and navigate to `http://localhost:5000/`. The port is configurable in code in the `src\Program.cs`.

#### Uninstalling
Run `uninstall <optional-service-name>` (The name must match the one used during install.)

This command will stop and uninstall the Windows service (using the service name provided).