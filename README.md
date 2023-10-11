# TH-Utils-UI-Unity<!-- omit in toc -->
<img src="https://img.shields.io/badge/Unity-2021 or Later-blue?&logo=Unity"> <img src="https://img.shields.io/badge/License-MIT-green">

UnityにおけるUI関連のメソッドを扱います。
著者が個人的な開発を行っていた際に必要になったちょっとしたメソッドをまとめています。

# Table Of Contents <!-- omit in toc -->
<details>
<summary>Details</summary>

- [Environment](#environment)
- [Installation](#installation)
  - [Unity Package Manager経由での導入](#unity-package-manager経由での導入)
- [Description](#description)
  - [JapaneseTraditionalColors class](#japanesetraditionalcolors-class)
    - [Definition](#definition)
  - [StringExtentions class](#stringextentions-class)
    - [Definition](#definition-1)
    - [Methods](#methods)
- [References](#references)
- [Troubleshooting](#troubleshooting)
- [Versions](#versions)
- [Author](#author)
- [License](#license)
</details>


# Environment
- Unity 2021 or Later

# Installation
## Unity Package Manager経由での導入
1. Window -> Package Managerを開きます
2. 左上のプラスアイコンをクリックし、「Add package from git URL...」をクリックします
3. このリポジトリURLを入力し、addをクリックします


# Description
<!-- -------------------------------------------------- -->
## JapaneseTraditionalColors class
### Definition
- Namespace: TH.Utils.UI

日本の伝統色に関する静的プロパティを提供します。
伝統色については同じ名前でも文献によって値が少し異なる場合があるため、提供する値はおおよその色であり、一例です。
各色の詳細については[ドキュメント](/Docs~/doc_JapaneseTraditionalColors.md)を参照してください。



<!-- -------------------------------------------------- -->
## StringExtentions class
### Definition
- Namespace: TH.Utils

文字列に関する静的メソッドを提供します。

### Methods
| メソッド名 | 概要 |
| ---- | ---- |
| [RandomString(int)](/Docs~/doc_StringExtentions.md#randomstringint) | ランダムな文字列を返します。 |
| [Shuffle(this string)](/Docs~/doc_StringExtentions.md#shufflethis-string) | 文字列をシャッフルします。 |



# References


# Troubleshooting


# Versions
- [CHANGELOG](/CHANGELOG.md)


# Author
- Takayoshi Hagiwara
    - Toyohashi University of Technology


# License
- MIT License