# Web Installation Guide

## Install .net core 3.0

Follow this official article:

https://dotnet.microsoft.com/download/linux-package-manager/ubuntu18-04/sdk-current

## Install Nginx(Ubuntu)

```
sudo apt-get update
sudo apt-get install nginx
```

Modify the default web settings.

```
sudo vim /etc/nginx/sites-available/default
```

Input the following to the above file.
```
server {
    listen        80;
    server_name   *.example.com;
    location / {
        proxy_pass         http://localhost:5000;
        proxy_http_version 1.1;
        proxy_set_header   Upgrade $http_upgrade;
        proxy_set_header   Connection keep-alive;
        proxy_set_header   Host $host;
        proxy_cache_bypass $http_upgrade;
        proxy_set_header   X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header   X-Forwarded-Proto $scheme;
    }
}
```

Retart nginx.
```
sudo systemctl restart nginx
```


## Install this Application(Ubuntu)

It is simple, just copy and unzip this application and run the following.

```
nohup dotnet VpnDiy.Web.dll
```

I tried many means, this way, we can start the web under the current user instead of **www-data**.



Reference:

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-3.0

https://www.nginx.com/resources/wiki/start/topics/tutorials/install/#official-debian-ubuntu-packages

https://serverfault.com/questions/424452/nginx-enable-site-command
