FROM ubuntu:18.04
RUN apt-get update && apt-get install apache2 && apt-get clean
EXPOSE 8080
ENTRYPOINT ["apache2ctl"]
