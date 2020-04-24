# instrução FROM
# definindo a imagem base da compilação
# para uma construção sem imagem base usa-se FROM scratch
# padrão do Dockerfile sempre é uma INSTRUÇÃO e um VALOR
# como visto abaixo
FROM ubuntu:18.04

# instrução COPY
# adiciona arquivos do diretorio para construção de imagem
COPY ./Teste /home/

# instrução ADD
# semelhante ao COPY pode referenciar um diretorio remoto
# ADD https://<url>/meu-arquivo.txt

# instrução LABEL
# adiciona metadados como autorização, chaves etc...
LABEL version="1.0"
# instrução WORKDIR
# informa o diretorio para execução de qualquer comando RUN, CMD, ENTRYPOINT
# WORKDIR /

# instrução RUN
# aqui podemos instalar várias coisas, NIGNX, GOLANG etc...
# pode haver várias desta instrução
# a instrução para executar algum comando em cima do S.O da imagem criada
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*
# instrução ENV
# indica variaveis de ambiente
ENV HelloWorld_Author="Alex Galante" \
    HelloWord_Version="1.0"

# só pode haver apenas uma instrução CMD por Dockerfile
# neste comando abaixo e como se estivemos abrindo o shell e executando echo Hello World
# pode ser usado assim:
#   CMD echo Teste (Shell Form)
#   CMD ["echo", "Teste"] (Exec Form)
CMD ["echo", "Hello World!"]

# instrução ENTRYPOINT
# indica invocavel ao executar o container semelhante ao CMD
# não pode ser sobrescrita
# todos os parametros passados via docker run são passados como parametros do ENTRYPOINT
# ENTRYPOINT ["/app/minha_app.exe"]

# instrução EXPOSE
# indica a porta que voce deseja expor a imagem
# ele pode ser subtituida se pessoa que executar a imagem especificar a porta
# exemplo: docker run helloworld -p 80:80
EXPOSE 80/tcp 

# para construir essa imagem basta executar docker build -t helloworld:0.1 .
# para executar docker run helloworld
# será printado no console a palavra HELLO WORLD



