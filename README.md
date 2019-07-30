# Psychological Assistance After Disaster using IBM Cloud Services and Unity
***
## Introduction
***
In the face of growing natural disasters, the project is dedicated to addressing the psychological reconstruction of children after disasters. We use the services provided on IBM cloud to achieve dialogue with children, with unity to build avatars, we hope that this avatar chat bot can help us better solve the psychological problems of children after the disaster, and through chat data to make a psychological assessment of children in the region.
## Included Components 
***
- [IBM Cloud Watson Assistant](https://cloud.ibm.com/catalog?search=label:%E8%BD%BB%E9%87%8F&category=ai)
- [IBM Cloud Speech to Text](https://cloud.ibm.com/catalog?search=label:%E8%BD%BB%E9%87%8F&category=ai)
- [IBM Cloud Text to Speech](https://cloud.ibm.com/catalog?search=label:%E8%BD%BB%E9%87%8F&category=ai)
- [IBM Cloud Tone Analyzer](https://cloud.ibm.com/catalog?search=label:%E8%BD%BB%E9%87%8F&category=ai)
- [Unity](https://unity.cn/)

## Setup
download "demo-win_64.rar"
***
### Dependency

- unity v2018.1.3+
- node v7.0+  

**Go** to [download unity](https://unity.cn/)

!["download"](img/p1.PNG)

**Use**
```bash
npm install  
npm start
```
to get node installed at your computer

**OR**

go to [NODEJS](https://nodejs.org/en/) to get the archive

## Code structure
    
    |  demo.exe  
    │  UnityCrashHandler64.exe  
    │  UnityPlayer.dll  
    |  WinPixEventRuntime.dll  
    │  
    ├─MonoBleedingEdge  
    │  ├─EmbedRuntime  
    |  └─etc  
    │      └─mono  
    └─demo_Data
    │  app.info
    .......
    |
    |
    │      IBM.Cloud.SDK.dll  
    │      UnityEngine.WindModule.xml  
    |   
    ├─Plugins  
    │      libflac-8.dll  
    ......
    │      libgcc_s_sjlj-1.dll

    │      
    └─Resources
            unity default resources
            unity_builtin_extra

## Run locally

click **demo.exe**.
## Features 

* Chat with children easily with avatar

![picture](img/P3.PNG)
* Analyze user sentiment based on chat content

![PICTURE](img/P5.PNG)
* Visualization and prediction of regional emotional problems(under development)

![PICTURE](img/P6.jpg)
## Feedback
*Contact us through email*  2477802179@qq.com

## License

This code pattern is licensed under the Apache Software License, Version 2.  Separate third party code objects invoked within this code pattern are licensed by their respective providers pursuant to their own separate licenses. Contributions are subject to the [Developer Certificate of Origin, Version 1.1 (DCO)](https://developercertificate.org/) and the [Apache Software License, Version 2](https://www.apache.org/licenses/LICENSE-2.0.txt).

[Apache Software License (ASL) FAQ](https://www.apache.org/foundation/license-faq.html#WhatDoesItMEAN)
## Links

* [IBM Cloud Docs](https://cloud.ibm.com/docs/)
* [Code Pattern](https://developer.ibm.com/cn/patterns/)


