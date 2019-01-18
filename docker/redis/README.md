# How to run
```sh
docker build -t lucian/redis .
docker run --name redis1 -d -p 6379:6379 --restart unless-stopped lucian/redis
```

or 

```sh
docker run --name redis1 -d -p 6379:6379 --restart unless-stopped redis:5.0.1-alpine
```