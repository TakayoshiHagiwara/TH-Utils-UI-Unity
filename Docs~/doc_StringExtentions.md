# TH-Utils-UI-Unity/TH.Utils.UI.StringExtentions class<!-- omit in toc -->
<img src="https://img.shields.io/badge/Unity-2021 or Later-blue?&logo=Unity"> <img src="https://img.shields.io/badge/License-MIT-green">


# Table Of Contents <!-- omit in toc -->
<details>
<summary>Details</summary>

- [Definition](#definition)
- [Methods](#methods)
  - [RandomString(int)](#randomstringint)
    - [Parameters](#parameters)
    - [Returns](#returns)
  - [Shuffle(this string)](#shufflethis-string)
    - [Parameters](#parameters-1)
    - [Returns](#returns-1)
</details>


# Definition
Namespace: TH.Utils

文字列に関する静的メソッドを提供します。

# Methods
<!-- -------------------------------------------------- -->
## RandomString(int)
ランダムな文字列を返します。
半角アルファベット（大文字、小文字）、数字の中からランダムな文字列を生成します。


```csharp
public static string RandomString(int len = 5)
```

### Parameters
- `len`: int
  - 文字列の長さ。

### Returns
- string
  - ランダムな文字列。

<!-- -------------------------------------------------- -->
## Shuffle(this string)
文字列をシャッフルします。


```csharp
public static string Shuffle(this string text)
```

### Parameters
- `text`: string
  - シャッフルする文字列。

### Returns
- string
  - シャッフルされた文字列。
