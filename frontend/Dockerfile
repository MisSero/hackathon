FROM node:21 as node
WORKDIR /app
COPY . .

RUN npm install

RUN npm run build

FROM nginx:latest as nginx

COPY --from=node /app/dist /var/www