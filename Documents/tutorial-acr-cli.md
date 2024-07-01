az acr create -g jjpuente -n jjpuenteacr --sku Basic --admin-enabled

az acr login -n jjpuenteacr

docker tag webapi:latest jjpuenteacr.azurecr.io/webapi:latest
