# TH-Utils-UI-Unity/TH.Utils.UI.JapaneseTraditionalColors class<!-- omit in toc -->
<img src="https://img.shields.io/badge/Unity-2021 or Later-blue?&logo=Unity"> <img src="https://img.shields.io/badge/License-MIT-green">


# Table Of Contents <!-- omit in toc -->
<details>
<summary>Details</summary>

- [Definition](#definition)
- [Sub class](#sub-class)
  - [RedFamily](#redfamily)
    - [Sakura](#sakura)
  - [YellowFamily](#yellowfamily)
  - [OrangeFamily](#orangefamily)
  - [GreenFamily](#greenfamily)
  - [BlueFamily](#bluefamily)
  - [PurpleFamily](#purplefamily)
  - [BrownFamily](#brownfamily)
  - [WhiteFamily](#whitefamily)
  - [BlackFamily](#blackfamily)
- [References](#references)
</details>


# Definition
Namespace: TH.Utils.UI

日本の伝統色に関する静的プロパティを提供します。
伝統色については同じ名前でも文献によって値が少し異なる場合があるため、ここで示しているものはおおよその色であり、一例です。
基本的には[こちら](https://www.colordic.org/w)を参照し、異なる場合は一部[Wikipedia](https://en.wikipedia.org/wiki/Traditional_colors_of_Japan)を参照しています。

（数が多いのでドキュメントを後回しにしています）

# Sub class
全465色を、本スクリプトの著者が直感でおおまかな色に分類したものです。
実際に得られるColorは、表示されているRGBAを255で割って正規化したものです。

<!-- -------------------------------------------------- -->
## RedFamily
主に赤系統の色を提供します。
<!-- -------------------------------------------------- -->
### Sakura
桜色のColorを返します。
- RGBA: 254, 238, 237, 255
- HEX: #feeeed

```csharp
public static Color Sakura
```

## YellowFamily
主に黄色系統の色を提供します。

## OrangeFamily
主にオレンジ系統の色を提供します。

## GreenFamily
主に緑系統の色を提供します。

## BlueFamily
主に青系統の色を提供します。

## PurpleFamily
主に紫系統の色を提供します。

## BrownFamily
主に茶系統の色を提供します。

## WhiteFamily
主に白系統の色を提供します。

## BlackFamily
主に黒系統の色を提供します。


# References
- https://en.wikipedia.org/wiki/Traditional_colors_of_Japan
- https://www.colordic.org/w
