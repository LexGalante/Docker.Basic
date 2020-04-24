FROM ubuntu:18.04
RUN apt-get update && apt-get install iputils-ping -y
ENV teste=HELLOWORD \
    comando=ping \
    parametro=8.8.8.8

CMD ${comando} ${parametro}

# execute comando docker run -it /bin/bash
# execute comando env
# será impresso o valor da variavel