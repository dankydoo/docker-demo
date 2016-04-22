FROM kevin:coreclr

RUN mkdir /usr/aspnet
WORKDIR /usr/aspnet
RUN git clone https://github.com/dankydoo/ContainerDemo.git

WORKDIR /usr/aspnet/ContainerDemo
RUN git checkout demo-sqlserver
RUN dnu restore
ENTRYPOINT ["dnx", "web"]

EXPOSE 5000