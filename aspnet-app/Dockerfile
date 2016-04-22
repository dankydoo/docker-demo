FROM kevin:coreclr

RUN mkdir /usr/aspnet
WORKDIR /usr/aspnet
RUN git clone https://github.com/dankydoo/docker-demo/tree/master/ContainerDemo

WORKDIR /usr/aspnet/ContainerDemo
RUN dnu restore
ENTRYPOINT ["dnx", "web"]

EXPOSE 5000