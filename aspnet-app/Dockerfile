FROM kevin:coreclr


RUN echo 'debconf debconf/frontend select Noninteractive' | debconf-set-selections

RUN apt-get install curl openssl -y
RUN apt-get install -y git

RUN mkdir /usr/aspnet-app
WORKDIR /usr/aspnet-app
RUN git clone https://github.com/dankydoo/docker-demo.git

RUN apt-get remove git -y

WORKDIR /usr/aspnet-app/docker-demo/ContainerDemo
RUN dotnet restore
RUN dotnet build
ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]

EXPOSE 5000
