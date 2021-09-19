# RemCon
Blazor web portal to remotely control some aspects of the host machine. Currently limited to:
- Default output audio device
- System volume

## Requirements

### Running
- [NirCmd](https://www.nirsoft.net/utils/nircmd.html) with `appsettings.json`>`RemConConfig`>`NirCmdExeLocation` updated with it's full path
- Update `appsettings.json`>`RemConConfig`>`Audio Devices` with a list of names of devices you wish to switch between 

### Build
- All running requirements
- .NET 5 (or above) SDK

