FROM kevin:coreclr

RUN apt-get install -y git openssl libcurl3

RUN mkdir /usr/aspnet-app
WORKDIR /usr/aspnet-app
RUN git clone https://github.com/dankydoo/ContainerDemo.git

RUN apt-get remove git -y

WORKDIR /usr/aspnet-app/docker-demo/ContainerDemo
RUN dot net restore
ENTRYPOINT ["dotnet", "web"]
