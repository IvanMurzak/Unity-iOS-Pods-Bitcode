# Unity iOS Pods Bitcode

[![OpenUPM](https://img.shields.io/npm/v/com.github.ivanmurzak.ios.pods.bitcode?label=OpenUPM&registry_uri=https://package.openupm.com&labelColor=333A41 'OpenUPM package')](https://openupm.com/packages/com.github.ivanmurzak.ios.pods.bitcode/)
[![r](https://github.com/IvanMurzak/Unity-iOS-Pods-Bitcode/workflows/release/badge.svg 'Release')](https://github.com/IvanMurzak/Unity-iOS-Pods-Bitcode/actions/workflows/release.yml)
[![OpenUPM](https://img.shields.io/badge/dynamic/json?labelColor=333A41&label=Downloads&query=%24.downloads&suffix=%2Fmonth&url=https%3A%2F%2Fpackage.openupm.com%2Fdownloads%2Fpoint%2Flast-month%2Fcom.github.ivanmurzak.ios.pods.bitcode)](https://openupm.com/packages/com.github.ivanmurzak.ios.pods.bitcode/)
[![Stars](https://img.shields.io/github/stars/IvanMurzak/Unity-iOS-Pods-Bitcode 'Stars')](https://github.com/IvanMurzak/Unity-iOS-Pods-Bitcode/stargazers)
[![License](https://img.shields.io/github/license/IvanMurzak/Unity-iOS-Pods-Bitcode?label=License&labelColor=333A41)](https://github.com/IvanMurzak/Unity-iOS-Pods-Bitcode/blob/main/LICENSE)
[![Stand With Ukraine](https://raw.githubusercontent.com/vshymanskyy/StandWithUkraine/main/badges/StandWithUkraine.svg)](https://stand-with-ukraine.pp.ua)

![image](https://user-images.githubusercontent.com/9135028/205457956-691ac3cd-e9fa-4f97-883f-7f2c7a392c8d.png)

Unity iOS post process for forcing Pods to have Bitcode property YES/NO. You can control bitcode status for all pods from single place. Highly usable with CI.

# Installation

### Option 1 - Installer

- **[⬇️ Download Installer](https://github.com/IvanMurzak/Unity-iOS-Pods-Bitcode/releases/latest/download/iOS-Pods-Bitcode-Installer.unitypackage)**
- **📂 Import installer into Unity project**
  > - You may use double click on the file - Unity will open it
  > - OR: You may open Unity Editor first, then click on `Assets/Import Package/Custom Package`, then choose the file

### Option 2 - OpenUPM-CLI

- [⬇️ Install OpenUPM-CLI](https://github.com/openupm/openupm-cli#installation)
- 📟 Open command line in Unity project folder

```bash
openupm add com.github.ivanmurzak.ios.pods.bitcode
```

### Option 3 - Manual (manifest.json)

- Add this code to `/Packages/manifest.json`

```json
{
  "dependencies": {
    "com.github.ivanmurzak.ios.pods.bitcode": "1.0.0"
  },
  "scopedRegistries": [
    {
      "name": "package.openupm.com",
      "url": "https://package.openupm.com",
      "scopes": [
        "com.github.ivanmurzak"
      ]
    }
  ]
}
```

# Usage

By default the package does nothing. To activate it you need to `PODS_BITCODE_NO` or `PODS_BITCODE_YES` environment variable in Unity Project Settings. If environment variable exists in postprocess stage of project building all pods bitcode will be forced to choosen value.

![image](https://user-images.githubusercontent.com/9135028/205459373-dccceb28-81ca-4413-802c-5d5a658e763c.png)
