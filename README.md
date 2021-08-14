# OculusPassthroughDemos
Demos with Oculus Passthrough API from tutorials done in [YouTube](https://www.youtube.com/dilmerv)

***Step By Step YouTube Tutorial Available*** :rocket: [Here](https://www.youtube.com/watch?v=SJANudr3Wu0) :exclamation:

- Passthrough API Demo:
<img src="https://github.com/dilmerv/OculusPassthroughDemos/blob/master/docs/images/OculusPassthroughAPI_1.gif" width="300">

# Requirements
1. Unity 2019 LTS or greater :heavy_check_mark:
2. Unity Oculus Integration [v31](https://developer.oculus.com/downloads/package/unity-integration-archive/) or greater :heavy_check_mark:
3. Oculus Device Software v31 or greater :heavy_check_mark:

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
10. Look at this [Oculus forum thread](https://forums.oculusvr.com/t5/Oculus-Quest-Development/Oculus-Integration-31-0-Passthrough-API-does-not-work/m-p/880623/) with community solutions and issues reported
Submit an issue if you encounter any problems.

# References

1. Passthrough API Oculus [docs](https://developer.oculus.com/experimental/passthrough-api/)
2. Passthrough API Samples [docs](https://developer.oculus.com/experimental/passthrough-samples/)

# How To Record :video_camera: Mixed Reality Experiences ?
You may have noticed that black background when recording MR with Oculus Quest 2, well you're not alone, that is actually by design - so how can you record the cool experiences you will be building then? See steps:

1. Download the [Mixed Reality Capture] app onto your Oculus Quest 2
2. Open the app and write down the IP Address
3. Download the (MRC) Mixed Reality Capture Tool and OBI Studio software as indicated [here](https://creator.oculus.com/mrc/)
4. You will need a Webcam record your experiences. The [Logitech BRIO Ultra HD](https://amzn.to/3g4OCkb) which is what I used in YouTube (The webcam will be calibrated with (MRC) and then OBI has all the tools needed to send the info from the Oculus Quest to OBI for recording)
