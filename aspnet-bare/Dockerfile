FROM ubuntu:trusty

MAINTAINER BOOF

RUN echo 'debconf debconf/frontend select Noninteractive' | debconf-set-selections

RUN apt-get update
RUN apt-get install curl -y

RUN curl -sL https://deb.nodesource.com/setup_4.x | bash -

RUN apt-get install aptitude -y
RUN aptitude install nodejs -y
RUN aptitude install npm -y

RUN npm install -g gulp
