FROM node
MAINTAINER ian.miell@gmail.com
RUN git clone https://github.com/ianmiell/todo.git
WORKDIR todo
RUN npm install
EXPOSE 8000
CMD ["npm","start"]
