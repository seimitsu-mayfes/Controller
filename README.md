コントローラー（Logicool F310）の入力をUnityで取得するやつ

必要な設定
〇コントローラーの背面のつまみをXの方にする。

〇Edit->Project Settings->Input Managerとして、Input Managerを開く。
　以下の軸を作成し、設定する。（）内の物は設定しなくていいかも。
　・Horizontal （左スティックの左右、float型、左が正）
　Name : Horizontal
　（Gravity : 0）
　（Dead : 0.19）
　（Sensitivity : 1）
　Invert : チェックを入れる
  Type : Joystick Axis
  Axis : X Axis
　（Joy Num : Get Motion ～）
　他空白

　・Vertical （左スティックの上下、float型、上が正）
　Name : Vertical
　（Gravity : 0）
　（Dead : 0.19）
　（Sensitivity : 1）
　Invert : チェックを入れる
　Type : Joystick Axis
　Axis : Y Axis
　（Joy Num : Get Motion ～）
　他空白

　・Fire1 （Aボタン、bool型）
　 Name : Fire1
　 Positive Button : joystick button 0
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　他空白またはデフォルトのまま

　・Fire2 （Bボタン、bool型）
　Name : Fire2
　Positive Button : joystick button 1
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　他空白またはデフォルトのまま

　・Fire3 （Xボタン、bool型）
　Name : Fire3
　Positive Button : joystick button 2
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　他空白またはデフォルトのまま

　・Fire4 （Yボタン、bool型）
　Name : Fire4
　Positive Button : joystick button 3
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　他空白またはデフォルトのまま

　・DPadHorizontal（十字キーの左右、float型、左が正）
　Name : DPadHorizontal
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　Invert : チェックを入れる
　Type : Joystick Axis
　Axis : 6th Axis
　（Joy Num : Get Motion ～）
　他空白

　・DPadVertical（十字キーの上下、float型、下が正）
　Name : DPadVertical
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　Invert : チェックを入れる
　Type : Joystick Axis
　Axis : 7th Axis
　（Joy Num : Get Motion ～）
　他空白

　・L1 （LBボタン、bool型）
　Name : L1
　Positive Button : joystick button 4
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　他空白またはデフォルトのまま

　・L2 （LTボタン、float型、押していない時は-1、押しているときは1）
　Name : L2
　（Gravity : 1000）
　（Dead : 0.001）
　（Sensitivity : 1000）
　Invert : チェックを入れる
　Type : Joystick Axis
　Axis : 3rd Axis
　（Joy Num : Get Motion ～）
　他空白

（十字キーとスティックの正の方向は間違ってるかも）