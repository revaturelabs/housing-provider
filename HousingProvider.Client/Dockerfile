FROM node:latest
WORKDIR /app
COPY . /app
EXPOSE 8000
RUN npm install --global http-server
# RUN npm install
# RUN npm run build
CMD ["npm", "start"]
