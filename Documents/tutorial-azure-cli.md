# Deploying App Service By Using Azure CLI
Azure CLI is a powerful tool that allows you to manage Azure resources directly from the command line. In this guide, we will walk through the steps to deploy an App Service on Azure, including creating an App Service plan and deploying a Web App.

## Create App Service Plan
```sh
az appservice plan create -g jjpuente -n webplan --sku B1
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the App Service plan will be created.
- `-n webplan` or `--name webplan`: Specifies the name of the App Service plan to be created.
- `--sku B1`: Specifies the pricing tier for the App Service plan. `B1` represents the Basic pricing tier.

## Create App Service
```sh
az webapp up -g jjpuente -p webplan -n webapi -r "dotnet:8" --logs
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the Web App will be created.
- `-p webplan` or `--plan webplan`: Specifies the name of the App Service plan to use.
- `-n webapi` or `--name webapi`: Specifies the name of the Web App to be created.
- `-r "dotnet:8"` or `--runtime "dotnet:8"`: Specifies the runtime stack for the Web App. In this case, it is .NET version 8.
- `--logs`: Enables logging for the deployment process.

## Create App Service with Plan
```sh
az webapp up -g jjpuente -n webapi-allinone -r "dotnet:8" --sku B1 --logs
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the Web App will be created.
- `-n webapi-allinone` or `--name webapi-allinone`: Specifies the name of the Web App to be created.
- `-r "dotnet:8"` or `--runtime "dotnet:8"`: Specifies the runtime stack for the Web App. In this case, it is .NET version 8.
- `--sku B1`: Specifies the pricing tier for the App Service plan that will be created and used for the Web App. `B1` represents the Basic pricing tier.
- `--logs`: Enables logging for the deployment process.