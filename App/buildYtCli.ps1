$t = "ytnetworks.azurecr.io/ytnetworks:latest"
docker build -t $t .

#$cs = [Environment]::GetEnvironmentVariable("YtNetworks_AzureStorageCs", "User")

#dotnet pack -o ./publish
#dotnet publish -o ./publish -c Release --runtime linux-x64 --self-contained
#docker tag ytnetworks/ytnetworks ytnetworks.azurecr.io/ytnetworks:latest
#docker run -it -e YtNetworks_AzureStorageCs=$cs $t
#docker push $t
