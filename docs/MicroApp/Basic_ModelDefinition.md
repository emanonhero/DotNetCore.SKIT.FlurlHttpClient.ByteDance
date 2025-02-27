﻿## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，发送订阅消息的请求是 `AppsMessageCustomSendRequest`，响应是 `AppsMessageCustomSendResponse`，接口是 `ExecuteAppsMessageCustomSendAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发送订阅消息，它的接口地址是 `[POST] /apps/message/custom/send`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。如果路由中带有版本信息，那么版本号一般都在结尾处，例如接口 `[POST] /v2/tags/image` 对应的是 `TagsImageV2`。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.Api/Models_、_src/SKIT.FlurlHttpClient.ByteDance.Api/SDK/ProductApi/Models_、_src/SKIT.FlurlHttpClient.ByteDance.Api/SDK/OpenApi/Models_ 目录。

---

### 字节小程序开放平台 API 支持情况：

#### 1. 小程序

<details>

<summary>[展开查看]</summary>

|     |                字节 API                |         备注         |
| :-: | :------------------------------------: | :------------------: |
|  √  |              接口调用凭证              |                      |
|  √  |                  登录                  |                      |
|  √  |                数据缓存                |                      |
|  √  |                  分享                  |                      |
|  √  |                  客服                  |                      |
|  ×  |          <del>交易系统</del>           | 异构协议，需独立模块 |
|  √  |                 二维码                 |                      |
|  √  |                内容安全                |                      |
|  √  |                 课程库                 |                      |
|  √  |                担保支付                |                      |
|  √  |                  评价                  |                      |
|  √  |                订阅消息                |                      |
|  √  |         其它：直播间自定义封面         |                      |
|  √  | 其它：抖音开放平台与小程序视频打通能力 |                      |
|  √  |             小程序推广计划             |                      |
|  √  |                  挂载                  |                      |
|  √  |                  分发                  |                      |
|  √  |             引导关注抖音号             |                      |
|  √  |                数据分析                |                      |

</details>

#### 2. 小游戏

<details>

<summary>[展开查看]</summary>

|     |   字节 API   | 备注 |
| :-: | :----------: | :--: |
|  √  | 接口调用凭证 |      |
|  √  |     登录     |      |
|  √  |   数据缓存   |      |
|  √  |    二维码    |      |
|  √  |   订阅消息   |      |

</details>

#### 3. 服务商平台

<details>

<summary>[展开查看]</summary>

|     |        字节 API        | 备注 |
| :-: | :--------------------: | :--: |
|  √  |      授权相关接口      |      |
|  √  |      域名相关接口      |      |
|  √  |      模板管理接口      |      |
|  √  |    代商家管理小程序    |      |
|  √  |    代商家管理小程序    |      |
|  √  | 代商家入驻抖音开放平台 |      |

</details>
