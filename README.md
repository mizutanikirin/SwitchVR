# SwitchVR
SwitchVRはAndroidでノーマルビューとVRビューの切り替えができるAssetです。
![0](https://user-images.githubusercontent.com/4795806/78230258-0a3c4200-750c-11ea-8a31-011ebba47e7b.png)

[開発環境]  
Windows10 Pro  
Unity 2018.3.14f1

# 使い方
### 1. SwitchVRの準備
1. [SwitchVR.unitypackage](https://github.com/mizutanikirin/SwitchVR/releases/tag/ver1.0.0)をプロジェクトにインポートする。
2. Assets/SwitchVR/DemoSwitchVR.unityを開く。
3. SwitchVR(GameObject)をコピーして使いたいシーンへペーストする。
### 2. [Player Settings]設定をする。
![2](https://user-images.githubusercontent.com/4795806/78230327-2344f300-750c-11ea-84aa-2b8b8469a1ef.png)
1. Unity Editorで[Player Settings ... > Inspector > XR Settings]を表示させる。  
2. [Virtual Reality Supported]にチェックを入れる。  
3. [Virtual Reality SDKs]に[Cardbord]と[None]を追加する。  
  3.1. 起動時はVRモードでない場合: 一番上を[None]にして、そのあと[Cardbord]にする。  
  3.2. 起動時はVRモードである場合: 一番上を[Cardbord]にして、そのあと[None]にする。  

### 3. SwitchVRの設定をする。
![1](https://user-images.githubusercontent.com/4795806/78230137-e5e06580-750b-11ea-9d1e-605c28d315aa.png)

1. [Inspector > SwitchVR]で[DeviceName]の設定をする。
2. [Inspector > SwitchVR]で[InitXREnable]の設定をする。
  2.1. 起動時はVRモードでない場合: false
  2.2. 起動時はVRモードである場合: true
3. [Inspector > SwitchVR]で[InitXREnable]の設定をする。

### 7. コードを書く。
```
// Example
public SwitchVR switchVR;

void Update() {
    // 画面タッチで切り替え
    if (Input.GetMouseButtonDown(0)) {
        switchVR.ToggleXR();
    }
}
```
