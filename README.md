# Unity iOS Pods Bitcode

 [![openupm](https://img.shields.io/npm/v/com.github.ivanmurzak.ios.pods.bitcode?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.github.ivanmurzak.ios.pods.bitcode/) ![License](https://img.shields.io/github/license/IvanMurzak/Unity-iOS-Pods-Bitcode) [![Stand With Ukraine](https://raw.githubusercontent.com/vshymanskyy/StandWithUkraine/main/badges/StandWithUkraine.svg)](https://stand-with-ukraine.pp.ua)

![image](https://user-images.githubusercontent.com/9135028/205457956-691ac3cd-e9fa-4f97-883f-7f2c7a392c8d.png)

Unity iOS post process for forcing Pods to have Bitcode property YES/NO. You can control bitcode status for all pods from single place. Highly usable with CI.

# Installation 

- [Install OpenUPM-CLI](https://github.com/openupm/openupm-cli#installation)
- Open command line in Unity project folder
- `openupm add com.github.ivanmurzak.ios.pods.bitcode`

# Usage

By default the package does nothing. To activate it you need to `PODS_BITCODE_NO` or `PODS_BITCODE_YES` environment variable in Unity Project Settings. If environment variable exists in postprocess stage of project building all pods bitcode will be forced to choosen value.

![image](https://user-images.githubusercontent.com/9135028/205459373-dccceb28-81ca-4413-802c-5d5a658e763c.png)
