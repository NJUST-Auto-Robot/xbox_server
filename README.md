<!--
 * @Author: skybase
 * @Date: 2025-02-20 14:30:26
 * @LastEditors: skybase
 * @LastEditTime: 2025-02-20 14:33:10
 * @Description:  ?(???)??
 * @FilePath: \undefinedd:\Project\Host_project\xbox_server\README.md
-->

# 帧格式

| 字段名 | head                        | lt_x          | lt_y          | rt_x          | rt_y          | ltrig    | rtrig    | btns                                                   | ddr16        |
| ------ | --------------------------- | ------------- | ------------- | ------------- | ------------- | -------- | -------- | ------------------------------------------------------ | ------------ |
| 类型   | uint16_t                    | int16_t       | int16_t       | int16_t       | int16_t       | uint8_t  | uint8_t  | uint16_t                                               | uint16_t     |
| 说明   | 帧头标识符，固定为 `0xFB7A` | 左摇杆 X 坐标 | 左摇杆 Y 坐标 | 右摇杆 X 坐标 | 右摇杆 Y 坐标 | 左触发器 | 右触发器 | 按键状态，使用 `GamepadButtonFlags` 枚举值（按位标志） | ddr16 校验位 |

# 按键枚举值

| 按键            | 十六进制值 | 说明       |
| --------------- | ---------- | ---------- |
| `None`          | `0x0000`   | 无按键按下 |
| `DPadUp`        | `0x0001`   | 十字键向上 |
| `DPadDown`      | `0x0002`   | 十字键向下 |
| `DPadLeft`      | `0x0004`   | 十字键向左 |
| `DPadRight`     | `0x0008`   | 十字键向右 |
| `Start`         | `0x0010`   | 启动按钮   |
| `Back`          | `0x0020`   | 返回按钮   |
| `LeftThumb`     | `0x0040`   | 左摇杆按下 |
| `RightThumb`    | `0x0080`   | 右摇杆按下 |
| `LeftShoulder`  | `0x0100`   | 左肩按钮   |
| `RightShoulder` | `0x0200`   | 右肩按钮   |
| `A`             | `0x1000`   | A 按钮     |
| `B`             | `0x2000`   | B 按钮     |
| `X`             | `0x4000`   | X 按钮     |
| `Y`             | `0x8000`   | Y 按钮     |
