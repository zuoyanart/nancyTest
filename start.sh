supervisor -e 'cs' -x xbuild WebApplication1.sln

nohup fastcgi-mono-server4 /applications=/:/home/data/host/zuoyan/dotnet/cms /socket=tcp:127.0.0.1:9000 &
