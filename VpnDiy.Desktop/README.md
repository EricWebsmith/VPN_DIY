# AWS EC2 Manager for Windows (AEMW)

This tool is to start, stop and connect AWS EC2 servers.
And after restarting an EC2 server, restart Shadowsocks.

![AWS EC2 Manager for Windows](https://github.com/juwikuang/VPN_DIY/blob/master/VpnDiy.Desktop/Resources/screenshot.png?raw=true)

# AWS CLI
I suppose you already have an AWS account. 

In order to use this tool, you need to visit AWS Console page and go to IAM (Identity and Access Management), create a user with proper access.

You need to install **the AWS CLI on Windows** following this document:
[https://docs.aws.amazon.com/cli/latest/userguide/install-windows.html](https://docs.aws.amazon.com/cli/latest/userguide/install-windows.html)

After installation, type 

```
aws configure
```

Keys will be asked. 

For **Default output format**, you need to type **json**

```
(base) C:\Users\eric>aws configure
AWS Access Key ID [****************XABG]:
AWS Secret Access Key [****************eMrX]:
Default region name [us-west-1]:
Default output format [json]:
```

## Dotnet Core 3.0
https://dotnet.microsoft.com/download/dotnet-core/3.0

## This

Now you can install this tool:

[https://github.com/juwikuang/AwsEc2_Shadowsocks_Manager/releases](https://github.com/juwikuang/AwsEc2_Shadowsocks_Manager/releases)


As you can see, the limited functions of this tool is observed by the picture. You need to create your machines by other means. This tool is only for start, stop and connect EC2 servers.
