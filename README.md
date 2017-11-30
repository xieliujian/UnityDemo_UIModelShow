# UnityDemo_UIModelShow

****
### Author : Xieliujian
### E-mail : 377624289@qq.com
****

<h2 id="Demo4">UIModelShow的Demo展示王者荣耀ui中显示3d模型的方法</h2>

* a, 效果图如下:
![效果图](https://github.com/xieliujian/UnityDemo_UIModelShow/blob/master/Snapshot/UIModelShow/UIModelShow.png)

* b, 功能说明:  
这个Demo展示王者荣耀ui中显示3d模型的方法
![效果图](https://github.com/xieliujian/UnityDemo_UIModelShow/blob/master/Snapshot/UIModelShow/MainCam.png)
![效果图](https://github.com/xieliujian/UnityDemo_UIModelShow/blob/master/Snapshot/UIModelShow/UIModelCam.png)
![效果图](https://github.com/xieliujian/UnityDemo_UIModelShow/blob/master/Snapshot/UIModelShow/UICam.png)
如上面3张截图所示，技术点在Camera的Depth分层和Culling Mask的Layer剔除, MainCam先渲染，渲染的是场景内的物体（但不包括ui和uimodel层）, 然后渲染UIModelCam, 只渲染uimodelcam层的物体，最后渲染ui，这样就是实现王者荣耀ui的模型显示的方法
****
