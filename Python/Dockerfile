FROM python:alpine3.7

RUN pip install --upgrade pip

# camada de instalaçao de dependencias PIP
COPY ./requirements.txt /app/requirements.txt
WORKDIR /app
RUN pip install -r requirements.txt

COPY . ./app
EXPOSE 8080

CMD ["python", "./app/api.py"]
