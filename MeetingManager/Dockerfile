FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

ENV POSTGRES_PASSWORD=/run/secrets/DBPASSWORD

FROM microsoft/dotnet:2.2-sdk AS build

WORKDIR /src

COPY MeetingManager.Service.Api/MeetingManager.Service.Api.csproj MeetingManager.Service.Api
COPY MeetingManager.Application/MeetingManager.Application.csproj MeetingManager.Application/
COPY MeetingManager.Domain/MeetingManager.Domain.csproj MeetingManager.Domain/
COPY MeetingManager.Infra.CC.EventBus/MeetingManager.Infra.CC.EventBus.csproj MeetingManager.Infra.CC.EventBus/
COPY MeetingManager.Infra.CC.Ioc/MeetingManager.Infra.CC.Ioc.csproj MeetingManager.Infra.CC.Ioc/
COPY MeetingManager.Infra.CrossCutting/MeetingManager.Infra.CrossCutting.csproj MeetingManager.Infra.CrossCutting
COPY MeetingManager.Infra.Data/MeetingManager.Infra.Data.csproj MeetingManager.Infra.Data/

COPY . .

WORKDIR /src/MeetingManager.Service.Api
RUN dotnet build MeetingManager.Service.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MeetingManager.Service.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MeetingManager.Service.Api.dll"]