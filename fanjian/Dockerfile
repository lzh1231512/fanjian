FROM microsoft/aspnetcore:2.2
WORKDIR /dotnet
EXPOSE 5004
COPY ./Release/fanjian .
ENTRYPOINT ["dotnet", "fanjian.dll"]
