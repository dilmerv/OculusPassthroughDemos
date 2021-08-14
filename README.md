# OculusPassthroughDemos
Demos with Oculus Passthrough API from tutorials done in [YouTube](https://www.youtube.com/dilmerv)

- Passthrough API Demo:
<img src="https://github.com/dilmerv/OculusPassthroughDemos/blob/master/docs/images/OculusPassthroughAPI_1.gif.gif" width="300">

# Requirements
1. Unity 2019 LTS or greater
2. Unity Oculus Integration [v31](https://developer.oculus.com/downloads/package/unity-integration-archive/) or greater
3. Oculus Device Software v31 or greater

# Troubleshooting (Steps Required)

1. Enable experimental Passthrough on the device by running the adb command:
   ```adb shell setprop debug.oculus.experimentalEnabled 1``` this command is required to be ran everytime you restart your Oculus device as it currently won't persist.
2. Oculus platform must be selected under XR Plug-in Management Android.
3. Change the script backend to IL2CPP and enable ARM64 as the only target architecture under player settings.
4. Change the "Color Space" to Linear 
5. Select "Switch To OVRPlugin With OpenXR Backend" under Oculus > Tools > OpenXR in the toolbar.
6. In the OVRCameraRig make sure to enable "Experimental Features Enabled" and "Passthrough Capability Enabled" 
7. Create a new Android Manifest and make sure it includes Passthrough experimental features.
8. In Oculus device settings make sure to have all Passthrough settings enabled as well.
9. Compare your settings with this project to make sure everything matches.

Submit an issue if you encounter any problems.