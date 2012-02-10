VBoxVMStatus
============

by Peter Upfold.

This program is a simple way to see, graphically, the status of your [VBoxVmService](http://vboxvmservice.sourceforge.net/)-started VirtualBox virtual machines. It is written in Visual Basic.NET (.NET Fx 4.0.x) and was created in Visual Studio 2010.

[VBoxVmService](http://vboxvmservice.sourceforge.net/) is a useful little piece of code that allows you to run VirtualBox virtual machines as a service on a Windows host. This means that you can have those virtual machines start upon boot, without having to have a user interactively log in to the Windows host. I have been using this myself on a Windows VM host to start two virtual machines. Unfortunately, this approach has a limitation. You cannot use the regular VirtualBox UI to manage the VBoxVmService-started VMs. Instead, you must enable the excellent VRDP support in VirtualBox to log in to the virtual machines. This, however, leaves a gap — you can't see the status of the virtual machines in the VirtualBox GUI, you can't start and stop the machines at will with a GUI, and the only way to check the status is using the `VmServiceControl.exe` application.

This program is designed, for this specific machine, to solve that problem — to provide a GUI to check the status of these VMs, as well as start and stop them on demand.

**The user interface is, at the moment, customised and very specific for this machine** that I am using. There are two VMs that I want to run on that machine. The names of these VMs that I have are hard-coded into the app for now.

**I provide the code here for this solution so that if others want to adapt this program for their environment, they can.** Who knows, in time, this project might be more useful for any kind of VBoxVmService deployment. ;)