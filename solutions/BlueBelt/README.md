# Blue Belt Exercises

Solve and test the issues of this project without configuring your local environment.

<img src="docs/solution.png" width=500/>

## Setup

1. Create a test project
2. Add your favorite test technologies

## Issues

- Find and solve the problem in CPF validation
- Find and solve the problem in data persistence

## Testing

```s
dotnet restore
dotnet test
```

### Integrated

**RabbitMQ**

```s
# Management user/pass is "guest/guest"
sudo docker run -d --hostname dojo-rabbit --name dojo-rabbit -p 5672:5672 -p 15672:15672 rabbitmq:3-management
```