FROM kevin:coreclr

RUN apt-get install git -y

RUN mkdir /usr/aspnet
WORKDIR /usr/aspnet
RUN git clone https://github.com/dankydoo/ContainerDemo.git

RUN apt-get remove git -y

WORKDIR /usr/aspnet/ContainerDemo
RUN dotnet restore
ENTRYPOINT ["dotnet", "web"]

EXPOSE 80
