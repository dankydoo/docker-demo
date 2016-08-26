FROM ubuntu:trusty

MAINTAINER BOOF
RUN apt-get update
RUN apt-get install apt-transport-https -y

RUN sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ trusty main" > /etc/apt/sources.list.d/dotnetdev.list'
RUN apt-key adv --keyserver apt-mo.trafficmanager.net --recv-keys 417A0893
RUN apt-get update

RUN apt-get install dotnet-dev-1.0.0-preview2-003121 -y

ENV PATH $PATH:$DNX_USER_HOME/runtimes/default/bin
