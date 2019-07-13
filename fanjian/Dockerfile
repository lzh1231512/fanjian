FROM microsoft/aspnetcore:2.2
WORKDIR /dotnet
EXPOSE 5005
COPY ./Release/fanjian .
ENTRYPOINT ["dotnet", "fanjian.dll"]
