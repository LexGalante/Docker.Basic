FROM node:10
WORKDIR /build

COPY package*.json ./
RUN npm install

COPY . .

EXPOSE 9090
CMD [ "node", "index.js" ]