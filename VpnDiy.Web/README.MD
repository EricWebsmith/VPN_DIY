


Reference:

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-3.0

https://www.nginx.com/resources/wiki/start/topics/tutorials/install/#official-debian-ubuntu-packages


<Directory /var/www//>
        Options Indexes MultiViews
        AllowOverride None
        Require all granted
</Directory>

```xml
<VirtualHost *:*>
    RequestHeader set "X-Forwarded-Proto" expr=%{REQUEST_SCHEME}
</VirtualHost>

<VirtualHost *:81>
    ProxyPreserveHost On
    ProxyPass / http://127.0.0.1:5000/
    ProxyPassReverse / http://127.0.0.1:5000/
    ServerName sufan_news.tvshowwords.com
    ServerAlias *.tvshowwords.com
    ErrorLog ${APACHE_LOG_DIR}helloapp-error.log
    CustomLog ${APACHE_LOG_DIR}helloapp-access.log common
</VirtualHost>
```


```
sudo vim /etc/systemd/system/kestrel-vpndiy.service
```

```
[Unit]
Description=Example .NET Web API App running on Ubuntu

[Service]
WorkingDirectory=/var/www/VpnDiy
ExecStart=/usr/bin/dotnet /var/www/VpnDiy/VpnDiy.Web.dll
Restart=always
# Restart service after 10 seconds if the dotnet service crashes:
RestartSec=10
KillSignal=SIGINT
SyslogIdentifier=dotnet-example
User=www-data
Environment=ASPNETCORE_ENVIRONMENT=Development
Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

[Install]
WantedBy=multi-user.target
```

Production


```
sudo systemctl enable kestrel-vpndiy.service
```


```
sudo systemctl start kestrel-vpndiy.service
sudo systemctl status kestrel-vpndiy.service
```