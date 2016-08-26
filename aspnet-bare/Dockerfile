FROM microsoft/dotnet:1.0.0-preview1

MAINTAINER BOOF
RUN echo 'debconf debconf/frontend select Noninteractive' | debconf-set-selections

RUN apt-get remove curl -y
RUN apt-get update
RUN apt-get install apt-utils -y
RUN apt-get install curl -y
